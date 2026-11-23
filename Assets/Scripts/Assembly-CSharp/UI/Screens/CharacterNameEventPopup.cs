using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using SYBO.Subway.Info;
using UnityEngine;
using UnityEngine.Events;

namespace UI.Screens;

public class CharacterNameEventPopup : UIScreen
{
	private enum HorizontalScrollDirections
	{
		left = -1,
		right = 1
	}

	private sealed class _003CDelayPositioning_003Ed__77(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
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
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.Screens.CharacterNameEventPopup+<DelayPositioning>d__77)+1C]");
					object obj3 = num + 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+D8]");
					nint num2 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.Screens.CharacterNameEventPopup+<DelayPositioning>d__77)+20]");
					object obj4 = num2 + 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+88]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+80]");
					_ = 0;
					Vector3 localPosition2 = vector + 48;
					transform3.localPosition = localPosition2;
					Transform transform5 = objectToPosition.transform;
					float num3 = (float)newRotation * ((float)Math.PI / 180f);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.Screens.CharacterNameEventPopup+<DelayPositioning>d__77)+28]");
					float num4 = 0f * ((float)Math.PI / 180f);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.Screens.CharacterNameEventPopup+<DelayPositioning>d__77)+2C]");
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
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.Screens.CharacterNameEventPopup+<DelayPositioning>d__77)+38]");
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

	private sealed class _003CAnimateScrollBar_003Ed__90(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public CharacterNameEventPopup _003C_003E4__this;

		public float amount;

		public HorizontalScrollDirections direction;

		public float speedFactor;

		private float _003CanimationLerpFactor_003E5__2;

		private Transform _003CcharacterScrollTrans_003E5__3;

		private Vector3 _003CcharacterScrollLocalPosition_003E5__4;

		private float _003CstartValue_003E5__5;

		private float _003CendValue_003E5__6;

		object IEnumerator<object>.Current => _003C_003E2__current;

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
		}

		private unsafe bool MoveNext()
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected VT, but got Unknown
			//IL_00cd: Expected VT, but got I
			//IL_00e6: Expected F4, but got VT
			//IL_0261: Expected F4, but got I
			//IL_025c: Expected native int or pointer, but got VT
			//IL_027b: Expected F4, but got I
			//IL_0276: Expected native int or pointer, but got VT
			object obj = default;
			Vector3 vector = (Vector3)(obj + -64);
			CharacterNameEventPopup characterNameEventPopup = _003C_003E4__this;
			if (_003C_003E1__state != 0)
			{
				if (_003C_003E1__state != 1)
				{
					bool result = default;
					return result;
				}
				_003C_003E1__state = -1;
			}
			else
			{
				_003CanimationLerpFactor_003E5__2 = 0f;
				_003C_003E1__state = -1;
				Transform transform = characterNameEventPopup.characterScrollAnchor.transform;
				_003CcharacterScrollTrans_003E5__3 = transform;
				Vector3 localPosition = _003CcharacterScrollTrans_003E5__3.localPosition;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+28]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+20]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+20]");
				_003CcharacterScrollLocalPosition_003E5__4 = (Vector3)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+28]");
				_ = 0;
				_003CstartValue_003E5__5 = (float)_003CcharacterScrollLocalPosition_003E5__4;
				float num = amount * (float)direction;
				float num2 = (float)_003CcharacterScrollLocalPosition_003E5__4 + num;
				_003CendValue_003E5__6 = num2;
				characterNameEventPopup.SetSkipButtonCollidersEnabled(state: false);
			}
			if (!(_003CanimationLerpFactor_003E5__2 < 1f))
			{
				characterNameEventPopup.SetSkipButtonCollidersEnabled(state: true);
				return false;
			}
			float deltaTime = Time.deltaTime;
			float num3 = deltaTime * speedFactor;
			float num4 = (_003CanimationLerpFactor_003E5__2 += num3);
			float num5 = _003CendValue_003E5__6 - _003CstartValue_003E5__5;
			float num6 = Math.Min(num4, 1f);
			bool flag = num4 < 0f;
			float num7 = 0f;
			if (!flag)
			{
				num7 = num6;
			}
			float num8 = num5 * num7;
			float num9 = _003CstartValue_003E5__5 + num8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.Screens.CharacterNameEventPopup+<AnimateScrollBar>d__90)+2C]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+18]");
			((Vector3*)(nint)vector)->z = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+10]");
			((Vector3*)(nint)vector)->x = 0f;
			_003CcharacterScrollTrans_003E5__3.localPosition = vector;
			_003C_003E2__current = null;
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

	private sealed class _003CAnimateCharacter_003Ed__91(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public CharacterScreenController characterController;

		public float speedFactor;

		public float freezeStart;

		public float freezeEnd;

		public float scaleStartValue;

		public float scaleEndValue;

		public float positionStartValue;

		public float positionEndValue;

		private float _003CanimationLerpFactor_003E5__2;

		private Transform _003CcharacterModelTrans_003E5__3;

		private Vector3 _003CcharacterModelPosition_003E5__4;

		object IEnumerator<object>.Current => _003C_003E2__current;

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
		}

		private unsafe bool MoveNext()
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected VT, but got Unknown
			//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
			//IL_00cd: Expected Obj, but got Unknown
			//IL_00dd: Expected Obj, but got I
			//IL_00ef: Expected VT, but got I
			//IL_0122: Unknown result type (might be due to invalid IL or missing references)
			//IL_0127: Expected Obj, but got Unknown
			//IL_0388: Unknown result type (might be due to invalid IL or missing references)
			//IL_038d: Expected VT, but got Unknown
			//IL_03a2: Unknown result type (might be due to invalid IL or missing references)
			//IL_03a7: Expected Obj, but got Unknown
			//IL_03c1: Expected F4, but got I
			//IL_03bc: Expected native int or pointer, but got VT
			//IL_03e2: Expected F4, but got I
			//IL_03dd: Expected native int or pointer, but got VT
			object obj = default;
			Vector3 vector = (Vector3)(obj - 96);
			if (_003C_003E1__state != 0)
			{
				if (_003C_003E1__state != 1)
				{
					goto IL_020f;
				}
				_003C_003E1__state = -1;
			}
			else
			{
				_003CanimationLerpFactor_003E5__2 = 0f;
				_003C_003E1__state = -1;
				if (!(characterController != null))
				{
					goto IL_020f;
				}
				Transform transform = characterController.transform;
				_003CcharacterModelTrans_003E5__3 = transform;
				Vector3 localPosition = _003CcharacterModelTrans_003E5__3.localPosition;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+48]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+40]");
				_ = 0;
				object obj2 = this - -64;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+48]");
				obj2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+40]");
				_003CcharacterModelPosition_003E5__4 = (Vector3)0;
			}
			if (!(_003CanimationLerpFactor_003E5__2 < 1f))
			{
				characterController.Freeze = freezeEnd;
				_003CcharacterModelTrans_003E5__3 = null;
				object obj3 = this + 56;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22E");
				return false;
			}
			float deltaTime = Time.deltaTime;
			float num = deltaTime * speedFactor;
			float num2 = (_003CanimationLerpFactor_003E5__2 += num);
			float num3 = freezeEnd - freezeStart;
			float num4 = Math.Min(num2, 1f);
			bool flag = num2 < 0f;
			float num5 = 0f;
			if (!flag)
			{
				num5 = num4;
			}
			float num6 = num3 * num5;
			float freeze = freezeStart + num6;
			characterController.Freeze = freeze;
			float num7 = positionEndValue - positionStartValue;
			float num8 = Math.Min(_003CanimationLerpFactor_003E5__2, 1f);
			bool flag2 = _003CanimationLerpFactor_003E5__2 < 0f;
			float num9 = 0f;
			if (!flag2)
			{
				num9 = num8;
			}
			float num10 = num7 * num9;
			float num11 = positionStartValue + num10;
			float num12 = scaleEndValue - scaleStartValue;
			float num13 = Math.Min(_003CanimationLerpFactor_003E5__2, 1f);
			bool flag3 = _003CanimationLerpFactor_003E5__2 < 0f;
			float num14 = 0f;
			if (!flag3)
			{
				num14 = num13;
			}
			float num15 = num12 * num14;
			float num16 = scaleStartValue + num15;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+38]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+30]");
			_ = 0;
			Vector3 localScale = vector + 16;
			_003CcharacterModelTrans_003E5__3.localScale = localScale;
			object obj4 = this - -64;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+28]");
			((Vector3*)(nint)vector)->z = 0f;
			_ = _003CcharacterModelPosition_003E5__4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+20]");
			((Vector3*)(nint)vector)->x = 0f;
			_003CcharacterModelTrans_003E5__3.localPosition = vector;
			_003C_003E2__current = null;
			_003C_003E1__state = 1;
			return true;
			IL_020f:
			bool result = default;
			return result;
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

	private UIWidget outline;

	private GameObject characterScrollAnchor;

	private GameObject _categoryModelAnchor;

	private GameObject skipWithKeysButtonWidget;

	private GameObject skipWithAdButtonWidget;

	private GameObject completeSignWidget;

	private GameObject startArrowWidget;

	private GameObject endArrowWidget;

	private GameObject centerAnchor;

	private GameObject overlayClipAnchor;

	private GameObject selectButtonPrefab;

	private GameObject eventDescriptionBox;

	private UILabel eventDescriptionBoxName;

	private GameObject eventDescriptionBoxActive;

	private UILabel eventDescriptionBoxTitleInactive;

	private UILabel eventDescriptionTitleActive;

	private UILabel eventDescriptionBoxNameActive;

	private UILabel eventDescriptionBoxNameActiveShadow;

	private UILabel firstTitle;

	private UILabel secondTitle;

	private UILabel skipButtonKeyAmount;

	private UILabel timerLabel;

	private UILabel _timerDescriptionLabel;

	private UILabel startArrowLabel;

	private UILabel endArrowLabel;

	private GameObject _lpModelPrefab;

	private UISprite _topSplatSprite;

	private GameObject _superMysteryBoxIcon;

	private GameObject _movieIcon;

	private GameObject _danceIcon;

	private GameObject _lpModel;

	private List<KeyValuePair<Characters.CharacterType, CharacterScreenController>> _characterControllers;

	private int _scrollPopulationStartFromSlot;

	private int _currentlyFocusedIndex;

	private bool _isFirstFocused;

	private bool _isLastFocused;

	private CharacterNameEventManager _characterNameEventManager;

	private CharacterSelectButton _selectButton;

	private BoxCollider _skipWithKeysButtonCollider;

	private BoxCollider _skipWithAdButtonCollider;

	private const float DEFAULT_SCALE_FACTOR = 9.3f;

	private const float FOCUSED_SCALE_FACTOR = 13f;

	private const float DEFAULT_Y_POSITION_ON_SCROLL = 0f;

	private const float FOCUSED_Y_POSITION_ON_SCROLL = -9f;

	private const float DEFAULT_FREEZE_VALUE = 1f;

	private const float FOCUSED_FREEZE_VALUE = 0f;

	private const float ANIMATION_SPEED_FACTOR = 2f;

	private const float SPACING_BETWEEN_CHARACTERS = 77f;

	private const string ONLINESETTINGS_ALLOW_SKIP_WITH_ADS_KEY = "character_name_event_skip_with_ads";

	private const bool DEFAULT_ALLOW_SKIP_WITH_ADS = true;

	private const string ONLINE_SETTING_EVENT_ELEMENT_NEW_POSITION_OFFSET = "event_popup_element_new_position_offset";

	private const string ONLINE_SETTING_EVENT_ELEMENT_NEW_ROTATION = "event_popup_element_new_rotation";

	private const string ONLINE_SETTING_EVENT_ELEMENT_NEW_SCALE = "event_popup_element_new_scale";

	private readonly Vector3 LP_POSITION_OFFSET;

	private readonly Vector3 LP_ROTATION;

	private readonly Vector3 LP_SCALE;

	private bool isAllowedToSkipWithAds
	{
		get
		{
			OnlineSettings instance = OnlineSettings.instance;
			return instance.GetValue("character_name_event_skip_with_ads", defaultValue: true);
		}
	}

	public override void Init()
	{
		//IL_0076: Expected I, but got Obj
		do
		{
			nint num = (nint)this;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v13 @ S1_v3 (Il2CppClass<UI.Screens.CharacterNameEventPopup>)+104] (should have been resolved before IL gen)");
			InitializeSelectButton();
			BoxCollider component = skipWithKeysButtonWidget.GetComponent<BoxCollider>();
			_skipWithKeysButtonCollider = component;
			BoxCollider component2 = skipWithAdButtonWidget.GetComponent<BoxCollider>();
			_skipWithAdButtonCollider = component2;
		}
		while (!(_skipWithAdButtonCollider == null) && _skipWithKeysButtonCollider == null);
	}

	public override void GainFocus()
	{
		overlayClipAnchor.SetActive(value: true);
		characterScrollAnchor.SetActive(value: true);
		_categoryModelAnchor.SetActive(value: true);
		ClearScrollListOfCharacters();
		InitScrollWithCharacterModels();
		EnableUIElementsForList();
		InitCategorySpecificElements();
	}

	public override void LoseFocus()
	{
		overlayClipAnchor.SetActive(value: false);
		characterScrollAnchor.SetActive(value: false);
		_categoryModelAnchor.SetActive(value: false);
	}

	private void SetActiveCharacterNameEventManager()
	{
		SSEventsManagerController instance = SSEventsManagerController.instance;
		CharacterNameEventManager typeOfActiveEventManager = instance.GetTypeOfActiveEventManager<CharacterNameEventManager>();
		_characterNameEventManager = typeOfActiveEventManager;
	}

	private unsafe void InitializeSelectButton()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_008b: Expected native int or pointer, but got VT
		//IL_00a3: Expected native int or pointer, but got VT
		object obj = default;
		Vector3 vector = (Vector3)(obj - 32);
		GameObject gameObject = NGUITools.AddChild(centerAnchor, selectButtonPrefab);
		CharacterSelectButton component = gameObject.GetComponent<CharacterSelectButton>();
		_selectButton = component;
		if (_selectButton != null)
		{
			Transform t = _selectButton.transform;
			Utility.SetLayerRecursively(t, 30);
			Transform transform = _selectButton.transform;
			_ = 0;
			((Vector3*)(nint)vector)->z = 0f;
			_ = -4382846862361624576L;
			((Vector3*)(nint)vector)->x = 0f;
			transform.localPosition = vector;
			_selectButton.InitButton(CharacterSelectButton.ButtonContext.characterNameEventPopup);
		}
	}

	private void ReloadSelectButton(Characters.CharacterType charType, int themeIndex)
	{
		RefreshDescriptionBox();
		if (_characterNameEventManager != null)
		{
			UpdateSkipButtonState();
		}
		_selectButton.ReloadButton();
	}

	private void UpdateSkipButtonState(bool forceDisableAds = false)
	{
		bool flag = false;
		if (!forceDisableAds)
		{
			bool flag2 = isAllowedToSkipWithAds;
			bool flag3 = !flag2;
			flag = false;
			if (!flag3)
			{
				VideoAdsManager instance = VideoAdsManager.instance;
				bool flag4 = instance.IsAnyVideoAvailable();
				flag = flag4;
			}
		}
		bool flag5 = _characterNameEventManager.IsAbleToSkip();
		bool flag6 = !flag;
		bool active = flag5 & flag6;
		skipWithKeysButtonWidget.SetActive(active);
		bool active2 = flag5 & flag;
		skipWithAdButtonWidget.SetActive(active2);
	}

	private void OnSelectCharacter()
	{
		RefreshDescriptionBox();
		_selectButton.ReloadButton();
	}

	public unsafe override void Show()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0295: Expected Obj, but got I4
		object obj2 = default;
		object obj = obj2 - 16;
		_ = 0;
		_ = 0;
		obj = 0;
		base.Show();
		SetActiveCharacterNameEventManager();
		Action action = default;
		action._002Ector(this, (nint)__ldftn(CharacterNameEventPopup.HidePopupIfNeeded));
		SSEventsManagerController.OnSSEventFinishedHandler += action;
		CharacterScreenManager instance = CharacterScreenManager.Instance;
		throw new ArgumentException();
	}

	private void InitCategorySpecificElements()
	{
		if (_characterNameEventManager == null)
		{
			return;
		}
		SSEventCategory eventCategory = _characterNameEventManager.GetEventCategory();
		bool flag = eventCategory == SSEventCategory.None;
		SSEventCategory sSEventCategory = eventCategory;
		if (!flag)
		{
			if (eventCategory != SSEventCategory.Cat1)
			{
				bool flag2 = eventCategory == SSEventCategory.Cat2;
				sSEventCategory = eventCategory;
				if (!flag2)
				{
					bool flag3 = eventCategory == SSEventCategory.Cat3;
					sSEventCategory = eventCategory;
					if (!flag3)
					{
						sSEventCategory = SSEventCategory.None;
					}
				}
			}
			else
			{
				CreateAndPositionLP3DElements();
				sSEventCategory = SSEventCategory.Cat1;
			}
		}
		bool state = sSEventCategory == SSEventCategory.Cat1;
		SetActiveIfExists(_lpModel, state);
		bool active = sSEventCategory == SSEventCategory.Cat2;
		_movieIcon.SetActive(active);
		bool active2 = sSEventCategory == SSEventCategory.Cat3;
		_danceIcon.SetActive(active2);
		bool active3 = sSEventCategory == SSEventCategory.None;
		_superMysteryBoxIcon.SetActive(active3);
	}

	private void SetActiveIfExists(GameObject go, bool state)
	{
		if (go != null)
		{
			go.SetActive(state);
		}
	}

	private void SetSkipButtonCollidersEnabled(bool state)
	{
		if (_skipWithAdButtonCollider != null)
		{
			_skipWithAdButtonCollider.enabled = state;
		}
		if (_skipWithKeysButtonCollider != null)
		{
			_skipWithKeysButtonCollider.enabled = state;
		}
	}

	public unsafe override void Hide()
	{
		base.Hide();
		Action action = default;
		action._002Ector(this, (nint)__ldftn(CharacterNameEventPopup.HidePopupIfNeeded));
		SSEventsManagerController.OnSSEventFinishedHandler -= action;
		CharacterScreenManager instance = CharacterScreenManager.Instance;
		throw new ArgumentException();
	}

	private void ClearScrollListOfCharacters()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0512: Unknown result type (might be due to invalid IL or missing references)
		//IL_0517: Expected Obj, but got Unknown
		//IL_0551: Unknown result type (might be due to invalid IL or missing references)
		//IL_0556: Expected Obj, but got Unknown
		//IL_05a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a9: Expected Obj, but got Unknown
		//IL_0577: Unknown result type (might be due to invalid IL or missing references)
		//IL_057c: Expected Obj, but got Unknown
		//IL_046f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0474: Expected Obj, but got Unknown
		//IL_048e: Expected Obj, but got I
		//IL_0046: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 + -64;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		object obj3 = obj + 8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1119");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		_ = 0;
		object obj4 = obj + 40;
		obj = obj4;
		_ = 0;
		object obj6 = default;
		object obj7 = default;
		object obj8 = default;
		object obj9 = default;
		object obj10 = default;
		object obj12 = default;
		object obj13 = default;
		CharacterNameEventPopup characterNameEventPopup = default;
		while (true)
		{
			_ = 0;
			object obj5 = obj + 40;
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
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+34]");
				obj = 0;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
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
								if (obj7 == null)
								{
									continue;
								}
								_ = 0;
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
												if (obj8 == null)
												{
													continue;
												}
												_ = 0;
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
															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @C");
															_ = 0;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
															if ((nint)0 != 1)
															{
																continue;
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
											goto IL_03a5;
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
							goto IL_03a5;
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
			goto IL_03a5;
			IL_03a5:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
			bool flag = obj9 == obj10;
			bool flag2 = !flag;
			object obj11 = obj12;
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
				obj11 = obj13;
			}
			_ = 0;
			object obj14 = obj + 8;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			characterNameEventPopup = (CharacterNameEventPopup)0;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 == 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
			return;
		}
		object obj15 = obj + 8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B29A");
		((List<T>)(object)characterNameEventPopup._characterControllers).Clear();
	}

	private unsafe void InitScrollWithCharacterModels()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0056: Expected F4, but got I
		//IL_0051: Expected native int or pointer, but got VT
		//IL_007e: Expected F4, but got I
		//IL_0079: Expected native int or pointer, but got VT
		object obj = default;
		Vector3 vector = (Vector3)(obj - 48);
		Transform transform = characterScrollAnchor.transform;
		Transform transform2 = characterScrollAnchor.transform;
		Vector3 localPosition = transform2.localPosition;
		Transform transform3 = characterScrollAnchor.transform;
		Vector3 localPosition2 = transform3.localPosition;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+28]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+18]");
		((Vector3*)(nint)vector)->z = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+24]");
		_ = 0;
		_ = -1030094848;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+10]");
		((Vector3*)(nint)vector)->x = 0f;
		transform.localPosition = vector;
		if (_characterNameEventManager == null)
		{
			return;
		}
		List<Characters.CharacterType> charactersToDisplay = _characterNameEventManager.GetCharactersToDisplay();
		bool isFirstFocused = _characterNameEventManager.IsShowingFirstElement();
		_isFirstFocused = isFirstFocused;
		bool isLastFocused = _characterNameEventManager.IsShowingLastElement();
		_isLastFocused = isLastFocused;
		bool flag = _characterNameEventManager.IsFirstCharacterSelected();
		if (_characterNameEventManager.HasCompletedCollectionForSelectedCharacter())
		{
			_scrollPopulationStartFromSlot = (flag ? 1 : 0);
			int currentlyFocusedIndex = (flag ? 1 : 0) ^ 1;
			_currentlyFocusedIndex = currentlyFocusedIndex;
			Invoke("ScrollToNextCharacter", 0.3f);
		}
		else
		{
			_scrollPopulationStartFromSlot = (_isFirstFocused ? 1 : 0);
			int currentlyFocusedIndex2 = (_isFirstFocused ? 1 : 0) ^ 1;
			_currentlyFocusedIndex = currentlyFocusedIndex2;
		}
		int num = 0;
		while (true)
		{
			int num2 = num;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ S0_v28 (System.Collections.Generic.List`1<SYBO.Subway.Info.Characters+CharacterType>)+C]");
			if ((nint)num2 >= (nint)0)
			{
				break;
			}
			Characters.CharacterType characterType = charactersToDisplay.get_Item(num);
			InsertCharacterIntoModelsList(characterType, _currentlyFocusedIndex);
			int num3 = num + 1;
			num = num3;
		}
		Transform t = characterScrollAnchor.transform;
		Utility.SetLayerRecursively(t, 29);
	}

	private void InsertCharacterIntoModelsList(Characters.CharacterType characterType, int focusedIndex)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		object obj2 = default;
		Enum obj = (Enum)(obj2 - 16);
		if (_characterNameEventManager != null)
		{
			CharacterNameEventManager characterNameEventManager = _characterNameEventManager;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v9+8]");
			int lastSelectedThemeForCharacterType = characterNameEventManager.GetLastSelectedThemeForCharacterType(Characters.CharacterType.slick);
			CharacterModelPreviewFactory instance = CharacterModelPreviewFactory.Instance;
			_ = -1;
			obj = (Enum)(object)typeof(Characters.CharacterType);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v9+8]");
			_ = 0;
			string text = obj.ToString();
			throw new ArgumentException();
		}
	}

	private void CreateAndPositionLP3DElements()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_023e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0243: Expected Obj, but got Unknown
		//IL_008d: Expected Obj, but got I
		//IL_009c: Expected Obj, but got VT
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Expected VT, but got Unknown
		//IL_00d5: Expected Obj, but got I
		//IL_00e4: Expected Obj, but got VT
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Expected VT, but got Unknown
		//IL_0122: Expected Obj, but got I
		//IL_0131: Expected Obj, but got VT
		//IL_013a: Unknown result type (might be due to invalid IL or missing references)
		//IL_013f: Expected VT, but got Unknown
		//IL_0179: Expected I4, but got Obj
		//IL_018b: Expected I, but got Obj
		//IL_019d: Expected I4, but got Obj
		//IL_01af: Expected I4, but got Obj
		//IL_01c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ca: Expected VT, but got Unknown
		//IL_01d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d8: Expected VT, but got Unknown
		//IL_01f6: Expected VT, but got Obj
		object obj = default;
		CharacterNameEventPopup characterNameEventPopup = (CharacterNameEventPopup)(obj - 144);
		characterNameEventPopup.timerLabel = null;
		characterNameEventPopup.secondTitle = null;
		characterNameEventPopup.eventDescriptionBoxNameActiveShadow = null;
		characterNameEventPopup.eventDescriptionTitleActive = null;
		characterNameEventPopup.eventDescriptionBoxActive = null;
		characterNameEventPopup.eventDescriptionBox = null;
		object obj2 = this + 172;
		if (_lpModel == null)
		{
			GameObject lpModel = NGUITools.AddChild(_categoryModelAnchor, _lpModelPrefab);
			_lpModel = lpModel;
			NGUITools.SetLayer(_lpModel, 31);
		}
		if ((UnityEngine.Object)obj2 != null)
		{
			CharacterNameEventPopup characterNameEventPopup2 = characterNameEventPopup;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.Screens.CharacterNameEventPopup)+D8]");
			characterNameEventPopup2.overlayClipAnchor = (GameObject)0;
			characterNameEventPopup.endArrowWidget = (GameObject)LP_POSITION_OFFSET;
			Vector3 defaultVal = (Vector3)(characterNameEventPopup + 80);
			Vector3 vector = characterNameEventPopup.VerifySettingOnline("event_popup_element_new_position_offset", defaultVal);
			CharacterNameEventPopup characterNameEventPopup3 = characterNameEventPopup;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.Screens.CharacterNameEventPopup)+E4]");
			characterNameEventPopup3.completeSignWidget = (GameObject)0;
			characterNameEventPopup.skipWithKeysButtonWidget = (GameObject)LP_ROTATION;
			Vector3 defaultVal2 = (Vector3)(characterNameEventPopup - -64);
			Vector3 vector2 = characterNameEventPopup.VerifySettingOnline("event_popup_element_new_rotation", defaultVal2);
			CharacterNameEventPopup characterNameEventPopup4 = characterNameEventPopup;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.Screens.CharacterNameEventPopup)+F0]");
			characterNameEventPopup4.characterScrollAnchor = (GameObject)0;
			((UIScreen)characterNameEventPopup).parentScreen__BackingField = (string)LP_SCALE;
			Vector3 defaultVal3 = (Vector3)(characterNameEventPopup + 48);
			Vector3 vector3 = characterNameEventPopup.VerifySettingOnline("event_popup_element_new_scale", defaultVal3);
			characterNameEventPopup.InComplete = (UnityEvent)(object)characterNameEventPopup.timerLabel;
			characterNameEventPopup._selectedFooterButton = (int)characterNameEventPopup.eventDescriptionBoxNameActiveShadow;
			((UnityEngine.Object)characterNameEventPopup).m_CachedPtr = (IntPtr)characterNameEventPopup.eventDescriptionBoxActive;
			((UIScreen)characterNameEventPopup)._footerInited = (byte)(int)characterNameEventPopup.secondTitle != 0;
			((UIScreen)characterNameEventPopup).addScreen = (byte)(int)characterNameEventPopup.eventDescriptionTitleActive != 0;
			characterNameEventPopup = (CharacterNameEventPopup)(object)characterNameEventPopup.eventDescriptionBox;
			Vector3 positionOffset = (Vector3)(characterNameEventPopup + 32);
			Vector3 newRotation = (Vector3)(characterNameEventPopup + 16);
			PositionModelOnSprite(_topSplatSprite, _lpModel, positionOffset, newRotation, (Vector3)characterNameEventPopup);
		}
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
		CharacterNameEventPopup characterNameEventPopup = (CharacterNameEventPopup)(obj - 48);
		characterNameEventPopup.InComplete = (UnityEvent)positionOffset.z;
		((UIScreen)characterNameEventPopup)._footerInited = (byte)(int)positionOffset.x != 0;
		characterNameEventPopup._selectedFooterButton = (int)newRotation.z;
		((UIScreen)characterNameEventPopup).addScreen = (byte)(int)newRotation.x != 0;
		((UnityEngine.Object)characterNameEventPopup).m_CachedPtr = (IntPtr)newScale.z;
		characterNameEventPopup = (CharacterNameEventPopup)newScale.x;
		Vector3 positionOffset2 = (Vector3)(characterNameEventPopup + 32);
		Vector3 newRotation2 = (Vector3)(characterNameEventPopup + 16);
		IEnumerator routine = characterNameEventPopup.DelayPositioning(tracker, objectToPosition, positionOffset2, newRotation2, (Vector3)characterNameEventPopup);
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

	private unsafe void EnableUIElementsForList()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_00f3: Expected Obj, but got I4
		//IL_00cb: Expected Obj, but got I4
		//IL_0173: Unknown result type (might be due to invalid IL or missing references)
		//IL_0178: Expected I4, but got Unknown
		//IL_00bd: Expected Obj, but got I4
		//IL_00e4: Expected I4, but got Obj
		object obj2 = default;
		object obj = obj2 - 16;
		obj = 0;
		if (_characterNameEventManager != null)
		{
			bool active = _characterNameEventManager.IsShowingFirstElement();
			startArrowWidget.SetActive(active);
			endArrowWidget.SetActive(_isLastFocused);
			CharacterNameEventManager characterNameEventManager = _characterNameEventManager;
			CharacterNameEventData eventProgressData = characterNameEventManager._eventProgressData;
			bool active2 = characterNameEventManager._eventProgressData != null && eventProgressData.wasLastCharacterCompleted__BackingField;
			completeSignWidget.SetActive(active2);
			UpdateSkipButtonState();
			CharacterNameEventManager characterNameEventManager2 = _characterNameEventManager;
			CharacterNameEventData eventProgressData2 = characterNameEventManager2._eventProgressData;
			if (characterNameEventManager2._eventProgressData != null)
			{
				object obj3 = eventProgressData2.skippedCharacters__BackingField + 3;
			}
			else
			{
				object obj3 = 2;
			}
			int num = obj + 12;
			string text = ((int*)num)->ToString();
			skipButtonKeyAmount.text = text;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @40A");
			_selectButton.ReloadButton(overrideCharacter: true, (Characters.CharacterType)obj);
		}
	}

	private unsafe void RefreshDescriptionBox()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected Ref, but got Unknown
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected Ref, but got Unknown
		//IL_00bc: Expected Obj, but got I
		//IL_00bc: Expected Obj, but got I
		//IL_0099: Expected Obj, but got I
		//IL_0099: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 16;
		_ = 0;
		_ = 0;
		if (_characterNameEventManager != null)
		{
			_ = string.Empty;
			_ = string.Empty;
			_characterNameEventManager.GetPopupDescription(out *(string*)(obj + 12), out *(string*)(obj + 8));
			if (_characterNameEventManager.SelectedCharacterMatchesFocusedCharacter())
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
				nint num = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
				SetActiveCharacterBox((string)num, (string)0);
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
				nint num2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
				SetInactiveCharacterBox((string)num2, (string)0);
			}
		}
	}

	private void SetInactiveCharacterBox(string descriptionLine1, string descriptionLine2)
	{
		eventDescriptionBox.SetActive(value: true);
		eventDescriptionBoxActive.SetActive(value: false);
		eventDescriptionBoxTitleInactive.text = descriptionLine1;
		eventDescriptionBoxName.text = descriptionLine2;
	}

	private unsafe void SetActiveCharacterBox(string descriptionLine1, string descriptionLine2)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
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
		//IL_0108: Expected Obj, but got VT
		//IL_0111: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Expected Obj, but got Unknown
		//IL_013a: Expected Obj, but got VT
		//IL_0166: Unknown result type (might be due to invalid IL or missing references)
		//IL_016b: Expected Obj, but got Unknown
		//IL_018f: Expected Obj, but got VT
		//IL_0198: Unknown result type (might be due to invalid IL or missing references)
		//IL_019d: Expected Obj, but got Unknown
		//IL_01c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cd: Expected VT, but got Unknown
		//IL_01e9: Expected Obj, but got VT
		//IL_01f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f7: Expected Obj, but got Unknown
		//IL_021b: Expected Obj, but got VT
		//IL_0247: Unknown result type (might be due to invalid IL or missing references)
		//IL_024c: Expected Obj, but got Unknown
		//IL_0270: Expected Obj, but got VT
		//IL_0279: Unknown result type (might be due to invalid IL or missing references)
		//IL_027e: Expected Obj, but got Unknown
		//IL_02a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ae: Expected VT, but got Unknown
		//IL_02cf: Expected Obj, but got VT
		//IL_02d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02dd: Expected Obj, but got Unknown
		//IL_0301: Expected Obj, but got VT
		//IL_032b: Expected F4, but got I
		//IL_0326: Expected native int or pointer, but got VT
		//IL_0335: Unknown result type (might be due to invalid IL or missing references)
		//IL_033a: Expected Obj, but got Unknown
		//IL_035e: Expected Obj, but got VT
		//IL_0367: Unknown result type (might be due to invalid IL or missing references)
		//IL_036c: Expected Obj, but got Unknown
		//IL_0396: Expected F4, but got I
		//IL_0391: Expected native int or pointer, but got VT
		//IL_042b: Expected Obj, but got I4
		//IL_041d: Expected Obj, but got I4
		//IL_0486: Unknown result type (might be due to invalid IL or missing references)
		//IL_048b: Expected Obj, but got Unknown
		//IL_0707: Unknown result type (might be due to invalid IL or missing references)
		//IL_070c: Expected I4, but got Unknown
		//IL_0587: Unknown result type (might be due to invalid IL or missing references)
		//IL_058c: Expected I4, but got Unknown
		//IL_05bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c2: Expected Obj, but got Unknown
		object obj = default;
		Color color = (Color)(obj - 128);
		eventDescriptionBox.SetActive(value: false);
		eventDescriptionBoxActive.SetActive(value: true);
		object obj2 = GlobalColors.CHARACTERWORDEVENT_POPUP_NAME_ACTIVE >> 16;
		object obj3 = obj2 & 0xFF;
		float num = (float)obj3 / 255f;
		object obj4 = GlobalColors.CHARACTERWORDEVENT_POPUP_NAME_ACTIVE >> 24;
		float num2 = (float)obj4 / 255f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+78]");
		_ = 0;
		object obj5 = GlobalColors.CHARACTERWORDEVENT_POPUP_NAME_ACTIVE & 0xFF;
		float num3 = (float)obj5 / 255f;
		object obj6 = GlobalColors.CHARACTERWORDEVENT_POPUP_NAME_ACTIVE >> 8;
		object obj7 = obj6 & 0xFF;
		float num4 = (float)obj7 / 255f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+70]");
		_ = 0;
		Color c = color + 48;
		string text = NGUIText.EncodeColor(c);
		object obj8 = GlobalColors.CHARACTERWORDEVENT_POPUP_NAME_INACTIVE >> 16;
		object obj9 = obj8 & 0xFF;
		float num5 = (float)obj9 / 255f;
		object obj10 = GlobalColors.CHARACTERWORDEVENT_POPUP_NAME_INACTIVE >> 24;
		float num6 = (float)obj10 / 255f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+68]");
		_ = 0;
		object obj11 = GlobalColors.CHARACTERWORDEVENT_POPUP_NAME_INACTIVE & 0xFF;
		float num7 = (float)obj11 / 255f;
		object obj12 = GlobalColors.CHARACTERWORDEVENT_POPUP_NAME_INACTIVE >> 8;
		object obj13 = obj12 & 0xFF;
		float num8 = (float)obj13 / 255f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+60]");
		_ = 0;
		Color c2 = color + 32;
		string text2 = NGUIText.EncodeColor(c2);
		object obj14 = GlobalColors.CHARACTERWORDEVENT_POPUP_NAME_SHADOW_ACTIVE >> 16;
		object obj15 = obj14 & 0xFF;
		float num9 = (float)obj15 / 255f;
		object obj16 = GlobalColors.CHARACTERWORDEVENT_POPUP_NAME_SHADOW_ACTIVE >> 24;
		float num10 = (float)obj16 / 255f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+58]");
		_ = 0;
		object obj17 = GlobalColors.CHARACTERWORDEVENT_POPUP_NAME_SHADOW_ACTIVE & 0xFF;
		float num11 = (float)obj17 / 255f;
		object obj18 = GlobalColors.CHARACTERWORDEVENT_POPUP_NAME_SHADOW_ACTIVE >> 8;
		object obj19 = obj18 & 0xFF;
		float num12 = (float)obj19 / 255f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+50]");
		_ = 0;
		Color c3 = color + 16;
		string text3 = NGUIText.EncodeColor(c3);
		object obj20 = GlobalColors.CHARACTERWORDEVENT_POPUP_NAME_SHADOW_INACTIVE >> 16;
		object obj21 = obj20 & 0xFF;
		float num13 = (float)obj21 / 255f;
		object obj22 = GlobalColors.CHARACTERWORDEVENT_POPUP_NAME_SHADOW_INACTIVE >> 24;
		float num14 = (float)obj22 / 255f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+48]");
		((Color*)(nint)color)->b = 0f;
		object obj23 = GlobalColors.CHARACTERWORDEVENT_POPUP_NAME_SHADOW_INACTIVE & 0xFF;
		float num15 = (float)obj23 / 255f;
		object obj24 = GlobalColors.CHARACTERWORDEVENT_POPUP_NAME_SHADOW_INACTIVE >> 8;
		object obj25 = obj24 & 0xFF;
		float num16 = (float)obj25 / 255f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+40]");
		((Color*)(nint)color)->r = 0f;
		string text4 = NGUIText.EncodeColor(color);
		SSEventsManagerController instance = SSEventsManagerController.instance;
		CharacterNameEventManager typeOfActiveEventManager = instance.GetTypeOfActiveEventManager<CharacterNameEventManager>();
		object obj27 = default;
		if (typeOfActiveEventManager != null)
		{
			CharacterNameEventData eventProgressData = typeOfActiveEventManager._eventProgressData;
			object obj26 = ((typeOfActiveEventManager._eventProgressData == null) ? ((object)0) : ((object)(eventProgressData.collectedLetterIndex__BackingField + 1)));
			obj27 = obj26;
		}
		char[] array = descriptionLine2.ToCharArray();
		CharacterNameEventPopup characterNameEventPopup = null;
		string text5 = string.Empty;
		string text6 = string.Empty;
		while (array.Length > (nint)characterNameEventPopup)
		{
			object obj28 = (object)characterNameEventPopup << 1;
			object obj29 = (object)array + obj28;
			CharacterNameEventPopup characterNameEventPopup2 = characterNameEventPopup;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v291 @ S1_v107+10]");
			if (characterNameEventPopup2.IsFilteredCharacter('\0'))
			{
				object obj30 = obj27 + 1;
				obj27 = obj30;
			}
			else if (System.Runtime.CompilerServices.Unsafe.As<CharacterNameEventPopup, UIntPtr>(ref characterNameEventPopup) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj27))
			{
				string text7 = text6 + "[" + text + "]";
				string text8 = text5 + "[" + text3 + "]";
				text5 = text8;
				text6 = text7;
			}
			else
			{
				string text9 = text6 + "[" + text2 + "]";
				string text10 = text5 + "[" + text4 + "]";
				text5 = text10;
				text6 = text9;
			}
			object obj31 = (object)characterNameEventPopup << 1;
			object obj32 = (object)array + obj31;
			char c4 = (char)(obj32 + 16);
			string text11 = ((char*)(ushort)c4)->ToString();
			string text12 = text6 + text11 + " ";
			object obj33 = (object)characterNameEventPopup << 1;
			object obj34 = (object)array + obj33;
			char c5 = (char)(obj34 + 16);
			string text13 = ((char*)(ushort)c5)->ToString();
			string text14 = text5 + text13 + " ";
			CharacterNameEventPopup characterNameEventPopup3 = (CharacterNameEventPopup)(characterNameEventPopup + 1);
			characterNameEventPopup = characterNameEventPopup3;
			text5 = text14;
			text6 = text12;
		}
		if (array.Length != 0)
		{
			int length = text6._stringLength - 1;
			string text15 = text6.Substring(0, length);
			eventDescriptionBoxNameActive.text = text15;
			int length2 = text5._stringLength - 1;
			string text16 = text5.Substring(0, length2);
			eventDescriptionBoxNameActiveShadow.text = text16;
		}
		eventDescriptionTitleActive.text = descriptionLine1;
	}

	private void Update()
	{
		SetTheClock();
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
		timerLabel.text = text;
	}

	public void OnSkipClicked()
	{
		if (_characterNameEventManager != null)
		{
			if (_characterNameEventManager.CanAffordToSkip())
			{
				_characterNameEventManager.UseKeysToSkip();
				ScrollToNextCharacter();
				return;
			}
			PurchaseHandler instance = PurchaseHandler.Instance;
			CharacterNameEventManager characterNameEventManager = _characterNameEventManager;
			CharacterNameEventData eventProgressData = characterNameEventManager._eventProgressData;
			int amountToSaveMe = ((characterNameEventManager._eventProgressData == null) ? 2 : (eventProgressData.skippedCharacters__BackingField + 3));
			instance.PurchaseKeysIfNeeded(amountToSaveMe);
		}
	}

	public unsafe void OnSkipWithAdClicked()
	{
		if (_characterNameEventManager != null)
		{
			VideoAdsManager instance = VideoAdsManager.instance;
			Action action = default;
			action._002Ector(this, (nint)__ldftn(CharacterNameEventPopup.OnSkipWithAdSuccessful));
			bool flag = instance.PlayVideoIfAvailable(action);
			UIScreenController instance2 = UIScreenController.Instance;
			if (flag)
			{
				instance2.ShowVideoAdsOverlay();
				return;
			}
			string message = Strings.Get(StringID.SLIDEIN_VIDEO_PLAY_ERROR);
			instance2.QueueErrorMessageSlidein(message);
			UpdateSkipButtonState(forceDisableAds: true);
		}
	}

	private void OnSkipWithAdSuccessful()
	{
		UIScreenController instance = UIScreenController.Instance;
		instance.HideVideoAdsOverlay();
		_characterNameEventManager.LogWatchedAdToSkip();
		ScrollToNextCharacter();
	}

	private unsafe void ScrollToNextCharacter()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Expected VT, but got Unknown
		//IL_00a3: Expected Ref, but got VT
		object obj2 = default;
		object obj = obj2 - 16;
		_ = 0;
		if (_characterNameEventManager != null && !_isLastFocused)
		{
			_isFirstFocused = false;
			_characterNameEventManager.SkipCurrentCharacter();
			Characters.CharacterType? nextCharacterToDisplay = _characterNameEventManager.GetNextCharacterToDisplay();
			int currentlyFocusedIndex = _currentlyFocusedIndex + 1;
			_currentlyFocusedIndex = currentlyFocusedIndex;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
			if ((nint)0 != 0)
			{
				Characters.CharacterType? characterType = (Characters.CharacterType?)(object)(obj + 8);
				Characters.CharacterType value = ((Characters.CharacterType?*)characterType)->Value;
				InsertCharacterIntoModelsList(value, _currentlyFocusedIndex);
			}
			else
			{
				_isLastFocused = true;
			}
			ScrollListTo(_currentlyFocusedIndex);
			RefreshDescriptionBox();
		}
	}

	private void ScrollListTo(int currentCharacterIndex)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected Obj, but got Unknown
		//IL_005b: Expected Obj, but got I4
		//IL_009a: Expected Obj, but got I
		//IL_00fa: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 16;
		_ = 0;
		EnableUIElementsForList();
		List<KeyValuePair<Characters.CharacterType, CharacterScreenController>> characterControllers = _characterControllers;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S1_v6 (System.Collections.Generic.List`1<System.Collections.Generic.KeyValuePair`2<SYBO.Subway.Info.Characters+CharacterType, CharacterScreenController>>)+C]");
		if ((nint)currentCharacterIndex <= (nint)0)
		{
			IEnumerator routine = AnimateScrollBar(HorizontalScrollDirections.left, 77f, 2f);
			Coroutine coroutine = StartCoroutine(routine);
			object obj3 = obj + 8;
			object obj4 = currentCharacterIndex - 1;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @40A");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
			IEnumerator routine2 = AnimateCharacter((CharacterScreenController)0, 13f, 9.3f, -9f, 0f, 0f, 1f, 2f);
			Coroutine coroutine2 = StartCoroutine(routine2);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @40A");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
			IEnumerator routine3 = AnimateCharacter((CharacterScreenController)0, 9.3f, 13f, 0f, -9f, 1f, 0f, 2f);
			Coroutine coroutine3 = StartCoroutine(routine3);
		}
	}

	private IEnumerator AnimateScrollBar(HorizontalScrollDirections direction, float amount, float speedFactor)
	{
		_ = 0;
		IEnumerator result = default;
		return result;
	}

	private IEnumerator AnimateCharacter(CharacterScreenController characterController, float scaleStartValue, float scaleEndValue, float positionStartValue, float positionEndValue, float freezeStart, float freezeEnd, float speedFactor)
	{
		_ = 0;
		IEnumerator result = default;
		return result;
	}

	private bool IsFilteredCharacter(char newChar)
	{
		//IL_0076: Expected Obj, but got I4
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected Obj, but got Unknown
		char[] fILTERED_CHARACTERS = CharacterNameEventManager.FILTERED_CHARACTERS;
		object obj = 0;
		bool flag;
		while (true)
		{
			flag = (nint)obj < fILTERED_CHARACTERS.Length;
			if (!flag)
			{
				break;
			}
			object obj2 = obj << 1;
			object obj3 = (object)fILTERED_CHARACTERS + obj2;
			char c = newChar;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S1_v7+10]");
			if ((nint)(int)c == 0)
			{
				break;
			}
			object obj4 = obj + 1;
			obj = obj4;
		}
		return flag;
	}

	public void HidePopupIfNeeded()
	{
		SSEventsManagerController instance = SSEventsManagerController.instance;
		IEventManager activeEventManager = instance.GetActiveEventManager();
		if (_characterNameEventManager != null && activeEventManager != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6A1");
			CharacterNameEventManager characterNameEventManager = _characterNameEventManager;
			object obj = default;
			if ((long)obj == characterNameEventManager._eventID)
			{
				return;
			}
		}
		UIScreenController instance2 = UIScreenController.Instance;
		instance2.CloseActivePopups(screenName);
	}

	public CharacterNameEventPopup()
	{
		//IL_002e: Expected VT, but got I8
		//IL_004d: Expected VT, but got I8
		List<KeyValuePair<Characters.CharacterType, CharacterScreenController>> list = default;
		list._002Ector();
		_characterControllers = list;
		_ = 1083808154;
		LP_SCALE = (Vector3)4654920577651939738L;
		_ = 4722024210427412480L;
		_ = 0;
		LP_POSITION_OFFSET = (Vector3)4647714815446351872L;
		base._002Ector();
	}
}
