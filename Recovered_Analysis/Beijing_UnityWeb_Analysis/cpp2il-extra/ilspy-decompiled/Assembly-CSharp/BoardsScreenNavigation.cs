using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Data.Managers;
using Info;
using UI;
using UI.Screens;
using UI.Screens.BoardScreenInternal;
using UI.Screens.RewardManagement;
using UnityEngine;

public class BoardsScreenNavigation : MonoBehaviour
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Predicate<HoverboardOverlayHelper> _003C_003E9__9_0;

		public static Predicate<HoverboardOverlayHelper> _003C_003E9__9_1;

		public static Predicate<HoverboardOverlayHelper> _003C_003E9__9_2;

		public static Predicate<HoverboardOverlayHelper> _003C_003E9__9_3;

		static _003C_003Ec()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			FPSLog._003C_003Ec obj = default;
			FPSLog._003C_003Ec._003C_003E9 = obj;
		}

		public _003C_003Ec()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			NullReferenceException ex = default;
			ex._002Ector();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}

		internal bool _003CUpdate_003Eb__9_0(HoverboardOverlayHelper x)
		{
			IntPtr cachedPtr = ((UnityEngine.Object)x).m_CachedPtr;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (BoardsScreenNavigation+<>c)+8]");
			return cachedPtr == (IntPtr)0;
		}

		internal bool _003CUpdate_003Eb__9_1(HoverboardOverlayHelper x)
		{
			//IL_0060: Expected I, but got Obj
			//IL_0076: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			nint num = (nint)typeof(BoardScreenManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S1_v3 (Il2CppClass<BoardScreenManager>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(BoardScreenManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v10 (Il2CppClass<BoardScreenManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			HoverboardModelPreviewFactory instance = HoverboardModelPreviewFactory.Instance;
			return (nint)x._cachedBoardId == (nint)instance.jumperSignature;
		}

		internal bool _003CUpdate_003Eb__9_2(HoverboardOverlayHelper x)
		{
			//IL_0060: Expected I, but got Obj
			//IL_0076: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			nint num = (nint)typeof(BoardScreenManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S1_v3 (Il2CppClass<BoardScreenManager>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(BoardScreenManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v10 (Il2CppClass<BoardScreenManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			HoverboardModelPreviewFactory instance = HoverboardModelPreviewFactory.Instance;
			return (nint)x._cachedBoardId == (nint)instance.jumperSignature;
		}

		internal bool _003CUpdate_003Eb__9_3(HoverboardOverlayHelper x)
		{
			//IL_0060: Expected I, but got Obj
			//IL_0076: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			nint num = (nint)typeof(BoardScreenManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S1_v3 (Il2CppClass<BoardScreenManager>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(BoardScreenManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v10 (Il2CppClass<BoardScreenManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			HoverboardModelPreviewFactory instance = HoverboardModelPreviewFactory.Instance;
			return (nint)x._cachedBoardId == (nint)instance.jumperSignature;
		}
	}

	public UITexture highlight;

	public UITexture selectBoardSkinHighlight;

	private UITexture selectButtonHighlight;

	private BoardScreen screen;

	private BoardSelectButton selectButton;

	private MeFooterNavigation _meFooter;

	private int height;

	private void OnEnable()
	{
		CancelInvoke();
	}

	private void Start()
	{
		//IL_0010: Expected Obj, but got I4
		highlight.tag = (string)1;
	}

	private void Update()
	{
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Expected Obj, but got Unknown
		//IL_007d: Expected Obj, but got VT
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Expected Obj, but got Unknown
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Expected Obj, but got Unknown
		//IL_0020: Expected Obj, but got I4
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected Obj, but got Unknown
		object obj = this + 24;
		_0021_00210 componentInChildren = (_0021_00210)((Component)this).GetComponentInChildren<T>();
		obj = componentInChildren;
		object obj2 = this + 28;
		_0021_00210[] componentsInChildren = (_0021_00210[])(object)((Component)this).GetComponentsInChildren<T>();
		obj2 = componentsInChildren;
		object obj3 = this + 20;
		GameObject gameObject = selectButton.gameObject;
		bool flag = ((Transform)(object)gameObject).IsChildOf((Transform)(object)"High");
		UITexture component = ((Component)flag).GetComponent<UITexture>();
		obj3 = component;
		object obj4 = this + 32;
		MeFooterNavigation componentInChildren2 = GetComponentInChildren<MeFooterNavigation>();
		obj4 = componentInChildren2;
		_meFooter.tag = null;
	}

	public BoardsScreenNavigation()
	{
		//IL_0b99: Expected Obj, but got I4
		//IL_0bc0: Expected Obj, but got I4
		//IL_0e09: Expected Obj, but got I4
		//IL_1052: Expected Obj, but got I4
		//IL_01f0: Expected I, but got Obj
		//IL_0206: Expected Obj, but got I
		//IL_1079: Expected Obj, but got I4
		//IL_0652: Expected I, but got Obj
		//IL_0668: Expected Obj, but got I
		//IL_1116: Expected Obj, but got I
		//IL_1126: Expected Obj, but got I
		//IL_1136: Expected Obj, but got I
		//IL_113f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1144: Expected Obj, but got Unknown
		//IL_114d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1152: Expected Obj, but got Unknown
		//IL_1186: Expected Obj, but got I4
		//IL_0231: Expected I, but got Obj
		//IL_0b67: Expected Obj, but got I4
		//IL_0903: Expected Obj, but got I4
		//IL_127f: Expected Obj, but got I
		//IL_128f: Expected Obj, but got I
		//IL_129f: Expected Obj, but got I
		//IL_12a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_12ad: Expected Obj, but got Unknown
		//IL_12b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_12bb: Expected Obj, but got Unknown
		//IL_0693: Expected I, but got Obj
		//IL_027e: Expected I, but got Obj
		//IL_0294: Expected Obj, but got I
		//IL_0062: Expected I, but got Obj
		//IL_0078: Expected Obj, but got I
		//IL_0a22: Expected Obj, but got I4
		//IL_0965: Expected Obj, but got I4
		//IL_06e0: Expected I, but got Obj
		//IL_06f6: Expected Obj, but got I
		//IL_04c4: Expected I, but got Obj
		//IL_04da: Expected Obj, but got I
		//IL_030c: Expected I, but got Obj
		//IL_0322: Expected Obj, but got I
		//IL_0cb3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cb8: Expected Obj, but got Unknown
		//IL_0ccf: Expected I, but got Obj
		//IL_0ce5: Expected Obj, but got I
		//IL_0a64: Expected I, but got Obj
		//IL_0a7a: Expected Obj, but got I
		//IL_09cc: Expected Obj, but got I4
		//IL_076e: Expected I, but got Obj
		//IL_0784: Expected Obj, but got I
		//IL_0efc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f01: Expected Obj, but got Unknown
		//IL_0f18: Expected I, but got Obj
		//IL_0f2e: Expected Obj, but got I
		//IL_0d32: Expected I, but got Obj
		//IL_0d48: Expected Obj, but got I
		//IL_02bf: Expected I, but got Obj
		//IL_00a3: Expected I, but got Obj
		//IL_10a2: Expected I, but got Obj
		//IL_10b8: Expected Obj, but got I
		//IL_0f7b: Expected I, but got Obj
		//IL_0f91: Expected Obj, but got I
		//IL_0721: Expected I, but got Obj
		//IL_0505: Expected I, but got Obj
		//IL_034d: Expected I, but got Obj
		//IL_00f0: Expected I, but got Obj
		//IL_0106: Expected Obj, but got I
		//IL_10e3: Expected I4, but got Obj
		//IL_0aa5: Expected I, but got Obj
		//IL_07af: Expected I, but got Obj
		//IL_0552: Expected I, but got Obj
		//IL_0568: Expected Obj, but got I
		//IL_11c3: Expected Obj, but got I
		//IL_11d3: Expected Obj, but got I
		//IL_11e3: Expected Obj, but got I
		//IL_11ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_11f1: Expected Obj, but got Unknown
		//IL_11fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_11ff: Expected Obj, but got Unknown
		//IL_1212: Unknown result type (might be due to invalid IL or missing references)
		//IL_1217: Expected I4, but got Unknown
		//IL_123f: Expected Obj, but got I4
		//IL_1264: Expected Obj, but got I4
		//IL_039a: Expected I, but got Obj
		//IL_0c1f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c24: Expected Obj, but got Unknown
		//IL_0c5b: Expected I4, but got Obj
		//IL_0af2: Expected I, but got Obj
		//IL_1306: Expected Obj, but got I
		//IL_1316: Expected Obj, but got I
		//IL_1326: Expected Obj, but got I
		//IL_132f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1334: Expected Obj, but got Unknown
		//IL_133d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1342: Expected Obj, but got Unknown
		//IL_1355: Unknown result type (might be due to invalid IL or missing references)
		//IL_135a: Expected I4, but got Unknown
		//IL_1382: Expected Obj, but got I4
		//IL_13a7: Expected Obj, but got I4
		//IL_07fc: Expected I, but got Obj
		//IL_0e68: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e6d: Expected Obj, but got Unknown
		//IL_0ea4: Expected I4, but got Obj
		//IL_03e7: Expected I, but got Obj
		//IL_03fd: Expected Obj, but got I
		//IL_0131: Expected I, but got Obj
		//IL_0b58: Expected Obj, but got I4
		//IL_0849: Expected I, but got Obj
		//IL_085f: Expected Obj, but got I
		//IL_0593: Expected I, but got Obj
		//IL_0db8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dbd: Expected Obj, but got Unknown
		//IL_0dd4: Expected I, but got Obj
		//IL_0dea: Expected Obj, but got I
		//IL_1001: Unknown result type (might be due to invalid IL or missing references)
		//IL_1006: Expected Obj, but got Unknown
		//IL_101d: Expected I, but got Obj
		//IL_1033: Expected Obj, but got I
		//IL_0428: Expected I, but got Obj
		//IL_088a: Expected I, but got Obj
		if (Input.GetKeyDown((string)275))
		{
			if (height != 1)
			{
				if (height == 3)
				{
					nint num = (nint)typeof(BoardScreenManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ S0_v254 (Il2CppClass<BoardScreenManager>)+BA]");
					object obj = (nint)0 & (nint)0x200;
					if (obj != null)
					{
						nint num2 = (nint)typeof(BoardScreenManager);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v194 @ S0_v284 (Il2CppClass<BoardScreenManager>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					HoverboardModelPreviewFactory instance = HoverboardModelPreviewFactory.Instance;
					if ((nint)instance.speederSignature <= 1)
					{
						nint num3 = (nint)typeof(BoardScreenManager);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v323 @ S0_v263 (Il2CppClass<BoardScreenManager>)+BA]");
						object obj2 = (nint)0 & (nint)0x200;
						if (obj2 != null)
						{
							nint num4 = (nint)typeof(BoardScreenManager);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v403 @ S0_v280 (Il2CppClass<BoardScreenManager>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						HoverboardModelPreviewFactory instance2 = HoverboardModelPreviewFactory.Instance;
						AnimationClip speederSignature = (AnimationClip)(instance2.speederSignature + 1);
						instance2.speederSignature = speederSignature;
						BoardScreen boardScreen = screen;
						HoverboardModelPreviewFactory instance3 = HoverboardModelPreviewFactory.Instance;
						((UIMessageHelper)(object)boardScreen._hoverboardThemeShifter).SetTemporaryHidden((byte)(int)instance3.speederSignature != 0);
						HoverboardModelPreviewFactory instance4 = HoverboardModelPreviewFactory.Instance;
						HoverboardModelPreviewFactory instance5 = HoverboardModelPreviewFactory.Instance;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7E7E");
						BoardScreen boardScreen2 = screen;
						boardScreen2._hoverboardSelectButton.OnEnable();
						BoardScreen boardScreen3 = screen;
						boardScreen3._hoverboardSelectButton.SetTryHoverboardUI();
					}
				}
			}
			else
			{
				BoardScreen boardScreen4 = screen;
				List<HoverboardOverlayHelper> boardHelpers = boardScreen4.boardHelpers;
				nint num5 = (nint)typeof(_003C_003Ec);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ S0_v190 (Il2CppClass<BoardsScreenNavigation+<>c>)+BA]");
				object obj3 = (nint)0 & (nint)0x200;
				if (obj3 != null)
				{
					nint num6 = (nint)typeof(_003C_003Ec);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ S0_v244 (Il2CppClass<BoardsScreenNavigation+<>c>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				bool flag = _003C_003Ec._003C_003E9__9_0 == null;
				bool flag2 = !flag;
				Predicate<HoverboardOverlayHelper> predicate = _003C_003Ec._003C_003E9__9_0;
				if (!flag2)
				{
					nint num7 = (nint)typeof(_003C_003Ec);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v204 @ S0_v218 (Il2CppClass<BoardsScreenNavigation+<>c>)+BA]");
					object obj4 = (nint)0 & (nint)0x200;
					if (obj4 != null)
					{
						nint num8 = (nint)typeof(_003C_003Ec);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v255 @ S0_v238 (Il2CppClass<BoardsScreenNavigation+<>c>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
					nint num9 = 0;
					_ = 0;
					Predicate<HoverboardOverlayHelper> predicate2 = default;
					object obj5 = predicate2 + 16;
					obj5 = _003C_003Ec._003C_003E9;
					nint num10 = (nint)typeof(_003C_003Ec);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v343 @ S0_v235 (Il2CppClass<BoardsScreenNavigation+<>c>)+5C]");
					object obj6 = (nint)0 + (nint)4;
					obj6 = predicate2;
					predicate = predicate2;
				}
				nint num11 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v226 @ S4_v12 (Il2CppMethodInfo)+C]");
				object obj7 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v227 @ S4_v13+60]");
				object obj8 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v228 @ S4_v14+78]");
				object obj9 = 0;
				object obj10 = obj9 & 0x7FF;
				object obj11 = obj10 + 39195;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v34 @ S5_v11 (should have been resolved before IL gen)");
				BoardScreen boardScreen5 = screen;
				List<HoverboardOverlayHelper> boardHelpers2 = boardScreen5.boardHelpers;
				object obj12 = boardHelpers2._size - 1;
				object obj13 = default;
				if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj13) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj12))
				{
					nint num12 = (nint)typeof(BoardScreenManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v270 @ S0_v203 (Il2CppClass<BoardScreenManager>)+BA]");
					object obj14 = (nint)0 & (nint)0x200;
					if (obj14 != null)
					{
						nint num13 = (nint)typeof(BoardScreenManager);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v346 @ S0_v213 (Il2CppClass<BoardScreenManager>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					HoverboardModelPreviewFactory instance6 = HoverboardModelPreviewFactory.Instance;
					BoardScreen boardScreen6 = screen;
					BoardScreen boardScreen7 = screen;
					List<HoverboardOverlayHelper> boardHelpers3 = boardScreen7.boardHelpers;
					nint num14 = (nint)typeof(_003C_003Ec);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v419 @ S2_v81 (Il2CppClass<BoardsScreenNavigation+<>c>)+BA]");
					object obj15 = (nint)0 & (nint)0x200;
					if (obj15 != null)
					{
						nint num15 = (nint)typeof(_003C_003Ec);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v495 @ S2_v121 (Il2CppClass<BoardsScreenNavigation+<>c>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					bool flag3 = _003C_003Ec._003C_003E9__9_1 == null;
					bool flag4 = !flag3;
					Predicate<HoverboardOverlayHelper> predicate3 = _003C_003Ec._003C_003E9__9_1;
					if (!flag4)
					{
						nint num16 = (nint)typeof(_003C_003Ec);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v563 @ S2_v95 (Il2CppClass<BoardsScreenNavigation+<>c>)+BA]");
						object obj16 = (nint)0 & (nint)0x200;
						if (obj16 != null)
						{
							nint num17 = (nint)typeof(_003C_003Ec);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v641 @ S2_v115 (Il2CppClass<BoardsScreenNavigation+<>c>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
						nint num18 = 0;
						_ = 0;
						Predicate<HoverboardOverlayHelper> predicate4 = default;
						object obj17 = predicate4 + 16;
						obj17 = _003C_003Ec._003C_003E9;
						nint num19 = (nint)typeof(_003C_003Ec);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v711 @ S2_v112 (Il2CppClass<BoardsScreenNavigation+<>c>)+5C]");
						object obj18 = (nint)0 + (nint)8;
						obj18 = predicate4;
						predicate3 = predicate4;
					}
					nint num20 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v584 @ S6_v13 (Il2CppMethodInfo)+C]");
					object obj19 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v585 @ S6_v14+60]");
					object obj20 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v586 @ S6_v15+78]");
					object obj21 = 0;
					object obj22 = obj21 & 0x7FF;
					object obj23 = obj22 + 39195;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v26 @ S7_v10 (should have been resolved before IL gen)");
					object obj24 = default;
					int index = obj24 + 1;
					HoverboardOverlayHelper hoverboardOverlayHelper = boardScreen6.boardHelpers.get_Item(index);
					instance6.jumperSignature = (AnimationClip)hoverboardOverlayHelper._cachedBoardId;
					screen.UpdateUIElements();
					((CelebrationPopup)(object)screen).PayoutReward((CelebrationReward)1, true, false);
				}
			}
		}
		if (Input.GetKeyDown((string)276))
		{
			if (height != 1)
			{
				if (height == 3)
				{
					nint num21 = (nint)typeof(BoardScreenManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v277 @ S0_v149 (Il2CppClass<BoardScreenManager>)+BA]");
					object obj25 = (nint)0 & (nint)0x200;
					if (obj25 != null)
					{
						nint num22 = (nint)typeof(BoardScreenManager);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v355 @ S0_v179 (Il2CppClass<BoardScreenManager>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					HoverboardModelPreviewFactory instance7 = HoverboardModelPreviewFactory.Instance;
					if ((nint)instance7.speederSignature >= 1)
					{
						nint num23 = (nint)typeof(BoardScreenManager);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v511 @ S0_v158 (Il2CppClass<BoardScreenManager>)+BA]");
						object obj26 = (nint)0 & (nint)0x200;
						if (obj26 != null)
						{
							nint num24 = (nint)typeof(BoardScreenManager);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v597 @ S0_v175 (Il2CppClass<BoardScreenManager>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						HoverboardModelPreviewFactory instance8 = HoverboardModelPreviewFactory.Instance;
						AnimationClip speederSignature2 = (AnimationClip)(instance8.speederSignature - 1);
						instance8.speederSignature = speederSignature2;
						BoardScreen boardScreen8 = screen;
						HoverboardModelPreviewFactory instance9 = HoverboardModelPreviewFactory.Instance;
						((UIMessageHelper)(object)boardScreen8._hoverboardThemeShifter).SetTemporaryHidden((byte)(int)instance9.speederSignature != 0);
						HoverboardModelPreviewFactory instance10 = HoverboardModelPreviewFactory.Instance;
						HoverboardModelPreviewFactory instance11 = HoverboardModelPreviewFactory.Instance;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7E7E");
						BoardScreen boardScreen9 = screen;
						boardScreen9._hoverboardSelectButton.OnEnable();
						BoardScreen boardScreen10 = screen;
						boardScreen10._hoverboardSelectButton.SetTryHoverboardUI();
					}
				}
			}
			else
			{
				BoardScreen boardScreen11 = screen;
				List<HoverboardOverlayHelper> boardHelpers4 = boardScreen11.boardHelpers;
				nint num25 = (nint)typeof(_003C_003Ec);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v246 @ S0_v85 (Il2CppClass<BoardsScreenNavigation+<>c>)+BA]");
				object obj27 = (nint)0 & (nint)0x200;
				if (obj27 != null)
				{
					nint num26 = (nint)typeof(_003C_003Ec);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v282 @ S0_v139 (Il2CppClass<BoardsScreenNavigation+<>c>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				bool flag5 = _003C_003Ec._003C_003E9__9_2 == null;
				bool flag6 = !flag5;
				Predicate<HoverboardOverlayHelper> predicate5 = _003C_003Ec._003C_003E9__9_2;
				if (!flag6)
				{
					nint num27 = (nint)typeof(_003C_003Ec);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v365 @ S0_v113 (Il2CppClass<BoardsScreenNavigation+<>c>)+BA]");
					object obj28 = (nint)0 & (nint)0x200;
					if (obj28 != null)
					{
						nint num28 = (nint)typeof(_003C_003Ec);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v427 @ S0_v133 (Il2CppClass<BoardsScreenNavigation+<>c>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
					nint num29 = 0;
					_ = 0;
					Predicate<HoverboardOverlayHelper> predicate6 = default;
					object obj29 = predicate6 + 16;
					obj29 = _003C_003Ec._003C_003E9;
					nint num30 = (nint)typeof(_003C_003Ec);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v531 @ S0_v130 (Il2CppClass<BoardsScreenNavigation+<>c>)+5C]");
					object obj30 = (nint)0 + (nint)12;
					obj30 = predicate6;
					predicate5 = predicate6;
				}
				nint num31 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v386 @ S4_v4 (Il2CppMethodInfo)+C]");
				object obj31 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v387 @ S4_v5+60]");
				object obj32 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v388 @ S4_v6+78]");
				object obj33 = 0;
				object obj34 = obj33 & 0x7FF;
				object obj35 = obj34 + 39195;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v143 @ S5_v6 (should have been resolved before IL gen)");
				object obj36 = default;
				if ((nint)obj36 >= 1)
				{
					nint num32 = (nint)typeof(BoardScreenManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v442 @ S0_v98 (Il2CppClass<BoardScreenManager>)+BA]");
					object obj37 = (nint)0 & (nint)0x200;
					if (obj37 != null)
					{
						nint num33 = (nint)typeof(BoardScreenManager);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v534 @ S0_v108 (Il2CppClass<BoardScreenManager>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					HoverboardModelPreviewFactory instance12 = HoverboardModelPreviewFactory.Instance;
					BoardScreen boardScreen12 = screen;
					BoardScreen boardScreen13 = screen;
					List<HoverboardOverlayHelper> boardHelpers5 = boardScreen13.boardHelpers;
					nint num34 = (nint)typeof(_003C_003Ec);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v613 @ S2_v23 (Il2CppClass<BoardsScreenNavigation+<>c>)+BA]");
					object obj38 = (nint)0 & (nint)0x200;
					if (obj38 != null)
					{
						nint num35 = (nint)typeof(_003C_003Ec);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v668 @ S2_v63 (Il2CppClass<BoardsScreenNavigation+<>c>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					bool flag7 = _003C_003Ec._003C_003E9__9_3 == null;
					bool flag8 = !flag7;
					Predicate<HoverboardOverlayHelper> predicate7 = _003C_003Ec._003C_003E9__9_3;
					if (!flag8)
					{
						nint num36 = (nint)typeof(_003C_003Ec);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v719 @ S2_v37 (Il2CppClass<BoardsScreenNavigation+<>c>)+BA]");
						object obj39 = (nint)0 & (nint)0x200;
						if (obj39 != null)
						{
							nint num37 = (nint)typeof(_003C_003Ec);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v765 @ S2_v57 (Il2CppClass<BoardsScreenNavigation+<>c>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
						nint num38 = 0;
						_ = 0;
						Predicate<HoverboardOverlayHelper> predicate8 = default;
						object obj40 = predicate8 + 16;
						obj40 = _003C_003Ec._003C_003E9;
						nint num39 = (nint)typeof(_003C_003Ec);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v811 @ S2_v54 (Il2CppClass<BoardsScreenNavigation+<>c>)+5C]");
						object obj41 = (nint)0 + (nint)16;
						obj41 = predicate8;
						predicate7 = predicate8;
					}
					nint num40 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v740 @ S6_v6 (Il2CppMethodInfo)+C]");
					object obj42 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v741 @ S6_v7+60]");
					object obj43 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v742 @ S6_v8+78]");
					object obj44 = 0;
					object obj45 = obj44 & 0x7FF;
					object obj46 = obj45 + 39195;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v137 @ S7_v6 (should have been resolved before IL gen)");
					object obj47 = default;
					int index2 = obj47 - 1;
					HoverboardOverlayHelper hoverboardOverlayHelper2 = boardScreen12.boardHelpers.get_Item(index2);
					instance12.jumperSignature = (AnimationClip)hoverboardOverlayHelper2._cachedBoardId;
					screen.UpdateUIElements();
					((CelebrationPopup)(object)screen).PayoutReward((CelebrationReward)1, true, false);
				}
			}
		}
		if (Input.GetKeyDown((string)274))
		{
			if (height == 1)
			{
				_meFooter.tag = (string)1;
				tag = null;
				highlight.tag = null;
			}
			else if (height == 2)
			{
				height = 1;
				highlight.tag = (string)1;
				selectButtonHighlight.tag = null;
			}
			else if (height == 3)
			{
				height = 2;
				selectBoardSkinHighlight.tag = null;
				selectButtonHighlight.tag = (string)1;
			}
		}
		if (Input.GetKeyDown((string)273))
		{
			if (height == 1)
			{
				height = 2;
				highlight.tag = null;
				selectButtonHighlight.tag = (string)1;
			}
			else if (height == 2)
			{
				nint num41 = (nint)typeof(BoardScreenManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v622 @ S0_v32 (Il2CppClass<BoardScreenManager>)+BA]");
				object obj48 = (nint)0 & (nint)0x200;
				if (obj48 != null)
				{
					nint num42 = (nint)typeof(BoardScreenManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v683 @ S0_v45 (Il2CppClass<BoardScreenManager>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				HoverboardModelPreviewFactory instance13 = HoverboardModelPreviewFactory.Instance;
				nint num43 = (nint)typeof(BoardManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v755 @ S1_v19 (Il2CppClass<Data.Managers.BoardManager>)+BA]");
				object obj49 = (nint)0 & (nint)0x200;
				if (obj49 != null)
				{
					nint num44 = (nint)typeof(BoardManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v783 @ S1_v27 (Il2CppClass<Data.Managers.BoardManager>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				if (BoardManager.AreAllNewThemesSeenForBoard((Boards.BoardId)instance13.jumperSignature))
				{
					height = 3;
					selectButtonHighlight.tag = null;
					selectBoardSkinHighlight.tag = (string)1;
				}
			}
		}
		if (Input.GetKeyDown((string)13) || Input.GetKeyDown((string)32))
		{
			selectButton.OnFinishedWatchingVideo();
		}
	}
}
