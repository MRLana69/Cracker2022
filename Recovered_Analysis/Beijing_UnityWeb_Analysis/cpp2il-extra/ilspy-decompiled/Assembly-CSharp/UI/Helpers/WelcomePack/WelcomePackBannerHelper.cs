using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2ILInjected;
using InApp;
using InAppPurchase;
using Info;
using Kiloo.Common.Backend.PurchaseValidation;
using SYBO.Components.Analytics;
using SYBO.Subway.Info;
using UI.Generic;
using UI.MessageCenter;
using UI.Popups;
using UI.RenderTexture;
using UI.Screens;
using UnityEngine;

namespace UI.Helpers.WelcomePack;

public class WelcomePackBannerHelper : MonoBehaviour
{
	private UILabel _title;

	private UILabel _boardName;

	private DefaultRenderTextureSetup _mainCellRenderTextureSetup;

	private UILabel _cell1Label;

	private DefaultRenderTextureSetup _cell1RenderTextureSetup;

	private UILabel _cell2Label;

	private DefaultRenderTextureSetup _cell2RenderTextureSetup;

	private UILabel _cell3Label;

	private DefaultRenderTextureSetup _cell3RenderTextureSetup;

	private UILabel _buyButtonLabel;

	private TimerHelper _timerPrefab;

	private UIWidget _timerContainer;

	private string _lastScreenNameWhenPressingBuy;

	private TimerHelper _timer;

	private InAppItemModel _inAppPack;

	private bool _isSetup;

	private void OnEnable()
	{
		((UpgradeScreen)this).Start();
	}

	private unsafe void LoadInAppPackIfNotLoaded()
	{
		//IL_0024: Expected I, but got Obj
		//IL_003a: Expected Obj, but got I
		//IL_0065: Expected I, but got Obj
		//IL_00b2: Expected I, but got Obj
		//IL_00c8: Expected Obj, but got I
		//IL_01bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c2: Expected Obj, but got Unknown
		//IL_00f3: Expected I, but got Obj
		if (WelcomePackManager.ParseFirstInstalledVersion() != 0)
		{
			Setup();
			SetupModels();
		}
		nint num = (nint)typeof(InAppManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S0_v9 (Il2CppClass<InApp.InAppManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(InAppManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S0_v27 (Il2CppClass<InApp.InAppManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		InAppManager instance = InAppManager.instance;
		if ((object)instance == null)
		{
			return;
		}
		nint num3 = (nint)typeof(InAppManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v17 (Il2CppClass<InApp.InAppManager>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(InAppManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v23 (Il2CppClass<InApp.InAppManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Dictionary<string, InAppItemModel> activeInAppOffers = InAppManager.GetActiveInAppOffers();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr = 0;
		InAppManager.OnPurchaseSuccess onPurchaseSuccess = default;
		((Delegate)onPurchaseSuccess).method_ptr = method_ptr;
		((Delegate)onPurchaseSuccess).method = (nint)__ldftn(WelcomePackBannerHelper.OnPurchaseSuccess);
		object obj3 = onPurchaseSuccess + 16;
		obj3 = this;
		((InAppManager)(object)activeInAppOffers).onPurchaseSuccess -= onPurchaseSuccess;
	}

	private void Setup()
	{
		//IL_005f: Expected I, but got Obj
		//IL_0075: Expected Obj, but got I
		//IL_0133: Unknown result type (might be due to invalid IL or missing references)
		//IL_0138: Expected Obj, but got Unknown
		//IL_014f: Expected Obj, but got I4
		//IL_00a0: Expected I, but got Obj
		if (_inAppPack != null)
		{
			return;
		}
		bool flag;
		if (WelcomePackManager.IsWelcomePackActive())
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v10 (System.Boolean)+8]");
			flag = (nint)0 == 0;
		}
		else
		{
			flag = true;
		}
		if (flag)
		{
			return;
		}
		nint num = (nint)typeof(InAppData);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S0_v14 (Il2CppClass<InApp.InAppData>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(InAppData);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S0_v20 (Il2CppClass<InApp.InAppData>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj2 = this + 68;
		bool flag2 = WelcomePackManager.IsWelcomePackActive();
		InAppItemModel inAppItemModel = InAppData.inAppData.get_Item((string)flag2);
		obj2 = inAppItemModel;
	}

	private void SetupModels()
	{
		//IL_002a: Expected I4, but got Obj
		SetupTimer();
		OnDisable();
		InAppItemModel inAppPack = _inAppPack;
		OnItemRestoreFinished((RestoreFinishedResult)inAppPack.bundleContents);
		_isSetup = true;
	}

	private void SetupTimer()
	{
		((CharacterPromotionPopup)(object)_mainCellRenderTextureSetup).OnCharacterPurchaseSuccess(Characters.CharacterId.slick, 1);
		((CharacterPromotionPopup)(object)_cell1RenderTextureSetup).OnCharacterPurchaseSuccess(Characters.CharacterId.slick, 1);
		((CharacterPromotionPopup)(object)_cell2RenderTextureSetup).OnCharacterPurchaseSuccess(Characters.CharacterId.slick, 1);
		((CharacterPromotionPopup)(object)_cell3RenderTextureSetup).OnCharacterPurchaseSuccess(Characters.CharacterId.slick, 1);
	}

	private void SetupLabels(List<InAppItemModel.BundleItem> content)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected I4, but got Unknown
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected I4, but got Unknown
		int sortingOrder = content + 50;
		((UIPanel)(object)_cell1Label).sortingOrder = sortingOrder;
		int sortingOrder2 = content + 50;
		((UIPanel)(object)_cell1RenderTextureSetup).sortingOrder = sortingOrder2;
	}

	private unsafe void OnDisable()
	{
		//IL_0198: Expected I, but got Obj
		//IL_01ae: Expected Obj, but got I
		//IL_01d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d6: Expected Obj, but got Unknown
		//IL_01f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fc: Expected Obj, but got Unknown
		//IL_020a: Expected I, but got Obj
		//IL_0220: Expected Obj, but got I
		//IL_0246: Unknown result type (might be due to invalid IL or missing references)
		//IL_024b: Expected Obj, but got Unknown
		//IL_0254: Expected Obj, but got VT
		//IL_025d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0262: Expected Obj, but got Unknown
		//IL_0273: Unknown result type (might be due to invalid IL or missing references)
		//IL_0278: Expected VT, but got Unknown
		//IL_0285: Expected F4, but got Obj
		//IL_0280: Expected native int or pointer, but got VT
		//IL_028e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0293: Expected Obj, but got Unknown
		//IL_02a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ae: Expected Obj, but got Unknown
		//IL_02b7: Expected Obj, but got VT
		//IL_02c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c5: Expected Obj, but got Unknown
		//IL_02da: Expected F4, but got Obj
		//IL_02d5: Expected native int or pointer, but got VT
		//IL_02e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e8: Expected Obj, but got Unknown
		//IL_02fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0303: Expected I4, but got Unknown
		//IL_0310: Expected I4, but got Obj
		//IL_032a: Expected F4, but got Obj
		//IL_0325: Expected native int or pointer, but got VT
		//IL_033f: Expected F4, but got I
		//IL_033a: Expected native int or pointer, but got VT
		//IL_0350: Expected I4, but got VT
		//IL_0013: Expected I, but got Obj
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Expected Obj, but got Unknown
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Expected Obj, but got Unknown
		//IL_0060: Expected I, but got Obj
		//IL_00df: Expected I, but got Obj
		//IL_00f5: Expected Obj, but got I
		//IL_0370: Expected F4, but got I4
		//IL_036b: Expected native int or pointer, but got VT
		//IL_0385: Expected F4, but got I
		//IL_0380: Expected native int or pointer, but got VT
		//IL_038e: Expected Obj, but got VT
		//IL_0167: Expected Obj, but got I8
		//IL_0174: Expected F4, but got Obj
		//IL_016f: Expected native int or pointer, but got VT
		//IL_0120: Expected I, but got Obj
		GameObject parent = _timerContainer.gameObject;
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v14 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v34 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj2 = this - -64;
		TimerHelper timerHelper = UnityEngine.Object.Instantiate(_timerPrefab, (Transform)(object)parent);
		obj2 = timerHelper;
		object obj3 = this - -64;
		nint num3 = (nint)typeof(GlobalColorsGenerated);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ S1_v10 (Il2CppClass<GlobalColorsGenerated>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num4 = (nint)typeof(GlobalColorsGenerated);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ S1_v56 (Il2CppClass<GlobalColorsGenerated>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj6 = default;
		object obj5 = obj6 - -64;
		obj5 = GlobalColorsGenerated.WEEKLYHUNT_TIMER_TEXT;
		object obj7 = obj6 + 68;
		obj7 = obj5;
		Matrix4x4 matrix4x = (Matrix4x4)(obj6 + 8);
		((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj7;
		object obj8 = obj6 + 48;
		Matrix4x4 matrix4x2 = Matrix4x4.Inverse(matrix4x);
		object obj9 = obj6 + 40;
		obj9 = GlobalColorsGenerated.WEEKLYHUNT_TIMER_BG;
		object obj10 = obj6 + 44;
		obj10 = obj9;
		((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj10;
		object obj11 = obj6 + 24;
		Matrix4x4 matrix4x3 = Matrix4x4.Inverse(matrix4x);
		bool flag = (byte)(obj6 + 72) != 0;
		((bool*)(flag ? 1 : 0))->m_value = (byte)(int)obj8 != 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ S1_v21+8]");
		_ = 0;
		((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ S1_v28+8]");
		((Matrix4x4*)(nint)matrix4x)->m20 = 0f;
		((TimerHelper)obj3).AnimateClock(flag, (byte)(int)matrix4x != 0);
		object obj12 = this - -64;
		((TimerHelper)obj12).SetTimerText((string)null);
		object obj13 = this - -64;
		GameObject gameObject = ((Component)obj13).gameObject;
		nint num5 = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v151 @ S1_v40 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj14 = (nint)0 & (nint)0x200;
		if (obj14 != null)
		{
			nint num6 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v157 @ S1_v52 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Vector3 one = Vector3.one;
		((Matrix4x4*)(nint)matrix4x)->m00 = (((bool*)(flag ? 1 : 0))->m_value ? 1 : 0);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ S1_v30 (System.Boolean)+8]");
		((Matrix4x4*)(nint)matrix4x)->m20 = 0f;
		Vector3 eulerAngles = ((Transform)matrix4x).eulerAngles;
		long msTicksSinceDeviceStartup = AnalyticsManager.GetMsTicksSinceDeviceStartup();
		obj6 = msTicksSinceDeviceStartup;
		((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj6;
		throw new ArrayTypeMismatchException();
	}

	private unsafe void DeactivateCells()
	{
		//IL_011d: Expected I, but got Obj
		//IL_0133: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_018e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0193: Expected Obj, but got Unknown
		//IL_00a1: Expected I, but got Obj
		nint num = (nint)typeof(InAppManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<InApp.InAppManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(InAppManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v29 (Il2CppClass<InApp.InAppManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		InAppManager instance = InAppManager.instance;
		if ((object)instance != null)
		{
			nint num3 = (nint)typeof(InAppManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v19 (Il2CppClass<InApp.InAppManager>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(InAppManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v25 (Il2CppClass<InApp.InAppManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Dictionary<string, InAppItemModel> activeInAppOffers = InAppManager.GetActiveInAppOffers();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint method_ptr = 0;
			InAppManager.OnPurchaseFailure onPurchaseFailure = default;
			((Delegate)onPurchaseFailure).method_ptr = method_ptr;
			((Delegate)onPurchaseFailure).method = (nint)__ldftn(WelcomePackBannerHelper.OnPurchaseSuccess);
			object obj3 = onPurchaseFailure + 16;
			obj3 = this;
			((InAppManager)(object)activeInAppOffers).onPurchaseFailure += onPurchaseFailure;
		}
		if (~(_isSetup ? 1u : 0u) == 0)
		{
			OnPurchaseClick();
			_isSetup = false;
		}
	}

	public void OnPurchaseClick()
	{
		((RenderTextureSetupBase)_mainCellRenderTextureSetup).OnReleaseRenderTexture();
		((RenderTextureSetupBase)_cell1RenderTextureSetup).OnReleaseRenderTexture();
		((RenderTextureSetupBase)_cell2RenderTextureSetup).OnReleaseRenderTexture();
		((RenderTextureSetupBase)_cell3RenderTextureSetup).OnReleaseRenderTexture();
	}

	private void OnItemRestoreFinished(RestoreFinishedResult result)
	{
		//IL_0384: Unknown result type (might be due to invalid IL or missing references)
		//IL_0389: Expected Obj, but got Unknown
		//IL_0392: Expected Obj, but got I4
		//IL_03a0: Expected I, but got Obj
		//IL_03b6: Expected Obj, but got I
		//IL_00ee: Expected I, but got Obj
		//IL_0104: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0403: Expected Obj, but got I4
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_017c: Expected I, but got Obj
		//IL_0192: Expected Obj, but got I
		//IL_012f: Expected I, but got Obj
		//IL_03f0: Expected I4, but got Obj
		//IL_044c: Expected I4, but got Obj
		//IL_045a: Expected Obj, but got I4
		//IL_00a1: Expected I, but got Obj
		//IL_0209: Expected Obj, but got I4
		//IL_01bd: Expected I, but got Obj
		//IL_0230: Unknown result type (might be due to invalid IL or missing references)
		//IL_0235: Expected Obj, but got Unknown
		//IL_0243: Expected Obj, but got I4
		//IL_0254: Expected Obj, but got I4
		//IL_0284: Expected I4, but got Obj
		//IL_0297: Expected Obj, but got I4
		//IL_02a8: Expected Obj, but got I4
		//IL_02d8: Expected I4, but got Obj
		//IL_02eb: Expected I, but got Obj
		//IL_0301: Expected Obj, but got I
		//IL_047a: Expected Obj, but got I4
		//IL_037a: Expected I4, but got Obj
		//IL_032c: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 8;
		obj = 0;
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S1_v6 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S1_v75 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)_title).FindKernel((string)null) != 0)
		{
			nint num3 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S1_v64 (Il2CppClass<Strings>)+BA]");
			object obj4 = (nint)0 & (nint)0x200;
			if (obj4 != null)
			{
				nint num4 = (nint)typeof(Strings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ S1_v71 (Il2CppClass<Strings>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			string text = Strings.GetDefault("WELCOME_PACK_TITLE");
			_title.fontSize = (int)text;
		}
		nint num5 = (nint)typeof(Boards);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ S1_v13 (Il2CppClass<Info.Boards>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num6 = (nint)typeof(Boards);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ S1_v57 (Il2CppClass<Info.Boards>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		InAppItemModel.BundleItem bundleItem = ((List<InAppItemModel.BundleItem>)result).get_Item(0);
		Boards.BoardId themeIdentifier = (Boards.BoardId)bundleItem.themeIdentifier;
		Boards.Board board = Boards.boardData.get_Item(themeIdentifier);
		nint num7 = (nint)typeof(Strings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ S2_v9 (Il2CppClass<Strings>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num8 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ S2_v38 (Il2CppClass<Strings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string text2 = Strings.GetDefault(board.name);
		_boardName.fontSize = (int)text2;
		InAppItemModel.BundleItem bundleItem2 = ((List<InAppItemModel.BundleItem>)result).get_Item(1);
		obj = bundleItem2.amount__BackingField;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D63B");
		int fontSize = default;
		_cell1Label.fontSize = fontSize;
		object obj7 = obj2 + 4;
		InAppItemModel.BundleItem bundleItem3 = ((List<InAppItemModel.BundleItem>)result).get_Item(2);
		obj7 = bundleItem3.amount__BackingField;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		string text4 = default;
		string text3 = "x" + text4;
		_cell2Label.fontSize = (int)text3;
		InAppItemModel.BundleItem bundleItem4 = ((List<InAppItemModel.BundleItem>)result).get_Item(3);
		obj2 = bundleItem4.amount__BackingField;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		string text6 = default;
		string text5 = "x" + text6;
		_cell3Label.fontSize = (int)text5;
		nint num9 = (nint)typeof(InAppData);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v180 @ S1_v42 (Il2CppClass<InApp.InAppData>)+BA]");
		object obj8 = (nint)0 & (nint)0x200;
		if (obj8 != null)
		{
			nint num10 = (nint)typeof(InAppData);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v186 @ S1_v51 (Il2CppClass<InApp.InAppData>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = WelcomePackManager.IsWelcomePackActive();
		InAppItemModel objectToClone = InAppData.inAppData.get_Item((string)flag);
		InAppItemModel inAppItemModel = InAppItemModel.Clone(objectToClone);
		_buyButtonLabel.fontSize = (int)inAppItemModel;
	}

	private void OnPurchaseClickInPopup(UIScreenController uiScreenController)
	{
		//IL_0085: Expected I, but got Obj
		//IL_009b: Expected Obj, but got I
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(InAppManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<InApp.InAppManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(InAppManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v14 (Il2CppClass<InApp.InAppManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Dictionary<string, InAppItemModel> activeInAppOffers = InAppManager.GetActiveInAppOffers();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num3 = 0;
		string text = default;
		text.m_stringLength = (int)num3;
		_ = 0;
		object obj2 = text + 16;
		obj2 = this;
		((InAppManager)(object)activeInAppOffers).StartPurchase(text);
		Dictionary<string, InAppItemModel> activeInAppOffers2 = InAppManager.GetActiveInAppOffers();
		bool success = WelcomePackManager.IsWelcomePackActive();
		((InAppManager)(object)activeInAppOffers2).InitFinishedCallback(success);
	}

	private void OnPurchaseSuccess(string productId, bool wasRestored, IPurchaseValidationResult validationResult)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected Obj, but got Unknown
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected Obj, but got Unknown
		//IL_0026: Expected Obj, but got I4
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected Obj, but got Unknown
		object obj = this + 12;
		obj = productId;
		object obj2 = this + 8;
		obj2 = wasRestored;
		object obj3 = this + 20;
		obj3 = validationResult;
		((BackBtnBehaviour)this).Update();
	}

	public unsafe WelcomePackBannerHelper()
	{
		//IL_0178: Expected I, but got Obj
		//IL_018e: Expected Obj, but got I
		//IL_0276: Unknown result type (might be due to invalid IL or missing references)
		//IL_027b: Expected Obj, but got Unknown
		//IL_0069: Expected I, but got Obj
		//IL_007f: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_01d5: Expected I, but got Obj
		//IL_01eb: Expected Obj, but got I
		//IL_021a: Expected Obj, but got I4
		//IL_00aa: Expected I, but got Obj
		//IL_014b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0150: Expected Obj, but got Unknown
		//IL_0159: Expected Obj, but got I4
		//IL_00f7: Expected I, but got Obj
		nint num = (nint)typeof(InAppManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<InApp.InAppManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(InAppManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v31 (Il2CppClass<InApp.InAppManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Dictionary<string, InAppItemModel> activeInAppOffers = InAppManager.GetActiveInAppOffers();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr = 0;
		InAppManager.OnItemRestoreFinished onItemRestoreFinished = default;
		((Delegate)onItemRestoreFinished).method_ptr = method_ptr;
		((Delegate)onItemRestoreFinished).method = (nint)__ldftn(WelcomePackBannerHelper.OnItemRestoreFinished);
		object obj2 = onItemRestoreFinished + 16;
		obj2 = this;
		((InAppManager)(object)activeInAppOffers).onItemRestoreFinished -= onItemRestoreFinished;
		Dictionary<string, InAppItemModel> activeInAppOffers2 = InAppManager.GetActiveInAppOffers();
		nint num3 = (nint)typeof(InAppData);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ S1_v11 (Il2CppClass<InApp.InAppData>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num4 = (nint)typeof(InAppData);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ S1_v24 (Il2CppClass<InApp.InAppData>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8526");
		string productId = default;
		int itemPayoutAmount = ((InAppManager)(object)activeInAppOffers2).GetItemPayoutAmount(productId, (string)null);
		nint num5 = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S0_v16 (Il2CppClass<UIScreenController>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num6 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ S0_v27 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = UIScreenController.ShouldShowOnlineScreen();
		if (((UIScreenController)flag).IsPopupQueueEmpty())
		{
			((ButtonColor)this).OnPress(flag);
			return;
		}
		object obj5 = this + 60;
		IEnumerator enumerator = ((UIScreenController)flag).DelayHideMainCamera();
		obj5 = enumerator;
	}
}
