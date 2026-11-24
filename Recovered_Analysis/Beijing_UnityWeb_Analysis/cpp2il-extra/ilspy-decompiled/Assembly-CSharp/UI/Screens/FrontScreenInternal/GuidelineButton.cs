using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Cpp2ILInjected;
using Data.Save;
using Info;
using Kiloo.Common.Utility;
using TopRun;
using UI.Screens.CoinScreenInternal;
using UI.Screens.RewardManagement;
using UnityEngine;
using UnityEngine.Rendering;

namespace UI.Screens.FrontScreenInternal;

public class GuidelineButton : MonoBehaviour
{
	public enum GuidelineButtonType
	{
		NotSet,
		Hoverboard,
		FacebookOrCollect,
		Mission1,
		PlayerMenuIntroduction,
		ShopMenuIntroduction
	}

	private enum AnimationState
	{
		None,
		Scaling,
		Blinking,
		Waiting
	}

	private UISprite _infoSprite;

	private UISprite _infoSpriteOverlay;

	private GameObject _breadcrumb;

	private GameObject _discount;

	private bool _showIcon;

	public GuidelineButtonType guidelineButtonType;

	private bool _hasInited;

	private const float SCALE_DURATION = 1f;

	private const float WAIT_DURATION = 2f;

	private const float BLINK_DURATION = 1f;

	private readonly Vector3 _startScale;

	private readonly Vector3 _endScale;

	private AnimationState _animationState;

	private float _currentAnimationTime;

	private void Awake()
	{
		CancelInvoke();
	}

	private void OnEnable()
	{
		string text = _infoSprite.tag;
		((GameObject)(object)text).tag = null;
		string text2 = _infoSpriteOverlay.tag;
		((GameObject)(object)text2).tag = null;
	}

	public void DetermineVisibility()
	{
		if (~(_hasInited ? 1u : 0u) != 0)
		{
			Update();
			_hasInited = true;
		}
		string text = _infoSprite.tag;
		((GameObject)(object)text).tag = null;
		string text2 = _infoSpriteOverlay.tag;
		((GameObject)(object)text2).tag = null;
		OnClick();
	}

	private void OnClick()
	{
		//IL_001e: Expected I, but got Obj
		//IL_0034: Expected Obj, but got I
		//IL_00bd: Expected I, but got Obj
		//IL_00d3: Expected Obj, but got I
		//IL_005f: Expected I, but got Obj
		//IL_00fe: Expected I, but got Obj
		//IL_014b: Expected Obj, but got I4
		int counterForElementsOnDisplay = ((CoinContainer)this).counterForElementsOnDisplay;
		if (counterForElementsOnDisplay != 0)
		{
			InitAnimation();
		}
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v11 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v26 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		int num3 = ((ComputeShader)(object)_discount).FindKernel((string)null);
		if ((counterForElementsOnDisplay & num3) != 0)
		{
			_discount.tag = null;
		}
		nint num4 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ S1_v9 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num5 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ S1_v17 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)_breadcrumb).FindKernel((string)null) != 0)
		{
			string text = (string)(counterForElementsOnDisplay ^ 1);
			_breadcrumb.tag = text;
		}
	}

	public bool ShouldInfoIconShow()
	{
		//IL_0605: Unknown result type (might be due to invalid IL or missing references)
		//IL_060a: Expected Obj, but got Unknown
		//IL_0614: Expected Obj, but got I
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected Obj, but got Unknown
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Expected Obj, but got Unknown
		//IL_00ff: Expected Obj, but got I4
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0128: Expected Obj, but got Unknown
		//IL_0132: Expected Obj, but got I4
		//IL_016d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0172: Expected Obj, but got Unknown
		//IL_017c: Expected Obj, but got I4
		//IL_01bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c1: Expected Obj, but got Unknown
		//IL_01cb: Expected Obj, but got VT
		//IL_0227: Unknown result type (might be due to invalid IL or missing references)
		//IL_022c: Expected Obj, but got Unknown
		//IL_023c: Expected Obj, but got I
		//IL_0288: Expected Obj, but got I
		//IL_02a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ae: Expected Obj, but got Unknown
		//IL_02e5: Expected Obj, but got F4
		//IL_0315: Expected Obj, but got I
		//IL_0339: Unknown result type (might be due to invalid IL or missing references)
		//IL_033e: Expected Obj, but got Unknown
		//IL_034e: Expected Obj, but got I
		//IL_0395: Expected Obj, but got I
		//IL_03c5: Expected Obj, but got I
		//IL_03f0: Expected Obj, but got I
		//IL_045d: Expected Obj, but got I
		//IL_048d: Expected Obj, but got I
		//IL_04b6: Expected I, but got Obj
		//IL_04cc: Expected Obj, but got I
		//IL_06d2: Expected Obj, but got I
		//IL_04f7: Expected I, but got Obj
		//IL_05d1: Expected Obj, but got I4
		//IL_0544: Expected I, but got Obj
		//IL_055a: Expected Obj, but got I
		//IL_0676: Unknown result type (might be due to invalid IL or missing references)
		//IL_067b: Expected Obj, but got Unknown
		//IL_0692: Expected I, but got Obj
		//IL_06a8: Expected Obj, but got I
		//IL_0585: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		StringBuilder stringBuilder = default;
		System.Text.StringBuilderCache.Release(stringBuilder);
		object obj2 = default;
		object obj = obj2 + 32;
		obj = (nint)((UnityEngine.Object)this).m_CachedPtr;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		int index = default;
		StringBuilder stringBuilder2 = stringBuilder.FindChunkForIndex(index);
		StringBuilder stringBuilder3 = stringBuilder2.AppendLine(",");
		object obj3 = obj2 + 28;
		obj3 = _infoSprite;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		int index2 = default;
		StringBuilder stringBuilder4 = stringBuilder.FindChunkForIndex(index2);
		StringBuilder stringBuilder5 = stringBuilder4.AppendLine(",");
		StringBuilder stringBuilder6 = stringBuilder.Append(_breadcrumb);
		StringBuilder stringBuilder7 = stringBuilder6.AppendLine(",");
		object obj4 = obj2 + 24;
		obj4 = _discount;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		int index3 = default;
		StringBuilder stringBuilder8 = stringBuilder.FindChunkForIndex(index3);
		StringBuilder stringBuilder9 = stringBuilder8.AppendLine(",");
		StringBuilder stringBuilder10 = stringBuilder.Append(_showIcon);
		StringBuilder stringBuilder11 = stringBuilder10.AppendLine(",");
		object obj5 = obj2 + 20;
		obj5 = guidelineButtonType;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		int index4 = default;
		StringBuilder stringBuilder12 = stringBuilder.FindChunkForIndex(index4);
		StringBuilder stringBuilder13 = stringBuilder12.AppendLine(",");
		object obj6 = obj2 + 16;
		obj6 = _hasInited;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		int index5 = default;
		StringBuilder stringBuilder14 = stringBuilder.FindChunkForIndex(index5);
		StringBuilder stringBuilder15 = stringBuilder14.AppendLine(",");
		object obj7 = obj2 + 12;
		obj7 = _startScale;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		int index6 = default;
		StringBuilder stringBuilder16 = stringBuilder.FindChunkForIndex(index6);
		StringBuilder stringBuilder17 = stringBuilder16.AppendLine(",");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F0D8");
		StringBuilder stringBuilder19 = default;
		StringBuilder stringBuilder18 = stringBuilder19.AppendLine(",");
		object obj8 = obj2 + 8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.Screens.FrontScreenInternal.GuidelineButton)+38]");
		obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		int index7 = default;
		StringBuilder stringBuilder20 = stringBuilder.FindChunkForIndex(index7);
		StringBuilder stringBuilder21 = stringBuilder20.AppendLine(",");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.Screens.FrontScreenInternal.GuidelineButton)+3C]");
		StringBuilder stringBuilder22 = stringBuilder.AppendLine((string)0);
		StringBuilder stringBuilder23 = stringBuilder22.AppendLine(",");
		object value = this - -64;
		StringBuilder stringBuilder24 = stringBuilder.Append(value);
		StringBuilder stringBuilder25 = stringBuilder24.AppendLine(",");
		StringBuilder stringBuilder26 = stringBuilder.Append((object)_currentAnimationTime);
		StringBuilder stringBuilder27 = stringBuilder26.AppendLine(",");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.Screens.FrontScreenInternal.GuidelineButton)+48]");
		StringBuilder stringBuilder28 = stringBuilder.Append((object)0);
		StringBuilder stringBuilder29 = stringBuilder28.AppendLine(",");
		object obj9 = obj2 + 4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.Screens.FrontScreenInternal.GuidelineButton)+4C]");
		obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		int index8 = default;
		StringBuilder stringBuilder30 = stringBuilder.FindChunkForIndex(index8);
		StringBuilder stringBuilder31 = stringBuilder30.AppendLine(",");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.Screens.FrontScreenInternal.GuidelineButton)+50]");
		StringBuilder stringBuilder32 = stringBuilder.Append((object)0);
		StringBuilder stringBuilder33 = stringBuilder32.AppendLine(",");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.Screens.FrontScreenInternal.GuidelineButton)+54]");
		StringBuilder stringBuilder34 = stringBuilder.AppendLine((string)0);
		StringBuilder stringBuilder35 = stringBuilder34.AppendLine(",");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.Screens.FrontScreenInternal.GuidelineButton)+60]");
		obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		int index9 = default;
		StringBuilder stringBuilder36 = stringBuilder.FindChunkForIndex(index9);
		StringBuilder stringBuilder37 = stringBuilder36.AppendLine(",");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F0D8");
		StringBuilder stringBuilder39 = default;
		StringBuilder stringBuilder38 = stringBuilder39.AppendLine(",");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.Screens.FrontScreenInternal.GuidelineButton)+70]");
		StringBuilder stringBuilder40 = stringBuilder.AppendLine((string)0);
		StringBuilder stringBuilder41 = stringBuilder40.AppendLine(",");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.Screens.FrontScreenInternal.GuidelineButton)+5C]");
		StringBuilder stringBuilder42 = stringBuilder.AppendLine((string)0);
		StringBuilder stringBuilder43 = stringBuilder42.AppendLine(",");
		nint num = (nint)typeof(CelebrationReward._003C_003Ec);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v287 @ S0_v94 (Il2CppClass<UI.Screens.RewardManagement.CelebrationReward+<>c>)+BA]");
		object obj10 = (nint)0 & (nint)0x200;
		if (obj10 != null)
		{
			nint num2 = (nint)typeof(CelebrationReward._003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v293 @ S0_v136 (Il2CppClass<UI.Screens.RewardManagement.CelebrationReward+<>c>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = CelebrationReward._003C_003Ec._003C_003E9__23_0 == null;
		bool flag2 = !flag;
		Func<HoverboardThemes.ThemeIdentifier, string> selector = CelebrationReward._003C_003Ec._003C_003E9__23_0;
		if (!flag2)
		{
			nint num3 = (nint)typeof(CelebrationReward._003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v313 @ S0_v110 (Il2CppClass<UI.Screens.RewardManagement.CelebrationReward+<>c>)+BA]");
			object obj11 = (nint)0 & (nint)0x200;
			if (obj11 != null)
			{
				nint num4 = (nint)typeof(CelebrationReward._003C_003Ec);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v344 @ S0_v130 (Il2CppClass<UI.Screens.RewardManagement.CelebrationReward+<>c>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num5 = 0;
			_ = 0;
			Func<HoverboardThemes.ThemeIdentifier, string> func = default;
			object obj12 = func + 16;
			obj12 = CelebrationReward._003C_003Ec._003C_003E9;
			nint num6 = (nint)typeof(CelebrationReward._003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v375 @ S0_v127 (Il2CppClass<UI.Screens.RewardManagement.CelebrationReward+<>c>)+5C]");
			object obj13 = (nint)0 + (nint)4;
			obj13 = func;
			selector = func;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.Screens.FrontScreenInternal.GuidelineButton)+58]");
		IEnumerable<string> source = Enumerable.Select((IEnumerable<HoverboardThemes.ThemeIdentifier>)0, selector);
		string[] strB = Enumerable.ToArray(source);
		int num7 = string.CompareOrdinalIgnoreCaseHelper(";", (string)(object)strB);
		StringBuilder stringBuilder44 = stringBuilder.AppendLine((string)num7);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		bool result = default;
		return result;
	}

	private void ForceAnimation()
	{
		//IL_0b94: Expected Obj, but got I4
		//IL_0574: Expected I, but got Obj
		//IL_058a: Expected Obj, but got I
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected Obj, but got Unknown
		//IL_004b: Expected Obj, but got I4
		//IL_06c6: Expected I, but got Obj
		//IL_06dc: Expected Obj, but got I
		//IL_0cda: Expected Obj, but got I4
		//IL_0ce8: Expected I, but got Obj
		//IL_0cfe: Expected Obj, but got I
		//IL_077e: Expected I, but got Obj
		//IL_0794: Expected Obj, but got I
		//IL_0d73: Expected Obj, but got I4
		//IL_0d29: Expected I, but got Obj
		//IL_0d3f: Expected Obj, but got I
		//IL_05b5: Expected I, but got Obj
		//IL_091f: Expected I, but got Obj
		//IL_0935: Expected Obj, but got I
		//IL_0d8f: Expected Obj, but got I4
		//IL_0d9d: Expected I, but got Obj
		//IL_0db3: Expected Obj, but got I
		//IL_0707: Expected I, but got Obj
		//IL_0602: Expected I, but got Obj
		//IL_0a71: Expected I, but got Obj
		//IL_0a87: Expected Obj, but got I
		//IL_0e17: Expected I, but got Obj
		//IL_0e2d: Expected Obj, but got I
		//IL_07bf: Expected I, but got Obj
		//IL_064f: Expected I, but got Obj
		//IL_0eb5: Expected I, but got Obj
		//IL_0ecb: Expected Obj, but got I
		//IL_0e58: Expected Obj, but got I4
		//IL_0e66: Expected I, but got Obj
		//IL_0e7c: Expected Obj, but got I
		//IL_0960: Expected I, but got Obj
		//IL_080c: Expected I, but got Obj
		//IL_0408: Expected I, but got Obj
		//IL_041e: Expected Obj, but got I
		//IL_0303: Expected I, but got Obj
		//IL_0319: Expected Obj, but got I
		//IL_00e5: Expected I, but got Obj
		//IL_00fb: Expected Obj, but got I
		//IL_0ef6: Expected Obj, but got I4
		//IL_0f04: Expected I, but got Obj
		//IL_0f1a: Expected Obj, but got I
		//IL_0ab2: Expected I, but got Obj
		//IL_09ad: Expected I, but got Obj
		//IL_0c72: Expected Obj, but got I4
		//IL_01c5: Expected I, but got Obj
		//IL_01db: Expected Obj, but got I
		//IL_0aff: Expected I, but got Obj
		//IL_09fa: Expected I, but got Obj
		//IL_0cbe: Expected Obj, but got I4
		//IL_0344: Expected I, but got Obj
		//IL_0126: Expected I, but got Obj
		//IL_0b4c: Expected I, but got Obj
		//IL_04f8: Expected I, but got Obj
		//IL_0c98: Expected Obj, but got I4
		//IL_0206: Expected I, but got Obj
		//IL_0478: Expected I, but got Obj
		//IL_0253: Expected I, but got Obj
		//IL_0269: Expected Obj, but got I
		//IL_0c4d: Expected Obj, but got I4
		//IL_02e1: Expected Obj, but got I4
		//IL_0294: Expected I, but got Obj
		object obj = 0;
		if (~(_showIcon ? 1u : 0u) == 0)
		{
			_showIcon = false;
			_infoSprite.tag = null;
			_infoSpriteOverlay.tag = null;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @76BC");
			object obj2 = this - -64;
			obj2 = 0;
			if (guidelineButtonType == GuidelineButtonType.FacebookOrCollect && OnboardingSave.shouldShowFacebookPopup)
			{
				OnboardingSave.hasShownFacebookPopup = true;
				OnboardingSave.shouldShowFacebookPopup = false;
				return;
			}
			if (guidelineButtonType == GuidelineButtonType.FacebookOrCollect && OnboardingSave.shouldShowHoverboardPopup)
			{
				nint num = (nint)typeof(AgeRestriction);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v310 @ S0_v253 (Il2CppClass<Info.AgeRestriction>)+BA]");
				object obj3 = (nint)0 & (nint)0x200;
				if (obj3 != null)
				{
					nint num2 = (nint)typeof(AgeRestriction);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v353 @ S0_v262 (Il2CppClass<Info.AgeRestriction>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				if (!AgeRestriction.waitForAgeRestriction)
				{
					OnboardingSave.hasShownHoverboardPopup = true;
					OnboardingSave.shouldShowHoverboardPopup = false;
					return;
				}
			}
			if (guidelineButtonType == GuidelineButtonType.FacebookOrCollect)
			{
				bool flag = OnboardingSave.ShouldShowStickersForCharacterThemes();
				if ((flag ? 1 : 0) != 2)
				{
					nint num3 = (nint)typeof(TopRunMaintenance);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v363 @ S0_v225 (Il2CppClass<TopRun.TopRunMaintenance>)+BA]");
					object obj4 = (nint)0 & (nint)0x200;
					if (obj4 != null)
					{
						nint num4 = (nint)typeof(TopRunMaintenance);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v404 @ S0_v246 (Il2CppClass<TopRun.TopRunMaintenance>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					IManager manager = TopRunRoot.manager;
					if (manager == null)
					{
						nint num5 = (nint)typeof(UIScreenController);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v459 @ S0_v233 (Il2CppClass<UIScreenController>)+BA]");
						object obj5 = (nint)0 & (nint)0x200;
						if (obj5 != null)
						{
							nint num6 = (nint)typeof(UIScreenController);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v488 @ S0_v242 (Il2CppClass<UIScreenController>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						bool flag2 = UIScreenController.ShouldShowOnlineScreen();
						((UIScreenController)flag2).SwitchScreen("TopRunUI");
						bool flag3 = UIScreenController.ShouldShowOnlineScreen();
						((UIScreenController)flag3)._ActivateNextPopup("TopRunPopup");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @928F");
						return;
					}
				}
			}
			if (guidelineButtonType == GuidelineButtonType.Hoverboard)
			{
				nint num7 = (nint)typeof(UIScreenController);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v315 @ S0_v209 (Il2CppClass<UIScreenController>)+BA]");
				object obj6 = (nint)0 & (nint)0x200;
				if (obj6 != null)
				{
					nint num8 = (nint)typeof(UIScreenController);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v367 @ S0_v217 (Il2CppClass<UIScreenController>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				bool flag4 = UIScreenController.ShouldShowOnlineScreen();
				((UIScreenController)flag4)._ActivateNextPopup("TutorialHoverboardsPopup");
				OnboardingSave.hasShownMissionIntroPopup = true;
				OnboardingSave.shouldShowMissionIntroPopup = false;
				return;
			}
			if (guidelineButtonType != GuidelineButtonType.Mission1)
			{
				if (guidelineButtonType == GuidelineButtonType.NotSet)
				{
					string args = tag;
					SDebug.LogFormat("A guideline button wiggler is not set properly.", (object[])(object)args);
				}
				return;
			}
			bool shouldShowEndGameMissionPopup = OnboardingSave.shouldShowEndGameMissionPopup;
			nint num9 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v419 @ S1_v78 (Il2CppClass<UIScreenController>)+BA]");
			object obj7 = (nint)0 & (nint)0x200;
			bool flag5 = obj7 == null;
			if (shouldShowEndGameMissionPopup)
			{
				if (!flag5)
				{
					nint num10 = (nint)typeof(UIScreenController);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v464 @ S0_v198 (Il2CppClass<UIScreenController>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				bool flag6 = UIScreenController.ShouldShowOnlineScreen();
				((UIScreenController)flag6)._ActivateNextPopup("TutorialMissionPopup");
				OnboardingSave.hasShownEndGameMissionPopup = true;
				OnboardingSave.shouldShowEndGameMissionPopup = false;
				return;
			}
			if (!flag5)
			{
				nint num11 = (nint)typeof(UIScreenController);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v473 @ S0_v187 (Il2CppClass<UIScreenController>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool flag7 = UIScreenController.ShouldShowOnlineScreen();
			((UIScreenController)flag7).SwitchScreen("ChallengesScreen");
			return;
		}
		if (guidelineButtonType == GuidelineButtonType.FacebookOrCollect)
		{
			nint num12 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v120 (Il2CppClass<UIScreenController>)+BA]");
			object obj8 = (nint)0 & (nint)0x200;
			if (obj8 != null)
			{
				nint num13 = (nint)typeof(UIScreenController);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ S0_v149 (Il2CppClass<UIScreenController>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool flag8 = UIScreenController.ShouldShowOnlineScreen();
			((UIScreenController)flag8).SwitchScreen("LeaderboardUI");
			nint num14 = (nint)typeof(UIScreens);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ S0_v127 (Il2CppClass<UIScreens>)+BA]");
			object obj9 = (nint)0 & (nint)0x200;
			if (obj9 != null)
			{
				nint num15 = (nint)typeof(UIScreens);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v166 @ S0_v143 (Il2CppClass<UIScreens>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			nint num16 = (nint)typeof(Flurry);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v179 @ S0_v135 (Il2CppClass<Flurry>)+BA]");
			object obj10 = (nint)0 & (nint)0x200;
			if (obj10 != null)
			{
				nint num17 = (nint)typeof(Flurry);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v281 @ S0_v139 (Il2CppClass<Flurry>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			return;
		}
		if (guidelineButtonType == GuidelineButtonType.Hoverboard)
		{
			nint num18 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v109 (Il2CppClass<UIScreenController>)+BA]");
			object obj11 = (nint)0 & (nint)0x200;
			if (obj11 != null)
			{
				nint num19 = (nint)typeof(UIScreenController);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ S0_v115 (Il2CppClass<UIScreenController>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool flag9 = UIScreenController.ShouldShowOnlineScreen();
			((UIScreenController)flag9)._ActivateNextPopup("ConsumablesPopup");
			return;
		}
		if (guidelineButtonType == GuidelineButtonType.Mission1)
		{
			nint num20 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ S0_v76 (Il2CppClass<UIScreenController>)+BA]");
			object obj12 = (nint)0 & (nint)0x200;
			if (obj12 != null)
			{
				nint num21 = (nint)typeof(UIScreenController);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ S0_v104 (Il2CppClass<UIScreenController>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool flag10 = UIScreenController.ShouldShowOnlineScreen();
			((UIScreenController)flag10).SwitchScreen("ChallengesScreen");
			nint num22 = (nint)typeof(ChallengesScreen);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v287 @ S0_v83 (Il2CppClass<UI.Screens.ChallengesScreen>)+BA]");
			object obj13 = (nint)0 & (nint)0x200;
			if (obj13 != null)
			{
				nint num23 = (nint)typeof(ChallengesScreen);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v324 @ S0_v100 (Il2CppClass<UI.Screens.ChallengesScreen>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC24");
			object obj14 = default;
			obj = obj14;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
			throw new NullReferenceException();
		}
		if (guidelineButtonType == GuidelineButtonType.PlayerMenuIntroduction)
		{
			nint num24 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ S0_v52 (Il2CppClass<UIScreenController>)+BA]");
			object obj15 = (nint)0 & (nint)0x200;
			if (obj15 != null)
			{
				nint num25 = (nint)typeof(UIScreenController);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v188 @ S0_v71 (Il2CppClass<UIScreenController>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool flag11 = UIScreenController.ShouldShowOnlineScreen();
			nint num26 = (nint)typeof(UIScreens);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v294 @ S1_v28 (Il2CppClass<UIScreens>)+BA]");
			object obj16 = (nint)0 & (nint)0x200;
			if (obj16 != null)
			{
				nint num27 = (nint)typeof(UIScreens);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v334 @ S1_v36 (Il2CppClass<UIScreens>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			((UIScreenController)flag11).SwitchScreen(UIScreens.meMenu_lastScreen);
			nint num28 = (nint)typeof(Flurry);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v388 @ S0_v63 (Il2CppClass<Flurry>)+BA]");
			object obj17 = (nint)0 & (nint)0x200;
			if (obj17 != null)
			{
				nint num29 = (nint)typeof(Flurry);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v428 @ S0_v67 (Il2CppClass<Flurry>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
		}
		else
		{
			if (guidelineButtonType != GuidelineButtonType.ShopMenuIntroduction)
			{
				return;
			}
			nint num30 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v198 @ S0_v29 (Il2CppClass<UIScreenController>)+BA]");
			object obj18 = (nint)0 & (nint)0x200;
			if (obj18 != null)
			{
				nint num31 = (nint)typeof(UIScreenController);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v300 @ S0_v47 (Il2CppClass<UIScreenController>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool flag12 = UIScreenController.ShouldShowOnlineScreen();
			nint num32 = (nint)typeof(UIScreens);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v347 @ S1_v12 (Il2CppClass<UIScreens>)+BA]");
			object obj19 = (nint)0 & (nint)0x200;
			if (obj19 != null)
			{
				nint num33 = (nint)typeof(UIScreens);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v392 @ S1_v20 (Il2CppClass<UIScreens>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			((UIScreenController)flag12).SwitchScreen(UIScreens.shopMenu_lastScreen);
			nint num34 = (nint)typeof(Flurry);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v439 @ S0_v40 (Il2CppClass<Flurry>)+BA]");
			object obj20 = (nint)0 & (nint)0x200;
			if (obj20 != null)
			{
				nint num35 = (nint)typeof(Flurry);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v456 @ S0_v43 (Il2CppClass<Flurry>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
		}
	}

	private void EnableInfoIcon()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected Obj, but got Unknown
		//IL_001a: Expected Obj, but got I4
		Update();
		object obj = this - -64;
		obj = 1;
		_currentAnimationTime = 0f;
	}

	private unsafe void InitAnimation()
	{
		//IL_0212: Expected Obj, but got I4
		//IL_0013: Expected Obj, but got I4
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected Obj, but got Unknown
		//IL_0050: Expected Obj, but got I4
		//IL_022d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0232: Expected Obj, but got Unknown
		//IL_023b: Expected Obj, but got I4
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Expected Obj, but got Unknown
		//IL_00ba: Expected Obj, but got I4
		//IL_00cf: Expected Obj, but got I4
		//IL_0137: Expected Obj, but got I4
		//IL_00fe: Expected Obj, but got I4
		//IL_0193: Unknown result type (might be due to invalid IL or missing references)
		//IL_0198: Expected Obj, but got Unknown
		//IL_01a1: Expected Obj, but got I4
		//IL_01b6: Expected Obj, but got I4
		//IL_01e5: Expected Obj, but got I4
		_showIcon = true;
		string text = _infoSprite.tag;
		((GameObject)(object)text).tag = (string)1;
		string text2 = _infoSpriteOverlay.tag;
		((GameObject)(object)text2).tag = (string)1;
		object obj = this - -64;
		if (obj != null)
		{
			return;
		}
		object obj2 = guidelineButtonType;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		string text4 = default;
		string text3 = text4 + "hasScaled";
		if (((LODParameters*)text3)->GetHashCode() == 0)
		{
			object obj3 = this - -64;
			obj3 = 1;
			_currentAnimationTime = 0f;
			obj2 = guidelineButtonType;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
			string text5 = default;
			string key = text5 + "hasScaled";
			PlayerPrefs.SetString(key, (string)1);
			return;
		}
		if (guidelineButtonType == GuidelineButtonType.FacebookOrCollect)
		{
			obj2 = guidelineButtonType;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
			string text6 = default;
			string key2 = text6 + "hasScaled";
			string text7 = PlayerPrefs.GetString(key2);
			if ((nint)text7 == 1)
			{
				object obj4 = this - -64;
				obj4 = 1;
				_currentAnimationTime = 0f;
				obj2 = guidelineButtonType;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
				string text8 = default;
				string key3 = text8 + "hasScaled";
				PlayerPrefs.SetString(key3, (string)2);
				return;
			}
		}
		object obj5 = this - -64;
		obj5 = 2;
		_currentAnimationTime = 0f;
	}

	private void Update()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @76BC");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @76BC");
	}

	public unsafe GuidelineButton()
	{
		//IL_053e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0543: Expected Obj, but got Unknown
		//IL_054c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0551: Expected VT, but got Unknown
		//IL_055a: Unknown result type (might be due to invalid IL or missing references)
		//IL_055f: Expected Obj, but got Unknown
		//IL_0568: Unknown result type (might be due to invalid IL or missing references)
		//IL_056d: Expected Obj, but got Unknown
		//IL_0576: Unknown result type (might be due to invalid IL or missing references)
		//IL_057b: Expected Obj, but got Unknown
		//IL_0584: Expected Obj, but got I4
		//IL_0590: Unknown result type (might be due to invalid IL or missing references)
		//IL_0595: Expected Obj, but got Unknown
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected Obj, but got Unknown
		//IL_05b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_05bd: Expected Obj, but got Unknown
		//IL_06e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e7: Expected Obj, but got Unknown
		//IL_0183: Expected I, but got Obj
		//IL_0199: Expected Obj, but got I
		//IL_0355: Expected I, but got Obj
		//IL_036b: Expected Obj, but got I
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Expected Obj, but got Unknown
		//IL_0094: Expected F4, but got Obj
		//IL_008f: Expected native int or pointer, but got VT
		//IL_00a9: Expected F4, but got I
		//IL_00a4: Expected native int or pointer, but got VT
		//IL_00b6: Expected Obj, but got F4
		//IL_00c8: Expected I, but got F4
		//IL_0517: Unknown result type (might be due to invalid IL or missing references)
		//IL_051c: Expected Obj, but got Unknown
		//IL_0525: Expected Obj, but got I4
		//IL_0329: Unknown result type (might be due to invalid IL or missing references)
		//IL_032e: Expected Obj, but got Unknown
		//IL_0337: Expected Obj, but got I4
		//IL_0752: Unknown result type (might be due to invalid IL or missing references)
		//IL_0757: Expected Obj, but got Unknown
		//IL_0772: Unknown result type (might be due to invalid IL or missing references)
		//IL_0777: Expected Obj, but got Unknown
		//IL_079a: Expected I, but got Obj
		//IL_07b0: Expected Obj, but got I
		//IL_01c4: Expected I, but got Obj
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Expected Obj, but got Unknown
		//IL_0642: Expected F4, but got Obj
		//IL_063d: Expected native int or pointer, but got VT
		//IL_0657: Expected F4, but got I
		//IL_0652: Expected native int or pointer, but got VT
		//IL_0685: Expected VT, but got Obj
		//IL_0148: Unknown result type (might be due to invalid IL or missing references)
		//IL_014d: Expected Obj, but got Unknown
		//IL_0156: Expected Obj, but got I4
		//IL_0447: Expected I, but got Obj
		//IL_021f: Expected I, but got Obj
		//IL_03d6: Expected I, but got Obj
		object obj = default;
		Transform transform = (Transform)(obj + 60);
		Quaternion quaternion = (Quaternion)(obj + 48);
		object obj2 = obj + 24;
		object obj3 = obj + 12;
		object obj4 = obj + 36;
		obj4 = 0;
		_ = 0;
		object obj5 = this - -64;
		if (obj5 == null)
		{
			return;
		}
		object obj6 = this - -64;
		if ((nint)obj6 == 1)
		{
			if (!(_currentAnimationTime < 1f))
			{
				Camera anchorCamera = _infoSprite.anchorCamera;
				object obj7 = this + 52;
				((Quaternion*)(nint)quaternion)->x = (float)obj7;
				Quaternion quaternion2 = quaternion;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v160 @ S2_v33+8]");
				((Quaternion*)(nint)quaternion2)->z = 0f;
				transform = (Transform)quaternion.x;
				((UnityEngine.Object)transform).m_CachedPtr = (IntPtr)quaternion.z;
				((Transform)(object)anchorCamera).parent = transform;
				Camera anchorCamera2 = _infoSpriteOverlay.anchorCamera;
				object obj8 = this + 52;
				obj2 = obj8;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v241 @ S2_v43+8]");
				_ = 0;
				transform = (Transform)obj2;
				Transform transform2 = transform;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13+8]");
				((UnityEngine.Object)transform2).m_CachedPtr = (IntPtr)0;
				((Transform)(object)anchorCamera2).parent = transform;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @76BC");
				object obj9 = this - -64;
				obj9 = 3;
				_currentAnimationTime = 0f;
			}
			else
			{
				float num = Easings.ElasticEaseInOut(_currentAnimationTime);
				nint num2 = (nint)typeof(Mathf);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v175 @ S0_v92 (Il2CppClass<UnityEngine.Mathf>)+BA]");
				object obj10 = (nint)0 & (nint)0x200;
				if (obj10 != null)
				{
					nint num3 = (nint)typeof(Mathf);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v206 @ S0_v128 (Il2CppClass<UnityEngine.Mathf>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				float num4 = num * 2f;
				float num5 = num4 - 1f;
				bool flag = 0f > num5;
				bool flag2 = !flag;
				float num6 = num5;
				if (!flag2)
				{
					num6 = 0f;
				}
				object obj11 = this + 40;
				obj2 = obj11;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v260 @ S1_v50+8]");
				_ = 0;
				object obj12 = this + 52;
				obj3 = obj12;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v269 @ S1_v55+8]");
				_ = 0;
				nint num7 = (nint)typeof(Vector3);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v276 @ S0_v104 (Il2CppClass<UnityEngine.Vector3>)+BA]");
				object obj13 = (nint)0 & (nint)0x200;
				if (obj13 != null)
				{
					nint num8 = (nint)typeof(Vector3);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v308 @ S0_v123 (Il2CppClass<UnityEngine.Vector3>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				((Quaternion*)(nint)quaternion)->x = (float)obj2;
				Quaternion quaternion3 = quaternion;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13+8]");
				((Quaternion*)(nint)quaternion3)->z = 0f;
				transform = (Transform)obj3;
				Transform transform3 = transform;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v15+8]");
				((UnityEngine.Object)transform3).m_CachedPtr = (IntPtr)0;
				Quaternion quaternion4 = Quaternion.Slerp(quaternion, (Quaternion)transform, num6);
				obj4 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
				_ = 0;
				Camera anchorCamera3 = _infoSprite.anchorCamera;
				transform = (Transform)obj4;
				Transform transform4 = transform;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v17+8]");
				((UnityEngine.Object)transform4).m_CachedPtr = (IntPtr)0;
				((Transform)(object)anchorCamera3).parent = transform;
				Camera anchorCamera4 = _infoSpriteOverlay.anchorCamera;
				transform = (Transform)obj4;
				Transform transform5 = transform;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v17+8]");
				((UnityEngine.Object)transform5).m_CachedPtr = (IntPtr)0;
				((Transform)(object)anchorCamera4).parent = transform;
				float num9 = num6 - 1f;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @76BC");
				float unscaledTime = Time.unscaledTime;
				float currentAnimationTime = _currentAnimationTime + unscaledTime;
				_currentAnimationTime = currentAnimationTime;
			}
		}
		object obj14 = this - -64;
		if ((nint)obj14 == 2)
		{
			if (!(_currentAnimationTime < 1f))
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @76BC");
				object obj15 = this - -64;
				obj15 = 3;
				_currentAnimationTime = 0f;
			}
			else
			{
				nint num10 = (nint)typeof(Mathf);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v188 @ S0_v52 (Il2CppClass<UnityEngine.Mathf>)+BA]");
				object obj16 = (nint)0 & (nint)0x200;
				bool flag3 = obj16 == null;
				if (_currentAnimationTime < 0.5f)
				{
					if (!flag3)
					{
						nint num11 = (nint)typeof(Mathf);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v281 @ S0_v76 (Il2CppClass<UnityEngine.Mathf>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					float num12 = Mathf.InverseLerp(0f, 2f, _currentAnimationTime);
				}
				else
				{
					if (!flag3)
					{
						nint num13 = (nint)typeof(Mathf);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v293 @ S0_v67 (Il2CppClass<UnityEngine.Mathf>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					float num12 = Mathf.InverseLerp(2f, 0f, _currentAnimationTime);
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @76BC");
				float unscaledTime2 = Time.unscaledTime;
				float currentAnimationTime2 = _currentAnimationTime + unscaledTime2;
				_currentAnimationTime = currentAnimationTime2;
			}
		}
		object obj17 = this - -64;
		if ((nint)obj17 == 3)
		{
			if (_currentAnimationTime < 2f)
			{
				float unscaledTime3 = Time.unscaledTime;
				float currentAnimationTime3 = _currentAnimationTime + unscaledTime3;
				_currentAnimationTime = currentAnimationTime3;
			}
			else
			{
				object obj18 = this - -64;
				obj18 = 2;
				_currentAnimationTime = 0f;
			}
		}
	}
}
