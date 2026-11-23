using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2ILInjected;
using DanielLochner.Assets.SimpleScrollSnap;
using Kiloo.Common.Utility;
using TMPro;
using UI.Screens;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class BoardScreen : UIScreen
{
	private class BoardState
	{
		public Quaternion defaultRotation;

		public GameObject boardRoot;

		public Transform boardTransform;
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static UnityAction _003C_003E9__29_0;

		static _003C_003Ec()
		{
			_003C_003Ec obj = default;
			_003C_003E9 = obj;
		}

		internal void _003COnEnable_003Eb__29_0()
		{
			UIScreenController instance = UIScreenController.Instance;
			instance.CloseActivePopups("MeScreen");
		}
	}

	private sealed class _003CDelayedRefreshEventBoardAndUI_003Ed__38(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public BoardScreen _003C_003E4__this;

		object IEnumerator<object>.Current => _003C_003E2__current;

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			if (_003C_003E1__state != 0)
			{
				if (_003C_003E1__state == 1)
				{
					_003C_003E1__state = -1;
					_003C_003E4__this.RefreshEventBoardAndUI();
				}
				return false;
			}
			_003C_003E1__state = -1;
			object obj = default;
			_003C_003E2__current = obj;
			_003C_003E1__state = 1;
			return true;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			NotSupportedException ex = default;
			ex._002Ector();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
		}
	}

	private sealed class _003CShowScroll_003Ed__45(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public BoardScreen _003C_003E4__this;

		object IEnumerator<object>.Current => _003C_003E2__current;

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			BoardScreen boardScreen = _003C_003E4__this;
			if (_003C_003E1__state != 0)
			{
				if (_003C_003E1__state == 1)
				{
					_003C_003E1__state = -1;
					GameObject gameObject = boardScreen.boardScroll.gameObject;
					gameObject.SetActive(value: true);
				}
				return false;
			}
			_003C_003E1__state = -1;
			GameObject gameObject2 = boardScreen.boardScroll.gameObject;
			gameObject2.SetActive(value: false);
			object obj = default;
			_003C_003E2__current = obj;
			_003C_003E1__state = 1;
			return true;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			NotSupportedException ex = default;
			ex._002Ector();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
		}
	}

	private GameObject scroll2dElements;

	private GameObject _centerAnchor;

	private GameObject dummyObject;

	private TMP_Text nameLabel;

	private TMP_Text staticPowerupLabel;

	private TMP_Text descriptionLabel;

	private Image powerIcon;

	private TMP_Text themeLimitedLabel;

	private UIHoverboardThemeShifter _hoverboardThemeShifter;

	private HoverboardSelectButton HoverboardSelectButton;

	private AudioClip selectSound;

	private GameObject themePower;

	private TMP_Text themePowerLabel;

	private CenterOnChild _centerer;

	private List<ListBoardCell> ListBoardCells;

	private ListBoardCell ListBoardCell;

	private Transform boardContent;

	private List<KeyValuePair<Hoverboards.BoardType, Hoverboards.Board>> boardList;

	private List<HoverboardOverlayHelper> boardHelpers;

	private List<Transform> listBoard;

	private bool _oldHoverboardOwned;

	private bool _inappOverlayActive;

	private bool _popupActive;

	public MeScreen MeScreen;

	private SimpleScrollSnap boardScroll;

	private int currentId;

	private Button closeButton;

	private Hoverboards.BoardType currentBoard;

	private unsafe void OnEnable()
	{
		currentId = -1;
		Button button = closeButton;
		bool flag = _003C_003Ec._003C_003E9__29_0 == null;
		bool flag2 = !flag;
		UnityAction call = _003C_003Ec._003C_003E9__29_0;
		if (!flag2)
		{
			UnityAction unityAction = default;
			unityAction._002Ector(_003C_003Ec._003C_003E9, (nint)__ldftn(_003C_003Ec._003COnEnable_003Eb__29_0));
			_003C_003Ec._003C_003E9__29_0 = unityAction;
			call = unityAction;
		}
		button.m_OnClick.AddListener(call);
		SimpleScrollSnap simpleScrollSnap = boardScroll;
		UnityAction unityAction2 = default;
		unityAction2._002Ector(this, (nint)__ldftn(BoardScreen._003COnEnable_003Eb__29_1));
		simpleScrollSnap.onPanelChanged.AddListener(unityAction2);
		IEnumerator routine = ShowScroll();
		Coroutine coroutine = StartCoroutine(routine);
	}

	public void SelectedBoard(int id)
	{
		if (id != currentId)
		{
			boardScroll.GoToPanel(id);
		}
	}

	private void ChangePanel(int id)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Expected Obj, but got Unknown
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Expected Obj, but got Unknown
		//IL_0379: Unknown result type (might be due to invalid IL or missing references)
		//IL_037e: Expected Obj, but got Unknown
		//IL_035a: Unknown result type (might be due to invalid IL or missing references)
		//IL_035f: Expected Obj, but got Unknown
		//IL_0287: Unknown result type (might be due to invalid IL or missing references)
		//IL_028c: Expected Obj, but got Unknown
		//IL_00fe: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 48;
		_ = 0;
		_ = 0;
		HoverboardOverlayHelper hoverboardOverlayHelper = boardHelpers.get_Item(id);
		BoardScreenManager instance = BoardScreenManager.Instance;
		if (hoverboardOverlayHelper._cachedType != instance.currentlyShownBoard__BackingField)
		{
			BoardScreenManager instance2 = BoardScreenManager.Instance;
			instance2.ChangedDisplayedHoverboard(hoverboardOverlayHelper._cachedType);
		}
		ShowHoverboardInMenu(willUpdateAnimation: true, willAllowSignatureAnimation: true);
		HoverboardOverlayHelper hoverboardOverlayHelper2 = boardHelpers.get_Item(id);
		hoverboardOverlayHelper2.SelectedInMenu();
		object obj3 = obj + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B5");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
		_ = 0;
		object obj4 = obj + 32;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		_ = 0;
		object obj6 = default;
		object obj8 = default;
		object obj9 = default;
		object obj11 = default;
		object obj12 = default;
		while (true)
		{
			_ = 0;
			object obj5 = obj + 32;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				if (obj6 == null)
				{
					break;
				}
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+2C]");
				object obj7 = 0;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ S0_v76+10]");
					if ((nint)0 == id)
					{
						continue;
					}
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						continue;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
			bool flag = obj8 == obj9;
			bool flag2 = !flag;
			object obj10 = obj11;
			if (!flag2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				obj10 = obj12;
			}
			_ = 0;
			object obj13 = obj + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 == 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
			break;
		}
		object obj14 = obj + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3AE6");
	}

	public override void Init()
	{
		//IL_0076: Expected I, but got Obj
		nint num = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v13 @ S1_v3 (Il2CppClass<BoardScreen>)+104] (should have been resolved before IL gen)");
		GameObject gameObject = base.gameObject;
		gameObject.SetActive(value: true);
		SyncPositionHelper component = GetComponent<SyncPositionHelper>();
		if (component != null)
		{
			MeScreen meScreen = MeScreen;
			component.toObject = meScreen.toObject;
		}
		MeScreen meScreen2 = MeScreen;
		meScreen2.toObject.SetActive(value: false);
		InitializeSelectButton();
		UIHoverboardThemeShifter hoverboardThemeShifter = _hoverboardThemeShifter;
		hoverboardThemeShifter._context = HoverboardManager.ScreenContext.BoardScreen;
		throw new ArgumentException();
	}

	public unsafe override void Show()
	{
		base.Show();
		Action action = default;
		action._002Ector(this, (nint)__ldftn(BoardScreen.RefreshIfPopupNotActive));
		UIScreenController.OnApplicationResumed += action;
		Action action2 = default;
		action2._002Ector(this, (nint)__ldftn(BoardScreen.RefreshEventBoardAndUI));
		SSEventsManagerController.OnSSEventStartedHandler += action2;
		Action action3 = default;
		action3._002Ector(this, (nint)__ldftn(BoardScreen.RefreshEventBoardAndUI));
		SSEventsManagerController.OnSSEventFinishedHandler += action3;
		Action action4 = default;
		action4._002Ector(this, (nint)__ldftn(BoardScreen.UpdateUIElements));
		HoverboardManager.OnBoardSelected += action4;
		throw new ArgumentException();
	}

	private void OnBoardSelected()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_04a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_04aa: Expected Obj, but got Unknown
		//IL_04d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_04dc: Expected Obj, but got Unknown
		//IL_055c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0561: Expected Obj, but got Unknown
		//IL_0502: Unknown result type (might be due to invalid IL or missing references)
		//IL_0507: Expected Obj, but got Unknown
		//IL_0422: Unknown result type (might be due to invalid IL or missing references)
		//IL_0427: Expected Obj, but got Unknown
		//IL_004e: Expected Obj, but got I
		//IL_05b1: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 48;
		_ = 0;
		_ = 0;
		object obj3 = obj + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B5");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
		_ = 0;
		object obj4 = obj + 32;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		_ = 0;
		object obj6 = default;
		object obj7;
		int startingPanel = default;
		object obj10 = default;
		int num3 = default;
		object obj11 = default;
		object obj12 = default;
		object obj14 = default;
		object obj15 = default;
		while (true)
		{
			_ = 0;
			object obj5 = obj + 32;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				bool flag = obj6 == null;
				obj7 = obj;
				if (flag)
				{
					break;
				}
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+2C]");
				object obj8 = 0;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 != 1)
						{
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ S0_v66+1C]");
							nint num = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v172 @ S0_v80+10]");
							bool flag2 = num == 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @E");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							if ((nint)0 != 1)
							{
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
								if ((nint)0 != 1)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v298 @ S0_v110+10]");
									nint num2 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ S0_v66+1C]");
									if (num2 == 0)
									{
										currentId = startingPanel;
										SimpleScrollSnap simpleScrollSnap = boardScroll;
										simpleScrollSnap.startingPanel = startingPanel;
										object obj9 = "selected";
									}
									else
									{
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
										if ((nint)0 == 1)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
											goto IL_0350;
										}
										object obj9 = "unlock";
										if (obj10 == null)
										{
											obj9 = "lock";
										}
									}
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @12");
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
									if ((nint)0 != 1)
									{
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
										if ((nint)0 != 1)
										{
											_ = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
											_ = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
											if ((nint)0 != 1)
											{
												startingPanel = num3 + 1;
												continue;
											}
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
									}
									else
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
									}
								}
								else
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
								}
								goto IL_0350;
							}
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			}
			goto IL_0350;
			IL_0350:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
			bool flag3 = obj11 == obj12;
			bool flag4 = !flag3;
			object obj13 = obj14;
			if (!flag4)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				bool flag5 = (nint)0 != 1;
				obj7 = obj;
				if (flag5)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				obj13 = obj15;
			}
			_ = 0;
			object obj16 = obj + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 == 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			obj7 = 0;
			break;
		}
		object obj17 = obj7 + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B203");
	}

	public unsafe override void Hide()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 48;
		_ = 0;
		_ = 0;
		base.Hide();
		Action action = default;
		action._002Ector(this, (nint)__ldftn(BoardScreen.RefreshIfPopupNotActive));
		UIScreenController.OnApplicationResumed -= action;
		Action action2 = default;
		action2._002Ector(this, (nint)__ldftn(BoardScreen.RefreshEventBoardAndUI));
		SSEventsManagerController.OnSSEventStartedHandler -= action2;
		Action action3 = default;
		action3._002Ector(this, (nint)__ldftn(BoardScreen.RefreshEventBoardAndUI));
		SSEventsManagerController.OnSSEventFinishedHandler -= action3;
		Action action4 = default;
		action4._002Ector(this, (nint)__ldftn(BoardScreen.UpdateUIElements));
		HoverboardManager.OnBoardSelected -= action4;
		throw new ArgumentException();
	}

	private void RefreshIfPopupNotActive()
	{
		if (~(_inappOverlayActive ? 1u : 0u) == 0 || ~(_popupActive ? 1u : 0u) == 0)
		{
			BoardScreenManager instance = BoardScreenManager.Instance;
			instance.refreshBoardsWhenNotShowingPopup__BackingField = true;
		}
		else
		{
			IEnumerator coroutine = DelayedRefreshEventBoardAndUI();
			Coroutine coroutine2 = CoroutineUtil.StartCoroutine(coroutine);
		}
	}

	private void InitializeSelectButton()
	{
		HoverboardSelectButton.InitButton(HoverboardManager.ScreenContext.BoardScreen);
	}

	private IEnumerator DelayedRefreshEventBoardAndUI()
	{
		_ = 0;
		IEnumerator result = default;
		return result;
	}

	private void RefreshEventBoardAndUI()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_00b2: Expected Obj, but got I8
		//IL_00bf: Expected VT, but got Obj
		object obj2 = default;
		object obj = obj2 - 32;
		SSEventsManagerController instance = SSEventsManagerController.instance;
		instance.RestoreBoardAfterEventIfNeeded();
		SSEventsManagerController instance2 = SSEventsManagerController.instance;
		IEventManager activeEventManager = instance2.GetActiveEventManager();
		UIModelController instance3 = UIModelController.Instance;
		GameObject gameObject = instance3.ActivateHoverboardModel();
		if (gameObject != null)
		{
			ScaleByUI scaleByUI = gameObject.AddComponent<ScaleByUI>();
			MeScreen meScreen = MeScreen;
			_ = 1101529088;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
			_ = 0;
			_ = 4731031409654235136L;
			obj = 4731031409654235136L;
			scaleByUI.startScale = (Vector3)obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
			_ = 0;
			scaleByUI.follow = meScreen.center;
		}
		ShowHoverboardInMenu(willUpdateAnimation: true, willAllowSignatureAnimation: false);
	}

	private void OnThemeActiveStateChanged(Hoverboard.BoardAbility boardAbility)
	{
		ShowHoverboardInMenu(willUpdateAnimation: true, willAllowSignatureAnimation: true, boardAbility);
	}

	public void ShowHoverboardInMenu(bool willUpdateAnimation, bool willAllowSignatureAnimation, Hoverboard.BoardAbility ability = Hoverboard.BoardAbility.None)
	{
		UIModelController instance = UIModelController.Instance;
		BoardScreenManager instance2 = BoardScreenManager.Instance;
		instance.ShowHoverboardMenuModel(instance2.currentlyShownBoard__BackingField, willUpdateAnimation, willAllowSignatureAnimation, ability);
		UpdateUIElements();
	}

	private void UpdateUIElements()
	{
		//IL_0157: Expected I, but got Obj
		//IL_0160: Unknown result type (might be due to invalid IL or missing references)
		//IL_0165: Expected Obj, but got Unknown
		//IL_0198: Expected I, but got Obj
		//IL_01a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a6: Expected Obj, but got Unknown
		//IL_01d4: Expected I, but got Obj
		//IL_01dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e2: Expected Obj, but got Unknown
		//IL_0211: Expected I, but got Obj
		//IL_021a: Unknown result type (might be due to invalid IL or missing references)
		//IL_021f: Expected Obj, but got Unknown
		//IL_027d: Expected Obj, but got I4
		//IL_0261: Expected Obj, but got I4
		//IL_02a7: Expected Obj, but got I4
		//IL_047b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0480: Expected I4, but got Unknown
		//IL_04a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ac: Expected I4, but got Unknown
		//IL_028b: Expected Obj, but got I4
		//IL_03d0: Expected I, but got Obj
		//IL_03d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03de: Expected Obj, but got Unknown
		//IL_03fa: Expected I, but got Obj
		//IL_0403: Unknown result type (might be due to invalid IL or missing references)
		//IL_0408: Expected Obj, but got Unknown
		BoardScreenManager instance = BoardScreenManager.Instance;
		if (~(instance.shouldResetThemeSelection__BackingField ? 1u : 0u) == 0)
		{
			BoardScreenManager instance2 = BoardScreenManager.Instance;
			instance2.shouldResetThemeSelection__BackingField = false;
			BoardScreenManager instance3 = BoardScreenManager.Instance;
			instance3.currentlyShownThemeIndex__BackingField = 0;
			_hoverboardThemeShifter.ResetThemeSelection();
		}
		BoardScreenManager instance4 = BoardScreenManager.Instance;
		if (instance4.currentlyShownThemeIndex__BackingField != 0)
		{
			BoardScreenManager instance5 = BoardScreenManager.Instance;
			List<HoverboardThemes.HoverboardTheme> list = HoverboardThemes.TryGetCustomThemesForBoard(instance5.currentlyShownBoard__BackingField);
			if (list != null)
			{
				BoardScreenManager instance6 = BoardScreenManager.Instance;
				if (instance6.currentlyShownThemeIndex__BackingField <= list._size)
				{
					goto IL_0109;
				}
			}
			BoardScreenManager instance7 = BoardScreenManager.Instance;
			instance7.currentlyShownThemeIndex__BackingField = 0;
			_hoverboardThemeShifter.ResetThemeSelection();
		}
		goto IL_0109;
		IL_0472:
		object obj;
		bool flag = (byte)(obj ^ 1) != 0;
		powerIcon.enabled = flag;
		staticPowerupLabel.enabled = flag;
		object obj2;
		bool flag2 = (byte)(obj2 ^ 1) != 0;
		themeLimitedLabel.enabled = flag2;
		BoardScreenManager instance8 = BoardScreenManager.Instance;
		if (instance8.currentlyShownThemeIndex__BackingField == 0)
		{
			themePower.SetActive(value: false);
			GameObject gameObject = nameLabel.gameObject;
			gameObject.SetActive(value: true);
		}
		else
		{
			themePower.SetActive(value: true);
			GameObject gameObject2 = nameLabel.gameObject;
			gameObject2.SetActive(value: false);
			TMP_Text tMP_Text = themePowerLabel;
			BoardScreenManager instance9 = BoardScreenManager.Instance;
			List<HoverboardThemes.HoverboardTheme> list2 = HoverboardThemes.hoverboardCustomThemes.get_Item(instance9.currentlyShownBoard__BackingField);
			BoardScreenManager instance10 = BoardScreenManager.Instance;
			int index = instance10.currentlyShownThemeIndex__BackingField - 1;
			HoverboardThemes.HoverboardTheme hoverboardTheme = list2.get_Item(index);
			string text = Strings.Get(hoverboardTheme.title);
			nint num = (nint)tMP_Text;
			object obj3 = tMP_Text + 528;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v280 @ S2_v41 (Il2CppClass<TMPro.TMP_Text>)+2CC] (should have been resolved before IL gen)");
			TMP_Text tMP_Text2 = themeLimitedLabel;
			nint num2 = (nint)tMP_Text2;
			object obj4 = tMP_Text2 + 528;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v294 @ S2_v45 (Il2CppClass<TMPro.TMP_Text>)+2CC] (should have been resolved before IL gen)");
		}
		BoardScreenManager instance11 = BoardScreenManager.Instance;
		BoardScreenManager instance12 = BoardScreenManager.Instance;
		HoverboardSelectButton.UpdateSticker(instance11.currentlyShownBoard__BackingField, instance12.currentlyShownThemeIndex__BackingField);
		SetupThemes();
		return;
		IL_0443:
		Hoverboards.Board board;
		string text2 = Strings.Get(board.description);
		if (text2 != null)
		{
			obj = 0;
			if (text2._stringLength != 0)
			{
				goto IL_0472;
			}
		}
		obj = 1;
		goto IL_0472;
		IL_0109:
		BoardScreenManager instance13 = BoardScreenManager.Instance;
		board = Hoverboards.boardData.get_Item(instance13.currentlyShownBoard__BackingField);
		TMP_Text tMP_Text3 = nameLabel;
		string text3 = Strings.Get(board.name);
		nint num3 = (nint)tMP_Text3;
		object obj5 = tMP_Text3 + 528;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v94 @ S2_v5 (Il2CppClass<TMPro.TMP_Text>)+2CC] (should have been resolved before IL gen)");
		TMP_Text tMP_Text4 = descriptionLabel;
		string text4 = Strings.Get(board.description);
		nint num4 = (nint)tMP_Text4;
		object obj6 = tMP_Text4 + 528;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v110 @ S2_v10 (Il2CppClass<TMPro.TMP_Text>)+2CC] (should have been resolved before IL gen)");
		TMP_Text tMP_Text5 = themeLimitedLabel;
		string text5 = Strings.Get(board.limitedDescription);
		nint num5 = (nint)tMP_Text5;
		object obj7 = tMP_Text5 + 528;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v126 @ S2_v15 (Il2CppClass<TMPro.TMP_Text>)+2CC] (should have been resolved before IL gen)");
		TMP_Text tMP_Text6 = staticPowerupLabel;
		string text6 = Strings.Get(StringID.BOARD_SCREEN_SPECIAL_POWER);
		nint num6 = (nint)tMP_Text6;
		object obj8 = tMP_Text6 + 528;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v141 @ S2_v20 (Il2CppClass<TMPro.TMP_Text>)+2CC] (should have been resolved before IL gen)");
		string text7 = Strings.Get(board.limitedDescription);
		if (text7 != null)
		{
			obj2 = 0;
			if (text7._stringLength != 0)
			{
				goto IL_0443;
			}
		}
		obj2 = 1;
		goto IL_0443;
	}

	private void InitBoards()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected Obj, but got Unknown
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected Obj, but got Unknown
		//IL_12bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_12c4: Expected Obj, but got Unknown
		//IL_0506: Unknown result type (might be due to invalid IL or missing references)
		//IL_050b: Expected Obj, but got Unknown
		//IL_051e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0523: Expected Obj, but got Unknown
		//IL_134e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1353: Expected Obj, but got Unknown
		//IL_138d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1392: Expected Obj, but got Unknown
		//IL_118a: Unknown result type (might be due to invalid IL or missing references)
		//IL_118f: Expected Obj, but got Unknown
		//IL_13d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_13da: Expected Obj, but got Unknown
		//IL_1111: Unknown result type (might be due to invalid IL or missing references)
		//IL_1116: Expected Obj, but got Unknown
		//IL_060d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0612: Expected Obj, but got Unknown
		//IL_10c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_10cb: Expected Obj, but got Unknown
		//IL_0143: Unknown result type (might be due to invalid IL or missing references)
		//IL_0148: Expected Obj, but got Unknown
		//IL_01a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a5: Expected Obj, but got Unknown
		//IL_122d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1232: Expected Obj, but got Unknown
		//IL_1276: Unknown result type (might be due to invalid IL or missing references)
		//IL_127b: Expected Obj, but got Unknown
		//IL_0406: Unknown result type (might be due to invalid IL or missing references)
		//IL_040b: Expected Obj, but got Unknown
		//IL_0719: Unknown result type (might be due to invalid IL or missing references)
		//IL_071e: Expected Obj, but got Unknown
		//IL_0799: Unknown result type (might be due to invalid IL or missing references)
		//IL_079e: Expected Obj, but got Unknown
		//IL_02b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b6: Expected Obj, but got Unknown
		//IL_034c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0351: Expected Obj, but got Unknown
		//IL_08d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_08dd: Expected Obj, but got Unknown
		//IL_08ed: Expected Obj, but got I
		//IL_09d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_09dd: Expected Obj, but got Unknown
		//IL_09ed: Expected Obj, but got I
		//IL_0aa2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aa7: Expected Obj, but got Unknown
		//IL_0ab7: Expected Obj, but got I
		//IL_0afe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b03: Expected Obj, but got Unknown
		//IL_0b42: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b47: Expected Obj, but got Unknown
		//IL_0bf7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bfc: Expected Obj, but got Unknown
		//IL_0d5d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d62: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 128;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		List<KeyValuePair<Hoverboards.BoardType, Hoverboards.Board>> list = default;
		list._002Ector();
		boardList = list;
		object obj3 = obj + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @728");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
		_ = 0;
		object obj4 = obj + 112;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
		_ = 0;
		object obj6 = default;
		object obj10 = default;
		object obj12 = default;
		object obj13 = default;
		object obj14 = default;
		object obj15 = default;
		object obj17 = default;
		object obj19 = default;
		object obj20 = default;
		object obj27 = default;
		object obj29 = default;
		object obj31 = default;
		object obj32 = default;
		object obj33 = default;
		object obj34 = default;
		object obj49 = default;
		object obj50 = default;
		object obj52 = default;
		object obj53 = default;
		while (true)
		{
			_ = 0;
			object obj5 = obj + 112;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			object obj18;
			object obj16;
			if ((nint)0 != 1)
			{
				if (obj6 == null)
				{
					goto IL_04fd;
				}
				_ = 0;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 != 1)
						{
							_ = 0;
							object obj7 = obj + 16;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @728");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							if ((nint)0 != 1)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
								_ = 0;
								object obj8 = obj + 96;
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+30]");
								_ = 0;
								while (true)
								{
									_ = 0;
									object obj9 = obj + 96;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
									if ((nint)0 == 1)
									{
										break;
									}
									if (obj10 != null)
									{
										_ = 0;
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
										if ((nint)0 == 1)
										{
											break;
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+6C]");
										nint num = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+7C]");
										if (num == 0)
										{
											_ = 0;
											_ = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+7C]");
											_ = 0;
											_ = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
											if ((nint)0 == 1)
											{
												break;
											}
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+30]");
											_ = 0;
											_ = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+30]");
											_ = 0;
											object obj11 = obj + 8;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
											_ = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
											if ((nint)0 == 1)
											{
												break;
											}
											_ = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
											_ = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
											if ((nint)0 == 1)
											{
												break;
											}
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v979 @ S0_v662+14]");
											nint num2 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+7C]");
											bool flag = num2 == 0;
											obj12 = obj13 | flag;
										}
										continue;
									}
									goto IL_03f7;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
								bool flag2 = obj14 != obj15;
								obj16 = obj17;
								obj18 = obj14;
								if (!flag2)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
									if ((nint)0 != 1)
									{
										goto IL_03f7;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
									obj16 = obj19;
									obj18 = obj20;
								}
								_ = 0;
								object obj21 = obj + 16;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
								if ((nint)0 == 1)
								{
									break;
								}
								goto IL_131c;
							}
						}
					}
				}
			}
			goto IL_0480;
			IL_04fd:
			object obj22 = obj + 56;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @DDC");
			object obj23 = obj12 & 1;
			if (obj23 == null)
			{
				BoardScreenManager instance = BoardScreenManager.Instance;
				BoardScreenManager instance2 = BoardScreenManager.Instance;
				instance.current = instance2.currentlyShownBoard__BackingField;
			}
			object obj24 = obj + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1119");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+20]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
			_ = 0;
			object obj25 = obj + 72;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+38]");
			_ = 0;
			int num3 = 0;
			while (true)
			{
				_ = 0;
				object obj26 = obj + 72;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 == 1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				}
				else
				{
					if (obj27 == null)
					{
						goto IL_1108;
					}
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+54]");
					_ = 0;
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+38]");
						_ = 0;
						_ = 0;
						object obj28 = obj - -64;
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 != 1)
						{
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							if ((nint)0 != 1)
							{
								if (obj29 == null)
								{
									bool flag3 = false;
									goto IL_078a;
								}
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
								if ((nint)0 != 1)
								{
									_ = 0;
									object obj30 = obj - -64;
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
									if ((nint)0 != 1)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v846 @ S0_v499+14]");
										bool flag4 = obj30 == null;
										bool flag3 = flag4;
										goto IL_078a;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
								}
								else
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
								}
							}
							else
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
							}
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
						}
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
					}
				}
				goto IL_0ffc;
				IL_0ffc:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
				bool flag5 = obj31 == obj32;
				bool flag6 = !flag5;
				obj16 = obj33;
				if (flag6)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 == 1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
					obj16 = obj34;
					break;
				}
				goto IL_1108;
				IL_1108:
				object obj35 = obj + 16;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B206");
				BoardScreenManager instance3 = BoardScreenManager.Instance;
				BoardScreenManager instance4 = BoardScreenManager.Instance;
				instance4.ChangedDisplayedHoverboard(instance3.currentlyShownBoard__BackingField);
				ToggleScrollElements(enable: true);
				return;
				IL_078a:
				_ = 0;
				object obj36 = obj - -64;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v932 @ S0_v180+10]");
						if (0 == (nint)obj36)
						{
							currentId = num3;
							SimpleScrollSnap simpleScrollSnap = boardScroll;
							simpleScrollSnap.startingPanel = num3;
							object obj37 = "selected";
						}
						else
						{
							object obj37 = "unlock";
						}
						if (obj29 == null)
						{
							object obj37 = "lock";
						}
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 != 1)
						{
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							if ((nint)0 != 1)
							{
								_ = 0;
								object obj38 = obj - -64;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1054 @ S0_v224+4]");
								object obj39 = 0;
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
								if ((nint)0 != 1)
								{
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @12");
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
									if ((nint)0 != 1)
									{
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
										if ((nint)0 != 1)
										{
											_ = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
											_ = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
											if ((nint)0 != 1)
											{
												_ = 0;
												object obj40 = obj - -64;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1116 @ S0_v267+4]");
												object obj41 = 0;
												_ = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
												if ((nint)0 != 1)
												{
													_ = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
													_ = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
													if ((nint)0 != 1)
													{
														_ = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
														_ = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
														if ((nint)0 != 1)
														{
															_ = 0;
															object obj42 = obj - -64;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1164 @ S0_v301+4]");
															object obj43 = 0;
															_ = 0;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
															if ((nint)0 != 1)
															{
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1165 @ S0_v302+C]");
																_ = 0;
																_ = 0;
																object obj44 = obj - -64;
																_ = 0;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																if ((nint)0 != 1)
																{
																	_ = 0;
																	object obj45 = obj - -64;
																	_ = 0;
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																	if ((nint)0 != 1)
																	{
																		_ = 0;
																		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
																		_ = 0;
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																		if ((nint)0 != 1)
																		{
																			_ = 0;
																			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @E");
																			_ = 0;
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																			if ((nint)0 != 1)
																			{
																				_ = 0;
																				object obj46 = obj - -64;
																				_ = 0;
																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																				if ((nint)0 != 1)
																				{
																					_ = 0;
																					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
																					_ = 0;
																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																					if ((nint)0 != 1)
																					{
																						_ = 0;
																						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
																						_ = 0;
																						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																						if ((nint)0 != 1)
																						{
																							_ = 0;
																							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
																							_ = 0;
																							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																							if ((nint)0 != 1)
																							{
																								_ = 0;
																								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
																								_ = 0;
																								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																								if ((nint)0 != 1)
																								{
																									_ = 0;
																									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
																									_ = 0;
																									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																									if ((nint)0 != 1)
																									{
																										_ = 0;
																										object obj47 = obj - -64;
																										_ = 0;
																										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																										if ((nint)0 != 1)
																										{
																											_ = 0;
																											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
																											_ = 0;
																											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																											if ((nint)0 != 1)
																											{
																												_ = 0;
																												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
																												_ = 0;
																												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																												if ((nint)0 != 1)
																												{
																													_ = 0;
																													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
																													_ = 0;
																													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																													if ((nint)0 != 1)
																													{
																														_ = 0;
																														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
																														_ = 0;
																														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																														if ((nint)0 != 1)
																														{
																															int num4 = num3 + 1;
																															num3 = num4;
																															continue;
																														}
																														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																													}
																													else
																													{
																														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																													}
																												}
																												else
																												{
																													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																												}
																											}
																											else
																											{
																												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																											}
																										}
																										else
																										{
																											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																										}
																									}
																									else
																									{
																										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																									}
																								}
																								else
																								{
																									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																								}
																							}
																							else
																							{
																								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																							}
																						}
																						else
																						{
																							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																						}
																					}
																					else
																					{
																						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																					}
																				}
																				else
																				{
																					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																				}
																				goto IL_0ffc;
																			}
																		}
																		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																	}
																	else
																	{
																		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																	}
																}
																else
																{
																	Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																}
															}
															else
															{
																Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
															}
															goto IL_0ffc;
														}
													}
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
												}
												else
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
												}
												goto IL_0ffc;
											}
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
									}
									else
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
									}
								}
								else
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
								}
							}
							else
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
							}
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
						}
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				}
				goto IL_0ffc;
			}
			_ = 0;
			object obj48 = obj + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 == 1)
			{
				break;
			}
			goto IL_11c4;
			IL_131c:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
			if (obj49 == obj18)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					goto IL_04fd;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				obj16 = obj50;
			}
			_ = 0;
			object obj51 = obj + 56;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 == 1)
			{
				break;
			}
			goto IL_11c4;
			IL_0480:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			obj16 = obj52;
			obj18 = obj53;
			goto IL_131c;
			IL_11c4:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
			break;
			IL_03f7:
			_ = 0;
			object obj54 = obj + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				continue;
			}
			goto IL_0480;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
	}

	private void ToggleScrollElements(bool enable)
	{
		MeScreen meScreen = MeScreen;
		meScreen.BoardsScrollAnchor.SetActive(enable);
		MeScreen meScreen2 = MeScreen;
		meScreen2.overlayParent.SetActive(enable);
		if (enable)
		{
			IEnumerator routine = ShowScroll();
			Coroutine coroutine = StartCoroutine(routine);
		}
	}

	private IEnumerator ShowScroll()
	{
		_ = 0;
		IEnumerator result = default;
		return result;
	}

	private void ClickedHoverboardTheme(int index)
	{
		PlayerInfo instance = PlayerInfo.Instance;
		BoardScreenManager instance2 = BoardScreenManager.Instance;
		BoardScreenManager instance3 = BoardScreenManager.Instance;
		int tIndex = index - 1;
		HoverboardThemes.ThemeIdentifier themeIdentifier = HoverboardThemes.GetThemeIdentifier(instance3.currentlyShownBoard__BackingField, tIndex);
		bool flag = instance._hoverboardCustomizationData.IsThemeOwned(instance2.currentlyShownBoard__BackingField, themeIdentifier);
		BoardScreenManager instance4 = BoardScreenManager.Instance;
		if (instance4.currentlyShownThemeIndex__BackingField == index)
		{
			if (flag)
			{
				HoverboardSelectButton.OnClick();
			}
			else if (index != 0)
			{
				return;
			}
		}
		BoardScreenManager instance5 = BoardScreenManager.Instance;
		instance5.currentlyShownThemeIndex__BackingField = index;
		HoverboardSelectButton.UpdateCurrentThemeIndex();
		_oldHoverboardOwned = flag;
		BoardScreenManager instance6 = BoardScreenManager.Instance;
		BoardScreenManager instance7 = BoardScreenManager.Instance;
		UpdateDisplayedModelWithTheme(instance6.currentlyShownBoard__BackingField, instance7.currentlyShownThemeIndex__BackingField);
		if (!_oldHoverboardOwned)
		{
			flag = false;
		}
		if (flag)
		{
			return;
		}
		UIModelController instance8 = UIModelController.Instance;
		CharacterModel cachedActiveModel = instance8._cachedActiveModel;
		if (!(instance8._cachedActiveModel != null))
		{
			return;
		}
		GameObject hoverboardGameObject = instance8._cachedActiveModel.GetHoverboardGameObject();
		if (hoverboardGameObject != null && cachedActiveModel._characterAnimation != null)
		{
			BoardScreenManager instance9 = BoardScreenManager.Instance;
			HoverboardModelPreviewFactory instance10 = HoverboardModelPreviewFactory.Instance;
			BoardScreenManager instance11 = BoardScreenManager.Instance;
			Hoverboard.BoardAbility boardAbility;
			if (instance9.currentlyShownThemeIndex__BackingField >= 1)
			{
				BoardScreenManager instance12 = BoardScreenManager.Instance;
				List<HoverboardThemes.HoverboardTheme> list = HoverboardThemes.hoverboardCustomThemes.get_Item(instance12.currentlyShownBoard__BackingField);
				BoardScreenManager instance13 = BoardScreenManager.Instance;
				int index2 = instance13.currentlyShownThemeIndex__BackingField - 1;
				HoverboardThemes.HoverboardTheme hoverboardTheme = list.get_Item(index2);
				boardAbility = hoverboardTheme.power;
			}
			else
			{
				boardAbility = Hoverboard.BoardAbility.None;
			}
			instance10.ChangeHoverboard(instance11.currentlyShownBoard__BackingField, hoverboardGameObject, cachedActiveModel._characterAnimation, willUpdateAnimation: true, willAllowSignatureAnimation: true, boardAbility);
		}
	}

	private void UpdateDisplayedModelWithTheme(Hoverboards.BoardType boardType, int themeIndex)
	{
		//IL_0039: Expected Obj, but got I4
		//IL_01ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ef: Expected Obj, but got Unknown
		//IL_00f3: Expected Obj, but got I4
		//IL_0273: Unknown result type (might be due to invalid IL or missing references)
		//IL_0278: Expected Obj, but got Unknown
		HoverboardManager instance = HoverboardManager.Instance;
		PlayerInfo instance2 = PlayerInfo.Instance;
		bool flag = themeIndex == 0;
		int num = 0;
		if (!flag)
		{
			object obj = themeIndex - 1;
			int tIndex = themeIndex - 1;
			HoverboardThemes.ThemeIdentifier themeIdentifier = HoverboardThemes.GetThemeIdentifier(boardType, tIndex);
			if (instance2._hoverboardCustomizationData.IsThemeOwned(boardType, themeIdentifier))
			{
				int tIndex2 = themeIndex - 1;
				HoverboardThemes.ThemeIdentifier themeIdentifier2 = HoverboardThemes.GetThemeIdentifier(boardType, tIndex2);
				bool flag2 = instance2._hoverboardCustomizationData.IsThemeActive(boardType, themeIdentifier2);
			}
			else
			{
				bool flag2 = true;
			}
			object obj2 = obj + (object)instance._displayCustomSets;
			num = 0;
			while (num < 2)
			{
				object obj3 = themeIndex - 1;
				if (num != (nint)obj3)
				{
					HoverboardThemes.ThemeIdentifier themeIdentifier3 = HoverboardThemes.GetThemeIdentifier(boardType, num);
					if (instance2._hoverboardCustomizationData.IsThemeOwned(boardType, themeIdentifier3))
					{
						HoverboardThemes.ThemeIdentifier themeIdentifier4 = HoverboardThemes.GetThemeIdentifier(boardType, num);
						bool flag3 = instance2._hoverboardCustomizationData.IsThemeActive(boardType, themeIdentifier4);
					}
					else
					{
						bool flag3 = false;
					}
					object obj4 = num + instance._displayCustomSets;
				}
				int num2 = num + 1;
				num = num2;
			}
		}
		else
		{
			while (num < 2)
			{
				HoverboardThemes.ThemeIdentifier themeIdentifier5 = HoverboardThemes.GetThemeIdentifier(boardType, num);
				bool flag4 = instance2._hoverboardCustomizationData.IsThemeActive(boardType, themeIdentifier5);
				object obj5 = num + instance._displayCustomSets;
				int num3 = num + 1;
				num = num3;
			}
		}
		ShowHoverboardInMenu(willUpdateAnimation: false, willAllowSignatureAnimation: true);
	}

	private void SetupThemes()
	{
		//IL_0070: Expected Obj, but got I
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Expected Obj, but got Unknown
		BoardScreenManager instance = BoardScreenManager.Instance;
		nint num = 0;
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S3_v3 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<Hoverboards+BoardType, System.Collections.Generic.List`1<HoverboardThemes+HoverboardTheme>>>)+54]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v31 @ S3_v4+4] (should have been resolved before IL gen)");
		object obj3 = default;
		object obj2 = obj3 ^ -1;
		object obj4 = obj2 >> 31;
		if (obj4 != null)
		{
			BoardScreenManager instance2 = BoardScreenManager.Instance;
			List<HoverboardThemes.HoverboardTheme> themes = HoverboardThemes.hoverboardCustomThemes.get_Item(instance2.currentlyShownBoard__BackingField);
			_hoverboardThemeShifter.MakeCustomThemesAvailable(themes);
		}
		else
		{
			_hoverboardThemeShifter.DisableThemeShifter();
		}
	}

	public unsafe void ScrollClicked(Vector2 pos)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_009c: Expected native int or pointer, but got VT
		object obj = default;
		Vector2 vector = (Vector2)(obj - 16);
		((Vector2*)(nint)vector)->x = pos.x;
		_ = pos.x;
		if (_centerer.CenterOnClosestChildAtPosition(vector))
		{
			PlayerInfo instance = PlayerInfo.Instance;
			BoardScreenManager instance2 = BoardScreenManager.Instance;
			if (instance.IsHoverboardUnlocked(instance2.currentlyShownBoard__BackingField))
			{
				HoverboardManager instance3 = HoverboardManager.Instance;
				instance3.SelectCurrentlyShownBoard(HoverboardManager.ScreenContext.BoardScreen);
				AudioSource audioSource = NGUITools.PlaySound(selectSound);
			}
		}
	}

	private void Update()
	{
	}

	public BoardScreen()
	{
		List<ListBoardCell> list = default;
		list._002Ector();
		ListBoardCells = list;
		List<HoverboardOverlayHelper> list2 = default;
		list2._002Ector();
		boardHelpers = list2;
		List<Transform> list3 = default;
		list3._002Ector();
		listBoard = list3;
		currentId = -1;
		_oldHoverboardOwned = true;
		base._002Ector();
	}

	private void _003COnEnable_003Eb__29_1()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_026a: Unknown result type (might be due to invalid IL or missing references)
		//IL_026f: Expected Obj, but got Unknown
		//IL_029c: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a1: Expected Obj, but got Unknown
		//IL_02e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02eb: Expected Obj, but got Unknown
		//IL_02c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cc: Expected Obj, but got Unknown
		//IL_01ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b0: Expected Obj, but got Unknown
		//IL_021c: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 48;
		_ = 0;
		_ = 0;
		SimpleScrollSnap simpleScrollSnap = boardScroll;
		currentId = simpleScrollSnap.CurrentPanel__BackingField;
		ChangePanel(simpleScrollSnap.CurrentPanel__BackingField);
		object obj3 = obj + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B5");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
		_ = 0;
		object obj4 = obj + 32;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		_ = 0;
		object obj6 = default;
		object obj7;
		object obj8 = default;
		object obj9 = default;
		object obj11 = default;
		object obj12 = default;
		while (true)
		{
			_ = 0;
			object obj5 = obj + 32;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				bool flag = obj6 == null;
				obj7 = obj;
				if (flag)
				{
					break;
				}
				_ = 0;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						continue;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
			bool flag2 = obj8 == obj9;
			bool flag3 = !flag2;
			object obj10 = obj11;
			if (!flag3)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				bool flag4 = (nint)0 != 1;
				obj7 = obj;
				if (flag4)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				obj10 = obj12;
			}
			_ = 0;
			object obj13 = obj + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 == 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				obj7 = 0;
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
			return;
		}
		object obj14 = obj7 + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3AE6");
	}
}
