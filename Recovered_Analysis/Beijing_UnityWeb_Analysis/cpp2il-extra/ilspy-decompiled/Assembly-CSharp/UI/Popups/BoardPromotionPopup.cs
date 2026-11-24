using System;
using Cpp2ILInjected;
using Info;
using SYBO.Subway.Promotion;
using UI.Generic;
using UI.Generic.Layout;
using UI.Popups.CloudSaveConfirmationPopupInternal;
using UI.Screens;
using UnityEngine;

namespace UI.Popups;

public class BoardPromotionPopup : UIScreen
{
	private readonly Vector3 MODEL_POSITION;

	private const int SCREEN_REFERENCE_HEIGHT = 480;

	private GameObject _topAnchor;

	private UILabel _popupBoardTitle;

	private UILabel _popupBoardSubTitle;

	private UITexture _popupStickerTexture;

	private TimerHelper _timerPrefab;

	private Transform _timerContainer;

	private Layout _timerLayout;

	private TimerHelper _timer;

	private Transform _boardAnchor;

	private BoardSelectButton _boardSelectButtonPrefab;

	private Transform _boardSelectButtonParent;

	private BoardSelectButton _boardSelectButton;

	private BoardPromotion boardPromotion;

	private const int BoardSelectButtonWidth = 135;

	private const int BoardSelectButtonHeight = 50;

	private UISprite backgroundSprite;

	private UISprite flashSprite;

	public override void Init()
	{
		((UpgradeScreen)this).Start();
	}

	public unsafe override void Show()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_069a: Unknown result type (might be due to invalid IL or missing references)
		//IL_069f: Expected Obj, but got Unknown
		//IL_06c1: Expected I, but got Obj
		//IL_06d7: Expected Obj, but got I
		//IL_06fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ff: Expected Obj, but got Unknown
		//IL_0711: Expected Obj, but got I4
		//IL_072b: Expected I, but got Obj
		//IL_0741: Expected Obj, but got I
		//IL_0767: Unknown result type (might be due to invalid IL or missing references)
		//IL_076c: Expected I4, but got Unknown
		//IL_0021: Expected I, but got Obj
		//IL_0146: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Expected Obj, but got Unknown
		//IL_016d: Expected I4, but got Obj
		//IL_006e: Expected I, but got Obj
		//IL_00bb: Expected I, but got Obj
		//IL_00d1: Expected Obj, but got I
		//IL_00fc: Expected I, but got Obj
		//IL_0327: Unknown result type (might be due to invalid IL or missing references)
		//IL_032c: Expected Obj, but got Unknown
		//IL_0335: Unknown result type (might be due to invalid IL or missing references)
		//IL_033a: Expected Obj, but got Unknown
		//IL_0366: Expected Obj, but got I4
		//IL_0422: Expected Obj, but got I
		//IL_0207: Expected I, but got Obj
		//IL_021d: Expected Obj, but got I
		//IL_04db: Expected Obj, but got I4
		//IL_04e9: Expected I, but got Obj
		//IL_04ff: Expected Obj, but got I
		//IL_0819: Unknown result type (might be due to invalid IL or missing references)
		//IL_081e: Expected Obj, but got Unknown
		//IL_0826: Expected Obj, but got I4
		//IL_0831: Unknown result type (might be due to invalid IL or missing references)
		//IL_0836: Expected Obj, but got Unknown
		//IL_0458: Unknown result type (might be due to invalid IL or missing references)
		//IL_045d: Expected Obj, but got Unknown
		//IL_0248: Expected I, but got Obj
		//IL_058a: Unknown result type (might be due to invalid IL or missing references)
		//IL_058f: Expected Obj, but got Unknown
		//IL_0597: Expected Obj, but got I4
		//IL_05a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a7: Expected Obj, but got Unknown
		//IL_052a: Expected I, but got Obj
		//IL_02cf: Expected Obj, but got I4
		//IL_05cb: Expected Obj, but got I4
		//IL_05d9: Expected I, but got Obj
		//IL_05ef: Expected Obj, but got I
		//IL_048e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0493: Expected Obj, but got Unknown
		//IL_02dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e2: Expected Obj, but got Unknown
		//IL_02b7: Expected Obj, but got I4
		//IL_061a: Expected I, but got Obj
		//IL_02fd: Expected I4, but got Obj
		//IL_0670: Expected Obj, but got I4
		object obj2 = default;
		object obj = obj2 + 48;
		object obj3 = obj2 + 16;
		obj3 = obj;
		_ = -1;
		ShowIfInactive();
		nint num = (nint)typeof(PromotionManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v16 (Il2CppClass<UI.Screens.PromotionManager>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num2 = (nint)typeof(PromotionManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S0_v164 (Il2CppClass<UI.Screens.PromotionManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj5 = this + 100;
		bool flag = UIScreen.IsScreenHeightOutOfProportion();
		BoardPromotion boardPromotion = ((PromotionManager)flag).TryGetCurrentPromotion<BoardPromotion>();
		obj5 = boardPromotion;
		nint num3 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ S1_v14 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num4 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ S1_v142 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		UIWidget.Pivot pivot = (UIWidget.Pivot)(obj2 + 24);
		if (this.boardPromotion != null)
		{
			nint num5 = (nint)typeof(Debug);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S0_v154 (Il2CppClass<UnityEngine.Debug>)+BA]");
			object obj7 = (nint)0 & (nint)0x200;
			if (obj7 != null)
			{
				nint num6 = (nint)typeof(Debug);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ S0_v160 (Il2CppClass<UnityEngine.Debug>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Debug.LogException((Exception)(object)"Current Promotion is not a board promotion.");
			return;
		}
		object obj8 = this.boardPromotion + 32;
		obj2 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ S2_v9+8]");
		_ = 0;
		((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		backgroundSprite.rawPivot = pivot;
		GameObject gameObject = backgroundSprite.gameObject;
		object current = ((Transform.Enumerator)(object)gameObject).Current;
		object obj9 = default;
		object obj11 = default;
		object obj14 = default;
		object obj15 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
			if (obj9 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				nint num7 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v366 @ S0_v125 (Il2CppClass<UnityEngine.Object>)+BA]");
				object obj10 = (nint)0 & (nint)0x200;
				if (obj10 != null)
				{
					nint num8 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v377 @ S0_v146 (Il2CppClass<UnityEngine.Object>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
				object obj12;
				if (obj11 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
					obj12 = 0;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
					obj12 = 0;
				}
				object obj13 = obj12 & 1;
				if (obj13 == null)
				{
					((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
					continue;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1AD");
				if (obj14 == obj15)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @99");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9A");
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A4");
				}
				break;
			}
			object obj16 = obj3 + 4;
			object obj17 = obj16 + 1;
			obj16 = obj17;
			object obj18 = obj17 << 2;
			object obj19 = obj3 + obj18;
			obj19 = 182;
			break;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AE");
		object obj20 = default;
		if (obj20 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @741D");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v12+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v12+4]");
			object obj21 = (nint)0 << 2;
			object obj22 = obj3 + obj21;
			if ((nint)obj22 == 182)
			{
				object obj23 = obj3 + 4;
				if ((nint)obj23 > -1)
				{
					object obj24 = obj23 + -1;
					obj23 = obj24;
				}
				goto IL_0873;
			}
		}
		object obj25 = default;
		if (obj25 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		goto IL_0873;
		IL_0873:
		BoardPromotion boardPromotion2 = this.boardPromotion;
		InitializeTimer();
		InitializeSelectButton();
		OnCloseClicked();
		((CloudSaveConfirmationPopup)this).SetupConfirmation((CloudSaveConfirmationPopupPayload)boardPromotion2._boardId);
		nint num9 = (nint)typeof(PromotionManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v406 @ S1_v44 (Il2CppClass<UI.Screens.PromotionManager>)+BA]");
		object obj26 = (nint)0 & (nint)0x200;
		if (obj26 != null)
		{
			nint num10 = (nint)typeof(PromotionManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v424 @ S1_v83 (Il2CppClass<UI.Screens.PromotionManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag2 = UIScreen.IsScreenHeightOutOfProportion();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num11 = 0;
		_ = 0;
		object obj28 = default;
		object obj27 = obj28 + 16;
		obj27 = flag2;
		object obj29 = _boardSelectButton + 164;
		obj29 = obj28;
		bool flag3 = UIScreen.IsScreenHeightOutOfProportion();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num12 = 0;
		_ = 0;
		object obj31 = default;
		object obj30 = obj31 + 16;
		obj30 = flag3;
		object obj32 = _boardSelectButton + 160;
		obj32 = obj31;
		bool isInstanced = UIScreenController.IsInstanced;
		object obj33 = (isInstanced ? 1 : 0) - -64;
		nint num13 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v495 @ S1_v70 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj34 = (nint)0 & (nint)0x200;
		if (obj34 != null)
		{
			nint num14 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v500 @ S1_v79 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if ((UnityEngine.Object)obj33 != null)
		{
			bool isInstanced2 = UIScreenController.IsInstanced;
			object obj35 = (isInstanced2 ? 1 : 0) - -64;
			string text = _boardAnchor.tag;
			obj35 = text;
		}
	}

	public unsafe override void Hide()
	{
		//IL_0022: Expected Obj, but got I4
		//IL_005c: Expected VT, but got I4
		//IL_005c: Expected Obj, but got I4
		//IL_005c: Expected Obj, but got I4
		//IL_005c: Expected Obj, but got I4
		base.Hide();
		bool isInstanced = UIScreenController.IsInstanced;
		((UIModelController)isInstanced).SelectCurrentlyShownBoard(Boards.BoardId.rome);
		bool isInstanced2 = UIScreenController.IsInstanced;
		BoardPromotion boardPromotion = this.boardPromotion;
		NGUITools.FitOnScreen((Camera)isInstanced2, (Transform)boardPromotion._boardId, (Transform)12, (Vector3)1, out *(Bounds*)null);
	}

	public override void GainFocus()
	{
		//IL_0022: Expected Obj, but got I4
		base.LoseFocus();
		bool isInstanced = UIScreenController.IsInstanced;
		((UIModelController)isInstanced).ClearScreenAnchor(UIModelController.ModelScreen.BoardPromotionPopup);
	}

	public unsafe override void LoseFocus()
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0039: Expected Obj, but got I4
		//IL_0073: Expected VT, but got I4
		//IL_0073: Expected Obj, but got I4
		//IL_0073: Expected Obj, but got I4
		//IL_0073: Expected Obj, but got I4
		string text = _boardAnchor.tag;
		((GameObject)(object)text).tag = (string)1;
		bool isInstanced = UIScreenController.IsInstanced;
		((UIModelController)isInstanced).SelectCurrentlyShownBoard(Boards.BoardId.rome);
		bool isInstanced2 = UIScreenController.IsInstanced;
		BoardPromotion boardPromotion = this.boardPromotion;
		NGUITools.FitOnScreen((Camera)isInstanced2, (Transform)boardPromotion._boardId, (Transform)12, (Vector3)1, out *(Bounds*)null);
	}

	private void InitBoardAnchor()
	{
		//IL_0035: Expected Obj, but got I4
		string text = _boardAnchor.tag;
		((GameObject)(object)text).tag = null;
		bool isInstanced = UIScreenController.IsInstanced;
		((UIModelController)isInstanced).ClearScreenAnchor(UIModelController.ModelScreen.BoardPromotionPopup);
	}

	private void InitializeSelectButton()
	{
		//IL_0259: Unknown result type (might be due to invalid IL or missing references)
		//IL_025e: Expected Obj, but got Unknown
		//IL_0264: Unknown result type (might be due to invalid IL or missing references)
		//IL_0269: Expected Obj, but got Unknown
		//IL_028f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0294: Expected Obj, but got Unknown
		//IL_02c9: Expected I, but got Obj
		//IL_02df: Expected Obj, but got I
		//IL_0313: Expected I, but got Obj
		//IL_0329: Expected Obj, but got I
		//IL_034f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0354: Expected Obj, but got Unknown
		//IL_035d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0362: Expected Obj, but got Unknown
		//IL_036b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0370: Expected Obj, but got Unknown
		//IL_0379: Unknown result type (might be due to invalid IL or missing references)
		//IL_037e: Expected Obj, but got Unknown
		//IL_0387: Unknown result type (might be due to invalid IL or missing references)
		//IL_038c: Expected Obj, but got Unknown
		//IL_039e: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_00ad: Expected I, but got Obj
		//IL_00c3: Expected Obj, but got I
		//IL_03d8: Expected Obj, but got I
		//IL_03e7: Expected VT, but got Obj
		//IL_03f5: Expected I, but got Obj
		//IL_040b: Expected Obj, but got I
		//IL_0467: Expected VT, but got Obj
		//IL_04a6: Expected VT, but got Obj
		//IL_00ee: Expected I, but got Obj
		//IL_01c0: Expected VT, but got Obj
		//IL_01cf: Expected VT, but got Obj
		//IL_013b: Expected I, but got Obj
		//IL_01e3: Expected VT, but got Obj
		//IL_01ec: Expected Obj, but got I4
		object obj = default;
		Transform transform = (Transform)(obj + 72);
		object obj2 = this + 40;
		transform = (Transform)obj2;
		Transform transform2 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S2_v3+8]");
		((UnityEngine.Object)transform2).m_CachedPtr = (IntPtr)0;
		Transform transform3 = (Transform)(obj + 84);
		transform3 = transform;
		((UnityEngine.Object)transform3).m_CachedPtr = ((UnityEngine.Object)transform).m_CachedPtr;
		Vector3 eulerAngles = transform3.eulerAngles;
		nint num = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S0_v11 (Il2CppClass<UIScreenController>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num2 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ S0_v56 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = UIScreenController.ShouldShowOnlineScreen();
		nint num3 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ S1_v12 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num4 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ S1_v63 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj5 = obj + 60;
		Transform transform4 = (Transform)(obj + 48);
		Transform transform5 = (Transform)(obj + 36);
		Transform transform6 = (Transform)(obj + 24);
		Transform transform7 = (Transform)(obj + 12);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ S0_v16 (System.Boolean)+3C]");
		if (((ComputeShader)0).FindKernel(null) == 0)
		{
			return;
		}
		nint num5 = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ S0_v22 (Il2CppClass<UIScreenController>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num6 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ S0_v52 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag2 = UIScreenController.ShouldShowOnlineScreen();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ S0_v27 (System.Boolean)+3C]");
		object obj7 = 0;
		transform.localScale = (Vector3)_boardAnchor;
		nint num7 = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v157 @ S0_v32 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj8 = (nint)0 & (nint)0x200;
		if (obj8 != null)
		{
			nint num8 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ S0_v48 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		transform3 = transform;
		((UnityEngine.Object)transform3).m_CachedPtr = ((UnityEngine.Object)transform).m_CachedPtr;
		float num9 = 480f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ S0_v28+14]");
		float num10 = num9 / 0f;
		Vector3 vector = (Vector3)transform3 / num10;
		transform3 = (Transform)obj5;
		Transform transform8 = transform3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ S1_v17+8]");
		((UnityEngine.Object)transform8).m_CachedPtr = (IntPtr)0;
		_boardAnchor.parent = transform3;
		transform4.localPosition = (Vector3)_boardAnchor;
		float num11 = 1f / num10;
		float num12 = 1f - num11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ S1_v19 (UnityEngine.Transform)+4]");
		float num13 = 0f * num12;
		transform5.localPosition = (Vector3)_boardAnchor;
		transform6.localPosition = (Vector3)_boardAnchor;
		transform7.localPosition = (Vector3)_boardAnchor;
		obj = 0;
		_ = 0;
		obj = transform5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ S1_v23 (UnityEngine.Transform)+4]");
		float num14 = 0f + num13;
		_ = ((UnityEngine.Object)transform7).m_CachedPtr;
		transform3 = (Transform)obj;
		Transform transform9 = transform3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((UnityEngine.Object)transform9).m_CachedPtr = (IntPtr)0;
		Vector3 eulerAngles2 = transform3.eulerAngles;
	}

	private void InitializeTimer()
	{
		//IL_00f2: Expected I, but got Obj
		//IL_0108: Expected Obj, but got I
		//IL_0181: Unknown result type (might be due to invalid IL or missing references)
		//IL_0186: Expected Obj, but got Unknown
		//IL_01c0: Expected I, but got Obj
		//IL_01d6: Expected Obj, but got I
		//IL_0137: Unknown result type (might be due to invalid IL or missing references)
		//IL_013c: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_00da: Expected Obj, but got I4
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v13 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v31 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj2 = this + 96;
		BoardSelectButton boardSelectButton = UnityEngine.Object.Instantiate(_boardSelectButtonPrefab, _boardSelectButtonParent);
		obj2 = boardSelectButton;
		GameObject gameObject = _boardSelectButton.gameObject;
		nint num3 = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S1_v9 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num4 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ S1_v25 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Vector3 one = Vector3.one;
		object obj4 = default;
		Transform transform = (Transform)(obj4 + 12);
		transform = (Transform)obj4;
		Transform transform2 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((UnityEngine.Object)transform2).m_CachedPtr = (IntPtr)0;
		Vector3 eulerAngles = transform.eulerAngles;
		_boardSelectButton.rewardedBreakComplete(withReward: true);
		UIWidget component = _boardSelectButton.GetComponent<UIWidget>();
		component.height = 135;
		UIWidget component2 = _boardSelectButton.GetComponent<UIWidget>();
		Color color = ((UIWidget)50).color;
	}

	public unsafe void OnCloseClicked()
	{
		//IL_00be: Expected I, but got Obj
		//IL_00d4: Expected Obj, but got I
		//IL_0203: Unknown result type (might be due to invalid IL or missing references)
		//IL_0208: Expected Obj, but got Unknown
		//IL_0233: Expected I, but got Obj
		//IL_0249: Expected Obj, but got I
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Expected Obj, but got Unknown
		//IL_0108: Expected Obj, but got VT
		//IL_0111: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Expected Obj, but got Unknown
		//IL_0127: Unknown result type (might be due to invalid IL or missing references)
		//IL_012c: Expected VT, but got Unknown
		//IL_0139: Expected F4, but got Obj
		//IL_0134: Expected native int or pointer, but got VT
		//IL_0142: Unknown result type (might be due to invalid IL or missing references)
		//IL_0147: Expected Obj, but got Unknown
		//IL_015d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0162: Expected Obj, but got Unknown
		//IL_016b: Expected Obj, but got VT
		//IL_0174: Unknown result type (might be due to invalid IL or missing references)
		//IL_0179: Expected Obj, but got Unknown
		//IL_018e: Expected F4, but got Obj
		//IL_0189: Expected native int or pointer, but got VT
		//IL_01a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a9: Expected I4, but got Unknown
		//IL_01b6: Expected I4, but got Obj
		//IL_01d0: Expected F4, but got Obj
		//IL_01cb: Expected native int or pointer, but got VT
		//IL_01e5: Expected F4, but got I
		//IL_01e0: Expected native int or pointer, but got VT
		//IL_01f8: Expected I4, but got VT
		//IL_0013: Expected I, but got Obj
		//IL_00af: Expected Obj, but got I4
		//IL_0060: Expected I, but got Obj
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v13 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v24 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj2 = this + 80;
		TimerHelper timerHelper = UnityEngine.Object.Instantiate(_timerPrefab, _timerContainer);
		obj2 = timerHelper;
		nint num3 = (nint)typeof(GlobalColorsGenerated);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ S1_v8 (Il2CppClass<GlobalColorsGenerated>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num4 = (nint)typeof(GlobalColorsGenerated);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ S1_v33 (Il2CppClass<GlobalColorsGenerated>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj5 = default;
		object obj4 = obj5 + 44;
		obj4 = GlobalColorsGenerated.WEEKLYHUNT_TIMER_TEXT;
		object obj6 = obj5 + 40;
		obj6 = obj4;
		Matrix4x4 matrix4x = (Matrix4x4)(obj5 - -64);
		((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj6;
		object obj7 = obj5 + 24;
		Matrix4x4 matrix4x2 = Matrix4x4.Inverse(matrix4x);
		object obj8 = obj5 + 20;
		obj8 = GlobalColorsGenerated.WEEKLYHUNT_TIMER_BG;
		object obj9 = obj5 + 16;
		obj9 = obj8;
		((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj9;
		Matrix4x4 matrix4x3 = Matrix4x4.Inverse(matrix4x);
		bool flag = (byte)(obj5 + 48) != 0;
		((bool*)(flag ? 1 : 0))->m_value = (byte)(int)obj7 != 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ S1_v19+8]");
		_ = 0;
		((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((Matrix4x4*)(nint)matrix4x)->m20 = 0f;
		_timer.AnimateClock(flag, (byte)(int)matrix4x != 0);
		_timer.SetTimerText((string)1);
	}

	private void SetupTop(Boards.BoardId boardId)
	{
		//IL_0189: Expected I, but got Obj
		//IL_019f: Expected Obj, but got I
		//IL_0251: Expected I, but got Obj
		//IL_0267: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_00b4: Expected I4, but got Obj
		//IL_00b4: Expected Obj, but got I
		//IL_0060: Expected I, but got Obj
		//IL_00e0: Expected I4, but got Obj
		//IL_00e0: Expected Obj, but got I
		//IL_00ee: Expected I, but got Obj
		//IL_0104: Expected Obj, but got I
		//IL_0204: Expected Obj, but got I4
		//IL_0210: Expected Obj, but got I8
		//IL_0219: Unknown result type (might be due to invalid IL or missing references)
		//IL_021e: Expected Obj, but got Unknown
		//IL_012f: Expected I, but got Obj
		nint num = (nint)typeof(Boards);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v9 (Il2CppClass<Info.Boards>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Boards);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v26 (Il2CppClass<Info.Boards>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Boards.Board board = Boards.boardData.get_Item(boardId);
		nint num3 = (nint)typeof(Strings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S1_v6 (Il2CppClass<Strings>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ S1_v31 (Il2CppClass<Strings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string format = Strings.GetDefault("BOARD_DISPLAY_NAME_WITH_SUFFIX");
		string args = Strings.GetDefault(board.name);
		string text = string.Format(format, (object[])(object)args);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.Popups.BoardPromotionPopup)+2C]");
		((UILabel)0).fontSize = (int)text;
		string text2 = Strings.GetDefault(board.limitedDescription);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.Popups.BoardPromotionPopup)+30]");
		((UILabel)0).fontSize = (int)text2;
		nint num5 = (nint)typeof(BoardBundlePopupManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ S1_v18 (Il2CppClass<UI.Screens.BoardBundlePopupManager>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num6 = (nint)typeof(BoardBundlePopupManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ S1_v27 (Il2CppClass<UI.Screens.BoardBundlePopupManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		int pageIndex = ChallengesScreen.GetPageIndex();
		long currentTimestamp = ((BoardBundlePopupManager)pageIndex).GetCurrentTimestamp();
		object obj4 = currentTimestamp;
		object obj5 = obj4 + 8;
		obj5 = obj4;
		throw new ArrayTypeMismatchException();
	}

	private void OnDestroy()
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_00ab: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UIScreenController>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v12 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = UIScreenController.ShouldShowOnlineScreen();
		((UIScreenController)flag).ClosePopup((GameObject)(object)screenName);
	}

	public BoardPromotionPopup()
	{
		//IL_0017: Expected Obj, but got I4
		//IL_0017: Expected Obj, but got I4
		bool isInstanced = UIScreenController.IsInstanced;
		((UIPowerupHandler)isInstanced).DisablePowerupSlot((UIPowerupHelper)12);
	}
}
