using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Data.Save;
using InApp;
using Info;
using Kiloo.Common.Extensions;
using SYBO.Common.Visuals;
using SYBO.Subway.Info;
using UI.DoubleCoinsVideo;
using UI.Screens.CharacterScreenInternal;
using UI.Screens.CoinScreenInternal;
using UI.Screens.UpgradeScreenInternal;
using UnityEngine;

namespace UI.Screens;

public class UpgradeScreen : UIScreen
{
	private sealed class _003CReadYPanelPosAfterFrames_003Ed__24 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public int numberofFrames;

		public UpgradeScreen _003C_003E4__this;

		private int _003Cframes_003E5__2;

		object IEnumerator<object>.Current
		{
			get
			{
				//IL_0113: Expected VT, but got Obj
				//IL_012d: Expected F4, but got I
				//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
				//IL_00d2: Expected Obj, but got Unknown
				//IL_00db: Expected Obj, but got I4
				//IL_00ef: Expected Obj, but got I4
				UpgradeScreen upgradeScreen = _003C_003E4__this;
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
					_003Cframes_003E5__2 = 0;
				}
				if (_003Cframes_003E5__2 < numberofFrames)
				{
					int num = _003Cframes_003E5__2 + 1;
					_003Cframes_003E5__2 = num;
					object obj = this + 12;
					obj = 0;
					_003C_003E1__state = 1;
					return 1;
				}
				GameObject gameObject = upgradeScreen._parentDragPanel.gameObject;
				Transform transform = default;
				transform.localPosition = (Vector3)gameObject;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7 (UnityEngine.Transform)+4]");
				upgradeScreen._scrollPanelStartY = 0f;
				upgradeScreen.OnProductRequestDone();
				return null;
			}
		}

		object IEnumerator.Current => _003C_003E2__current;

		public _003CReadYPanelPosAfterFrames_003Ed__24(int _003C_003E1__state)
		{
			//IL_0009: Expected Obj, but got I4
			//IL_002e: Expected Obj, but got I4
			string tag = ((Component)_003C_003E1__state).tag;
			bool flag = this._003C_003E1__state != 0;
			((GameObject)(object)tag).tag = (string)flag;
		}

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

	private sealed class _003CRefreshTable_003Ed__28(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public UpgradeScreen _003C_003E4__this;

		public bool isReturningFromCelebration;

		object IEnumerator<object>.Current
		{
			get
			{
				//IL_0059: Unknown result type (might be due to invalid IL or missing references)
				//IL_005e: Expected Obj, but got Unknown
				//IL_0084: Expected Obj, but got I4
				//IL_009a: Unknown result type (might be due to invalid IL or missing references)
				//IL_009f: Expected Obj, but got Unknown
				//IL_00c5: Expected Obj, but got I4
				UpgradeScreen upgradeScreen = _003C_003E4__this;
				if (_003C_003E1__state != 0)
				{
					if (_003C_003E1__state != 1)
					{
						if (_003C_003E1__state == 2)
						{
							_003C_003E1__state = -1;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7266");
							upgradeScreen._hasRefreshedTable = true;
							if (~(isReturningFromCelebration ? 1u : 0u) == 0)
							{
								upgradeScreen.OnProductRequestDone();
							}
							return null;
						}
						return null;
					}
					_003C_003E1__state = -1;
					object obj = this + 12;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
					object obj2 = default;
					obj = obj2;
					_003C_003E1__state = 2;
					return 1;
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

	public GameObject ConsumablePrefab;

	public GameObject PermanentPrefab;

	private UITable _table;

	private UIPanel _panel;

	private UIScrollView _parentDragPanel;

	public UIScrollBar scrollbar;

	private UIWidget _outline;

	private GameObject listTitleComponent;

	public List<UpgradeHelper> cachedUpgradeHelpers;

	private UIScreenController _screenController;

	private GameObject _bundlesButton;

	private bool _isReturningFromCelebration;

	private bool _facebookLoginRunning;

	[NonSerialized]
	public UpgradeType[] upgradeSingleUse;

	[NonSerialized]
	public UpgradeType[] upgradePermanent;

	public static bool forceScrollRearange;

	private bool _isSubscribedToChangedScreen;

	private static char[] SPLIT_CHARACTER;

	private IEventManager _activeEventManager;

	private float _uiPanelBoundsOffset;

	private float _scrollPanelStartY;

	private bool _hasRefreshedTable;

	private bool _subscribedToEvents;

	private int _numberOfObjects;

	private int _indexExpanded;

	public int indexExpanded
	{
		get
		{
			if (_activeEventManager != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
				object obj = default;
				if ((nint)obj == 4)
				{
					return 1;
				}
			}
			return 0;
		}
		set
		{
			//IL_0023: Expected Obj, but got I4
			if ((string)value != "CelebrationPopup")
			{
				_isReturningFromCelebration = true;
			}
		}
	}

	private void Start()
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected Obj, but got Unknown
		object obj = this + 32;
		obj = string.Empty;
		CancelInvoke();
	}

	private IEnumerator ReadYPanelPosAfterFrames(int numberofFrames)
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

	public override void Init()
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected Obj, but got Unknown
		//IL_0034: Expected I, but got Obj
		//IL_004a: Expected Obj, but got I
		//IL_0075: Expected I, but got Obj
		IEnumerator routine = RefreshTable(isReturningFromCelebration: true);
		Coroutine coroutine = StartCoroutine_Auto(routine);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num = 0;
		_ = 0;
		Action<string> action = default;
		object obj = action + 16;
		obj = this;
		nint num2 = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S0_v17 (Il2CppClass<UIScreenController>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num3 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S0_v23 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		UIScreenController.OnNavigatedToScreen -= action;
		PopupClosed("UpgradesUI_shop");
	}

	public override void Show()
	{
		//IL_0077: Expected I, but got Obj
		//IL_008d: Expected Obj, but got I
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Expected Obj, but got Unknown
		//IL_00c6: Expected Obj, but got I4
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		ShowIfInactive();
		_numberOfObjects = 0;
		SetScrollPanelYForTableElements();
		nint num = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9 (Il2CppClass<UIScreenController>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v17 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj2 = this + 76;
		bool flag = UIScreenController.ShouldShowOnlineScreen();
		obj2 = flag;
		object obj3 = this - -64;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120D9");
	}

	private bool IsJackpotEventActive()
	{
		return false;
	}

	private IEnumerator RefreshTable(bool isReturningFromCelebration)
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

	public unsafe override void Hide()
	{
		//IL_06bb: Expected I, but got Obj
		//IL_06d1: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_0205: Expected I, but got Obj
		//IL_021b: Expected Obj, but got I
		//IL_018c: Expected I, but got Obj
		//IL_0705: Expected I, but got Obj
		//IL_071b: Expected Obj, but got I
		//IL_0054: Expected I, but got Obj
		//IL_07cb: Expected I, but got Obj
		//IL_07e1: Expected Obj, but got I
		//IL_0246: Expected I, but got Obj
		//IL_00a1: Expected I, but got Obj
		//IL_0293: Expected I, but got Obj
		//IL_02a9: Expected Obj, but got I
		//IL_00ee: Expected I, but got Obj
		//IL_0104: Expected Obj, but got I
		//IL_0321: Expected I, but got Obj
		//IL_083c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0841: Expected Obj, but got Unknown
		//IL_084a: Expected Obj, but got I4
		//IL_07a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_07a6: Expected Obj, but got Unknown
		//IL_02d4: Expected I, but got Obj
		//IL_012f: Expected I, but got Obj
		//IL_03fc: Expected I, but got Obj
		//IL_0412: Expected Obj, but got I
		//IL_0855: Unknown result type (might be due to invalid IL or missing references)
		//IL_085a: Expected Obj, but got Unknown
		//IL_087d: Expected Obj, but got I4
		//IL_043d: Expected I, but got Obj
		//IL_089a: Expected I, but got Obj
		//IL_08b0: Expected Obj, but got I
		//IL_04a7: Expected I, but got Obj
		//IL_04bd: Expected Obj, but got I
		//IL_09dd: Expected Obj, but got I4
		//IL_0535: Expected I, but got Obj
		//IL_04e8: Expected I, but got Obj
		//IL_05a6: Expected I, but got Obj
		//IL_05bc: Expected Obj, but got I
		//IL_08f4: Expected I, but got Obj
		//IL_090a: Expected Obj, but got I
		//IL_05e7: Expected I, but got Obj
		//IL_0634: Expected I, but got Obj
		base.Hide();
		if (~(_subscribedToEvents ? 1u : 0u) != 0)
		{
			nint num = (nint)typeof(InAppManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v115 (Il2CppClass<InApp.InAppManager>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(InAppManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ S0_v135 (Il2CppClass<InApp.InAppManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Dictionary<string, InAppItemModel> activeInAppOffers = InAppManager.GetActiveInAppOffers();
			nint num3 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ S1_v81 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ S1_v96 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)(object)activeInAppOffers).FindKernel((string)null) != 0)
			{
				nint num5 = (nint)typeof(InAppManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ S0_v125 (Il2CppClass<InApp.InAppManager>)+BA]");
				object obj3 = (nint)0 & (nint)0x200;
				if (obj3 != null)
				{
					nint num6 = (nint)typeof(InAppManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ S0_v131 (Il2CppClass<InApp.InAppManager>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				Dictionary<string, InAppItemModel> activeInAppOffers2 = InAppManager.GetActiveInAppOffers();
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				nint method_ptr = 0;
				InAppManager.OnProductRequestDone onProductRequestDone = default;
				((Delegate)onProductRequestDone).method_ptr = method_ptr;
				((Delegate)onProductRequestDone).method = (nint)__ldftn(UpgradeScreen.OnProductRequestDone);
				object obj4 = onProductRequestDone + 16;
				obj4 = this;
				((InAppManager)(object)activeInAppOffers2).onProductRequestDone -= onProductRequestDone;
			}
			_subscribedToEvents = true;
		}
		nint num7 = (nint)typeof(UserSave);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S0_v11 (Il2CppClass<Data.Save.UserSave>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num8 = (nint)typeof(UserSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ S0_v110 (Il2CppClass<Data.Save.UserSave>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool hasPaidOutFacebookReward = UserSave.hasPaidOutFacebookReward;
		if ((hasPaidOutFacebookReward ? 1 : 0) == 5 || ((BuyButtonIngame)null).type == UpgradeType._notset)
		{
			nint num9 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ S1_v57 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj6 = (nint)0 & (nint)0x200;
			if (obj6 != null)
			{
				nint num10 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ S1_v74 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)(object)_bundlesButton).FindKernel((string)null) != 0)
			{
				nint num11 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ S1_v63 (Il2CppClass<UnityEngine.Object>)+BA]");
				object obj7 = (nint)0 & (nint)0x200;
				if (obj7 != null)
				{
					nint num12 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v179 @ S1_v70 (Il2CppClass<UnityEngine.Object>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				UnityEngine.Object.DestroyImmediate(_bundlesButton);
				object obj8 = this + 80;
				obj8 = 0;
			}
		}
		nint num13 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ S1_v8 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj9 = (nint)0 & (nint)0x200;
		if (obj9 != null)
		{
			nint num14 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ S1_v51 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)_footerHandler).FindKernel((string)null) != 0)
		{
			_footerHandler._002Ector();
		}
		IEnumerator enumerator = _screenController.DelayHideMainCamera();
		if ((string)(object)enumerator != "GameOverScreen")
		{
			IEnumerator enumerator2 = _screenController.DelayHideMainCamera();
			UIScreen uIScreen = _screenController._ActivateScreen((string)(object)enumerator2);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7281");
			GameOverScreen gameOverScreen = default;
			gameOverScreen.LeaderboardTabTapped();
		}
		nint num15 = (nint)typeof(SSEventsManagerController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v225 @ S0_v29 (Il2CppClass<SSEventsManagerController>)+BA]");
		object obj10 = (nint)0 & (nint)0x200;
		if (obj10 != null)
		{
			nint num16 = (nint)typeof(SSEventsManagerController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v232 @ S0_v89 (Il2CppClass<SSEventsManagerController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj11 = this + 100;
		string flurryUserId = Flurry.flurryUserId;
		bool flag = ((SSEventsManagerController)(object)flurryUserId).DoesCharacterMatchCurrentEvent(Characters.CharacterId.slick);
		obj11 = flag;
		if (indexExpanded != 0)
		{
			nint num17 = (nint)typeof(UpgradeScreen);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v254 @ S0_v77 (Il2CppClass<UI.Screens.UpgradeScreen>)+BA]");
			object obj12 = (nint)0 & (nint)0x200;
			if (obj12 != null)
			{
				nint num18 = (nint)typeof(UpgradeScreen);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v275 @ S0_v83 (Il2CppClass<UI.Screens.UpgradeScreen>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			forceScrollRearange = true;
		}
		nint num19 = (nint)typeof(UpgradeScreen);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v269 @ S0_v39 (Il2CppClass<UI.Screens.UpgradeScreen>)+BA]");
		object obj13 = (nint)0 & (nint)0x200;
		if (obj13 != null)
		{
			nint num20 = (nint)typeof(UpgradeScreen);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v283 @ S0_v70 (Il2CppClass<UI.Screens.UpgradeScreen>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (~(forceScrollRearange ? 1u : 0u) == 0 && ~(_isReturningFromCelebration ? 1u : 0u) != 0)
		{
			nint num21 = (nint)typeof(UpgradeScreen);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v325 @ S0_v53 (Il2CppClass<UI.Screens.UpgradeScreen>)+BA]");
			object obj14 = (nint)0 & (nint)0x200;
			if (obj14 != null)
			{
				nint num22 = (nint)typeof(UpgradeScreen);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v333 @ S0_v64 (Il2CppClass<UI.Screens.UpgradeScreen>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			forceScrollRearange = false;
			nint num23 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v348 @ S1_v32 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj15 = (nint)0 & (nint)0x200;
			if (obj15 != null)
			{
				nint num24 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v354 @ S1_v38 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)(object)_parentDragPanel).FindKernel((string)null) != 0)
			{
				_parentDragPanel.UpdatePosition();
			}
		}
		bool isReturningFromCelebration = _isReturningFromCelebration;
		GameObject routine = ((CoinContainer)(object)this).AddChildPrefab((GameObject)isReturningFromCelebration);
		Coroutine coroutine = StartCoroutine_Auto((IEnumerator)(object)routine);
	}

	public void OnScreenChanged(string screen)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected Obj, but got Unknown
		object obj = this + 36;
		obj = screen;
	}

	private unsafe void OnDestroy()
	{
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_018c: Expected I, but got Obj
		//IL_01a2: Expected Obj, but got I
		//IL_025b: Expected I, but got Obj
		//IL_0271: Expected Obj, but got I
		//IL_0054: Expected I, but got Obj
		//IL_01cd: Expected I, but got Obj
		//IL_00a1: Expected I, but got Obj
		//IL_00ee: Expected I, but got Obj
		//IL_0104: Expected Obj, but got I
		//IL_02f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fc: Expected Obj, but got Unknown
		//IL_012f: Expected I, but got Obj
		base.LoseFocus();
		if (~(_subscribedToEvents ? 1u : 0u) == 0)
		{
			nint num = (nint)typeof(InAppManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v24 (Il2CppClass<InApp.InAppManager>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(InAppManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ S0_v44 (Il2CppClass<InApp.InAppManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Dictionary<string, InAppItemModel> activeInAppOffers = InAppManager.GetActiveInAppOffers();
			nint num3 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ S1_v9 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ S1_v24 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)(object)activeInAppOffers).FindKernel((string)null) != 0)
			{
				nint num5 = (nint)typeof(InAppManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ S0_v34 (Il2CppClass<InApp.InAppManager>)+BA]");
				object obj3 = (nint)0 & (nint)0x200;
				if (obj3 != null)
				{
					nint num6 = (nint)typeof(InAppManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ S0_v40 (Il2CppClass<InApp.InAppManager>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				Dictionary<string, InAppItemModel> activeInAppOffers2 = InAppManager.GetActiveInAppOffers();
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				nint method_ptr = 0;
				InAppManager.OnPurchaseSuccess onPurchaseSuccess = default;
				((Delegate)onPurchaseSuccess).method_ptr = method_ptr;
				((Delegate)onPurchaseSuccess).method = (nint)__ldftn(UpgradeScreen.OnProductRequestDone);
				object obj4 = onPurchaseSuccess + 16;
				obj4 = this;
				((InAppManager)(object)activeInAppOffers2).onPurchaseSuccess += onPurchaseSuccess;
			}
			_subscribedToEvents = false;
		}
		if (~(_facebookLoginRunning ? 1u : 0u) != 0)
		{
			return;
		}
		nint num7 = (nint)typeof(HouseKeeper);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v13 (Il2CppClass<HouseKeeper>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num8 = (nint)typeof(HouseKeeper);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ S0_v19 (Il2CppClass<HouseKeeper>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		HouseKeeper.DeleteSoundOptionBeforeVideoAds();
		_facebookLoginRunning = false;
	}

	private void PopupClosed(string popupName)
	{
		//IL_01d2: Expected I4, but got Obj
		//IL_012c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0131: Expected Obj, but got Unknown
		//IL_0144: Expected I, but got Obj
		//IL_015a: Expected Obj, but got I
		//IL_0046: Expected Obj, but got I
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Expected Obj, but got Unknown
		//IL_0067: Expected I, but got Obj
		//IL_007d: Expected Obj, but got I
		//IL_0185: Expected I, but got Obj
		//IL_00a8: Expected I, but got Obj
		char c = popupName.get_Chars((int)"UpgradesUI_shop");
		bool isSubscribedToChangedScreen = _isSubscribedToChangedScreen;
		if (c != '\0')
		{
			if (!isSubscribedToChangedScreen)
			{
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint cachedPtr = 0;
			UIScreenController uIScreenController = default;
			((UnityEngine.Object)uIScreenController).m_CachedPtr = cachedPtr;
			uIScreenController.popupAnchor = (GameObject)0;
			object obj = uIScreenController + 16;
			obj = this;
			nint num = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ S0_v42 (Il2CppClass<UIScreenController>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num2 = (nint)typeof(UIScreenController);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ S0_v49 (Il2CppClass<UIScreenController>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			uIScreenController.Awake();
			_isReturningFromCelebration = false;
			_isSubscribedToChangedScreen = false;
		}
		else
		{
			if (isSubscribedToChangedScreen)
			{
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num3 = 0;
			_ = 0;
			Action<string> action = default;
			object obj3 = action + 16;
			obj3 = this;
			nint num4 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ S0_v20 (Il2CppClass<UIScreenController>)+BA]");
			object obj4 = (nint)0 & (nint)0x200;
			if (obj4 != null)
			{
				nint num5 = (nint)typeof(UIScreenController);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ S0_v26 (Il2CppClass<UIScreenController>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			UIScreenController.OnPopupClosed -= action;
			_isSubscribedToChangedScreen = true;
		}
	}

	public void SaleEnded()
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected Obj, but got Unknown
		//IL_003e: Expected I, but got Obj
		//IL_0054: Expected Obj, but got I
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Expected Obj, but got Unknown
		//IL_007f: Expected I, but got Obj
		UIScreenController screenController = _screenController;
		if (~(screenController.stoppingFromEditor ? 1u : 0u) == 0)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num = 0;
		_ = 0;
		Action<string> action = default;
		object obj = action + 16;
		obj = this;
		nint num2 = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S0_v20 (Il2CppClass<UIScreenController>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num3 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ S0_v35 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		UIScreenController.OnWillShowScreen += action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num4 = 0;
		_ = 0;
		Action<string> action2 = default;
		object obj3 = action2 + 16;
		obj3 = this;
		UIScreenController.OnWillShowScreen += action2;
	}

	private void FillTable()
	{
		//IL_0010: Expected Obj, but got I4
		_table.Sort((List<Transform>)1);
	}

	private GameObject MakeBuyable(UpgradeType upgradeType, bool permanent)
	{
		//IL_00fb: Expected I, but got Obj
		//IL_0111: Expected Obj, but got I
		//IL_0187: Expected Obj, but got I
		//IL_00ed: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0134: Unknown result type (might be due to invalid IL or missing references)
		//IL_0139: Expected Obj, but got Unknown
		//IL_0146: Expected Obj, but got I4
		//IL_0146: Expected Obj, but got I4
		//IL_0163: Expected Obj, but got I
		//IL_00a1: Expected I, but got Obj
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S1_v3 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v15 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.Screens.UpgradeScreen)+114]");
		if ((UnityEngine.Object)0 != null)
		{
			nint num3 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v12 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ S0_v21 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			object obj3 = this + 276;
			UI.DoubleCoinsVideo.DoubleCoinsVideo doubleCoinsVideo = UnityEngine.Object.Instantiate((UI.DoubleCoinsVideo.DoubleCoinsVideo)upgradeType, (Transform)permanent);
			obj3 = doubleCoinsVideo;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.Screens.UpgradeScreen)+114]");
			GameObject uiGrid = ((Component)0).gameObject;
			UIExtensions.RepositionImmediately((UIGrid)(object)uiGrid);
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.Screens.UpgradeScreen)+114]");
		return (GameObject)0;
	}

	private void AdjustForUIPanelBoundsOffset(Vector3 offset)
	{
		//IL_000a: Expected I4, but got VT
		_indexExpanded = (int)offset;
	}

	private unsafe void SetScrollPanelYForTableElements()
	{
		//IL_0357: Expected I, but got Obj
		//IL_036d: Expected Obj, but got I
		//IL_0399: Expected I4, but got Obj
		//IL_03a6: Expected Obj, but got I4
		//IL_03b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b8: Expected Obj, but got Unknown
		//IL_03c2: Expected Obj, but got I4
		//IL_0071: Expected I4, but got Obj
		//IL_0071: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_0084: Expected I, but got Obj
		//IL_009a: Expected Obj, but got I
		//IL_03e8: Expected Obj, but got I4
		//IL_03f7: Expected Obj, but got F4
		//IL_0412: Unknown result type (might be due to invalid IL or missing references)
		//IL_0417: Expected I4, but got Unknown
		//IL_0424: Expected I4, but got Obj
		//IL_0447: Expected I4, but got Obj
		//IL_046c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0471: Expected Obj, but got Unknown
		//IL_047a: Expected Obj, but got I4
		//IL_00c5: Expected I, but got Obj
		//IL_0194: Expected I, but got Obj
		//IL_01aa: Expected Obj, but got I
		//IL_04b5: Expected I4, but got Obj
		//IL_04c2: Expected Obj, but got I4
		//IL_04d0: Expected Obj, but got I4
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0114: Expected Obj, but got Unknown
		//IL_013e: Expected I4, but got Obj
		//IL_0165: Unknown result type (might be due to invalid IL or missing references)
		//IL_016a: Expected Obj, but got Unknown
		//IL_0233: Expected I4, but got Obj
		//IL_0233: Expected Obj, but got I4
		//IL_01d5: Expected I, but got Obj
		//IL_0246: Expected I, but got Obj
		//IL_025c: Expected Obj, but got I
		//IL_04f6: Expected Obj, but got I4
		//IL_0505: Expected Obj, but got F4
		//IL_0524: Expected I4, but got Obj
		//IL_0547: Expected I4, but got Obj
		//IL_056c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0571: Expected Obj, but got Unknown
		//IL_057a: Expected Obj, but got I4
		//IL_0287: Expected I, but got Obj
		//IL_02d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d6: Expected Obj, but got Unknown
		//IL_0300: Expected I4, but got Obj
		//IL_0327: Unknown result type (might be due to invalid IL or missing references)
		//IL_032c: Expected Obj, but got Unknown
		string go = _table.tag;
		nint num = (nint)typeof(NGUITools);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S2_v2 (Il2CppClass<NGUITools>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S2_v67 (Il2CppClass<NGUITools>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		int num3 = NGUITools.CalculateNextDepth((GameObject)(object)go, (byte)(int)listTitleComponent != 0);
		ListTitleComponentHelper component = ((GameObject)num3).GetComponent<ListTitleComponentHelper>();
		object obj3 = default;
		object obj2 = obj3 + 16;
		obj2 = _numberOfObjects;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		object[] args = default;
		string text = $"{args:000}";
		UnityEngine.Object.DestroyImmediate((UnityEngine.Object)num3, (byte)(int)text != 0);
		nint num4 = (nint)typeof(Strings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ S1_v15 (Il2CppClass<Strings>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num5 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ S1_v74 (Il2CppClass<Strings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string text2 = Strings.GetDefault("UPGRADE_SCREEN_SINGLE_USE");
		obj3 = 0;
		_ = 0;
		obj3 = 0f;
		_ = 74f / 255f;
		_ = 128f / 255f;
		_ = 1f;
		int num6 = obj3 + 24;
		((int*)num6)->m_value = (int)obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		((MeshMorpher)(object)component).BuildMesh((int)text2, num6, -145f);
		int numberOfObjects = _numberOfObjects + 1;
		_numberOfObjects = numberOfObjects;
		object obj5 = upgradeSingleUse + 12;
		object obj6 = 0;
		while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj6) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj5))
		{
			object obj7 = upgradeSingleUse + 16;
			object obj8 = obj6 << 2;
			object obj9 = obj7 + obj8;
			List<CharacterScrollListSlot> prioritizedPendingSlots = ((CharacterListManager)(object)this).GetPrioritizedPendingSlots((int)obj9, false);
			int numberOfObjects2 = _numberOfObjects + 1;
			_numberOfObjects = numberOfObjects2;
			object obj10 = obj6 + 1;
			obj6 = obj10;
		}
		string go2 = _table.tag;
		nint num7 = (nint)typeof(NGUITools);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ S2_v29 (Il2CppClass<NGUITools>)+BA]");
		object obj11 = (nint)0 & (nint)0x200;
		if (obj11 != null)
		{
			nint num8 = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ S2_v58 (Il2CppClass<NGUITools>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		int num9 = NGUITools.CalculateNextDepth((GameObject)(object)go2, (byte)(int)listTitleComponent != 0);
		ListTitleComponentHelper component2 = ((GameObject)num9).GetComponent<ListTitleComponentHelper>();
		obj2 = _numberOfObjects;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		object[] args2 = default;
		string text3 = $"{args2:000}";
		UnityEngine.Object.DestroyImmediate((UnityEngine.Object)num9, (byte)(int)text3 != 0);
		nint num10 = (nint)typeof(Strings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v191 @ S1_v40 (Il2CppClass<Strings>)+BA]");
		object obj12 = (nint)0 & (nint)0x200;
		if (obj12 != null)
		{
			nint num11 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v197 @ S1_v62 (Il2CppClass<Strings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string text4 = Strings.GetDefault("UPGRADES_TITLE");
		obj3 = 0;
		_ = 0;
		obj3 = 0f;
		_ = 74f / 255f;
		_ = 128f / 255f;
		_ = 1f;
		((int*)num6)->m_value = (int)obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		((MeshMorpher)(object)component2).BuildMesh((int)text4, num6, -142f);
		int numberOfObjects3 = _numberOfObjects + 1;
		_numberOfObjects = numberOfObjects3;
		object obj13 = upgradePermanent + 12;
		object obj14 = 0;
		while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj14) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj13))
		{
			object obj15 = upgradePermanent + 16;
			object obj16 = obj14 << 2;
			object obj17 = obj15 + obj16;
			List<CharacterScrollListSlot> prioritizedPendingSlots2 = ((CharacterListManager)(object)this).GetPrioritizedPendingSlots((int)obj17, true);
			int numberOfObjects4 = _numberOfObjects + 1;
			_numberOfObjects = numberOfObjects4;
			object obj18 = obj14 + 1;
			obj14 = obj18;
		}
	}

	private unsafe void MakeTableElementAlwaysVisible(GameObject go, int index)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0281: Unknown result type (might be due to invalid IL or missing references)
		//IL_0286: Expected Obj, but got Unknown
		//IL_028f: Expected Obj, but got I4
		//IL_029e: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a3: Expected Obj, but got Unknown
		//IL_02bf: Expected I, but got Obj
		//IL_02d5: Expected Obj, but got I
		//IL_0021: Expected I, but got Obj
		//IL_02fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0300: Expected Obj, but got Unknown
		//IL_0309: Unknown result type (might be due to invalid IL or missing references)
		//IL_030e: Expected Obj, but got Unknown
		//IL_033a: Expected Obj, but got I4
		//IL_01e3: Expected Obj, but got I
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Expected Obj, but got Unknown
		//IL_0221: Unknown result type (might be due to invalid IL or missing references)
		//IL_0226: Expected Obj, but got Unknown
		//IL_012e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0133: Expected Obj, but got Unknown
		//IL_0257: Unknown result type (might be due to invalid IL or missing references)
		//IL_025c: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 48;
		object obj3 = obj2 + 24;
		obj3 = 0;
		_ = 0;
		object obj4 = obj2 + 16;
		obj4 = obj;
		_ = -1;
		nint num = (nint)typeof(LeaderboardDummyData);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v18 (Il2CppClass<LeaderboardDummyData>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num2 = (nint)typeof(LeaderboardDummyData);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S0_v107 (Il2CppClass<LeaderboardDummyData>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (LeaderboardDummyData.dummyData == null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @727C");
		obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		object obj6 = default;
		object obj8 = default;
		object obj9 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			if (obj6 == null)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
			_ = 2;
			object obj7 = obj8 + 16;
			obj7 = obj9;
			int num3 = ((int*)index)->m_value & 1;
			bool flag = num3 == 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
			object obj10 = go + 1;
			GameObject gameObject = (GameObject)obj10;
			int value = ((int*)index)->m_value + 1;
			((int*)index)->m_value = value;
		}
		object obj11 = obj4 + 4;
		object obj12 = obj11 + 1;
		obj11 = obj12;
		object obj13 = obj12 << 2;
		object obj14 = obj4 + obj13;
		obj14 = 114;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
			object obj15 = (nint)0 << 2;
			object obj16 = obj4 + obj15;
			if ((nint)obj16 == 114)
			{
				object obj17 = obj4 + 4;
				if ((nint)obj17 > -1)
				{
					object obj18 = obj17 + -1;
					obj17 = obj18;
				}
				return;
			}
		}
		object obj19 = default;
		if (obj19 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
	}

	public bool IsLastElementOpen()
	{
		return (byte)_indexExpanded != 0;
	}

	private bool BundlesActiveInThisLocale()
	{
		//IL_00ae: Expected Obj, but got I
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Expected Obj, but got Unknown
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Expected Obj, but got Unknown
		//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ea: Expected Obj, but got Unknown
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected Obj, but got Unknown
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Expected Obj, but got Unknown
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ S2_v2 (Il2CppMethodInfo)+18]");
		object obj = 0;
		object obj2 = obj;
		object obj3 = obj2 & 0x1FFF;
		object obj4 = obj3 + 22691;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v25 @ S3_v4 (should have been resolved before IL gen)");
		object obj6 = default;
		object obj5 = obj6 + 12;
		bool flag = false;
		object obj7 = default;
		object obj11 = default;
		while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj7) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj5))
		{
			object obj8 = obj6 + 16;
			object obj9 = obj7 << 2;
			object obj10 = obj8 + obj9;
			TableElementAlwaysVisible tableElementAlwaysVisible = (TableElementAlwaysVisible)obj10;
			bool flag2 = tableElementAlwaysVisible._index == _indexExpanded;
			bool flag3 = !flag2;
			int num2 = (flag ? 1 : 0);
			if (!flag3)
			{
				int index = tableElementAlwaysVisible.index;
				int num3 = (flag ? 1 : 0) | index;
				num2 = num3;
			}
			obj7 = obj11 + 1;
			flag = (byte)num2 != 0;
		}
		return flag;
	}

	private void OnProductRequestDone()
	{
		//IL_0080: Expected Obj, but got I
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Expected Obj, but got Unknown
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Expected Obj, but got Unknown
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Expected Obj, but got Unknown
		//IL_00c5: Expected Obj, but got I4
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected Obj, but got Unknown
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Expected Obj, but got Unknown
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ S2_v2 (Il2CppMethodInfo)+18]");
		object obj = 0;
		object obj2 = obj;
		object obj3 = obj2 & 0x1FFF;
		object obj4 = obj3 + 22691;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v25 @ S3_v4 (should have been resolved before IL gen)");
		object obj6 = default;
		object obj5 = obj6 + 12;
		object obj7 = 0;
		while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj7) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj5))
		{
			object obj8 = obj6 + 16;
			object obj9 = obj7 << 2;
			object obj10 = obj8 + obj9;
			object obj11 = obj10;
			float num2 = _scrollPanelStartY + _uiPanelBoundsOffset;
			object obj12 = obj7 + 1;
			obj7 = obj12;
		}
	}

	public UpgradeScreen()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7266");
	}
}
