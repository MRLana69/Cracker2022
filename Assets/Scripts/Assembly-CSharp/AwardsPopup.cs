using System;
using Cpp2ILInjected;
using UI.Screens;
using UnityEngine;

public class AwardsPopup : UIScreen
{
	private UILabel titleLine;

	private UILabel line1Big;

	private UILabel line1Small;

	private UILabel line1Dot;

	private UILabel line2Big;

	private UILabel line2Small;

	private UILabel line2Dot;

	private UILabel line3Big;

	private UILabel line3Small;

	private UILabel line3Dot;

	private UILabel buttonText;

	private GameObject goldCanGO;

	private GameObject silverCanGO;

	private GameObject bronzeCanGO;

	private UIModelController uimodelController;

	private GameObject goldCan;

	private GameObject silverCan;

	private GameObject bronzeCan;

	private static readonly Vector3 BRONZE_POSITION;

	private static readonly Vector3 BRONZE_ROTATION;

	private static readonly Vector3 BRONZE_SCALE;

	private static readonly Vector3 GOLD_POSITION;

	private static readonly Vector3 GOLD_ROTATION;

	private static readonly Vector3 GOLD_SCALE;

	private static readonly Vector3 SILVER_POSITION;

	private static readonly Vector3 SILVER_ROTATION;

	private static readonly Vector3 SILVER_SCALE;

	public override void Show()
	{
		base.Show();
		UIModelController instance = UIModelController.Instance;
		uimodelController = instance;
		string text = Strings.Get(StringID.POPUP_AWARDS_TITLE_LINE_1);
		titleLine.text = text;
		string text2 = Strings.Get(StringID.OK);
		buttonText.text = text2;
		string text3 = Strings.Get(StringID.POPUP_AWARDS_LINE1BIG);
		line1Big.text = text3;
		string text4 = Strings.Get(StringID.POPUP_AWARDS_LINE1SMALL);
		line1Small.text = text4;
		string text5 = Strings.Get(StringID.POPUP_AWARDS_LINE2BIG);
		line2Big.text = text5;
		string text6 = Strings.Get(StringID.POPUP_AWARDS_LINE2SMALL);
		line2Small.text = text6;
		string text7 = Strings.Get(StringID.POPUP_AWARDS_LINE3BIG);
		line3Big.text = text7;
		string text8 = Strings.Get(StringID.POPUP_AWARDS_LINE3SMALL);
		line3Small.text = text8;
		PlayerInfo instance2 = PlayerInfo.Instance;
		if (!instance2._hasShownAwardsIntroductionPopup)
		{
			instance2._dirty = true;
			instance2._hasShownAwardsIntroductionPopup = true;
		}
		InsertCans();
	}

	public override void Hide()
	{
		base.Hide();
		goldCan.SetActive(value: false);
		silverCan.SetActive(value: false);
		bronzeCan.SetActive(value: false);
	}

	private void OkClicked()
	{
		UIScreenController instance = UIScreenController.Instance;
		instance.ignoreLastPopupClosed = true;
		UIScreenController instance2 = UIScreenController.Instance;
		instance2.PushScreen("AwardsScreen");
		UIScreenController instance3 = UIScreenController.Instance;
		instance3.CloseActivePopups(screenName);
	}

	private unsafe void InsertCans()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0679: Unknown result type (might be due to invalid IL or missing references)
		//IL_067e: Expected Obj, but got Unknown
		//IL_007e: Expected I, but got Obj
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Expected VT, but got Unknown
		//IL_00ca: Expected I, but got Obj
		//IL_014d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0152: Expected VT, but got Unknown
		//IL_01a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a6: Expected VT, but got Unknown
		//IL_01c1: Expected I, but got Obj
		//IL_01ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f2: Expected VT, but got Unknown
		//IL_020a: Unknown result type (might be due to invalid IL or missing references)
		//IL_020f: Expected Obj, but got Unknown
		//IL_02a8: Expected I, but got Obj
		//IL_02d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d9: Expected VT, but got Unknown
		//IL_02f4: Expected I, but got Obj
		//IL_0377: Unknown result type (might be due to invalid IL or missing references)
		//IL_037c: Expected VT, but got Unknown
		//IL_03cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d0: Expected VT, but got Unknown
		//IL_03eb: Expected I, but got Obj
		//IL_0417: Unknown result type (might be due to invalid IL or missing references)
		//IL_041c: Expected VT, but got Unknown
		//IL_0434: Unknown result type (might be due to invalid IL or missing references)
		//IL_0439: Expected Obj, but got Unknown
		//IL_04d0: Expected I, but got Obj
		//IL_0516: Unknown result type (might be due to invalid IL or missing references)
		//IL_051b: Expected VT, but got Unknown
		//IL_0536: Expected I, but got Obj
		//IL_05b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_05be: Expected VT, but got Unknown
		//IL_060d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0612: Expected VT, but got Unknown
		//IL_062d: Expected I, but got Obj
		//IL_0652: Expected F4, but got I
		//IL_064d: Expected native int or pointer, but got VT
		//IL_0660: Expected F4, but got VT
		//IL_065b: Expected native int or pointer, but got VT
		object obj = default;
		Vector3 vector = (Vector3)(obj - 288);
		object obj2 = this + 112;
		if (goldCan != null)
		{
			((GameObject)obj2).SetActive(true);
		}
		else
		{
			UIModelController uIModelController = uimodelController;
			GameObject gameObject = NGUITools.AddChild(uIModelController.TutorialPopupAnchor, goldCanGO);
			goldCan = gameObject;
		}
		UIModelController instance = UIModelController.Instance;
		int layer = instance.TutorialPopupAnchor.layer;
		goldCan.layer = layer;
		Transform transform = goldCan.transform;
		nint num = (nint)typeof(AwardsPopup);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ S1_v12 (Il2CppClass<AwardsPopup>)+5C]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ S1_v13 (Il2CppStaticFields<AwardsPopup>)+2C]");
		_ = 0;
		_ = GOLD_POSITION;
		Vector3 localPosition = vector + 176;
		transform.localPosition = localPosition;
		nint num3 = (nint)typeof(AwardsPopup);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ S0_v27 (Il2CppClass<AwardsPopup>)+5C]");
		nint num4 = 0;
		float num5 = (float)GOLD_ROTATION * ((float)Math.PI / 180f);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ S0_v28 (Il2CppStaticFields<AwardsPopup>)+34]");
		float num6 = 0f * ((float)Math.PI / 180f);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ S0_v28 (Il2CppStaticFields<AwardsPopup>)+38]");
		float num7 = 0f * ((float)Math.PI / 180f);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+108]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+100]");
		_ = 0;
		Vector3 euler = vector + 160;
		Quaternion quaternion = Quaternion.Internal_FromEulerRad(euler);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+118]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+118]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+110]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+110]");
		_ = 0;
		Quaternion localRotation = (Quaternion)(vector + 144);
		transform.localRotation = localRotation;
		nint num8 = (nint)typeof(AwardsPopup);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ S1_v41 (Il2CppClass<AwardsPopup>)+5C]");
		nint num9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ S1_v42 (Il2CppStaticFields<AwardsPopup>)+44]");
		_ = 0;
		_ = GOLD_SCALE;
		Vector3 localScale = vector + 128;
		transform.localScale = localScale;
		object obj3 = this + 116;
		if (silverCan != null)
		{
			((GameObject)obj3).SetActive(true);
		}
		else
		{
			UIModelController uIModelController2 = uimodelController;
			GameObject gameObject2 = NGUITools.AddChild(uIModelController2.TutorialPopupAnchor, silverCanGO);
			silverCan = gameObject2;
		}
		UIModelController instance2 = UIModelController.Instance;
		int layer2 = instance2.TutorialPopupAnchor.layer;
		silverCan.layer = layer2;
		Transform transform2 = silverCan.transform;
		nint num10 = (nint)typeof(AwardsPopup);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v210 @ S1_v57 (Il2CppClass<AwardsPopup>)+5C]");
		nint num11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v211 @ S1_v58 (Il2CppStaticFields<AwardsPopup>)+50]");
		_ = 0;
		_ = SILVER_POSITION;
		Vector3 localPosition2 = vector + 112;
		transform2.localPosition = localPosition2;
		nint num12 = (nint)typeof(AwardsPopup);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v223 @ S0_v71 (Il2CppClass<AwardsPopup>)+5C]");
		nint num13 = 0;
		float num14 = (float)SILVER_ROTATION * ((float)Math.PI / 180f);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v224 @ S0_v72 (Il2CppStaticFields<AwardsPopup>)+58]");
		float num15 = 0f * ((float)Math.PI / 180f);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v224 @ S0_v72 (Il2CppStaticFields<AwardsPopup>)+5C]");
		float num16 = 0f * ((float)Math.PI / 180f);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+108]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+100]");
		_ = 0;
		Vector3 euler2 = vector + 96;
		Quaternion quaternion2 = Quaternion.Internal_FromEulerRad(euler2);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+118]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+118]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+110]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+110]");
		_ = 0;
		Quaternion localRotation2 = (Quaternion)(vector + 80);
		transform2.localRotation = localRotation2;
		nint num17 = (nint)typeof(AwardsPopup);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v279 @ S1_v86 (Il2CppClass<AwardsPopup>)+5C]");
		nint num18 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v280 @ S1_v87 (Il2CppStaticFields<AwardsPopup>)+68]");
		_ = 0;
		_ = SILVER_SCALE;
		Vector3 localScale2 = vector - -64;
		transform2.localScale = localScale2;
		object obj4 = this + 120;
		if (bronzeCan != null)
		{
			((GameObject)obj4).SetActive(true);
		}
		else
		{
			UIModelController uIModelController3 = uimodelController;
			GameObject gameObject3 = NGUITools.AddChild(uIModelController3.TutorialPopupAnchor, bronzeCanGO);
			bronzeCan = gameObject3;
		}
		UIModelController instance3 = UIModelController.Instance;
		int layer3 = instance3.TutorialPopupAnchor.layer;
		((GameObject)obj4).layer = layer3;
		Transform transform3 = ((GameObject)obj4).transform;
		nint num19 = (nint)typeof(AwardsPopup);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v346 @ S0_v112 (Il2CppClass<AwardsPopup>)+5C]");
		nint num20 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v347 @ S0_v113 (Il2CppStaticFields<AwardsPopup>)+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+D8]");
		_ = 0;
		_ = BRONZE_POSITION;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+D0]");
		_ = 0;
		Vector3 localPosition3 = vector + 48;
		transform3.localPosition = localPosition3;
		nint num21 = (nint)typeof(AwardsPopup);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v368 @ S0_v121 (Il2CppClass<AwardsPopup>)+5C]");
		nint num22 = 0;
		float num23 = (float)BRONZE_ROTATION * ((float)Math.PI / 180f);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v369 @ S0_v122 (Il2CppStaticFields<AwardsPopup>)+10]");
		float num24 = 0f * ((float)Math.PI / 180f);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v369 @ S0_v122 (Il2CppStaticFields<AwardsPopup>)+14]");
		float num25 = 0f * ((float)Math.PI / 180f);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+108]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+100]");
		_ = 0;
		Vector3 euler3 = vector + 32;
		Quaternion quaternion3 = Quaternion.Internal_FromEulerRad(euler3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+118]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+118]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+110]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+110]");
		_ = 0;
		Quaternion localRotation3 = (Quaternion)(vector + 16);
		transform3.localRotation = localRotation3;
		nint num26 = (nint)typeof(AwardsPopup);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v424 @ S1_v132 (Il2CppClass<AwardsPopup>)+5C]");
		nint num27 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v425 @ S1_v133 (Il2CppStaticFields<AwardsPopup>)+20]");
		((Vector3*)(nint)vector)->z = 0f;
		((Vector3*)(nint)vector)->x = (float)BRONZE_SCALE;
		transform3.localScale = vector;
	}

	static AwardsPopup()
	{
		//IL_0013: Expected I, but got Obj
		//IL_0037: Expected VT, but got I8
		//IL_0045: Expected I, but got Obj
		//IL_0069: Expected VT, but got I8
		//IL_0077: Expected I, but got Obj
		//IL_009b: Expected VT, but got I8
		//IL_00a9: Expected I, but got Obj
		//IL_00cd: Expected VT, but got I8
		//IL_00db: Expected I, but got Obj
		//IL_00ff: Expected VT, but got I8
		//IL_010d: Expected I, but got Obj
		//IL_0131: Expected VT, but got I8
		//IL_013f: Expected I, but got Obj
		//IL_0163: Expected VT, but got I8
		//IL_0171: Expected I, but got Obj
		//IL_0195: Expected VT, but got I8
		//IL_01a3: Expected I, but got Obj
		//IL_01c7: Expected VT, but got I8
		nint num = (nint)typeof(AwardsPopup);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v11 @ S0_v6 (Il2CppClass<AwardsPopup>)+5C]");
		nint num2 = 0;
		_ = 0;
		BRONZE_POSITION = (Vector3)4674736416481869824L;
		nint num3 = (nint)typeof(AwardsPopup);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v10 (Il2CppClass<AwardsPopup>)+5C]");
		nint num4 = 0;
		_ = 1135542272;
		BRONZE_ROTATION = (Vector3)4842495500421693440L;
		nint num5 = (nint)typeof(AwardsPopup);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v14 (Il2CppClass<AwardsPopup>)+5C]");
		nint num6 = 0;
		_ = 1114636288;
		BRONZE_SCALE = (Vector3)4787326405009473536L;
		nint num7 = (nint)typeof(AwardsPopup);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v18 (Il2CppClass<AwardsPopup>)+5C]");
		nint num8 = 0;
		_ = -1041235968;
		GOLD_POSITION = (Vector3)4638707619458449408L;
		nint num9 = (nint)typeof(AwardsPopup);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v22 (Il2CppClass<AwardsPopup>)+5C]");
		nint num10 = 0;
		_ = 0;
		GOLD_ROTATION = (Vector3)4842495500422742016L;
		nint num11 = (nint)typeof(AwardsPopup);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S0_v26 (Il2CppClass<AwardsPopup>)+5C]");
		nint num12 = 0;
		_ = 1115422720;
		GOLD_SCALE = (Vector3)4790704104730787840L;
		nint num13 = (nint)typeof(AwardsPopup);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ S0_v30 (Il2CppClass<AwardsPopup>)+5C]");
		nint num14 = 0;
		_ = 0;
		SILVER_POSITION = (Vector3)4665729217217167360L;
		nint num15 = (nint)typeof(AwardsPopup);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ S0_v34 (Il2CppClass<AwardsPopup>)+5C]");
		nint num16 = 0;
		_ = 1092616192;
		SILVER_ROTATION = (Vector3)4842495500421693440L;
		nint num17 = (nint)typeof(AwardsPopup);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S0_v38 (Il2CppClass<AwardsPopup>)+5C]");
		nint num18 = 0;
		_ = 1114636288;
		SILVER_SCALE = (Vector3)4787326405009473536L;
	}
}
