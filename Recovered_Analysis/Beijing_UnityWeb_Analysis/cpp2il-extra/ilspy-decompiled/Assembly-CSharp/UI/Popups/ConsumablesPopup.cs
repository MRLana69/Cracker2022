using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2ILInjected;
using Data.Save;
using Info;
using Info.VideoRewardCooldowns;
using Kiloo.Common.Ads;
using Kiloo.Common.JsonUtil;
using Kiloo.Common.LocalizationManager;
using Kiloo.Common.Utility;
using SYBO.Components.Utilities;
using SYBO.Subway;
using SYBO.Subway.Promotion;
using UI.FreeStuff;
using UI.Generic;
using UI.Generic.Layout;
using UI.Pages;
using UI.Popups.BoardBundlePopupInternal;
using UI.Popups.CloudSaveConfirmationPopupInternal;
using UI.Popups.ConsumablesPopupInternal;
using UI.Screens;
using UnityEngine;
using UnityEngine.Networking;

namespace UI.Popups;

public class ConsumablesPopup : UIScreen
{
	public enum VideoButtonTrackingState
	{
		NotSet,
		NoFill,
		Fill,
		Cooldown
	}

	private sealed class _003CPerformAnimation_003Ed__70(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public float delay;

		public ConsumablesPopup _003C_003E4__this;

		private float _003CstartTime_003E5__2;

		unsafe object IEnumerator<object>.Current
		{
			get
			{
				//IL_08ac: Unknown result type (might be due to invalid IL or missing references)
				//IL_08b1: Expected Obj, but got Unknown
				//IL_08ba: Unknown result type (might be due to invalid IL or missing references)
				//IL_08bf: Expected VT, but got Unknown
				//IL_08c8: Unknown result type (might be due to invalid IL or missing references)
				//IL_08cd: Expected Obj, but got Unknown
				//IL_08d6: Unknown result type (might be due to invalid IL or missing references)
				//IL_08db: Expected Obj, but got Unknown
				//IL_08e4: Unknown result type (might be due to invalid IL or missing references)
				//IL_08e9: Expected Obj, but got Unknown
				//IL_08f2: Unknown result type (might be due to invalid IL or missing references)
				//IL_08f7: Expected Obj, but got Unknown
				//IL_0900: Unknown result type (might be due to invalid IL or missing references)
				//IL_0905: Expected Obj, but got Unknown
				//IL_090e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0913: Expected Obj, but got Unknown
				//IL_091c: Unknown result type (might be due to invalid IL or missing references)
				//IL_0921: Expected Obj, but got Unknown
				//IL_092a: Unknown result type (might be due to invalid IL or missing references)
				//IL_092f: Expected Obj, but got Unknown
				//IL_0938: Unknown result type (might be due to invalid IL or missing references)
				//IL_093d: Expected Obj, but got Unknown
				//IL_0946: Unknown result type (might be due to invalid IL or missing references)
				//IL_094b: Expected Obj, but got Unknown
				//IL_0954: Unknown result type (might be due to invalid IL or missing references)
				//IL_0959: Expected Obj, but got Unknown
				//IL_0962: Unknown result type (might be due to invalid IL or missing references)
				//IL_0967: Expected Obj, but got Unknown
				//IL_0970: Unknown result type (might be due to invalid IL or missing references)
				//IL_0975: Expected Obj, but got Unknown
				//IL_097e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0983: Expected Obj, but got Unknown
				//IL_098c: Unknown result type (might be due to invalid IL or missing references)
				//IL_0991: Expected Obj, but got Unknown
				//IL_00de: Unknown result type (might be due to invalid IL or missing references)
				//IL_00e3: Expected Obj, but got Unknown
				//IL_00ec: Expected Obj, but got I4
				//IL_0100: Expected Obj, but got I4
				//IL_0242: Expected I, but got Obj
				//IL_0258: Expected Obj, but got I
				//IL_0180: Unknown result type (might be due to invalid IL or missing references)
				//IL_0185: Expected Obj, but got Unknown
				//IL_0192: Expected F4, but got Obj
				//IL_018d: Expected native int or pointer, but got VT
				//IL_01a7: Expected F4, but got I
				//IL_01a2: Expected native int or pointer, but got VT
				//IL_01b4: Expected Obj, but got F4
				//IL_01c6: Expected I, but got F4
				//IL_02cb: Unknown result type (might be due to invalid IL or missing references)
				//IL_02d0: Expected Obj, but got Unknown
				//IL_02ee: Unknown result type (might be due to invalid IL or missing references)
				//IL_02f3: Expected Obj, but got Unknown
				//IL_0316: Expected I, but got Obj
				//IL_032c: Expected Obj, but got I
				//IL_0283: Expected I, but got Obj
				//IL_0a2a: Expected VT, but got Obj
				//IL_03a3: Expected F4, but got Obj
				//IL_039e: Expected native int or pointer, but got VT
				//IL_03b8: Expected F4, but got I
				//IL_03b3: Expected native int or pointer, but got VT
				//IL_03e6: Expected VT, but got Obj
				//IL_0357: Expected I, but got Obj
				//IL_0439: Expected I, but got Obj
				//IL_044f: Expected Obj, but got I
				//IL_046c: Expected I, but got Obj
				//IL_0a8d: Expected Obj, but got I
				//IL_0ab0: Expected I, but got Obj
				//IL_0ac6: Expected Obj, but got I
				//IL_0b0a: Expected VT, but got Obj
				//IL_04f0: Expected F4, but got Obj
				//IL_04eb: Expected native int or pointer, but got VT
				//IL_0505: Expected F4, but got I
				//IL_0500: Expected native int or pointer, but got VT
				//IL_0533: Expected VT, but got Obj
				//IL_0561: Expected Obj, but got I4
				//IL_0488: Expected I, but got Obj
				//IL_04b8: Expected I, but got Obj
				//IL_0586: Expected I, but got Obj
				//IL_059c: Expected Obj, but got I
				//IL_05bf: Expected I, but got Obj
				//IL_05d5: Expected Obj, but got I
				//IL_0619: Expected VT, but got Obj
				//IL_04de: Expected I, but got Obj
				//IL_0678: Expected F4, but got Obj
				//IL_0673: Expected native int or pointer, but got VT
				//IL_068d: Expected F4, but got I
				//IL_0688: Expected native int or pointer, but got VT
				//IL_06bb: Expected VT, but got Obj
				//IL_06e9: Expected Obj, but got I4
				//IL_070e: Expected I, but got Obj
				//IL_0724: Expected Obj, but got I
				//IL_0747: Expected I, but got Obj
				//IL_075d: Expected Obj, but got I
				//IL_07a1: Expected VT, but got Obj
				//IL_0800: Expected F4, but got Obj
				//IL_07fb: Expected native int or pointer, but got VT
				//IL_0815: Expected F4, but got I
				//IL_0810: Expected native int or pointer, but got VT
				//IL_0843: Expected VT, but got Obj
				//IL_0871: Expected Obj, but got I4
				//IL_087c: Unknown result type (might be due to invalid IL or missing references)
				//IL_0881: Expected Obj, but got Unknown
				//IL_088a: Expected Obj, but got I4
				//IL_089e: Expected Obj, but got I4
				object obj = default;
				Transform transform = (Transform)(obj + 204);
				Vector3 vector = (Vector3)(obj + 192);
				object obj2 = obj + 180;
				object obj3 = obj + 168;
				object obj4 = obj + 156;
				object obj5 = obj + 144;
				object obj6 = obj + 132;
				object obj7 = obj + 120;
				object obj8 = obj + 108;
				object obj9 = obj + 96;
				object obj10 = obj + 84;
				object obj11 = obj + 72;
				object obj12 = obj + 60;
				object obj13 = obj + 48;
				object obj14 = obj + 36;
				object obj15 = obj + 24;
				object obj16 = obj + 12;
				ConsumablesPopup consumablesPopup = _003C_003E4__this;
				if (_003C_003E1__state != 0)
				{
					if (_003C_003E1__state != 1)
					{
						if (_003C_003E1__state == 2)
						{
							_003C_003E1__state = -1;
							goto IL_0105;
						}
						return null;
					}
					_003C_003E1__state = -1;
				}
				else
				{
					_003C_003E1__state = -1;
					float maxDelay = NetworkServer.maxDelay;
					float num = maxDelay + delay;
					_003CstartTime_003E5__2 = num;
				}
				float maxDelay2 = NetworkServer.maxDelay;
				if (maxDelay2 < _003CstartTime_003E5__2)
				{
					object obj17 = this + 12;
					obj17 = 0;
					_003C_003E1__state = 1;
					return 1;
				}
				goto IL_0105;
				IL_0105:
				float maxDelay3 = NetworkServer.maxDelay;
				float num2 = _003CstartTime_003E5__2 + consumablesPopup._animationTime;
				if (!(maxDelay3 < num2))
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @76BC");
					GameObject gameObject = consumablesPopup._glowSprite.gameObject;
					object obj18 = consumablesPopup + 148;
					((Vector3*)(nint)vector)->x = (float)obj18;
					Vector3 vector2 = vector;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v203 @ S2_v159+8]");
					((Vector3*)(nint)vector2)->z = 0f;
					transform = (Transform)vector.x;
					((UnityEngine.Object)transform).m_CachedPtr = (IntPtr)vector.z;
					((Transform)(object)gameObject).parent = transform;
					consumablesPopup.Hide3DModels();
					return null;
				}
				float maxDelay4 = NetworkServer.maxDelay;
				float num3 = maxDelay4 - _003CstartTime_003E5__2;
				float defaultValue = num3 / consumablesPopup._animationTime;
				float t = PlayerPrefs.GetFloat((string)(object)consumablesPopup._animCurve, defaultValue);
				nint num4 = (nint)typeof(Mathf);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v217 @ S0_v56 (Il2CppClass<UnityEngine.Mathf>)+BA]");
				object obj19 = (nint)0 & (nint)0x200;
				if (obj19 != null)
				{
					nint num5 = (nint)typeof(Mathf);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v224 @ S0_v77 (Il2CppClass<UnityEngine.Mathf>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				float num6 = Mathf.LerpUnclamped(consumablesPopup._originalGlowAlpha, 1f, t);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @76BC");
				GameObject gameObject2 = consumablesPopup._glowSprite.gameObject;
				object obj20 = consumablesPopup + 148;
				obj2 = obj20;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v245 @ S2_v13+8]");
				_ = 0;
				object obj21 = consumablesPopup + 148;
				obj3 = obj21;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v254 @ S2_v18+8]");
				_ = 0;
				nint num7 = (nint)typeof(Vector3);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v264 @ S1_v44 (Il2CppClass<UnityEngine.Vector3>)+BA]");
				object obj22 = (nint)0 & (nint)0x200;
				if (obj22 != null)
				{
					nint num8 = (nint)typeof(Vector3);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v270 @ S1_v139 (Il2CppClass<UnityEngine.Vector3>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				transform = (Transform)obj3;
				Transform transform2 = transform;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v15+8]");
				((UnityEngine.Object)transform2).m_CachedPtr = (IntPtr)0;
				Vector3 vector3 = (Vector3)transform / consumablesPopup._glowAnimScaling;
				float maxDelay5 = NetworkServer.maxDelay;
				float num9 = maxDelay5 - _003CstartTime_003E5__2;
				float defaultValue2 = num9 / consumablesPopup._animationTime;
				float t2 = PlayerPrefs.GetFloat((string)(object)consumablesPopup._animCurve, defaultValue2);
				((Vector3*)(nint)vector)->x = (float)obj2;
				Vector3 vector4 = vector;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13+8]");
				((Vector3*)(nint)vector4)->z = 0f;
				transform = (Transform)obj4;
				Transform transform3 = transform;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v17+8]");
				((UnityEngine.Object)transform3).m_CachedPtr = (IntPtr)0;
				Vector3 vector5 = Vector3.LerpUnclamped(vector, (Vector3)transform, t2);
				transform = (Transform)obj5;
				Transform transform4 = transform;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v19+8]");
				((UnityEngine.Object)transform4).m_CachedPtr = (IntPtr)0;
				((Transform)(object)gameObject2).parent = transform;
				int layer = consumablesPopup._hoverboardUIModel.layer;
				nint num10 = (nint)typeof(ConsumablesPopup);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v332 @ S1_v64 (Il2CppClass<UI.Popups.ConsumablesPopup>)+BA]");
				object obj23 = (nint)0 & (nint)0x200;
				bool flag = obj23 == null;
				nint num11 = (nint)typeof(ConsumablesPopup);
				if (!flag)
				{
					nint num12 = (nint)typeof(ConsumablesPopup);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v338 @ S1_v133 (Il2CppClass<UI.Popups.ConsumablesPopup>)+74]");
					bool flag2 = (nint)0 == 0;
					bool flag3 = !flag2;
					num11 = (nint)typeof(ConsumablesPopup);
					if (!flag3)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						num11 = (nint)typeof(ConsumablesPopup);
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v342 @ L1_v7 (Il2CppClass<UI.Popups.ConsumablesPopup>)+5C]");
				object obj24 = (nint)0 + (nint)24;
				obj6 = obj24;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v350 @ S2_v49+8]");
				_ = 0;
				nint num13 = (nint)typeof(ConsumablesPopup);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v358 @ S2_v54 (Il2CppClass<UI.Popups.ConsumablesPopup>)+5C]");
				object obj25 = (nint)0 + (nint)24;
				obj7 = obj25;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v361 @ S2_v56+8]");
				_ = 0;
				transform = (Transform)obj7;
				Transform transform5 = transform;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S0_v23+8]");
				((UnityEngine.Object)transform5).m_CachedPtr = (IntPtr)0;
				Vector3 vector6 = (Vector3)transform / consumablesPopup._modelAnimScaling;
				float maxDelay6 = NetworkServer.maxDelay;
				float num14 = maxDelay6 - _003CstartTime_003E5__2;
				float defaultValue3 = num14 / consumablesPopup._animationTime;
				float t3 = PlayerPrefs.GetFloat((string)(object)consumablesPopup._animCurve, defaultValue3);
				((Vector3*)(nint)vector)->x = (float)obj6;
				Vector3 vector7 = vector;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S0_v21+8]");
				((Vector3*)(nint)vector7)->z = 0f;
				transform = (Transform)obj8;
				Transform transform6 = transform;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S0_v25+8]");
				((UnityEngine.Object)transform6).m_CachedPtr = (IntPtr)0;
				Vector3 vector8 = Vector3.LerpUnclamped(vector, (Vector3)transform, t3);
				transform = (Transform)obj9;
				Transform transform7 = transform;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ S0_v27+8]");
				((UnityEngine.Object)transform7).m_CachedPtr = (IntPtr)0;
				((Transform)layer).parent = transform;
				int layer2 = consumablesPopup._headstartUIModel.layer;
				nint num15 = (nint)typeof(ConsumablesPopup);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v428 @ S2_v84 (Il2CppClass<UI.Popups.ConsumablesPopup>)+5C]");
				object obj26 = (nint)0 + (nint)60;
				obj10 = obj26;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v431 @ S2_v86+8]");
				_ = 0;
				nint num16 = (nint)typeof(ConsumablesPopup);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v439 @ S2_v91 (Il2CppClass<UI.Popups.ConsumablesPopup>)+5C]");
				object obj27 = (nint)0 + (nint)60;
				obj11 = obj27;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v442 @ S2_v93+8]");
				_ = 0;
				transform = (Transform)obj11;
				Transform transform8 = transform;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ S0_v31+8]");
				((UnityEngine.Object)transform8).m_CachedPtr = (IntPtr)0;
				Vector3 vector9 = (Vector3)transform / consumablesPopup._modelAnimScaling;
				float maxDelay7 = NetworkServer.maxDelay;
				float num17 = maxDelay7 - _003CstartTime_003E5__2;
				float defaultValue4 = num17 / consumablesPopup._animationTime;
				float t4 = PlayerPrefs.GetFloat((string)(object)consumablesPopup._animCurve, defaultValue4);
				((Vector3*)(nint)vector)->x = (float)obj10;
				Vector3 vector10 = vector;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ S0_v29+8]");
				((Vector3*)(nint)vector10)->z = 0f;
				transform = (Transform)obj12;
				Transform transform9 = transform;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S0_v33+8]");
				((UnityEngine.Object)transform9).m_CachedPtr = (IntPtr)0;
				Vector3 vector11 = Vector3.LerpUnclamped(vector, (Vector3)transform, t4);
				transform = (Transform)obj13;
				Transform transform10 = transform;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S0_v35+8]");
				((UnityEngine.Object)transform10).m_CachedPtr = (IntPtr)0;
				((Transform)layer2).parent = transform;
				int layer3 = consumablesPopup._scoreboosterUIModel.layer;
				nint num18 = (nint)typeof(ConsumablesPopup);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v507 @ S2_v121 (Il2CppClass<UI.Popups.ConsumablesPopup>)+5C]");
				object obj28 = (nint)0 + (nint)96;
				obj14 = obj28;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v510 @ S2_v123+8]");
				_ = 0;
				nint num19 = (nint)typeof(ConsumablesPopup);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v518 @ S2_v128 (Il2CppClass<UI.Popups.ConsumablesPopup>)+5C]");
				object obj29 = (nint)0 + (nint)96;
				obj15 = obj29;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v521 @ S2_v130+8]");
				_ = 0;
				transform = (Transform)obj15;
				Transform transform11 = transform;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ S0_v39+8]");
				((UnityEngine.Object)transform11).m_CachedPtr = (IntPtr)0;
				Vector3 vector12 = (Vector3)transform / consumablesPopup._modelAnimScaling;
				float maxDelay8 = NetworkServer.maxDelay;
				float num20 = maxDelay8 - _003CstartTime_003E5__2;
				float defaultValue5 = num20 / consumablesPopup._animationTime;
				float t5 = PlayerPrefs.GetFloat((string)(object)consumablesPopup._animCurve, defaultValue5);
				((Vector3*)(nint)vector)->x = (float)obj14;
				Vector3 vector13 = vector;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ S0_v37+8]");
				((Vector3*)(nint)vector13)->z = 0f;
				transform = (Transform)obj16;
				Transform transform12 = transform;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ S0_v41+8]");
				((UnityEngine.Object)transform12).m_CachedPtr = (IntPtr)0;
				Vector3 vector14 = Vector3.LerpUnclamped(vector, (Vector3)transform, t5);
				transform = (Transform)obj;
				Transform transform13 = transform;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
				((UnityEngine.Object)transform13).m_CachedPtr = (IntPtr)0;
				((Transform)layer3).parent = transform;
				object obj30 = this + 12;
				obj30 = 0;
				_003C_003E1__state = 2;
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

	private UIWidget _outline;

	private UILabel _consumableTitle;

	private UILabel _consumableCount;

	private UILabel _consumablePrice;

	private UILabel _consumableDescription;

	private UISprite _glowSprite;

	private GameObject _hoverboardPrefab;

	private GameObject _headstartPrefab;

	private GameObject _scoreboosterPrefab;

	private AnimationCurve _animCurve;

	private float _animationTime;

	private float _modelAnimScaling;

	private float _glowAnimScaling;

	private HorizontalLayout _buttonLayout;

	private GameObject _watchVideoButton;

	private UIButtonOverlayOff _videoButtonOverlay;

	private GameObject _videoButtonNormalState;

	private UILabel _videoButtonFreeLabel;

	private UIWidget _videoTvIconContainer;

	private GameObject _videoTvIconPrefab;

	private GameObject _hoverboardUIModel;

	private GameObject _headstartUIModel;

	private GameObject _scoreboosterUIModel;

	private GameObject _coinboxFundsEnabled;

	private GameObject _coinboxFundsDisabled;

	private static readonly Vector3 HOVERBOARD_POSITION_OFFSET;

	private static readonly Vector3 HOVERBOARD_ROTATION;

	private static readonly Vector3 HOVERBOARD_SCALE;

	private static readonly Vector3 HEADSTART_POSITION_OFFSET;

	private static readonly Vector3 HEADSTART_ROTATION;

	private static readonly Vector3 HEADSTART_SCALE;

	private static readonly Vector3 SCOREBOOSTER_POSITION_OFFSET;

	private static readonly Vector3 SCOREBOOSTER_ROTATION;

	private static readonly Vector3 SCOREBOOSTER_SCALE;

	private SellConsumablesHelper _consumablesHelper;

	private float _originalGlowAlpha;

	private Vector3 _originalGlowScale;

	private VideoButtonTrackingState _videoButtonTrackingState;

	private bool isVideoPlaying__BackingField;

	public bool isVideoPlaying
	{
		get
		{
			//IL_0023: Expected Obj, but got I4
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			_ = 0;
			bool flag = default;
			object obj = (flag ? 1 : 0) + 16;
			obj = this;
			return flag;
		}
		private set
		{
			//IL_0016: Expected Obj, but got I4
			LocaleData instance = LocaleData.instance;
			((LegalTextData)(object)instance).SetLanguage((Locale)value);
			((ConsentPopup)this).CheckboxClicked();
		}
	}

	private bool isInRun => isVideoPlaying__BackingField;

	public override void Init()
	{
		((UpgradeScreen)this).Start();
	}

	public override void LoseFocus()
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected Obj, but got Unknown
		//IL_004d: Expected VT, but got Obj
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Expected Obj, but got Unknown
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Expected Obj, but got Unknown
		ShowIfInactive();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		SellConsumablesHelper sellConsumablesHelper = default;
		sellConsumablesHelper.DidShowConsumablesPopup();
		object obj = this + 140;
		obj = sellConsumablesHelper;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @76C9");
		float originalGlowAlpha = default;
		_originalGlowAlpha = originalGlowAlpha;
		GameObject gameObject = _glowSprite.gameObject;
		Transform transform = default;
		transform.localScale = (Vector3)gameObject;
		object obj2 = transform + 12;
		obj2 = transform;
		_ = ((UnityEngine.Object)transform).m_CachedPtr;
		object obj3 = this + 148;
		obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S0_v17+8]");
		_ = 0;
		Reset3DModelScales();
		HideCoinboxes();
	}

	public override void GainFocus()
	{
		SetupCoinboxes();
	}

	public override void Show()
	{
		//IL_0060: Expected Obj, but got I4
		//IL_0075: Expected Obj, but got I4
		if (ShouldShowVideoButton())
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7B23");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v7 @ S1_v6+8]");
			((LanguageSelectionPopup)this).SetBackButtonEnabledState(false);
		}
		else
		{
			bool isInstanced = UIScreenController.IsInstanced;
			((UIModelController)isInstanced).DeactivateModelScreen(UIModelController.ModelScreen.TutorialPopup);
			_hoverboardUIModel.tag = (string)1;
		}
	}

	public override void Hide()
	{
		//IL_0022: Expected I, but got Obj
		//IL_0038: Expected Obj, but got I
		//IL_00df: Expected I4, but got Obj
		//IL_0063: Expected I, but got Obj
		base.Hide();
		bool playedVideo = default;
		if (ShouldShowVideoButton())
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7B23");
		}
		else
		{
			nint num = (nint)typeof(SellableConsumable);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S1_v7 (Il2CppClass<Info.SellableConsumable>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(SellableConsumable);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S1_v14 (Il2CppClass<Info.SellableConsumable>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			playedVideo = (byte)(int)SellableConsumable.hoverboard != 0;
		}
		TrackConsumablePurchase(playedVideo);
	}

	private void Setup(SellableConsumable consumable)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected I4, but got Unknown
		bool flag = (byte)(consumable & 1) != 0;
		isVideoPlaying__BackingField = flag;
	}

	private void UpdateVideoButtonState()
	{
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Expected Obj, but got Unknown
		//IL_00e1: Expected I, but got Obj
		//IL_00f7: Expected Obj, but got I
		//IL_001e: Expected I, but got Obj
		//IL_0034: Expected Obj, but got I
		//IL_0273: Unknown result type (might be due to invalid IL or missing references)
		//IL_0278: Expected Obj, but got Unknown
		//IL_028a: Expected Obj, but got I4
		//IL_0233: Expected Obj, but got I
		//IL_023c: Expected VT, but got Obj
		//IL_0182: Unknown result type (might be due to invalid IL or missing references)
		//IL_0187: Expected Obj, but got Unknown
		//IL_0122: Expected I, but got Obj
		//IL_005f: Expected I, but got Obj
		//IL_01c0: Expected Obj, but got I4
		base.LoseFocus();
		if (ShouldShowVideoButton())
		{
			_consumablesHelper.LogPurchases();
			nint num = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S0_v52 (Il2CppClass<UIScreenController>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(UIScreenController);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S0_v62 (Il2CppClass<UIScreenController>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool flag = UIScreenController.ShouldShowOnlineScreen();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S0_v57 (System.Boolean)+20]");
			((Component)0).tag = null;
			_00210 val = (_00210)SingletonMonoBehaviour<>.Instantiate();
			_ = 1;
		}
		SetupCoinboxes();
		this._002Ector();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num3 = 0;
		_ = 0;
		Action<string> action = default;
		object obj2 = action + 16;
		obj2 = this;
		AdSystemManager.onDismissedVideo += action;
		nint num4 = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ S0_v22 (Il2CppClass<UIScreenController>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num5 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ S0_v45 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag2 = UIScreenController.ShouldShowOnlineScreen();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num6 = 0;
		string text = default;
		text.m_stringLength = (int)num6;
		_ = 0;
		object obj4 = text + 16;
		obj4 = this;
		((UIScreenController)flag2).ShowVideoAdsOverlay(text);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num7 = 0;
		_ = 0;
		Action<string> action2 = default;
		object obj5 = action2 + 16;
		obj5 = this;
		UIScreenController.OnPopupShown += action2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num8 = 0;
		_ = 0;
		int num9 = default;
		object obj6 = num9 + 16;
		obj6 = this;
		InventorySave.SetKeys(num9);
	}

	private unsafe void OnPowerupAmountChanged(UpgradeType upgradeType, int amount)
	{
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_0129: Expected Obj, but got I4
		//IL_0137: Expected I, but got Obj
		//IL_014d: Expected Obj, but got I
		//IL_01a2: Expected I4, but got Obj
		//IL_01a2: Expected Obj, but got I4
		//IL_0054: Expected I, but got Obj
		//IL_00a1: Expected I, but got Obj
		AnimationClip[] characterAnimations = ((CharacterPromotion)(object)_buttonLayout).CharacterAnimations;
		if ((nint)characterAnimations != (nint)upgradeType)
		{
			return;
		}
		nint num = (nint)typeof(PromotionManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v11 (Il2CppClass<UI.Screens.PromotionManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(PromotionManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S0_v28 (Il2CppClass<UI.Screens.PromotionManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = UIScreen.IsScreenHeightOutOfProportion();
		((PromotionManager)flag).StartTimer();
		nint num3 = (nint)typeof(CharacterScreenManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ S0_v18 (Il2CppClass<UI.Screens.CharacterScreenManager>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(CharacterScreenManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ S0_v24 (Il2CppClass<UI.Screens.CharacterScreenManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool running = FirstPurchaseBonusManager.running;
		AnimationClip[] characterAnimations2 = ((CharacterPromotion)(object)_buttonLayout).CharacterAnimations;
		HorizontalLayout buttonLayout = _buttonLayout;
		((CoinScreen)running).InsertEarner((int)characterAnimations2, ref *(((Layout)buttonLayout)._alignNow ? ((int*)1) : ((int*)null)));
	}

	private unsafe void TrackConsumablePurchase(bool playedVideo)
	{
		//IL_060c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0611: Expected I4, but got Unknown
		//IL_061a: Unknown result type (might be due to invalid IL or missing references)
		//IL_061f: Expected Obj, but got Unknown
		//IL_0628: Unknown result type (might be due to invalid IL or missing references)
		//IL_062d: Expected Obj, but got Unknown
		//IL_0636: Unknown result type (might be due to invalid IL or missing references)
		//IL_063b: Expected Obj, but got Unknown
		//IL_0644: Unknown result type (might be due to invalid IL or missing references)
		//IL_0649: Expected Obj, but got Unknown
		//IL_0652: Unknown result type (might be due to invalid IL or missing references)
		//IL_0657: Expected Obj, but got Unknown
		//IL_0660: Unknown result type (might be due to invalid IL or missing references)
		//IL_0665: Expected Obj, but got Unknown
		//IL_066e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0673: Expected Obj, but got Unknown
		//IL_067c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0681: Expected Obj, but got Unknown
		//IL_068a: Unknown result type (might be due to invalid IL or missing references)
		//IL_068f: Expected Obj, but got Unknown
		//IL_0698: Expected Obj, but got I4
		//IL_06a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a6: Expected Obj, but got Unknown
		//IL_06af: Expected Obj, but got I4
		//IL_00e6: Expected Obj, but got I4
		//IL_00f9: Expected I, but got Obj
		//IL_010f: Expected Obj, but got I
		//IL_0041: Expected I, but got Obj
		//IL_0057: Expected Obj, but got I
		//IL_0714: Expected I, but got Obj
		//IL_072a: Expected Obj, but got I
		//IL_06ed: Expected Obj, but got I4
		//IL_06ed: Expected Obj, but got I
		//IL_0758: Expected Obj, but got I
		//IL_076b: Expected I4, but got Obj
		//IL_0779: Expected Obj, but got I4
		//IL_079b: Expected I4, but got Obj
		//IL_013a: Expected I, but got Obj
		//IL_00d1: Expected Obj, but got I4
		//IL_0082: Expected I, but got Obj
		//IL_0187: Expected I, but got Obj
		//IL_01f6: Expected Obj, but got I4
		//IL_0225: Expected I4, but got Obj
		//IL_0233: Expected Obj, but got I4
		//IL_0255: Expected I4, but got Obj
		//IL_0286: Expected Obj, but got I
		//IL_02b2: Expected Obj, but got I4
		//IL_02d4: Expected I4, but got Obj
		//IL_0301: Expected Obj, but got I
		//IL_0319: Expected I4, but got Obj
		//IL_0327: Expected Obj, but got I4
		//IL_0349: Expected I4, but got Obj
		//IL_0378: Expected Obj, but got I4
		//IL_03c4: Expected I4, but got Obj
		//IL_03da: Expected Obj, but got I4
		//IL_0400: Expected I4, but got Obj
		//IL_0416: Expected Obj, but got I4
		//IL_0441: Expected I4, but got Obj
		//IL_0457: Expected Obj, but got I4
		//IL_0468: Expected I4, but got Obj
		//IL_047e: Expected Obj, but got I4
		//IL_04c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ca: Expected Obj, but got Unknown
		//IL_04eb: Expected I, but got Obj
		//IL_0501: Expected Obj, but got I
		//IL_07fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ff: Expected Obj, but got Unknown
		//IL_0811: Expected Obj, but got I4
		//IL_05a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a5: Expected Obj, but got Unknown
		//IL_052c: Expected I, but got Obj
		//IL_05d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_05de: Expected Obj, but got Unknown
		object obj = default;
		UIWidget.Pivot pivot = (UIWidget.Pivot)(obj + 160);
		object obj2 = obj + 104;
		object obj3 = obj - -64;
		object obj4 = obj + 48;
		object obj5 = obj + 32;
		object obj6 = obj + 16;
		object obj7 = obj + 120;
		object obj8 = obj + 88;
		object obj9 = obj + 72;
		object obj10 = obj + 152;
		obj10 = 0;
		object obj11 = obj + 136;
		obj11 = 0;
		_ = 0;
		if (!playedVideo)
		{
			return;
		}
		Reset3DModelScales();
		if (ShouldShowVideoButton())
		{
			nint num = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ S0_v112 (Il2CppClass<UIScreenController>)+BA]");
			object obj12 = (nint)0 & (nint)0x200;
			if (obj12 != null)
			{
				nint num2 = (nint)typeof(UIScreenController);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ S0_v123 (Il2CppClass<UIScreenController>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool flag = UIScreenController.ShouldShowOnlineScreen();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ S0_v117 (System.Boolean)+20]");
			((Component)0).tag = (string)1;
			_consumablesHelper.DidHideConsumablesPopup();
			_coinboxFundsDisabled.tag = (string)1;
		}
		else
		{
			_coinboxFundsEnabled.tag = (string)1;
		}
		nint num3 = (nint)typeof(ColorData);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ S0_v39 (Il2CppClass<UI.ColorData>)+BA]");
		object obj13 = (nint)0 & (nint)0x200;
		if (obj13 != null)
		{
			nint num4 = (nint)typeof(ColorData);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ S0_v105 (Il2CppClass<UI.ColorData>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag2 = HoverboardStickerManager.ShouldShowHoverboardStickerFlow();
		nint num5 = (nint)typeof(Strings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v174 @ S2_v4 (Il2CppClass<Strings>)+BA]");
		object obj14 = (nint)0 & (nint)0x200;
		if (obj14 != null)
		{
			nint num6 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v181 @ S2_v83 (Il2CppClass<Strings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [playedVideo @ L1 (System.Boolean)+14]");
		string text = Strings.GetDefault((string)0);
		_consumableTitle.fontSize = (int)text;
		object obj15 = (flag2 ? 1 : 0) + 604;
		obj2 = obj15;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v196 @ S2_v11+8]");
		_ = 0;
		((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11+8]");
		_ = 0;
		_consumableTitle.rawPivot = pivot;
		string format = Strings.GetDefault("INVENTORY_ITEM_COUNTER");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [playedVideo @ L1 (System.Boolean)+8]");
		int tier = InventorySave.GetTier(UpgradeType._notset);
		obj3 = tier;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		object[] args = default;
		string text2 = string.Format(format, args);
		_consumableCount.fontSize = (int)text2;
		object obj16 = (flag2 ? 1 : 0) + 604;
		obj4 = obj16;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v232 @ S2_v27+8]");
		_ = 0;
		((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v15+8]");
		_ = 0;
		_consumableCount.rawPivot = pivot;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [playedVideo @ L1 (System.Boolean)+C]");
		obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D63B");
		int fontSize = default;
		_consumablePrice.fontSize = fontSize;
		object obj17 = (flag2 ? 1 : 0) + 604;
		obj5 = obj17;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v259 @ S2_v41+8]");
		_ = 0;
		((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v17+8]");
		_ = 0;
		_consumablePrice.rawPivot = pivot;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [playedVideo @ L1 (System.Boolean)+18]");
		string text3 = Strings.GetDefault((string)0);
		_consumableDescription.fontSize = (int)text3;
		object obj18 = (flag2 ? 1 : 0) + 12;
		obj6 = obj18;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v285 @ S2_v53+8]");
		_ = 0;
		((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v19+8]");
		_ = 0;
		_consumableDescription.rawPivot = pivot;
		object obj19 = (flag2 ? 1 : 0) + 732;
		obj = obj19;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v308 @ S5_v3+8]");
		_ = 0;
		obj7 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		obj11 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S0_v21+8]");
		_ = 0;
		Vector2 effectDistance = ((UILabel)pivot).effectDistance;
		obj8 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ S0_v29+8]");
		_ = 0;
		((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S0_v23+8]");
		_ = 0;
		Vector2 effectDistance2 = ((UILabel)pivot).effectDistance;
		obj9 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ S0_v29+8]");
		_ = 0;
		((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S0_v25+8]");
		_ = 0;
		Vector2 effectDistance3 = ((UILabel)pivot).effectDistance;
		((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ S0_v29+8]");
		_ = 0;
		Vector2 effectDistance4 = ((UILabel)pivot).effectDistance;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [playedVideo @ L1 (System.Boolean)+8]");
		((LanguageSelectionPopup)this).SetBackButtonEnabledState(false);
		OnCoinsButtonClicked();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num7 = 0;
		_ = 0;
		Action<string> action = default;
		object obj20 = action + 16;
		obj20 = this;
		AdSystemManager.onFailedToShowVideo -= action;
		nint num8 = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v397 @ S0_v76 (Il2CppClass<UIScreenController>)+BA]");
		object obj21 = (nint)0 & (nint)0x200;
		if (obj21 != null)
		{
			nint num9 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v403 @ S0_v101 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag3 = UIScreenController.ShouldShowOnlineScreen();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr = 0;
		Action action2 = default;
		((Delegate)action2).method_ptr = method_ptr;
		((Delegate)action2).method = (nint)__ldftn(ConsumablesPopup.OnVideoOverlayClosed);
		object obj22 = action2 + 16;
		obj22 = this;
		((UIScreenController)flag3).OnOverlayManuallyClosed -= action2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr2 = 0;
		Action action3 = default;
		((Delegate)action3).method_ptr = method_ptr2;
		((Delegate)action3).method = (nint)__ldftn(ConsumablesPopup.OnApplicationResumed);
		object obj23 = action3 + 16;
		obj23 = this;
		UIScreenController.OnApplicationResumed -= action3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num10 = 0;
		_ = 0;
		Action<UpgradeType, int> action4 = default;
		object obj24 = action4 + 16;
		obj24 = this;
		InventorySave.powerupsChanged -= action4;
		((RewardForVideoButton)(object)_buttonLayout).Init((VideoButtonPayload)null);
	}

	public unsafe void OnCoinsButtonClicked()
	{
		//IL_03a0: Expected I, but got Obj
		//IL_03b6: Expected Obj, but got I
		//IL_0456: Unknown result type (might be due to invalid IL or missing references)
		//IL_045b: Expected I4, but got Unknown
		//IL_0464: Unknown result type (might be due to invalid IL or missing references)
		//IL_0469: Expected Obj, but got Unknown
		//IL_0472: Unknown result type (might be due to invalid IL or missing references)
		//IL_0477: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_007f: Expected Obj, but got I4
		//IL_008d: Expected I, but got Obj
		//IL_00a3: Expected Obj, but got I
		//IL_038c: Expected Obj, but got I4
		//IL_00ce: Expected I, but got Obj
		//IL_0144: Expected I4, but got Obj
		//IL_0152: Expected Obj, but got I4
		//IL_0174: Expected I4, but got Obj
		//IL_01a3: Expected Obj, but got I4
		//IL_01c5: Expected I4, but got Obj
		//IL_01db: Expected Obj, but got I4
		//IL_021f: Expected I, but got Obj
		//IL_0235: Expected Obj, but got I
		//IL_0412: Expected I4, but got Obj
		//IL_041f: Expected Obj, but got I4
		//IL_042c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0431: Expected Obj, but got Unknown
		//IL_0444: Expected Obj, but got I4
		//IL_0260: Expected I, but got Obj
		//IL_0319: Expected Obj, but got I4
		nint num = (nint)typeof(ColorData);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v9 (Il2CppClass<UI.ColorData>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(ColorData);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v65 (Il2CppClass<UI.ColorData>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj2 = default;
		UIWidget.Pivot pivot = (UIWidget.Pivot)(obj2 + 40);
		object obj3 = obj2 + 32;
		object obj4 = obj2 + 16;
		bool flag = HoverboardStickerManager.ShouldShowHoverboardStickerFlow();
		_watchVideoButton.tag = null;
		string cooldownId = GetCooldownId();
		if (cooldownId != null)
		{
			_watchVideoButton.tag = (string)1;
			nint num3 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ S1_v19 (Il2CppClass<Strings>)+BA]");
			object obj5 = (nint)0 & (nint)0x200;
			if (obj5 != null)
			{
				nint num4 = (nint)typeof(Strings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ S1_v58 (Il2CppClass<Strings>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			string format = Strings.GetDefault("CONSUMABLES_POPUP_FREE_TEXT");
			bool flag2 = ShouldShowVideoButton();
			SellableConsumable consumableReward = _consumablesHelper.GetConsumableReward(flag2);
			obj3 = consumableReward;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
			object[] args = default;
			string text = string.Format(format, args);
			_videoButtonFreeLabel.fontSize = (int)text;
			object obj6 = (flag ? 1 : 0) + 604;
			obj4 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ S2_v15+8]");
			_ = 0;
			((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S0_v18+8]");
			_ = 0;
			_videoButtonFreeLabel.rawPivot = pivot;
			object obj7 = (flag ? 1 : 0) + 732;
			obj2 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ S2_v25+8]");
			_ = 0;
			((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			_ = 0;
			Vector2 effectDistance = ((UILabel)pivot).effectDistance;
			HorizontalLayout component = _videoButtonNormalState.GetComponent<HorizontalLayout>();
			((RewardForVideoButton)(object)component).Init((VideoButtonPayload)null);
			string go = _videoTvIconContainer.tag;
			nint num5 = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v192 @ S2_v36 (Il2CppClass<NGUITools>)+BA]");
			object obj8 = (nint)0 & (nint)0x200;
			if (obj8 != null)
			{
				nint num6 = (nint)typeof(NGUITools);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v197 @ S2_v45 (Il2CppClass<NGUITools>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			int num7 = NGUITools.CalculateNextDepth((GameObject)(object)go, (byte)(int)_videoTvIconPrefab != 0);
			FitSpriteToWidget component2 = ((GameObject)num7).GetComponent<FitSpriteToWidget>();
			object obj9 = component2 + 16;
			obj9 = _videoTvIconContainer;
			FitSpriteToWidget component3 = ((GameObject)num7).GetComponent<FitSpriteToWidget>();
			component3.FitStretch();
			bool flag3 = ShouldShowVideoButton();
			if (_consumablesHelper.IsConsumableVideoLocationAvailable(flag3))
			{
				BackgroundClicked();
			}
			bool flag4 = ShouldShowVideoButton();
			int consumableRewardForVideo = _consumablesHelper.GetConsumableRewardForVideo(flag4);
			((WaterFallReach)consumableRewardForVideo)._002Ector();
		}
		if (_videoButtonTrackingState == VideoButtonTrackingState.Fill || _videoButtonTrackingState == VideoButtonTrackingState.NoFill)
		{
			bool flag5 = ShouldShowVideoButton();
			int consumableRewardForVideo2 = _consumablesHelper.GetConsumableRewardForVideo(flag5);
			AdTrackingSystemLogger.LogVideoAdButtonClick((AdLocationInfo)consumableRewardForVideo2);
		}
	}

	private bool ShouldShowVideoButton()
	{
		//IL_0087: Expected I, but got Obj
		//IL_009d: Expected Obj, but got I
		//IL_00d8: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(Game);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SYBO.Subway.Game>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Game);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v19 (Il2CppClass<SYBO.Subway.Game>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool isInstantiated = Game.IsInstantiated;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v11 (System.Boolean)+60]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v12+8]");
		if ((nint)0 != 0)
		{
			return _consumablesHelper != null;
		}
		return false;
	}

	private string GetCooldownId()
	{
		//IL_01a2: Expected Obj, but got I4
		//IL_00a1: Expected Obj, but got I4
		//IL_00a1: Expected Obj, but got I4
		//IL_0205: Expected Obj, but got I4
		object obj = 0;
		_videoButtonTrackingState = VideoButtonTrackingState.NotSet;
		bool flag = ShouldShowVideoButton();
		string videoIdForConsumable = _consumablesHelper.GetVideoIdForConsumable(flag);
		if (videoIdForConsumable != null)
		{
			string flurryName = ((NotEnoughCurrencyPopup)this).GetFlurryName();
			if (CooldownManager.GetChargesUsed(flurryName) == 0)
			{
				_videoButtonTrackingState = VideoButtonTrackingState.Cooldown;
				return null;
			}
			bool flag2 = _consumablesHelper.IsConsumableVideoLocationAvailable(isInRun: false);
			bool flag3 = ShouldShowVideoButton();
			int consumableRewardForVideo = _consumablesHelper.GetConsumableRewardForVideo(flag3);
			((WaterFallReach)consumableRewardForVideo).OnFailedToCacheVideo((string)flag2);
			if (flag2)
			{
				_videoButtonTrackingState = VideoButtonTrackingState.Fill;
			}
			else
			{
				_videoButtonTrackingState = VideoButtonTrackingState.NoFill;
			}
			bool flag4 = ShouldShowVideoButton();
			GameObject gameObject = ((DailyChallengePage)(object)_consumablesHelper)._003CInit_003Eb__17_0((UIWidget)flag4);
			obj = gameObject;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
			throw new NullReferenceException();
		}
		return null;
	}

	public void OnVideoButtonClicked()
	{
		//IL_006c: Expected Obj, but got I4
		//IL_0085: Expected Obj, but got I4
		//IL_0031: Expected VT, but got Obj
		bool flag = ShouldShowVideoButton();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num = 0;
		_ = 0;
		Boards.BoardId boardId = default;
		object obj = boardId + 16;
		obj = this;
		((BoardBundleItem)(object)_consumablesHelper).SetupBoard((Transform)flag, boardId, (List<int>)null);
		if (ShouldShowVideoButton())
		{
			_00210 val = (_00210)SingletonMonoBehaviour<>.Instantiate();
			_ = 1;
		}
	}

	private unsafe void OnFinishedWatchingVideo()
	{
		//IL_0021: Expected Obj, but got I4
		//IL_0129: Expected VT, but got Obj
		//IL_008c: Expected Obj, but got I4
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e0: Expected Obj, but got Unknown
		//IL_00f8: Expected Obj, but got I4
		//IL_00f8: Expected I4, but got Obj
		IEnumerator coroutine = ((UIScaleAnimation)(object)this).WaitForSecondsAndRestart(0f);
		CoroutineUtil.StopCoroutine((Coroutine)(object)coroutine);
		bool flag = ShouldShowVideoButton();
		int consumableRewardForVideo = _consumablesHelper.GetConsumableRewardForVideo(flag);
		((WaterFallReach)consumableRewardForVideo)._002Ector();
		bool flag2 = ShouldShowVideoButton();
		if (_consumablesHelper.IsConsumableVideoLocationAvailable(flag2))
		{
			bool flag3 = ShouldShowVideoButton();
			int consumableRewardForVideo2 = _consumablesHelper.GetConsumableRewardForVideo(flag3);
			AdTrackingSystemLogger.LogFillRequest((AdLocationInfo)consumableRewardForVideo2);
			isVideoPlaying__BackingField = true;
			bool flag4 = ShouldShowVideoButton();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint method_ptr = 0;
			Action action = default;
			((Delegate)action).method_ptr = method_ptr;
			((Delegate)action).method = (nint)__ldftn(ConsumablesPopup.OnFinishedWatchingVideo);
			object obj = action + 16;
			obj = this;
			CloudSaveConfirmationPopupPayload.PreparePayload((CloudSaveConfirmationPopupPayload.ConfirmationState)_consumablesHelper, (Action)flag4, action);
		}
		if (ShouldShowVideoButton())
		{
			_00210 val = (_00210)SingletonMonoBehaviour<>.Instantiate();
			_ = 1;
		}
	}

	public void OnVideoOverlayClosed()
	{
		//IL_002b: Expected I, but got Obj
		//IL_0041: Expected Obj, but got I
		//IL_0269: Unknown result type (might be due to invalid IL or missing references)
		//IL_026e: Expected Obj, but got Unknown
		//IL_00c6: Expected Obj, but got I4
		//IL_006c: Expected I, but got Obj
		//IL_00fa: Expected Obj, but got I4
		//IL_01a6: Expected I, but got Obj
		//IL_01bc: Expected Obj, but got I
		//IL_0193: Expected Obj, but got I4
		//IL_01e7: Expected I, but got Obj
		if (~(isVideoPlaying__BackingField ? 1u : 0u) != 0)
		{
			return;
		}
		string flurryName = ((NotEnoughCurrencyPopup)this).GetFlurryName();
		((Cooldowns)(object)flurryName)._002Ector();
		nint num = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S0_v11 (Il2CppClass<UIScreenController>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S0_v41 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = UIScreenController.ShouldShowOnlineScreen();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		string text = default;
		text.m_stringLength = 10;
		object obj2 = text + 40;
		bool flag2 = ShouldShowVideoButton();
		UpgradeType consumableUpgradeType = _consumablesHelper.GetConsumableUpgradeType(flag2);
		obj2 = consumableUpgradeType;
		bool flag3 = ShouldShowVideoButton();
		SellableConsumable consumableReward = _consumablesHelper.GetConsumableReward(flag3);
		((UIScreenController)flag)._QueueMessage(text);
		string cooldownId = GetCooldownId();
		if (cooldownId == null)
		{
			_watchVideoButton.tag = null;
			((RewardForVideoButton)(object)_buttonLayout).Init((VideoButtonPayload)null);
		}
		string flurryName2 = ((NotEnoughCurrencyPopup)this).GetFlurryName();
		if (flurryName2 != "hoverboard")
		{
			OnShowVideoFailure((string)1);
		}
		nint num3 = (nint)typeof(SaveManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ S0_v26 (Il2CppClass<Data.Save.SaveManager>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num4 = (nint)typeof(SaveManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ S0_v32 (Il2CppClass<Data.Save.SaveManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		SaveManager.Load();
		isVideoPlaying__BackingField = false;
	}

	public void OnApplicationResumed()
	{
		if (~(isVideoPlaying__BackingField ? 1u : 0u) == 0)
		{
			OnVideoOverlayClosed();
		}
	}

	private void OnShowVideoFailure(string locationId)
	{
		//IL_01fd: Expected Obj, but got I4
		//IL_001b: Expected Obj, but got I
		//IL_002b: Expected Obj, but got I
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected Obj, but got Unknown
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Expected Obj, but got Unknown
		//IL_006b: Expected Obj, but got I4
		//IL_0090: Expected Obj, but got I
		//IL_00a0: Expected Obj, but got I
		//IL_00b0: Expected Obj, but got I
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Expected Obj, but got Unknown
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Expected Obj, but got Unknown
		//IL_021e: Expected I, but got Obj
		//IL_0234: Expected Obj, but got I
		//IL_01a5: Expected I, but got Obj
		//IL_015e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0163: Expected Obj, but got Unknown
		//IL_0267: Expected Obj, but got I
		//IL_0277: Expected Obj, but got I
		//IL_0287: Expected Obj, but got I
		//IL_0290: Unknown result type (might be due to invalid IL or missing references)
		//IL_0295: Expected Obj, but got Unknown
		//IL_029e: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a3: Expected Obj, but got Unknown
		bool flag = ShouldShowVideoButton();
		GameObject gameObject = ((DailyChallengePage)(object)_consumablesHelper)._003CInit_003Eb__17_0((UIWidget)flag);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S3_v2 (Il2CppMethodInfo)+C]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S3_v3+60]");
		object obj2 = 0;
		object obj3 = obj2;
		object obj4 = obj3 & 0x1FFF;
		object obj5 = obj4 + 113696;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v42 @ S4_v4 (should have been resolved before IL gen)");
		bool flag2 = ShouldShowVideoButton();
		object obj6 = flag2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @E241");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ S4_v6 (Il2CppMethodInfo)+C]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ S4_v7+60]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ S4_v8+48]");
		object obj9 = 0;
		object obj10 = obj9 & 0x7FF;
		object obj11 = obj10 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v70 @ S5_v6 (should have been resolved before IL gen)");
		if (_videoButtonTrackingState != VideoButtonTrackingState.NotSet)
		{
			if (locationId != null)
			{
				object obj12 = "Used";
			}
			else
			{
				if (_videoButtonTrackingState != VideoButtonTrackingState.Fill)
				{
					object obj13 = this + 160;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
					throw new NullReferenceException();
				}
				object obj12 = "AvailableNotUsed";
			}
			nint num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ S4_v12 (Il2CppMethodInfo)+C]");
			object obj14 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ S4_v13+60]");
			object obj15 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ S4_v14+48]");
			object obj16 = 0;
			object obj17 = obj16 & 0x7FF;
			object obj18 = obj17 + 39195;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v85 @ S5_v11 (should have been resolved before IL gen)");
		}
		nint num4 = (nint)typeof(Flurry);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ S0_v23 (Il2CppClass<Flurry>)+BA]");
		object obj19 = (nint)0 & (nint)0x200;
		if (obj19 != null)
		{
			nint num5 = (nint)typeof(Flurry);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ S0_v28 (Il2CppClass<Flurry>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
	}

	private void SwitchVideoButtonToNormalState()
	{
		OnCoinsButtonClicked();
		((RewardForVideoButton)(object)_buttonLayout).Init((VideoButtonPayload)null);
	}

	public void BackgroundClicked()
	{
		//IL_0020: Expected Obj, but got I4
		_videoButtonNormalState.tag = (string)1;
		_videoButtonOverlay.GoToNotAvailableState();
		HorizontalLayout component = _videoButtonNormalState.GetComponent<HorizontalLayout>();
		((RewardForVideoButton)(object)component).Init((VideoButtonPayload)null);
	}

	private void Setup3DModels()
	{
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_00d4: Expected Obj, but got I4
		//IL_0054: Expected I, but got Obj
		if (ShouldShowVideoButton())
		{
			return;
		}
		nint num = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v10 (Il2CppClass<UIScreenController>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v16 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = UIScreenController.ShouldShowOnlineScreen();
		((UIScreenController)flag).DebugCloseAllPopups();
	}

	private unsafe void Reset3DModelScales()
	{
		//IL_0881: Expected I, but got Obj
		//IL_0897: Expected Obj, but got I
		//IL_0f38: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f3d: Expected Obj, but got Unknown
		//IL_0f46: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f4b: Expected Obj, but got Unknown
		//IL_0f54: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f59: Expected Obj, but got Unknown
		//IL_0f62: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f67: Expected Obj, but got Unknown
		//IL_0f70: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f75: Expected Ref, but got Unknown
		//IL_02bc: Expected I, but got Obj
		//IL_02d2: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Expected Obj, but got Unknown
		//IL_0074: Expected I, but got Obj
		//IL_008a: Expected Obj, but got I
		//IL_059b: Expected I, but got Obj
		//IL_05b1: Expected Obj, but got I
		//IL_02fd: Expected I, but got Obj
		//IL_08ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_08bf: Expected Obj, but got Unknown
		//IL_08d4: Expected I4, but got Obj
		//IL_08d4: Expected Obj, but got I
		//IL_08e0: Expected Obj, but got I4
		//IL_08fd: Expected I, but got Obj
		//IL_0913: Expected Obj, but got I
		//IL_0353: Expected I, but got Obj
		//IL_0369: Expected Obj, but got I
		//IL_00b5: Expected I, but got Obj
		//IL_05dc: Expected I, but got Obj
		//IL_0aec: Unknown result type (might be due to invalid IL or missing references)
		//IL_0af1: Expected Obj, but got Unknown
		//IL_0b08: Expected I4, but got Obj
		//IL_0b08: Expected Obj, but got I
		//IL_0b14: Expected Obj, but got I4
		//IL_0b31: Expected I, but got Obj
		//IL_0b47: Expected Obj, but got I
		//IL_014f: Expected I, but got Obj
		//IL_0165: Expected Obj, but got I
		//IL_0182: Expected I, but got Obj
		//IL_0102: Expected I, but got Obj
		//IL_0632: Expected I, but got Obj
		//IL_0648: Expected Obj, but got I
		//IL_0394: Expected I, but got Obj
		//IL_0990: Expected Obj, but got VT
		//IL_09e4: Expected I, but got Obj
		//IL_09fa: Expected Obj, but got I
		//IL_0a1d: Expected I, but got Obj
		//IL_0a33: Expected Obj, but got I
		//IL_0d25: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d2a: Expected Obj, but got Unknown
		//IL_0d41: Expected I4, but got Obj
		//IL_0d41: Expected Obj, but got I
		//IL_0d4d: Expected Obj, but got I4
		//IL_0d6a: Expected I, but got Obj
		//IL_0d80: Expected Obj, but got I
		//IL_042e: Expected I, but got Obj
		//IL_0444: Expected Obj, but got I
		//IL_0461: Expected I, but got Obj
		//IL_03e1: Expected I, but got Obj
		//IL_0a87: Expected Obj, but got VT
		//IL_019e: Expected I, but got Obj
		//IL_01ce: Expected I, but got Obj
		//IL_0673: Expected I, but got Obj
		//IL_0bc1: Expected Obj, but got I
		//IL_0c1d: Expected I, but got Obj
		//IL_0c33: Expected Obj, but got I
		//IL_0c56: Expected I, but got Obj
		//IL_0c6c: Expected Obj, but got I
		//IL_0254: Expected I, but got Obj
		//IL_026a: Expected Obj, but got I
		//IL_02a9: Expected Obj, but got I4
		//IL_0207: Expected I, but got Obj
		//IL_070d: Expected I, but got Obj
		//IL_0723: Expected Obj, but got I
		//IL_0740: Expected I, but got Obj
		//IL_06c0: Expected I, but got Obj
		//IL_0cc0: Expected Obj, but got VT
		//IL_047d: Expected I, but got Obj
		//IL_04ad: Expected I, but got Obj
		//IL_01f4: Expected I, but got Obj
		//IL_0dfa: Expected Obj, but got I
		//IL_0e56: Expected I, but got Obj
		//IL_0e6c: Expected Obj, but got I
		//IL_0e8f: Expected I, but got Obj
		//IL_0ea5: Expected Obj, but got I
		//IL_0533: Expected I, but got Obj
		//IL_0549: Expected Obj, but got I
		//IL_0588: Expected Obj, but got I4
		//IL_04e6: Expected I, but got Obj
		//IL_0ef9: Expected Obj, but got VT
		//IL_075c: Expected I, but got Obj
		//IL_078c: Expected I, but got Obj
		//IL_04d3: Expected I, but got Obj
		//IL_0812: Expected I, but got Obj
		//IL_0828: Expected Obj, but got I
		//IL_0867: Expected Obj, but got I4
		//IL_07c5: Expected I, but got Obj
		//IL_07b2: Expected I, but got Obj
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v4 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S1_v221 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj2 = default;
		Transform transform = (Transform)(obj2 + 72);
		object obj3 = obj2 + 56;
		object obj4 = obj2 + 44;
		object obj5 = obj2 + 32;
		ref Quaternion reference = ref *(Quaternion*)(obj2 + 16);
		if (_hoverboardUIModel != null)
		{
			bool isInstanced = UIScreenController.IsInstanced;
			object obj6 = this - -64;
			nint num3 = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ S0_v85 (Il2CppClass<NGUITools>)+BA]");
			object obj7 = (nint)0 & (nint)0x200;
			if (obj7 != null)
			{
				nint num4 = (nint)typeof(NGUITools);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ S0_v103 (Il2CppClass<NGUITools>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			object obj8 = this + 120;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ S0_v79 (System.Boolean)+18]");
			int num5 = NGUITools.CalculateNextDepth((GameObject)0, (byte)(int)obj6 != 0);
			obj8 = num5;
			int layer = _hoverboardUIModel.layer;
			nint num6 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ S1_v168 (Il2CppClass<UnityEngine.Vector3>)+BA]");
			object obj9 = (nint)0 & (nint)0x200;
			if (obj9 != null)
			{
				nint num7 = (nint)typeof(Vector3);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v190 @ S1_v217 (Il2CppClass<UnityEngine.Vector3>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Vector3 one = Vector3.one;
			transform = (Transform)obj3;
			Transform transform2 = transform;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S1_v11+8]");
			((UnityEngine.Object)transform2).m_CachedPtr = (IntPtr)0;
			Vector3 localPosition = transform.localPosition;
			int layer2 = _hoverboardUIModel.layer;
			nint num8 = (nint)typeof(ConsumablesPopup);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v275 @ S1_v178 (Il2CppClass<UI.Popups.ConsumablesPopup>)+BA]");
			object obj10 = (nint)0 & (nint)0x200;
			bool flag = obj10 == null;
			nint num9 = (nint)typeof(ConsumablesPopup);
			if (!flag)
			{
				nint num10 = (nint)typeof(ConsumablesPopup);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v305 @ S1_v211 (Il2CppClass<UI.Popups.ConsumablesPopup>)+74]");
				bool flag2 = (nint)0 == 0;
				bool flag3 = !flag2;
				num9 = (nint)typeof(ConsumablesPopup);
				if (!flag3)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					num9 = (nint)typeof(ConsumablesPopup);
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v309 @ L1_v26 (Il2CppClass<UI.Popups.ConsumablesPopup>)+5C]");
			nint num11 = 0;
			obj4 = HOVERBOARD_POSITION_OFFSET;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v316 @ S2_v125 (Il2CppStaticFields<UI.Popups.ConsumablesPopup>)+8]");
			_ = 0;
			transform = (Transform)obj4;
			Transform transform3 = transform;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S1_v13+8]");
			((UnityEngine.Object)transform3).m_CachedPtr = (IntPtr)0;
			Vector3 eulerAngles = transform.eulerAngles;
			int layer3 = _hoverboardUIModel.layer;
			nint num12 = (nint)typeof(ConsumablesPopup);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v363 @ S2_v135 (Il2CppClass<UI.Popups.ConsumablesPopup>)+5C]");
			object obj11 = (nint)0 + (nint)12;
			obj5 = obj11;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v366 @ S2_v137+8]");
			_ = 0;
			nint num13 = (nint)typeof(Quaternion);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v373 @ S1_v191 (Il2CppClass<UnityEngine.Quaternion>)+BA]");
			object obj12 = (nint)0 & (nint)0x200;
			if (obj12 != null)
			{
				nint num14 = (nint)typeof(Quaternion);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v395 @ S1_v207 (Il2CppClass<UnityEngine.Quaternion>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			transform = (Transform)obj5;
			Transform transform4 = transform;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ S1_v15+8]");
			((UnityEngine.Object)transform4).m_CachedPtr = (IntPtr)0;
			Quaternion.Inverse_Injected(ref reference, out *(Quaternion*)transform);
			transform = (Transform)reference;
			Transform transform5 = transform;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ S1_v17 (UnityEngine.Quaternion&)+8]");
			((UnityEngine.Object)transform5).m_CachedPtr = (IntPtr)0;
			Vector3 localScale = transform.localScale;
			int layer4 = _hoverboardUIModel.layer;
			nint num15 = (nint)typeof(ConsumablesPopup);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v494 @ S2_v153 (Il2CppClass<UI.Popups.ConsumablesPopup>)+5C]");
			object obj13 = (nint)0 + (nint)24;
			obj2 = obj13;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v496 @ S2_v155+8]");
			_ = 0;
			transform = (Transform)obj2;
			Transform transform6 = transform;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			((UnityEngine.Object)transform6).m_CachedPtr = (IntPtr)0;
			((Transform)layer4).parent = transform;
		}
		nint num16 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ S1_v21 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj14 = (nint)0 & (nint)0x200;
		if (obj14 != null)
		{
			nint num17 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ S1_v157 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (_headstartUIModel != null)
		{
			bool isInstanced2 = UIScreenController.IsInstanced;
			nint num18 = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v174 @ S0_v56 (Il2CppClass<NGUITools>)+BA]");
			object obj15 = (nint)0 & (nint)0x200;
			if (obj15 != null)
			{
				nint num19 = (nint)typeof(NGUITools);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v200 @ S0_v74 (Il2CppClass<NGUITools>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			object obj16 = this + 124;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ S0_v51 (System.Boolean)+18]");
			int num20 = NGUITools.CalculateNextDepth((GameObject)0, (byte)(int)_headstartPrefab != 0);
			obj16 = num20;
			int layer5 = _headstartUIModel.layer;
			nint num21 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v255 @ S1_v104 (Il2CppClass<UnityEngine.Vector3>)+BA]");
			object obj17 = (nint)0 & (nint)0x200;
			if (obj17 != null)
			{
				nint num22 = (nint)typeof(Vector3);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v281 @ S1_v153 (Il2CppClass<UnityEngine.Vector3>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Vector3 one2 = Vector3.one;
			transform = (Transform)obj3;
			Transform transform7 = transform;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S1_v11+8]");
			((UnityEngine.Object)transform7).m_CachedPtr = (IntPtr)0;
			Vector3 localPosition2 = transform.localPosition;
			int layer6 = _headstartUIModel.layer;
			nint num23 = (nint)typeof(ConsumablesPopup);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v379 @ S1_v114 (Il2CppClass<UI.Popups.ConsumablesPopup>)+BA]");
			object obj18 = (nint)0 & (nint)0x200;
			bool flag4 = obj18 == null;
			nint num24 = (nint)typeof(ConsumablesPopup);
			if (!flag4)
			{
				nint num25 = (nint)typeof(ConsumablesPopup);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v410 @ S1_v147 (Il2CppClass<UI.Popups.ConsumablesPopup>)+74]");
				bool flag5 = (nint)0 == 0;
				bool flag6 = !flag5;
				num24 = (nint)typeof(ConsumablesPopup);
				if (!flag6)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					num24 = (nint)typeof(ConsumablesPopup);
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v414 @ L1_v18 (Il2CppClass<UI.Popups.ConsumablesPopup>)+5C]");
			object obj19 = (nint)0 + (nint)36;
			obj4 = obj19;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v423 @ S2_v76+8]");
			_ = 0;
			transform = (Transform)obj4;
			Transform transform8 = transform;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S1_v13+8]");
			((UnityEngine.Object)transform8).m_CachedPtr = (IntPtr)0;
			Vector3 eulerAngles2 = transform.eulerAngles;
			int layer7 = _headstartUIModel.layer;
			nint num26 = (nint)typeof(ConsumablesPopup);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v470 @ S2_v86 (Il2CppClass<UI.Popups.ConsumablesPopup>)+5C]");
			object obj20 = (nint)0 + (nint)48;
			obj5 = obj20;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v473 @ S2_v88+8]");
			_ = 0;
			nint num27 = (nint)typeof(Quaternion);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v480 @ S1_v127 (Il2CppClass<UnityEngine.Quaternion>)+BA]");
			object obj21 = (nint)0 & (nint)0x200;
			if (obj21 != null)
			{
				nint num28 = (nint)typeof(Quaternion);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v507 @ S1_v143 (Il2CppClass<UnityEngine.Quaternion>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			transform = (Transform)obj5;
			Transform transform9 = transform;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ S1_v15+8]");
			((UnityEngine.Object)transform9).m_CachedPtr = (IntPtr)0;
			Quaternion.Inverse_Injected(ref reference, out *(Quaternion*)transform);
			transform = (Transform)reference;
			Transform transform10 = transform;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ S1_v17 (UnityEngine.Quaternion&)+8]");
			((UnityEngine.Object)transform10).m_CachedPtr = (IntPtr)0;
			Vector3 localScale2 = transform.localScale;
			int layer8 = _headstartUIModel.layer;
			nint num29 = (nint)typeof(ConsumablesPopup);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v586 @ S2_v104 (Il2CppClass<UI.Popups.ConsumablesPopup>)+5C]");
			object obj22 = (nint)0 + (nint)60;
			obj2 = obj22;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v588 @ S2_v106+8]");
			_ = 0;
			transform = (Transform)obj2;
			Transform transform11 = transform;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			((UnityEngine.Object)transform11).m_CachedPtr = (IntPtr)0;
			((Transform)layer8).parent = transform;
		}
		nint num30 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ S1_v28 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj23 = (nint)0 & (nint)0x200;
		if (obj23 != null)
		{
			nint num31 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v180 @ S1_v94 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (_scoreboosterUIModel != null)
		{
			bool isInstanced3 = UIScreenController.IsInstanced;
			nint num32 = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v266 @ S0_v28 (Il2CppClass<NGUITools>)+BA]");
			object obj24 = (nint)0 & (nint)0x200;
			if (obj24 != null)
			{
				nint num33 = (nint)typeof(NGUITools);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v291 @ S0_v46 (Il2CppClass<NGUITools>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			object obj25 = this + 128;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v229 @ S0_v23 (System.Boolean)+18]");
			int num34 = NGUITools.CalculateNextDepth((GameObject)0, (byte)(int)_scoreboosterPrefab != 0);
			obj25 = num34;
			int layer9 = _scoreboosterUIModel.layer;
			nint num35 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v354 @ S1_v41 (Il2CppClass<UnityEngine.Vector3>)+BA]");
			object obj26 = (nint)0 & (nint)0x200;
			if (obj26 != null)
			{
				nint num36 = (nint)typeof(Vector3);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v385 @ S1_v90 (Il2CppClass<UnityEngine.Vector3>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Vector3 one3 = Vector3.one;
			transform = (Transform)obj3;
			Transform transform12 = transform;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S1_v11+8]");
			((UnityEngine.Object)transform12).m_CachedPtr = (IntPtr)0;
			Vector3 localPosition3 = transform.localPosition;
			int layer10 = _scoreboosterUIModel.layer;
			nint num37 = (nint)typeof(ConsumablesPopup);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v486 @ S1_v51 (Il2CppClass<UI.Popups.ConsumablesPopup>)+BA]");
			object obj27 = (nint)0 & (nint)0x200;
			bool flag7 = obj27 == null;
			nint num38 = (nint)typeof(ConsumablesPopup);
			if (!flag7)
			{
				nint num39 = (nint)typeof(ConsumablesPopup);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v522 @ S1_v84 (Il2CppClass<UI.Popups.ConsumablesPopup>)+74]");
				bool flag8 = (nint)0 == 0;
				bool flag9 = !flag8;
				num38 = (nint)typeof(ConsumablesPopup);
				if (!flag9)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					num38 = (nint)typeof(ConsumablesPopup);
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v526 @ L1_v10 (Il2CppClass<UI.Popups.ConsumablesPopup>)+5C]");
			object obj28 = (nint)0 + (nint)72;
			obj4 = obj28;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v535 @ S2_v26+8]");
			_ = 0;
			transform = (Transform)obj4;
			Transform transform13 = transform;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S1_v13+8]");
			((UnityEngine.Object)transform13).m_CachedPtr = (IntPtr)0;
			Vector3 eulerAngles3 = transform.eulerAngles;
			int layer11 = _scoreboosterUIModel.layer;
			nint num40 = (nint)typeof(ConsumablesPopup);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v569 @ S2_v36 (Il2CppClass<UI.Popups.ConsumablesPopup>)+5C]");
			object obj29 = (nint)0 + (nint)84;
			obj5 = obj29;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v572 @ S2_v38+8]");
			_ = 0;
			nint num41 = (nint)typeof(Quaternion);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v579 @ S1_v64 (Il2CppClass<UnityEngine.Quaternion>)+BA]");
			object obj30 = (nint)0 & (nint)0x200;
			if (obj30 != null)
			{
				nint num42 = (nint)typeof(Quaternion);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v599 @ S1_v80 (Il2CppClass<UnityEngine.Quaternion>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			transform = (Transform)obj5;
			Transform transform14 = transform;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ S1_v15+8]");
			((UnityEngine.Object)transform14).m_CachedPtr = (IntPtr)0;
			Quaternion.Inverse_Injected(ref reference, out *(Quaternion*)transform);
			transform = (Transform)reference;
			Transform transform15 = transform;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ S1_v17 (UnityEngine.Quaternion&)+8]");
			((UnityEngine.Object)transform15).m_CachedPtr = (IntPtr)0;
			Vector3 localScale3 = transform.localScale;
			int layer12 = _scoreboosterUIModel.layer;
			nint num43 = (nint)typeof(ConsumablesPopup);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v627 @ S2_v54 (Il2CppClass<UI.Popups.ConsumablesPopup>)+5C]");
			object obj31 = (nint)0 + (nint)96;
			obj2 = obj31;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v629 @ S2_v56+8]");
			_ = 0;
			transform = (Transform)obj2;
			Transform transform16 = transform;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			((UnityEngine.Object)transform16).m_CachedPtr = (IntPtr)0;
			((Transform)layer12).parent = transform;
		}
		SetupCoinboxes();
	}

	private void Show3DModel(UpgradeType type)
	{
		if (~(isVideoPlaying__BackingField ? 1u : 0u) == 0)
		{
			OnVideoOverlayClosed();
		}
	}

	private void Hide3DModels()
	{
		//IL_03d2: Expected I, but got Obj
		//IL_03e8: Expected Obj, but got I
		//IL_0576: Unknown result type (might be due to invalid IL or missing references)
		//IL_057b: Expected Obj, but got Unknown
		//IL_0127: Expected I, but got Obj
		//IL_013d: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_006f: Expected I, but got Obj
		//IL_0085: Expected Obj, but got I
		//IL_00a2: Expected I, but got Obj
		//IL_027c: Expected I, but got Obj
		//IL_0292: Expected Obj, but got I
		//IL_0168: Expected I, but got Obj
		//IL_041b: Expected Obj, but got I
		//IL_045a: Expected Obj, but got I4
		//IL_01c4: Expected I, but got Obj
		//IL_01da: Expected Obj, but got I
		//IL_01f7: Expected I, but got Obj
		//IL_00be: Expected I, but got Obj
		//IL_00ee: Expected I, but got Obj
		//IL_02bd: Expected I, but got Obj
		//IL_04a2: Expected Obj, but got I
		//IL_04e1: Expected Obj, but got I4
		//IL_0319: Expected I, but got Obj
		//IL_032f: Expected Obj, but got I
		//IL_034c: Expected I, but got Obj
		//IL_0213: Expected I, but got Obj
		//IL_0243: Expected I, but got Obj
		//IL_0114: Expected I, but got Obj
		//IL_0529: Expected Obj, but got I
		//IL_0568: Expected Obj, but got I4
		//IL_0368: Expected I, but got Obj
		//IL_0398: Expected I, but got Obj
		//IL_0269: Expected I, but got Obj
		//IL_03be: Expected I, but got Obj
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v4 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S1_v85 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj2 = default;
		Transform transform = (Transform)(obj2 + 12);
		if (((ComputeShader)(object)_hoverboardUIModel).FindKernel((string)null) != 0)
		{
			int layer = _hoverboardUIModel.layer;
			nint num3 = (nint)typeof(ConsumablesPopup);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ S1_v70 (Il2CppClass<UI.Popups.ConsumablesPopup>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			bool flag = obj3 == null;
			nint num4 = (nint)typeof(ConsumablesPopup);
			if (!flag)
			{
				nint num5 = (nint)typeof(ConsumablesPopup);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ S1_v79 (Il2CppClass<UI.Popups.ConsumablesPopup>)+74]");
				bool flag2 = (nint)0 == 0;
				bool flag3 = !flag2;
				num4 = (nint)typeof(ConsumablesPopup);
				if (!flag3)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					num4 = (nint)typeof(ConsumablesPopup);
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ L1_v11 (Il2CppClass<UI.Popups.ConsumablesPopup>)+5C]");
			object obj4 = (nint)0 + (nint)24;
			obj2 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ S2_v38+8]");
			_ = 0;
			transform = (Transform)obj2;
			Transform transform2 = transform;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			((UnityEngine.Object)transform2).m_CachedPtr = (IntPtr)0;
			((Transform)layer).parent = transform;
		}
		nint num6 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ S1_v13 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num7 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ S1_v64 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)_headstartUIModel).FindKernel((string)null) != 0)
		{
			int layer2 = _headstartUIModel.layer;
			nint num8 = (nint)typeof(ConsumablesPopup);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ S1_v49 (Il2CppClass<UI.Popups.ConsumablesPopup>)+BA]");
			object obj6 = (nint)0 & (nint)0x200;
			bool flag4 = obj6 == null;
			nint num9 = (nint)typeof(ConsumablesPopup);
			if (!flag4)
			{
				nint num10 = (nint)typeof(ConsumablesPopup);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ S1_v58 (Il2CppClass<UI.Popups.ConsumablesPopup>)+74]");
				bool flag5 = (nint)0 == 0;
				bool flag6 = !flag5;
				num9 = (nint)typeof(ConsumablesPopup);
				if (!flag6)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					num9 = (nint)typeof(ConsumablesPopup);
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ L1_v7 (Il2CppClass<UI.Popups.ConsumablesPopup>)+5C]");
			object obj7 = (nint)0 + (nint)60;
			obj2 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v161 @ S2_v26+8]");
			_ = 0;
			transform = (Transform)obj2;
			Transform transform3 = transform;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			((UnityEngine.Object)transform3).m_CachedPtr = (IntPtr)0;
			((Transform)layer2).parent = transform;
		}
		nint num11 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ S1_v20 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj8 = (nint)0 & (nint)0x200;
		if (obj8 != null)
		{
			nint num12 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v140 @ S1_v43 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)_scoreboosterUIModel).FindKernel((string)null) == 0)
		{
			return;
		}
		int layer3 = _scoreboosterUIModel.layer;
		nint num13 = (nint)typeof(ConsumablesPopup);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v193 @ S1_v28 (Il2CppClass<UI.Popups.ConsumablesPopup>)+BA]");
		object obj9 = (nint)0 & (nint)0x200;
		bool flag7 = obj9 == null;
		nint num14 = (nint)typeof(ConsumablesPopup);
		if (!flag7)
		{
			nint num15 = (nint)typeof(ConsumablesPopup);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v199 @ S1_v37 (Il2CppClass<UI.Popups.ConsumablesPopup>)+74]");
			bool flag8 = (nint)0 == 0;
			bool flag9 = !flag8;
			num14 = (nint)typeof(ConsumablesPopup);
			if (!flag9)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				num14 = (nint)typeof(ConsumablesPopup);
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v203 @ L0_v3 (Il2CppClass<UI.Popups.ConsumablesPopup>)+5C]");
		object obj10 = (nint)0 + (nint)96;
		obj2 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v210 @ S2_v14+8]");
		_ = 0;
		transform = (Transform)obj2;
		Transform transform4 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((UnityEngine.Object)transform4).m_CachedPtr = (IntPtr)0;
		((Transform)layer3).parent = transform;
	}

	private void SetupCoinboxes()
	{
		//IL_01b9: Expected Obj, but got I4
		//IL_01c7: Expected I, but got Obj
		//IL_01dd: Expected Obj, but got I
		//IL_0071: Expected I, but got Obj
		//IL_0087: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0110: Expected I, but got Obj
		//IL_0126: Expected Obj, but got I
		//IL_00b2: Expected I, but got Obj
		//IL_0151: Expected I, but got Obj
		bool isInstanced = UIScreenController.IsInstanced;
		((UIModelController)isInstanced).ClearScreenAnchor(UIModelController.ModelScreen.TutorialPopup);
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S1_v4 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S1_v35 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)_hoverboardUIModel).FindKernel((string)null) != 0)
		{
			_hoverboardUIModel.tag = null;
		}
		nint num3 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S1_v11 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ S1_v30 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)_headstartUIModel).FindKernel((string)null) != 0)
		{
			_headstartUIModel.tag = null;
		}
		nint num5 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ S1_v18 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num6 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ S1_v25 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)_scoreboosterUIModel).FindKernel((string)null) != 0)
		{
			_scoreboosterUIModel.tag = null;
		}
	}

	private void HideCoinboxes()
	{
		//IL_00f1: Expected I, but got Obj
		//IL_0107: Expected Obj, but got I
		//IL_0132: Expected I, but got Obj
		//IL_0148: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected Obj, but got Unknown
		//IL_0082: Expected I, but got Obj
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Expected Obj, but got Unknown
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S1_v3 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v27 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (_coinboxFundsEnabled != null)
		{
			object obj2 = this + 132;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120D9");
			object obj3 = default;
			obj2 = obj3;
		}
		nint num3 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ S1_v10 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num4 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ S1_v20 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (_coinboxFundsDisabled != null)
		{
			object obj5 = this + 136;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120D9");
			object obj6 = default;
			obj5 = obj6;
		}
		this._002Ector();
	}

	private IEnumerator PerformAnimation(float delay = 0f)
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

	public ConsumablesPopup()
	{
		//IL_0111: Expected I, but got Obj
		//IL_0127: Expected Obj, but got I
		//IL_0071: Expected I, but got Obj
		//IL_0087: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_00b2: Expected I, but got Obj
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S1_v3 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v22 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)_coinboxFundsEnabled).FindKernel((string)null) != 0)
		{
			_coinboxFundsEnabled.tag = null;
		}
		nint num3 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S1_v10 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ S1_v17 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)_coinboxFundsDisabled).FindKernel((string)null) != 0)
		{
			_coinboxFundsDisabled.tag = null;
		}
	}

	private void _003COnCoinsButtonClicked_003Eb__54_0()
	{
		((UpgradeScreen)this).Start();
	}
}
