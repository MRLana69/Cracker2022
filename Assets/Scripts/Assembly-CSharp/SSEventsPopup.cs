using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using UI.Screens;
using UnityEngine;
using UnityEngine.Events;

public class SSEventsPopup : UIScreen
{
	[Serializable]
	private class EventTypeGameObjectPair
	{
		public SSEventType _eventType;

		public GameObject _gameObject;
	}

	private sealed class _003CDelayPositioning_003Ed__88(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public UISprite tracker;

		public GameObject objectToPosition;

		public Vector3 positionOffset;

		public Vector3 newRotation;

		public Vector3 newScale;

		object IEnumerator<object>.Current => _003C_003E2__current;

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
		}

		private unsafe bool MoveNext()
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected VT, but got Unknown
			//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d8: Expected VT, but got Unknown
			//IL_0132: Unknown result type (might be due to invalid IL or missing references)
			//IL_0137: Expected VT, but got Unknown
			//IL_019e: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a3: Expected VT, but got Unknown
			//IL_01f7: Unknown result type (might be due to invalid IL or missing references)
			//IL_01fc: Expected Obj, but got Unknown
			//IL_0219: Expected Obj, but got I
			//IL_0236: Expected Obj, but got I
			//IL_0268: Unknown result type (might be due to invalid IL or missing references)
			//IL_026d: Expected VT, but got Unknown
			//IL_0302: Unknown result type (might be due to invalid IL or missing references)
			//IL_0307: Expected VT, but got Unknown
			//IL_0351: Unknown result type (might be due to invalid IL or missing references)
			//IL_0356: Expected VT, but got Unknown
			//IL_038c: Expected F4, but got I
			//IL_0387: Expected native int or pointer, but got VT
			//IL_039b: Expected F4, but got VT
			//IL_0396: Expected native int or pointer, but got VT
			object obj = default;
			Vector3 vector = (Vector3)(obj - 224);
			_ = 0;
			_ = 0;
			_ = 0;
			_ = 0;
			if (_003C_003E1__state != 0)
			{
				if (_003C_003E1__state == 1)
				{
					_003C_003E1__state = -1;
					Transform transform = tracker.transform;
					Vector3 position = transform.position;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+D8]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+D0]");
					_ = 0;
					UIScreenController instance = UIScreenController.Instance;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+B8]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+B0]");
					_ = 0;
					Vector3 position2 = vector + 96;
					Vector3 vector2 = instance.Camera2DNormal.WorldToScreenPoint(position2);
					UIScreenController instance2 = UIScreenController.Instance;
					_ = 1065353216;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+98]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+D0]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+90]");
					_ = 0;
					Vector3 position3 = vector + 80;
					Vector3 vector3 = instance2.Camera3D.ScreenToWorldPoint(position3);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+D8]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+D0]");
					_ = 0;
					Transform transform2 = objectToPosition.transform;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+A8]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+A0]");
					_ = 0;
					Vector3 position4 = vector - -64;
					transform2.position = position4;
					Transform transform3 = objectToPosition.transform;
					Transform transform4 = objectToPosition.transform;
					Vector3 localPosition = transform4.localPosition;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+D0]");
					object obj2 = 0 + positionOffset;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+D4]");
					nint num = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SSEventsPopup+<DelayPositioning>d__88)+1C]");
					object obj3 = num + 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+D8]");
					nint num2 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SSEventsPopup+<DelayPositioning>d__88)+20]");
					object obj4 = num2 + 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+88]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+80]");
					_ = 0;
					Vector3 localPosition2 = vector + 48;
					transform3.localPosition = localPosition2;
					Transform transform5 = objectToPosition.transform;
					float num3 = (float)newRotation * ((float)Math.PI / 180f);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SSEventsPopup+<DelayPositioning>d__88)+28]");
					float num4 = 0f * ((float)Math.PI / 180f);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SSEventsPopup+<DelayPositioning>d__88)+2C]");
					float num5 = 0f * ((float)Math.PI / 180f);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+C8]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+C0]");
					_ = 0;
					Vector3 euler = vector + 32;
					Quaternion quaternion = Quaternion.Internal_FromEulerRad(euler);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+D8]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+D8]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+D0]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+D0]");
					_ = 0;
					Quaternion localRotation = (Quaternion)(vector + 16);
					transform5.localRotation = localRotation;
					Transform transform6 = objectToPosition.transform;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SSEventsPopup+<DelayPositioning>d__88)+38]");
					((Vector3*)(nint)vector)->z = 0f;
					((Vector3*)(nint)vector)->x = (float)newScale;
					transform6.localScale = vector;
				}
			}
			else
			{
				_003C_003E1__state = -1;
				object obj5 = default;
				_003C_003E2__current = obj5;
				_003C_003E1__state = 1;
			}
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

	private List<EventTypeGameObjectPair> _stateGameObjects;

	private const string ONLINE_SETTING_EVENT_ELEMENT_NEW_POSITION_OFFSET = "event_popup_element_new_position_offset";

	private const string ONLINE_SETTING_EVENT_ELEMENT_NEW_ROTATION = "event_popup_element_new_rotation";

	private const string ONLINE_SETTING_EVENT_ELEMENT_NEW_SCALE = "event_popup_element_new_scale";

	private static Vector3 SPECIAL_POWER_BOARD_POSITION_OFFSET;

	private static Vector3 SPECIAL_POWER_BOARD_ROTATION;

	private static Vector3 SPECIAL_POWER_BOARD_SCALE;

	private static Vector3 LIMITED_CHAR_POSITION_OFFSET;

	private static Vector3 LIMITED_CHAR_ROTATION;

	private static Vector3 LIMITED_CHAR_SCALE;

	private static Vector3 CHARACTER_DAY_MODEL_POSITION_OFFSET;

	private static Vector3 CHARACTER_DAY_MODEL_ROTATION;

	private static Vector3 CHARACTER_DAY_MODEL_SCALE;

	private static Vector3 MYSTERY_POWERUP_POSITION_OFFSET;

	private static Vector3 MYSTERY_POWERUP_ROTATION;

	private static Vector3 MYSTERY_POWERUP_SCALE;

	private GameObject _specialPowerBoard;

	private GameObject _limitedCharacter;

	private GameObject _mysteryPowerup;

	private GameObject _widgetsContainer;

	private UISprite _bgFill;

	private UISprite _bgOutline;

	private UILabel _eventTitleLine1;

	private UILabel _eventTitleLine2;

	private UILabel _clockLabel;

	private UILabel _clockDescriptionLabel;

	private UILabel _messageTitleLabel;

	private UILabel _messageSecondTitleLabel;

	private UILabel _checkItOutLabel;

	private GameObject _twoLinesDescription;

	private GameObject _jackpotBottomElements;

	private GameObject _jackpotTopElements;

	private GameObject _jackpotTopElementsHearts;

	private GameObject _jackpotTopElementsNormal;

	private GameObject _goToItemButton;

	private UILabel _jackpotsDescriptionLabel;

	private UILabel _MBJackpotLabel;

	private UILabel _SMBJackpotLabel;

	private UISprite _coinLeft;

	private UISprite _coinRight;

	private UISprite _bottomDescriptionBoxSprite;

	private UISprite _topSplatSprite;

	private UISprite _glowEffectSprite;

	private GameObject _descriptionEffectsParent;

	private List<UISprite> _listBgStripes;

	private GameObject _mysteryPowerupPrefab;

	private const float COIN_SPRITE_OFFSET = 2f;

	private IEventManager _activeEventManager;

	private readonly Vector2 _dimensionsBgFillNormalEvent;

	private readonly Vector2 _dimensionsBgOutlineNormalEvent;

	private readonly Vector2 _dimensionsBgFillCheckOutItemEvent;

	private readonly Vector2 _dimensionsBgOutlineCheckOutItemEvent;

	private readonly Vector2 _dimensionsBgFillExtendedCheckOutItemEvent;

	private readonly Vector2 _dimensionsBgOutlineExtendedCheckOutItemEvent;

	private readonly Vector3 _buttonPosition;

	private readonly Vector3 _buttonPositionWhenExtended;

	private readonly int _descriptionBoxNormalHeight;

	private readonly int _descriptionBoxExtendedHeight;

	private readonly int _rayEffectNormalHeight;

	private readonly int _rayEffectExtendedHeight;

	private readonly Vector3 _effectsNormalPosition;

	private readonly Vector3 _effectsExtendedPosition;

	private List<SSEventCategory> _supportedCategories;

	private void Awake()
	{
		while (_eventTitleLine1 != null && _eventTitleLine2 != null && _clockLabel != null && _messageTitleLabel != null && _messageSecondTitleLabel != null && _checkItOutLabel == null)
		{
		}
	}

	private void Update()
	{
		SetTheClock();
	}

	public override void Show()
	{
		base.Show();
		SSEventsManagerController instance = SSEventsManagerController.instance;
		IEventManager activeEventManager = instance.GetActiveEventManager();
		_activeEventManager = activeEventManager;
		UpdateUIElements();
		SetLabelsTexts();
		PresentCurrentEventAvailable();
	}

	private void SetTheClock()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_001c: Expected F8, but got I8
		//IL_00a0: Expected F8, but got I4
		//IL_0152: Unknown result type (might be due to invalid IL or missing references)
		//IL_0157: Expected Obj, but got Unknown
		//IL_0177: Expected Obj, but got I
		//IL_0180: Unknown result type (might be due to invalid IL or missing references)
		//IL_0185: Expected Obj, but got Unknown
		//IL_018e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0193: Expected Obj, but got Unknown
		//IL_01ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b3: Expected Obj, but got Unknown
		//IL_01d3: Expected Obj, but got I
		//IL_01dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e1: Expected Obj, but got Unknown
		//IL_01ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ef: Expected Obj, but got Unknown
		//IL_020a: Unknown result type (might be due to invalid IL or missing references)
		//IL_020f: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 32;
		_ = 0;
		SSEventsManagerController instance = SSEventsManagerController.instance;
		long num = instance.TimeLeftInSeconds();
		string text;
		if (num >= 1)
		{
			TimeSpan timeSpan = TimeSpan.FromSeconds(num);
			string format = Strings.Get(StringID.EVENTS_POPUP_CLOCK);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
			double value = 0.0 * 2.7777777777777777E-11;
			double num2 = Math.Abs(value);
			if (!(num2 < 2147483648.0))
			{
				value = -2147483648.0;
			}
			object obj3 = obj + 20;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
			object obj4 = (nint)0 / (nint)600000000;
			object obj5 = obj4 / 60;
			object obj6 = obj5 * 60;
			object obj7 = obj4 - obj6;
			object obj8 = obj + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
			object obj9 = (nint)0 / (nint)10000000;
			object obj10 = obj9 / 60;
			object obj11 = obj10 * 60;
			object obj12 = obj9 - obj11;
			object obj13 = obj + 12;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
			object arg2 = default;
			object arg3 = default;
			object arg4 = default;
			string arg = $"{arg2:00}:{arg3:00}:{arg4:00}";
			text = string.Format(format, arg);
		}
		else
		{
			text = Strings.Get(StringID.EVENT_POPUP_EVENT_EXPIRED);
		}
		_clockLabel.text = text;
	}

	private void UpdateUIElements()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected Obj, but got Unknown
		//IL_0056: Expected Obj, but got I4
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Expected Obj, but got Unknown
		//IL_08af: Expected I4, but got F8
		//IL_0488: Expected I4, but got F8
		//IL_08f6: Expected I4, but got F8
		//IL_00f5: Expected I4, but got F8
		//IL_04cf: Expected I4, but got F8
		//IL_093d: Expected I4, but got F8
		//IL_013c: Expected I4, but got F8
		//IL_0516: Expected I4, but got F8
		//IL_0984: Expected I4, but got F8
		//IL_09b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_09b9: Expected VT, but got Unknown
		//IL_0183: Expected I4, but got F8
		//IL_1859: Unknown result type (might be due to invalid IL or missing references)
		//IL_185e: Expected VT, but got Unknown
		//IL_055d: Expected I4, but got F8
		//IL_0c6f: Expected Obj, but got VT
		//IL_0c78: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c7d: Expected Obj, but got Unknown
		//IL_0ca1: Expected Obj, but got VT
		//IL_0ccd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cd2: Expected Obj, but got Unknown
		//IL_0cf6: Expected Obj, but got VT
		//IL_0cff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d04: Expected Obj, but got Unknown
		//IL_0d2f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d34: Expected VT, but got Unknown
		//IL_0d57: Expected Obj, but got VT
		//IL_0d60: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d65: Expected Obj, but got Unknown
		//IL_0d89: Expected Obj, but got VT
		//IL_0db5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dba: Expected Obj, but got Unknown
		//IL_0dde: Expected Obj, but got VT
		//IL_0de7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dec: Expected Obj, but got Unknown
		//IL_0e17: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e1c: Expected VT, but got Unknown
		//IL_0e3a: Expected Obj, but got VT
		//IL_0e43: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e48: Expected Obj, but got Unknown
		//IL_0e6c: Expected Obj, but got VT
		//IL_0e8a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e8f: Expected Obj, but got Unknown
		//IL_0e9f: Expected Obj, but got I
		//IL_0ea9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0eae: Expected Obj, but got Unknown
		//IL_0ed2: Expected Obj, but got VT
		//IL_0edb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ee0: Expected Obj, but got Unknown
		//IL_0f0b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f10: Expected VT, but got Unknown
		//IL_0a0b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a10: Expected Obj, but got Unknown
		//IL_0a3d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a42: Expected Obj, but got Unknown
		//IL_05b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b7: Expected VT, but got Unknown
		//IL_0f33: Expected Obj, but got VT
		//IL_0f3c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f41: Expected Obj, but got Unknown
		//IL_0f65: Expected Obj, but got VT
		//IL_0f91: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f96: Expected Obj, but got Unknown
		//IL_0fba: Expected Obj, but got VT
		//IL_0fc3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fc8: Expected Obj, but got Unknown
		//IL_0ff3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ff8: Expected VT, but got Unknown
		//IL_1010: Unknown result type (might be due to invalid IL or missing references)
		//IL_1015: Expected Obj, but got Unknown
		//IL_19bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_19c4: Expected Obj, but got Unknown
		//IL_1707: Unknown result type (might be due to invalid IL or missing references)
		//IL_170c: Expected VT, but got Unknown
		//IL_01ca: Expected I4, but got F8
		//IL_1047: Unknown result type (might be due to invalid IL or missing references)
		//IL_104c: Expected Obj, but got Unknown
		//IL_1a08: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a0d: Expected Obj, but got Unknown
		//IL_0609: Unknown result type (might be due to invalid IL or missing references)
		//IL_060e: Expected Obj, but got Unknown
		//IL_063b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0640: Expected Obj, but got Unknown
		//IL_021f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0224: Expected VT, but got Unknown
		//IL_0c4c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c51: Expected Obj, but got Unknown
		//IL_188b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1890: Expected Obj, but got Unknown
		//IL_1099: Unknown result type (might be due to invalid IL or missing references)
		//IL_109e: Expected Obj, but got Unknown
		//IL_153a: Unknown result type (might be due to invalid IL or missing references)
		//IL_153f: Expected Obj, but got Unknown
		//IL_0a68: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a6d: Expected Obj, but got Unknown
		//IL_0276: Unknown result type (might be due to invalid IL or missing references)
		//IL_027b: Expected Obj, but got Unknown
		//IL_02a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ad: Expected Obj, but got Unknown
		//IL_157f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1584: Expected Obj, but got Unknown
		//IL_172d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1732: Expected Obj, but got Unknown
		//IL_0aac: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ab1: Expected Obj, but got Unknown
		//IL_0666: Unknown result type (might be due to invalid IL or missing references)
		//IL_066b: Expected Obj, but got Unknown
		//IL_06aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_06af: Expected Obj, but got Unknown
		//IL_0852: Unknown result type (might be due to invalid IL or missing references)
		//IL_0857: Expected Obj, but got Unknown
		//IL_135e: Expected Obj, but got VT
		//IL_1367: Unknown result type (might be due to invalid IL or missing references)
		//IL_136c: Expected Obj, but got Unknown
		//IL_1390: Expected Obj, but got VT
		//IL_13bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_13c1: Expected Obj, but got Unknown
		//IL_13e5: Expected Obj, but got VT
		//IL_13ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_13f3: Expected Obj, but got Unknown
		//IL_1424: Unknown result type (might be due to invalid IL or missing references)
		//IL_1429: Expected Obj, but got Unknown
		//IL_11e4: Expected Obj, but got VT
		//IL_11ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_11f2: Expected Obj, but got Unknown
		//IL_1216: Expected Obj, but got VT
		//IL_1242: Unknown result type (might be due to invalid IL or missing references)
		//IL_1247: Expected Obj, but got Unknown
		//IL_126b: Expected Obj, but got VT
		//IL_1274: Unknown result type (might be due to invalid IL or missing references)
		//IL_1279: Expected Obj, but got Unknown
		//IL_12aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_12af: Expected Obj, but got Unknown
		//IL_042b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0430: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 320;
		_ = 0;
		_ = 0;
		if (_activeEventManager == null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
		object obj4 = default;
		object obj3 = obj4 - 1;
		object obj13;
		if ((nint)obj3 <= 6)
		{
			object obj5 = 1 << (int)obj3;
			object obj6 = obj5 & 0x65;
			if (obj6 != null)
			{
				goto IL_043f;
			}
			if ((nint)obj3 == 3)
			{
				_goToItemButton.SetActive(value: true);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2BE");
				double num2 = default;
				double num = Math.Abs(num2);
				int width = ((!(num < 2147483648.0)) ? int.MinValue : ((int)num2));
				_bgFill.width = width;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2BE");
				double num4 = default;
				double num3 = Math.Abs(num4);
				int height = ((!(num3 < 2147483648.0)) ? int.MinValue : ((int)num4));
				_bgFill.height = height;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2BE");
				double num6 = default;
				double num5 = Math.Abs(num6);
				int width2 = ((!(num5 < 2147483648.0)) ? int.MinValue : ((int)num6));
				_bgOutline.width = width2;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2BE");
				double num8 = default;
				double num7 = Math.Abs(num8);
				int height2 = ((!(num7 < 2147483648.0)) ? int.MinValue : ((int)num8));
				_bgOutline.height = height2;
				Transform transform = _goToItemButton.transform;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SSEventsPopup)+F8]");
				_ = 0;
				_ = _buttonPositionWhenExtended;
				Vector3 localPosition = (Vector3)(obj + 168);
				transform.localPosition = localPosition;
				_bottomDescriptionBoxSprite.height = _descriptionBoxExtendedHeight;
				Transform transform2 = _descriptionEffectsParent.transform;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SSEventsPopup)+120]");
				_ = 0;
				_ = _effectsExtendedPosition;
				Vector3 localPosition2 = (Vector3)(obj + 152);
				transform2.localPosition = localPosition2;
				UISprite uISprite = _listBgStripes.get_Item(0);
				if (((UIWidget)uISprite).mHeight != _rayEffectExtendedHeight)
				{
					object obj7 = obj + 288;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B5");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+128]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+120]");
					_ = 0;
					object obj8 = obj + 304;
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+118]");
					_ = 0;
					object obj10 = default;
					object obj11 = default;
					object obj12 = default;
					object obj14 = default;
					while (true)
					{
						_ = 0;
						object obj9 = obj + 304;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 == 1)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
						}
						else
						{
							if (obj10 == null)
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
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
						bool flag = obj11 != obj12;
						obj13 = obj14;
						if (!flag)
						{
							goto IL_03d3;
						}
						goto IL_069b;
					}
					object obj15 = obj + 288;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @142D");
				}
				goto IL_0c60;
			}
		}
		goto IL_0866;
		IL_0a9d:
		_ = 0;
		object obj16 = obj + 288;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
		object obj17;
		if ((nint)0 == 1)
		{
			obj13 = obj17;
			goto IL_15c4;
		}
		goto IL_1870;
		IL_043f:
		_goToItemButton.SetActive(value: true);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2BE");
		double num10 = default;
		double num9 = Math.Abs(num10);
		int width3 = ((!(num9 < 2147483648.0)) ? int.MinValue : ((int)num10));
		_bgFill.width = width3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2BE");
		double num12 = default;
		double num11 = Math.Abs(num12);
		int height3 = ((!(num11 < 2147483648.0)) ? int.MinValue : ((int)num12));
		_bgFill.height = height3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2BE");
		double num14 = default;
		double num13 = Math.Abs(num14);
		int width4 = ((!(num13 < 2147483648.0)) ? int.MinValue : ((int)num14));
		_bgOutline.width = width4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2BE");
		double num16 = default;
		double num15 = Math.Abs(num16);
		int height4 = ((!(num15 < 2147483648.0)) ? int.MinValue : ((int)num16));
		_bgOutline.height = height4;
		Transform transform3 = _goToItemButton.transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SSEventsPopup)+EC]");
		_ = 0;
		_ = _buttonPosition;
		Vector3 localPosition3 = (Vector3)(obj + 136);
		transform3.localPosition = localPosition3;
		_bottomDescriptionBoxSprite.height = _descriptionBoxNormalHeight;
		Transform transform4 = _descriptionEffectsParent.transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SSEventsPopup)+114]");
		_ = 0;
		_ = _effectsNormalPosition;
		Vector3 localPosition4 = (Vector3)(obj + 120);
		transform4.localPosition = localPosition4;
		UISprite uISprite2 = _listBgStripes.get_Item(0);
		if (((UIWidget)uISprite2).mHeight != _rayEffectNormalHeight)
		{
			object obj18 = obj + 288;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B5");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+128]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+120]");
			_ = 0;
			object obj19 = obj + 304;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+118]");
			_ = 0;
			object obj21 = default;
			object obj22 = default;
			object obj23 = default;
			object obj24 = default;
			while (true)
			{
				_ = 0;
				object obj20 = obj + 304;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 == 1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				}
				else
				{
					if (obj21 == null)
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
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
				bool flag2 = obj22 != obj23;
				obj17 = obj24;
				if (!flag2)
				{
					goto IL_07fa;
				}
				goto IL_0a9d;
			}
			object obj25 = obj + 288;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @142D");
		}
		goto IL_0c60;
		IL_07fa:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
		if ((nint)0 != 1)
		{
			object obj26 = obj + 288;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @142D");
			goto IL_0866;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
		object obj27 = default;
		obj17 = obj27;
		goto IL_0a9d;
		IL_069b:
		_ = 0;
		object obj28 = obj + 288;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
		if ((nint)0 == 1)
		{
			goto IL_15c4;
		}
		obj17 = obj13;
		goto IL_1870;
		IL_0866:
		_goToItemButton.SetActive(value: false);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2BE");
		double num18 = default;
		double num17 = Math.Abs(num18);
		int width5 = ((!(num17 < 2147483648.0)) ? int.MinValue : ((int)num18));
		_bgFill.width = width5;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2BE");
		double num20 = default;
		double num19 = Math.Abs(num20);
		int height5 = ((!(num19 < 2147483648.0)) ? int.MinValue : ((int)num20));
		_bgFill.height = height5;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2BE");
		double num22 = default;
		double num21 = Math.Abs(num22);
		int width6 = ((!(num21 < 2147483648.0)) ? int.MinValue : ((int)num22));
		_bgOutline.width = width6;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2BE");
		double num24 = default;
		double num23 = Math.Abs(num24);
		int height6 = ((!(num23 < 2147483648.0)) ? int.MinValue : ((int)num24));
		_bgOutline.height = height6;
		_bottomDescriptionBoxSprite.height = _descriptionBoxNormalHeight;
		Transform transform5 = _descriptionEffectsParent.transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SSEventsPopup)+114]");
		_ = 0;
		_ = _effectsNormalPosition;
		Vector3 localPosition5 = (Vector3)(obj + 104);
		transform5.localPosition = localPosition5;
		UISprite uISprite3 = _listBgStripes.get_Item(0);
		if (((UIWidget)uISprite3).mHeight == _rayEffectNormalHeight)
		{
			goto IL_0c60;
		}
		object obj29 = obj + 288;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B5");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+128]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+120]");
		_ = 0;
		object obj30 = obj + 304;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+118]");
		_ = 0;
		object obj32 = default;
		object obj33 = default;
		object obj34 = default;
		object obj35 = default;
		object obj36 = default;
		while (true)
		{
			_ = 0;
			object obj31 = obj + 304;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				if (obj32 == null)
				{
					goto IL_0c43;
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
			bool flag3 = obj33 != obj34;
			obj17 = obj35;
			if (flag3)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				goto IL_0c43;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			obj17 = obj36;
			break;
			IL_0c43:
			object obj37 = obj + 288;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @142D");
			goto IL_0c60;
		}
		_ = 0;
		object obj38 = obj + 288;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
		if ((nint)0 == 1)
		{
			obj13 = obj17;
			goto IL_15c4;
		}
		goto IL_1870;
		IL_15c4:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
		obj17 = obj13;
		goto IL_1870;
		IL_1870:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
		return;
		IL_0c60:
		object obj39 = GlobalColors.EVENTS_POPUP_CATEGORY_DEFAULT_TITLE_LINE_1_COLOR >> 16;
		object obj40 = obj39 & 0xFF;
		float num25 = (float)obj40 / 255f;
		object obj41 = GlobalColors.EVENTS_POPUP_CATEGORY_DEFAULT_TITLE_LINE_1_COLOR >> 24;
		float num26 = (float)obj41 / 255f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+110]");
		_ = 0;
		object obj42 = GlobalColors.EVENTS_POPUP_CATEGORY_DEFAULT_TITLE_LINE_1_COLOR & 0xFF;
		float num27 = (float)obj42 / 255f;
		object obj43 = GlobalColors.EVENTS_POPUP_CATEGORY_DEFAULT_TITLE_LINE_1_COLOR >> 8;
		object obj44 = obj43 & 0xFF;
		float num28 = (float)obj44 / 255f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+108]");
		_ = 0;
		Color color = (Color)(obj + 88);
		_eventTitleLine1.color = color;
		object obj45 = GlobalColors.EVENTS_POPUP_CATEGORY_DEFAULT_TITLE_LINE_2_COLOR >> 16;
		object obj46 = obj45 & 0xFF;
		float num29 = (float)obj46 / 255f;
		object obj47 = GlobalColors.EVENTS_POPUP_CATEGORY_DEFAULT_TITLE_LINE_2_COLOR >> 24;
		float num30 = (float)obj47 / 255f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+100]");
		_ = 0;
		object obj48 = GlobalColors.EVENTS_POPUP_CATEGORY_DEFAULT_TITLE_LINE_2_COLOR & 0xFF;
		float num31 = (float)obj48 / 255f;
		object obj49 = GlobalColors.EVENTS_POPUP_CATEGORY_DEFAULT_TITLE_LINE_2_COLOR >> 8;
		object obj50 = obj49 & 0xFF;
		float num32 = (float)obj50 / 255f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+F8]");
		_ = 0;
		Color color2 = (Color)(obj + 72);
		_eventTitleLine2.color = color2;
		object obj51 = GlobalColors.EVENTS_POPUP_CATEGORY_DEFAULT_TIMER_DESCRIPTION_COLOR >> 16;
		object obj52 = obj51 & 0xFF;
		float num33 = (float)obj52 / 255f;
		object obj53 = GlobalColors.EVENTS_POPUP_CATEGORY_DEFAULT_TIMER_DESCRIPTION_COLOR >> 24;
		float num34 = (float)obj53 / 255f;
		object obj54 = obj - -64;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+F0]");
		obj54 = 0;
		object obj55 = GlobalColors.EVENTS_POPUP_CATEGORY_DEFAULT_TIMER_DESCRIPTION_COLOR & 0xFF;
		float num35 = (float)obj55 / 255f;
		object obj56 = GlobalColors.EVENTS_POPUP_CATEGORY_DEFAULT_TIMER_DESCRIPTION_COLOR >> 8;
		object obj57 = obj56 & 0xFF;
		float num36 = (float)obj57 / 255f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+E8]");
		_ = 0;
		Color color3 = (Color)(obj + 56);
		_clockDescriptionLabel.color = color3;
		object obj58 = GlobalColors.EVENTS_POPUP_CATEGORY_DEFAULT_TIMER_COLOR >> 16;
		object obj59 = obj58 & 0xFF;
		float num37 = (float)obj59 / 255f;
		object obj60 = GlobalColors.EVENTS_POPUP_CATEGORY_DEFAULT_TIMER_COLOR >> 24;
		float num38 = (float)obj60 / 255f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+E0]");
		_ = 0;
		object obj61 = GlobalColors.EVENTS_POPUP_CATEGORY_DEFAULT_TIMER_COLOR & 0xFF;
		float num39 = (float)obj61 / 255f;
		object obj62 = GlobalColors.EVENTS_POPUP_CATEGORY_DEFAULT_TIMER_COLOR >> 8;
		object obj63 = obj62 & 0xFF;
		float num40 = (float)obj63 / 255f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+D8]");
		_ = 0;
		Color color4 = (Color)(obj + 40);
		_clockLabel.color = color4;
		object obj64 = obj + 288;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B5");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+128]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+120]");
		_ = 0;
		object obj65 = obj + 304;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+118]");
		_ = 0;
		object obj67 = default;
		object obj68 = default;
		object obj83 = default;
		object obj84 = default;
		object obj85 = default;
		object obj86 = default;
		while (true)
		{
			_ = 0;
			object obj66 = obj + 304;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				if (obj67 == null)
				{
					goto IL_1531;
				}
				_ = 0;
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
						if ((nint)obj68 == 4)
						{
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							if ((nint)0 != 1)
							{
								object obj69 = GlobalColors.EVENTS_POPUP_STRIPES_JACKPOT >> 16;
								object obj70 = obj69 & 0xFF;
								float num41 = (float)obj70 / 255f;
								object obj71 = GlobalColors.EVENTS_POPUP_STRIPES_JACKPOT >> 24;
								float num42 = (float)obj71 / 255f;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+D0]");
								_ = 0;
								object obj72 = GlobalColors.EVENTS_POPUP_STRIPES_JACKPOT & 0xFF;
								float num43 = (float)obj72 / 255f;
								object obj73 = GlobalColors.EVENTS_POPUP_STRIPES_JACKPOT >> 8;
								object obj74 = obj73 & 0xFF;
								float num44 = (float)obj74 / 255f;
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C8]");
								_ = 0;
								object obj75 = obj + 8;
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
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							if ((nint)0 != 1)
							{
								object obj76 = GlobalColors.EVENTS_POPUP_STRIPES_NORMAL >> 16;
								object obj77 = obj76 & 0xFF;
								float num45 = (float)obj77 / 255f;
								object obj78 = GlobalColors.EVENTS_POPUP_STRIPES_NORMAL >> 24;
								float num46 = (float)obj78 / 255f;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C0]");
								_ = 0;
								object obj79 = GlobalColors.EVENTS_POPUP_STRIPES_NORMAL & 0xFF;
								float num47 = (float)obj79 / 255f;
								object obj80 = GlobalColors.EVENTS_POPUP_STRIPES_NORMAL >> 8;
								object obj81 = obj80 & 0xFF;
								float num48 = (float)obj81 / 255f;
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+B8]");
								_ = 0;
								object obj82 = obj + 24;
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
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
			bool flag4 = obj83 != obj84;
			obj13 = obj85;
			if (flag4)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				goto IL_1531;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			obj13 = obj86;
			break;
			IL_1531:
			object obj87 = obj + 288;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @142D");
			return;
		}
		_ = 0;
		object obj88 = obj + 288;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
		bool flag5 = (nint)0 != 1;
		obj17 = obj13;
		if (!flag5)
		{
			goto IL_15c4;
		}
		goto IL_1870;
		IL_03d3:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
		if ((nint)0 != 1)
		{
			object obj89 = obj + 288;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @142D");
			goto IL_043f;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
		object obj90 = default;
		obj13 = obj90;
		goto IL_069b;
	}

	private unsafe void SetCategorySpecificElements()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_04c9: Expected Obj, but got VT
		//IL_04d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d7: Expected Obj, but got Unknown
		//IL_04fb: Expected Obj, but got VT
		//IL_0527: Unknown result type (might be due to invalid IL or missing references)
		//IL_052c: Expected Obj, but got Unknown
		//IL_0550: Expected Obj, but got VT
		//IL_0559: Unknown result type (might be due to invalid IL or missing references)
		//IL_055e: Expected Obj, but got Unknown
		//IL_0589: Unknown result type (might be due to invalid IL or missing references)
		//IL_058e: Expected VT, but got Unknown
		//IL_05ac: Expected Obj, but got VT
		//IL_05b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ba: Expected Obj, but got Unknown
		//IL_05de: Expected Obj, but got VT
		//IL_060a: Unknown result type (might be due to invalid IL or missing references)
		//IL_060f: Expected Obj, but got Unknown
		//IL_0633: Expected Obj, but got VT
		//IL_063c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0641: Expected Obj, but got Unknown
		//IL_066c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0671: Expected VT, but got Unknown
		//IL_0694: Expected Obj, but got VT
		//IL_069d: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a2: Expected Obj, but got Unknown
		//IL_06c6: Expected Obj, but got VT
		//IL_06f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_06f7: Expected Obj, but got Unknown
		//IL_071b: Expected Obj, but got VT
		//IL_0724: Unknown result type (might be due to invalid IL or missing references)
		//IL_0729: Expected Obj, but got Unknown
		//IL_0754: Unknown result type (might be due to invalid IL or missing references)
		//IL_0759: Expected VT, but got Unknown
		//IL_0777: Expected Obj, but got VT
		//IL_0780: Unknown result type (might be due to invalid IL or missing references)
		//IL_0785: Expected Obj, but got Unknown
		//IL_07a9: Expected Obj, but got VT
		//IL_07d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_07da: Expected Obj, but got Unknown
		//IL_07fe: Expected Obj, but got VT
		//IL_0807: Unknown result type (might be due to invalid IL or missing references)
		//IL_080c: Expected Obj, but got Unknown
		//IL_0837: Unknown result type (might be due to invalid IL or missing references)
		//IL_083c: Expected VT, but got Unknown
		//IL_0022: Expected Obj, but got VT
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected Obj, but got Unknown
		//IL_0054: Expected Obj, but got VT
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Expected Obj, but got Unknown
		//IL_00a9: Expected Obj, but got VT
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Expected Obj, but got Unknown
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Expected VT, but got Unknown
		//IL_0105: Expected Obj, but got VT
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Expected Obj, but got Unknown
		//IL_0137: Expected Obj, but got VT
		//IL_0163: Unknown result type (might be due to invalid IL or missing references)
		//IL_0168: Expected Obj, but got Unknown
		//IL_018c: Expected Obj, but got VT
		//IL_0195: Unknown result type (might be due to invalid IL or missing references)
		//IL_019a: Expected Obj, but got Unknown
		//IL_01c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ca: Expected VT, but got Unknown
		//IL_01ed: Expected Obj, but got VT
		//IL_01f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fb: Expected Obj, but got Unknown
		//IL_021f: Expected Obj, but got VT
		//IL_024b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0250: Expected Obj, but got Unknown
		//IL_0274: Expected Obj, but got VT
		//IL_027d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0282: Expected Obj, but got Unknown
		//IL_02ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b2: Expected VT, but got Unknown
		//IL_02d0: Expected Obj, but got VT
		//IL_02d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02de: Expected Obj, but got Unknown
		//IL_0302: Expected Obj, but got VT
		//IL_032e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0333: Expected Obj, but got Unknown
		//IL_0357: Expected Obj, but got VT
		//IL_0360: Unknown result type (might be due to invalid IL or missing references)
		//IL_0365: Expected Obj, but got Unknown
		//IL_0390: Unknown result type (might be due to invalid IL or missing references)
		//IL_0395: Expected VT, but got Unknown
		//IL_03b8: Expected Obj, but got VT
		//IL_03c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c6: Expected Obj, but got Unknown
		//IL_03ea: Expected Obj, but got VT
		//IL_0414: Expected F4, but got I
		//IL_040f: Expected native int or pointer, but got VT
		//IL_041e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0423: Expected Obj, but got Unknown
		//IL_0447: Expected Obj, but got VT
		//IL_0450: Unknown result type (might be due to invalid IL or missing references)
		//IL_0455: Expected Obj, but got Unknown
		//IL_047f: Expected F4, but got I
		//IL_047a: Expected native int or pointer, but got VT
		object obj = default;
		Color color = (Color)(obj - 288);
		SSEventCategory eventCategory = GetEventCategory();
		if (eventCategory == SSEventCategory.Cat1)
		{
			object obj2 = GlobalColors.EVENTS_POPUP_CATEGORY_VALENTINE_TITLE_LINE_1_COLOR >> 16;
			object obj3 = obj2 & 0xFF;
			float num = (float)obj3 / 255f;
			object obj4 = GlobalColors.EVENTS_POPUP_CATEGORY_VALENTINE_TITLE_LINE_1_COLOR >> 24;
			float num2 = (float)obj4 / 255f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+118]");
			_ = 0;
			object obj5 = GlobalColors.EVENTS_POPUP_CATEGORY_VALENTINE_TITLE_LINE_1_COLOR & 0xFF;
			float num3 = (float)obj5 / 255f;
			object obj6 = GlobalColors.EVENTS_POPUP_CATEGORY_VALENTINE_TITLE_LINE_1_COLOR >> 8;
			object obj7 = obj6 & 0xFF;
			float num4 = (float)obj7 / 255f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+110]");
			_ = 0;
			Color color2 = color - -64;
			_eventTitleLine1.color = color2;
			object obj8 = GlobalColors.EVENTS_POPUP_CATEGORY_VALENTINE_TITLE_LINE_2_COLOR >> 16;
			object obj9 = obj8 & 0xFF;
			float num5 = (float)obj9 / 255f;
			object obj10 = GlobalColors.EVENTS_POPUP_CATEGORY_VALENTINE_TITLE_LINE_2_COLOR >> 24;
			float num6 = (float)obj10 / 255f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+108]");
			_ = 0;
			object obj11 = GlobalColors.EVENTS_POPUP_CATEGORY_VALENTINE_TITLE_LINE_2_COLOR & 0xFF;
			float num7 = (float)obj11 / 255f;
			object obj12 = GlobalColors.EVENTS_POPUP_CATEGORY_VALENTINE_TITLE_LINE_2_COLOR >> 8;
			object obj13 = obj12 & 0xFF;
			float num8 = (float)obj13 / 255f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+100]");
			_ = 0;
			Color color3 = color + 48;
			_eventTitleLine2.color = color3;
			object obj14 = GlobalColors.EVENTS_POPUP_CATEGORY_VALENTINE_TIMER_DESCRIPTION_COLOR >> 16;
			object obj15 = obj14 & 0xFF;
			float num9 = (float)obj15 / 255f;
			object obj16 = GlobalColors.EVENTS_POPUP_CATEGORY_VALENTINE_TIMER_DESCRIPTION_COLOR >> 24;
			float num10 = (float)obj16 / 255f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+F8]");
			_ = 0;
			object obj17 = GlobalColors.EVENTS_POPUP_CATEGORY_VALENTINE_TIMER_DESCRIPTION_COLOR & 0xFF;
			float num11 = (float)obj17 / 255f;
			object obj18 = GlobalColors.EVENTS_POPUP_CATEGORY_VALENTINE_TIMER_DESCRIPTION_COLOR >> 8;
			object obj19 = obj18 & 0xFF;
			float num12 = (float)obj19 / 255f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+F0]");
			_ = 0;
			Color color4 = color + 32;
			_clockDescriptionLabel.color = color4;
			object obj20 = GlobalColors.EVENTS_POPUP_CATEGORY_VALENTINE_TIMER_COLOR >> 16;
			object obj21 = obj20 & 0xFF;
			float num13 = (float)obj21 / 255f;
			object obj22 = GlobalColors.EVENTS_POPUP_CATEGORY_VALENTINE_TIMER_COLOR >> 24;
			float num14 = (float)obj22 / 255f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+E8]");
			_ = 0;
			object obj23 = GlobalColors.EVENTS_POPUP_CATEGORY_VALENTINE_TIMER_COLOR & 0xFF;
			float num15 = (float)obj23 / 255f;
			object obj24 = GlobalColors.EVENTS_POPUP_CATEGORY_VALENTINE_TIMER_COLOR >> 8;
			object obj25 = obj24 & 0xFF;
			float num16 = (float)obj25 / 255f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+E0]");
			_ = 0;
			Color color5 = color + 16;
			_clockLabel.color = color5;
			object obj26 = GlobalColors.EVENTS_POPUP_CATEGORY_VALENTINE_SPLASH_COLOR >> 16;
			object obj27 = obj26 & 0xFF;
			float num17 = (float)obj27 / 255f;
			object obj28 = GlobalColors.EVENTS_POPUP_CATEGORY_VALENTINE_SPLASH_COLOR >> 24;
			float num18 = (float)obj28 / 255f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+D8]");
			((Color*)(nint)color)->b = 0f;
			object obj29 = GlobalColors.EVENTS_POPUP_CATEGORY_VALENTINE_SPLASH_COLOR & 0xFF;
			float num19 = (float)obj29 / 255f;
			object obj30 = GlobalColors.EVENTS_POPUP_CATEGORY_VALENTINE_SPLASH_COLOR >> 8;
			object obj31 = obj30 & 0xFF;
			float num20 = (float)obj31 / 255f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+D0]");
			((Color*)(nint)color)->r = 0f;
			_topSplatSprite.color = color;
			string text = Strings.Get(StringID.EVENTS_POPUP_CATEGORY_VALENTINE_TITLE);
			_eventTitleLine1.text = text;
		}
		else
		{
			object obj32 = GlobalColors.EVENTS_POPUP_CATEGORY_DEFAULT_TITLE_LINE_1_COLOR >> 16;
			object obj33 = obj32 & 0xFF;
			float num21 = (float)obj33 / 255f;
			object obj34 = GlobalColors.EVENTS_POPUP_CATEGORY_DEFAULT_TITLE_LINE_1_COLOR >> 24;
			float num22 = (float)obj34 / 255f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+C8]");
			_ = 0;
			object obj35 = GlobalColors.EVENTS_POPUP_CATEGORY_DEFAULT_TITLE_LINE_1_COLOR & 0xFF;
			float num23 = (float)obj35 / 255f;
			object obj36 = GlobalColors.EVENTS_POPUP_CATEGORY_DEFAULT_TITLE_LINE_1_COLOR >> 8;
			object obj37 = obj36 & 0xFF;
			float num24 = (float)obj37 / 255f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+C0]");
			_ = 0;
			Color color6 = color + 128;
			_eventTitleLine1.color = color6;
			object obj38 = GlobalColors.EVENTS_POPUP_CATEGORY_DEFAULT_TITLE_LINE_2_COLOR >> 16;
			object obj39 = obj38 & 0xFF;
			float num25 = (float)obj39 / 255f;
			object obj40 = GlobalColors.EVENTS_POPUP_CATEGORY_DEFAULT_TITLE_LINE_2_COLOR >> 24;
			float num26 = (float)obj40 / 255f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+B8]");
			_ = 0;
			object obj41 = GlobalColors.EVENTS_POPUP_CATEGORY_DEFAULT_TITLE_LINE_2_COLOR & 0xFF;
			float num27 = (float)obj41 / 255f;
			object obj42 = GlobalColors.EVENTS_POPUP_CATEGORY_DEFAULT_TITLE_LINE_2_COLOR >> 8;
			object obj43 = obj42 & 0xFF;
			float num28 = (float)obj43 / 255f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+B0]");
			_ = 0;
			Color color7 = color + 112;
			_eventTitleLine2.color = color7;
			object obj44 = GlobalColors.EVENTS_POPUP_CATEGORY_DEFAULT_TIMER_DESCRIPTION_COLOR >> 16;
			object obj45 = obj44 & 0xFF;
			float num29 = (float)obj45 / 255f;
			object obj46 = GlobalColors.EVENTS_POPUP_CATEGORY_DEFAULT_TIMER_DESCRIPTION_COLOR >> 24;
			float num30 = (float)obj46 / 255f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+A8]");
			_ = 0;
			object obj47 = GlobalColors.EVENTS_POPUP_CATEGORY_DEFAULT_TIMER_DESCRIPTION_COLOR & 0xFF;
			float num31 = (float)obj47 / 255f;
			object obj48 = GlobalColors.EVENTS_POPUP_CATEGORY_DEFAULT_TIMER_DESCRIPTION_COLOR >> 8;
			object obj49 = obj48 & 0xFF;
			float num32 = (float)obj49 / 255f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+A0]");
			_ = 0;
			Color color8 = color + 96;
			_clockDescriptionLabel.color = color8;
			object obj50 = GlobalColors.EVENTS_POPUP_CATEGORY_DEFAULT_TIMER_COLOR >> 16;
			object obj51 = obj50 & 0xFF;
			float num33 = (float)obj51 / 255f;
			object obj52 = GlobalColors.EVENTS_POPUP_CATEGORY_DEFAULT_TIMER_COLOR >> 24;
			float num34 = (float)obj52 / 255f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+98]");
			_ = 0;
			object obj53 = GlobalColors.EVENTS_POPUP_CATEGORY_DEFAULT_TIMER_COLOR & 0xFF;
			float num35 = (float)obj53 / 255f;
			object obj54 = GlobalColors.EVENTS_POPUP_CATEGORY_DEFAULT_TIMER_COLOR >> 8;
			object obj55 = obj54 & 0xFF;
			float num36 = (float)obj55 / 255f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+90]");
			_ = 0;
			Color color9 = color + 80;
			_clockLabel.color = color9;
		}
		bool active = eventCategory == SSEventCategory.None;
		_jackpotTopElementsNormal.SetActive(active);
		bool active2 = eventCategory == SSEventCategory.Cat1;
		_jackpotTopElementsHearts.SetActive(active2);
	}

	private unsafe SSEventCategory GetEventCategory()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Expected Ref, but got Unknown
		//IL_0445: Expected Obj, but got I
		//IL_01cc: Expected I4, but got Obj
		//IL_048e: Expected Obj, but got I
		//IL_0391: Expected Obj, but got I4
		//IL_03d6: Expected Obj, but got I
		//IL_0312: Expected Obj, but got I
		//IL_032c: Expected Obj, but got I4
		//IL_0342: Expected Obj, but got I
		//IL_0367: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 16;
		_ = 0;
		_ = 0;
		SSEventCategory sSEventCategory;
		if (~(Globals.DEBUG_USE_EVENT_TESTER ? 1u : 0u) == 0)
		{
			EventTesterManager instance = EventTesterManager.Instance;
			SSEventCategory eventCategory = instance.GetEventCategory();
			sSEventCategory = eventCategory;
		}
		else
		{
			OnlineSettings instance2 = OnlineSettings.instance;
			bool flag = instance2.TryGetValue("event_category", out *(string*)(obj + 12));
			bool flag2 = !flag;
			sSEventCategory = SSEventCategory.None;
			if (!flag2)
			{
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B");
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
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
								if ((nint)0 != 1)
								{
									object obj3 = default;
									sSEventCategory = (SSEventCategory)obj3;
									goto IL_04d3;
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
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
				object obj4 = default;
				object obj5 = default;
				bool flag3 = obj4 != obj5;
				SSEventCategory sSEventCategory2 = default;
				sSEventCategory = sSEventCategory2;
				if (!flag3)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					SSEventsPopup sSEventsPopup;
					if ((nint)0 != 1)
					{
						SSEventCategory sSEventCategory3 = default;
						int value__ = ((SSEventCategory*)(int)sSEventCategory3)->value__;
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 != 1)
						{
							object obj6 = default;
							if (obj6 != null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4]");
								object obj7 = (nint)0 << 2;
								object obj8 = obj + obj7;
								obj8 = ((SSEventCategory*)(int)sSEventCategory3)->value__;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4]");
								object obj9 = (nint)0 + (nint)1;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D");
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4]");
								object obj10 = -1;
								sSEventCategory = SSEventCategory.None;
								goto IL_04d3;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F");
							object obj11 = ((SSEventCategory*)(int)sSEventCategory3)->value__;
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							bool flag4 = (nint)0 != 1;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							sSEventsPopup = (SSEventsPopup)0;
							sSEventCategory = sSEventCategory3;
							if (flag4)
							{
								goto IL_04fc;
							}
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					bool flag5 = (nint)0 != 1;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					sSEventsPopup = (SSEventsPopup)0;
					SSEventCategory sSEventCategory4 = default;
					sSEventCategory = sSEventCategory4;
					if (!flag5)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						sSEventsPopup = (SSEventsPopup)0;
						sSEventCategory = sSEventCategory4;
					}
				}
				goto IL_04fc;
			}
		}
		goto IL_04d3;
		IL_04d3:
		bool flag6 = _supportedCategories.Contains(sSEventCategory);
		SSEventCategory result = sSEventCategory;
		if (!flag6)
		{
			result = SSEventCategory.None;
		}
		return result;
		IL_04fc:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
		goto IL_04d3;
	}

	private unsafe void SetLabelsTexts()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0925: Expected Obj, but got I
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Expected Obj, but got Unknown
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Expected Obj, but got Unknown
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Expected Obj, but got Unknown
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Expected Obj, but got Unknown
		//IL_00b4: Expected Obj, but got I
		//IL_0510: Expected Obj, but got I
		//IL_052c: Expected Obj, but got I
		//IL_0159: Expected Obj, but got I
		//IL_0540: Expected Obj, but got VT
		//IL_0549: Unknown result type (might be due to invalid IL or missing references)
		//IL_054e: Expected Obj, but got Unknown
		//IL_0572: Expected Obj, but got VT
		//IL_059e: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a3: Expected Obj, but got Unknown
		//IL_05c7: Expected Obj, but got VT
		//IL_05d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d5: Expected Obj, but got Unknown
		//IL_0600: Unknown result type (might be due to invalid IL or missing references)
		//IL_0605: Expected VT, but got Unknown
		//IL_0623: Expected Obj, but got VT
		//IL_062c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0631: Expected Obj, but got Unknown
		//IL_0655: Expected Obj, but got VT
		//IL_0681: Unknown result type (might be due to invalid IL or missing references)
		//IL_0686: Expected Obj, but got Unknown
		//IL_06aa: Expected Obj, but got VT
		//IL_06b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_06b8: Expected Obj, but got Unknown
		//IL_06e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e8: Expected VT, but got Unknown
		//IL_070b: Expected Obj, but got VT
		//IL_0714: Unknown result type (might be due to invalid IL or missing references)
		//IL_0719: Expected Obj, but got Unknown
		//IL_073d: Expected Obj, but got VT
		//IL_0769: Unknown result type (might be due to invalid IL or missing references)
		//IL_076e: Expected Obj, but got Unknown
		//IL_0792: Expected Obj, but got VT
		//IL_079b: Unknown result type (might be due to invalid IL or missing references)
		//IL_07a0: Expected Obj, but got Unknown
		//IL_07cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_07d0: Expected VT, but got Unknown
		//IL_07e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ed: Expected Obj, but got Unknown
		//IL_07ff: Expected I, but got Obj
		//IL_0808: Unknown result type (might be due to invalid IL or missing references)
		//IL_080d: Expected Obj, but got Unknown
		//IL_0820: Unknown result type (might be due to invalid IL or missing references)
		//IL_0825: Expected Obj, but got Unknown
		//IL_0837: Expected I, but got Obj
		//IL_0840: Unknown result type (might be due to invalid IL or missing references)
		//IL_0845: Expected Obj, but got Unknown
		//IL_086c: Expected Obj, but got I
		//IL_0875: Invalid comparison between Obj and F4
		//IL_017f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0184: Expected Obj, but got Unknown
		//IL_01d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01da: Expected Obj, but got Unknown
		//IL_021e: Expected Obj, but got VT
		//IL_0227: Unknown result type (might be due to invalid IL or missing references)
		//IL_022c: Expected Obj, but got Unknown
		//IL_0250: Expected Obj, but got VT
		//IL_027c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0281: Expected Obj, but got Unknown
		//IL_02a5: Expected Obj, but got VT
		//IL_02ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b3: Expected Obj, but got Unknown
		//IL_02de: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e3: Expected VT, but got Unknown
		//IL_0301: Expected Obj, but got VT
		//IL_030a: Unknown result type (might be due to invalid IL or missing references)
		//IL_030f: Expected Obj, but got Unknown
		//IL_0333: Expected Obj, but got VT
		//IL_035f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0364: Expected Obj, but got Unknown
		//IL_0388: Expected Obj, but got VT
		//IL_0391: Unknown result type (might be due to invalid IL or missing references)
		//IL_0396: Expected Obj, but got Unknown
		//IL_03c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c6: Expected VT, but got Unknown
		//IL_03e9: Expected Obj, but got VT
		//IL_03f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f7: Expected Obj, but got Unknown
		//IL_041b: Expected Obj, but got VT
		//IL_0445: Expected F4, but got I
		//IL_0440: Expected native int or pointer, but got VT
		//IL_044f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0454: Expected Obj, but got Unknown
		//IL_0478: Expected Obj, but got VT
		//IL_0481: Unknown result type (might be due to invalid IL or missing references)
		//IL_0486: Expected Obj, but got Unknown
		//IL_04b0: Expected F4, but got I
		//IL_04ab: Expected native int or pointer, but got VT
		object obj = default;
		Color color = (Color)(obj - 224);
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		if (_activeEventManager == null)
		{
			return;
		}
		_ = string.Empty;
		_ = string.Empty;
		_ = string.Empty;
		_ = string.Empty;
		bool flag = _activeEventManager == null;
		string text = string.Empty;
		if (!flag)
		{
			object obj2 = color + 220;
			object obj3 = color + 216;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @293");
			object obj4 = color + 208;
			object obj5 = color + 212;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @293");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+DC]");
			text = (string)0;
		}
		_eventTitleLine1.text = text;
		UILabel eventTitleLine = _eventTitleLine2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+D8]");
		eventTitleLine.text = (string)0;
		string text2 = Strings.Get(StringID.EVENTS_POPUP_CLOCK_DESCRIPTION);
		_clockDescriptionLabel.text = text2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
		object obj6 = default;
		if ((nint)obj6 == 4)
		{
			_twoLinesDescription.SetActive(value: false);
			_jackpotBottomElements.SetActive(value: true);
			_jackpotTopElements.SetActive(value: true);
			UILabel jackpotsDescriptionLabel = _jackpotsDescriptionLabel;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+D0]");
			jackpotsDescriptionLabel.text = (string)0;
			int megaJackpotAmount = MysteryBox.GetMegaJackpotAmount(MysteryBox.Type.Normal);
			object obj7 = color + 96;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
			object arg = default;
			string text3 = $"{arg:#,###0}";
			_MBJackpotLabel.text = text3;
			int megaJackpotAmount2 = MysteryBox.GetMegaJackpotAmount(MysteryBox.Type.Super);
			object obj8 = color + 204;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
			object arg2 = default;
			string text4 = $"{arg2:#,###0}";
			_SMBJackpotLabel.text = text4;
			object obj9 = GlobalColors.EVENTS_POPUP_DESCRIPTION_BOX_JACKPOT_EVENT_COLOR >> 16;
			object obj10 = obj9 & 0xFF;
			float num = (float)obj10 / 255f;
			object obj11 = GlobalColors.EVENTS_POPUP_DESCRIPTION_BOX_JACKPOT_EVENT_COLOR >> 24;
			float num2 = (float)obj11 / 255f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+C0]");
			_ = 0;
			object obj12 = GlobalColors.EVENTS_POPUP_DESCRIPTION_BOX_JACKPOT_EVENT_COLOR & 0xFF;
			float num3 = (float)obj12 / 255f;
			object obj13 = GlobalColors.EVENTS_POPUP_DESCRIPTION_BOX_JACKPOT_EVENT_COLOR >> 8;
			object obj14 = obj13 & 0xFF;
			float num4 = (float)obj14 / 255f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+B8]");
			_ = 0;
			Color color2 = color + 32;
			_bottomDescriptionBoxSprite.color = color2;
			object obj15 = GlobalColors.EVENTS_POPUP_DESCRIPTION_BOX_NORMAL_COLOR >> 16;
			object obj16 = obj15 & 0xFF;
			float num5 = (float)obj16 / 255f;
			object obj17 = GlobalColors.EVENTS_POPUP_DESCRIPTION_BOX_NORMAL_COLOR >> 24;
			float num6 = (float)obj17 / 255f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+B0]");
			_ = 0;
			object obj18 = GlobalColors.EVENTS_POPUP_DESCRIPTION_BOX_NORMAL_COLOR & 0xFF;
			float num7 = (float)obj18 / 255f;
			object obj19 = GlobalColors.EVENTS_POPUP_DESCRIPTION_BOX_NORMAL_COLOR >> 8;
			object obj20 = obj19 & 0xFF;
			float num8 = (float)obj20 / 255f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+A8]");
			_ = 0;
			Color color3 = color + 16;
			_topSplatSprite.color = color3;
			object obj21 = GlobalColors.EVENTS_POPUP_GLOW_JACKPOT_COLOR >> 16;
			object obj22 = obj21 & 0xFF;
			float num9 = (float)obj22 / 255f;
			object obj23 = GlobalColors.EVENTS_POPUP_GLOW_JACKPOT_COLOR >> 24;
			float num10 = (float)obj23 / 255f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+A0]");
			((Color*)(nint)color)->b = 0f;
			object obj24 = GlobalColors.EVENTS_POPUP_GLOW_JACKPOT_COLOR & 0xFF;
			float num11 = (float)obj24 / 255f;
			object obj25 = GlobalColors.EVENTS_POPUP_GLOW_JACKPOT_COLOR >> 8;
			object obj26 = obj25 & 0xFF;
			float num12 = (float)obj26 / 255f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+98]");
			((Color*)(nint)color)->r = 0f;
			_glowEffectSprite.color = color;
		}
		else
		{
			_twoLinesDescription.SetActive(value: true);
			_jackpotBottomElements.SetActive(value: false);
			_jackpotTopElements.SetActive(value: false);
			UILabel messageTitleLabel = _messageTitleLabel;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+D0]");
			messageTitleLabel.text = (string)0;
			UILabel messageSecondTitleLabel = _messageSecondTitleLabel;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+D4]");
			messageSecondTitleLabel.text = (string)0;
			object obj27 = GlobalColors.EVENTS_POPUP_DESCRIPTION_BOX_NORMAL_COLOR >> 16;
			object obj28 = obj27 & 0xFF;
			float num13 = (float)obj28 / 255f;
			object obj29 = GlobalColors.EVENTS_POPUP_DESCRIPTION_BOX_NORMAL_COLOR >> 24;
			float num14 = (float)obj29 / 255f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+90]");
			_ = 0;
			object obj30 = GlobalColors.EVENTS_POPUP_DESCRIPTION_BOX_NORMAL_COLOR & 0xFF;
			float num15 = (float)obj30 / 255f;
			object obj31 = GlobalColors.EVENTS_POPUP_DESCRIPTION_BOX_NORMAL_COLOR >> 8;
			object obj32 = obj31 & 0xFF;
			float num16 = (float)obj32 / 255f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+88]");
			_ = 0;
			Color color4 = color + 80;
			_bottomDescriptionBoxSprite.color = color4;
			object obj33 = GlobalColors.EVENTS_POPUP_SPLASH_COLOR >> 16;
			object obj34 = obj33 & 0xFF;
			float num17 = (float)obj34 / 255f;
			object obj35 = GlobalColors.EVENTS_POPUP_SPLASH_COLOR >> 24;
			float num18 = (float)obj35 / 255f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+80]");
			_ = 0;
			object obj36 = GlobalColors.EVENTS_POPUP_SPLASH_COLOR & 0xFF;
			float num19 = (float)obj36 / 255f;
			object obj37 = GlobalColors.EVENTS_POPUP_SPLASH_COLOR >> 8;
			object obj38 = obj37 & 0xFF;
			float num20 = (float)obj38 / 255f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+78]");
			_ = 0;
			Color color5 = color - -64;
			_topSplatSprite.color = color5;
			object obj39 = GlobalColors.EVENTS_POPUP_GLOW_DEFAULT_COLOR >> 16;
			object obj40 = obj39 & 0xFF;
			float num21 = (float)obj40 / 255f;
			object obj41 = GlobalColors.EVENTS_POPUP_GLOW_DEFAULT_COLOR >> 24;
			float num22 = (float)obj41 / 255f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+70]");
			_ = 0;
			object obj42 = GlobalColors.EVENTS_POPUP_GLOW_DEFAULT_COLOR & 0xFF;
			float num23 = (float)obj42 / 255f;
			object obj43 = GlobalColors.EVENTS_POPUP_GLOW_DEFAULT_COLOR >> 8;
			object obj44 = obj43 & 0xFF;
			float num24 = (float)obj44 / 255f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+68]");
			_ = 0;
			Color color6 = color + 48;
			_glowEffectSprite.color = color6;
			object obj45 = color + 96;
			UILabel messageSecondTitleLabel2 = _messageSecondTitleLabel;
			nint num25 = (nint)messageSecondTitleLabel2;
			object obj46 = messageSecondTitleLabel2 + 176;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v371 @ S2_v53 (Il2CppClass<UILabel>)+16C] (should have been resolved before IL gen)");
			object obj47 = color + 96;
			UISprite bottomDescriptionBoxSprite = _bottomDescriptionBoxSprite;
			nint num26 = (nint)bottomDescriptionBoxSprite;
			object obj48 = bottomDescriptionBoxSprite + 176;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v389 @ S2_v57 (Il2CppClass<UISprite>)+16C] (should have been resolved before IL gen)");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+60]");
			nint num27 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+60]");
			object obj49 = num27 / 0;
			bool flag2 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj49) > System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)0.95f);
			int fontSize = 15;
			if (!flag2)
			{
				fontSize = 16;
			}
			messageSecondTitleLabel2.fontSize = fontSize;
		}
		string text5 = Strings.Get(StringID.EVENTS_POPUP_CHECKOUT_BUTTON_TITLE);
		_checkItOutLabel.text = text5;
	}

	private void PresentCurrentEventAvailable()
	{
		if (_activeEventManager != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
			DisableAllStates();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v10+8]");
			if ((nint)0 != 0)
			{
				throw new ArgumentException();
			}
			string text = Strings.Get(StringID.EVENT_POPUP_NOT_AVAILABLE_DESCRIPTION);
			_messageTitleLabel.text = text;
			_messageSecondTitleLabel.text = string.Empty;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v10+8]");
			SetExtraSettingsForState(SSEventType.None);
		}
	}

	private void SetExtraSettingsForState(SSEventType eventType)
	{
		//IL_000e: Expected Obj, but got I4
		object obj = eventType - 1;
		if (eventType != SSEventType.SpecialPowerBoard)
		{
			if ((nint)obj == 1)
			{
				return;
			}
			if ((nint)obj != 2)
			{
				if ((nint)obj == 3)
				{
					PositionCoinIcons();
					SetCategorySpecificElements();
					return;
				}
				if ((nint)obj == 4)
				{
					PositionMysteryPowerup3dElements();
					return;
				}
				if ((nint)obj == 5)
				{
					AddSpecialPowerBoardEvent3dElements();
					return;
				}
				if ((nint)obj != 6)
				{
					return;
				}
			}
			AddLimitedCharacter3dElements(eventType);
		}
		else
		{
			AddSpecialPowerBoardEvent3dElements();
		}
	}

	private void PositionMysteryPowerup3dElements()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0280: Unknown result type (might be due to invalid IL or missing references)
		//IL_0285: Expected Obj, but got Unknown
		//IL_006c: Expected I, but got Obj
		//IL_0091: Expected Obj, but got I
		//IL_009f: Expected Obj, but got VT
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Expected VT, but got Unknown
		//IL_00d6: Expected I, but got Obj
		//IL_00fb: Expected Obj, but got I
		//IL_0109: Expected Obj, but got VT
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Expected VT, but got Unknown
		//IL_013b: Expected I, but got Obj
		//IL_0160: Expected Obj, but got I
		//IL_016e: Expected Obj, but got VT
		//IL_0177: Unknown result type (might be due to invalid IL or missing references)
		//IL_017c: Expected VT, but got Unknown
		//IL_01bb: Expected I4, but got Obj
		//IL_01cd: Expected I, but got Obj
		//IL_01df: Expected I4, but got Obj
		//IL_01f1: Expected I4, but got Obj
		//IL_0207: Unknown result type (might be due to invalid IL or missing references)
		//IL_020c: Expected VT, but got Unknown
		//IL_0215: Unknown result type (might be due to invalid IL or missing references)
		//IL_021a: Expected VT, but got Unknown
		//IL_0238: Expected VT, but got Obj
		object obj = default;
		SSEventsPopup sSEventsPopup = (SSEventsPopup)(obj - 144);
		sSEventsPopup._MBJackpotLabel = null;
		sSEventsPopup._goToItemButton = null;
		sSEventsPopup._jackpotTopElementsHearts = null;
		sSEventsPopup._jackpotBottomElements = null;
		sSEventsPopup._checkItOutLabel = null;
		sSEventsPopup._messageTitleLabel = null;
		object obj2 = this - -64;
		if (_mysteryPowerup == null)
		{
			UIModelController instance = UIModelController.Instance;
			Transform anchor = instance.TutorialPopupAnchor.transform;
			GameObject mysteryPowerup = sSEventsPopup.PlacePrefabUnderAnchor(_mysteryPowerupPrefab, anchor, 31);
			_mysteryPowerup = mysteryPowerup;
		}
		if ((UnityEngine.Object)obj2 != null)
		{
			nint num = (nint)typeof(SSEventsPopup);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ S1_v16 (Il2CppClass<SSEventsPopup>)+5C]");
			nint num2 = 0;
			SSEventsPopup sSEventsPopup2 = sSEventsPopup;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ S1_v17 (Il2CppStaticFields<SSEventsPopup>)+74]");
			sSEventsPopup2._clockLabel = (UILabel)0;
			sSEventsPopup._eventTitleLine1 = (UILabel)MYSTERY_POWERUP_POSITION_OFFSET;
			Vector3 defaultVal = (Vector3)(sSEventsPopup + 80);
			Vector3 vector = sSEventsPopup.VerifySettingOnline("event_popup_element_new_position_offset", defaultVal);
			nint num3 = (nint)typeof(SSEventsPopup);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ S1_v24 (Il2CppClass<SSEventsPopup>)+5C]");
			nint num4 = 0;
			SSEventsPopup sSEventsPopup3 = sSEventsPopup;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ S1_v25 (Il2CppStaticFields<SSEventsPopup>)+80]");
			sSEventsPopup3._bgFill = (UISprite)0;
			sSEventsPopup._mysteryPowerup = (GameObject)MYSTERY_POWERUP_ROTATION;
			Vector3 defaultVal2 = (Vector3)(sSEventsPopup - -64);
			Vector3 vector2 = sSEventsPopup.VerifySettingOnline("event_popup_element_new_rotation", defaultVal2);
			nint num5 = (nint)typeof(SSEventsPopup);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ S1_v32 (Il2CppClass<SSEventsPopup>)+5C]");
			nint num6 = 0;
			SSEventsPopup sSEventsPopup4 = sSEventsPopup;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ S1_v33 (Il2CppStaticFields<SSEventsPopup>)+8C]");
			sSEventsPopup4._specialPowerBoard = (GameObject)0;
			((UIScreen)sSEventsPopup).parentScreen__BackingField = (string)MYSTERY_POWERUP_SCALE;
			Vector3 defaultVal3 = (Vector3)(sSEventsPopup + 48);
			Vector3 vector3 = sSEventsPopup.VerifySettingOnline("event_popup_element_new_scale", defaultVal3);
			sSEventsPopup.InComplete = (UnityEvent)(object)sSEventsPopup._MBJackpotLabel;
			sSEventsPopup._selectedFooterButton = (int)sSEventsPopup._jackpotTopElementsHearts;
			((UnityEngine.Object)sSEventsPopup).m_CachedPtr = (IntPtr)sSEventsPopup._checkItOutLabel;
			((UIScreen)sSEventsPopup)._footerInited = (byte)(int)sSEventsPopup._goToItemButton != 0;
			((UIScreen)sSEventsPopup).addScreen = (byte)(int)sSEventsPopup._jackpotBottomElements != 0;
			sSEventsPopup = (SSEventsPopup)(object)sSEventsPopup._messageTitleLabel;
			Vector3 positionOffset = (Vector3)(sSEventsPopup + 32);
			Vector3 newRotation = (Vector3)(sSEventsPopup + 16);
			PositionModelOnSprite(_topSplatSprite, _mysteryPowerup, positionOffset, newRotation, (Vector3)sSEventsPopup);
		}
	}

	private unsafe void PositionCoinIcons()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Expected VT, but got Unknown
		//IL_013a: Expected native int or pointer, but got VT
		//IL_0166: Expected F4, but got I
		//IL_0161: Expected native int or pointer, but got VT
		object obj = default;
		Vector3 vector = (Vector3)(obj - 80);
		Transform transform = _coinLeft.transform;
		Transform transform2 = _MBJackpotLabel.transform;
		Vector3 localPosition = transform2.localPosition;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+40]");
		float num = 0f + 2f;
		Transform transform3 = _MBJackpotLabel.transform;
		Vector3 localPosition2 = transform3.localPosition;
		_ = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+44]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+30]");
		_ = 0;
		Vector3 localPosition3 = vector + 16;
		transform.localPosition = localPosition3;
		Transform transform4 = _coinRight.transform;
		Transform transform5 = _SMBJackpotLabel.transform;
		Vector3 localPosition4 = transform5.localPosition;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+40]");
		float num2 = 0f + 2f;
		Transform transform6 = _SMBJackpotLabel.transform;
		Vector3 localPosition5 = transform6.localPosition;
		_ = 0;
		((Vector3*)(nint)vector)->z = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+44]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+20]");
		((Vector3*)(nint)vector)->x = 0f;
		transform4.localPosition = vector;
	}

	private unsafe void AddSpecialPowerBoardEvent3dElements()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_010f: Expected VT, but got I4
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Expected Obj, but got Unknown
		//IL_007e: Expected VT, but got I4
		//IL_00df: Expected Ref, but got VT
		object obj = default;
		Hoverboards.BoardType? boardType = (Hoverboards.BoardType?)(object)(obj - 16);
		_ = 0;
		boardType = (Hoverboards.BoardType?)(object)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22E");
		if (_activeEventManager == null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
		object obj2 = default;
		bool flag = (nint)obj2 != 6;
		if ((nint)obj2 == 1)
		{
			flag = false;
		}
		if (!flag)
		{
			object obj3 = (Nullable)boardType + 15;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5A7");
			boardType = (Hoverboards.BoardType?)(object)1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Nullable`1<Hoverboards+BoardType>)+F]");
			if ((nint)0 != 0 && _specialPowerBoard == null)
			{
				Hoverboards.BoardType value = ((Hoverboards.BoardType?*)boardType)->Value;
				Hoverboards.Board board = Hoverboards.boardData.get_Item(value);
			}
		}
	}

	private void AddLimitedCharacter3dElements(SSEventType eventType)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_05e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e7: Expected Obj, but got Unknown
		//IL_0603: Unknown result type (might be due to invalid IL or missing references)
		//IL_0608: Expected Obj, but got Unknown
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected Obj, but got Unknown
		//IL_0168: Unknown result type (might be due to invalid IL or missing references)
		//IL_016d: Expected Obj, but got Unknown
		//IL_052a: Expected Obj, but got I
		//IL_0417: Expected Obj, but got I
		//IL_0442: Expected Obj, but got I
		//IL_0467: Expected Obj, but got I
		//IL_047d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0482: Expected Obj, but got Unknown
		//IL_04c9: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 32;
		_ = 0;
		_ = 0;
		object obj3 = obj + 8;
		_ = 0;
		_ = 0;
		object obj4 = obj + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22E");
		if (_activeEventManager == null)
		{
			return;
		}
		object obj5 = obj + 31;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5A7");
		_ = 1;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+1F]");
		if ((nint)0 == 0)
		{
			return;
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
				object obj6 = default;
				if (obj6 == null)
				{
					return;
				}
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					_ = 0;
					object obj7 = obj + 16;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
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
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
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
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @E");
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
									if ((nint)0 != 1)
									{
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
										if ((nint)0 != 1)
										{
											return;
										}
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
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
		object obj8 = default;
		object obj9 = default;
		bool flag = obj8 != obj9;
		object obj11 = default;
		object obj10 = obj11;
		if (!flag)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				object obj13 = default;
				object obj12 = obj13;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					object obj14 = default;
					if (obj14 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v10+4]");
						object obj15 = (nint)0 << 2;
						object obj16 = obj3 + obj15;
						obj16 = obj13;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v10+4]");
						object obj17 = (nint)0 + (nint)1;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v10+4]");
						object obj18 = (nint)0 << 2;
						object obj19 = obj18 + obj3;
						object obj20 = obj19 - 4;
						object obj21 = obj20;
						object obj22 = obj21;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v368 @ S1_v56+10C] (should have been resolved before IL gen)");
						string text2 = default;
						string text = "Limited character name is not accurate from Online Setting! : " + text2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v10+4]");
						object obj23 = -1;
						return;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F");
					object obj24 = obj13;
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					bool flag2 = (nint)0 != 1;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					obj10 = 0;
					if (flag2)
					{
						goto IL_0632;
					}
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			bool flag3 = (nint)0 != 1;
			object obj25 = default;
			obj10 = obj25;
			if (!flag3)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
				obj10 = obj25;
			}
		}
		goto IL_0632;
		IL_0632:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
	}

	private unsafe GameObject PlaceModelUnderAnchor(GameObject model, Transform anchor, int layer)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0064: Expected I, but got Obj
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Expected VT, but got Unknown
		//IL_00dc: Expected I, but got Obj
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		//IL_0127: Expected VT, but got Unknown
		//IL_0154: Expected I, but got Obj
		//IL_0179: Expected F4, but got I
		//IL_0174: Expected native int or pointer, but got VT
		//IL_0187: Expected F4, but got VT
		//IL_0182: Expected native int or pointer, but got VT
		object obj = default;
		Vector3 vector = (Vector3)(obj - 80);
		NGUITools.SetLayer(model, layer);
		Transform transform = model.transform;
		transform.parent = anchor;
		Transform transform2 = model.transform;
		nint num = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S0_v19 (Il2CppClass<UnityEngine.Vector3>)+5C]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S0_v20 (Il2CppStaticFields<UnityEngine.Vector3>)+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+48]");
		_ = 0;
		_ = Vector3.zeroVector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+40]");
		_ = 0;
		Vector3 localPosition = vector + 32;
		transform2.localPosition = localPosition;
		Transform transform3 = model.transform;
		nint num3 = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ S0_v34 (Il2CppClass<UnityEngine.Vector3>)+5C]");
		nint num4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ S0_v35 (Il2CppStaticFields<UnityEngine.Vector3>)+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+38]");
		_ = 0;
		_ = Vector3.zeroVector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+30]");
		_ = 0;
		Vector3 localEulerAngles = vector + 16;
		transform3.localEulerAngles = localEulerAngles;
		Transform transform4 = model.transform;
		nint num5 = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ S1_v31 (Il2CppClass<UnityEngine.Vector3>)+5C]");
		nint num6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ S1_v32 (Il2CppStaticFields<UnityEngine.Vector3>)+14]");
		((Vector3*)(nint)vector)->z = 0f;
		((Vector3*)(nint)vector)->x = (float)Vector3.oneVector;
		transform4.localScale = vector;
		return model;
	}

	private unsafe GameObject PlacePrefabUnderAnchor(GameObject prefab, Transform anchor, int layer)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0157: Expected I, but got Obj
		//IL_0069: Expected I, but got Obj
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Expected VT, but got Unknown
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Expected VT, but got Unknown
		//IL_0104: Expected I, but got Obj
		//IL_0129: Expected F4, but got I
		//IL_0124: Expected native int or pointer, but got VT
		//IL_0137: Expected F4, but got VT
		//IL_0132: Expected native int or pointer, but got VT
		object obj = default;
		Vector3 vector = (Vector3)(obj - 80);
		nint num = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S1_v5 (Il2CppClass<UnityEngine.Vector3>)+5C]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S1_v6 (Il2CppStaticFields<UnityEngine.Vector3>)+8]");
		_ = 0;
		_ = Vector3.zeroVector;
		nint num3 = (nint)typeof(Quaternion);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S1_v12 (Il2CppClass<UnityEngine.Quaternion>)+5C]");
		nint num4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S1_v13 (Il2CppStaticFields<UnityEngine.Quaternion>)+8]");
		_ = 0;
		_ = Quaternion.identityQuaternion;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+48]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+38]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+40]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+30]");
		_ = 0;
		Vector3 position = vector + 32;
		Quaternion rotation = (Quaternion)(vector + 16);
		GameObject gameObject = UnityEngine.Object.Instantiate(prefab, position, rotation);
		NGUITools.SetLayer(gameObject, layer);
		Transform transform = gameObject.transform;
		transform.parent = anchor;
		Transform transform2 = gameObject.transform;
		nint num5 = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ S1_v33 (Il2CppClass<UnityEngine.Vector3>)+5C]");
		nint num6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ S1_v34 (Il2CppStaticFields<UnityEngine.Vector3>)+14]");
		((Vector3*)(nint)vector)->z = 0f;
		((Vector3*)(nint)vector)->x = (float)Vector3.oneVector;
		transform2.localScale = vector;
		return gameObject;
	}

	private unsafe Vector3 VerifySettingOnline(string key, Vector3 defaultVal)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0438: Unknown result type (might be due to invalid IL or missing references)
		//IL_043d: Expected Ref, but got Unknown
		//IL_0464: Expected native int or pointer, but got VT
		//IL_0476: Expected native int or pointer, but got VT
		//IL_04b9: Expected VT, but got I
		//IL_0047: Expected Obj, but got I
		//IL_0488: Expected native int or pointer, but got VT
		//IL_0495: Expected native int or pointer, but got VT
		//IL_04a2: Expected native int or pointer, but got VT
		//IL_0393: Expected VT, but got I
		//IL_0409: Expected VT, but got I
		//IL_034c: Expected VT, but got I
		//IL_0274: Expected Obj, but got I
		//IL_029f: Expected Obj, but got I
		//IL_02c4: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 16;
		_ = 0;
		_ = 0;
		_ = string.Empty;
		OnlineSettings instance = OnlineSettings.instance;
		float z;
		float y;
		float x;
		Vector3 result;
		Vector3 vector = default;
		if (instance.TryGetValue(key, out *(string*)(obj + 12)))
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
			string[] array = ((string)0).Split(',');
			if (array.Length == 3)
			{
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @20");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @20");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @20");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						bool flag = (nint)0 != 1;
						float num = default;
						z = num;
						float num2 = default;
						y = num2;
						float num3 = default;
						x = num3;
						if (flag)
						{
							goto IL_0480;
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
				object obj3 = default;
				object obj4 = default;
				bool flag2 = obj3 != obj4;
				object obj6 = default;
				object obj5 = obj6;
				if (!flag2)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						object obj8 = default;
						object obj7 = obj8;
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 != 1)
						{
							object obj9 = default;
							if (obj9 != null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4]");
								object obj10 = (nint)0 << 2;
								object obj11 = obj + obj10;
								obj11 = obj8;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4]");
								object obj12 = (nint)0 + (nint)1;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D");
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4]");
								object obj13 = -1;
								z = defaultVal.z;
								y = defaultVal.y;
								x = defaultVal.x;
								goto IL_0480;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F");
							object obj14 = obj8;
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							bool flag3 = (nint)0 != 1;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							result = (Vector3)0;
							if (flag3)
							{
								goto IL_040e;
							}
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					vector = (Vector3)0;
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					bool flag4 = (nint)0 == 1;
					object obj15 = default;
					obj5 = obj15;
					if (flag4)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						result = (Vector3)0;
						goto IL_040e;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
			}
		}
		((Vector3*)(nint)vector)->x = defaultVal.x;
		((Vector3*)(nint)vector)->z = defaultVal.z;
		goto IL_04ac;
		IL_0480:
		Vector3 vector2 = default;
		((Vector3*)(nint)vector2)->z = z;
		((Vector3*)(nint)vector2)->y = y;
		((Vector3*)(nint)vector2)->x = x;
		goto IL_04ac;
		IL_040e:
		return result;
		IL_04ac:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
		return (Vector3)0;
	}

	private unsafe void OnDisable()
	{
		if (_specialPowerBoard != null)
		{
			_specialPowerBoard.SetActive(value: false);
		}
		if (_limitedCharacter != null)
		{
			_limitedCharacter.SetActive(value: false);
		}
		if (_mysteryPowerup != null)
		{
			_mysteryPowerup.SetActive(value: false);
		}
		Action action = default;
		action._002Ector(this, (nint)__ldftn(SSEventsPopup.HidePopupIfNeeded));
		SSEventsManagerController.OnSSEventFinishedHandler -= action;
		Action action2 = default;
		action2._002Ector(this, (nint)__ldftn(SSEventsPopup.HidePopupIfNeeded));
		UIScreenController.OnApplicationResumed -= action2;
	}

	private unsafe void OnEnable()
	{
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Expected Obj, but got Unknown
		SSEventsManagerController instance = SSEventsManagerController.instance;
		IEventManager activeEventManager = instance.GetActiveEventManager();
		_activeEventManager = activeEventManager;
		if (_activeEventManager != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
			object obj = default;
			if (_specialPowerBoard != null)
			{
				bool flag = (nint)obj == 1;
				bool flag2 = (nint)obj == 6;
				bool active = flag | flag2;
				_specialPowerBoard.SetActive(active);
			}
			if (_limitedCharacter != null)
			{
				object obj2 = obj & -5;
				bool active2 = (nint)obj2 == 3;
				_limitedCharacter.SetActive(active2);
			}
			if (_mysteryPowerup != null)
			{
				bool active3 = (nint)obj == 5;
				_mysteryPowerup.SetActive(active3);
			}
		}
		Action action = default;
		action._002Ector(this, (nint)__ldftn(SSEventsPopup.HidePopupIfNeeded));
		SSEventsManagerController.OnSSEventFinishedHandler += action;
		Action action2 = default;
		action2._002Ector(this, (nint)__ldftn(SSEventsPopup.HidePopupIfNeeded));
		UIScreenController.OnApplicationResumed += action2;
	}

	private void DisableAllStates()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0252: Unknown result type (might be due to invalid IL or missing references)
		//IL_0257: Expected Obj, but got Unknown
		//IL_0284: Unknown result type (might be due to invalid IL or missing references)
		//IL_0289: Expected Obj, but got Unknown
		//IL_02ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d3: Expected Obj, but got Unknown
		//IL_02af: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b4: Expected Obj, but got Unknown
		//IL_01bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c0: Expected Obj, but got Unknown
		//IL_004e: Expected Obj, but got I
		//IL_022c: Expected Obj, but got I
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
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				obj7 = 0;
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
			return;
		}
		object obj15 = obj7 + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AEB5");
	}

	public static void ShowIfNeeded()
	{
		//IL_009b: Expected I8, but got I4
		SSEventsManagerController instance = SSEventsManagerController.instance;
		IEventManager activeEventManager = instance.GetActiveEventManager();
		if (activeEventManager == null)
		{
			return;
		}
		PlayerInfo instance2 = PlayerInfo.Instance;
		if (~(instance2._isTutorialCompleted ? 1u : 0u) != 0)
		{
			return;
		}
		PlayerInfo instance3 = PlayerInfo.Instance;
		long num = instance3._lastTimeEventPopupHasBeenForcedShown;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6A1");
		long num2 = default;
		if (num2 < 1)
		{
			return;
		}
		if (num2 != instance3._lastTimeEventPopupHasBeenForcedShown)
		{
			num = 0L;
		}
		if (num == 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
			UIScreenController instance4 = UIScreenController.Instance;
			object obj = default;
			bool flag = (nint)obj == 8;
			object popupName = "CharacterNameEventPopup";
			if (!flag)
			{
				popupName = "EventsPopup";
			}
			instance4.QueuePopup((string)popupName);
			PlayerInfo instance5 = PlayerInfo.Instance;
			if (num2 != instance5._lastTimeEventPopupHasBeenForcedShown)
			{
				instance5._dirty = true;
				instance5._lastTimeEventPopupHasBeenForcedShown = num2;
			}
		}
	}

	private void HidePopupIfNeeded()
	{
		SSEventsManagerController instance = SSEventsManagerController.instance;
		IEventManager activeEventManager = instance.GetActiveEventManager();
		if (_activeEventManager != null && activeEventManager != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6A1");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6A1");
			object obj = default;
			object obj2 = default;
			if (obj == obj2)
			{
				return;
			}
		}
		if (_limitedCharacter != null)
		{
			_limitedCharacter.SetActive(value: false);
		}
		if (_specialPowerBoard != null)
		{
			_specialPowerBoard.SetActive(value: false);
		}
		UIScreenController instance2 = UIScreenController.Instance;
		instance2.CloseActivePopups(screenName);
	}

	public void GoToEventItem()
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected Obj, but got Unknown
		if (_activeEventManager == null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
		object obj2 = default;
		object obj = obj2 - 1;
		if ((nint)obj2 == 1)
		{
			goto IL_01b5;
		}
		if ((nint)obj == 1)
		{
			return;
		}
		object obj3;
		if ((nint)obj != 2)
		{
			if ((nint)obj == 3)
			{
				if (UIScreenController.IsInstanced)
				{
					UIScreenController instance = UIScreenController.Instance;
					instance.ignoreLastPopupClosed = true;
					UIScreenController instance2 = UIScreenController.Instance;
					instance2.doSaveAndDelayRemainingPopups = true;
					UIScreenController instance3 = UIScreenController.Instance;
					instance3.CloseActivePopups(screenName);
					obj3 = "UpgradesUI_shop";
					goto IL_0330;
				}
				return;
			}
			if ((nint)obj == 4)
			{
				return;
			}
			if ((nint)obj == 5)
			{
				goto IL_01b5;
			}
			if ((nint)obj != 6)
			{
				return;
			}
		}
		if (UIScreenController.IsInstanced)
		{
			if (_limitedCharacter != null)
			{
				_limitedCharacter.SetActive(value: false);
			}
			UIScreenController instance4 = UIScreenController.Instance;
			instance4.ignoreLastPopupClosed = true;
			UIScreenController instance5 = UIScreenController.Instance;
			instance5.doSaveAndDelayRemainingPopups = true;
			UIScreenController instance6 = UIScreenController.Instance;
			instance6.CloseActivePopups(screenName);
			obj3 = "CharacterScreen";
			goto IL_0330;
		}
		return;
		IL_01b5:
		if (UIScreenController.IsInstanced)
		{
			if (_specialPowerBoard != null)
			{
				_specialPowerBoard.SetActive(value: false);
			}
			UIScreenController instance7 = UIScreenController.Instance;
			instance7.ignoreLastPopupClosed = true;
			UIScreenController instance8 = UIScreenController.Instance;
			instance8.doSaveAndDelayRemainingPopups = true;
			UIScreenController instance9 = UIScreenController.Instance;
			instance9.CloseActivePopups(screenName);
			BoardScreenManager instance10 = BoardScreenManager.Instance;
			obj3 = "BoardScreen";
			goto IL_0330;
		}
		return;
		IL_0330:
		UpgradeScreen.forceScrollRearange = true;
		UIScreenController instance11 = UIScreenController.Instance;
		instance11.PushScreen((string)obj3);
	}

	private void PositionModelOnSprite(UISprite tracker, GameObject objectToPosition, Vector3 positionOffset, Vector3 newRotation, Vector3 newScale)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0020: Expected Obj, but got F4
		//IL_0032: Expected I4, but got F4
		//IL_0044: Expected I4, but got F4
		//IL_0056: Expected I4, but got F4
		//IL_0068: Expected I, but got F4
		//IL_0075: Expected Obj, but got F4
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Expected VT, but got Unknown
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Expected VT, but got Unknown
		//IL_00ae: Expected VT, but got Obj
		object obj = default;
		SSEventsPopup sSEventsPopup = (SSEventsPopup)(obj - 48);
		sSEventsPopup.InComplete = (UnityEvent)positionOffset.z;
		((UIScreen)sSEventsPopup)._footerInited = (byte)(int)positionOffset.x != 0;
		sSEventsPopup._selectedFooterButton = (int)newRotation.z;
		((UIScreen)sSEventsPopup).addScreen = (byte)(int)newRotation.x != 0;
		((UnityEngine.Object)sSEventsPopup).m_CachedPtr = (IntPtr)newScale.z;
		sSEventsPopup = (SSEventsPopup)newScale.x;
		Vector3 positionOffset2 = (Vector3)(sSEventsPopup + 32);
		Vector3 newRotation2 = (Vector3)(sSEventsPopup + 16);
		IEnumerator routine = sSEventsPopup.DelayPositioning(tracker, objectToPosition, positionOffset2, newRotation2, (Vector3)sSEventsPopup);
		Coroutine coroutine = StartCoroutine(routine);
	}

	private IEnumerator DelayPositioning(UISprite tracker, GameObject objectToPosition, Vector3 positionOffset, Vector3 newRotation, Vector3 newScale)
	{
		_ = 0;
		_ = positionOffset.z;
		_ = positionOffset.x;
		_ = newRotation.x;
		_ = newRotation.z;
		_ = newScale.x;
		_ = newScale.z;
		IEnumerator result = default;
		return result;
	}

	public SSEventsPopup()
	{
		//IL_003b: Expected VT, but got I8
		//IL_004a: Expected I4, but got I8
		//IL_0059: Expected I4, but got I8
		//IL_007c: Expected VT, but got I8
		//IL_008b: Expected VT, but got I8
		//IL_009a: Expected VT, but got I8
		//IL_00a9: Expected VT, but got I8
		//IL_00b8: Expected VT, but got I8
		//IL_00c7: Expected VT, but got I8
		//IL_00d6: Expected VT, but got I8
		List<EventTypeGameObjectPair> list = default;
		list._002Ector();
		_stateGameObjects = list;
		List<UISprite> list2 = default;
		list2._002Ector();
		_listBgStripes = list2;
		_ = 3247964160L;
		_ = -4611686018427387904L;
		_effectsNormalPosition = (Vector3)(-4548635620422975488L);
		_rayEffectNormalHeight = 43;
		_descriptionBoxNormalHeight = 80;
		_ = 3273392128L;
		_ = -4593671619917905920L;
		_buttonPosition = (Vector3)(-4394668808158052352L);
		_dimensionsBgOutlineExtendedCheckOutItemEvent = (Vector2)4872472585483059200L;
		_dimensionsBgFillExtendedCheckOutItemEvent = (Vector2)4870783735622467584L;
		_dimensionsBgOutlineCheckOutItemEvent = (Vector2)4868954148274176000L;
		_dimensionsBgFillCheckOutItemEvent = (Vector2)4867265298413584384L;
		_dimensionsBgOutlineNormalEvent = (Vector2)4855443349392064512L;
		_dimensionsBgFillNormalEvent = (Vector2)4851784174694498304L;
		List<SSEventCategory> list3 = default;
		list3._002Ector();
		list3.Add(SSEventCategory.None);
		list3.Add(SSEventCategory.Cat1);
		_supportedCategories = list3;
		base._002Ector();
	}

	static SSEventsPopup()
	{
		//IL_0013: Expected I, but got Obj
		//IL_0037: Expected VT, but got I8
		//IL_0045: Expected I, but got Obj
		//IL_0069: Expected VT, but got I8
		//IL_0077: Expected I, but got Obj
		//IL_009b: Expected VT, but got I8
		//IL_00a9: Expected I, but got Obj
		//IL_00cd: Expected VT, but got I8
		//IL_00db: Expected I, but got Obj
		//IL_00ff: Expected VT, but got I8
		//IL_010d: Expected I, but got Obj
		//IL_0131: Expected VT, but got I8
		//IL_013f: Expected I, but got Obj
		//IL_0163: Expected VT, but got I8
		//IL_0171: Expected I, but got Obj
		//IL_0195: Expected VT, but got I8
		//IL_01a3: Expected I, but got Obj
		//IL_01c7: Expected VT, but got I8
		//IL_01d5: Expected I, but got Obj
		//IL_01f9: Expected VT, but got I8
		//IL_0207: Expected I, but got Obj
		//IL_022b: Expected VT, but got I8
		//IL_0239: Expected I, but got Obj
		//IL_025d: Expected VT, but got I8
		nint num = (nint)typeof(SSEventsPopup);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v11 @ S0_v6 (Il2CppClass<SSEventsPopup>)+5C]");
		nint num2 = 0;
		_ = 0;
		SPECIAL_POWER_BOARD_POSITION_OFFSET = (Vector3)4656722017926512640L;
		nint num3 = (nint)typeof(SSEventsPopup);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v10 (Il2CppClass<SSEventsPopup>)+5C]");
		nint num4 = 0;
		_ = -1034787226;
		SPECIAL_POWER_BOARD_ROTATION = (Vector3)4825607001827180544L;
		nint num5 = (nint)typeof(SSEventsPopup);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v14 (Il2CppClass<SSEventsPopup>)+5C]");
		nint num6 = 0;
		_ = 1090519040;
		SPECIAL_POWER_BOARD_SCALE = (Vector3)4683743613555834880L;
		nint num7 = (nint)typeof(SSEventsPopup);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v18 (Il2CppClass<SSEventsPopup>)+5C]");
		nint num8 = 0;
		_ = 0;
		LIMITED_CHAR_POSITION_OFFSET = (Vector3)(-4461941330817318912L);
		nint num9 = (nint)typeof(SSEventsPopup);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v22 (Il2CppClass<SSEventsPopup>)+5C]");
		nint num10 = 0;
		_ = 1077936128;
		LIMITED_CHAR_ROTATION = (Vector3)(-4387350460893233152L);
		nint num11 = (nint)typeof(SSEventsPopup);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S0_v26 (Il2CppClass<SSEventsPopup>)+5C]");
		nint num12 = 0;
		_ = 1090519040;
		LIMITED_CHAR_SCALE = (Vector3)4683743613555834880L;
		nint num13 = (nint)typeof(SSEventsPopup);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ S0_v30 (Il2CppClass<SSEventsPopup>)+5C]");
		nint num14 = 0;
		_ = 0;
		CHARACTER_DAY_MODEL_POSITION_OFFSET = (Vector3)(-4461378377642672128L);
		nint num15 = (nint)typeof(SSEventsPopup);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ S0_v34 (Il2CppClass<SSEventsPopup>)+5C]");
		nint num16 = 0;
		_ = 1077936128;
		CHARACTER_DAY_MODEL_ROTATION = (Vector3)(-4387350460893233152L);
		nint num17 = (nint)typeof(SSEventsPopup);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S0_v38 (Il2CppClass<SSEventsPopup>)+5C]");
		nint num18 = 0;
		_ = 1090519040;
		CHARACTER_DAY_MODEL_SCALE = (Vector3)4683743613555834880L;
		nint num19 = (nint)typeof(SSEventsPopup);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ S0_v42 (Il2CppClass<SSEventsPopup>)+5C]");
		nint num20 = 0;
		_ = 0;
		MYSTERY_POWERUP_POSITION_OFFSET = (Vector3)(-4464193130631004160L);
		nint num21 = (nint)typeof(SSEventsPopup);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S0_v46 (Il2CppClass<SSEventsPopup>)+5C]");
		nint num22 = 0;
		_ = 0;
		MYSTERY_POWERUP_ROTATION = (Vector3)4844184350283005952L;
		nint num23 = (nint)typeof(SSEventsPopup);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ S0_v50 (Il2CppClass<SSEventsPopup>)+5C]");
		nint num24 = 0;
		_ = 1083179008;
		MYSTERY_POWERUP_SCALE = (Vector3)4652218416156901376L;
	}
}
