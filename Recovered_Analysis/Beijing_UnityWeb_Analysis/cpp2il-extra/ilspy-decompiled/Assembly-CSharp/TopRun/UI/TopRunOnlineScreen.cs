using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Data.Managers;
using Info;
using Kiloo;
using Kiloo.Common.Backend.PurchaseValidation;
using Kiloo.Common.Extensions;
using Kiloo.Common.UI;
using SYBO.Common.Automation.Samplers;
using SYBO.Subway.Routes;
using SYBO.Subway.Routes.Builders;
using TopRun.Internal;
using UI;
using UI.FreeStuff;
using UI.Generic.Layout;
using UI.Screens;
using UI.Screens.NotEnoughCurrencyPopupInternal;
using UI.Screens.RewardManagement;
using UnityEngine;

namespace TopRun.UI;

public class TopRunOnlineScreen : UIScreen
{
	private class TopRunListAdapter : ListAdapter<TopRunCell>
	{
		private GameObject _playerPrefab;

		private GameObject _rankHeaderPrefab;

		private GameObject _spacePrefab;

		private GameObject _emptyCell;

		private const int PLAYER_PREFAB = 0;

		private const int RANK_PREFAB = 1;

		private const int SPACE_CELL = 2;

		private const int EMPTY_CELL = 3;

		private const int FACEBOOK_BUTTON = 4;

		public TopRunListAdapter(List<TopRunCell> topRunListT, GameObject playerCell, GameObject headerCell, GameObject spaceCell, GameObject emptyCellPrefab)
		{
			//IL_001b: Expected Obj, but got I
			//IL_002b: Expected Obj, but got I
			//IL_003c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0041: Expected Obj, but got Unknown
			//IL_004a: Unknown result type (might be due to invalid IL or missing references)
			//IL_004f: Expected Obj, but got Unknown
			//IL_005f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0064: Expected Obj, but got Unknown
			//IL_0072: Unknown result type (might be due to invalid IL or missing references)
			//IL_0077: Expected Obj, but got Unknown
			//IL_0085: Unknown result type (might be due to invalid IL or missing references)
			//IL_008a: Expected Obj, but got Unknown
			//IL_0098: Unknown result type (might be due to invalid IL or missing references)
			//IL_009d: Expected Obj, but got Unknown
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ S2_v2 (Il2CppMethodInfo)+C]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S2_v3+60]");
			object obj2 = 0;
			object obj3 = obj2;
			object obj4 = obj3 & 0x3FFF;
			object obj5 = obj4 + 97173;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v26 @ S3_v4 (should have been resolved before IL gen)");
			object obj6 = this + 20;
			obj6 = playerCell;
			object obj7 = this + 24;
			obj7 = headerCell;
			object obj8 = this + 28;
			obj8 = spaceCell;
			object obj9 = this + 16;
			obj9 = emptyCellPrefab;
		}

		public void SetNewDataList(List<TopRunCell> topRunListT)
		{
		}

		public override int GetModelType(int index)
		{
			//IL_0079: Expected I, but got Obj
			//IL_008f: Expected Obj, but got I
			//IL_00ba: Expected I, but got Obj
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [index @ L1 (System.Int32)+C]");
			if ((nint)0 != 2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [index @ L1 (System.Int32)+C]");
				if ((nint)0 != 5)
				{
					return 0;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [index @ L1 (System.Int32)+8]");
			if ((nint)0 != 0)
			{
				return 0;
			}
			nint num = (nint)typeof(BoardManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S2_v3 (Il2CppClass<Data.Managers.BoardManager>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(BoardManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S2_v8 (Il2CppClass<Data.Managers.BoardManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (TopRun.UI.TopRunOnlineScreen+TopRunListAdapter)+8]");
			nint num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [index @ L1 (System.Int32)+28]");
			bool flag = BoardManager.IsThemeActive((Boards.BoardId)num3, HoverboardThemes.ThemeIdentifier.none);
			return (flag ? 1 : 0) ^ 1;
		}

		public override Container GetContainer(Container container, int dataIndex, bool isMeasurePass = false)
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_0024: Expected Obj, but got I4
			object obj2 = default;
			object obj = obj2 + 8;
			obj = container;
			obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
			object obj3 = default;
			obj2 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120A3");
			Container result = default;
			return result;
		}
	}

	private sealed class _003CRefreshAdapterListDelayed_003Ed__48 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public int frames;

		public TopRunOnlineScreen _003C_003E4__this;

		private int _003Cframe_003E5__2;

		object IEnumerator<object>.Current
		{
			get
			{
				//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
				//IL_00ae: Expected Obj, but got Unknown
				//IL_00d4: Expected Obj, but got I4
				//IL_0134: Expected I4, but got Obj
				TopRunOnlineScreen topRunOnlineScreen = _003C_003E4__this;
				if (_003C_003E1__state != 0)
				{
					if (_003C_003E1__state != 1)
					{
						return null;
					}
					_003C_003E1__state = -1;
				}
				else
				{
					_003C_003E1__state = -1;
					_003Cframe_003E5__2 = 0;
				}
				if (_003Cframe_003E5__2 < frames)
				{
					int num = _003Cframe_003E5__2 + 1;
					_003Cframe_003E5__2 = num;
					object obj = this + 12;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
					object obj2 = default;
					obj = obj2;
					_003C_003E1__state = 1;
					return 1;
				}
				if (topRunOnlineScreen._adapter != null && topRunOnlineScreen._contentList != null)
				{
					((_003CRefreshAdapterListDelayed_003Ed__48)(object)topRunOnlineScreen._adapter)._002Ector((int)topRunOnlineScreen._contentList);
				}
				topRunOnlineScreen.RefreshOrFetchNewTournament();
				topRunOnlineScreen.loadingOverlay.tag = null;
				return null;
			}
		}

		object IEnumerator.Current => _003C_003E2__current;

		public _003CRefreshAdapterListDelayed_003Ed__48(int _003C_003E1__state)
		{
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0010: Expected Obj, but got Unknown
			//IL_0018: Expected Obj, but got I4
			object obj = this + 12;
			obj = _003C_003E1__state;
			((Container)this).hasTransientState = false;
		}

		void IDisposable.Dispose()
		{
			//IL_005b: Expected Obj, but got I4
			//IL_0061: Unknown result type (might be due to invalid IL or missing references)
			//IL_0066: Expected Obj, but got Unknown
			//IL_007d: Expected I, but got Obj
			//IL_0093: Expected Obj, but got I
			//IL_00b9: Expected Obj, but got VT
			//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
			//IL_00cb: Expected I4, but got Unknown
			//IL_0013: Expected I, but got Obj
			object obj = 0;
			object obj2 = this + 8;
			obj2 = "";
			nint num = (nint)typeof(DateTime);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v12 (Il2CppClass<System.DateTime>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num2 = (nint)typeof(DateTime);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v20 (Il2CppClass<System.DateTime>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			obj = DateTime.MinValue;
			int num3 = (int)(obj & 0x3FFFFFFFFFFFFFFFL);
			frames = num3;
			_003Cframe_003E5__2 = -1;
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

	private sealed class _003CAnimateMedalAfterSeconds_003Ed__49(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public float seconds;

		public TopRunOnlineScreen _003C_003E4__this;

		object IEnumerator<object>.Current
		{
			get
			{
				//IL_0042: Expected I, but got Obj
				//IL_0058: Expected Obj, but got I
				//IL_01fe: Unknown result type (might be due to invalid IL or missing references)
				//IL_0203: Expected Obj, but got Unknown
				//IL_021f: Expected Obj, but got I4
				//IL_0083: Expected I, but got Obj
				//IL_0121: Expected I, but got Obj
				//IL_0137: Expected Obj, but got I
				//IL_023d: Expected Obj, but got I4
				//IL_0162: Expected I, but got Obj
				//IL_01aa: Expected Obj, but got I4
				if (_003C_003E1__state != 0)
				{
					if (_003C_003E1__state == 1)
					{
						_003C_003E1__state = -1;
						ManagerData managerData = ((Manager)(object)_003C_003E4__this).managerData;
						if ((nint)managerData > -1)
						{
							int myIndexInTheList = _003C_003E4__this.GetMyIndexInTheList();
							nint num = (nint)typeof(UnityEngine.Object);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ S0_v40 (Il2CppClass<UnityEngine.Object>)+BA]");
							object obj = (nint)0 & (nint)0x200;
							if (obj != null)
							{
								nint num2 = (nint)typeof(UnityEngine.Object);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ S0_v47 (Il2CppClass<UnityEngine.Object>)+74]");
								if ((nint)0 == 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
								}
							}
							if (((ComputeShader)myIndexInTheList).FindKernel(null) != 0)
							{
								((TopRunPlayerCell)myIndexInTheList).ResizeNameIfNeeded();
							}
						}
						return null;
					}
					return null;
				}
				_003C_003E1__state = -1;
				nint num3 = (nint)typeof(UIScreenController);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S0_v12 (Il2CppClass<UIScreenController>)+BA]");
				object obj2 = (nint)0 & (nint)0x200;
				if (obj2 != null)
				{
					nint num4 = (nint)typeof(UIScreenController);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v27 (Il2CppClass<UIScreenController>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				bool flag = UIScreenController.ShouldShowOnlineScreen();
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				_ = seconds;
				object obj3 = this + 12;
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

	private ScrollView _topRunListView;

	private UILabel _titleLabel;

	private UISprite _flagSprite;

	private UILabel _countryLabel;

	private GameObject _playerPrefab;

	private GameObject _rankHeaderPrefab;

	private GameObject _spaceCell;

	private GameObject _emptyCell;

	private FacebookLoginPromotion _facebookLoginContent;

	private GameObject _normalStateContainer;

	private TopRunNormalStateHelper _normalStatePrefab;

	private TopRunNormalStateHelper _normalStateHelper;

	private GameObject _resultStateContainer;

	private GameObject _resultStatePrefab;

	private GameObject _resultStateElement;

	private GameObject _offlineState;

	public GameObject loadingOverlay;

	private UISprite _loadingOverlayBackground;

	private UIWidget _topAnchor;

	private UIPanel _scrollPanel;

	private UISprite _scrollBarBackground;

	private GameObject _globalStateNormal;

	private GameObject _globalStateMaintenance;

	private UIRect _scrollbarRect;

	private UILabel _maintenanceLabel1;

	private UILabel _maintenanceLabel2;

	private UILabel _maintenanceLabel3;

	private Layout _maintenanceLabelLayout;

	private UIWidget _maintenanceCharacterGuide;

	private CharacterScreenController _maintenanceCharacter;

	private TopRunListAdapter _adapter;

	private TopRunStates _currentState;

	private bool _isLoading;

	private List<TopRunCell> _contentList;

	private const int NO_MEDAL_RANK_THRESHOLD = 4;

	private const int NORMAL_STATE_NORMAL_OFFSET = -9;

	private const int NORMAL_STATE_RESULTS_OFFSET = -110;

	private const int SCROLL_PANEL_NORMAL_OFFSET = -5;

	private const int SCROLL_PANEL_RESULTS_OFFSET = -15;

	private const int POSITION_OFFSET_IN_LIST = 2;

	private bool _hasSetiPhoneXOffsetsIfNecessary;

	public override void Init()
	{
		CancelInvoke();
	}

	public unsafe override void Show()
	{
		//IL_029f: Expected I, but got Obj
		//IL_02b5: Expected Obj, but got I
		//IL_02d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02dd: Expected Obj, but got Unknown
		//IL_02ec: Expected Obj, but got I4
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected Obj, but got Unknown
		//IL_003f: Expected I4, but got Obj
		//IL_003f: Expected I4, but got Obj
		//IL_003f: Expected I4, but got Obj
		//IL_003f: Expected I4, but got Obj
		//IL_003a: Expected native int or pointer, but got VT
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Expected Obj, but got Unknown
		//IL_00d2: Expected Obj, but got I4
		//IL_006a: Expected I, but got Obj
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Expected Obj, but got Unknown
		//IL_0057: Expected Obj, but got VT
		//IL_00fb: Expected Obj, but got I4
		//IL_010e: Expected I, but got Obj
		//IL_0124: Expected Obj, but got I
		//IL_014f: Expected I, but got Obj
		//IL_01d7: Expected I, but got Obj
		//IL_01ed: Expected Obj, but got I
		//IL_0218: Expected I, but got Obj
		ShowIfInactive();
		SetMaintenanceLabels();
		if (_contentList != null)
		{
			object obj = this - -64;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			RouteBuilder.BuildDirective buildDirective = default;
			System.Runtime.CompilerServices.Unsafe.Write((void*)(nint)buildDirective, new RouteBuilder.BuildDirective((int)_contentList, (SectionSpawnMode)_playerPrefab, (ChunkBuildMode)_rankHeaderPrefab, (byte)(int)obj != 0, (RouteSection)(object)_emptyCell));
			object obj2 = this + 160;
			obj2 = buildDirective;
		}
		int layer = _normalStateContainer.layer;
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S0_v16 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ S0_v82 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj4 = this + 84;
		TopRunNormalStateHelper topRunNormalStateHelper = UnityEngine.Object.Instantiate(_normalStatePrefab, (Transform)layer);
		obj4 = topRunNormalStateHelper;
		GameObject uiGrid = _normalStateHelper.gameObject;
		UIExtensions.RepositionImmediately((UIGrid)(object)uiGrid);
		object obj5 = this + 96;
		int layer2 = _resultStateContainer.layer;
		GameObject gameObject = UnityEngine.Object.Instantiate(_resultStatePrefab, (Transform)layer2);
		obj5 = gameObject;
		int layer3 = _resultStateElement.layer;
		UIExtensions.RepositionImmediately((UIGrid)layer3);
		nint num3 = (nint)typeof(IPhoneXSupport);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ S0_v31 (Il2CppClass<IPhoneXSupport>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num4 = (nint)typeof(IPhoneXSupport);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ S0_v78 (Il2CppClass<IPhoneXSupport>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (!IPhoneXSupport.CheckIsiPhoneXDevice() || ~(_hasSetiPhoneXOffsetsIfNecessary ? 1u : 0u) == 0)
		{
			return;
		}
		UIPanel scrollPanel = _scrollPanel;
		UIRect.AnchorPoint bottomAnchor = scrollPanel.bottomAnchor;
		nint num5 = (nint)typeof(IPhoneXSupport);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v167 @ S0_v46 (Il2CppClass<IPhoneXSupport>)+BA]");
		object obj7 = (nint)0 & (nint)0x200;
		if (obj7 != null)
		{
			nint num6 = (nint)typeof(IPhoneXSupport);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v173 @ S0_v72 (Il2CppClass<IPhoneXSupport>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		int absolute = IPhoneXSupport.OFFSET_BOTTOM + bottomAnchor.absolute;
		bottomAnchor.absolute = absolute;
		UIWidget topAnchor = _topAnchor;
		UIRect.AnchorPoint topAnchor2 = topAnchor.topAnchor;
		int absolute2 = topAnchor2.absolute - IPhoneXSupport.OFFSET_TOP;
		topAnchor2.absolute = absolute2;
		UIWidget topAnchor3 = _topAnchor;
		UIRect.AnchorPoint bottomAnchor2 = topAnchor3.bottomAnchor;
		int absolute3 = bottomAnchor2.absolute - IPhoneXSupport.OFFSET_TOP;
		bottomAnchor2.absolute = absolute3;
		UISprite scrollBarBackground = _scrollBarBackground;
		UIRect.AnchorPoint bottomAnchor3 = scrollBarBackground.bottomAnchor;
		int absolute4 = IPhoneXSupport.OFFSET_BOTTOM + bottomAnchor3.absolute;
		bottomAnchor3.absolute = absolute4;
		UISprite loadingOverlayBackground = _loadingOverlayBackground;
		UIRect.AnchorPoint bottomAnchor4 = loadingOverlayBackground.bottomAnchor;
		int absolute5 = IPhoneXSupport.OFFSET_BOTTOM + bottomAnchor4.absolute;
		bottomAnchor4.absolute = absolute5;
		_hasSetiPhoneXOffsetsIfNecessary = true;
	}

	public unsafe override void GainFocus()
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected Obj, but got Unknown
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Expected Obj, but got Unknown
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Expected Obj, but got Unknown
		//IL_00c9: Expected I, but got Obj
		//IL_00df: Expected Obj, but got I
		//IL_010a: Expected I, but got Obj
		//IL_01b3: Expected I, but got Obj
		//IL_01c9: Expected Obj, but got I
		//IL_0189: Expected Obj, but got I4
		//IL_0342: Expected I, but got Obj
		//IL_0358: Expected Obj, but got I
		//IL_01f4: Expected I, but got Obj
		//IL_0276: Expected I, but got Obj
		//IL_0263: Expected I4, but got Obj
		base.Hide();
		TopRunNotificationSlideInManager instance = TopRunNotificationSlideInManager.instance;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num = 0;
		_ = 0;
		EventHandler<TournamentChangedEventArgs> eventHandler = default;
		object obj = eventHandler + 16;
		obj = this;
		((TopRunEventsHandler)(object)instance).OnTopRunChangedEvent -= eventHandler;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7502");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num2 = 0;
		_ = 0;
		object obj3 = default;
		object obj2 = obj3 + 16;
		obj2 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @750C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr = 0;
		Action action = default;
		((Delegate)action).method_ptr = method_ptr;
		((Delegate)action).method = (nint)__ldftn(TopRunOnlineScreen.OnApplicationResumed);
		object obj4 = action + 16;
		obj4 = this;
		nint num3 = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ S0_v27 (Il2CppClass<UIScreenController>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num4 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ S0_v67 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		UIScreenController.OnApplicationResumed -= action;
		_isLoading = true;
		ForceUpdateAnchors();
		bool flag = UIScreenController.ShouldShowOnlineScreen();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ S0_v35 (System.Boolean)+7A]");
		if ((nint)0 == 0)
		{
			loadingOverlay.tag = (string)1;
			((TopRunOnlineScreen)null).SetCurrentState();
		}
		SetListContent();
		SetScreenTop_UI();
		nint num5 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ S1_v35 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num6 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ S1_v46 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)_topRunListView).FindKernel((string)null) != 0 && _adapter != null)
		{
			_topRunListView.CalculateVirtualRelativeWidgetBounds((ScrollView.BoundsCalculationMode)_adapter);
		}
		nint num7 = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ S0_v46 (Il2CppClass<UIScreenController>)+BA]");
		object obj7 = (nint)0 & (nint)0x200;
		if (obj7 != null)
		{
			nint num8 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ S0_v56 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag2 = UIScreenController.ShouldShowOnlineScreen();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ S0_v51 (System.Boolean)+7A]");
		if ((nint)0 == 0)
		{
			RefreshOrFetchNewTournament();
		}
	}

	public override void Hide()
	{
		//IL_00a5: Expected I, but got Obj
		//IL_00bb: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_008d: Expected Obj, but got I4
		nint num = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UIScreenController>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v18 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = UIScreenController.ShouldShowOnlineScreen();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v11 (System.Boolean)+7A]");
		if ((nint)0 != 0)
		{
			Player myPlayerProfile = GetMyPlayerProfile(hasScore: true);
			Coroutine coroutine = StartCoroutine_Auto((IEnumerator)myPlayerProfile);
			bool flag2 = ((IntervalSampler)(object)this).Update(0.5f);
			Coroutine coroutine2 = StartCoroutine_Auto((IEnumerator)flag2);
		}
	}

	private unsafe void TournamentChanged(object sender, EventArgs eventArg)
	{
		//IL_016f: Expected I, but got Obj
		//IL_0185: Expected Obj, but got I
		//IL_020d: Expected Obj, but got I4
		//IL_0216: Expected Obj, but got I4
		//IL_0223: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_00d4: Expected I, but got Obj
		//IL_00ea: Expected Obj, but got I
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Expected Obj, but got Unknown
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Expected Obj, but got Unknown
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Expected Obj, but got Unknown
		//IL_0115: Expected I, but got Obj
		nint num = (nint)typeof(Strings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v10 (Il2CppClass<Strings>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v36 (Il2CppClass<Strings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = Strings.TryGetLocalizedOnlineSettings("top_run_maintenance_message", out *(string*)string.Empty);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		int num3 = default;
		object obj2 = num3 + 16;
		obj2 = 59;
		string text = ((string)flag).Substring(num3);
		TopRunOnlineScreen topRunOnlineScreen;
		object obj5;
		EventArgs e;
		if (text.m_firstChar == '\u0003')
		{
			object obj3 = text + 16;
			topRunOnlineScreen = (TopRunOnlineScreen)obj3;
			object obj4 = text + 20;
			obj5 = obj4;
			object obj6 = text + 24;
			e = (EventArgs)obj6;
			return;
		}
		nint num4 = (nint)typeof(Strings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ S0_v22 (Il2CppClass<Strings>)+BA]");
		object obj7 = (nint)0 & (nint)0x200;
		if (obj7 != null)
		{
			nint num5 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ S0_v29 (Il2CppClass<Strings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string text2 = Strings.GetDefault("TOPRUN_MAINTENANCE_LINE1");
		topRunOnlineScreen = (TopRunOnlineScreen)(object)text2;
		string text3 = Strings.GetDefault("TOPRUN_MAINTENANCE_LINE2");
		obj5 = text3;
		string text4 = Strings.GetDefault("TOPRUN_MAINTENANCE_LINE3");
		e = (EventArgs)(object)text4;
	}

	private void OnApplicationResumed()
	{
		//IL_0021: Expected Obj, but got I4
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Expected Obj, but got Unknown
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Expected Obj, but got Unknown
		//IL_00b5: Expected I, but got Obj
		//IL_00cb: Expected Obj, but got I
		//IL_00f6: Expected I, but got Obj
		base.LoseFocus();
		TopRunNotificationSlideInManager instance = TopRunNotificationSlideInManager.instance;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num = 0;
		_ = 0;
		bool flag = default;
		object obj = (flag ? 1 : 0) + 16;
		obj = this;
		((AwardCollectibleHelper)(object)instance).AddSocialLockCanOverlay(flag);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7502");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num2 = 0;
		_ = 0;
		object obj3 = default;
		object obj2 = obj3 + 16;
		obj2 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @750C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num3 = 0;
		_ = 0;
		Action<string> action = default;
		object obj4 = action + 16;
		obj4 = this;
		nint num4 = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ S0_v27 (Il2CppClass<UIScreenController>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num5 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ S0_v37 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		UIScreenController.OnPopupShown += action;
		loadingOverlay.tag = null;
		bool flag2 = UIScreenController.ShouldShowOnlineScreen();
		_ = 0;
		CreateMaintenanceCharacterModel();
	}

	private void RefreshAdapterIfDataChanged()
	{
		//IL_0120: Expected I, but got Obj
		//IL_0136: Expected Obj, but got I
		//IL_007b: Expected I, but got Obj
		//IL_0091: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0062: Expected Obj, but got I4
		//IL_00bc: Expected I, but got Obj
		_isLoading = true;
		nint num = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S0_v7 (Il2CppClass<UIScreenController>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v34 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = UIScreenController.ShouldShowOnlineScreen();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v12 (System.Boolean)+7A]");
		if ((nint)0 == 0)
		{
			loadingOverlay.tag = (string)1;
		}
		ForceUpdateAnchors();
		nint num3 = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S0_v18 (Il2CppClass<UIScreenController>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S0_v28 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag2 = UIScreenController.ShouldShowOnlineScreen();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v23 (System.Boolean)+7A]");
		if ((nint)0 == 0)
		{
			((TopRunOnlineScreen)null).SetCurrentState();
		}
	}

	private unsafe IEnumerator RefreshAdapterListDelayed(int frames)
	{
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected Obj, but got Unknown
		//IL_0049: Expected I4, but got I8
		//IL_0057: Expected Obj, but got I4
		//IL_006e: Expected I4, but got I8
		//IL_008a: Expected Obj, but got I4
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Expected Obj, but got Unknown
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Expected Obj, but got Unknown
		//IL_00f3: Expected Obj, but got I4
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0100: Expected Obj, but got Unknown
		//IL_0141: Expected Obj, but got I4
		//IL_0149: Unknown result type (might be due to invalid IL or missing references)
		//IL_014e: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 8;
		int num = (int)(((int*)frames)->m_value / 864000000000L);
		object obj3 = num * 24;
		int num2 = (int)(((int*)frames)->m_value / 36000000000L);
		int num3 = num2 / 24;
		object obj4 = num3 * 24;
		object obj5 = num2 - obj4;
		object obj6 = obj3 + obj5;
		obj = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		object obj7 = obj2 + 4;
		int num4 = ((int*)frames)->m_value / 600000000;
		int num5 = num4 / 60;
		object obj8 = num5 * 60;
		object obj9 = num4 - obj8;
		obj7 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		int num6 = ((int*)frames)->m_value / 10000000;
		int num7 = num6 / 60;
		object obj10 = num7 * 60;
		object obj11 = num6 - obj10;
		obj2 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		string format = default;
		object arg = default;
		object arg2 = default;
		return (IEnumerator)(object)string.Format((IFormatProvider)(object)"{0:00}:{1:00}:{2:00}", format, arg, arg2);
	}

	private IEnumerator AnimateMedalAfterSeconds(float seconds)
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		_ = 0;
		IEnumerator enumerator = default;
		object obj = enumerator + 20;
		obj = this;
		return enumerator;
	}

	private unsafe TopRunPlayerCell GetPlayerScriptFromList()
	{
		//IL_0283: Unknown result type (might be due to invalid IL or missing references)
		//IL_0288: Expected Obj, but got Unknown
		//IL_0291: Expected Obj, but got I4
		//IL_02a8: Expected I, but got Obj
		//IL_02be: Expected Obj, but got I
		//IL_02e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e9: Expected Obj, but got Unknown
		//IL_02f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fc: Expected Obj, but got Unknown
		//IL_0304: Expected Obj, but got VT
		//IL_030d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0312: Expected VT, but got Unknown
		//IL_031f: Expected I8, but got Obj
		//IL_031a: Expected native int or pointer, but got VT
		//IL_0328: Unknown result type (might be due to invalid IL or missing references)
		//IL_032d: Expected Obj, but got Unknown
		//IL_0342: Expected Ref, but got VT
		//IL_034e: Expected Obj, but got I8
		//IL_0357: Unknown result type (might be due to invalid IL or missing references)
		//IL_035c: Expected Obj, but got Unknown
		//IL_036d: Expected Obj, but got VT
		//IL_037f: Expected I8, but got Obj
		//IL_037a: Expected native int or pointer, but got VT
		//IL_03ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b0: Expected Obj, but got Unknown
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_0138: Unknown result type (might be due to invalid IL or missing references)
		//IL_013d: Expected Obj, but got Unknown
		//IL_015a: Expected I, but got Obj
		//IL_0170: Expected Obj, but got I
		//IL_00ab: Expected I, but got Obj
		//IL_00c1: Expected Obj, but got I
		//IL_023b: Expected I, but got Obj
		//IL_00ec: Expected I, but got Obj
		//IL_01ca: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 24;
		obj = 0;
		DateTime today = CDateTime.Today;
		nint num = (nint)typeof(DateTime);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S0_v15 (Il2CppClass<System.DateTime>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num2 = (nint)typeof(DateTime);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S0_v80 (Il2CppClass<System.DateTime>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj4 = obj2 + 32;
		obj4 = this;
		object obj5 = obj2 + 16;
		obj5 = today;
		DateTime dateTime = (DateTime)(obj2 + 40);
		((DateTime*)(nint)dateTime)->dateData = (ulong)(long)obj4;
		IFormatProvider formatProvider = (IFormatProvider)(obj2 + 48);
		formatProvider = (IFormatProvider)obj5;
		long num3 = ((DateTime*)dateTime)->System_002EIConvertible_002EToInt64(formatProvider);
		obj = num3;
		object obj6 = obj2 + 8;
		DateTime today2 = CDateTime.Today;
		obj6 = today2;
		obj2 = this;
		((DateTime*)(nint)dateTime)->dateData = (ulong)(long)obj6;
		formatProvider = (IFormatProvider)obj2;
		long num4 = (long)(dateTime.dateData & 0x3FFFFFFFFFFFFFFFL);
		object obj7 = formatProvider & 0x3FFFFFFFFFFFFFFFL;
		if (num4 > (long)obj7)
		{
			return (TopRunPlayerCell)(object)"00:00:00";
		}
		object obj8 = obj / 864000000000L;
		if ((nint)obj8 >= 2)
		{
			nint num5 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ S0_v67 (Il2CppClass<Strings>)+BA]");
			object obj9 = (nint)0 & (nint)0x200;
			if (obj9 != null)
			{
				nint num6 = (nint)typeof(Strings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ S0_v74 (Il2CppClass<Strings>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			return (TopRunPlayerCell)(object)Strings.GetDefault("TOPRUN_STATE_DAYS_LEFT");
		}
		object obj10 = obj / 864000000000L;
		bool flag = (nint)obj10 == 1;
		nint num7 = (nint)typeof(Strings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ S1_v37 (Il2CppClass<Strings>)+BA]");
		object obj11 = (nint)0 & (nint)0x200;
		bool flag2 = obj11 == null;
		if (flag)
		{
			if (!flag2)
			{
				nint num8 = (nint)typeof(Strings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ S0_v62 (Il2CppClass<Strings>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			return (TopRunPlayerCell)(object)Strings.GetDefault("TOPRUN_STATE_DAYS_LEFT_SINGLE");
		}
		if (!flag2)
		{
			nint num9 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v164 @ S0_v52 (Il2CppClass<Strings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		return (TopRunPlayerCell)(object)Strings.GetDefault("TOPRUN_STATE_TIME_LEFT");
	}

	private void OnPlayerChanged(object o, PlayerInfoChangedEventArgs eventArg = null)
	{
		//IL_0098: Expected I, but got Obj
		//IL_00ae: Expected Obj, but got I
		//IL_00d9: Expected I, but got Obj
		string text = tag;
		if (!((GameObject)(object)text).activeInHierarchy)
		{
			return;
		}
		string text2 = tag;
		string text3 = ((GameObject)(object)text2).tag;
		if (text3 == null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7502");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
		object obj = default;
		if (obj != null)
		{
			return;
		}
		_isLoading = false;
		nint num = (nint)typeof(TopRunRewardHelper);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ S0_v19 (Il2CppClass<TopRunRewardHelper>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(TopRunRewardHelper);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ S0_v26 (Il2CppClass<TopRunRewardHelper>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		TopRunRewardHelper.CalculateBeatenFriendsAward();
		ForceUpdateAnchors();
		ScrollToMyPosition();
	}

	private void ScrollToMyPosition()
	{
		//IL_0055: Expected I4, but got Obj
		if (_adapter != null)
		{
			SetMaintenanceLabels();
			if (_contentList != null)
			{
				((_003CRefreshAdapterListDelayed_003Ed__48)(object)_adapter)._002Ector((int)_contentList);
			}
			SetListContent();
			SetScreenTop_UI();
		}
		RefreshOrFetchNewTournament();
		loadingOverlay.tag = null;
	}

	private int GetMyIndexInTheList()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_034a: Unknown result type (might be due to invalid IL or missing references)
		//IL_034f: Expected Obj, but got Unknown
		//IL_0358: Expected Obj, but got I4
		//IL_0367: Unknown result type (might be due to invalid IL or missing references)
		//IL_036c: Expected Obj, but got Unknown
		//IL_011e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Expected Obj, but got Unknown
		//IL_012c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0131: Expected Obj, but got Unknown
		//IL_015d: Expected Obj, but got I4
		//IL_004d: Expected I, but got Obj
		//IL_0063: Expected Obj, but got I
		//IL_01e5: Expected Obj, but got I
		//IL_02ac: Expected Obj, but got I
		//IL_008e: Expected I, but got Obj
		//IL_021b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0220: Expected Obj, but got Unknown
		//IL_02ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ef: Expected Obj, but got Unknown
		//IL_00fa: Expected Obj, but got I
		//IL_0251: Unknown result type (might be due to invalid IL or missing references)
		//IL_0256: Expected Obj, but got Unknown
		//IL_03c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c5: Expected Obj, but got Unknown
		//IL_03ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d3: Expected Obj, but got Unknown
		//IL_03ff: Expected Obj, but got I4
		//IL_0320: Unknown result type (might be due to invalid IL or missing references)
		//IL_0325: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 48;
		object obj3 = obj2 + 24;
		obj3 = 0;
		_ = 0;
		object obj4 = obj2 + 16;
		obj4 = obj;
		_ = -1;
		TopRunListAdapter adapter = _adapter;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @727C");
		obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		object obj5 = default;
		object obj7 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			if (obj5 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				nint num = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v174 @ S0_v93 (Il2CppClass<UnityEngine.Object>)+BA]");
				object obj6 = (nint)0 & (nint)0x200;
				if (obj6 != null)
				{
					nint num2 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v199 @ S0_v114 (Il2CppClass<UnityEngine.Object>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
				if (obj7 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ S0_v87+20]");
					object obj8 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v284 @ S0_v102+38]");
					if ((nint)0 != 0)
					{
						object obj9 = obj4 + 4;
						object obj10 = obj9 + 1;
						obj9 = obj10;
						object obj11 = obj10 << 2;
						object obj12 = obj4 + obj11;
						obj12 = 90;
						break;
					}
				}
				continue;
			}
			object obj13 = obj4 + 4;
			object obj14 = obj13 + 1;
			obj13 = obj14;
			object obj15 = obj14 << 2;
			object obj16 = obj4 + obj15;
			obj16 = 88;
			break;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
			object obj17 = (nint)0 << 2;
			object obj18 = obj4 + obj17;
			if ((nint)obj18 == 90)
			{
				object obj19 = obj4 + 4;
				if ((nint)obj19 > -1)
				{
					object obj20 = obj19 + -1;
					obj19 = obj20;
				}
				goto IL_045f;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
			object obj21 = (nint)0 << 2;
			object obj22 = obj4 + obj21;
			if ((nint)obj22 == 88)
			{
				object obj23 = obj4 + 4;
				if ((nint)obj23 > -1)
				{
					object obj24 = obj23 + -1;
					obj23 = obj24;
				}
				goto IL_045f;
			}
		}
		object obj25 = default;
		if (obj25 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		goto IL_045f;
		IL_045f:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ S0_v87+20]");
		return 0;
	}

	private void RefreshOrFetchNewTournament()
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected VT, but got Unknown
		//IL_0021: Invalid comparison between VT and I4
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Expected Obj, but got Unknown
		ManagerData managerData = ((Manager)(object)this).managerData;
		Vector3 vector = (Vector3)(managerData - 2);
		if (vector > (object)(-1))
		{
			Container lastVisibleContainerOnScreen = _topRunListView.GetLastVisibleContainerOnScreen();
			if (lastVisibleContainerOnScreen != null)
			{
				UIScrollView uiScrollView = _topRunListView.uiScrollView;
				object obj = uiScrollView + 220;
				object obj2 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S1_v10+8]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+C]");
				float num = 0f * 0.5f;
				float strength = num - lastVisibleContainerOnScreen.height;
				_topRunListView.SmoothScrollToOffset(vector, (Action)null, strength);
			}
		}
	}

	private void SetCurrentState()
	{
		//IL_0214: Expected I, but got Obj
		//IL_022a: Expected Obj, but got I
		//IL_0250: Unknown result type (might be due to invalid IL or missing references)
		//IL_0255: Expected Obj, but got Unknown
		//IL_025e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0263: Expected Obj, but got Unknown
		//IL_026c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0271: Expected Obj, but got Unknown
		//IL_027a: Unknown result type (might be due to invalid IL or missing references)
		//IL_027f: Expected Obj, but got Unknown
		//IL_0288: Unknown result type (might be due to invalid IL or missing references)
		//IL_028d: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_0091: Expected I, but got Obj
		//IL_00a7: Expected Obj, but got I
		//IL_02cf: Expected Obj, but got VT
		//IL_02ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f1: Expected Obj, but got Unknown
		//IL_02fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0303: Expected Obj, but got Unknown
		//IL_00d2: Expected I, but got Obj
		//IL_0137: Expected I, but got Obj
		//IL_014d: Expected Obj, but got I
		//IL_033d: Expected Obj, but got VT
		//IL_035a: Unknown result type (might be due to invalid IL or missing references)
		//IL_035f: Expected Obj, but got Unknown
		//IL_036c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0371: Expected Obj, but got Unknown
		//IL_0178: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7502");
		nint num = (nint)typeof(TopRunRewardHelper);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v11 (Il2CppClass<TopRunRewardHelper>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(TopRunRewardHelper);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v83 (Il2CppClass<TopRunRewardHelper>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj3 = default;
		object obj2 = obj3 + 40;
		object obj4 = obj3 + 32;
		object obj5 = obj3 + 24;
		object obj6 = obj3 + 16;
		object obj7 = obj3 + 8;
		TopRunRewardHelper.CalculateBeatenFriendsAward();
		object obj8 = default;
		if (obj8 == null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
		object obj9 = default;
		if (obj9 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @750E");
			nint num3 = (nint)typeof(DateTime);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ S0_v36 (Il2CppClass<System.DateTime>)+BA]");
			object obj10 = (nint)0 & (nint)0x200;
			if (obj10 != null)
			{
				nint num4 = (nint)typeof(DateTime);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ S0_v77 (Il2CppClass<System.DateTime>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			object obj11 = default;
			obj5 = obj11;
			obj6 = DateTime.MinValue;
			obj4 = obj5;
			obj2 = obj6;
			object obj12 = obj4 & 0x3FFFFFFFFFFFFFFFL;
			object obj13 = obj2 & 0x3FFFFFFFFFFFFFFFL;
			if (obj12 != obj13)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @750E");
				DateTime today = CDateTime.Today;
				nint num5 = (nint)typeof(DateTime);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v157 @ S0_v56 (Il2CppClass<System.DateTime>)+BA]");
				object obj14 = (nint)0 & (nint)0x200;
				if (obj14 != null)
				{
					nint num6 = (nint)typeof(DateTime);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ S0_v73 (Il2CppClass<System.DateTime>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				object obj15 = default;
				obj7 = obj15;
				obj3 = today;
				obj4 = obj7;
				obj2 = obj3;
				object obj16 = obj4 & 0x3FFFFFFFFFFFFFFFL;
				object obj17 = obj2 & 0x3FFFFFFFFFFFFFFFL;
				if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj16) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj17))
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
					object obj18 = default;
					if (obj18 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @741D");
						return;
					}
				}
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @741D");
	}

	private void ForceUpdateAnchors()
	{
		//IL_04f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f6: Expected Obj, but got Unknown
		//IL_050d: Expected Obj, but got I4
		//IL_0343: Expected Obj, but got I4
		//IL_0359: Expected Obj, but got I
		//IL_036a: Unknown result type (might be due to invalid IL or missing references)
		//IL_036f: Expected Obj, but got Unknown
		//IL_0378: Unknown result type (might be due to invalid IL or missing references)
		//IL_037d: Expected Obj, but got Unknown
		//IL_0395: Expected I, but got Obj
		//IL_03ab: Expected Obj, but got I
		//IL_0269: Expected I, but got Obj
		//IL_027f: Expected Obj, but got I
		//IL_003a: Expected I, but got Obj
		//IL_0050: Expected Obj, but got I
		//IL_04b0: Expected Obj, but got I4
		//IL_04be: Expected Obj, but got I4
		//IL_03d6: Expected I, but got Obj
		//IL_02aa: Expected I, but got Obj
		//IL_0438: Expected I4, but got Obj
		//IL_0438: Expected Obj, but got I4
		//IL_01af: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b4: Expected Obj, but got Unknown
		//IL_007b: Expected I, but got Obj
		//IL_01d0: Expected Obj, but got I4
		//IL_0107: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Expected Obj, but got Unknown
		//IL_0216: Expected Obj, but got I4
		//IL_0128: Expected Obj, but got I4
		//IL_015d: Expected Obj, but got I4
		CreateMaintenanceCharacterModel();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7502");
		object obj = default;
		if (obj != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
			object obj2 = default;
			if (obj2 != null)
			{
				nint num = (nint)typeof(TopRunRewardHelper);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ S0_v72 (Il2CppClass<TopRunRewardHelper>)+BA]");
				object obj3 = (nint)0 & (nint)0x200;
				if (obj3 != null)
				{
					nint num2 = (nint)typeof(TopRunRewardHelper);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ S0_v113 (Il2CppClass<TopRunRewardHelper>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				CelebrationReward pendingReward = TopRunRewardHelper.GetPendingReward();
				if (pendingReward != null)
				{
					_currentState = TopRunStates.Results;
					UIWidget component = _normalStateContainer.GetComponent<UIWidget>();
					UIRect.AnchorPoint topAnchor = component.topAnchor;
					topAnchor.absolute = -110;
					UIPanel scrollPanel = _scrollPanel;
					object obj4 = scrollPanel.topAnchor + 8;
					int layer = _normalStateContainer.layer;
					obj4 = layer;
					UIPanel scrollPanel2 = _scrollPanel;
					UIRect.AnchorPoint topAnchor2 = scrollPanel2.topAnchor;
					topAnchor2.absolute = -15;
					_resultStateContainer.tag = (string)1;
				}
				else
				{
					_currentState = TopRunStates.Normal;
					UIWidget component2 = _normalStateContainer.GetComponent<UIWidget>();
					UIRect.AnchorPoint topAnchor3 = component2.topAnchor;
					topAnchor3.absolute = -9;
					UIPanel scrollPanel3 = _scrollPanel;
					object obj5 = scrollPanel3.topAnchor + 8;
					int layer2 = _normalStateContainer.layer;
					obj5 = layer2;
					UIPanel scrollPanel4 = _scrollPanel;
					UIRect.AnchorPoint topAnchor4 = scrollPanel4.topAnchor;
					topAnchor4.absolute = -5;
					_resultStateContainer.tag = null;
				}
				_normalStateContainer.tag = (string)1;
				_offlineState.tag = null;
				_normalStateHelper.Update();
				goto IL_0490;
			}
		}
		if (~(_isLoading ? 1u : 0u) != 0)
		{
			nint num3 = (nint)typeof(TopRunMaintenance);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v49 (Il2CppClass<TopRun.TopRunMaintenance>)+BA]");
			object obj6 = (nint)0 & (nint)0x200;
			if (obj6 != null)
			{
				nint num4 = (nint)typeof(TopRunMaintenance);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ S0_v64 (Il2CppClass<TopRun.TopRunMaintenance>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			IManager manager = TopRunRoot.manager;
			if (manager != null)
			{
				_currentState = TopRunStates.OfflineMaintenance;
				_resultStateContainer.tag = null;
				_normalStateContainer.tag = null;
				_offlineState.tag = null;
				DestroyMaintenanceCharacterModel();
				this._002Ector();
				goto IL_0490;
			}
		}
		_currentState = TopRunStates.Offline;
		UIPanel scrollPanel5 = _scrollPanel;
		object obj7 = scrollPanel5.topAnchor + 8;
		int layer3 = _offlineState.layer;
		obj7 = layer3;
		UIPanel scrollPanel6 = _scrollPanel;
		UIRect.AnchorPoint topAnchor5 = scrollPanel6.topAnchor;
		topAnchor5.absolute = -5;
		_resultStateContainer.tag = null;
		_normalStateContainer.tag = null;
		_offlineState.tag = (string)1;
		nint num5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ S2_v12 (Il2CppMethodInfo)+18]");
		object obj8 = 0;
		object obj9 = obj8;
		object obj10 = obj9 & 0x1FFF;
		object obj11 = obj10 + 22691;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v134 @ S3_v5 (should have been resolved before IL gen)");
		nint num6 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ S0_v37 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj12 = (nint)0 & (nint)0x200;
		if (obj12 != null)
		{
			nint num7 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v170 @ S0_v44 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		ComputeShader computeShader = default;
		if (computeShader.FindKernel(null) != 0)
		{
			bool isLoading = _isLoading;
			((BundlePurchaseButton)(object)computeShader).OnPurchaseSuccess((string)isLoading, (byte)(int)this != 0, (IPurchaseValidationResult)null);
		}
		goto IL_0490;
		IL_0490:
		bool flag = _currentState == TopRunStates.OfflineMaintenance;
		_globalStateMaintenance.tag = (string)flag;
		string text = (string)((flag ? 1 : 0) ^ 1);
		_globalStateNormal.tag = text;
	}

	private void SetScreenTop_UI()
	{
		((UIRect)_scrollPanel).ParentHasChanged();
	}

	private unsafe void SetListContent()
	{
		//IL_0167: Expected I, but got Obj
		//IL_017d: Expected Obj, but got I
		//IL_0297: Expected I4, but got Obj
		//IL_02a5: Expected I, but got Obj
		//IL_02bb: Expected Obj, but got I
		//IL_01a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a8: Expected Obj, but got Unknown
		//IL_01b1: Expected Obj, but got VT
		//IL_01ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bf: Expected Obj, but got Unknown
		//IL_01d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d5: Expected VT, but got Unknown
		//IL_01e2: Expected F4, but got Obj
		//IL_01dd: Expected native int or pointer, but got VT
		//IL_01eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f0: Expected Obj, but got Unknown
		//IL_020a: Expected F4, but got Obj
		//IL_0205: Expected native int or pointer, but got VT
		//IL_021f: Expected F4, but got I
		//IL_021a: Expected native int or pointer, but got VT
		//IL_022e: Expected I4, but got VT
		//IL_0237: Unknown result type (might be due to invalid IL or missing references)
		//IL_023c: Expected Obj, but got Unknown
		//IL_0245: Expected Obj, but got VT
		//IL_024e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0253: Expected Obj, but got Unknown
		//IL_0268: Expected F4, but got Obj
		//IL_0263: Expected native int or pointer, but got VT
		//IL_0013: Expected I, but got Obj
		//IL_00ac: Expected F4, but got Obj
		//IL_00a7: Expected native int or pointer, but got VT
		//IL_00c1: Expected F4, but got I
		//IL_00bc: Expected native int or pointer, but got VT
		//IL_00d0: Expected I4, but got VT
		//IL_0060: Expected I, but got Obj
		//IL_0133: Expected Obj, but got I
		//IL_0158: Expected I4, but got Obj
		nint num = (nint)typeof(Strings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v4 (Il2CppClass<Strings>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S1_v52 (Il2CppClass<Strings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string text = Strings.GetDefault("TOPRUN_TITLE");
		_titleLabel.fontSize = (int)text;
		nint num3 = (nint)typeof(GlobalColors);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S1_v12 (Il2CppClass<GlobalColors>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(GlobalColors);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ S1_v46 (Il2CppClass<GlobalColors>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj4 = default;
		object obj3 = obj4 + 40;
		obj3 = GlobalColors.TOPRUN_SCREEN_TITLE_COLOUR;
		object obj5 = obj4 + 44;
		obj5 = obj3;
		Matrix4x4 matrix4x = (Matrix4x4)(obj4 + 48);
		((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj5;
		object obj6 = obj4 + 24;
		Matrix4x4 matrix4x2 = Matrix4x4.Inverse(matrix4x);
		((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ S1_v23+8]");
		((Matrix4x4*)(nint)matrix4x)->m20 = 0f;
		_titleLabel.rawPivot = (UIWidget.Pivot)matrix4x;
		object obj7 = obj4 + 16;
		obj7 = GlobalColors.TOPRUN_COUNTRY_NAME_COLOUR;
		object obj8 = obj4 + 20;
		obj8 = obj7;
		((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj8;
		Matrix4x4 matrix4x3 = Matrix4x4.Inverse(matrix4x);
		((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((Matrix4x4*)(nint)matrix4x)->m20 = 0f;
		_countryLabel.rawPivot = (UIWidget.Pivot)matrix4x;
		TopRunEventsHandler instance = TopRunEventsHandler.instance;
		IEnumerator enumerator = ((CountryPopup)(object)instance).DelayedSelect();
		UISprite flagSprite = _flagSprite;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ S1_v38 (System.Collections.IEnumerator)+C]");
		flagSprite.fillCenter = false;
		TopRunEventsHandler instance2 = TopRunEventsHandler.instance;
		IEnumerator enumerator2 = ((CountryPopup)(object)instance2).DelayedSelect();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ S1_v42 (System.Collections.IEnumerator)+8]");
		string text2 = Strings.GetDefault((string)0);
		string text3 = text2.ToUpperInvariant();
		_countryLabel.fontSize = (int)text3;
	}

	private unsafe void AddFacebookButtonAfterMe(List<TopRunCell> contentList, ref bool isFacebookButtonAdded)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0284: Unknown result type (might be due to invalid IL or missing references)
		//IL_0289: Expected Obj, but got Unknown
		//IL_0292: Expected Obj, but got I4
		//IL_02a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a6: Expected Obj, but got Unknown
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Expected Obj, but got Unknown
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Expected Obj, but got Unknown
		//IL_015e: Expected Obj, but got I4
		//IL_01e6: Expected Obj, but got I
		//IL_0224: Unknown result type (might be due to invalid IL or missing references)
		//IL_0229: Expected Obj, but got Unknown
		//IL_025a: Unknown result type (might be due to invalid IL or missing references)
		//IL_025f: Expected Obj, but got Unknown
		//IL_02da: Unknown result type (might be due to invalid IL or missing references)
		//IL_02df: Expected Obj, but got Unknown
		//IL_02e8: Expected Obj, but got Ref
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Expected Obj, but got Unknown
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Expected Obj, but got Unknown
		//IL_0111: Expected Obj, but got I4
		object obj2 = default;
		object obj = obj2 + 48;
		object obj3 = obj2 + 24;
		obj3 = 0;
		_ = 0;
		object obj4 = obj2 + 16;
		obj4 = obj;
		_ = -1;
		if (System.Runtime.CompilerServices.Unsafe.AsPointer(ref isFacebookButtonAdded) == null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @727C");
		obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		object obj5 = default;
		object obj6 = default;
		object obj8 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			if (obj5 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v171 @ S0_v73+14]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
					if (obj6 != null)
					{
						object obj7 = obj8 + 20;
						obj7 = ((List<TopRunCell>)System.Runtime.CompilerServices.Unsafe.AsPointer(ref isFacebookButtonAdded))._items;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
						object obj9 = obj4 + 4;
						object obj10 = obj9 + 1;
						obj9 = obj10;
						object obj11 = obj10 << 2;
						object obj12 = obj4 + obj11;
						obj12 = 104;
						break;
					}
				}
				continue;
			}
			object obj13 = obj4 + 4;
			object obj14 = obj13 + 1;
			obj13 = obj14;
			object obj15 = obj14 << 2;
			object obj16 = obj4 + obj15;
			obj16 = 104;
			break;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
			object obj17 = (nint)0 << 2;
			object obj18 = obj4 + obj17;
			if ((nint)obj18 == 104)
			{
				object obj19 = obj4 + 4;
				if ((nint)obj19 > -1)
				{
					object obj20 = obj19 + -1;
					obj19 = obj20;
				}
				return;
			}
		}
		object obj21 = default;
		if (obj21 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
	}

	private Player GetMyPlayerProfile(bool hasScore = true)
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		Player player = default;
		player.publicKey__BackingField = null;
		object obj = player + 20;
		obj = this;
		player.isFriend__BackingField = hasScore;
		return player;
	}

	private void SetMaintenanceLabels()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0c4f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c54: Expected Obj, but got Unknown
		//IL_0c5d: Expected Obj, but got I4
		//IL_0c6c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c71: Expected Obj, but got Unknown
		//IL_02b2: Expected Obj, but got I4
		//IL_0274: Expected Obj, but got I4
		object obj2 = default;
		object obj = obj2 + 48;
		object obj3 = obj2 + 24;
		obj3 = 0;
		_ = 0;
		object obj4 = obj2 + 16;
		obj4 = obj;
		_ = -1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7502");
		if (_currentState != TopRunStates.Normal && _currentState != TopRunStates.Results)
		{
			bool flag = _currentState == TopRunStates.OfflineMaintenance;
			throw new IndexOutOfRangeException();
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
		object obj5 = default;
		string facebookId;
		if ((nint)obj5 < 1)
		{
			object obj6 = 4;
			facebookId = null;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @745A");
			object obj7 = default;
			object obj6 = obj7;
			facebookId = (string)1;
		}
		IRank playerRank = ((Manager)null).GetPlayerRank(facebookId);
		throw new IndexOutOfRangeException();
	}

	private void DestroyMaintenanceCharacterModel()
	{
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Expected Obj, but got Unknown
		//IL_008a: Expected Obj, but got I4
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Expected Obj, but got Unknown
		//IL_00a1: Expected Obj, but got I4
		//IL_00aa: Expected Obj, but got I4
		//IL_00b8: Expected I, but got Obj
		//IL_00ce: Expected Obj, but got I
		//IL_010b: Expected I4, but got Obj
		//IL_011a: Expected I4, but got Obj
		//IL_0061: Expected I4, but got Obj
		//IL_0013: Expected I, but got Obj
		EventArgs e = default;
		TopRunOnlineScreen topRunOnlineScreen = (TopRunOnlineScreen)(e + 8);
		topRunOnlineScreen = (TopRunOnlineScreen)0;
		object obj = e + 4;
		obj = 0;
		e = (EventArgs)0;
		nint num = (nint)typeof(TopRunMaintenance);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S0_v14 (Il2CppClass<TopRun.TopRunMaintenance>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(TopRunMaintenance);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S0_v28 (Il2CppClass<TopRun.TopRunMaintenance>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		topRunOnlineScreen.TournamentChanged(obj, e);
		_maintenanceLabel1.fontSize = (int)topRunOnlineScreen;
		_maintenanceLabel2.fontSize = (int)obj;
		_maintenanceLabel3.fontSize = (int)e;
		((RewardForVideoButton)(object)_maintenanceLabelLayout).Init((VideoButtonPayload)null);
	}

	private void CreateMaintenanceCharacterModel()
	{
		//IL_00fe: Expected I, but got Obj
		//IL_0114: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_006f: Expected I, but got Obj
		//IL_0085: Expected Obj, but got I
		//IL_00b0: Expected I, but got Obj
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S1_v3 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v20 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)_maintenanceCharacter).FindKernel((string)null) == 0)
		{
			return;
		}
		string obj2 = _maintenanceCharacter.tag;
		nint num3 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S1_v11 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num4 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S1_v16 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		UnityEngine.Object.DestroyImmediate((UnityEngine.Object)(object)obj2);
	}

	private static GameObject PlaceModelUnderAnchor(GameObject model, Transform anchor, int layer)
	{
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Expected Obj, but got Unknown
		//IL_00b9: Expected Obj, but got I
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fa: Expected Obj, but got Unknown
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected Obj, but got Unknown
		//IL_0045: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		object obj2 = default;
		object obj = obj2 + 8;
		obj = model;
		bool flag = layer == 0;
		bool flag2 = !flag;
		IEnumerable<_0021_00210> source = (IEnumerable<_0021_00210>)(nint)((UnityEngine.Object)model).m_CachedPtr;
		if (!flag2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num = 0;
			_ = 0;
			Func<_0021_00210, _0021_00211> func = default;
			object obj3 = func + 16;
			obj3 = obj2;
			IEnumerable<_0021_00211> enumerable = (IEnumerable<_0021_00211>)Enumerable.Select<TSource, TResult>((IEnumerable<TSource>)(nint)((UnityEngine.Object)model).m_CachedPtr, (Func<TSource, TResult>)(object)func);
			source = (IEnumerable<_0021_00210>)enumerable;
		}
		List<CharacterScrollListSlot> list = Enumerable.ToList((IEnumerable<CharacterScrollListSlot>)source);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num2 = 0;
		_ = 0;
		Predicate<_00210> predicate = default;
		object obj4 = predicate + 16;
		obj4 = obj2;
		List<_00210> source2 = (List<_00210>)(object)((List<T>)(object)list).FindAll((Predicate<T>)(object)predicate);
		return (GameObject)(object)Enumerable.ToList((IEnumerable<CharacterScrollListSlot>)source2);
	}

	private static void PositionModelOnSprite(UIWidget tracker, GameObject objectToPosition, Vector3 positionOffset, Vector3 newRotation, Vector3 newScale)
	{
		//IL_00f8: Expected Obj, but got I
		//IL_0108: Expected Obj, but got I
		//IL_0118: Expected Obj, but got I
		//IL_0121: Unknown result type (might be due to invalid IL or missing references)
		//IL_0126: Expected Obj, but got Unknown
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0134: Expected Obj, but got Unknown
		//IL_0052: Expected I, but got Obj
		//IL_0068: Expected Obj, but got I
		//IL_0190: Expected Obj, but got VT
		//IL_0190: Expected Obj, but got VT
		//IL_01aa: Expected Obj, but got I
		//IL_01ba: Expected Obj, but got I
		//IL_01ca: Expected Obj, but got I
		//IL_01d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d8: Expected Obj, but got Unknown
		//IL_01e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e6: Expected Obj, but got Unknown
		//IL_0201: Expected Obj, but got I4
		//IL_0017: Expected I4, but got Obj
		//IL_0017: Expected Obj, but got I
		//IL_0029: Expected Obj, but got I4
		//IL_016f: Invalid comparison between VT and I4
		//IL_0093: Expected I, but got Obj
		//IL_003f: Expected Obj, but got I4
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
			GameObject gameObject = ((Dictionary<UiElementType, GameObject>)(nint)((UnityEngine.Object)tracker).m_CachedPtr).get_Item((UiElementType)objectToPosition);
			gameObject.tag = (string)1;
			GameObject gameObject2 = gameObject;
			object obj7 = 0;
		}
		else
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v14 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj8 = (nint)0 & (nint)0x200;
			if (obj8 != null)
			{
				nint num3 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ S0_v25 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			GameObject gameObject3 = UnityEngine.Object.Instantiate((GameObject)positionOffset, (Transform)newRotation);
			nint num4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ S4_v5 (Il2CppMethodInfo)+C]");
			object obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S4_v6+60]");
			object obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ S4_v7+48]");
			object obj11 = 0;
			object obj12 = obj11 & 0x7FF;
			object obj13 = obj12 + 39195;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v80 @ S5_v5 (should have been resolved before IL gen)");
			GameObject gameObject2 = gameObject3;
			object obj7 = 1;
		}
		if (newScale != (Vector3)(object)0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7A74");
		}
	}

	public TopRunOnlineScreen()
	{
		//IL_00ef: Expected I, but got Obj
		//IL_0105: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0151: Expected Obj, but got I4
		//IL_00a1: Expected I, but got Obj
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S1_v3 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v20 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)_maintenanceCharacter).FindKernel((string)null) != 0)
		{
			return;
		}
		nint num3 = (nint)typeof(CharacterModelPreviewFactory);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S0_v11 (Il2CppClass<CharacterModelPreviewFactory>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(CharacterModelPreviewFactory);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v17 (Il2CppClass<CharacterModelPreviewFactory>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		BoardScreenManager instance = BoardScreenManager.Instance;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num5 = 0;
		_ = 0;
		bool flag = default;
		object obj3 = (flag ? 1 : 0) + 16;
		obj3 = this;
		((HoverboardBundle)(object)instance).AddCustomSetModelAndEffect(0, false, flag);
	}

	private unsafe void _003CCreateMaintenanceCharacterModel_003Eb__64_0(CharacterScreenController csc)
	{
		//IL_02fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0301: Expected Obj, but got Unknown
		//IL_030a: Expected Obj, but got I4
		//IL_0323: Expected I, but got Obj
		//IL_0339: Expected Obj, but got I
		//IL_0474: Unknown result type (might be due to invalid IL or missing references)
		//IL_0479: Expected Obj, but got Unknown
		//IL_0072: Expected I4, but got Obj
		//IL_0072: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_00a7: Expected I, but got Obj
		//IL_00bd: Expected Obj, but got I
		//IL_035f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0364: Expected Obj, but got Unknown
		//IL_0375: Unknown result type (might be due to invalid IL or missing references)
		//IL_037a: Expected Obj, but got Unknown
		//IL_0382: Expected Obj, but got VT
		//IL_038b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0390: Expected VT, but got Unknown
		//IL_039d: Expected I8, but got Obj
		//IL_0398: Expected native int or pointer, but got VT
		//IL_03a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ab: Expected Obj, but got Unknown
		//IL_03c0: Expected Ref, but got VT
		//IL_03cc: Expected Obj, but got I8
		//IL_03d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03da: Expected Obj, but got Unknown
		//IL_0272: Expected I, but got Obj
		//IL_0288: Expected Obj, but got I
		//IL_00e8: Expected I, but got Obj
		//IL_0458: Expected I4, but got Obj
		//IL_02b3: Expected I, but got Obj
		//IL_0174: Expected I, but got Obj
		//IL_018a: Expected Obj, but got I
		//IL_01b5: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 32;
		obj = 0;
		showOldFooterSection = true;
		nint num = (nint)typeof(Strings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S1_v7 (Il2CppClass<Strings>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num2 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S1_v76 (Il2CppClass<Strings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string format = Strings.GetDefault("TOPRUN_WEEK_TITLE");
		object obj4 = obj2 + 56;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
		object obj5 = default;
		obj4 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		object[] args = default;
		string text = string.Format(format, args);
		((UILabel)_selectedFooterButton).fontSize = (int)text;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7502");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @750E");
		DateTime today = CDateTime.Today;
		nint num3 = (nint)typeof(DateTime);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ S0_v20 (Il2CppClass<System.DateTime>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num4 = (nint)typeof(DateTime);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S0_v49 (Il2CppClass<System.DateTime>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj7 = obj2 + 24;
		object obj8 = default;
		obj7 = obj8;
		object obj9 = obj2 + 16;
		obj9 = today;
		DateTime dateTime = (DateTime)(obj2 + 40);
		((DateTime*)(nint)dateTime)->dateData = (ulong)(long)obj7;
		IFormatProvider formatProvider = (IFormatProvider)(obj2 + 48);
		formatProvider = (IFormatProvider)obj9;
		long num5 = ((DateTime*)dateTime)->System_002EIConvertible_002EToInt64(formatProvider);
		obj = num5;
		object obj10 = obj2 + 8;
		obj10 = obj8;
		formatProvider = (IFormatProvider)obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8E86");
		object obj11 = default;
		if (obj11 == null)
		{
			double num6 = (double)obj * 2.7777777777777777E-11;
			if (!(num6 > 100.0))
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
				nint num7 = (nint)typeof(Strings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ S1_v55 (Il2CppClass<Strings>)+BA]");
				object obj12 = (nint)0 & (nint)0x200;
				if (obj12 != null)
				{
					nint num8 = (nint)typeof(Strings);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v170 @ S1_v72 (Il2CppClass<Strings>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				string text2 = Strings.GetDefault("TOPRUN_STATE_NEXT_IN");
				throw new ArrayTypeMismatchException();
			}
		}
		nint num9 = (nint)typeof(Strings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ S1_v38 (Il2CppClass<Strings>)+BA]");
		object obj13 = (nint)0 & (nint)0x200;
		if (obj13 != null)
		{
			nint num10 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ S1_v45 (Il2CppClass<Strings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string text3 = Strings.GetDefault("TOPRUN_STATE_NEXT_SOON");
		((UILabel)(object)_footerHandler).fontSize = (int)text3;
	}
}
