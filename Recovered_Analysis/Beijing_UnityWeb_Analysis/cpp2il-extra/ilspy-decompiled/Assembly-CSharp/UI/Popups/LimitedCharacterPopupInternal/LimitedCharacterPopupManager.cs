using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Data.Managers;
using Kiloo;
using SYBO.Subway.Info;
using UI.FreeStuff;
using UI.Pages;
using UI.Popups.LimitedBoardPopupInternal;
using UI.Popups.SettingsPopupInternal;
using UI.Screens.RewardManagement;
using UnityEngine;

namespace UI.Popups.LimitedCharacterPopupInternal;

public class LimitedCharacterPopupManager
{
	private sealed class _003CTimer_003Ed__25(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public float timeLeft;

		public Action handler;

		private float _003CstartPoint_003E5__2;

		object IEnumerator<object>.Current
		{
			get
			{
				//IL_0092: Unknown result type (might be due to invalid IL or missing references)
				//IL_0097: Expected Obj, but got Unknown
				//IL_00a0: Expected Obj, but got I4
				//IL_00b4: Expected Obj, but got I4
				//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
				//IL_00cf: Expected Obj, but got Unknown
				//IL_00d8: Expected Obj, but got I4
				//IL_00ec: Expected Obj, but got I4
				//IL_017b: Unknown result type (might be due to invalid IL or missing references)
				//IL_0180: Expected Obj, but got Unknown
				//IL_0189: Expected Obj, but got I4
				//IL_019d: Expected Obj, but got I4
				if (_003C_003E1__state != 0)
				{
					if (_003C_003E1__state != 1)
					{
						if (_003C_003E1__state != 2)
						{
							if (_003C_003E1__state != 3)
							{
								return null;
							}
							_003C_003E1__state = -1;
						}
						else
						{
							_003C_003E1__state = -1;
							_003CstartPoint_003E5__2 = 0f;
						}
						if (_003CstartPoint_003E5__2 < timeLeft)
						{
							float aspectRatio = Utils.GetAspectRatio();
							float num = _003CstartPoint_003E5__2 + aspectRatio;
							_003CstartPoint_003E5__2 = num;
							object obj = this + 12;
							obj = 0;
							_003C_003E1__state = 3;
							return 1;
						}
						if (handler != null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @78B7");
						}
						return null;
					}
					_003C_003E1__state = -1;
					object obj2 = this + 12;
					obj2 = 0;
					_003C_003E1__state = 2;
					return 1;
				}
				_003C_003E1__state = -1;
				object obj3 = this + 12;
				obj3 = 0;
				_003C_003E1__state = 1;
				return 1;
			}
		}

		object IEnumerator.Current => _003C_003E2__current;

		unsafe void IDisposable.Dispose()
		{
			//IL_0133: Unknown result type (might be due to invalid IL or missing references)
			//IL_0138: Expected Obj, but got Unknown
			//IL_014f: Expected I, but got Obj
			//IL_0165: Expected Obj, but got I
			//IL_022e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0233: Expected VT, but got Unknown
			//IL_0240: Expected F4, but got Obj
			//IL_023b: Expected native int or pointer, but got VT
			//IL_0249: Unknown result type (might be due to invalid IL or missing references)
			//IL_024e: Expected Obj, but got Unknown
			//IL_0268: Expected F4, but got Obj
			//IL_0263: Expected native int or pointer, but got VT
			//IL_027d: Expected F4, but got I
			//IL_0278: Expected native int or pointer, but got VT
			//IL_0283: Unknown result type (might be due to invalid IL or missing references)
			//IL_0288: Expected Obj, but got Unknown
			//IL_0295: Expected Obj, but got F4
			//IL_02ad: Expected I, but got Obj
			//IL_02c3: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			//IL_02e6: Unknown result type (might be due to invalid IL or missing references)
			//IL_02eb: Expected Obj, but got Unknown
			//IL_0060: Expected I, but got Obj
			//IL_00ad: Expected I, but got Obj
			//IL_00c3: Expected Obj, but got I
			//IL_01d5: Unknown result type (might be due to invalid IL or missing references)
			//IL_01da: Expected Obj, but got Unknown
			//IL_01f1: Expected I, but got Obj
			//IL_0207: Expected Obj, but got I
			//IL_00ee: Expected I, but got Obj
			object obj = this + 16;
			obj = "";
			nint num = (nint)typeof(Vector2);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v11 (Il2CppClass<UnityEngine.Vector2>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num2 = (nint)typeof(Vector2);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S0_v71 (Il2CppClass<UnityEngine.Vector2>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Vector2 one = Vector2.one;
			object obj3 = default;
			Vector4 vector = (Vector4)(obj3 + 20);
			((Vector4*)(nint)vector)->x = (float)obj3;
			object obj4 = obj3 + 8;
			Vector3 vector2 = vector;
			((Vector4*)(nint)vector)->x = (float)obj4;
			Vector4 vector3 = vector;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ S0_v19+8]");
			((Vector4*)(nint)vector3)->z = 0f;
			object obj5 = this + 32;
			obj5 = vector.x;
			_ = vector.z;
			nint num3 = (nint)typeof(SettingsButton.SettingsButtonPayload._003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ S0_v26 (Il2CppClass<UI.Popups.SettingsPopupInternal.SettingsButton+SettingsButtonPayload+<>c>)+BA]");
			object obj6 = (nint)0 & (nint)0x200;
			if (obj6 != null)
			{
				nint num4 = (nint)typeof(SettingsButton.SettingsButtonPayload._003C_003Ec);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ S0_v65 (Il2CppClass<UI.Popups.SettingsPopupInternal.SettingsButton+SettingsButtonPayload+<>c>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool flag = SettingsButton.SettingsButtonPayload._003C_003Ec._003C_003E9__10_0 == null;
			bool flag2 = !flag;
			Func<bool> func = SettingsButton.SettingsButtonPayload._003C_003Ec._003C_003E9__10_0;
			if (!flag2)
			{
				nint num5 = (nint)typeof(SettingsButton.SettingsButtonPayload._003C_003Ec);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ S0_v39 (Il2CppClass<UI.Popups.SettingsPopupInternal.SettingsButton+SettingsButtonPayload+<>c>)+BA]");
				object obj7 = (nint)0 & (nint)0x200;
				if (obj7 != null)
				{
					nint num6 = (nint)typeof(SettingsButton.SettingsButtonPayload._003C_003Ec);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ S0_v59 (Il2CppClass<UI.Popups.SettingsPopupInternal.SettingsButton+SettingsButtonPayload+<>c>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				nint num7 = 0;
				_ = 0;
				Func<bool> func2 = default;
				object obj8 = func2 + 16;
				obj8 = SettingsButton.SettingsButtonPayload._003C_003Ec._003C_003E9;
				nint num8 = (nint)typeof(SettingsButton.SettingsButtonPayload._003C_003Ec);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ S0_v56 (Il2CppClass<UI.Popups.SettingsPopupInternal.SettingsButton+SettingsButtonPayload+<>c>)+5C]");
				object obj9 = (nint)0 + (nint)4;
				obj9 = func2;
				func = func2;
			}
			object obj10 = this + 48;
			obj10 = func;
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

	private static Action m_OnLimitedCharacterStartedHandler;

	private static Action m_OnLimitedCharacterExpiredHandler;

	private const Characters.CharacterId CURRENT_CHARACTER = Characters.CharacterId.slick;

	private int currentThemeIndex__BackingField;

	private static LimitedCharacterPopupManager _instance;

	private bool _isInitialized;

	private IEnumerator _startTimerCoroutine;

	private IEnumerator _endTimerCoroutine;

	public Characters.CharacterId currentCharacter
	{
		get
		{
			//IL_0011: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.Popups.LimitedCharacterPopupInternal.LimitedCharacterPopupManager)+24]");
			string tag = ((Component)0).tag;
			return ((GameObject)(object)tag).activeInHierarchy ? Characters.CharacterId.tricky : Characters.CharacterId.slick;
		}
	}

	public int currentThemeIndex
	{
		get
		{
			//IL_00fc: Expected I, but got Obj
			//IL_0112: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			//IL_0060: Expected I, but got Obj
			//IL_0076: Expected Obj, but got I
			//IL_00a1: Expected I, but got Obj
			nint num = (nint)typeof(Globals);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Globals>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(Globals);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v29 (Il2CppClass<Globals>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (~(Globals.DEBUG_LIMITED_CHARACTER_POPUP ? 1u : 0u) == 0)
			{
				nint num3 = (nint)typeof(Globals);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v16 (Il2CppClass<Globals>)+BA]");
				object obj2 = (nint)0 & (nint)0x200;
				if (obj2 != null)
				{
					nint num4 = (nint)typeof(Globals);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S0_v23 (Il2CppClass<Globals>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				return (int)Globals.debugLimitedCharacterPopupId;
			}
			return 0;
		}
		set
		{
			((UILabel)_endTimerCoroutine).fontSize = value;
		}
	}

	public unsafe static LimitedCharacterPopupManager Instance
	{
		get
		{
			//IL_07e4: Unknown result type (might be due to invalid IL or missing references)
			//IL_07e9: Expected Obj, but got Unknown
			//IL_07f2: Expected Obj, but got I4
			//IL_07fb: Unknown result type (might be due to invalid IL or missing references)
			//IL_0800: Expected Obj, but got Unknown
			//IL_0809: Expected Obj, but got I4
			//IL_0817: Expected I, but got Obj
			//IL_082d: Expected Obj, but got I
			//IL_0a78: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a7d: Expected Obj, but got Unknown
			//IL_0a94: Expected Obj, but got I4
			//IL_0ab2: Unknown result type (might be due to invalid IL or missing references)
			//IL_0ab7: Expected VT, but got Unknown
			//IL_0ac4: Expected I4, but got Obj
			//IL_0abf: Expected native int or pointer, but got VT
			//IL_0ada: Unknown result type (might be due to invalid IL or missing references)
			//IL_0adf: Expected Obj, but got Unknown
			//IL_0b03: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b08: Expected Obj, but got Unknown
			//IL_0060: Expected Obj, but got I4
			//IL_0082: Expected I4, but got Obj
			//IL_007d: Expected native int or pointer, but got VT
			//IL_0098: Unknown result type (might be due to invalid IL or missing references)
			//IL_009d: Expected Obj, but got Unknown
			//IL_0013: Expected I, but got Obj
			//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d5: Expected Obj, but got Unknown
			//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ec: Expected Obj, but got Unknown
			//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
			//IL_0103: Expected Obj, but got Unknown
			//IL_0115: Unknown result type (might be due to invalid IL or missing references)
			//IL_011a: Expected Obj, but got Unknown
			//IL_0131: Expected Obj, but got I4
			//IL_0153: Expected I4, but got Obj
			//IL_014e: Expected native int or pointer, but got VT
			//IL_0169: Unknown result type (might be due to invalid IL or missing references)
			//IL_016e: Expected Obj, but got Unknown
			//IL_0189: Unknown result type (might be due to invalid IL or missing references)
			//IL_018e: Expected Obj, but got Unknown
			//IL_01a3: Expected I4, but got Obj
			//IL_019e: Expected native int or pointer, but got VT
			//IL_01ac: Expected Obj, but got VT
			//IL_01b9: Unknown result type (might be due to invalid IL or missing references)
			//IL_01be: Expected Obj, but got Unknown
			//IL_01da: Expected Obj, but got I4
			//IL_01fc: Expected I4, but got Obj
			//IL_01f7: Expected native int or pointer, but got VT
			//IL_0212: Unknown result type (might be due to invalid IL or missing references)
			//IL_0217: Expected Obj, but got Unknown
			//IL_022d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0232: Expected Obj, but got Unknown
			//IL_0247: Expected I4, but got Obj
			//IL_0242: Expected native int or pointer, but got VT
			//IL_0250: Expected Obj, but got VT
			//IL_0262: Unknown result type (might be due to invalid IL or missing references)
			//IL_0267: Expected Obj, but got Unknown
			//IL_027c: Expected I4, but got Obj
			//IL_0277: Expected native int or pointer, but got VT
			//IL_0285: Expected Obj, but got VT
			//IL_0292: Unknown result type (might be due to invalid IL or missing references)
			//IL_0297: Expected Obj, but got Unknown
			//IL_02b3: Expected Obj, but got I4
			//IL_02d5: Expected I4, but got Obj
			//IL_02d0: Expected native int or pointer, but got VT
			//IL_02eb: Unknown result type (might be due to invalid IL or missing references)
			//IL_02f0: Expected Obj, but got Unknown
			//IL_0306: Unknown result type (might be due to invalid IL or missing references)
			//IL_030b: Expected Obj, but got Unknown
			//IL_0320: Expected I4, but got Obj
			//IL_031b: Expected native int or pointer, but got VT
			//IL_0329: Expected Obj, but got VT
			//IL_033b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0340: Expected Obj, but got Unknown
			//IL_0357: Expected Obj, but got I4
			//IL_0379: Expected I4, but got Obj
			//IL_0374: Expected native int or pointer, but got VT
			//IL_038f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0394: Expected Obj, but got Unknown
			//IL_03af: Unknown result type (might be due to invalid IL or missing references)
			//IL_03b4: Expected Obj, but got Unknown
			//IL_03c9: Expected I4, but got Obj
			//IL_03c4: Expected native int or pointer, but got VT
			//IL_03d2: Expected Obj, but got VT
			//IL_03df: Unknown result type (might be due to invalid IL or missing references)
			//IL_03e4: Expected Obj, but got Unknown
			//IL_03f9: Expected I4, but got Obj
			//IL_03f4: Expected native int or pointer, but got VT
			//IL_0402: Expected Obj, but got VT
			//IL_0414: Unknown result type (might be due to invalid IL or missing references)
			//IL_0419: Expected Obj, but got Unknown
			//IL_0430: Expected Obj, but got I4
			//IL_0452: Expected I4, but got Obj
			//IL_044d: Expected native int or pointer, but got VT
			//IL_0468: Unknown result type (might be due to invalid IL or missing references)
			//IL_046d: Expected Obj, but got Unknown
			//IL_0488: Unknown result type (might be due to invalid IL or missing references)
			//IL_048d: Expected Obj, but got Unknown
			//IL_04a2: Expected I4, but got Obj
			//IL_049d: Expected native int or pointer, but got VT
			//IL_04ab: Expected Obj, but got VT
			//IL_04b8: Unknown result type (might be due to invalid IL or missing references)
			//IL_04bd: Expected Obj, but got Unknown
			//IL_04d9: Expected Obj, but got I4
			//IL_04fb: Expected I4, but got Obj
			//IL_04f6: Expected native int or pointer, but got VT
			//IL_051e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0523: Expected Obj, but got Unknown
			//IL_0538: Expected I4, but got Obj
			//IL_0533: Expected native int or pointer, but got VT
			//IL_0545: Expected Obj, but got VT
			//IL_0558: Expected I, but got Obj
			//IL_056e: Expected Obj, but got I
			//IL_0b1f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b24: Expected Obj, but got Unknown
			//IL_0b3a: Expected I, but got Obj
			//IL_0b50: Expected Obj, but got I
			//IL_0599: Expected I, but got Obj
			//IL_05e6: Expected I, but got Obj
			//IL_05fc: Expected Obj, but got I
			//IL_0b76: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b7b: Expected Obj, but got Unknown
			//IL_0b91: Expected I, but got Obj
			//IL_0ba7: Expected Obj, but got I
			//IL_0674: Expected I, but got Obj
			//IL_089d: Unknown result type (might be due to invalid IL or missing references)
			//IL_08a2: Expected Obj, but got Unknown
			//IL_08b9: Expected I, but got Obj
			//IL_08cf: Expected Obj, but got I
			//IL_09bc: Unknown result type (might be due to invalid IL or missing references)
			//IL_09c1: Expected Obj, but got Unknown
			//IL_09d2: Unknown result type (might be due to invalid IL or missing references)
			//IL_09d7: Expected Obj, but got Unknown
			//IL_09ed: Expected I, but got Obj
			//IL_0a03: Expected Obj, but got I
			//IL_06c1: Expected I, but got Obj
			//IL_06d7: Expected Obj, but got I
			//IL_0627: Expected I, but got Obj
			//IL_0a29: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a2e: Expected Obj, but got Unknown
			//IL_0a5c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a61: Expected Obj, but got Unknown
			//IL_074f: Expected I, but got Obj
			//IL_094b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0950: Expected Obj, but got Unknown
			//IL_0967: Expected I, but got Obj
			//IL_097d: Expected Obj, but got I
			//IL_079c: Expected I, but got Obj
			//IL_0702: Expected I, but got Obj
			object obj2 = default;
			object obj = obj2 + 208;
			obj = 0;
			object obj3 = obj2 + 200;
			obj3 = 0;
			nint num = (nint)typeof(ColorData);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S0_v13 (Il2CppClass<UI.ColorData>)+BA]");
			object obj4 = (nint)0 & (nint)0x200;
			if (obj4 != null)
			{
				nint num2 = (nint)typeof(ColorData);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S0_v245 (Il2CppClass<UI.ColorData>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			object obj5 = obj2 + 184;
			bool flag = HoverboardStickerManager.ShouldShowHoverboardStickerFlow();
			object obj6 = (flag ? 1 : 0) + 28;
			obj5 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ S1_v11+8]");
			_ = 0;
			Color32 color = (Color32)(obj2 + 224);
			((Color32*)(nint)color)->rgba = (int)obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S0_v18+8]");
			_ = 0;
			object obj7 = obj2 + 176;
			Color color2 = color;
			obj = obj7;
			_ = -103;
			object obj8 = obj2 + 152;
			bool flag2 = HoverboardStickerManager.ShouldShowHoverboardStickerFlow();
			object obj9 = (flag2 ? 1 : 0) + 268;
			obj8 = obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ S1_v28+8]");
			_ = 0;
			((Color32*)(nint)color)->rgba = (int)obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ S0_v28+8]");
			_ = 0;
			object obj10 = obj2 + 144;
			Color color3 = color;
			obj3 = obj10;
			_ = 102;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			VideoButtonPayload videoButtonPayload = default;
			object obj11 = videoButtonPayload + 12;
			obj11 = "icon_coinPack_3";
			object obj12 = videoButtonPayload + 28;
			obj12 = "COINS_FOR_AD_BUTTON_POPUP_TITLE";
			object obj13 = videoButtonPayload + 32;
			obj13 = "COINS_FOR_AD_BUTTON_DESCRIPTION";
			object obj14 = obj2 + 128;
			bool flag3 = HoverboardStickerManager.ShouldShowHoverboardStickerFlow();
			object obj15 = (flag3 ? 1 : 0) + 92;
			obj14 = obj15;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ S1_v53+8]");
			_ = 0;
			((Color32*)(nint)color)->rgba = (int)obj14;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ S0_v45+8]");
			_ = 0;
			object obj16 = obj2 + 120;
			Color color4 = color;
			object obj17 = obj2 + 220;
			obj17 = obj16;
			((Color32*)(nint)color)->rgba = (int)obj17;
			Color32 firstColorDark = ((VideoButtonPayload)color).firstColorDark;
			object obj18 = obj2 + 104;
			bool flag4 = HoverboardStickerManager.ShouldShowHoverboardStickerFlow();
			object obj19 = (flag4 ? 1 : 0) + 124;
			obj18 = obj19;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v174 @ S1_v72+8]");
			_ = 0;
			((Color32*)(nint)color)->rgba = (int)obj18;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v168 @ S0_v56+8]");
			_ = 0;
			object obj20 = obj2 + 96;
			Color color5 = color;
			object obj21 = obj2 + 216;
			obj21 = obj20;
			((Color32*)(nint)color)->rgba = (int)obj21;
			Color32 firstHighlightColor = ((VideoButtonPayload)color).firstHighlightColor;
			object obj22 = obj2 + 212;
			obj22 = obj;
			((Color32*)(nint)color)->rgba = (int)obj22;
			Color32 secondColor = ((VideoButtonPayload)color).secondColor;
			object obj23 = obj2 + 80;
			bool flag5 = HoverboardStickerManager.ShouldShowHoverboardStickerFlow();
			object obj24 = (flag5 ? 1 : 0) + 316;
			obj23 = obj24;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v227 @ S1_v97+8]");
			_ = 0;
			((Color32*)(nint)color)->rgba = (int)obj23;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v221 @ S0_v71+8]");
			_ = 0;
			object obj25 = obj2 + 72;
			Color color6 = color;
			object obj26 = obj2 + 204;
			obj26 = obj25;
			((Color32*)(nint)color)->rgba = (int)obj26;
			Color32 secondColorDark = ((VideoButtonPayload)color).secondColorDark;
			object obj27 = obj2 + 56;
			bool flag6 = HoverboardStickerManager.ShouldShowHoverboardStickerFlow();
			object obj28 = (flag6 ? 1 : 0) + 556;
			obj27 = obj28;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v267 @ S1_v116+8]");
			_ = 0;
			((Color32*)(nint)color)->rgba = (int)obj27;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v261 @ S0_v82+8]");
			_ = 0;
			object obj29 = obj2 + 48;
			Color color7 = color;
			object obj30 = obj2 + 172;
			obj30 = obj29;
			((Color32*)(nint)color)->rgba = (int)obj30;
			Color32 secondHighlightColor = ((VideoButtonPayload)color).secondHighlightColor;
			object obj31 = obj2 + 168;
			obj31 = obj3;
			((Color32*)(nint)color)->rgba = (int)obj31;
			Color32 titleColor = ((VideoButtonPayload)color).titleColor;
			object obj32 = obj2 + 32;
			bool flag7 = HoverboardStickerManager.ShouldShowHoverboardStickerFlow();
			object obj33 = (flag7 ? 1 : 0) + 268;
			obj32 = obj33;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v320 @ S1_v141+8]");
			_ = 0;
			((Color32*)(nint)color)->rgba = (int)obj32;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v314 @ S0_v97+8]");
			_ = 0;
			object obj34 = obj2 + 24;
			Color color8 = color;
			object obj35 = obj2 + 124;
			obj35 = obj34;
			((Color32*)(nint)color)->rgba = (int)obj35;
			Color32 descriptionColor = ((VideoButtonPayload)color).descriptionColor;
			object obj36 = obj2 + 8;
			bool flag8 = HoverboardStickerManager.ShouldShowHoverboardStickerFlow();
			object obj37 = (flag8 ? 1 : 0) + 604;
			obj36 = obj37;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v360 @ S1_v160+8]");
			_ = 0;
			((Color32*)(nint)color)->rgba = (int)obj36;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v354 @ S0_v108+8]");
			_ = 0;
			Color color9 = color;
			object obj38 = obj2 + 76;
			obj38 = obj2;
			((Color32*)(nint)color)->rgba = (int)obj38;
			videoButtonPayload.flurryName = (string)color;
			nint num3 = (nint)typeof(NotEnoughCurrencyPopup._003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v389 @ S0_v118 (Il2CppClass<UI.Popups.NotEnoughCurrencyPopup+<>c>)+BA]");
			object obj39 = (nint)0 & (nint)0x200;
			if (obj39 != null)
			{
				nint num4 = (nint)typeof(NotEnoughCurrencyPopup._003C_003Ec);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v395 @ S0_v239 (Il2CppClass<UI.Popups.NotEnoughCurrencyPopup+<>c>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool flag9 = NotEnoughCurrencyPopup._003C_003Ec._003C_003E9__44_0 == null;
			bool flag10 = !flag9;
			Func<bool> func = NotEnoughCurrencyPopup._003C_003Ec._003C_003E9__44_0;
			if (!flag10)
			{
				nint num5 = (nint)typeof(NotEnoughCurrencyPopup._003C_003Ec);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v412 @ S0_v213 (Il2CppClass<UI.Popups.NotEnoughCurrencyPopup+<>c>)+BA]");
				object obj40 = (nint)0 & (nint)0x200;
				if (obj40 != null)
				{
					nint num6 = (nint)typeof(NotEnoughCurrencyPopup._003C_003Ec);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v444 @ S0_v233 (Il2CppClass<UI.Popups.NotEnoughCurrencyPopup+<>c>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				nint num7 = 0;
				_ = 0;
				Func<bool> func2 = default;
				object obj41 = func2 + 16;
				obj41 = NotEnoughCurrencyPopup._003C_003Ec._003C_003E9;
				nint num8 = (nint)typeof(NotEnoughCurrencyPopup._003C_003Ec);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v487 @ S0_v230 (Il2CppClass<UI.Popups.NotEnoughCurrencyPopup+<>c>)+5C]");
				object obj42 = (nint)0 + (nint)4;
				obj42 = func2;
				func = func2;
			}
			object obj43 = videoButtonPayload + 20;
			obj43 = func;
			nint num9 = (nint)typeof(NotEnoughCurrencyPopup._003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v437 @ S0_v130 (Il2CppClass<UI.Popups.NotEnoughCurrencyPopup+<>c>)+BA]");
			object obj44 = (nint)0 & (nint)0x200;
			if (obj44 != null)
			{
				nint num10 = (nint)typeof(NotEnoughCurrencyPopup._003C_003Ec);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v458 @ S0_v206 (Il2CppClass<UI.Popups.NotEnoughCurrencyPopup+<>c>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool flag11 = NotEnoughCurrencyPopup._003C_003Ec._003C_003E9__44_1 == null;
			bool flag12 = !flag11;
			Action action = NotEnoughCurrencyPopup._003C_003Ec._003C_003E9__44_1;
			if (!flag12)
			{
				nint num11 = (nint)typeof(NotEnoughCurrencyPopup._003C_003Ec);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v492 @ S0_v183 (Il2CppClass<UI.Popups.NotEnoughCurrencyPopup+<>c>)+BA]");
				object obj45 = (nint)0 & (nint)0x200;
				if (obj45 != null)
				{
					nint num12 = (nint)typeof(NotEnoughCurrencyPopup._003C_003Ec);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v525 @ S0_v200 (Il2CppClass<UI.Popups.NotEnoughCurrencyPopup+<>c>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				nint method_ptr = 0;
				Action action2 = default;
				((Delegate)action2).method_ptr = method_ptr;
				((Delegate)action2).method = (nint)__ldftn(NotEnoughCurrencyPopup._003C_003Ec._003CCreateButtonPayload_003Eb__44_1);
				object obj46 = action2 + 16;
				obj46 = NotEnoughCurrencyPopup._003C_003Ec._003C_003E9;
				nint num13 = (nint)typeof(NotEnoughCurrencyPopup._003C_003Ec);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v559 @ S0_v197 (Il2CppClass<UI.Popups.NotEnoughCurrencyPopup+<>c>)+5C]");
				object obj47 = (nint)0 + (nint)8;
				obj47 = action2;
				action = action2;
			}
			object obj48 = videoButtonPayload + 16;
			obj48 = action;
			nint num14 = (nint)typeof(CoinsForVideoManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v517 @ S0_v142 (Il2CppClass<CoinsForVideoManager>)+BA]");
			object obj49 = (nint)0 & (nint)0x200;
			if (obj49 != null)
			{
				nint num15 = (nint)typeof(CoinsForVideoManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v539 @ S0_v178 (Il2CppClass<CoinsForVideoManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			CountdownPopupManager instance = CountdownPopupManager.Instance;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num16 = 0;
			_ = 0;
			object obj51 = default;
			object obj50 = obj51 + 16;
			obj50 = instance;
			object obj52 = videoButtonPayload + 24;
			obj52 = obj51;
			nint num17 = (nint)typeof(AdLocations);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v587 @ S0_v160 (Il2CppClass<AdLocations>)+BA]");
			object obj53 = (nint)0 & (nint)0x200;
			if (obj53 != null)
			{
				nint num18 = (nint)typeof(AdLocations);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v593 @ S0_v172 (Il2CppClass<AdLocations>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			object obj54 = videoButtonPayload + 36;
			obj54 = AdLocations.FREE_COINS_POPUP_VIDEOS;
			videoButtonPayload.rewardType__BackingField = CelebrationRewardType.coins;
			videoButtonPayload.unlockItemSource__BackingField = UnlockItemSource.NotEnoughCurrencyPopup;
			object obj55 = videoButtonPayload + 84;
			obj55 = "Coins";
			return (LimitedCharacterPopupManager)(object)videoButtonPayload;
		}
	}

	public static event Action OnLimitedCharacterStartedHandler
	{
		add
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F4C1");
		}
		remove
		{
			//IL_00ca: Expected I, but got Obj
			//IL_00e0: Expected Obj, but got I
			//IL_014e: Expected I, but got Obj
			//IL_0164: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			//IL_0060: Expected I, but got Obj
			nint num = (nint)typeof(LimitedCharacterPopupManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UI.Popups.LimitedCharacterPopupInternal.LimitedCharacterPopupManager>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(LimitedCharacterPopupManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v33 (Il2CppClass<UI.Popups.LimitedCharacterPopupInternal.LimitedCharacterPopupManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Delegate onLimitedCharacterStartedHandler = LimitedCharacterPopupManager.m_OnLimitedCharacterStartedHandler;
			Action onLimitedCharacterStartedHandler2 = default;
			while (true)
			{
				Delegate obj2 = onLimitedCharacterStartedHandler.CombineImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				nint num3 = (nint)typeof(LimitedCharacterPopupManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v18 (Il2CppClass<UI.Popups.LimitedCharacterPopupInternal.LimitedCharacterPopupManager>)+BA]");
				object obj3 = (nint)0 & (nint)0x200;
				if (obj3 != null)
				{
					nint num4 = (nint)typeof(LimitedCharacterPopupManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v27 (Il2CppClass<UI.Popups.LimitedCharacterPopupInternal.LimitedCharacterPopupManager>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				if ((object)LimitedCharacterPopupManager.m_OnLimitedCharacterStartedHandler == onLimitedCharacterStartedHandler)
				{
					LimitedCharacterPopupManager.m_OnLimitedCharacterStartedHandler = onLimitedCharacterStartedHandler2;
				}
				if ((object)LimitedCharacterPopupManager.m_OnLimitedCharacterStartedHandler != onLimitedCharacterStartedHandler)
				{
					onLimitedCharacterStartedHandler = LimitedCharacterPopupManager.m_OnLimitedCharacterStartedHandler;
					continue;
				}
				break;
			}
		}
	}

	public static event Action OnLimitedCharacterExpiredHandler
	{
		add
		{
			//IL_00ca: Expected I, but got Obj
			//IL_00e0: Expected Obj, but got I
			//IL_014e: Expected I, but got Obj
			//IL_0164: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			//IL_0060: Expected I, but got Obj
			nint num = (nint)typeof(LimitedCharacterPopupManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UI.Popups.LimitedCharacterPopupInternal.LimitedCharacterPopupManager>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(LimitedCharacterPopupManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v33 (Il2CppClass<UI.Popups.LimitedCharacterPopupInternal.LimitedCharacterPopupManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Delegate onLimitedCharacterStartedHandler = LimitedCharacterPopupManager.m_OnLimitedCharacterStartedHandler;
			Action onLimitedCharacterStartedHandler2 = default;
			while (true)
			{
				Delegate obj2 = onLimitedCharacterStartedHandler.RemoveImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				nint num3 = (nint)typeof(LimitedCharacterPopupManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v18 (Il2CppClass<UI.Popups.LimitedCharacterPopupInternal.LimitedCharacterPopupManager>)+BA]");
				object obj3 = (nint)0 & (nint)0x200;
				if (obj3 != null)
				{
					nint num4 = (nint)typeof(LimitedCharacterPopupManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v27 (Il2CppClass<UI.Popups.LimitedCharacterPopupInternal.LimitedCharacterPopupManager>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				if ((object)LimitedCharacterPopupManager.m_OnLimitedCharacterStartedHandler == onLimitedCharacterStartedHandler)
				{
					LimitedCharacterPopupManager.m_OnLimitedCharacterStartedHandler = onLimitedCharacterStartedHandler2;
				}
				if ((object)LimitedCharacterPopupManager.m_OnLimitedCharacterStartedHandler != onLimitedCharacterStartedHandler)
				{
					onLimitedCharacterStartedHandler = LimitedCharacterPopupManager.m_OnLimitedCharacterStartedHandler;
					continue;
				}
				break;
			}
		}
		remove
		{
			//IL_00e4: Expected I, but got Obj
			//IL_00fa: Expected Obj, but got I
			//IL_017d: Expected I, but got Obj
			//IL_0193: Expected Obj, but got I
			//IL_01b0: Expected I, but got Obj
			//IL_0013: Expected I, but got Obj
			//IL_012d: Expected Obj, but got I
			//IL_0060: Expected I, but got Obj
			//IL_0090: Expected I, but got Obj
			//IL_00b6: Expected I, but got Obj
			nint num = (nint)typeof(LimitedCharacterPopupManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UI.Popups.LimitedCharacterPopupInternal.LimitedCharacterPopupManager>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(LimitedCharacterPopupManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v34 (Il2CppClass<UI.Popups.LimitedCharacterPopupInternal.LimitedCharacterPopupManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Delegate obj2 = LimitedCharacterPopupManager.m_OnLimitedCharacterExpiredHandler;
			object obj6 = default;
			while (true)
			{
				Delegate obj3 = obj2.CombineImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				nint num3 = (nint)typeof(LimitedCharacterPopupManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v18 (Il2CppClass<UI.Popups.LimitedCharacterPopupInternal.LimitedCharacterPopupManager>)+BA]");
				object obj4 = (nint)0 & (nint)0x200;
				bool flag = obj4 == null;
				nint num4 = (nint)typeof(LimitedCharacterPopupManager);
				if (!flag)
				{
					nint num5 = (nint)typeof(LimitedCharacterPopupManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v28 (Il2CppClass<UI.Popups.LimitedCharacterPopupInternal.LimitedCharacterPopupManager>)+74]");
					bool flag2 = (nint)0 == 0;
					bool flag3 = !flag2;
					num4 = (nint)typeof(LimitedCharacterPopupManager);
					if (!flag3)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						num4 = (nint)typeof(LimitedCharacterPopupManager);
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ L1_v5 (Il2CppClass<UI.Popups.LimitedCharacterPopupInternal.LimitedCharacterPopupManager>)+5C]");
				object obj5 = (nint)0 + (nint)4;
				if (obj5 == obj2)
				{
					obj5 = obj6;
				}
				if (obj5 != obj2)
				{
					obj2 = (Delegate)obj5;
					continue;
				}
				break;
			}
		}
	}

	private LimitedCharacterPopupManager()
	{
		//IL_00e4: Expected I, but got Obj
		//IL_00fa: Expected Obj, but got I
		//IL_017a: Expected I, but got Obj
		//IL_0190: Expected Obj, but got I
		//IL_01ad: Expected I, but got Obj
		//IL_0013: Expected I, but got Obj
		//IL_012d: Expected Obj, but got I
		//IL_0060: Expected I, but got Obj
		//IL_0090: Expected I, but got Obj
		//IL_00b6: Expected I, but got Obj
		nint num = (nint)typeof(LimitedCharacterPopupManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UI.Popups.LimitedCharacterPopupInternal.LimitedCharacterPopupManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(LimitedCharacterPopupManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v34 (Il2CppClass<UI.Popups.LimitedCharacterPopupInternal.LimitedCharacterPopupManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Delegate obj2 = LimitedCharacterPopupManager.m_OnLimitedCharacterExpiredHandler;
		object obj6 = default;
		while (true)
		{
			Delegate obj3 = obj2.RemoveImpl((Delegate)(object)this);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
			nint num3 = (nint)typeof(LimitedCharacterPopupManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v18 (Il2CppClass<UI.Popups.LimitedCharacterPopupInternal.LimitedCharacterPopupManager>)+BA]");
			object obj4 = (nint)0 & (nint)0x200;
			bool flag = obj4 == null;
			nint num4 = (nint)typeof(LimitedCharacterPopupManager);
			if (!flag)
			{
				nint num5 = (nint)typeof(LimitedCharacterPopupManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v28 (Il2CppClass<UI.Popups.LimitedCharacterPopupInternal.LimitedCharacterPopupManager>)+74]");
				bool flag2 = (nint)0 == 0;
				bool flag3 = !flag2;
				num4 = (nint)typeof(LimitedCharacterPopupManager);
				if (!flag3)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					num4 = (nint)typeof(LimitedCharacterPopupManager);
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ L1_v5 (Il2CppClass<UI.Popups.LimitedCharacterPopupInternal.LimitedCharacterPopupManager>)+5C]");
			object obj5 = (nint)0 + (nint)4;
			if (obj5 == obj2)
			{
				obj5 = obj6;
			}
			if (obj5 != obj2)
			{
				obj2 = (Delegate)obj5;
				continue;
			}
			break;
		}
	}

	private void Initialize()
	{
		if (~(_isInitialized ? 1u : 0u) != 0)
		{
			StartTimer();
		}
	}

	public bool IsCharacterAvailable()
	{
		return (byte)currentThemeIndex__BackingField != 0;
	}

	public bool ShouldButtonBeVisible()
	{
		//IL_0250: Unknown result type (might be due to invalid IL or missing references)
		//IL_0255: Expected Obj, but got Unknown
		//IL_025e: Expected Obj, but got I4
		//IL_026c: Expected I, but got Obj
		//IL_0282: Expected Obj, but got I
		//IL_0312: Unknown result type (might be due to invalid IL or missing references)
		//IL_0317: Expected Obj, but got Unknown
		//IL_0320: Unknown result type (might be due to invalid IL or missing references)
		//IL_0325: Expected Obj, but got Unknown
		//IL_0078: Expected I, but got Obj
		//IL_008e: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0109: Expected Obj, but got VT
		//IL_0111: Expected Obj, but got VT
		//IL_0126: Unknown result type (might be due to invalid IL or missing references)
		//IL_012b: Expected Obj, but got Unknown
		//IL_0138: Unknown result type (might be due to invalid IL or missing references)
		//IL_013d: Expected Obj, but got Unknown
		//IL_00b9: Expected I, but got Obj
		//IL_018e: Expected Obj, but got I4
		//IL_016d: Expected Obj, but got I4
		//IL_01a9: Expected Obj, but got VT
		//IL_01be: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c3: Expected Obj, but got Unknown
		//IL_01d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d5: Expected Obj, but got Unknown
		//IL_0226: Expected Obj, but got I4
		//IL_0205: Expected Obj, but got I4
		object obj2 = default;
		object obj = obj2 + 16;
		obj = 0;
		nint num = (nint)typeof(Globals);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11 (Il2CppClass<Globals>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num2 = (nint)typeof(Globals);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v58 (Il2CppClass<Globals>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj4 = obj2 + 24;
		object obj5 = obj2 + 8;
		if (~(Globals.DEBUG_LIMITED_CHARACTER_POPUP_IGNORE_EXPIRE ? 1u : 0u) == 0)
		{
			return true;
		}
		int characterId = ((LimitedCharacterPopupManager)null).currentThemeIndex;
		nint num3 = (nint)typeof(CharacterManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ S1_v12 (Il2CppClass<Data.Managers.CharacterManager>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num4 = (nint)typeof(CharacterManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ S1_v45 (Il2CppClass<Data.Managers.CharacterManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		TimeSpan timeSpan = CharacterManager.CharacterExpirationTimespan((Characters.CharacterId)characterId);
		int characterId2 = ((LimitedCharacterPopupManager)null).currentThemeIndex;
		DateTime dateTime = CharacterManager.CharacterStartAvailabilityDate((Characters.CharacterId)characterId2);
		DateTime utcNow = CDateTime.UtcNow;
		obj = utcNow;
		obj5 = timeSpan;
		obj4 = obj5;
		object obj7 = obj & 0x3FFFFFFFFFFFFFFFL;
		object obj8 = obj4 & 0x3FFFFFFFFFFFFFFFL;
		object obj9;
		if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj7) > System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj8))
		{
			obj9 = 1;
		}
		else
		{
			bool flag = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj7) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj8);
			object obj10 = (flag ? 1u : 0u) << 31;
			obj9 = obj10 >> 31;
		}
		if ((nint)obj9 > 0)
		{
			obj2 = dateTime;
			obj4 = obj2;
			object obj11 = obj & 0x3FFFFFFFFFFFFFFFL;
			object obj12 = obj4 & 0x3FFFFFFFFFFFFFFFL;
			object obj13;
			if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj11) > System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj12))
			{
				obj13 = 1;
			}
			else
			{
				bool flag2 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj11) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj12);
				object obj14 = (flag2 ? 1u : 0u) << 31;
				obj13 = obj14 >> 31;
			}
			return (nint)obj13 < 0;
		}
		return false;
	}

	public bool CurrentlyShownCharacterMatchesEventItem()
	{
		//IL_008c: Expected I, but got Obj
		//IL_00a2: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		int characterId = ((LimitedCharacterPopupManager)null).currentThemeIndex;
		nint num = (nint)typeof(CharacterManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S1_v4 (Il2CppClass<Data.Managers.CharacterManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(CharacterManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v11 (Il2CppClass<Data.Managers.CharacterManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (CharacterManager.IsCollectionComplete((Characters.CharacterId)characterId))
		{
			return false;
		}
		return ((LimitedCharacterPopupManager)null).ShouldButtonBeVisible();
	}

	private unsafe void StartTimer()
	{
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected Obj, but got Unknown
		//IL_0052: Expected I, but got Obj
		//IL_0068: Expected Obj, but got I
		//IL_0093: Expected I, but got Obj
		if (~(_isInitialized ? 1u : 0u) == 0)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr = 0;
		Action action = default;
		((Delegate)action).method_ptr = method_ptr;
		((Delegate)action).method = (nint)__ldftn(LimitedCharacterPopupManager.StartTimer);
		object obj = action + 16;
		obj = this;
		nint num = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S0_v16 (Il2CppClass<UIScreenController>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S0_v23 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		UIScreenController.OnApplicationResumed -= action;
		LimitedBoardPopupManager.OnLimitedBoardStartedHandler += (Action)(object)this;
		_isInitialized = true;
	}

	private IEnumerator Timer(float timeLeft, Action handler)
	{
		//IL_006e: Expected I4, but got Obj
		//IL_0018: Expected Obj, but got I4
		string tag = ((Component)this).tag;
		TweenWidth tweenWidth = UITweener.Begin<TweenWidth>((GameObject)(object)tag, timeLeft);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.Popups.LimitedCharacterPopupInternal.LimitedCharacterPopupManager)+64]");
		tweenWidth.from = 0;
		tweenWidth.to = (int)handler;
		if (!(timeLeft > 0f))
		{
			((PageTop)(object)tweenWidth).Delay(1f, (Action)1);
			tweenWidth.tag = null;
		}
		return (IEnumerator)tweenWidth;
	}
}
