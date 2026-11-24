using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

namespace UI.Screens;

public class TutorialDoubleCoinsPopup : CharacterPopup
{
	private GameObject _centerAnchor;

	private UILabel _calloutText;

	private GameObject _tutorialMultiLinesPrefab;

	private GameObject _doubleCoinsPrefab;

	private TutorialMultilineLabelsHelper _tutorialLinesHelper;

	private GameObject _doubleCoins;

	public override void Init()
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		List<UISprite> list = default;
		list._002Ector();
		object obj = this + 124;
		obj = list;
		((UpgradeScreen)(object)this).Start();
	}

	public override void Show()
	{
		//IL_0142: Unknown result type (might be due to invalid IL or missing references)
		//IL_0147: Expected Obj, but got Unknown
		//IL_0150: Expected Obj, but got I4
		//IL_0162: Unknown result type (might be due to invalid IL or missing references)
		//IL_0167: Expected Obj, but got Unknown
		//IL_017a: Unknown result type (might be due to invalid IL or missing references)
		//IL_017f: Expected Obj, but got Unknown
		//IL_01a2: Expected I, but got Obj
		//IL_01b8: Expected Obj, but got I
		//IL_01de: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e3: Expected Obj, but got Unknown
		//IL_0206: Unknown result type (might be due to invalid IL or missing references)
		//IL_020b: Expected Obj, but got Unknown
		//IL_021e: Expected I4, but got Obj
		//IL_022a: Expected Obj, but got I4
		//IL_0242: Expected I, but got Obj
		//IL_0258: Expected Obj, but got I
		//IL_027b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0280: Expected Obj, but got Unknown
		//IL_028f: Expected I4, but got Obj
		//IL_029b: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_00ad: Expected I, but got Obj
		//IL_00c3: Expected Obj, but got I
		//IL_0060: Expected I, but got Obj
		//IL_02d1: Expected Obj, but got I
		//IL_02e7: Expected Obj, but got I
		//IL_02f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f5: Expected Obj, but got Unknown
		//IL_030d: Expected Obj, but got I4
		//IL_031c: Expected Obj, but got F4
		//IL_00ee: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 32;
		obj = 0;
		_ = 0;
		base.Hide();
		object obj3 = this - -64;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @39CF");
		object obj4 = obj2 + 16;
		obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
		_ = 0;
		nint num = (nint)typeof(TutorialMultilineLabelsHelper);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S0_v22 (Il2CppClass<TutorialMultilineLabelsHelper>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num2 = (nint)typeof(TutorialMultilineLabelsHelper);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ S0_v70 (Il2CppClass<TutorialMultilineLabelsHelper>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Transform transform = (Transform)(obj2 + 48);
		transform = (Transform)obj4;
		Transform transform2 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v19+8]");
		((UnityEngine.Object)transform2).m_CachedPtr = (IntPtr)0;
		object obj6 = this + 72;
		bool flag = ((UIModelController)(object)_centerAnchor).ExistsTransformModelInModelScreen((UIModelController.ModelScreen)obj3, transform);
		obj6 = flag;
		string go = tag;
		nint num3 = (nint)typeof(NGUITools);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ S0_v36 (Il2CppClass<NGUITools>)+BA]");
		object obj7 = (nint)0 & (nint)0x200;
		if (obj7 != null)
		{
			nint num4 = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ S0_v66 (Il2CppClass<NGUITools>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj8 = this + 76;
		int num5 = NGUITools.CalculateNextDepth((GameObject)(object)go, (byte)(int)_doubleCoinsPrefab != 0);
		obj8 = num5;
		DoubleCoinUpgradeHelper component = _doubleCoins.GetComponent<DoubleCoinUpgradeHelper>();
		component.OnEnable();
		nint num6 = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ S0_v46 (Il2CppClass<UIScreenController>)+BA]");
		object obj9 = (nint)0 & (nint)0x200;
		if (obj9 != null)
		{
			nint num7 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ S0_v62 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag2 = UIScreenController.ShouldShowOnlineScreen();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ S0_v51 (System.Boolean)+3C]");
		object obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ S0_v52+14]");
		object obj11 = (nint)0 / (nint)2;
		object obj12 = obj11 - 180;
		int layer = _doubleCoins.layer;
		obj2 = 0;
		_ = 0;
		obj2 = 2f;
		_ = 0f;
		transform = (Transform)obj2;
		Transform transform3 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((UnityEngine.Object)transform3).m_CachedPtr = (IntPtr)0;
		Vector3 eulerAngles = transform.eulerAngles;
		NGUITools.UpdateWidgetCollider(_doubleCoins);
	}

	private void OnNewPopupShown(string popupName)
	{
		//IL_002d: Expected Obj, but got I
		//IL_000e: Expected Obj, but got I4
		//IL_0017: Expected Obj, but got I4
		//IL_007c: Expected Obj, but got I4
		//IL_0085: Expected Obj, but got I4
		//IL_01d5: Expected I, but got Obj
		//IL_01eb: Expected Obj, but got I
		//IL_0219: Expected Obj, but got I
		//IL_0065: Expected Obj, but got I4
		//IL_006e: Expected Obj, but got I4
		//IL_00c9: Expected I, but got Obj
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Expected Obj, but got Unknown
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Expected Obj, but got Unknown
		//IL_0111: Expected Obj, but got I4
		//IL_0261: Unknown result type (might be due to invalid IL or missing references)
		//IL_0266: Expected Obj, but got Unknown
		//IL_0275: Expected VT, but got Obj
		//IL_027e: Expected Obj, but got I4
		//IL_0147: Expected Obj, but got I4
		//IL_0162: Expected Obj, but got I4
		//IL_02c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cd: Expected Obj, but got Unknown
		//IL_0198: Expected Obj, but got I4
		object obj;
		UIWidget uIWidget;
		if (popupName != null)
		{
			obj = -30;
			uIWidget = (UIWidget)423;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.Screens.TutorialDoubleCoinsPopup)+70]");
			string text = ((Component)0).tag;
			object obj2;
			if (((GameObject)(object)text).activeInHierarchy)
			{
				uIWidget = (UIWidget)370;
				obj2 = -60;
			}
			else
			{
				uIWidget = (UIWidget)310;
				obj2 = -90;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.Screens.TutorialDoubleCoinsPopup)+74]");
			string text2 = ((Component)0).tag;
			bool activeInHierarchy = ((GameObject)(object)text2).activeInHierarchy;
			bool flag = !activeInHierarchy;
			obj = obj2;
			if (!flag)
			{
				UIWidget uIWidget2 = (UIWidget)(uIWidget + 60);
				object obj3 = obj2 + 30;
				obj = obj3;
				uIWidget = uIWidget2;
			}
		}
		nint num = (nint)typeof(Mathf);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S0_v11 (Il2CppClass<UnityEngine.Mathf>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num2 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ S0_v20 (Il2CppClass<UnityEngine.Mathf>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		UIWidget uIWidget3;
		if ((nint)uIWidget < 310)
		{
			uIWidget3 = (UIWidget)310;
		}
		else
		{
			uIWidget3 = (((nint)uIWidget <= 423) ? uIWidget : ((UIWidget)423));
		}
		Color color = uIWidget3.color;
		object obj5 = default;
		Transform transform = (Transform)(obj5 + 12);
		transform.localPosition = (Vector3)base._characterModel;
		obj5 = 0;
		_ = 0;
		obj5 = transform;
		if ((nint)obj < -90)
		{
			object obj6 = -90;
		}
		else if ((nint)obj > -30)
		{
			object obj6 = -30;
		}
		else
		{
			object obj6 = obj;
		}
		_ = 0f;
		Transform transform2 = (Transform)(obj5 + 24);
		transform2 = (Transform)obj5;
		Transform transform3 = transform2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((UnityEngine.Object)transform3).m_CachedPtr = (IntPtr)0;
		Vector3 eulerAngles = transform2.eulerAngles;
	}

	private void OnNewPopupClosed(string popupName)
	{
		//IL_001f: Expected I4, but got Obj
		if (popupName.get_Chars((int)"TutorialDoubleCoinsPopup") != '\0')
		{
			ShowCharacter();
		}
	}

	public override void Hide()
	{
		//IL_01a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ab: Expected Obj, but got Unknown
		//IL_01b4: Expected Obj, but got I4
		//IL_01c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c8: Expected Obj, but got Unknown
		//IL_01d1: Expected Obj, but got I4
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected Obj, but got Unknown
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected Obj, but got Unknown
		//IL_0063: Expected I, but got Obj
		//IL_0079: Expected Obj, but got I
		//IL_0228: Expected I4, but got Obj
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Expected Obj, but got Unknown
		//IL_011c: Expected I, but got Obj
		//IL_0132: Expected Obj, but got I
		//IL_00a4: Expected I, but got Obj
		//IL_0280: Unknown result type (might be due to invalid IL or missing references)
		//IL_0285: Expected Obj, but got Unknown
		//IL_015d: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 32;
		obj = 0;
		_ = 0;
		object obj3 = obj2 + 16;
		obj3 = 0;
		_ = 0;
		((UIScreen)this).Hide();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @39CF");
		obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @39CF");
		object obj4 = obj2 + 44;
		obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		object obj5 = obj2 + 56;
		obj5 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v12+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8B9F");
		nint num = (nint)typeof(Strings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ S1_v28 (Il2CppClass<Strings>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num2 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ S1_v52 (Il2CppClass<Strings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string text = Strings.GetDefault("POPUP_TUTORIAL_DOUBLE_COINS_CALLOUT");
		_calloutText.fontSize = (int)text;
		((UIGeometry)(object)_tutorialLinesHelper).WriteToBuffers((List<Vector3>)(object)"POPUP_TUTORIAL_DOUBLE_COINS_LINE1_BIG", (List<Vector2>)(object)"POPUP_TUTORIAL_DOUBLE_COINS_LINE1_SMALL", (List<Color>)(object)"POPUP_TUTORIAL_DOUBLE_COINS_LINE2_BIG", (List<Vector3>)(object)"POPUP_TUTORIAL_DOUBLE_COINS_LINE2_SMALL", (List<Vector4>)(object)"POPUP_TUTORIAL_DOUBLE_COINS_LINE3_BIG", (List<Vector4>)(object)"POPUP_TUTORIAL_DOUBLE_COINS_LINE3_SMALL");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num3 = 0;
		_ = 0;
		Action<string> action = default;
		object obj7 = action + 16;
		obj7 = this;
		nint num4 = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ S0_v40 (Il2CppClass<UIScreenController>)+BA]");
		object obj8 = (nint)0 & (nint)0x200;
		if (obj8 != null)
		{
			nint num5 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ S0_v56 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		UIScreenController.OnPopupShown -= action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num6 = 0;
		_ = 0;
		Action<string> action2 = default;
		object obj9 = action2 + 16;
		obj9 = this;
		UIScreenController.OnPopupClosed -= action2;
	}

	public unsafe TutorialDoubleCoinsPopup()
	{
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Expected Obj, but got Unknown
		//IL_00a6: Expected I, but got Obj
		//IL_00bc: Expected Obj, but got I
		//IL_010a: Expected Obj, but got I
		//IL_0113: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		HideCharacter();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr = 0;
		Action action = default;
		((Delegate)action).method_ptr = method_ptr;
		((Delegate)action).method = (nint)__ldftn(TutorialDoubleCoinsPopup.OnNewPopupShown);
		object obj = action + 16;
		obj = this;
		nint num = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v16 (Il2CppClass<UIScreenController>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v31 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		UIScreenController.OnLastPopupClosed += action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint cachedPtr = 0;
		UIScreenController uIScreenController = default;
		((UnityEngine.Object)uIScreenController).m_CachedPtr = cachedPtr;
		uIScreenController.popupAnchor = (GameObject)0;
		object obj3 = uIScreenController + 16;
		obj3 = this;
		uIScreenController.Awake();
	}
}
