using System;
using Cpp2ILInjected;
using Data.Managers;
using Data.Save;
using Kiloo;
using SYBO.Subway.Info;
using UI;
using UnityEngine;

public class EventButtonBreadcrumb : MonoBehaviour
{
	private GameObject _breadcrumb;

	private IEventManager _activeEventManager;

	private void OnEnable()
	{
		CancelInvoke();
	}

	private unsafe void OnDisable()
	{
		//IL_018d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0192: Expected Obj, but got Unknown
		//IL_01a5: Expected I, but got Obj
		//IL_01bb: Expected Obj, but got I
		//IL_0216: Unknown result type (might be due to invalid IL or missing references)
		//IL_021b: Expected Obj, but got Unknown
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Expected Obj, but got Unknown
		//IL_00d8: Expected I, but got Obj
		//IL_00ee: Expected Obj, but got I
		//IL_0119: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr = 0;
		Action action = default;
		((Delegate)action).method_ptr = method_ptr;
		((Delegate)action).method = (nint)__ldftn(EventButtonBreadcrumb.CheckForUnseenEventPopup);
		object obj = action + 16;
		obj = this;
		nint num = (nint)typeof(SSEventsManagerController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S0_v12 (Il2CppClass<SSEventsManagerController>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(SSEventsManagerController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S0_v51 (Il2CppClass<SSEventsManagerController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		SSEventsManagerController.OnSSEventStartedHandler -= action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr2 = 0;
		Action action2 = default;
		((Delegate)action2).method_ptr = method_ptr2;
		((Delegate)action2).method = (nint)__ldftn(EventButtonBreadcrumb.CheckForUnseenEventPopup);
		object obj3 = action2 + 16;
		obj3 = this;
		SSEventsManagerController.OnSSEventChangedHandler -= action2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr3 = 0;
		Action action3 = default;
		((Delegate)action3).method_ptr = method_ptr3;
		((Delegate)action3).method = (nint)__ldftn(EventButtonBreadcrumb.HideBreadcrumb);
		object obj4 = action3 + 16;
		obj4 = this;
		SSEventsManagerController.OnSSEventFinishedHandler -= action3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num3 = 0;
		_ = 0;
		Action<string> action4 = default;
		object obj5 = action4 + 16;
		obj5 = this;
		nint num4 = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ S0_v41 (Il2CppClass<UIScreenController>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num5 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ S0_v47 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		UIScreenController.OnPopupShown -= action4;
		ShowBreadcrumb();
	}

	private unsafe void PopupWasShown(string popup)
	{
		//IL_0974: Unknown result type (might be due to invalid IL or missing references)
		//IL_0979: Expected I4, but got Unknown
		//IL_098e: Expected Obj, but got I
		//IL_099c: Expected I, but got Obj
		//IL_09b2: Expected Obj, but got I
		//IL_0602: Expected I, but got Obj
		//IL_0618: Expected Obj, but got I
		//IL_0567: Expected I, but got Obj
		//IL_0b80: Expected Obj, but got I
		//IL_05ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b1: Expected Obj, but got Unknown
		//IL_05d3: Expected I4, but got Obj
		//IL_0112: Expected I, but got Obj
		//IL_0128: Expected Obj, but got I
		//IL_0037: Expected I, but got Obj
		//IL_0713: Expected I, but got Obj
		//IL_0729: Expected Obj, but got I
		//IL_0643: Expected I, but got Obj
		//IL_0a71: Expected Obj, but got I
		//IL_0084: Expected I, but got Obj
		//IL_009a: Expected Obj, but got I
		//IL_0bae: Expected Obj, but got I
		//IL_06b1: Expected Obj, but got I4
		//IL_06b1: Expected Obj, but got I
		//IL_06b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_06bc: Expected Obj, but got Unknown
		//IL_06de: Expected I4, but got Obj
		//IL_0700: Expected Obj, but got I
		//IL_023a: Expected I, but got Obj
		//IL_0250: Expected Obj, but got I
		//IL_0153: Expected I, but got Obj
		//IL_0a1d: Expected Obj, but got I4
		//IL_0a3f: Expected I4, but got Obj
		//IL_07f5: Expected I, but got Obj
		//IL_080b: Expected Obj, but got I
		//IL_0754: Expected I, but got Obj
		//IL_0a9f: Expected Obj, but got I
		//IL_01c1: Expected Obj, but got I4
		//IL_01c1: Expected Obj, but got I
		//IL_01c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cc: Expected Obj, but got Unknown
		//IL_01ee: Expected I4, but got Obj
		//IL_0210: Expected Obj, but got I
		//IL_00c5: Expected I, but got Obj
		//IL_0bdc: Expected Obj, but got I
		//IL_0799: Unknown result type (might be due to invalid IL or missing references)
		//IL_079e: Expected Obj, but got Unknown
		//IL_07c0: Expected I4, but got Obj
		//IL_07e2: Expected Obj, but got I
		//IL_032e: Expected I, but got Obj
		//IL_0344: Expected Obj, but got I
		//IL_027b: Expected I, but got Obj
		//IL_0227: Expected Obj, but got I
		//IL_08b7: Expected I, but got Obj
		//IL_08cd: Expected Obj, but got I
		//IL_0836: Expected I, but got Obj
		//IL_0acd: Expected Obj, but got I
		//IL_02c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c5: Expected Obj, but got Unknown
		//IL_02e7: Expected I4, but got Obj
		//IL_0309: Expected Obj, but got I
		//IL_031b: Expected Obj, but got I
		//IL_0c0a: Expected Obj, but got I
		//IL_08a4: Expected Obj, but got I4
		//IL_08a4: Expected Obj, but got I
		//IL_03f0: Expected I, but got Obj
		//IL_0406: Expected Obj, but got I
		//IL_036f: Expected I, but got Obj
		//IL_08f8: Expected I, but got Obj
		//IL_0afb: Expected Obj, but got I
		//IL_03dd: Expected Obj, but got I4
		//IL_03dd: Expected Obj, but got I
		//IL_0966: Expected Obj, but got I4
		//IL_0966: Expected Obj, but got I
		//IL_0495: Expected I, but got Obj
		//IL_04ab: Expected Obj, but got I
		//IL_0431: Expected I, but got Obj
		//IL_0b29: Expected Obj, but got I
		//IL_0482: Expected Obj, but got I
		//IL_04d6: Expected I, but got Obj
		//IL_052b: Expected Obj, but got I
		object obj = default;
		UIWidget.Pivot pivot = (UIWidget.Pivot)(obj + 16);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (EventButtonBreadcrumb)+7C]");
		((GameObject)0).tag = popup;
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v15 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		bool flag = obj2 == null;
		if (popup != null)
		{
			if (!flag)
			{
				nint num2 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S0_v105 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (UnityEngine.Object.IsNativeObjectAlive((UnityEngine.Object)_breadcrumb))
			{
				nint num3 = (nint)typeof(ColorData);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S1_v154 (Il2CppClass<UI.ColorData>)+BA]");
				object obj3 = (nint)0 & (nint)0x200;
				if (obj3 != null)
				{
					nint num4 = (nint)typeof(ColorData);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ S1_v163 (Il2CppClass<UI.ColorData>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				bool flag2 = HoverboardStickerManager.ShouldShowHoverboardStickerFlow();
				object obj4 = (flag2 ? 1 : 0) + 268;
				obj = obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ S2_v89+8]");
				_ = 0;
				((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
				_ = 0;
				((UIWidget)(object)_breadcrumb).rawPivot = pivot;
			}
			nint num5 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ S1_v79 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj5 = (nint)0 & (nint)0x200;
			if (obj5 != null)
			{
				nint num6 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v140 @ S1_v149 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (EventButtonBreadcrumb)+24]");
			if (UnityEngine.Object.IsNativeObjectAlive((UnityEngine.Object)0))
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (EventButtonBreadcrumb)+29]");
				bool flag3 = (nint)0 != 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (EventButtonBreadcrumb)+24]");
				((Component)0).tag = (string)flag3;
				object obj6 = this + 60;
				obj = obj6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v227 @ S2_v76+8]");
				_ = 0;
				((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (EventButtonBreadcrumb)+24]");
				((UIWidget)0).rawPivot = pivot;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (EventButtonBreadcrumb)+24]");
				((Component)0).tag = null;
			}
			nint num7 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v191 @ S1_v86 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj7 = (nint)0 & (nint)0x200;
			if (obj7 != null)
			{
				nint num8 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v240 @ S1_v136 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (EventButtonBreadcrumb)+4C]");
			if (UnityEngine.Object.IsNativeObjectAlive((UnityEngine.Object)0))
			{
				object obj8 = this + 96;
				obj = obj8;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v280 @ S2_v63+8]");
				_ = 0;
				((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (EventButtonBreadcrumb)+4C]");
				((UIWidget)0).rawPivot = pivot;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (EventButtonBreadcrumb)+4C]");
				((Component)0).tag = null;
			}
			nint num9 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v305 @ S1_v93 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj9 = (nint)0 & (nint)0x200;
			if (obj9 != null)
			{
				nint num10 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v345 @ S1_v126 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (EventButtonBreadcrumb)+70]");
			if (UnityEngine.Object.IsNativeObjectAlive((UnityEngine.Object)0))
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (EventButtonBreadcrumb)+79]");
				bool flag4 = (nint)0 != 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (EventButtonBreadcrumb)+70]");
				((Component)0).tag = (string)flag4;
			}
			nint num11 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v378 @ S1_v100 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj10 = (nint)0 & (nint)0x200;
			if (obj10 != null)
			{
				nint num12 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v403 @ S1_v119 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (EventButtonBreadcrumb)+74]");
			if (UnityEngine.Object.IsNativeObjectAlive((UnityEngine.Object)0))
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (EventButtonBreadcrumb)+74]");
				((GameObject)0).tag = null;
			}
			nint num13 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v435 @ S1_v107 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj11 = (nint)0 & (nint)0x200;
			if (obj11 != null)
			{
				nint num14 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v461 @ S1_v114 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (EventButtonBreadcrumb)+80]");
			if (UnityEngine.Object.IsNativeObjectAlive((UnityEngine.Object)0))
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (EventButtonBreadcrumb)+80]");
				((Collider)0).isTrigger = false;
			}
			return;
		}
		if (!flag)
		{
			nint num15 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S0_v55 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (UnityEngine.Object.IsNativeObjectAlive((UnityEngine.Object)_breadcrumb))
		{
			object obj12 = this + 16;
			obj = obj12;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ S2_v38+8]");
			_ = 0;
			((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			_ = 0;
			((UIWidget)(object)_breadcrumb).rawPivot = pivot;
		}
		nint num16 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ S1_v10 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj13 = (nint)0 & (nint)0x200;
		if (obj13 != null)
		{
			nint num17 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ S1_v67 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (EventButtonBreadcrumb)+24]");
		if (UnityEngine.Object.IsNativeObjectAlive((UnityEngine.Object)0))
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (EventButtonBreadcrumb)+28]");
			bool flag5 = (nint)0 != 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (EventButtonBreadcrumb)+24]");
			((Component)0).tag = (string)flag5;
			object obj14 = this + 44;
			obj = obj14;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v252 @ S2_v28+8]");
			_ = 0;
			((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (EventButtonBreadcrumb)+24]");
			((UIWidget)0).rawPivot = pivot;
		}
		nint num18 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v217 @ S1_v17 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj15 = (nint)0 & (nint)0x200;
		if (obj15 != null)
		{
			nint num19 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v263 @ S1_v55 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (EventButtonBreadcrumb)+4C]");
		if (UnityEngine.Object.IsNativeObjectAlive((UnityEngine.Object)0))
		{
			object obj16 = this + 80;
			obj = obj16;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v316 @ S2_v16+8]");
			_ = 0;
			((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (EventButtonBreadcrumb)+4C]");
			((UIWidget)0).rawPivot = pivot;
		}
		nint num20 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v338 @ S1_v24 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj17 = (nint)0 & (nint)0x200;
		if (obj17 != null)
		{
			nint num21 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v354 @ S1_v46 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (EventButtonBreadcrumb)+70]");
		if (UnityEngine.Object.IsNativeObjectAlive((UnityEngine.Object)0))
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (EventButtonBreadcrumb)+78]");
			bool flag6 = (nint)0 != 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (EventButtonBreadcrumb)+70]");
			((Component)0).tag = (string)flag6;
		}
		nint num22 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v397 @ S1_v31 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj18 = (nint)0 & (nint)0x200;
		if (obj18 != null)
		{
			nint num23 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v412 @ S1_v39 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (EventButtonBreadcrumb)+74]");
		if (UnityEngine.Object.IsNativeObjectAlive((UnityEngine.Object)0))
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (EventButtonBreadcrumb)+78]");
			bool flag7 = (nint)0 != 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (EventButtonBreadcrumb)+74]");
			((GameObject)0).tag = (string)flag7;
		}
	}

	private unsafe void CheckForUnseenEventPopup()
	{
		//IL_01a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a6: Expected Obj, but got Unknown
		//IL_01b9: Expected I, but got Obj
		//IL_01cf: Expected Obj, but got I
		//IL_0212: Expected Obj, but got I
		//IL_021e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0223: Expected Obj, but got Unknown
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Expected Obj, but got Unknown
		//IL_00ec: Expected I, but got Obj
		//IL_0102: Expected Obj, but got I
		//IL_012d: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr = 0;
		Action action = default;
		((Delegate)action).method_ptr = method_ptr;
		((Delegate)action).method = (nint)__ldftn(EventButtonBreadcrumb.CheckForUnseenEventPopup);
		object obj = action + 16;
		obj = this;
		nint num = (nint)typeof(SSEventsManagerController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S0_v12 (Il2CppClass<SSEventsManagerController>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(SSEventsManagerController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S0_v50 (Il2CppClass<SSEventsManagerController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		SSEventsManagerController.OnSSEventFinishedHandler += action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num3 = 0;
		SSEventsManagerController sSEventsManagerController = default;
		sSEventsManagerController._currentEventManager = (IEventManager)num3;
		_ = 0;
		object obj3 = sSEventsManagerController + 16;
		obj3 = this;
		sSEventsManagerController.Initialize();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr2 = 0;
		Action action2 = default;
		((Delegate)action2).method_ptr = method_ptr2;
		((Delegate)action2).method = (nint)__ldftn(EventButtonBreadcrumb.HideBreadcrumb);
		object obj4 = action2 + 16;
		obj4 = this;
		SSEventsManagerController.OnSSEventChangedHandler += action2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr3 = 0;
		Action action3 = default;
		((Delegate)action3).method_ptr = method_ptr3;
		((Delegate)action3).method = (nint)__ldftn(EventButtonBreadcrumb.PopupWasShown);
		object obj5 = action3 + 16;
		obj5 = this;
		nint num4 = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ S0_v41 (Il2CppClass<UIScreenController>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num5 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ S0_v46 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		UIScreenController.OnLastPopupClosed += action3;
	}

	private unsafe void ShowBreadcrumb()
	{
		//IL_0214: Unknown result type (might be due to invalid IL or missing references)
		//IL_0219: Expected Obj, but got Unknown
		//IL_0222: Expected Obj, but got I4
		//IL_0236: Expected I, but got Obj
		//IL_024c: Expected Obj, but got I
		//IL_0272: Unknown result type (might be due to invalid IL or missing references)
		//IL_0277: Expected Obj, but got Unknown
		//IL_0280: Unknown result type (might be due to invalid IL or missing references)
		//IL_0285: Expected VT, but got Unknown
		//IL_028e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0293: Expected Obj, but got Unknown
		//IL_0299: Unknown result type (might be due to invalid IL or missing references)
		//IL_029e: Expected Obj, but got Unknown
		//IL_02c1: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_0091: Expected I, but got Obj
		//IL_00a7: Expected Obj, but got I
		//IL_0133: Expected I, but got Obj
		//IL_0149: Expected Obj, but got I
		//IL_00d2: Expected I, but got Obj
		//IL_032b: Expected I, but got Obj
		//IL_0341: Expected Obj, but got I
		//IL_0366: Expected Obj, but got VT
		//IL_036e: Expected Obj, but got VT
		//IL_037b: Expected I8, but got Obj
		//IL_0376: Expected native int or pointer, but got VT
		//IL_0390: Expected Ref, but got VT
		//IL_039c: Expected Obj, but got I8
		//IL_03a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ae: Expected Obj, but got Unknown
		//IL_0174: Expected I, but got Obj
		//IL_01c1: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 16;
		obj = 0;
		this._002Ector();
		nint num = (nint)typeof(SSEventsManagerController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v12 (Il2CppClass<SSEventsManagerController>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num2 = (nint)typeof(SSEventsManagerController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v66 (Il2CppClass<SSEventsManagerController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		IFormatProvider formatProvider = (IFormatProvider)(obj2 + 32);
		DateTime dateTime = (DateTime)(obj2 + 24);
		object obj4 = obj2 + 8;
		object obj5 = this + 16;
		string flurryUserId = Flurry.flurryUserId;
		bool flag = ((SSEventsManagerController)(object)flurryUserId).DoesCharacterMatchCurrentEvent(Characters.CharacterId.slick);
		obj5 = flag;
		if (_activeEventManager == null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
		object obj6 = default;
		if (obj6 == null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
		nint num3 = (nint)typeof(UserSave);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ S1_v20 (Il2CppClass<Data.Save.UserSave>)+BA]");
		object obj7 = (nint)0 & (nint)0x200;
		if (obj7 != null)
		{
			nint num4 = (nint)typeof(UserSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ S1_v40 (Il2CppClass<Data.Save.UserSave>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string lastSeenBundleVersion = UserSave.lastSeenBundleVersion;
		object obj8 = default;
		if (obj8 != lastSeenBundleVersion)
		{
			HideBreadcrumb();
			return;
		}
		DateTime today = CDateTime.Today;
		nint num5 = (nint)typeof(UserSave);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ S0_v36 (Il2CppClass<Data.Save.UserSave>)+BA]");
		object obj9 = (nint)0 & (nint)0x200;
		if (obj9 != null)
		{
			nint num6 = (nint)typeof(UserSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ S0_v61 (Il2CppClass<Data.Save.UserSave>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		DateTime nextUnlockTime = FacebookWeeklyGiftManager.GetNextUnlockTime();
		nint num7 = (nint)typeof(DateTime);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ S0_v43 (Il2CppClass<System.DateTime>)+BA]");
		object obj10 = (nint)0 & (nint)0x200;
		if (obj10 != null)
		{
			nint num8 = (nint)typeof(DateTime);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ S0_v57 (Il2CppClass<System.DateTime>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		obj4 = today;
		obj2 = nextUnlockTime;
		((DateTime*)(nint)dateTime)->dateData = (ulong)(long)obj4;
		formatProvider = (IFormatProvider)obj2;
		long num9 = ((DateTime*)dateTime)->System_002EIConvertible_002EToInt64(formatProvider);
		obj = num9;
		object obj11 = obj / 864000000000L;
		if ((nint)obj11 > 4)
		{
			HideBreadcrumb();
		}
	}

	private void HideBreadcrumb()
	{
		//IL_0010: Expected Obj, but got I4
		_breadcrumb.tag = (string)1;
	}

	public EventButtonBreadcrumb()
	{
		_breadcrumb.tag = null;
	}
}
