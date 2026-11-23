using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2ILInjected;
using DanielLochner.Assets.SimpleScrollSnap;
using SYBO.Subway.Info;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace UI.Screens;

public class CharacterScreen : UIScreen
{
	public class RibbonPayload
	{
		public bool shouldShow;

		public string line1;

		public string line2;

		public string line3;
	}

	private sealed class _003CEnableCamerasDelayed_003Ed__51(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public CharacterScreen _003C_003E4__this;

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
					UIScreenController instance = UIScreenController.Instance;
					instance.Camera3D.enabled = true;
					UIScreenController instance2 = UIScreenController.Instance;
					instance2.Camera3DClip.enabled = true;
				}
				return false;
			}
			_003C_003E1__state = -1;
			CharacterScreen characterScreen = _003C_003E4__this;
			characterScreen._firstShow = false;
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

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static UnityAction _003C_003E9__55_0;

		static _003C_003Ec()
		{
			_003C_003Ec obj = default;
			_003C_003E9 = obj;
		}

		internal void _003COnEnable_003Eb__55_0()
		{
			UIScreenController instance = UIScreenController.Instance;
			instance.CloseActivePopups("MeScreen");
		}
	}

	private sealed class _003CShowScroll_003Ed__56(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public CharacterScreen _003C_003E4__this;

		object IEnumerator<object>.Current => _003C_003E2__current;

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			CharacterScreen characterScreen = _003C_003E4__this;
			if (_003C_003E1__state != 0)
			{
				if (_003C_003E1__state == 1)
				{
					_003C_003E1__state = -1;
					GameObject gameObject = characterScreen.CharacterScroll.gameObject;
					gameObject.SetActive(value: true);
				}
				return false;
			}
			_003C_003E1__state = -1;
			GameObject gameObject2 = characterScreen.CharacterScroll.gameObject;
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

	private sealed class _003CDelayedCenterOnEventCharacter_003Ed__71(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public CharacterScreen _003C_003E4__this;

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
					CenterScrollOnEventCharacter();
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

	public MeScreen MeScreen;

	private UIGrid characterGrid;

	private UIPanel scrollPanel;

	private GameObject char2dElements;

	private GameObject dummyObject;

	private TMP_Text _nameTitle;

	private SimpleScrollSnap CharacterScroll;

	private ListCharacterCell ListCharacterCell;

	private List<ListCharacterCell> ListCharacterCells;

	private Transform characterContent;

	private TMP_Text _nameSubtitle;

	private GameObject characterDayEventElements;

	private TMP_Text characterDayEventTimer;

	private AudioClip selectSound;

	private UICharacterThemeShifter _characterThemeShifter;

	private GameObject _characterDayParticleSystem;

	private GameObject _characterSelectButtonPrefab;

	private GameObject _centerAnchor;

	private bool _hasInited;

	private CenterOnChild _centerer;

	private float _cellWidth;

	private bool _hasShownModel;

	private SSEventType _currentActiveEventType;

	public static bool queueRefreshCharacter;

	public static bool forceRefreshOnCharacterScreen;

	public static bool forceCenterOnEventCharacter;

	public static bool forceCenterOnCurrentlySelectedCharacter;

	public static bool isReturningFromMysteryBox;

	private List<KeyValuePair<Characters.CharacterType, Characters.Model>> _characterList;

	private float _cachedScrollPosition;

	private CharacterSelectButton _characterSelectButton;

	private bool _charactersEnabled;

	private bool _firstShow;

	public const int STICKER_SMALL_FONT_SIZE = 10;

	public const int STICKER_BIG_FONT_SIZE = 15;

	public const float SMALL_TOP_LABEL_POSITION_Y = 6f;

	public const float SMALL_BOTTOM_LABEL_POSITION_Y = -5f;

	public const float BIG_TOP_LABEL_POSITION_Y = 5.5f;

	public const float BIG_BOTTOM_LABEL_POSITION_Y = -7f;

	private CharacterScreenManager _screenManagerInstance;

	private readonly List<GameObject> _characterModels;

	private readonly List<CharacterOverlayHelper> _characterHelpers;

	private readonly List<OverlayIndex> _characterIndices;

	private bool _hasCenteredOnCharacter;

	private int currentId;

	private Button closeButton;

	public override void Init()
	{
		//IL_00d8: Expected I, but got Obj
		nint num = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v13 @ S1_v3 (Il2CppClass<UI.Screens.CharacterScreen>)+104] (should have been resolved before IL gen)");
		SyncPositionHelper component = GetComponent<SyncPositionHelper>();
		if (component != null)
		{
			MeScreen meScreen = MeScreen;
			component.toObject = meScreen.toObject;
		}
		CharacterScreenManager instance = CharacterScreenManager.Instance;
		_screenManagerInstance = instance;
		UIGrid uIGrid = characterGrid;
		_cellWidth = uIGrid.cellWidth;
		CenterOnChild component2 = uIGrid.GetComponent<CenterOnChild>();
		_centerer = component2;
		SSEventsManagerController instance2 = SSEventsManagerController.instance;
		IEventManager activeEventManager = instance2.GetActiveEventManager();
		SSEventType currentActiveEventType = default;
		if (activeEventManager != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
		}
		else
		{
			currentActiveEventType = SSEventType.None;
		}
		_currentActiveEventType = currentActiveEventType;
		InitScrollWithCharacterModels();
		InitializeSelectButton();
		PlayerInfo instance3 = PlayerInfo.Instance;
		PlayerInfo instance4 = PlayerInfo.Instance;
		int currentThemeIndex = instance4.currentThemeIndex;
		ChangeCurrentlyShownCharacter((Characters.CharacterType)instance3._currentCharacter, currentThemeIndex);
		_hasInited = true;
	}

	private void CheckCenterOnCharacter()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0047: Expected I, but got Obj
		//IL_0050: Expected Obj, but got I4
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Expected Obj, but got Unknown
		//IL_00bd: Expected Obj, but got I4
		//IL_006c: Expected Obj, but got I4
		object obj = default;
		CharacterScreenManager characterScreenManager = (CharacterScreenManager)(obj - 16);
		characterScreenManager._characterList = null;
		if (~(_hasCenteredOnCharacter ? 1u : 0u) != 0)
		{
			_hasCenteredOnCharacter = true;
			CharacterScreenManager instance = CharacterScreenManager.Instance;
			Characters.CharacterType? characterTypeActiveInEvent = characterScreenManager.GetCharacterTypeActiveInEvent();
			nint num = (nint)typeof(CharacterScreen);
			object obj2 = 2;
			if (characterScreenManager._characterList == null)
			{
				obj2 = 3;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S0_v20 (Il2CppClass<UI.Screens.CharacterScreen>)+5C]");
			object obj3 = 0 + obj2;
			obj3 = 1;
		}
	}

	private void InitializeSelectButton()
	{
		CharacterSelectButton component = _characterSelectButtonPrefab.GetComponent<CharacterSelectButton>();
		_characterSelectButton = component;
		CharacterScreenManager screenManagerInstance = _screenManagerInstance;
		UpdateThemeShifter(screenManagerInstance.currentlyShownCharacter__BackingField, screenManagerInstance.currentlyShownThemeIndex__BackingField);
		_characterSelectButton.InitButton(CharacterSelectButton.ButtonContext.characterScreen);
	}

	public override void Show()
	{
		if (~(_firstShow ? 1u : 0u) == 0)
		{
			UIScreenController instance = UIScreenController.Instance;
			instance.Camera3D.enabled = false;
			UIScreenController instance2 = UIScreenController.Instance;
			instance2.Camera3DClip.enabled = false;
		}
		base.Show();
		UIScreenController instance3 = UIScreenController.Instance;
		throw new ArgumentException();
	}

	private IEnumerator EnableCamerasDelayed()
	{
		_ = 0;
		IEnumerator result = default;
		return result;
	}

	public override void Hide()
	{
		base.Hide();
		UIScreenController instance = UIScreenController.Instance;
		throw new ArgumentException();
	}

	private void UpdateCharacter()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_044c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0451: Expected Obj, but got Unknown
		//IL_047e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0483: Expected Obj, but got Unknown
		//IL_051e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0523: Expected Obj, but got Unknown
		//IL_04a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ae: Expected Obj, but got Unknown
		//IL_03c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ce: Expected Obj, but got Unknown
		//IL_004e: Expected Obj, but got I
		//IL_0573: Expected Obj, but got I
		//IL_04d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_04da: Expected Obj, but got Unknown
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
		int num2 = default;
		object obj12 = default;
		object obj13 = default;
		object obj15 = default;
		object obj16 = default;
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
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B");
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
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v209 @ S0_v87+EC]");
							nint num = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ S0_v66+1C]");
							if (num == 0)
							{
								currentId = startingPanel;
								SimpleScrollSnap characterScroll = CharacterScroll;
								characterScroll.startingPanel = startingPanel;
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
									goto IL_02f7;
								}
								object obj9 = "unlock";
								if (obj10 == null)
								{
									obj9 = "lock";
								}
							}
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ S0_v66+1C]");
							_ = 0;
							object obj11 = obj + 8;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							if ((nint)0 != 1)
							{
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @10");
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
											startingPanel = num2 + 1;
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
			goto IL_02f7;
			IL_02f7:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
			bool flag2 = obj12 == obj13;
			bool flag3 = !flag2;
			object obj14 = obj15;
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
				obj14 = obj16;
			}
			_ = 0;
			object obj17 = obj + 16;
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
		object obj18 = obj7 + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @966F");
	}

	private void InitScrollWithCharacterModels()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0848: Unknown result type (might be due to invalid IL or missing references)
		//IL_084d: Expected Obj, but got Unknown
		//IL_0856: Expected Obj, but got I4
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected Obj, but got Unknown
		//IL_0070: Expected Obj, but got I
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Expected Obj, but got Unknown
		//IL_0910: Unknown result type (might be due to invalid IL or missing references)
		//IL_0915: Expected Obj, but got Unknown
		//IL_0899: Unknown result type (might be due to invalid IL or missing references)
		//IL_089e: Expected Obj, but got Unknown
		//IL_07cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_07d0: Expected Obj, but got Unknown
		//IL_0965: Expected Obj, but got I
		//IL_024c: Expected Obj, but got I
		//IL_08fc: Expected Obj, but got I
		//IL_0372: Unknown result type (might be due to invalid IL or missing references)
		//IL_0377: Expected Obj, but got Unknown
		//IL_04c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ca: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 80;
		_ = 0;
		object obj3 = obj - -64;
		obj3 = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		GameObject gameObject = base.gameObject;
		gameObject.SetActive(value: true);
		_screenManagerInstance.InitCharacters();
		CharacterScreenManager screenManagerInstance = _screenManagerInstance;
		List<KeyValuePair<Characters.CharacterType, Characters.Model>> characterList = _screenManagerInstance.GetCharacterList();
		_characterList = characterList;
		object obj4 = obj + 24;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1119");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+28]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+20]");
		obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
		_ = 0;
		object obj5 = obj + 56;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
		_ = 0;
		int num = 0;
		object obj7 = default;
		object obj8;
		object obj12 = default;
		object obj15 = default;
		object obj16 = default;
		object obj18 = default;
		object obj19 = default;
		while (true)
		{
			_ = 0;
			object obj6 = obj + 56;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				bool flag = obj7 == null;
				obj8 = obj;
				if (flag)
				{
					break;
				}
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+44]");
				_ = 0;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
					_ = 0;
					_ = 0;
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+30]");
						_ = 0;
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B");
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
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v325 @ S0_v111+EC]");
								nint num2 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+2C]");
								if (num2 == 0)
								{
									currentId = num;
									SimpleScrollSnap characterScroll = CharacterScroll;
									characterScroll.startingPanel = num;
									object obj9 = "selected";
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v325 @ S0_v111+EC]");
									object obj10 = 0;
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
										goto IL_06f9;
									}
									object obj11 = "unlock";
									if (obj12 == null)
									{
										obj11 = "lock";
									}
									object obj9 = obj11;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+2C]");
									object obj10 = 0;
								}
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
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
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+2C]");
											_ = 0;
											object obj13 = obj + 12;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
											_ = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
											if ((nint)0 != 1)
											{
												_ = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @10");
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
															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
															_ = 0;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
															if ((nint)0 != 1)
															{
																_ = -1;
																_ = typeof(Characters.CharacterType);
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+2C]");
																_ = 0;
																_ = 0;
																object obj14 = obj + 24;
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
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+2C]");
																		_ = 0;
																		_ = 0;
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+2C]");
																		bool flag2 = (nint)0 != (nint)screenManagerInstance.currentlyShownCharacter__BackingField;
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
																					int num3 = num + 1;
																					num = num3;
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
																		goto IL_06f9;
																	}
																}
																Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
															}
															else
															{
																Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
															}
															goto IL_06f9;
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
							goto IL_06f9;
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
			goto IL_06f9;
			IL_06f9:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
			bool flag3 = obj15 == obj16;
			bool flag4 = !flag3;
			object obj17 = obj18;
			if (!flag4)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				bool flag5 = (nint)0 != 1;
				obj8 = obj;
				if (flag5)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				obj17 = obj19;
			}
			_ = 0;
			object obj20 = obj + 16;
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
			obj8 = 0;
			break;
		}
		object obj21 = obj8 + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2284");
	}

	private unsafe void OnEnable()
	{
		Button button = closeButton;
		bool flag = _003C_003Ec._003C_003E9__55_0 == null;
		bool flag2 = !flag;
		UnityAction call = _003C_003Ec._003C_003E9__55_0;
		if (!flag2)
		{
			UnityAction unityAction = default;
			unityAction._002Ector(_003C_003Ec._003C_003E9, (nint)__ldftn(_003C_003Ec._003COnEnable_003Eb__55_0));
			_003C_003Ec._003C_003E9__55_0 = unityAction;
			call = unityAction;
		}
		button.m_OnClick.AddListener(call);
		SimpleScrollSnap characterScroll = CharacterScroll;
		UnityAction unityAction2 = default;
		unityAction2._002Ector(this, (nint)__ldftn(CharacterScreen._003COnEnable_003Eb__55_1));
		characterScroll.onPanelChanged.AddListener(unityAction2);
		IEnumerator routine = ShowScroll();
		Coroutine coroutine = StartCoroutine(routine);
	}

	private IEnumerator ShowScroll()
	{
		_ = 0;
		IEnumerator result = default;
		return result;
	}

	public void SelectedCharacter(int id)
	{
		if (id != currentId)
		{
			CharacterScroll.GoToPanel(id);
			ChangePanel();
		}
	}

	private void ChangePanel()
	{
		CharacterOverlayHelper characterOverlayHelper = _characterHelpers.get_Item(currentId);
		PlayerInfo instance = PlayerInfo.Instance;
		int indexForLastSelectedTheme = instance.GetIndexForLastSelectedTheme(characterOverlayHelper._cachedType);
		ChangeCurrentlyShownCharacter(characterOverlayHelper._cachedType, indexForLastSelectedTheme);
		CharacterOverlayHelper characterOverlayHelper2 = _characterHelpers.get_Item(currentId);
		characterOverlayHelper2.SelectedInMenu();
	}

	private void RefreshCharacterList()
	{
		if (~(_charactersEnabled ? 1u : 0u) == 0 && DetectChangeInCharacterList())
		{
			InitScrollWithCharacterModels();
		}
	}

	private bool DetectChangeInCharacterList()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		_ = 0;
		bool result;
		if (~(forceRefreshOnCharacterScreen ? 1u : 0u) == 0)
		{
			forceRefreshOnCharacterScreen = false;
			result = true;
		}
		else
		{
			SSEventsManagerController instance = SSEventsManagerController.instance;
			IEventManager activeEventManager = instance.GetActiveEventManager();
			bool flag = activeEventManager == null;
			SSEventType sSEventType = SSEventType.None;
			if (!flag)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
				SSEventType sSEventType2 = default;
				sSEventType = sSEventType2;
			}
			if (sSEventType == _currentActiveEventType)
			{
				int num = 0;
				while (true)
				{
					List<CharacterOverlayHelper> characterHelpers = _characterHelpers;
					bool flag2 = num < characterHelpers._size;
					bool flag3 = !flag2;
					result = flag2;
					if (flag3)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @40A");
					CharacterOverlayHelper characterOverlayHelper = _characterHelpers.get_Item(num);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
					bool flag4 = (nint)0 != (nint)characterOverlayHelper._cachedType;
					result = flag2;
					if (flag4)
					{
						break;
					}
					int num2 = num + 1;
					num = num2;
				}
			}
			else
			{
				_currentActiveEventType = sSEventType;
				result = true;
			}
		}
		return result;
	}

	private void Update()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_049d: Expected F8, but got I8
		//IL_04ec: Expected F8, but got I4
		//IL_06e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e8: Expected Obj, but got Unknown
		//IL_0708: Expected Obj, but got I
		//IL_0711: Unknown result type (might be due to invalid IL or missing references)
		//IL_0716: Expected Obj, but got Unknown
		//IL_071f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0724: Expected Obj, but got Unknown
		//IL_073f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0744: Expected Obj, but got Unknown
		//IL_0764: Expected Obj, but got I
		//IL_076d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0772: Expected Obj, but got Unknown
		//IL_077b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0780: Expected Obj, but got Unknown
		//IL_079b: Unknown result type (might be due to invalid IL or missing references)
		//IL_07a0: Expected Obj, but got Unknown
		//IL_0513: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + -64;
		_ = 0;
		_ = 0;
		_ = 0;
		if (~(_hasInited ? 1u : 0u) != 0)
		{
			return;
		}
		if (_centerer != null)
		{
			CenterOnChild centerer = _centerer;
			if (centerer.mSelectedObject != null)
			{
				CharacterOverlayHelper characterOverlayHelper = _characterHelpers.get_Item(currentId);
				if (~(_hasShownModel ? 1u : 0u) != 0)
				{
					_hasShownModel = true;
					PlayerInfo instance = PlayerInfo.Instance;
					int indexForLastSelectedTheme = instance.GetIndexForLastSelectedTheme(characterOverlayHelper._cachedType);
					ChangeCurrentlyShownCharacter(characterOverlayHelper._cachedType, indexForLastSelectedTheme);
					CharacterOverlayHelper characterOverlayHelper2 = _characterHelpers.get_Item(currentId);
					characterOverlayHelper2.SelectedInMenu();
				}
				CharacterScreenManager screenManagerInstance = _screenManagerInstance;
				_ = screenManagerInstance.currentlyShownCharacter__BackingField;
				if (characterOverlayHelper._cachedType != screenManagerInstance.currentlyShownCharacter__BackingField)
				{
					throw new ArgumentException();
				}
				if (characterDayEventElements.activeSelf)
				{
					SSEventsManagerController instance2 = SSEventsManagerController.instance;
					long num = instance2.TimeLeftInSeconds();
					TimeSpan timeSpan = TimeSpan.FromSeconds(num);
					if (TimeSpan.Zero > timeSpan)
					{
						_ = TimeSpan.Zero;
					}
					TMP_Text tMP_Text = characterDayEventTimer;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+28]");
					double value = 0.0 * 2.7777777777777777E-11;
					double num2 = Math.Abs(value);
					if (!(num2 < 2147483648.0))
					{
						value = -2147483648.0;
					}
					object obj3 = obj + 24;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+28]");
					object obj4 = (nint)0 / (nint)600000000;
					object obj5 = obj4 / 60;
					object obj6 = obj5 * 60;
					object obj7 = obj4 - obj6;
					object obj8 = obj + 16;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+28]");
					object obj9 = (nint)0 / (nint)10000000;
					object obj10 = obj9 / 60;
					object obj11 = obj10 * 60;
					object obj12 = obj9 - obj11;
					object obj13 = obj + 12;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
					object arg = default;
					object arg2 = default;
					object arg3 = default;
					string text = $"{arg:00}:{arg2:00}:{arg3:00}";
					nint num3 = (nint)tMP_Text;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v458 @ S2_v21 (Il2CppClass<TMPro.TMP_Text>)+2CC] (should have been resolved before IL gen)");
				}
			}
		}
		ScaleScrollModels();
	}

	private void ChangeCurrentlyShownCharacter(Characters.CharacterType charType, int index)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_007b: Expected Obj, but got I8
		//IL_0088: Expected VT, but got Obj
		object obj2 = default;
		object obj = obj2 - 32;
		CharacterScreenManager screenManagerInstance = _screenManagerInstance;
		screenManagerInstance.currentlyShownThemeIndex__BackingField = index;
		screenManagerInstance.currentlyShownCharacter__BackingField = charType;
		UIModelController instance = UIModelController.Instance;
		GameObject gameObject = instance.ShowMenuModel(charType, index);
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
		UpdateUIElements();
		UpdateThemeShifter(charType, index);
	}

	private void UpdateThemeShifter(Characters.CharacterType charType, int index)
	{
		//IL_0074: Expected Obj, but got I
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Expected Obj, but got Unknown
		//IL_009a: Expected I4, but got Obj
		nint num = 0;
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S3_v3 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<SYBO.Subway.Info.Characters+CharacterType, System.Collections.Generic.List`1<CharacterTheme>>>)+54]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v28 @ S3_v4+4] (should have been resolved before IL gen)");
		object obj3 = default;
		object obj2 = obj3 ^ -1;
		bool flag = (byte)(obj2 >> 31) != 0;
		GameObject gameObject = _characterThemeShifter.gameObject;
		gameObject.SetActive(flag);
		if (flag)
		{
			List<CharacterTheme> themes = CharacterThemes.TryGetCustomThemesForChar(charType);
			_characterThemeShifter.MakeCustomThemesAvailable(themes);
			_characterThemeShifter.UpdateUIForCharacter(charType, index);
		}
	}

	private void UpdateUIElements()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_014f: Expected Obj, but got I4
		//IL_0317: Expected I, but got Obj
		//IL_0320: Unknown result type (might be due to invalid IL or missing references)
		//IL_0325: Expected Obj, but got Unknown
		//IL_020b: Expected Obj, but got I4
		//IL_01ef: Expected Obj, but got I4
		//IL_0380: Expected I, but got Obj
		//IL_0389: Unknown result type (might be due to invalid IL or missing references)
		//IL_038e: Expected Obj, but got Unknown
		//IL_0293: Expected Obj, but got I4
		//IL_0277: Expected Obj, but got I4
		//IL_02aa: Expected I, but got Obj
		//IL_02b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b8: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		_ = 0;
		UIModelController instance = UIModelController.Instance;
		Characters.Model model = Characters.characterData.get_Item(instance._currentlyShownModel);
		PlayerInfo instance2 = PlayerInfo.Instance;
		bool flag = instance2.IsCharacterOwned(instance._currentlyShownModel);
		CharacterScreenManager screenManagerInstance = _screenManagerInstance;
		CharacterTheme themeForCharacter = CharacterThemes.GetThemeForCharacter(instance._currentlyShownModel, screenManagerInstance.currentlyShownThemeIndex__BackingField);
		bool flag2 = _characterSelectButton.CurrentlyShownCharacterMatchesEventItem();
		SSEventsManagerController instance3 = SSEventsManagerController.instance;
		IEventManager activeEventManager = instance3.GetActiveEventManager();
		if (activeEventManager != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
			object obj3 = default;
			if ((nint)obj3 != 7)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
			}
		}
		SetEventRibbonActive();
		if (flag)
		{
			if (activeEventManager != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
			}
		}
		else
		{
			bool flag3 = themeForCharacter == null;
			object obj4 = flag3 & flag2;
			if (obj4 == null && ~(model.hasOnlineSettings ? 1u : 0u) == 0 && themeForCharacter == null)
			{
				PlayerInfo instance4 = PlayerInfo.Instance;
				TimeSpan timeSpan = instance4.CharacterExpirationTimespan(instance._currentlyShownModel);
			}
		}
		TMP_Text nameTitle = _nameTitle;
		string text = Strings.Get(model.name);
		nint num = (nint)nameTitle;
		object obj5 = nameTitle + 528;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v133 @ S2_v10 (Il2CppClass<TMPro.TMP_Text>)+2CC] (should have been resolved before IL gen)");
		TMP_Text nameSubtitle = _nameSubtitle;
		string text2 = Strings.Get(model.characterLimitedDescription);
		object obj6;
		if (text2 != null)
		{
			obj6 = 0;
			if (text2._stringLength != 0)
			{
				goto IL_0350;
			}
		}
		obj6 = 1;
		goto IL_0350;
		IL_03b5:
		object obj7;
		if (obj7 == null)
		{
			TMP_Text nameSubtitle2 = _nameSubtitle;
			nint num2 = (nint)nameSubtitle2;
			object obj8 = nameSubtitle2 + 528;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v257 @ S2_v27 (Il2CppClass<TMPro.TMP_Text>)+2CC] (should have been resolved before IL gen)");
		}
		goto IL_03c3;
		IL_03c3:
		CharacterScreenManager screenManagerInstance2 = _screenManagerInstance;
		UpdateThemeShifter(screenManagerInstance2.currentlyShownCharacter__BackingField, screenManagerInstance2.currentlyShownThemeIndex__BackingField);
		CharacterScreenManager screenManagerInstance3 = _screenManagerInstance;
		UpdateCharacterSticker(screenManagerInstance3.currentlyShownCharacter__BackingField, screenManagerInstance3.currentlyShownThemeIndex__BackingField);
		_characterSelectButton.ReloadButton();
		return;
		IL_0350:
		if (obj6 == null)
		{
			string text3 = Strings.Get(model.characterLimitedDescription);
		}
		else
		{
			string text3 = string.Empty;
		}
		nint num3 = (nint)nameSubtitle;
		object obj9 = nameSubtitle + 528;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v186 @ S2_v17 (Il2CppClass<TMPro.TMP_Text>)+2CC] (should have been resolved before IL gen)");
		if (themeForCharacter != null)
		{
			string text4 = Strings.Get(themeForCharacter.title);
			if (text4 != null)
			{
				obj7 = 0;
				if (text4._stringLength != 0)
				{
					goto IL_03b5;
				}
			}
			obj7 = 1;
			goto IL_03b5;
		}
		goto IL_03c3;
	}

	private void UpdateSelectedCharacter()
	{
		UIModelController instance = UIModelController.Instance;
		UIModelController instance2 = UIModelController.Instance;
		PlayerInfo instance3 = PlayerInfo.Instance;
		bool flag = instance3.IsCharacterOwned(instance._currentlyShownModel);
		PlayerInfo instance4 = PlayerInfo.Instance;
		bool flag2 = instance4.IsThemeUnlockedForCharacter(instance._currentlyShownModel, instance2._currentlyShownThemeIndex);
		if (flag && flag2)
		{
			PlayerInfo instance5 = PlayerInfo.Instance;
			instance5.SetLastSelectedTheme(instance._currentlyShownModel, instance2._currentlyShownThemeIndex);
			_characterThemeShifter.UpdateUIForCharacter(instance._currentlyShownModel, instance2._currentlyShownThemeIndex);
			_characterSelectButton.ReloadButton();
		}
		UpdateCharacter();
	}

	private void RefreshCharacterModelInScrollList(Characters.CharacterType ctype, int themeIndex)
	{
	}

	private unsafe void LimitedCharacterEventStarted()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0148: Unknown result type (might be due to invalid IL or missing references)
		//IL_014d: Expected Obj, but got Unknown
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Expected Obj, but got Unknown
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Expected VT, but got Unknown
		//IL_0099: Expected Ref, but got VT
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Expected VT, but got Unknown
		//IL_00d9: Expected Ref, but got VT
		object obj2 = default;
		object obj = obj2 - 16;
		_ = 0;
		_ = 0;
		object obj3 = obj + 8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22E");
		_ = 0;
		SSEventsManagerController instance = SSEventsManagerController.instance;
		IEventManager activeEventManager = instance.GetActiveEventManager();
		if (activeEventManager != null)
		{
			object obj4 = obj + 7;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5A7");
			_ = 1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+7]");
			if ((nint)0 != 0)
			{
				CharacterScreenManager screenManagerInstance = _screenManagerInstance;
				Characters.CharacterType? characterType = (Characters.CharacterType?)(object)(obj + 8);
				Characters.CharacterType value = ((Characters.CharacterType?*)characterType)->Value;
				screenManagerInstance.currentlyShownCharacter__BackingField = value;
				CharacterScreenManager screenManagerInstance2 = _screenManagerInstance;
				PlayerInfo instance2 = PlayerInfo.Instance;
				Characters.CharacterType? characterType2 = (Characters.CharacterType?)(object)(obj + 8);
				Characters.CharacterType value2 = ((Characters.CharacterType?*)characterType2)->Value;
				int indexForLastSelectedTheme = instance2.GetIndexForLastSelectedTheme(value2);
				screenManagerInstance2.currentlyShownThemeIndex__BackingField = indexForLastSelectedTheme;
				RefreshCharacterList();
				CharacterScreenManager screenManagerInstance3 = _screenManagerInstance;
				ChangeCurrentlyShownCharacter(screenManagerInstance3.currentlyShownCharacter__BackingField, screenManagerInstance3.currentlyShownThemeIndex__BackingField);
			}
		}
	}

	private void LimitedCharacterEventFinished()
	{
		CharacterScreenManager screenManagerInstance = _screenManagerInstance;
		PlayerInfo instance = PlayerInfo.Instance;
		screenManagerInstance.currentlyShownCharacter__BackingField = (Characters.CharacterType)instance._currentCharacter;
		CharacterScreenManager screenManagerInstance2 = _screenManagerInstance;
		PlayerInfo instance2 = PlayerInfo.Instance;
		CharacterScreenManager screenManagerInstance3 = _screenManagerInstance;
		int indexForLastSelectedTheme = instance2.GetIndexForLastSelectedTheme(screenManagerInstance3.currentlyShownCharacter__BackingField);
		screenManagerInstance2.currentlyShownThemeIndex__BackingField = indexForLastSelectedTheme;
		RefreshCharacterList();
		CharacterScreenManager screenManagerInstance4 = _screenManagerInstance;
		ChangeCurrentlyShownCharacter(screenManagerInstance4.currentlyShownCharacter__BackingField, screenManagerInstance4.currentlyShownThemeIndex__BackingField);
	}

	private void RefreshCharacterScreen()
	{
		RefreshCharacterList();
		UpdateUIElements();
	}

	private void CenterScrollOnCharacterType(Characters.CharacterType charType)
	{
	}

	private IEnumerator DelayedCenterOnEventCharacter()
	{
		_ = 0;
		IEnumerator result = default;
		return result;
	}

	private void CenterScrollOnEventCharacter()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		SSEventsManagerController instance = SSEventsManagerController.instance;
		IEventManager activeEventManager = instance.GetActiveEventManager();
		if (activeEventManager == null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
		object obj3 = default;
		if ((nint)obj3 != 7)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
			object obj4 = default;
			if ((nint)obj4 != 3)
			{
				return;
			}
		}
		_ = 0;
		object obj5 = obj + 15;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5A7");
	}

	private void OnCharacterUnlocked(Characters.CharacterType charType, int version)
	{
		ChangeCurrentlyShownCharacter(charType, version);
		queueRefreshCharacter = true;
		if (version >= 1)
		{
			CharacterTheme themeForCharacter = CharacterThemes.GetThemeForCharacter(charType, version);
			if (themeForCharacter != null)
			{
				string text = Strings.Get(themeForCharacter.title);
			}
		}
	}

	public unsafe void ScrollClicked(Vector2 pos)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_00ff: Expected native int or pointer, but got VT
		object obj = default;
		Vector2 vector = (Vector2)(obj - 16);
		CharacterScreenManager screenManagerInstance = _screenManagerInstance;
		((Vector2*)(nint)vector)->x = pos.x;
		_ = pos.x;
		bool flag = _centerer.CenterOnClosestChildAtPosition(vector);
		PlayerInfo instance = PlayerInfo.Instance;
		bool flag2 = instance.IsCharacterOwned(screenManagerInstance.currentlyShownCharacter__BackingField);
		PlayerInfo instance2 = PlayerInfo.Instance;
		int indexForLastSelectedTheme = instance2.GetIndexForLastSelectedTheme(screenManagerInstance.currentlyShownCharacter__BackingField);
		if (flag && flag2)
		{
			CharacterScreenManager screenManagerInstance2 = _screenManagerInstance;
			if (indexForLastSelectedTheme == screenManagerInstance2.currentlyShownThemeIndex__BackingField)
			{
				UIModelController instance3 = UIModelController.Instance;
				instance3.SelectThemeForCurrentModel(indexForLastSelectedTheme);
				UpdateSelectedCharacter();
				AudioSource audioSource = NGUITools.PlaySound(selectSound);
			}
		}
	}

	private void OnThemeButtonClicked(int index)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_007b: Expected Obj, but got I8
		//IL_0088: Expected VT, but got Obj
		object obj2 = default;
		object obj = obj2 - 32;
		CharacterScreenManager screenManagerInstance = _screenManagerInstance;
		screenManagerInstance.currentlyShownThemeIndex__BackingField = index;
		UIModelController instance = UIModelController.Instance;
		CharacterScreenManager screenManagerInstance2 = _screenManagerInstance;
		GameObject gameObject = instance.ShowMenuModel(screenManagerInstance2.currentlyShownCharacter__BackingField, index);
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
		UpdateUIElements();
	}

	private void UpdateCharacterSticker(Characters.CharacterType charType, int index)
	{
		//IL_0052: Expected Obj, but got I4
		//IL_0069: Expected Obj, but got I4
		//IL_009b: Expected Obj, but got I4
		object obj;
		do
		{
			Characters.Model model = Characters.characterData.get_Item(charType);
			CharacterTheme themeForCharacter = CharacterThemes.GetThemeForCharacter(charType, index);
			PlayerInfo instance = PlayerInfo.Instance;
			bool flag = instance.IsCharacterOwned(charType);
			bool flag2 = themeForCharacter == null;
			obj = 0;
			if (!flag2)
			{
				obj = 0;
				if (themeForCharacter.price == 0)
				{
					bool flag3 = CharacterStickerManager.IsThemeUnlockedForCharacter(charType, index);
					object obj2 = (flag3 ? 1 : 0) ^ 1;
					obj = obj2;
				}
			}
			bool active = _characterSelectButton.CurrentlyShownCharacterMatchesEventItem() && _currentActiveEventType == SSEventType.CharacterDay;
			characterDayEventElements.SetActive(active);
			bool active2 = ShouldEnableCharacterDayParticleSystem();
			_characterDayParticleSystem.SetActive(active2);
		}
		while (obj != null);
	}

	private void SetEventRibbonActive()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Expected Obj, but got Unknown
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Expected Obj, but got Unknown
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		_ = 0;
		_ = 0;
		_ = 0;
		SSEventsManagerController instance = SSEventsManagerController.instance;
		IEventManager activeEventManager = instance.GetActiveEventManager();
		bool flag2 = default;
		if (activeEventManager != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
			object obj3 = default;
			bool flag = (nint)obj3 == 7;
			flag2 = true;
			if (!flag)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
				object obj4 = default;
				bool flag3 = (nint)obj4 == 3;
				flag2 = flag3;
			}
		}
		_ = string.Empty;
		_ = string.Empty;
		_ = string.Empty;
		if (flag2)
		{
			object obj5 = obj + 12;
			object obj6 = obj + 8;
			object obj7 = obj + 4;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @58D");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4]");
		_ = 0;
	}

	private void SetRibbonInfo(RibbonPayload payload)
	{
	}

	private void OnPopupShown(string popupName)
	{
		if (_characterDayParticleSystem.activeSelf)
		{
			_characterDayParticleSystem.SetActive(value: false);
		}
	}

	private void OnLastPopupClosed()
	{
		bool active = ShouldEnableCharacterDayParticleSystem();
		_characterDayParticleSystem.SetActive(active);
		if (~(_hasShownModel ? 1u : 0u) == 0 && ~(isReturningFromMysteryBox ? 1u : 0u) == 0)
		{
			CharacterScreenManager screenManagerInstance = _screenManagerInstance;
			ChangeCurrentlyShownCharacter(screenManagerInstance.currentlyShownCharacter__BackingField, screenManagerInstance.currentlyShownThemeIndex__BackingField);
			isReturningFromMysteryBox = false;
		}
	}

	public void SetupAfterMysteryBox()
	{
		isReturningFromMysteryBox = true;
	}

	private bool ShouldEnableCharacterDayParticleSystem()
	{
		SSEventsManagerController instance = SSEventsManagerController.instance;
		IEventManager activeEventManager = instance.GetActiveEventManager(SSEventType.CharacterDay);
		bool flag = activeEventManager == null;
		bool result = false;
		if (!flag)
		{
			UIScreenController instance2 = UIScreenController.Instance;
			bool isShowingPopup = instance2.isShowingPopup;
			result = false;
			if (!isShowingPopup)
			{
				bool flag2 = _characterSelectButton.CurrentlyShownCharacterMatchesEventItem();
				result = flag2;
			}
		}
		return result;
	}

	private unsafe void ScaleScrollModels()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_019d: Expected F4, but got I
		//IL_00a9: Expected F8, but got I4
		//IL_01dc: Invalid comparison between F8 and I4
		//IL_03ba: Expected F8, but got I4
		//IL_03d7: Invalid comparison between F8 and I4
		//IL_00b7: Expected F8, but got I4
		//IL_02a7: Expected I4, but got F8
		//IL_02cb: Expected I, but got Obj
		//IL_0333: Expected F4, but got I
		//IL_032e: Expected native int or pointer, but got VT
		//IL_0352: Expected F4, but got I
		//IL_034d: Expected native int or pointer, but got VT
		object obj = default;
		Vector3 vector = (Vector3)(obj - 48);
		Transform transform = scrollPanel.transform;
		Vector3 localPosition = transform.localPosition;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+20]");
		float num = Math.Abs(0f);
		float value = num - _cachedScrollPosition;
		float num2 = Math.Abs(value);
		if (!(num2 > 1f))
		{
			return;
		}
		float num3 = num / _cellWidth;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2BE");
		double num5 = default;
		double num4 = Math.Abs(num5);
		if (!(num4 < 2147483648.0))
		{
			num5 = -2147483648.0;
		}
		double num6 = num5 - 4.0;
		if (!(num6 > 0.0))
		{
			num6 = 0.0;
		}
		List<GameObject> characterModels = _characterModels;
		double num7 = characterModels._size;
		double num8 = num5 + 4.0;
		if (!(num8 > (double)characterModels._size))
		{
			num7 = num8;
		}
		double num9 = num6;
		while (num9 < num7)
		{
			double num10 = num9 * (double)_cellWidth;
			float value2 = num - (float)num10;
			float num11 = Math.Abs(value2);
			float num12 = _cellWidth * 1.5f;
			float num13 = num11 / num12;
			float num14 = Math.Min(num13, 1f);
			bool flag = num13 < 0f;
			float num15 = 0f;
			if (!flag)
			{
				num15 = num14;
			}
			float num16 = num15 * -2f;
			float num17 = num16 * num15;
			float num18 = num17 * num15;
			float num19 = num15 * 3f;
			float num20 = num19 * num15;
			float num21 = num18 + num20;
			float num22 = num21 * 7f;
			float num23 = 1f - num21;
			float num24 = num23 * 10f;
			float num25 = num22 + num24;
			GameObject gameObject = _characterModels.get_Item((int)num9);
			Transform transform2 = gameObject.transform;
			nint num26 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v207 @ S0_v60 (Il2CppClass<UnityEngine.Vector3>)+5C]");
			nint num27 = 0;
			float num28 = (float)Vector3.oneVector * num25;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v208 @ S0_v61 (Il2CppStaticFields<UnityEngine.Vector3>)+10]");
			float num29 = 0f * num25;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v208 @ S0_v61 (Il2CppStaticFields<UnityEngine.Vector3>)+14]");
			float num30 = 0f * num25;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+18]");
			((Vector3*)(nint)vector)->z = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+10]");
			((Vector3*)(nint)vector)->x = 0f;
			transform2.localScale = vector;
			double num31 = num9 + 1.0;
			num9 = num31;
		}
		_cachedScrollPosition = num;
	}

	public CharacterScreen()
	{
		List<ListCharacterCell> list = default;
		list._002Ector();
		ListCharacterCells = list;
		List<KeyValuePair<Characters.CharacterType, Characters.Model>> list2 = default;
		list2._002Ector();
		_characterList = list2;
		_firstShow = true;
		List<GameObject> list3 = default;
		list3._002Ector();
		_characterModels = list3;
		List<CharacterOverlayHelper> list4 = default;
		list4._002Ector();
		_characterHelpers = list4;
		List<OverlayIndex> list5 = default;
		list5._002Ector();
		_characterIndices = list5;
		currentId = -1;
		base._002Ector();
	}

	private void _003COnEnable_003Eb__55_1()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0217: Unknown result type (might be due to invalid IL or missing references)
		//IL_021c: Expected Obj, but got Unknown
		//IL_0249: Unknown result type (might be due to invalid IL or missing references)
		//IL_024e: Expected Obj, but got Unknown
		//IL_0293: Unknown result type (might be due to invalid IL or missing references)
		//IL_0298: Expected Obj, but got Unknown
		//IL_0274: Unknown result type (might be due to invalid IL or missing references)
		//IL_0279: Expected Obj, but got Unknown
		//IL_0175: Unknown result type (might be due to invalid IL or missing references)
		//IL_017a: Expected Obj, but got Unknown
		//IL_004e: Expected Obj, but got I
		//IL_02e8: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 48;
		_ = 0;
		_ = 0;
		SimpleScrollSnap characterScroll = CharacterScroll;
		currentId = characterScroll.CurrentPanel__BackingField;
		ChangePanel();
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
		object obj9 = default;
		object obj10 = default;
		object obj12 = default;
		object obj13 = default;
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
					_ = currentId;
					continue;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
			bool flag2 = obj9 == obj10;
			bool flag3 = !flag2;
			object obj11 = obj12;
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
				obj11 = obj13;
			}
			_ = 0;
			object obj14 = obj + 16;
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
		object obj15 = obj7 + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @369C");
	}
}
