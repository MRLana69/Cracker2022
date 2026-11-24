using System;
using System.Collections.Generic;
using ABTest;
using Cpp2ILInjected;
using Data.Save;
using Info;
using Kiloo.Common.Extensions;
using Kiloo.Common.Timer;
using SYBO.Subway.Info;
using UI.Breadcrumbs;
using UI.Footer;
using UI.FreeStuff;
using UI.Generic;
using UI.Generic.Layout;
using UI.Pages.DailyChallengePageInternal;
using UI.Popups.ABTestTesterPopupInternal;
using UI.Popups.ConsumablesPopupInternal;
using UnityEngine;

namespace UI.Pages;

public class DailyChallengePage : Page
{
	private PageTop _topPrefab;

	private GameObject _iconPrefab;

	private UIWidget _scalingElement;

	private PageTop _top;

	private TimerHelper _timerPrefab;

	private UIWidget _rewardGuide;

	private GameObject _superMysteryBoxPrefab;

	private Layout _dayParent;

	private RegularDayHelper _dayPrefab;

	private FinalDayHelper _finalDay;

	private List<UI.Pages.DailyChallengePageInternal.DayHelper> _dayHelpers;

	private TimerHelper _timer;

	private GameObject _superMysteryBoxObject;

	private Vector3 _rotationFrom;

	private Vector3 _rotationTo;

	private float _currentRewardRotationDuration;

	private int _rewardRotationDirection;

	public unsafe override void Init(UIWidget pageGuideWidget)
	{
		//IL_020d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0212: Expected Obj, but got Unknown
		//IL_022e: Expected I4, but got Obj
		//IL_0242: Expected I4, but got Obj
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Expected Obj, but got Unknown
		//IL_0048: Expected I, but got Obj
		//IL_005e: Expected Obj, but got I
		//IL_0270: Expected Obj, but got I
		//IL_0289: Expected I, but got Obj
		//IL_029f: Expected Obj, but got I
		//IL_0089: Expected I, but got Obj
		//IL_00d6: Expected I, but got Obj
		//IL_03a8: Expected Obj, but got I4
		//IL_03da: Expected Obj, but got I4
		//IL_0130: Expected I, but got Obj
		//IL_0146: Expected Obj, but got I
		//IL_01ee: Expected I4, but got Obj
		//IL_01ee: Expected Obj, but got I4
		//IL_0201: Expected I4, but got Obj
		//IL_0313: Expected Obj, but got I
		//IL_0323: Expected Obj, but got I
		//IL_0333: Expected Obj, but got I
		//IL_033c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0341: Expected Obj, but got Unknown
		//IL_034a: Unknown result type (might be due to invalid IL or missing references)
		//IL_034f: Expected Obj, but got Unknown
		//IL_01c5: Expected Obj, but got I4
		//IL_0171: Expected I, but got Obj
		object obj = this + 40;
		obj = pageGuideWidget;
		((UILabel)topContainer).fontSize = (int)pageGuideWidget.topAnchor;
		((UILabel)(object)_topPrefab).fontSize = (int)pageGuideWidget.leftAnchor;
		GameObject iconPrefab = _iconPrefab;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr = 0;
		EventDelegate.Callback callback = default;
		((Delegate)callback).method_ptr = method_ptr;
		((Delegate)callback).method = (nint)__ldftn(ABTestTesterCellHelper.PayloadSelected);
		object obj2 = callback + 16;
		obj2 = this;
		nint num = (nint)typeof(EventDelegate);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S1_v15 (Il2CppClass<EventDelegate>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num2 = (nint)typeof(EventDelegate);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ S1_v50 (Il2CppClass<EventDelegate>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S0_v12 (UnityEngine.GameObject)+2C]");
		bool flag = EventDelegate.Remove((List<EventDelegate>)0, callback);
		_rewardGuide = null;
		nint num3 = (nint)typeof(ABTestManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S1_v22 (Il2CppClass<ABTest.ABTestManager>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num4 = (nint)typeof(ABTestManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ S1_v46 (Il2CppClass<ABTest.ABTestManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string debugPayload = ABTestManager.GetDebugPayload((string)(object)pageGuideWidget.leftAnchor);
		string text2;
		if (debugPayload != null)
		{
			UIRect.AnchorUpdate updateAnchors = pageGuideWidget.updateAnchors;
			nint num5 = (nint)typeof(ABTestManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ S0_v34 (Il2CppClass<ABTest.ABTestManager>)+BA]");
			object obj5 = (nint)0 & (nint)0x200;
			if (obj5 != null)
			{
				nint num6 = (nint)typeof(ABTestManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ S0_v47 (Il2CppClass<ABTest.ABTestManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			uint num7 = _003CPrivateImplementationDetails_003E.ComputeStringHash((string)(object)pageGuideWidget.leftAnchor);
			nint num8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ S4_v3 (Il2CppMethodInfo)+C]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ S4_v4+60]");
			object obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ S4_v5+8C]");
			object obj8 = 0;
			object obj9 = obj8 & 0x7FF;
			object obj10 = obj9 + 39195;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v113 @ S5_v5 (should have been resolved before IL gen)");
			string text = default;
			if ((nint)text < 0)
			{
				text2 = null;
			}
			else
			{
				_rewardGuide = (UIWidget)1;
				text2 = text;
			}
		}
		else
		{
			text2 = null;
		}
		bool flag2 = (object)_rewardGuide != null;
		string text3 = (string)((flag2 ? 1 : 0) ^ 1);
		((GameObject)(object)_top).tag = text3;
		bool flag3 = (object)_rewardGuide != null;
		((GameObject)(object)_timerPrefab).tag = (string)flag3;
		((PurchaseHandler)(object)_iconPrefab).OnPurchaseCharacterWithInappSucceded((Characters.CharacterId)pageGuideWidget.updateAnchors, text2);
		string text4 = ((List<string>)pageGuideWidget.updateAnchors).get_Item((int)text2);
		((UILabel)_scalingElement).fontSize = (int)text4;
	}

	public override void Show()
	{
		CancelInvoke();
	}

	public override void Hide()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_01f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f5: Expected Obj, but got Unknown
		//IL_01fe: Expected Obj, but got I4
		//IL_020d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0212: Expected Obj, but got Unknown
		//IL_0238: Expected Obj, but got I4
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Expected Obj, but got Unknown
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Expected Obj, but got Unknown
		//IL_00b5: Expected Obj, but got I4
		//IL_013d: Expected Obj, but got I
		//IL_0173: Unknown result type (might be due to invalid IL or missing references)
		//IL_0178: Expected Obj, but got Unknown
		//IL_01a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ae: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 48;
		object obj3 = obj2 + 24;
		obj3 = 0;
		_ = 0;
		object obj4 = obj2 + 16;
		obj4 = obj;
		_ = -1;
		string text = tag;
		((GameObject)(object)text).tag = (string)1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @10F7C");
		obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		object obj5 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			if (obj5 == null)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
		}
		object obj6 = obj4 + 4;
		object obj7 = obj6 + 1;
		obj6 = obj7;
		object obj8 = obj7 << 2;
		object obj9 = obj4 + obj8;
		obj9 = 63;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
			object obj10 = (nint)0 << 2;
			object obj11 = obj4 + obj10;
			if ((nint)obj11 == 63)
			{
				object obj12 = obj4 + 4;
				if ((nint)obj12 > -1)
				{
					object obj13 = obj12 + -1;
					obj12 = obj13;
				}
				goto IL_0280;
			}
		}
		object obj14 = default;
		if (obj14 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		goto IL_0280;
		IL_0280:
		this._002Ector();
		((Breadcrumb)null)._002Ector();
	}

	private void Update()
	{
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Expected Obj, but got Unknown
		//IL_009a: Expected I, but got Obj
		//IL_00b0: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected Obj, but got Unknown
		string text = tag;
		((GameObject)(object)text).tag = null;
		object obj = this - -64;
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S1_v6 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S1_v14 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)obj).FindKernel((string)null) != 0)
		{
			object obj3 = this - -64;
			((GameObject)obj3).tag = null;
		}
	}

	private unsafe void RotateReward(Transform transformToRotate)
	{
		//IL_06b9: Expected I, but got Obj
		//IL_06cf: Expected Obj, but got I
		//IL_06f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_06f7: Expected Obj, but got Unknown
		//IL_072f: Expected I, but got Obj
		//IL_0745: Expected Obj, but got I
		//IL_076b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0770: Expected VT, but got Unknown
		//IL_0782: Unknown result type (might be due to invalid IL or missing references)
		//IL_0787: Expected Obj, but got Unknown
		//IL_078f: Expected Obj, but got VT
		//IL_0013: Expected I, but got Obj
		//IL_00b6: Expected I, but got Obj
		//IL_00cc: Expected Obj, but got I
		//IL_0060: Expected I, but got Obj
		//IL_07c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ce: Expected Obj, but got Unknown
		//IL_07ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_07f2: Expected Obj, but got Unknown
		//IL_014c: Expected I, but got Obj
		//IL_0162: Expected Obj, but got I
		//IL_00f7: Expected I, but got Obj
		//IL_081b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0820: Expected Obj, but got Unknown
		//IL_0837: Expected Obj, but got I4
		//IL_0872: Unknown result type (might be due to invalid IL or missing references)
		//IL_0877: Expected Obj, but got Unknown
		//IL_0892: Unknown result type (might be due to invalid IL or missing references)
		//IL_0897: Expected Obj, but got Unknown
		//IL_08ae: Expected Obj, but got I4
		//IL_08e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_08ee: Expected Obj, but got Unknown
		//IL_0909: Unknown result type (might be due to invalid IL or missing references)
		//IL_090e: Expected Obj, but got Unknown
		//IL_01da: Expected Obj, but got I4
		//IL_0215: Unknown result type (might be due to invalid IL or missing references)
		//IL_021a: Expected Obj, but got Unknown
		//IL_0235: Unknown result type (might be due to invalid IL or missing references)
		//IL_023a: Expected Obj, but got Unknown
		//IL_0251: Expected Obj, but got I4
		//IL_028c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0291: Expected Obj, but got Unknown
		//IL_018d: Expected I, but got Obj
		//IL_02df: Expected Obj, but got I
		//IL_02e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ed: Expected Obj, but got Unknown
		//IL_02f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fd: Expected Obj, but got Unknown
		//IL_034b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0350: Expected Obj, but got Unknown
		//IL_0470: Unknown result type (might be due to invalid IL or missing references)
		//IL_0475: Expected Obj, but got Unknown
		//IL_0483: Expected I, but got Obj
		//IL_0499: Expected Obj, but got I
		//IL_03a3: Expected I, but got Obj
		//IL_03b9: Expected Obj, but got I
		//IL_04c4: Expected I, but got Obj
		//IL_03e4: Expected I, but got Obj
		//IL_0516: Unknown result type (might be due to invalid IL or missing references)
		//IL_051b: Expected Obj, but got Unknown
		//IL_053f: Expected Obj, but got I
		//IL_0551: Expected I, but got Obj
		//IL_0567: Expected Obj, but got I
		//IL_09b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_09b7: Expected Obj, but got Unknown
		//IL_09c6: Expected Obj, but got I4
		//IL_09dc: Expected Obj, but got I4
		//IL_09ee: Expected I, but got Obj
		//IL_0a04: Expected Obj, but got I
		//IL_0a21: Expected I, but got Obj
		//IL_0a45: Expected Obj, but got I
		//IL_0a68: Expected I, but got Obj
		//IL_0a7e: Expected Obj, but got I
		//IL_0aa1: Expected I, but got Obj
		//IL_0ab7: Expected Obj, but got I
		//IL_0ad5: Expected Obj, but got I4
		//IL_0b0a: Expected VT, but got Obj
		//IL_0b47: Expected VT, but got I4
		//IL_0bb0: Expected VT, but got Obj
		//IL_0bab: Expected native int or pointer, but got VT
		//IL_0bb8: Expected Obj, but got VT
		//IL_0592: Expected I, but got Obj
		//IL_05df: Expected I, but got Obj
		//IL_060f: Expected I, but got Obj
		//IL_0680: Unknown result type (might be due to invalid IL or missing references)
		//IL_0685: Expected Obj, but got Unknown
		//IL_0635: Expected I, but got Obj
		GameObject parent = topContainer.gameObject;
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v14 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v145 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj2 = this + 28;
		PageTop pageTop = UnityEngine.Object.Instantiate(_topPrefab, (Transform)(object)parent);
		obj2 = pageTop;
		GameObject gameObject = _top.gameObject;
		nint num3 = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ S1_v10 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num4 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ S1_v206 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj4 = default;
		PrizePositionData.TransformValues? transformValues = (PrizePositionData.TransformValues?)(object)(obj4 + 104);
		Vector3 one = Vector3.one;
		Transform transform = (Transform)(obj4 + 144);
		transform = (Transform)transformValues;
		Transform transform2 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ S1_v15 (System.Nullable`1<PrizePositionData+TransformValues>)+8]");
		((UnityEngine.Object)transform2).m_CachedPtr = (IntPtr)0;
		Vector3 eulerAngles = transform.eulerAngles;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		PageTop.TopIconPayload topIconPayload = default;
		topIconPayload._002Ector();
		nint num5 = (nint)typeof(Strings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ S1_v24 (Il2CppClass<Strings>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num6 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ S1_v202 (Il2CppClass<Strings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj6 = topIconPayload + 8;
		string text = Strings.GetDefault("DAILY_CHALLENGE_WORD_HUNT");
		obj6 = text;
		object obj7 = topIconPayload + 12;
		string text2 = Strings.GetDefault("DAILY_CHALLENGE_COLLECT");
		string text3 = text2.ToUpperInvariant();
		obj7 = text3;
		nint num7 = (nint)typeof(ColorData);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ S1_v33 (Il2CppClass<UI.ColorData>)+BA]");
		object obj8 = (nint)0 & (nint)0x200;
		if (obj8 != null)
		{
			nint num8 = (nint)typeof(ColorData);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ S1_v198 (Il2CppClass<UI.ColorData>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj9 = obj4 + 88;
		bool flag = HoverboardStickerManager.ShouldShowHoverboardStickerFlow();
		object obj10 = (flag ? 1 : 0) + 140;
		obj9 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ S2_v26+8]");
		_ = 0;
		transform = (Transform)obj9;
		Transform transform3 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ S1_v38+8]");
		((UnityEngine.Object)transform3).m_CachedPtr = (IntPtr)0;
		object obj11 = topIconPayload + 20;
		obj11 = transform;
		_ = ((UnityEngine.Object)transform).m_CachedPtr;
		object obj12 = obj4 + 72;
		bool flag2 = HoverboardStickerManager.ShouldShowHoverboardStickerFlow();
		object obj13 = (flag2 ? 1 : 0) + 204;
		obj12 = obj13;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v172 @ S2_v42+8]");
		_ = 0;
		transform = (Transform)obj12;
		Transform transform4 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v166 @ S1_v46+8]");
		((UnityEngine.Object)transform4).m_CachedPtr = (IntPtr)0;
		object obj14 = topIconPayload + 36;
		obj14 = transform;
		_ = ((UnityEngine.Object)transform).m_CachedPtr;
		object obj15 = obj4 + 56;
		bool flag3 = HoverboardStickerManager.ShouldShowHoverboardStickerFlow();
		object obj16 = (flag3 ? 1 : 0) + 908;
		obj15 = obj16;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v201 @ S2_v58+8]");
		_ = 0;
		transform = (Transform)obj15;
		Transform transform5 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v195 @ S1_v54+8]");
		((UnityEngine.Object)transform5).m_CachedPtr = (IntPtr)0;
		object obj17 = topIconPayload + 52;
		obj17 = transform;
		_ = ((UnityEngine.Object)transform).m_CachedPtr;
		object obj18 = obj4 + 40;
		bool flag4 = HoverboardStickerManager.ShouldShowHoverboardStickerFlow();
		object obj19 = (flag4 ? 1 : 0) + 924;
		obj18 = obj19;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v230 @ S2_v74+8]");
		_ = 0;
		transform = (Transform)obj18;
		Transform transform6 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v224 @ S1_v62+8]");
		((UnityEngine.Object)transform6).m_CachedPtr = (IntPtr)0;
		object obj20 = topIconPayload + 68;
		obj20 = transform;
		_ = ((UnityEngine.Object)transform).m_CachedPtr;
		_top.MakeIcon(topIconPayload);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint cachedPtr = 0;
		UIWidget uIWidget = default;
		((UnityEngine.Object)uIWidget).m_CachedPtr = cachedPtr;
		uIWidget.bottomAnchor = (UIRect.AnchorPoint)0;
		object obj21 = uIWidget + 16;
		obj21 = this;
		object obj22 = this + 60;
		GameObject gameObject2 = ((WeeklyHuntPage)(object)_top)._003CInit_003Eb__32_2(uIWidget);
		TimerHelper component = gameObject2.GetComponent<TimerHelper>();
		obj22 = component;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		PageTop._003C_003Ec__DisplayClass32_0 obj23 = default;
		obj23._002Ector();
		object obj24 = obj23 + 8;
		obj24 = _iconPrefab;
		((WeeklyHuntPage)(object)_top).Init((UIWidget)(object)obj23);
		((PageTop)(object)this).Setup((PageTop.EventsPageTopPayload)(object)transformToRotate);
		int num9 = 0;
		while (num9 <= 3)
		{
			GameObject parent2 = _dayParent.gameObject;
			nint num10 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v332 @ S2_v114 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj25 = (nint)0 & (nint)0x200;
			if (obj25 != null)
			{
				nint num11 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v343 @ S2_v122 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			RegularDayHelper regularDayHelper = UnityEngine.Object.Instantiate(_dayPrefab, (Transform)(object)parent2);
			regularDayHelper._dayIndex = num9;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7266");
			_dayHelpers.Add(regularDayHelper);
			int num12 = num9 + 1;
			num9 = num12;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7266");
		_dayHelpers.Add(_finalDay);
		((RewardForVideoButton)(object)_dayParent).Init((VideoButtonPayload)null);
		object obj26 = this - -64;
		nint num13 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v364 @ S1_v96 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj27 = (nint)0 & (nint)0x200;
		if (obj27 != null)
		{
			nint num14 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v374 @ S1_v187 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (!((UnityEngine.Object)obj26 != null))
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		object obj29 = default;
		object obj28 = obj29 + 48;
		obj28 = this;
		bool isInstanced = UIScreenController.IsInstanced;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v422 @ S0_v61 (System.Boolean)+28]");
		int layer = ((GameObject)0).layer;
		nint num15 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v429 @ S0_v67 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj30 = (nint)0 & (nint)0x200;
		if (obj30 != null)
		{
			nint num16 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v435 @ S0_v133 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj31 = this - -64;
		GameObject gameObject3 = UnityEngine.Object.Instantiate(_superMysteryBoxPrefab, (Transform)layer);
		obj31 = gameObject3;
		Color color = MiscExtensions.ToColor((string)31);
		nint num17 = (nint)typeof(PrizePositionData);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v457 @ S0_v77 (Il2CppClass<PrizePositionData>)+BA]");
		object obj32 = (nint)0 & (nint)0x200;
		bool flag5 = obj32 == null;
		nint num18 = (nint)typeof(PrizePositionData);
		if (!flag5)
		{
			nint num19 = (nint)typeof(PrizePositionData);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v463 @ S0_v127 (Il2CppClass<PrizePositionData>)+74]");
			bool flag6 = (nint)0 == 0;
			bool flag7 = !flag6;
			num18 = (nint)typeof(PrizePositionData);
			if (!flag7)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				num18 = (nint)typeof(PrizePositionData);
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v467 @ L1_v7 (Il2CppClass<PrizePositionData>)+5C]");
		object obj33 = (nint)0 + (nint)180;
		obj12 = obj33;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v475 @ S1_v114+8]");
		_ = 0;
		nint num20 = (nint)typeof(PrizePositionData);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v483 @ S1_v119 (Il2CppClass<PrizePositionData>)+5C]");
		object obj34 = (nint)0 + (nint)204;
		obj15 = obj34;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v486 @ S1_v121+8]");
		_ = 0;
		nint num21 = (nint)typeof(PrizePositionData);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v494 @ S1_v126 (Il2CppClass<PrizePositionData>)+5C]");
		object obj35 = (nint)0 + (nint)192;
		obj18 = obj35;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v497 @ S1_v128+8]");
		_ = 0;
		obj4 = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		obj9 = obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v166 @ S1_v46+8]");
		_ = 0;
		transformValues = (PrizePositionData.TransformValues?)obj15;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v195 @ S1_v54+8]");
		_ = 0;
		transform = (Transform)obj18;
		Transform transform7 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v224 @ S1_v62+8]");
		((UnityEngine.Object)transform7).m_CachedPtr = (IntPtr)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7CEF");
		transformValues = (PrizePositionData.TransformValues?)(object)0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		transform = (Transform)obj4;
		Transform transform8 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((UnityEngine.Object)transform8).m_CachedPtr = (IntPtr)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+10]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+18]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+20]");
		_ = 0;
		*(PrizePositionData.TransformValues?*)(nint)transformValues = (PrizePositionData.TransformValues)transform;
		transform = (Transform)transformValues;
		Transform transform9 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ S1_v15 (System.Nullable`1<PrizePositionData+TransformValues>)+8]");
		((UnityEngine.Object)transform9).m_CachedPtr = (IntPtr)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ S1_v15 (System.Nullable`1<PrizePositionData+TransformValues>)+10]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ S1_v15 (System.Nullable`1<PrizePositionData+TransformValues>)+18]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ S1_v15 (System.Nullable`1<PrizePositionData+TransformValues>)+20]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8262");
		string self = tag;
		GameObject.Internal_CreateGameObject((GameObject)(object)self, "ResetAndUpdateAnchors");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num22 = 0;
		string text4 = default;
		text4.m_stringLength = (int)num22;
		_ = 0;
		object obj36 = text4 + 16;
		obj36 = obj29;
		Timer.Log(text4);
	}

	private void RefreshDailyChallenge()
	{
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Expected Obj, but got Unknown
		//IL_0093: Expected I, but got Obj
		//IL_00a9: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected Obj, but got Unknown
		//IL_0074: Expected Obj, but got I4
		object obj = this - -64;
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S1_v4 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S1_v14 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)obj).FindKernel((string)null) != 0)
		{
			object obj3 = this - -64;
			int layer = ((GameObject)obj3).layer;
			((MissionsPage)this).Init((UIWidget)layer);
		}
	}

	public override FooterButton.FooterPayload GetButtonPayload()
	{
		return (FooterButton.FooterPayload)(object)_dayPrefab;
	}

	public DailyChallengePage()
	{
		//IL_00cc: Expected I, but got Obj
		//IL_00e2: Expected Obj, but got I
		//IL_013b: Expected Obj, but got VT
		//IL_0144: Unknown result type (might be due to invalid IL or missing references)
		//IL_0149: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(EventsSave);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v4 (Il2CppClass<Data.Save.EventsSave>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(EventsSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S1_v26 (Il2CppClass<Data.Save.EventsSave>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		DateTime wordHuntExpireDeviceTime = EventsSave.wordHuntExpireDeviceTime;
		object obj2 = wordHuntExpireDeviceTime;
		object obj3 = obj2 + 8;
		obj3 = obj2;
		throw new ArrayTypeMismatchException();
	}

	private GameObject _003CInit_003Eb__17_0(UIWidget w)
	{
		//IL_000a: Expected I4, but got Obj
		//IL_003b: Expected Obj, but got I
		if (((SellConsumablesHelper)(object)this).GetConsumableUpgradeType((byte)(int)w != 0) != UpgradeType._notset)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5 @ S0_v2 (Info.UpgradeType)+8]");
			return (GameObject)0;
		}
		return null;
	}
}
