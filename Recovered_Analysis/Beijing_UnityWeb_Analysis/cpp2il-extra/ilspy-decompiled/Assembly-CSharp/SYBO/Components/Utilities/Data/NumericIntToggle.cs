using System;
using Cpp2ILInjected;
using SYBO.Components.Base.Interfaces;
using SYBO.Components.Json;
using SYBO.Components.Utilities.Components;

namespace SYBO.Components.Utilities.Data;

[Serializable]
public class NumericIntToggle : NumericToggle, IChangeable
{
	private int _value;

	private int _valueOriginal;

	public int Value
	{
		get
		{
			return (_value == _valueOriginal) ? 1 : 0;
		}
		set
		{
			//IL_0060: Expected Obj, but got I4
			//IL_0072: Expected I, but got Obj
			//IL_0088: Expected Obj, but got I
			//IL_00af: Expected I4, but got Obj
			//IL_0013: Expected I, but got Obj
			string text = $"Add case for '{(object[])value}'.";
			nint num = (nint)typeof(Exception);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9 (Il2CppClass<System.Exception>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(Exception);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v14 (Il2CppClass<System.Exception>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			((Exception)(object)this).SetErrorCode((int)text);
		}
	}

	public NumericIntToggle()
	{
		((NumericFloatToggle)this).SoftReset();
	}

	public NumericIntToggle(int value, bool isEnabled = true, string inspectorMessage = "(Default)")
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected Obj, but got Unknown
		//IL_0013: Expected Obj, but got I4
		object obj = this + 8;
		obj = value;
	}

	private void Initialize(int value, bool isEnabled, string message)
	{
		//IL_0018: Expected Obj, but got I4
		//IL_0018: Expected Obj, but got I4
		((SetActiveComponent)(object)this).Awake();
		((JsonContext)(object)this).RegisterDeserializeByKeyReference((object)value, (JsonFieldInfo)isEnabled, (object)message);
	}

	public void Reset()
	{
		//IL_001c: Expected Obj, but got I4
		((SetActiveComponent)(object)this).Awake();
		((JsonContext)(object)this).RegisterDeserializeByKeyReference((object)(-1), (JsonFieldInfo)null, (object)"(Default)");
	}

	public void SoftReset()
	{
		//IL_002a: Expected Obj, but got I4
		//IL_002a: Expected Obj, but got I4
		bool isEnabledOriginal = base._isEnabledOriginal;
		((JsonContext)(object)this).RegisterDeserializeByKeyReference((object)_valueOriginal, (JsonFieldInfo)isEnabledOriginal, (object)base._inspectorMessageOriginal);
	}

	protected override bool IsOriginalValue()
	{
		return (byte)_value != 0;
	}
}
