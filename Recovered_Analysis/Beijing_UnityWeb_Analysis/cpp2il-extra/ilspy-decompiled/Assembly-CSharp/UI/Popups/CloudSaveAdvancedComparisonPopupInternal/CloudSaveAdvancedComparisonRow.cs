using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using UI.FreeStuff;
using UI.Generic;
using UI.Popups.BoardBundlePopupInternal;
using UI.Popups.CloudSaveComparisonPopupInternal;
using UnityEngine;

namespace UI.Popups.CloudSaveAdvancedComparisonPopupInternal;

public class CloudSaveAdvancedComparisonRow : MonoBehaviour
{
	public class CloudSaveComparisonRowPayload
	{
		public string name;

		public string localValue;

		public string onlineValue;

		public bool showBackground;

		public bool isLocalImprovement;

		public bool isOnlineImprovement;

		public CloudSaveComparisonRowPayload()
		{
			//IL_001e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0023: Expected Obj, but got Unknown
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			List<CloudSaveProgressCell.CloudSaveProgressCellPayload> list = default;
			list._002Ector();
			object obj = this + 20;
			obj = list;
		}
	}

	private UILabel _name;

	private UILabel _localValue;

	private UILabel _onlineValue;

	private UISprite _background;

	public void SetupRow(CloudSaveComparisonRowPayload payload)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_040f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0414: Expected Obj, but got Unknown
		//IL_041d: Expected Obj, but got I4
		//IL_042c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0431: Expected Obj, but got Unknown
		//IL_0445: Unknown result type (might be due to invalid IL or missing references)
		//IL_044a: Expected Obj, but got Unknown
		//IL_0468: Expected Obj, but got I
		//IL_0023: Expected Obj, but got I
		//IL_0040: Expected Obj, but got I
		//IL_0064: Expected Obj, but got I
		//IL_008b: Expected Obj, but got I4
		//IL_009c: Expected Obj, but got I
		//IL_00b3: Expected I, but got Obj
		//IL_00c9: Expected Obj, but got I
		//IL_04a8: Expected Obj, but got I
		//IL_04d0: Expected Obj, but got I4
		//IL_00f4: Expected I, but got Obj
		//IL_0295: Unknown result type (might be due to invalid IL or missing references)
		//IL_029a: Expected Obj, but got Unknown
		//IL_02a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a8: Expected Obj, but got Unknown
		//IL_02d4: Expected Obj, but got I4
		//IL_052f: Expected Obj, but got I
		//IL_035c: Expected Obj, but got I
		//IL_018b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0190: Expected Obj, but got Unknown
		//IL_0199: Unknown result type (might be due to invalid IL or missing references)
		//IL_019e: Expected Obj, but got Unknown
		//IL_01a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ac: Expected Obj, but got Unknown
		//IL_0392: Unknown result type (might be due to invalid IL or missing references)
		//IL_0397: Expected Obj, but got Unknown
		//IL_01f0: Expected I, but got Obj
		//IL_0206: Expected Obj, but got I
		//IL_03c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03cd: Expected Obj, but got Unknown
		//IL_0231: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 48;
		object obj3 = obj2 + 24;
		obj3 = 0;
		_ = 0;
		object obj4 = obj2 + 16;
		obj4 = obj;
		_ = -1;
		object obj5 = this + 44;
		obj5 = payload;
		((CloudSaveConflictBlock)this).ButtonClicked();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.Popups.CloudSaveAdvancedComparisonPopupInternal.CloudSaveAdvancedComparisonRow)+2C]");
		object obj6 = 0;
		UISprite background = _background;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ S1_v14+C]");
		background.fillCenter = false;
		((FitSpriteToWidget)(object)_onlineValue).FitStretch();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.Popups.CloudSaveAdvancedComparisonPopupInternal.CloudSaveAdvancedComparisonRow)+2C]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.Popups.CloudSaveAdvancedComparisonPopupInternal.CloudSaveAdvancedComparisonRow)+24]");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S1_v18+8]");
		((UILabel)num).fontSize = 0;
		string text = _localValue.tag;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.Popups.CloudSaveAdvancedComparisonPopupInternal.CloudSaveAdvancedComparisonRow)+2C]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ S1_v22+10]");
		bool flag = (nint)0 != 0;
		((GameObject)(object)text).tag = (string)flag;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.Popups.CloudSaveAdvancedComparisonPopupInternal.CloudSaveAdvancedComparisonRow)+28]");
		GameObject obj9 = ((Component)0).gameObject;
		nint num2 = (nint)typeof(NGUITools);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ S1_v27 (Il2CppClass<NGUITools>)+BA]");
		object obj10 = (nint)0 & (nint)0x200;
		if (obj10 != null)
		{
			nint num3 = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ S1_v96 (Il2CppClass<NGUITools>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		NGUITools.DestroyImmediate(obj9);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.Popups.CloudSaveAdvancedComparisonPopupInternal.CloudSaveAdvancedComparisonRow)+2C]");
		object obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @10F7C");
		obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		object obj12 = 0;
		object obj13 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			if (obj13 == null)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			object obj14 = obj12 + 1;
			object obj15 = obj14 / 2;
			object obj16 = obj15 * 2;
			object obj17 = obj14 - obj16;
			bool flag2 = (nint)obj17 == 1;
			_ = 3;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			nint num4 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v337 @ S0_v118 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj18 = (nint)0 & (nint)0x200;
			if (obj18 != null)
			{
				nint num5 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v342 @ S0_v134 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
			obj12 = obj14;
		}
		object obj19 = obj4 + 4;
		object obj20 = obj19 + 1;
		obj19 = obj20;
		object obj21 = obj20 << 2;
		object obj22 = obj4 + obj21;
		obj22 = 238;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
			object obj23 = (nint)0 << 2;
			object obj24 = obj4 + obj23;
			if ((nint)obj24 == 238)
			{
				object obj25 = obj4 + 4;
				if ((nint)obj25 > -1)
				{
					object obj26 = obj25 + -1;
					obj25 = obj26;
				}
				goto IL_051d;
			}
		}
		object obj27 = default;
		if (obj27 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		goto IL_051d;
		IL_051d:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.Popups.CloudSaveAdvancedComparisonPopupInternal.CloudSaveAdvancedComparisonRow)+28]");
		((RewardForVideoButton)0).Init(null);
	}

	private static void ColorTextField(UILabel label, bool isImprovement)
	{
		//IL_0031: Expected Obj, but got I4
		//IL_005d: Expected Obj, but got I4
		//IL_009b: Expected Obj, but got I4
		//IL_00ae: Expected I, but got Obj
		//IL_00c4: Expected Obj, but got I
		//IL_018b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0190: Expected Obj, but got Unknown
		//IL_01a7: Expected Obj, but got I4
		//IL_01c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ca: Expected Obj, but got Unknown
		//IL_0225: Expected I4, but got Obj
		//IL_00ef: Expected I, but got Obj
		UIRect.AnchorPoint leftAnchor = label.leftAnchor;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [isImprovement @ L1 (System.Boolean)+8]");
		((UILabel)(object)leftAnchor).fontSize = 0;
		UIRect.AnchorPoint rightAnchor = label.rightAnchor;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [isImprovement @ L1 (System.Boolean)+C]");
		((UILabel)(object)rightAnchor).fontSize = 0;
		UIRect.AnchorPoint bottomAnchor = label.bottomAnchor;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [isImprovement @ L1 (System.Boolean)+10]");
		((UILabel)(object)bottomAnchor).fontSize = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [isImprovement @ L1 (System.Boolean)+15]");
		bool flag = (nint)0 != 0;
		((BoardBundleItem)(object)label.rightAnchor).SetupBoard((List<int>)flag);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [isImprovement @ L1 (System.Boolean)+16]");
		bool flag2 = (nint)0 != 0;
		((BoardBundleItem)(object)label.bottomAnchor).SetupBoard((List<int>)flag2);
		string text = ((Component)(object)label.topAnchor).tag;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [isImprovement @ L1 (System.Boolean)+14]");
		bool flag3 = (nint)0 != 0;
		((GameObject)(object)text).tag = (string)flag3;
		nint num = (nint)typeof(ColorData);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ S1_v20 (Il2CppClass<UI.ColorData>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(ColorData);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ S1_v34 (Il2CppClass<UI.ColorData>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		UIEventListener.FloatDelegate floatDelegate = default;
		object obj2 = floatDelegate + 16;
		bool flag4 = HoverboardStickerManager.ShouldShowHoverboardStickerFlow();
		object obj3 = (flag4 ? 1 : 0) + 44;
		obj2 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S2_v14+8]");
		_ = 0;
		GameObject gameObject = (GameObject)(floatDelegate + 32);
		gameObject = (GameObject)obj2;
		GameObject gameObject2 = gameObject;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ S1_v25+8]");
		((UnityEngine.Object)gameObject2).m_CachedPtr = (IntPtr)0;
		floatDelegate(gameObject, 0.4f);
		gameObject = (GameObject)(object)floatDelegate;
		((UnityEngine.Object)gameObject).m_CachedPtr = ((Delegate)floatDelegate).method_ptr;
		((UIWidget)(object)label.topAnchor).rawPivot = (UIWidget.Pivot)gameObject;
	}

	public CloudSaveAdvancedComparisonRow()
	{
		CancelInvoke();
	}
}
