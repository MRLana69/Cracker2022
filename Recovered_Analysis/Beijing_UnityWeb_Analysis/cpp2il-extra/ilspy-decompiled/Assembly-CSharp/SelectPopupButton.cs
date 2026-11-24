using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2ILInjected;
using InApp;
using Info;
using SYBO.Subway.Info;
using UI.Popups;
using UnityEngine;

public class SelectPopupButton : MonoBehaviour
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Func<string, string> _003C_003E9__21_0;

		public static Func<string, string> _003C_003E9__21_1;

		public static Func<string, string> _003C_003E9__23_0;

		public static Func<string, string> _003C_003E9__23_1;

		static _003C_003Ec()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			RewardManager._003C_003Ec obj = default;
			RewardManager._003C_003Ec._003C_003E9 = obj;
		}

		public _003C_003Ec()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			NullReferenceException ex = default;
			ex._002Ector();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}

		internal string _003CSetItems_003Eb__21_0(string x)
		{
			//IL_0020: Expected Obj, but got I4
			int stringLength = x.m_stringLength;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SelectPopupButton+<>c)+8]");
			bool flag = (nint)stringLength == 0;
			return (string)flag;
		}

		internal string _003CSetItems_003Eb__21_1(string x)
		{
			return x;
		}

		internal string _003CSetSelected_003Eb__23_0(string x)
		{
			return x;
		}

		internal string _003CSetSelected_003Eb__23_1(string x)
		{
			return x;
		}
	}

	private List<string> _options;

	private Dictionary<string, string> _actualOptions;

	public bool multiSelect;

	private UILabel _currentSelectedLabel;

	private List<string> _selectedItems;

	private bool returningFromSelect__BackingField;

	private string value__BackingField;

	private Dictionary<string, string> multipleValues__BackingField;

	public List<EventDelegate> onChange;

	public unsafe bool returningFromSelect
	{
		get
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_03da: Unknown result type (might be due to invalid IL or missing references)
			//IL_03df: Expected I4, but got Unknown
			//IL_03f6: Unknown result type (might be due to invalid IL or missing references)
			//IL_03fb: Expected Obj, but got Unknown
			//IL_0417: Expected I, but got Obj
			//IL_042d: Expected Obj, but got I
			//IL_056d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0572: Expected Obj, but got Unknown
			//IL_00fc: Expected I, but got Obj
			//IL_0112: Expected Obj, but got I
			//IL_0021: Expected I, but got Obj
			//IL_006e: Expected I, but got Obj
			//IL_0084: Expected Obj, but got I
			//IL_0519: Expected I4, but got Obj
			//IL_0519: Expected Obj, but got I
			//IL_013d: Expected I, but got Obj
			//IL_045c: Expected Obj, but got I4
			//IL_0564: Expected I4, but got Obj
			//IL_018a: Expected I, but got Obj
			//IL_01a0: Expected Obj, but got I
			//IL_00af: Expected I, but got Obj
			//IL_0261: Expected I, but got Obj
			//IL_0277: Expected Obj, but got I
			//IL_01cb: Expected I, but got Obj
			//IL_02a2: Expected I, but got Obj
			object obj2 = default;
			object obj = obj2 + 32;
			bool flag = (byte)(obj2 + 16) != 0;
			((bool*)(flag ? 1 : 0))->m_value = false;
			object obj3 = obj2 + 8;
			obj3 = obj;
			_ = -1;
			nint num = (nint)typeof(Globals);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S0_v17 (Il2CppClass<Globals>)+BA]");
			object obj4 = (nint)0 & (nint)0x200;
			if (obj4 != null)
			{
				nint num2 = (nint)typeof(Globals);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S0_v158 (Il2CppClass<Globals>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			object obj5 = obj2 + 20;
			List<string> list = default;
			if (~(Globals.DEBUG_USE_EVENT_TESTER ? 1u : 0u) == 0)
			{
				nint num3 = (nint)typeof(EventTesterManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ S0_v147 (Il2CppClass<EventTesterManager>)+BA]");
				object obj6 = (nint)0 & (nint)0x200;
				if (obj6 != null)
				{
					nint num4 = (nint)typeof(EventTesterManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ S0_v154 (Il2CppClass<EventTesterManager>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				bool isInitialized = EventTesterManager.isInitialized;
				List<string> eventTypes = ((EventTesterPopup)isInitialized).GetEventTypes();
				list = eventTypes;
			}
			else
			{
				nint num5 = (nint)typeof(OnlineSettings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ S0_v36 (Il2CppClass<Info.OnlineSettings>)+BA]");
				object obj7 = (nint)0 & (nint)0x200;
				if (obj7 != null)
				{
					nint num6 = (nint)typeof(OnlineSettings);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ S0_v142 (Il2CppClass<Info.OnlineSettings>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				string saveDataPath = OnlineSettings.GetSaveDataPath();
				if (((InAppManager)(object)saveDataPath).RestoreNonConsumablePurchases((string[])(object)"event_category", flag))
				{
					nint num7 = (nint)typeof(Type);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v160 @ S0_v46 (Il2CppClass<System.Type>)+BA]");
					object obj8 = (nint)0 & (nint)0x200;
					if (obj8 != null)
					{
						nint num8 = (nint)typeof(Type);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v168 @ S0_v132 (Il2CppClass<System.Type>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
						}
					}
					obj2 = typeof(SSEventCategory);
					obj5 = obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
					nint num9 = (nint)typeof(Enum);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v213 @ S0_v95 (Il2CppClass<System.Enum>)+BA]");
					object obj9 = (nint)0 & (nint)0x200;
					if (obj9 != null)
					{
						nint num10 = (nint)typeof(Enum);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v224 @ S0_v119 (Il2CppClass<System.Enum>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
					object obj11 = default;
					object obj10 = obj11;
					object obj13 = default;
					object obj12 = obj13;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1AD");
					object obj14 = default;
					if (obj12 == obj14)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @99");
						object obj16 = default;
						object obj15 = obj16;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9B");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1D");
						object obj18 = default;
						object obj17 = obj18;
					}
					else
					{
						object obj17 = obj10;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A4");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SelectPopupButton)+E8]");
			if (!((List<SSEventCategory>)0).Contains((SSEventCategory)list))
			{
				list = null;
			}
			return (byte)(int)list != 0;
		}
		private set
		{
			//IL_000e: Expected Obj, but got I4
			//IL_002c: Expected Obj, but got I4
			//IL_002c: Expected Obj, but got I4
			//IL_003b: Expected Obj, but got I4
			string text = (string)((value ? 1 : 0) ^ 1);
			((GameObject)(object)_actualOptions).tag = text;
			((GameObject)multiSelect).tag = (string)value;
			_selectedItems = (List<string>)value;
		}
	}

	public string value
	{
		get
		{
			//IL_0019: Expected Obj, but got I4
			bool flag = returningFromSelect__BackingField;
			return (string)flag;
		}
		private set
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected I4, but got Unknown
			bool flag = (byte)(value & 1) != 0;
			returningFromSelect__BackingField = flag;
		}
	}

	public Dictionary<string, string> multipleValues
	{
		get
		{
			return (Dictionary<string, string>)(object)value__BackingField;
		}
		private set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected Obj, but got Unknown
			object obj = this + 36;
			obj = value;
		}
	}

	public SelectPopupButton()
	{
		CancelInvoke();
	}

	private void Awake()
	{
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Expected Obj, but got Unknown
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		List<string> list = default;
		list._002Ector();
		object obj = this + 12;
		obj = list;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		List<EventDelegate> list2 = default;
		list2._002Ector();
		object obj2 = this + 44;
		obj2 = list2;
		CancelInvoke();
		returningFromSelect__BackingField = false;
	}

	private void Start()
	{
		//IL_0025: Expected Obj, but got I
		//IL_0035: Expected Obj, but got I
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Expected Obj, but got Unknown
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Expected Obj, but got Unknown
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S3_v2 (Il2CppMethodInfo)+C]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S3_v3+60]");
		object obj2 = 0;
		object obj3 = obj2;
		object obj4 = obj3 & 0x1FFF;
		object obj5 = obj4 + 113696;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v28 @ S4_v4 (should have been resolved before IL gen)");
		object obj6 = this + 40;
		object obj7 = default;
		obj6 = obj7;
	}

	public void SetItems(List<string> items, int selectedIndex = 0)
	{
	}

	public void SetItems(Dictionary<string, string> items)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected Obj, but got Unknown
		object obj = this + 40;
		obj = items;
	}

	public void SetSelected(List<string> selected)
	{
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected Obj, but got Unknown
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Expected Obj, but got Unknown
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected Obj, but got Unknown
		returningFromSelect__BackingField = false;
		object obj = this + 12;
		Dictionary<string, string>.ValueCollection values = ((Dictionary<string, string>)(object)selected).Values;
		List<string> list = Enumerable.ToList(values);
		obj = list;
		object obj2 = this + 16;
		obj2 = selected;
		if (~(multiSelect ? 1u : 0u) != 0)
		{
			object obj3 = this + 36;
			string text = _options.get_Item(0);
			obj3 = text;
		}
		((ScrollPanelPixelPerfect)this).Start();
	}

	public void SetSelected(Dictionary<string, string> selected)
	{
		//IL_01c9: Expected I, but got Obj
		//IL_01df: Expected Obj, but got I
		//IL_038d: Expected I, but got Obj
		//IL_03a3: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0346: Expected Obj, but got I
		//IL_0357: Unknown result type (might be due to invalid IL or missing references)
		//IL_035c: Expected Obj, but got Unknown
		//IL_0365: Unknown result type (might be due to invalid IL or missing references)
		//IL_036a: Expected Obj, but got Unknown
		//IL_00ee: Expected I, but got Obj
		//IL_021d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0222: Expected Obj, but got Unknown
		//IL_0239: Expected I, but got Obj
		//IL_024f: Expected Obj, but got I
		//IL_013b: Expected I, but got Obj
		//IL_0151: Expected Obj, but got I
		//IL_00a1: Expected I, but got Obj
		//IL_02b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bc: Expected Obj, but got Unknown
		//IL_02d3: Expected I, but got Obj
		//IL_02e9: Expected Obj, but got I
		//IL_017c: Expected I, but got Obj
		nint num = (nint)typeof(_003C_003Ec);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SelectPopupButton+<>c>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v86 (Il2CppClass<SelectPopupButton+<>c>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = _003C_003Ec._003C_003E9__23_0 == null;
		bool flag2 = !flag;
		Func<string, string> func = _003C_003Ec._003C_003E9__23_0;
		if (!flag2)
		{
			nint num3 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v60 (Il2CppClass<SelectPopupButton+<>c>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(_003C_003Ec);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ S0_v80 (Il2CppClass<SelectPopupButton+<>c>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num5 = 0;
			_ = 0;
			Func<string, string> func2 = default;
			object obj3 = func2 + 16;
			obj3 = _003C_003Ec._003C_003E9;
			nint num6 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ S0_v77 (Il2CppClass<SelectPopupButton+<>c>)+5C]");
			object obj4 = (nint)0 + (nint)12;
			obj4 = func2;
			func = func2;
		}
		nint num7 = (nint)typeof(_003C_003Ec);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v16 (Il2CppClass<SelectPopupButton+<>c>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num8 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ S0_v53 (Il2CppClass<SelectPopupButton+<>c>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag3 = _003C_003Ec._003C_003E9__23_1 == null;
		bool flag4 = !flag3;
		Func<string, string> func3 = _003C_003Ec._003C_003E9__23_1;
		if (!flag4)
		{
			nint num9 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ S0_v27 (Il2CppClass<SelectPopupButton+<>c>)+BA]");
			object obj6 = (nint)0 & (nint)0x200;
			if (obj6 != null)
			{
				nint num10 = (nint)typeof(_003C_003Ec);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ S0_v47 (Il2CppClass<SelectPopupButton+<>c>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num11 = 0;
			_ = 0;
			Func<string, string> func4 = default;
			object obj7 = func4 + 16;
			obj7 = _003C_003Ec._003C_003E9;
			nint num12 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v184 @ S0_v44 (Il2CppClass<SelectPopupButton+<>c>)+5C]");
			object obj8 = (nint)0 + (nint)16;
			obj8 = func4;
			func3 = func4;
		}
		nint num13 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ S5_v2 (Il2CppMethodInfo)+18]");
		object obj9 = 0;
		object obj10 = obj9;
		object obj11 = obj10 & 0x7FF;
		object obj12 = obj11 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v151 @ S6_v4 (should have been resolved before IL gen)");
		Dictionary<string, string> selectedItems = default;
		OnSelectPopupClosed(selectedItems);
	}

	private unsafe void OnButtonClick()
	{
		//IL_0187: Unknown result type (might be due to invalid IL or missing references)
		//IL_018c: Expected Obj, but got Unknown
		//IL_019f: Expected I, but got Obj
		//IL_01b5: Expected Obj, but got I
		//IL_01f6: Expected I, but got Obj
		//IL_020c: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Expected Obj, but got Unknown
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Expected Obj, but got Unknown
		returningFromSelect__BackingField = false;
		UIEventTrigger component = GetComponent<UIEventTrigger>();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr = 0;
		EventDelegate.Callback callback = default;
		((Delegate)callback).method_ptr = method_ptr;
		((Delegate)callback).method = (nint)__ldftn(SelectPopupButton.OnButtonClick);
		object obj = callback + 16;
		obj = this;
		nint num = (nint)typeof(EventDelegate);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S1_v12 (Il2CppClass<EventDelegate>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(EventDelegate);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S1_v37 (Il2CppClass<EventDelegate>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = EventDelegate.Remove(component.onClick, callback);
		nint num3 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ S1_v18 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num4 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ S1_v33 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (_currentSelectedLabel != null)
		{
			object obj4 = this + 24;
			UILabel componentInChildren = GetComponentInChildren<UILabel>();
			obj4 = componentInChildren;
		}
		if (~(multiSelect ? 1u : 0u) != 0)
		{
			string text = value__BackingField;
			if (value__BackingField == null || text.m_stringLength == 0)
			{
				object obj5 = this + 36;
				string text2 = _options.get_Item(0);
				obj5 = text2;
			}
		}
		((ScrollPanelPixelPerfect)this).Start();
	}

	private void OnSelectPopupClosed(Dictionary<string, string> selectedItems)
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected Obj, but got Unknown
		if (~(multiSelect ? 1u : 0u) == 0)
		{
			object obj = this + 40;
			obj = selectedItems;
			((ScrollPanelPixelPerfect)this).Start();
		}
	}

	private unsafe void NotifyOnChange()
	{
		//IL_0177: Expected I, but got Obj
		//IL_018d: Expected Obj, but got I
		//IL_01c1: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_0090: Expected F4, but got I
		//IL_008b: Expected native int or pointer, but got VT
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Expected Obj, but got Unknown
		//IL_005f: Expected I4, but got Obj
		//IL_015d: Expected VT, but got I4
		//IL_015d: Expected VT, but got Obj
		nint num = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UIScreenController>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v20 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = UIScreenController.ShouldShowOnlineScreen();
		((UIScreenController)flag).QueuePopup("ScrollListSelectPopup");
		if (_actualOptions == null)
		{
			((PurchaseHandler)(object)this).OnPurchaseCharacterWithInappSucceded((Characters.CharacterId)_options, (string)null);
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @735C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num3 = 0;
		Vector3 vector = default;
		((Vector3*)(nint)vector)->z = num3;
		_ = 0;
		object obj2 = vector + 16;
		obj2 = this;
		List<string> list2;
		if (~(multiSelect ? 1u : 0u) == 0)
		{
			Dictionary<string, string>.KeyCollection keys = multipleValues__BackingField.Keys;
			List<string> list = Enumerable.ToList(keys);
			list2 = list;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			List<string> list3 = default;
			list3._002Ector();
			UILabel currentSelectedLabel = _currentSelectedLabel;
			list3.Add(currentSelectedLabel.mText);
			list2 = list3;
		}
		bool flag2 = multiSelect;
		UIWidget tracker = default;
		AgeRestrictionPopup.PositionModelOnSprite(tracker, (GameObject)(object)_actualOptions, vector, (Vector3)list2, (Vector3)flag2);
		returningFromSelect__BackingField = false;
	}
}
