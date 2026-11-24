using System;
using System.Collections.Generic;
using ABTest;
using Cpp2ILInjected;
using Kiloo.Common.UI;
using SYBO.Subway.Info;
using UI.Screens;
using UI.Screens.CharacterScreenInternal;
using UI.ScrollListSelectPopup;
using UnityEngine;

namespace UI.Popups;

public class ABTestTesterPopup : UIScreen
{
	private class ABTestTesterListAdapter : ListAdapter<ABTestData.ABTestDataItem>
	{
		private GameObject _cellPrefab;

		public ABTestTesterListAdapter(List<ABTestData.ABTestDataItem> identifiers, GameObject cell)
		{
			//IL_0010: Unknown result type (might be due to invalid IL or missing references)
			//IL_0015: Expected Obj, but got Unknown
			object obj = this + 16;
			obj = identifiers;
		}

		public unsafe override Container GetContainer(Container container, int dataIndex, bool isMeasurePass = false)
		{
			//IL_0281: Expected Obj, but got I
			//IL_0291: Expected Obj, but got I
			//IL_02b8: Expected Obj, but got I
			//IL_02b8: Expected Obj, but got I
			//IL_008b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0090: Expected Obj, but got Unknown
			//IL_00aa: Expected Obj, but got VT
			//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b8: Expected Obj, but got Unknown
			//IL_02d6: Expected Obj, but got I
			//IL_00d7: Expected Obj, but got I4
			//IL_00ed: Expected Obj, but got I
			//IL_0105: Expected Obj, but got I
			//IL_013a: Unknown result type (might be due to invalid IL or missing references)
			//IL_013f: Expected Obj, but got Unknown
			//IL_015f: Expected Obj, but got I
			//IL_0174: Expected Obj, but got I
			//IL_0198: Unknown result type (might be due to invalid IL or missing references)
			//IL_019d: Expected Obj, but got Unknown
			//IL_01df: Unknown result type (might be due to invalid IL or missing references)
			//IL_01e4: Expected Obj, but got Unknown
			//IL_02eb: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7308");
			Container container2 = default;
			if (container2 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S0_v9+8]");
				object obj2 = default;
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S0_v9+8]");
					if ((nint)0 == 1)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.Popups.ABTestTesterPopup+ABTestTesterListAdapter)+18]");
						Container container3 = default;
						container3.Measure(includeInactive: false);
						object obj = container3 + 84;
						obj = obj2;
						container2 = container3;
					}
					else
					{
						container2 = null;
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.Popups.ABTestTesterPopup+ABTestTesterListAdapter)+14]");
					Container container4 = default;
					container4.Measure(includeInactive: false);
					object obj3 = obj2 + 8;
					_0021_00210 componentInChildren = (_0021_00210)container4.model.GetComponentInChildren<T>();
					obj3 = componentInChildren;
					object obj4 = obj2 + 12;
					bool hasVertices = ((UIGeometry)(object)container4.model).hasVertices;
					obj4 = hasVertices;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S0_v39+C]");
					object obj5 = (nint)0 + (nint)12;
					obj5 = container4;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S0_v39+C]");
					object obj6 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
					nint method_ptr = 0;
					Delegate obj7 = default;
					obj7.method_ptr = method_ptr;
					obj7.method = (nint)__ldftn(UI.ScrollListSelectPopup.ScrollListSelectPopup.OnClickContainer);
					object obj8 = obj7 + 16;
					obj8 = _cellPrefab;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S0_v39+C]");
					object obj9 = (nint)0 + (nint)20;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ S0_v55+14]");
					Delegate obj10 = ((Delegate)0).CombineImpl(obj7);
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
					object obj11 = default;
					obj9 = obj11;
					object obj12 = container4 + 84;
					obj12 = obj2;
					container2 = container4;
				}
			}
			if (!isMeasurePass)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7510");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S0_v9+8]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S0_v9+8]");
					if ((nint)0 != 1)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S0_v9+8]");
						object obj13 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
						string text = default;
						string msg = "No cell type match for: " + text;
						SDebug.LogFormat(msg, null);
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72E6");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ S0_v20+8]");
					object obj14 = (nint)0 + (nint)24;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S0_v9+10]");
					obj14 = 0;
					GameObject cellPrefab = _cellPrefab;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ S1_v14 (UnityEngine.GameObject)+48]");
					nint num = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S0_v9+10]");
					bool returningFromSelect = ((Dictionary<string, bool>)num).get_Item((string)0);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ S0_v20+8]");
					((SelectPopupButton)0).returningFromSelect = returningFromSelect;
				}
			}
			return container2;
		}
	}

	private GameObject _cellPrefab;

	private ScrollView _scrollView;

	private GameObject _initializationInfo;

	private ABTestTesterListAdapter _adapter;

	public override void Init()
	{
	}

	public override void Show()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_030d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0312: Expected Obj, but got Unknown
		//IL_031b: Expected Obj, but got I4
		//IL_032a: Unknown result type (might be due to invalid IL or missing references)
		//IL_032f: Expected I, but got Unknown
		//IL_0337: Expected I, but got Obj
		//IL_034b: Expected I, but got Obj
		//IL_0361: Expected Obj, but got I
		//IL_0429: Unknown result type (might be due to invalid IL or missing references)
		//IL_042e: Expected Obj, but got Unknown
		//IL_0021: Expected I, but got Obj
		//IL_04ab: Expected I4, but got Obj
		//IL_04ab: Expected I4, but got Obj
		//IL_04b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b6: Expected Obj, but got Unknown
		//IL_00a3: Expected I, but got Obj
		//IL_00b9: Expected Obj, but got I
		//IL_00e4: Expected I, but got Obj
		//IL_03b0: Expected Obj, but got I
		//IL_03b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03be: Expected Obj, but got Unknown
		//IL_03dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e1: Expected Obj, but got Unknown
		//IL_03ea: Expected Obj, but got I4
		//IL_026f: Expected Obj, but got I
		//IL_0277: Unknown result type (might be due to invalid IL or missing references)
		//IL_027c: Expected Obj, but got Unknown
		//IL_02b2: Expected Obj, but got I
		//IL_02e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e8: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 48;
		object obj3 = obj2 + 24;
		obj3 = 0;
		_ = 0;
		nint num = (nint)(obj2 + 16);
		num = (nint)obj;
		_ = -1;
		nint num2 = (nint)typeof(ABTestManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S1_v11 (Il2CppClass<ABTest.ABTestManager>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num3 = (nint)typeof(ABTestManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ S1_v69 (Il2CppClass<ABTest.ABTestManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7C30");
		object obj5 = default;
		string text = (string)(obj5 ^ 1);
		_initializationInfo.tag = text;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		List<ABTestData.ABTestDataItem> list = default;
		list._002Ector();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7C30");
		object obj6 = default;
		if (obj6 != null)
		{
			nint num4 = (nint)typeof(ABTestData);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ S0_v34 (Il2CppClass<ABTest.ABTestData>)+BA]");
			object obj7 = (nint)0 & (nint)0x200;
			if (obj7 != null)
			{
				nint num5 = (nint)typeof(ABTestData);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ S0_v110 (Il2CppClass<ABTest.ABTestData>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @727C");
			obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			_ = 0;
			object obj8 = default;
			object obj9 = default;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				if (obj8 == null)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v213 @ S0_v89+8]");
				if ((nint)0 != 0)
				{
					continue;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				if (obj9 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v213 @ S0_v89+1C]");
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
					}
				}
			}
			object obj10 = num + 4;
			object obj11 = obj10 + 1;
			obj10 = obj11;
			object obj12 = obj11 << 2;
			object obj13 = num + obj12;
			obj13 = 114;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15 (Il2CppMethodInfo)+4]");
			if ((nint)0 != -1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15 (Il2CppMethodInfo)+4]");
				object obj14 = (nint)0 << 2;
				object obj15 = num + obj14;
				if ((nint)obj15 == 114)
				{
					object obj16 = num + 4;
					if ((nint)obj16 > -1)
					{
						object obj17 = obj16 + -1;
						obj16 = obj17;
					}
					goto IL_048e;
				}
			}
			object obj18 = default;
			if (obj18 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
			}
		}
		goto IL_048e;
		IL_048e:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		CharacterModelRequest.CharacterBundleRequest characterBundleRequest = default;
		characterBundleRequest._002Ector((Characters.CharacterId)list, (int)_cellPrefab);
		object obj19 = this + 52;
		obj19 = characterBundleRequest;
	}

	public ABTestTesterPopup()
	{
		//IL_0017: Expected I4, but got Obj
		base.Hide();
		_scrollView.CalculateVirtualRelativeWidgetBounds((ScrollView.BoundsCalculationMode)_adapter);
	}
}
