using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2ILInjected;
using UnityEngine;

public class SelectPopupButton : MonoBehaviour
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Func<string, string> _003C_003E9__17_0;

		public static Func<string, string> _003C_003E9__17_1;

		public static Func<string, string> _003C_003E9__18_0;

		public static Func<string, string> _003C_003E9__18_1;

		static _003C_003Ec()
		{
			_003C_003Ec obj = default;
			_003C_003E9 = obj;
		}

		internal string _003CStart_003Eb__17_0(string x)
		{
			return x;
		}

		internal string _003CStart_003Eb__17_1(string x)
		{
			return x;
		}

		internal string _003CSetItems_003Eb__18_0(string x)
		{
			return x;
		}

		internal string _003CSetItems_003Eb__18_1(string x)
		{
			return x;
		}
	}

	private List<string> _options;

	private Dictionary<string, string> _actualOptions;

	public bool multiSelect;

	private UILabel _currentSelectedLabel;

	private List<string> _selectedItems;

	private bool _returningFromSelect;

	public List<EventDelegate> onChange;

	private Dictionary<string, string> multipleValues__BackingField;

	public bool returningFromSelect => _returningFromSelect;

	public string value
	{
		get
		{
			return null;
		}
		private set
		{
		}
	}

	public Dictionary<string, string> multipleValues
	{
		get
		{
			return multipleValues__BackingField;
		}
		private set
		{
			multipleValues__BackingField = value;
		}
	}

	private void Awake()
	{
		nint num = 0;
		nint num2 = 0;
		IntPtr intPtr = num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v26 @ S4_v4 (Il2CppClass<Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, System.String>>>)+4] (should have been resolved before IL gen)");
		Dictionary<string, string> dictionary = default;
		multipleValues__BackingField = dictionary;
	}

	private unsafe void Start()
	{
		//IL_00db: Expected Obj, but got I4
		//IL_00c2: Expected Obj, but got I4
		_returningFromSelect = false;
		bool flag = _003C_003Ec._003C_003E9__17_0 == null;
		bool flag2 = !flag;
		Func<string, string> func = _003C_003Ec._003C_003E9__17_0;
		if (!flag2)
		{
			throw new ArgumentException();
		}
		bool flag3 = _003C_003Ec._003C_003E9__17_1 == null;
		bool flag4 = !flag3;
		Func<string, string> func2 = _003C_003Ec._003C_003E9__17_1;
		if (!flag4)
		{
			throw new ArgumentException();
		}
		nint num = 0;
		nint num2 = 0;
		IntPtr intPtr = num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v91 @ S6_v3 (Il2CppClass<Il2CppMethodRgctx<System.Linq.Enumerable::ToDictionary>>)+4] (should have been resolved before IL gen)");
		Dictionary<string, string> actualOptions = default;
		_actualOptions = actualOptions;
		UIEventTrigger component = GetComponent<UIEventTrigger>();
		EventDelegate.Callback callback = default;
		callback._002Ector(this, (nint)__ldftn(SelectPopupButton.OnButtonClick));
		EventDelegate eventDelegate = EventDelegate.Add(component.onClick, callback);
		if (_currentSelectedLabel == null)
		{
			UILabel componentInChildren = GetComponentInChildren<UILabel>();
			_currentSelectedLabel = componentInChildren;
		}
		if (multiSelect)
		{
			goto IL_00f9;
		}
		object obj;
		if ((object)this != null)
		{
			obj = 0;
			if (((UnityEngine.Object)this).m_CachedPtr != (IntPtr)0)
			{
				goto IL_01c6;
			}
		}
		obj = 1;
		goto IL_01c6;
		IL_00f9:
		NotifyOnChange();
		return;
		IL_01c6:
		if (obj != null)
		{
			string text = _options.get_Item(0);
		}
		goto IL_00f9;
	}

	public void SetItems(List<string> items, int selectedIndex = 0)
	{
		_options = items;
		_returningFromSelect = false;
		bool flag = _003C_003Ec._003C_003E9__18_0 == null;
		bool flag2 = !flag;
		Func<string, string> func = _003C_003Ec._003C_003E9__18_0;
		if (!flag2)
		{
			throw new ArgumentException();
		}
		bool flag3 = _003C_003Ec._003C_003E9__18_1 == null;
		bool flag4 = !flag3;
		Func<string, string> func2 = _003C_003Ec._003C_003E9__18_1;
		if (!flag4)
		{
			throw new ArgumentException();
		}
		nint num = 0;
		nint num2 = 0;
		IntPtr intPtr = num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v94 @ S6_v3 (Il2CppClass<Il2CppMethodRgctx<System.Linq.Enumerable::ToDictionary>>)+4] (should have been resolved before IL gen)");
		Dictionary<string, string> actualOptions = default;
		_actualOptions = actualOptions;
		if (~(multiSelect ? 1u : 0u) != 0)
		{
			string text = _options.get_Item(selectedIndex);
		}
		NotifyOnChange();
	}

	public void SetItems(Dictionary<string, string> items)
	{
		_returningFromSelect = false;
		Dictionary<string, string>.ValueCollection values = items.Values;
		List<string> options = Enumerable.ToList(values);
		_options = options;
		_actualOptions = items;
		if (~(multiSelect ? 1u : 0u) != 0)
		{
			string text = _options.get_Item(0);
		}
		NotifyOnChange();
	}

	private void OnButtonClick()
	{
		UIScreenController instance = UIScreenController.Instance;
		instance.PushPopup("ScrollListSelectPopup");
		throw new ArgumentException();
	}

	private void OnSelectPopupClosed(Dictionary<string, string> selectedItems)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0124: Expected Obj, but got I4
		//IL_004b: Expected Obj, but got I4
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Expected Obj, but got Unknown
		//IL_00a5: Expected Obj, but got I4
		object obj2 = default;
		object obj = obj2 - 16;
		object obj3 = selectedItems._count - selectedItems._freeCount;
		string text = default;
		if ((nint)obj3 == 1)
		{
			Dictionary<string, string>.ValueCollection values = selectedItems.Values;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @967C");
		}
		else
		{
			object obj4 = selectedItems._count - selectedItems._freeCount;
			object obj5 = obj + 12;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
			object arg = default;
			text = $"{arg} selected";
		}
		_currentSelectedLabel.text = text;
		object obj6 = selectedItems._count - selectedItems._freeCount;
		if ((nint)obj6 >= 1)
		{
			multipleValues__BackingField = selectedItems;
			Dictionary<string, string>.ValueCollection values2 = selectedItems.Values;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @967C");
			_returningFromSelect = true;
			NotifyOnChange();
		}
	}

	private void NotifyOnChange()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0242: Unknown result type (might be due to invalid IL or missing references)
		//IL_0247: Expected Obj, but got Unknown
		//IL_0274: Unknown result type (might be due to invalid IL or missing references)
		//IL_0279: Expected Obj, but got Unknown
		//IL_02be: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c3: Expected Obj, but got Unknown
		//IL_029f: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a4: Expected Obj, but got Unknown
		//IL_01ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b0: Expected Obj, but got Unknown
		//IL_021c: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 48;
		_ = 0;
		_ = 0;
		object obj3 = obj + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B5");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
		_ = 0;
		object obj4 = obj + 32;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		_ = 0;
		object obj6 = default;
		object obj7;
		object obj8 = default;
		object obj9 = default;
		object obj11 = default;
		object obj12 = default;
		while (true)
		{
			_ = 0;
			object obj5 = obj + 32;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				bool flag = obj6 == null;
				obj7 = obj;
				if (flag)
				{
					break;
				}
				_ = 0;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						continue;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
			bool flag2 = obj8 == obj9;
			bool flag3 = !flag2;
			object obj10 = obj11;
			if (!flag3)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				bool flag4 = (nint)0 != 1;
				obj7 = obj;
				if (flag4)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				obj10 = obj12;
			}
			_ = 0;
			object obj13 = obj + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 == 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				obj7 = 0;
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
			return;
		}
		object obj14 = obj7 + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @967D");
	}

	public SelectPopupButton()
	{
		List<string> list = default;
		list._002Ector();
		_options = list;
		List<EventDelegate> list2 = default;
		list2._002Ector();
		onChange = list2;
		base._002Ector();
	}
}
