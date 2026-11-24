using ABTest;
using Cpp2ILInjected;
using UnityEngine;

namespace UI.Popups.ABTestTesterPopupInternal;

public class ABTestTesterCellHelper : MonoBehaviour
{
	private UILabel _title;

	private UILabel _description;

	private SelectPopupButton _selectPayloadButton;

	private UILabel _selectPayloadText;

	private GameObject _offIcon;

	private GameObject _onIcon;

	private bool _currentIconState;

	private ABTestData.ABTestDataItem _testDataItem;

	public void Init(ABTestData.ABTestDataItem testDataItem)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected Obj, but got Unknown
		object obj = this + 20;
		obj = testDataItem;
	}

	public void PayloadSelected()
	{
		CancelInvoke();
	}

	public void ToggleActive()
	{
		//IL_001d: Expected I, but got Obj
		//IL_0033: Expected Obj, but got I
		//IL_0186: Expected I4, but got Obj
		//IL_0186: Expected Obj, but got I4
		//IL_005e: Expected I, but got Obj
		//IL_00bf: Expected I, but got Obj
		//IL_00d5: Expected Obj, but got I
		//IL_0100: Expected I, but got Obj
		if (~(_currentIconState ? 1u : 0u) != 0)
		{
			return;
		}
		ABTestData.ABTestDataItem testDataItem = _testDataItem;
		nint num = (nint)typeof(ABTestManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S1_v4 (Il2CppClass<ABTest.ABTestManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(ABTestManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S1_v15 (Il2CppClass<ABTest.ABTestManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		uint num3 = _003CPrivateImplementationDetails_003E.ComputeStringHash(testDataItem.identifier);
		SelectPopupButton selectPayloadButton = _selectPayloadButton;
		if (((string)num3).get_Chars((int)selectPayloadButton.value__BackingField) == '\0')
		{
			return;
		}
		ABTestData.ABTestDataItem testDataItem2 = _testDataItem;
		SelectPopupButton selectPayloadButton2 = _selectPayloadButton;
		nint num4 = (nint)typeof(ABTestManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ S2_v5 (Il2CppClass<ABTest.ABTestManager>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num5 = (nint)typeof(ABTestManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ S2_v10 (Il2CppClass<ABTest.ABTestManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		ABTestManager.LogWarn(testDataItem2.identifier, (Object)(object)selectPayloadButton2.value__BackingField);
	}

	public ABTestTesterCellHelper()
	{
		//IL_017a: Expected Obj, but got I4
		//IL_01ac: Expected Obj, but got I4
		//IL_00ab: Expected I, but got Obj
		//IL_00c1: Expected Obj, but got I
		//IL_001d: Expected I, but got Obj
		//IL_0033: Expected Obj, but got I
		//IL_00ec: Expected I, but got Obj
		//IL_005e: Expected I, but got Obj
		bool currentIconState = _currentIconState;
		bool currentIconState2 = (byte)((currentIconState ? 1u : 0u) ^ 1u) != 0;
		_currentIconState = currentIconState2;
		bool currentIconState3 = _currentIconState;
		string text = (string)((currentIconState3 ? 1 : 0) ^ 1);
		_offIcon.tag = text;
		bool currentIconState4 = _currentIconState;
		_onIcon.tag = (string)currentIconState4;
		ABTestData.ABTestDataItem testDataItem = _testDataItem;
		if (~(_currentIconState ? 1u : 0u) == 0)
		{
			SelectPopupButton selectPayloadButton = _selectPayloadButton;
			nint num = (nint)typeof(ABTestManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S0_v30 (Il2CppClass<ABTest.ABTestManager>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(ABTestManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ S0_v35 (Il2CppClass<ABTest.ABTestManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			ABTestManager.LogWarn(testDataItem.identifier, (Object)(object)selectPayloadButton.value__BackingField);
			return;
		}
		nint num3 = (nint)typeof(ABTestManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ S0_v17 (Il2CppClass<ABTest.ABTestManager>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(ABTestManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ S0_v22 (Il2CppClass<ABTest.ABTestManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		testDataItem.identifier();
	}
}
