using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2ILInjected;
using UI.Screens;
using UnityEngine;

public class HoverboardCustomizationPopup : UIScreen
{
	private sealed class _003CDelayPositioning_003Ed__41(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public GameObject modelHost;

		public HoverboardCustomizationPopup _003C_003E4__this;

		public GameObject modelToPosition;

		public Vector3 offset;

		public Vector3 rotation;

		public Vector3 scale;

		object IEnumerator<object>.Current => _003C_003E2__current;

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d8: Expected VT, but got Unknown
			//IL_0132: Unknown result type (might be due to invalid IL or missing references)
			//IL_0137: Expected VT, but got Unknown
			//IL_01d4: Expected Obj, but got VT
			//IL_01dd: Unknown result type (might be due to invalid IL or missing references)
			//IL_01e2: Expected Obj, but got Unknown
			//IL_01eb: Unknown result type (might be due to invalid IL or missing references)
			//IL_01f0: Expected Obj, but got Unknown
			//IL_01f9: Unknown result type (might be due to invalid IL or missing references)
			//IL_01fe: Expected Obj, but got Unknown
			object obj2 = default;
			object obj = obj2 - 160;
			_ = 0;
			_ = 0;
			if (_003C_003E1__state != 0)
			{
				if (_003C_003E1__state == 1)
				{
					_003C_003E1__state = -1;
					Transform transform = modelHost.transform;
					Vector3 position = transform.position;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+88]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+80]");
					_ = 0;
					UIScreenController instance = UIScreenController.Instance;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+98]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+90]");
					_ = 0;
					Vector3 position2 = (Vector3)(obj + 80);
					Vector3 vector = instance.Camera2DNormal.WorldToScreenPoint(position2);
					UIScreenController instance2 = UIScreenController.Instance;
					_ = 1077936128;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+68]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+80]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+60]");
					_ = 0;
					Vector3 position3 = (Vector3)(obj - -64);
					Vector3 vector2 = instance2.Camera3D.ScreenToWorldPoint(position3);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+78]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+70]");
					_ = 0;
					Transform transform2 = modelToPosition.transform;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+88]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+80]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (HoverboardCustomizationPopup+<DelayPositioning>d__41)+24]");
					_ = 0;
					_ = offset;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (HoverboardCustomizationPopup+<DelayPositioning>d__41)+30]");
					_ = 0;
					_ = rotation;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (HoverboardCustomizationPopup+<DelayPositioning>d__41)+3C]");
					_ = 0;
					obj = scale;
					object obj3 = obj + 48;
					object obj4 = obj + 32;
					object obj5 = obj + 16;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1CEC");
				}
			}
			else
			{
				_003C_003E1__state = -1;
				object obj6 = default;
				_003C_003E2__current = obj6;
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

	private UILabel title1;

	private UILabel title2;

	private UISprite container1;

	private UISprite container1Arrow;

	private UISprite container1Glow;

	private UISprite container2;

	private UISprite container2Footer;

	private UILabel board1Power;

	private UISprite container2Arrow;

	private UISprite container2Glow;

	private UISprite container3;

	private UISprite container3Footer;

	private UILabel board2Power;

	private UISprite container3Arrow;

	private UISprite container3Glow;

	private UISprite container4;

	private UISprite container4Glow;

	private GameObject boardModelPrefab;

	private GameObject theme1ModelPrefab;

	private GameObject theme2ModelPrefab;

	private GameObject bothThemesModelPrefab;

	private UISprite[] lightRays;

	private GameObject _boardModel;

	private GameObject _theme1Model;

	private GameObject _theme2Model;

	private GameObject _bothThemesModel;

	private static readonly Vector3 BOARD_MODEL_POSITION_OFFSET;

	private static readonly Vector3 BOARD_MODEL_ROTATION;

	private static readonly Vector3 BOARD_MODEL_SCALE;

	private static readonly Vector3 THEME1_POSITION_OFFSET;

	private static readonly Vector3 THEME1_ROTATION;

	private static readonly Vector3 THEME1_SCALE;

	private static readonly Vector3 THEME2_POSITION_OFFSET;

	private static readonly Vector3 THEME2_ROTATION;

	private static readonly Vector3 THEME2_SCALE;

	private static readonly Vector3 BOTH_THEMES_MODEL_POSITION_OFFSET;

	private static readonly Vector3 BOTH_THEMES_MODEL_ROTATION;

	private static readonly Vector3 BOTH_THEMES_MODEL_SCALE;

	public unsafe override void Show()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0044: Expected Obj, but got VT
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected Obj, but got Unknown
		//IL_0076: Expected Obj, but got VT
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Expected Obj, but got Unknown
		//IL_00cb: Expected Obj, but got VT
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Expected Obj, but got Unknown
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Expected VT, but got Unknown
		//IL_012c: Expected Obj, but got VT
		//IL_0135: Unknown result type (might be due to invalid IL or missing references)
		//IL_013a: Expected Obj, but got Unknown
		//IL_015e: Expected Obj, but got VT
		//IL_018a: Unknown result type (might be due to invalid IL or missing references)
		//IL_018f: Expected Obj, but got Unknown
		//IL_01b3: Expected Obj, but got VT
		//IL_01bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c1: Expected Obj, but got Unknown
		//IL_01ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f1: Expected VT, but got Unknown
		//IL_020f: Expected Obj, but got VT
		//IL_0218: Unknown result type (might be due to invalid IL or missing references)
		//IL_021d: Expected Obj, but got Unknown
		//IL_0241: Expected Obj, but got VT
		//IL_026d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0272: Expected Obj, but got Unknown
		//IL_0296: Expected Obj, but got VT
		//IL_029f: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a4: Expected Obj, but got Unknown
		//IL_02cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d4: Expected VT, but got Unknown
		//IL_02f7: Expected Obj, but got VT
		//IL_0300: Unknown result type (might be due to invalid IL or missing references)
		//IL_0305: Expected Obj, but got Unknown
		//IL_0329: Expected Obj, but got VT
		//IL_0355: Unknown result type (might be due to invalid IL or missing references)
		//IL_035a: Expected Obj, but got Unknown
		//IL_037e: Expected Obj, but got VT
		//IL_0387: Unknown result type (might be due to invalid IL or missing references)
		//IL_038c: Expected Obj, but got Unknown
		//IL_03b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03bc: Expected VT, but got Unknown
		//IL_03fc: Expected Obj, but got VT
		//IL_0405: Unknown result type (might be due to invalid IL or missing references)
		//IL_040a: Expected Obj, but got Unknown
		//IL_042e: Expected Obj, but got VT
		//IL_045a: Unknown result type (might be due to invalid IL or missing references)
		//IL_045f: Expected Obj, but got Unknown
		//IL_0483: Expected Obj, but got VT
		//IL_048c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0491: Expected Obj, but got Unknown
		//IL_04bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c1: Expected VT, but got Unknown
		//IL_04e4: Expected Obj, but got VT
		//IL_04ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f2: Expected Obj, but got Unknown
		//IL_0516: Expected Obj, but got VT
		//IL_0542: Unknown result type (might be due to invalid IL or missing references)
		//IL_0547: Expected Obj, but got Unknown
		//IL_056b: Expected Obj, but got VT
		//IL_0574: Unknown result type (might be due to invalid IL or missing references)
		//IL_0579: Expected Obj, but got Unknown
		//IL_05a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a9: Expected VT, but got Unknown
		//IL_05c7: Expected Obj, but got VT
		//IL_05d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d5: Expected Obj, but got Unknown
		//IL_05f9: Expected Obj, but got VT
		//IL_0625: Unknown result type (might be due to invalid IL or missing references)
		//IL_062a: Expected Obj, but got Unknown
		//IL_064e: Expected Obj, but got VT
		//IL_0657: Unknown result type (might be due to invalid IL or missing references)
		//IL_065c: Expected Obj, but got Unknown
		//IL_0687: Unknown result type (might be due to invalid IL or missing references)
		//IL_068c: Expected VT, but got Unknown
		//IL_06d1: Expected Obj, but got VT
		//IL_06da: Unknown result type (might be due to invalid IL or missing references)
		//IL_06df: Expected Obj, but got Unknown
		//IL_0703: Expected Obj, but got VT
		//IL_072f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0734: Expected Obj, but got Unknown
		//IL_0758: Expected Obj, but got VT
		//IL_0761: Unknown result type (might be due to invalid IL or missing references)
		//IL_0766: Expected Obj, but got Unknown
		//IL_0791: Unknown result type (might be due to invalid IL or missing references)
		//IL_0796: Expected VT, but got Unknown
		//IL_07b4: Expected Obj, but got VT
		//IL_07bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_07c2: Expected Obj, but got Unknown
		//IL_07e6: Expected Obj, but got VT
		//IL_0812: Unknown result type (might be due to invalid IL or missing references)
		//IL_0817: Expected Obj, but got Unknown
		//IL_083b: Expected Obj, but got VT
		//IL_0844: Unknown result type (might be due to invalid IL or missing references)
		//IL_0849: Expected Obj, but got Unknown
		//IL_0874: Unknown result type (might be due to invalid IL or missing references)
		//IL_0879: Expected VT, but got Unknown
		//IL_08a0: Expected Obj, but got I4
		//IL_08cf: Expected Obj, but got VT
		//IL_08d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_08dd: Expected Obj, but got Unknown
		//IL_0901: Expected Obj, but got VT
		//IL_092b: Expected F4, but got I
		//IL_0926: Expected native int or pointer, but got VT
		//IL_0935: Unknown result type (might be due to invalid IL or missing references)
		//IL_093a: Expected Obj, but got Unknown
		//IL_095e: Expected Obj, but got VT
		//IL_0967: Unknown result type (might be due to invalid IL or missing references)
		//IL_096c: Expected Obj, but got Unknown
		//IL_0996: Expected F4, but got I
		//IL_0991: Expected native int or pointer, but got VT
		//IL_09ab: Expected Obj, but got I
		//IL_09b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_09be: Expected Obj, but got Unknown
		object obj = default;
		Color color = (Color)(obj - 320);
		string text = Strings.Get(StringID.HOVERBOARD_CUSTOMIZATION_POPUP_TITLE1);
		title1.text = text;
		string text2 = Strings.Get(StringID.HOVERBOARD_CUSTOMIZATION_POPUP_TITLE2);
		title2.text = text2;
		object obj2 = GlobalColors.HOVERBOARD_CUSTOMIZATION_POPUP_BOARD_THEME_FOOTER_COLOR >> 16;
		object obj3 = obj2 & 0xFF;
		float num = (float)obj3 / 255f;
		object obj4 = GlobalColors.HOVERBOARD_CUSTOMIZATION_POPUP_BOARD_THEME_FOOTER_COLOR >> 24;
		float num2 = (float)obj4 / 255f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+138]");
		_ = 0;
		object obj5 = GlobalColors.HOVERBOARD_CUSTOMIZATION_POPUP_BOARD_THEME_FOOTER_COLOR & 0xFF;
		float num3 = (float)obj5 / 255f;
		object obj6 = GlobalColors.HOVERBOARD_CUSTOMIZATION_POPUP_BOARD_THEME_FOOTER_COLOR >> 8;
		object obj7 = obj6 & 0xFF;
		float num4 = (float)obj7 / 255f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+130]");
		_ = 0;
		Color color2 = color + 144;
		container1.color = color2;
		object obj8 = GlobalColors.HOVERBOARD_CUSTOMIZATION_POPUP_BOARD_THEME_FOOTER_COLOR >> 16;
		object obj9 = obj8 & 0xFF;
		float num5 = (float)obj9 / 255f;
		object obj10 = GlobalColors.HOVERBOARD_CUSTOMIZATION_POPUP_BOARD_THEME_FOOTER_COLOR >> 24;
		float num6 = (float)obj10 / 255f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+128]");
		_ = 0;
		object obj11 = GlobalColors.HOVERBOARD_CUSTOMIZATION_POPUP_BOARD_THEME_FOOTER_COLOR & 0xFF;
		float num7 = (float)obj11 / 255f;
		object obj12 = GlobalColors.HOVERBOARD_CUSTOMIZATION_POPUP_BOARD_THEME_FOOTER_COLOR >> 8;
		object obj13 = obj12 & 0xFF;
		float num8 = (float)obj13 / 255f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+120]");
		_ = 0;
		Color color3 = color + 128;
		container1Arrow.color = color3;
		object obj14 = GlobalColors.HOVERBOARD_CUSTOMIZATION_POPUP_BOARD_THEME_CONTAINER_COLOR >> 16;
		object obj15 = obj14 & 0xFF;
		float num9 = (float)obj15 / 255f;
		object obj16 = GlobalColors.HOVERBOARD_CUSTOMIZATION_POPUP_BOARD_THEME_CONTAINER_COLOR >> 24;
		float num10 = (float)obj16 / 255f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+118]");
		_ = 0;
		object obj17 = GlobalColors.HOVERBOARD_CUSTOMIZATION_POPUP_BOARD_THEME_CONTAINER_COLOR & 0xFF;
		float num11 = (float)obj17 / 255f;
		object obj18 = GlobalColors.HOVERBOARD_CUSTOMIZATION_POPUP_BOARD_THEME_CONTAINER_COLOR >> 8;
		object obj19 = obj18 & 0xFF;
		float num12 = (float)obj19 / 255f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+110]");
		_ = 0;
		Color color4 = color + 112;
		container2.color = color4;
		object obj20 = GlobalColors.HOVERBOARD_CUSTOMIZATION_POPUP_BOARD_THEME_FOOTER_COLOR >> 16;
		object obj21 = obj20 & 0xFF;
		float num13 = (float)obj21 / 255f;
		object obj22 = GlobalColors.HOVERBOARD_CUSTOMIZATION_POPUP_BOARD_THEME_FOOTER_COLOR >> 24;
		float num14 = (float)obj22 / 255f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+108]");
		_ = 0;
		object obj23 = GlobalColors.HOVERBOARD_CUSTOMIZATION_POPUP_BOARD_THEME_FOOTER_COLOR & 0xFF;
		float num15 = (float)obj23 / 255f;
		object obj24 = GlobalColors.HOVERBOARD_CUSTOMIZATION_POPUP_BOARD_THEME_FOOTER_COLOR >> 8;
		object obj25 = obj24 & 0xFF;
		float num16 = (float)obj25 / 255f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+100]");
		_ = 0;
		Color color5 = color + 96;
		container2Footer.color = color5;
		string text3 = Strings.Get(StringID.HOVERBOARD_THEME_HERO_TELEPORT_TITLE);
		board1Power.text = text3;
		object obj26 = GlobalColors.HOVERBOARD_CUSTOMIZATION_POPUP_BOARD_THEME_FOOTER_COLOR >> 16;
		object obj27 = obj26 & 0xFF;
		float num17 = (float)obj27 / 255f;
		object obj28 = GlobalColors.HOVERBOARD_CUSTOMIZATION_POPUP_BOARD_THEME_FOOTER_COLOR >> 24;
		float num18 = (float)obj28 / 255f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+F8]");
		_ = 0;
		object obj29 = GlobalColors.HOVERBOARD_CUSTOMIZATION_POPUP_BOARD_THEME_FOOTER_COLOR & 0xFF;
		float num19 = (float)obj29 / 255f;
		object obj30 = GlobalColors.HOVERBOARD_CUSTOMIZATION_POPUP_BOARD_THEME_FOOTER_COLOR >> 8;
		object obj31 = obj30 & 0xFF;
		float num20 = (float)obj31 / 255f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+F0]");
		_ = 0;
		Color color6 = color + 80;
		container2Arrow.color = color6;
		object obj32 = GlobalColors.HOVERBOARD_CUSTOMIZATION_POPUP_BOARD_THEME_CONTAINER_COLOR >> 16;
		object obj33 = obj32 & 0xFF;
		float num21 = (float)obj33 / 255f;
		object obj34 = GlobalColors.HOVERBOARD_CUSTOMIZATION_POPUP_BOARD_THEME_CONTAINER_COLOR >> 24;
		float num22 = (float)obj34 / 255f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+E8]");
		_ = 0;
		object obj35 = GlobalColors.HOVERBOARD_CUSTOMIZATION_POPUP_BOARD_THEME_CONTAINER_COLOR & 0xFF;
		float num23 = (float)obj35 / 255f;
		object obj36 = GlobalColors.HOVERBOARD_CUSTOMIZATION_POPUP_BOARD_THEME_CONTAINER_COLOR >> 8;
		object obj37 = obj36 & 0xFF;
		float num24 = (float)obj37 / 255f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+E0]");
		_ = 0;
		Color color7 = color - -64;
		container3.color = color7;
		object obj38 = GlobalColors.HOVERBOARD_CUSTOMIZATION_POPUP_BOARD_THEME_FOOTER_COLOR >> 16;
		object obj39 = obj38 & 0xFF;
		float num25 = (float)obj39 / 255f;
		object obj40 = GlobalColors.HOVERBOARD_CUSTOMIZATION_POPUP_BOARD_THEME_FOOTER_COLOR >> 24;
		float num26 = (float)obj40 / 255f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+D8]");
		_ = 0;
		object obj41 = GlobalColors.HOVERBOARD_CUSTOMIZATION_POPUP_BOARD_THEME_FOOTER_COLOR & 0xFF;
		float num27 = (float)obj41 / 255f;
		object obj42 = GlobalColors.HOVERBOARD_CUSTOMIZATION_POPUP_BOARD_THEME_FOOTER_COLOR >> 8;
		object obj43 = obj42 & 0xFF;
		float num28 = (float)obj43 / 255f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+D0]");
		_ = 0;
		Color color8 = color + 48;
		container3Footer.color = color8;
		string text4 = Strings.Get(StringID.HOVERBOARD_THEME_HERO_SUPER_JUMP_TITLE);
		board2Power.text = text4;
		object obj44 = GlobalColors.HOVERBOARD_CUSTOMIZATION_POPUP_BOARD_THEME_FOOTER_COLOR >> 16;
		object obj45 = obj44 & 0xFF;
		float num29 = (float)obj45 / 255f;
		object obj46 = GlobalColors.HOVERBOARD_CUSTOMIZATION_POPUP_BOARD_THEME_FOOTER_COLOR >> 24;
		float num30 = (float)obj46 / 255f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+C8]");
		_ = 0;
		object obj47 = GlobalColors.HOVERBOARD_CUSTOMIZATION_POPUP_BOARD_THEME_FOOTER_COLOR & 0xFF;
		float num31 = (float)obj47 / 255f;
		object obj48 = GlobalColors.HOVERBOARD_CUSTOMIZATION_POPUP_BOARD_THEME_FOOTER_COLOR >> 8;
		object obj49 = obj48 & 0xFF;
		float num32 = (float)obj49 / 255f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+C0]");
		_ = 0;
		Color color9 = color + 32;
		container3Arrow.color = color9;
		object obj50 = GlobalColors.HOVERBOARD_CUSTOMIZATION_POPUP_BOARD_THEME_CONTAINER_COLOR >> 16;
		object obj51 = obj50 & 0xFF;
		float num33 = (float)obj51 / 255f;
		object obj52 = GlobalColors.HOVERBOARD_CUSTOMIZATION_POPUP_BOARD_THEME_CONTAINER_COLOR >> 24;
		float num34 = (float)obj52 / 255f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+B8]");
		_ = 0;
		object obj53 = GlobalColors.HOVERBOARD_CUSTOMIZATION_POPUP_BOARD_THEME_CONTAINER_COLOR & 0xFF;
		float num35 = (float)obj53 / 255f;
		object obj54 = GlobalColors.HOVERBOARD_CUSTOMIZATION_POPUP_BOARD_THEME_CONTAINER_COLOR >> 8;
		object obj55 = obj54 & 0xFF;
		float num36 = (float)obj55 / 255f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+B0]");
		_ = 0;
		Color color10 = color + 16;
		container4.color = color10;
		UISprite[] array = lightRays;
		object obj56 = 0;
		while (array.Length > (nint)obj56)
		{
			object obj57 = obj56 << 2;
			object obj58 = (object)array + obj57;
			object obj59 = GlobalColors.HOVERBOARD_CUSTOMIZATION_POPUP_BOARD_THEME_CONTAINER_COLOR_LIGHT >> 16;
			object obj60 = obj59 & 0xFF;
			float num37 = (float)obj60 / 255f;
			object obj61 = GlobalColors.HOVERBOARD_CUSTOMIZATION_POPUP_BOARD_THEME_CONTAINER_COLOR_LIGHT >> 24;
			float num38 = (float)obj61 / 255f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+A8]");
			((Color*)(nint)color)->b = 0f;
			object obj62 = GlobalColors.HOVERBOARD_CUSTOMIZATION_POPUP_BOARD_THEME_CONTAINER_COLOR_LIGHT & 0xFF;
			float num39 = (float)obj62 / 255f;
			object obj63 = GlobalColors.HOVERBOARD_CUSTOMIZATION_POPUP_BOARD_THEME_CONTAINER_COLOR_LIGHT >> 8;
			object obj64 = obj63 & 0xFF;
			float num40 = (float)obj64 / 255f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+A0]");
			((Color*)(nint)color)->r = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v489 @ S0_v112+10]");
			((UIWidget)0).color = color;
			object obj65 = obj56 + 1;
			obj56 = obj65;
		}
		Add3DModels();
	}

	private unsafe void Add3DModels()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_066b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0670: Expected Obj, but got Unknown
		//IL_007d: Expected I, but got Obj
		//IL_00ae: Expected I, but got Obj
		//IL_00df: Expected I, but got Obj
		//IL_013f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0144: Expected VT, but got Unknown
		//IL_014d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0152: Expected VT, but got Unknown
		//IL_015b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0160: Expected VT, but got Unknown
		//IL_0187: Unknown result type (might be due to invalid IL or missing references)
		//IL_018c: Expected Obj, but got Unknown
		//IL_021f: Expected I, but got Obj
		//IL_0250: Expected I, but got Obj
		//IL_0281: Expected I, but got Obj
		//IL_02e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e6: Expected VT, but got Unknown
		//IL_02ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f4: Expected VT, but got Unknown
		//IL_02fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0302: Expected VT, but got Unknown
		//IL_0329: Unknown result type (might be due to invalid IL or missing references)
		//IL_032e: Expected Obj, but got Unknown
		//IL_03c1: Expected I, but got Obj
		//IL_03f2: Expected I, but got Obj
		//IL_0423: Expected I, but got Obj
		//IL_0483: Unknown result type (might be due to invalid IL or missing references)
		//IL_0488: Expected VT, but got Unknown
		//IL_0491: Unknown result type (might be due to invalid IL or missing references)
		//IL_0496: Expected VT, but got Unknown
		//IL_049f: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a4: Expected VT, but got Unknown
		//IL_04cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d0: Expected Obj, but got Unknown
		//IL_0563: Expected I, but got Obj
		//IL_0594: Expected I, but got Obj
		//IL_05c5: Expected I, but got Obj
		//IL_061e: Expected F4, but got I
		//IL_0619: Expected native int or pointer, but got VT
		//IL_062c: Expected F4, but got VT
		//IL_0627: Expected native int or pointer, but got VT
		//IL_0635: Unknown result type (might be due to invalid IL or missing references)
		//IL_063a: Expected VT, but got Unknown
		//IL_0643: Unknown result type (might be due to invalid IL or missing references)
		//IL_0648: Expected VT, but got Unknown
		object obj = default;
		Vector3 vector = (Vector3)(obj - 320);
		object obj2 = this + 140;
		if (_boardModel != null)
		{
			((GameObject)obj2).SetActive(true);
		}
		else
		{
			UIModelController instance = UIModelController.Instance;
			GameObject boardModel = NGUITools.AddChild(instance.TutorialPopupAnchor, boardModelPrefab);
			_boardModel = boardModel;
		}
		UIModelController instance2 = UIModelController.Instance;
		int layer = instance2.TutorialPopupAnchor.layer;
		_boardModel.layer = layer;
		GameObject modelHost = container1Glow.gameObject;
		nint num = (nint)typeof(HoverboardCustomizationPopup);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ S1_v12 (Il2CppClass<HoverboardCustomizationPopup>)+5C]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ S1_v13 (Il2CppStaticFields<HoverboardCustomizationPopup>)+8]");
		_ = 0;
		_ = BOARD_MODEL_POSITION_OFFSET;
		nint num3 = (nint)typeof(HoverboardCustomizationPopup);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ S1_v18 (Il2CppClass<HoverboardCustomizationPopup>)+5C]");
		nint num4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ S1_v19 (Il2CppStaticFields<HoverboardCustomizationPopup>)+20]");
		_ = 0;
		_ = BOARD_MODEL_SCALE;
		nint num5 = (nint)typeof(HoverboardCustomizationPopup);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ S0_v30 (Il2CppClass<HoverboardCustomizationPopup>)+5C]");
		nint num6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+138]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+128]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+120]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+130]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ S0_v31 (Il2CppStaticFields<HoverboardCustomizationPopup>)+14]");
		_ = 0;
		_ = BOARD_MODEL_ROTATION;
		Vector3 offset = vector + 176;
		Vector3 scale = vector + 160;
		Vector3 rotation = vector + 144;
		PlaceModel(modelHost, _boardModel, offset, scale, rotation);
		object obj3 = this + 144;
		if (_theme1Model != null)
		{
			((GameObject)obj3).SetActive(true);
		}
		else
		{
			UIModelController instance3 = UIModelController.Instance;
			GameObject theme1Model = NGUITools.AddChild(instance3.TutorialPopupAnchor, theme1ModelPrefab);
			_theme1Model = theme1Model;
		}
		UIModelController instance4 = UIModelController.Instance;
		int layer2 = instance4.TutorialPopupAnchor.layer;
		SetLayerRecursively(_theme1Model, layer2);
		GameObject modelHost2 = container2Glow.gameObject;
		nint num7 = (nint)typeof(HoverboardCustomizationPopup);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v191 @ S1_v43 (Il2CppClass<HoverboardCustomizationPopup>)+5C]");
		nint num8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v192 @ S1_v44 (Il2CppStaticFields<HoverboardCustomizationPopup>)+2C]");
		_ = 0;
		_ = THEME1_POSITION_OFFSET;
		nint num9 = (nint)typeof(HoverboardCustomizationPopup);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v200 @ S1_v49 (Il2CppClass<HoverboardCustomizationPopup>)+5C]");
		nint num10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v201 @ S1_v50 (Il2CppStaticFields<HoverboardCustomizationPopup>)+44]");
		_ = 0;
		_ = THEME1_SCALE;
		nint num11 = (nint)typeof(HoverboardCustomizationPopup);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v208 @ S0_v61 (Il2CppClass<HoverboardCustomizationPopup>)+5C]");
		nint num12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+118]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+108]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+100]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+110]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v209 @ S0_v62 (Il2CppStaticFields<HoverboardCustomizationPopup>)+38]");
		_ = 0;
		_ = THEME1_ROTATION;
		Vector3 offset2 = vector + 128;
		Vector3 scale2 = vector + 112;
		Vector3 rotation2 = vector + 96;
		PlaceModel(modelHost2, _theme1Model, offset2, scale2, rotation2);
		object obj4 = this + 148;
		if (_theme2Model != null)
		{
			((GameObject)obj4).SetActive(true);
		}
		else
		{
			UIModelController instance5 = UIModelController.Instance;
			GameObject theme2Model = NGUITools.AddChild(instance5.TutorialPopupAnchor, theme2ModelPrefab);
			_theme2Model = theme2Model;
		}
		UIModelController instance6 = UIModelController.Instance;
		int layer3 = instance6.TutorialPopupAnchor.layer;
		SetLayerRecursively(_theme2Model, layer3);
		GameObject modelHost3 = container3Glow.gameObject;
		nint num13 = (nint)typeof(HoverboardCustomizationPopup);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v303 @ S1_v74 (Il2CppClass<HoverboardCustomizationPopup>)+5C]");
		nint num14 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v304 @ S1_v75 (Il2CppStaticFields<HoverboardCustomizationPopup>)+50]");
		_ = 0;
		_ = THEME2_POSITION_OFFSET;
		nint num15 = (nint)typeof(HoverboardCustomizationPopup);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v312 @ S1_v80 (Il2CppClass<HoverboardCustomizationPopup>)+5C]");
		nint num16 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v313 @ S1_v81 (Il2CppStaticFields<HoverboardCustomizationPopup>)+68]");
		_ = 0;
		_ = THEME2_SCALE;
		nint num17 = (nint)typeof(HoverboardCustomizationPopup);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v320 @ S0_v92 (Il2CppClass<HoverboardCustomizationPopup>)+5C]");
		nint num18 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+F8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+E8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+E0]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+F0]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v321 @ S0_v93 (Il2CppStaticFields<HoverboardCustomizationPopup>)+5C]");
		_ = 0;
		_ = THEME2_ROTATION;
		Vector3 offset3 = vector + 80;
		Vector3 scale3 = vector - -64;
		Vector3 rotation3 = vector + 48;
		PlaceModel(modelHost3, _theme2Model, offset3, scale3, rotation3);
		object obj5 = this + 152;
		if (_bothThemesModel != null)
		{
			((GameObject)obj5).SetActive(true);
		}
		else
		{
			UIModelController instance7 = UIModelController.Instance;
			GameObject bothThemesModel = NGUITools.AddChild(instance7.TutorialPopupAnchor, bothThemesModelPrefab);
			_bothThemesModel = bothThemesModel;
		}
		UIModelController instance8 = UIModelController.Instance;
		int layer4 = instance8.TutorialPopupAnchor.layer;
		SetLayerRecursively(_bothThemesModel, layer4);
		GameObject modelHost4 = container4Glow.gameObject;
		nint num19 = (nint)typeof(HoverboardCustomizationPopup);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v415 @ S1_v105 (Il2CppClass<HoverboardCustomizationPopup>)+5C]");
		nint num20 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v416 @ S1_v106 (Il2CppStaticFields<HoverboardCustomizationPopup>)+74]");
		_ = 0;
		_ = BOTH_THEMES_MODEL_POSITION_OFFSET;
		nint num21 = (nint)typeof(HoverboardCustomizationPopup);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v424 @ S1_v111 (Il2CppClass<HoverboardCustomizationPopup>)+5C]");
		nint num22 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v425 @ S1_v112 (Il2CppStaticFields<HoverboardCustomizationPopup>)+8C]");
		_ = 0;
		_ = BOTH_THEMES_MODEL_SCALE;
		nint num23 = (nint)typeof(HoverboardCustomizationPopup);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v432 @ S0_v123 (Il2CppClass<HoverboardCustomizationPopup>)+5C]");
		nint num24 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+D8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+C8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+C0]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+D0]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v433 @ S0_v124 (Il2CppStaticFields<HoverboardCustomizationPopup>)+80]");
		((Vector3*)(nint)vector)->z = 0f;
		((Vector3*)(nint)vector)->x = (float)BOTH_THEMES_MODEL_ROTATION;
		Vector3 offset4 = vector + 32;
		Vector3 scale4 = vector + 16;
		PlaceModel(modelHost4, _bothThemesModel, offset4, scale4, vector);
	}

	public unsafe void PlaceModel(GameObject modelHost, GameObject modelToPosition, Vector3 offset, Vector3 scale, Vector3 rotation)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0043: Expected native int or pointer, but got VT
		//IL_0055: Expected native int or pointer, but got VT
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Expected VT, but got Unknown
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Expected VT, but got Unknown
		object obj = default;
		Vector3 vector = (Vector3)(obj - 48);
		_ = offset.z;
		_ = offset.x;
		_ = scale.z;
		_ = scale.x;
		((Vector3*)(nint)vector)->z = rotation.z;
		((Vector3*)(nint)vector)->x = rotation.x;
		Vector3 offset2 = vector + 32;
		Vector3 scale2 = vector + 16;
		IEnumerator routine = DelayPositioning(modelHost, modelToPosition, offset2, scale2, vector);
		Coroutine coroutine = StartCoroutine(routine);
	}

	private IEnumerator DelayPositioning(GameObject modelHost, GameObject modelToPosition, Vector3 offset, Vector3 scale, Vector3 rotation)
	{
		_ = 0;
		_ = offset.z;
		_ = offset.x;
		_ = scale.x;
		_ = scale.z;
		_ = rotation.x;
		_ = rotation.z;
		IEnumerator result = default;
		return result;
	}

	private unsafe void ResetTransform(Transform trans, Vector3 newPosition, Vector3 positionOffset, Vector3 newRotation, Vector3 newScale)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected VT, but got Unknown
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Expected VT, but got Unknown
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_015d: Expected VT, but got Unknown
		//IL_01ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b1: Expected VT, but got Unknown
		//IL_01cb: Expected native int or pointer, but got VT
		//IL_01dd: Expected native int or pointer, but got VT
		object obj = default;
		Vector3 vector = (Vector3)(obj - 144);
		_ = newPosition.z;
		_ = newPosition.x;
		Vector3 position = vector - -64;
		trans.position = position;
		Vector3 localPosition = trans.localPosition;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+80]");
		float num = 0f + positionOffset.x;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+84]");
		float num2 = 0f + positionOffset.y;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+88]");
		float num3 = 0f + positionOffset.z;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+68]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+60]");
		_ = 0;
		Vector3 localPosition2 = vector + 48;
		trans.localPosition = localPosition2;
		float num4 = newRotation.x * ((float)Math.PI / 180f);
		float num5 = newRotation.y * ((float)Math.PI / 180f);
		float num6 = newRotation.z * ((float)Math.PI / 180f);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+78]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+70]");
		_ = 0;
		Vector3 euler = vector + 32;
		Quaternion quaternion = Quaternion.Internal_FromEulerRad(euler);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+88]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+88]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+80]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+80]");
		_ = 0;
		Quaternion localRotation = (Quaternion)(vector + 16);
		trans.localRotation = localRotation;
		((Vector3*)(nint)vector)->z = newScale.z;
		((Vector3*)(nint)vector)->x = newScale.x;
		trans.localScale = vector;
	}

	public override void Hide()
	{
		base.Hide();
		_boardModel.SetActive(value: false);
		_theme1Model.SetActive(value: false);
		_theme2Model.SetActive(value: false);
		_bothThemesModel.SetActive(value: false);
	}

	public void OKClicked()
	{
		PlayerInfo instance = PlayerInfo.Instance;
		if (!instance._hasShownHoverboardCustmoizationPopup)
		{
			instance._dirty = true;
			instance._hasShownHoverboardCustmoizationPopup = true;
		}
		BoardScreenManager instance2 = BoardScreenManager.Instance;
		instance2.forceCenterOnSpecificBoard__BackingField = true;
		BoardScreenManager instance3 = BoardScreenManager.Instance;
		instance3.comingFromHoverboardCustomizationPopup__BackingField = true;
		UIScreenController instance4 = UIScreenController.Instance;
		instance4.ignoreLastPopupClosed = true;
		UIScreenController instance5 = UIScreenController.Instance;
		instance5.CloseActivePopups(screenName);
		UIScreenController instance6 = UIScreenController.Instance;
		instance6.PushScreen("BoardScreen");
	}

	private void SetLayerRecursively(GameObject obj, int newLayer)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected Obj, but got Unknown
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Expected Obj, but got Unknown
		//IL_02ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0304: Expected Obj, but got Unknown
		//IL_0344: Unknown result type (might be due to invalid IL or missing references)
		//IL_0349: Expected Obj, but got Unknown
		object obj3 = default;
		object obj2 = obj3 - 32;
		_ = 0;
		if (null == obj)
		{
			return;
		}
		obj.layer = newLayer;
		Transform transform = obj.transform;
		IEnumerator enumerator = transform.GetEnumerator();
		object obj4 = obj2 + 24;
		object obj5 = obj2 + 28;
		obj2 = obj5;
		_ = 0;
		object obj6 = default;
		object obj7 = default;
		object obj8 = default;
		object obj9 = default;
		object obj11 = default;
		object obj12 = default;
		while (true)
		{
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				if (obj6 == null)
				{
					goto IL_02f6;
				}
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
								if (obj7 != null)
								{
									continue;
								}
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
						goto IL_0267;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			}
			goto IL_0267;
			IL_0267:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
			bool flag = obj8 != obj9;
			object obj10 = obj11;
			if (flag)
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
				goto IL_02f6;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			obj10 = obj12;
			break;
			IL_02f6:
			object obj13 = obj2 + 8;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @38A");
			return;
		}
		_ = 0;
		object obj14 = obj2 + 8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
		if ((nint)0 != 1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
	}

	static HoverboardCustomizationPopup()
	{
		//IL_0013: Expected I, but got Obj
		//IL_0033: Expected VT, but got I4
		//IL_0041: Expected I, but got Obj
		//IL_0065: Expected VT, but got I8
		//IL_0073: Expected I, but got Obj
		//IL_0097: Expected VT, but got I8
		//IL_00a5: Expected I, but got Obj
		//IL_00c9: Expected VT, but got I8
		//IL_00d7: Expected I, but got Obj
		//IL_00fb: Expected VT, but got I8
		//IL_0109: Expected I, but got Obj
		//IL_012d: Expected VT, but got I8
		//IL_013b: Expected I, but got Obj
		//IL_015f: Expected VT, but got I8
		//IL_016d: Expected I, but got Obj
		//IL_0191: Expected VT, but got I8
		//IL_019f: Expected I, but got Obj
		//IL_01c3: Expected VT, but got I8
		//IL_01d1: Expected I, but got Obj
		//IL_01f5: Expected VT, but got I8
		//IL_0203: Expected I, but got Obj
		//IL_0227: Expected VT, but got I8
		//IL_0235: Expected I, but got Obj
		//IL_0259: Expected VT, but got I8
		nint num = (nint)typeof(HoverboardCustomizationPopup);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v11 @ S0_v6 (Il2CppClass<HoverboardCustomizationPopup>)+5C]");
		nint num2 = 0;
		_ = 0;
		BOARD_MODEL_POSITION_OFFSET = (Vector3)0;
		nint num3 = (nint)typeof(HoverboardCustomizationPopup);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v10 (Il2CppClass<HoverboardCustomizationPopup>)+5C]");
		nint num4 = 0;
		_ = 1111752704;
		BOARD_MODEL_ROTATION = (Vector3)(-4400016834832891904L);
		nint num5 = (nint)typeof(HoverboardCustomizationPopup);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v14 (Il2CppClass<HoverboardCustomizationPopup>)+5C]");
		nint num6 = 0;
		_ = 1099956224;
		BOARD_MODEL_SCALE = (Vector3)4724276010211606528L;
		nint num7 = (nint)typeof(HoverboardCustomizationPopup);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v18 (Il2CppClass<HoverboardCustomizationPopup>)+5C]");
		nint num8 = 0;
		_ = 0;
		THEME1_POSITION_OFFSET = (Vector3)4647714815446351872L;
		nint num9 = (nint)typeof(HoverboardCustomizationPopup);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v22 (Il2CppClass<HoverboardCustomizationPopup>)+5C]");
		nint num10 = 0;
		_ = 1110179840;
		THEME1_ROTATION = (Vector3)(-4394105860323803136L);
		nint num11 = (nint)typeof(HoverboardCustomizationPopup);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S0_v26 (Il2CppClass<HoverboardCustomizationPopup>)+5C]");
		nint num12 = 0;
		_ = 1101004800;
		THEME1_SCALE = (Vector3)4728779609840025600L;
		nint num13 = (nint)typeof(HoverboardCustomizationPopup);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ S0_v30 (Il2CppClass<HoverboardCustomizationPopup>)+5C]");
		nint num14 = 0;
		_ = 0;
		THEME2_POSITION_OFFSET = (Vector3)4647714815446351872L;
		nint num15 = (nint)typeof(HoverboardCustomizationPopup);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ S0_v34 (Il2CppClass<HoverboardCustomizationPopup>)+5C]");
		nint num16 = 0;
		_ = 1110835200;
		THEME2_ROTATION = (Vector3)(-4400579784787623936L);
		nint num17 = (nint)typeof(HoverboardCustomizationPopup);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S0_v38 (Il2CppClass<HoverboardCustomizationPopup>)+5C]");
		nint num18 = 0;
		_ = 1101004800;
		THEME2_SCALE = (Vector3)4728779609840025600L;
		nint num19 = (nint)typeof(HoverboardCustomizationPopup);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ S0_v42 (Il2CppClass<HoverboardCustomizationPopup>)+5C]");
		nint num20 = 0;
		_ = 0;
		BOTH_THEMES_MODEL_POSITION_OFFSET = (Vector3)4697254411347427328L;
		nint num21 = (nint)typeof(HoverboardCustomizationPopup);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S0_v46 (Il2CppClass<HoverboardCustomizationPopup>)+5C]");
		nint num22 = 0;
		_ = 1106247680;
		BOTH_THEMES_MODEL_ROTATION = (Vector3)(-4394668810281418752L);
		nint num23 = (nint)typeof(HoverboardCustomizationPopup);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ S0_v50 (Il2CppClass<HoverboardCustomizationPopup>)+5C]");
		nint num24 = 0;
		_ = 1105723392;
		BOTH_THEMES_MODEL_SCALE = (Vector3)4749045808167911424L;
	}
}
