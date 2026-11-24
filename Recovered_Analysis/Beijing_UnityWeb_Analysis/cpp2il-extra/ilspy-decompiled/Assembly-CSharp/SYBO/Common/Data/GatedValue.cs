using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using SYBO.Common.Events;
using SYBO.Common.Utilities;

namespace SYBO.Common.Data;

public class GatedValue
{
	private EventHandler<ValueChangedEventArgs> m_OnValueChanged;

	private float _minimumValue;

	private float _maximumValue;

	private float _value;

	private float[] _gateValues;

	public float MinimumValue => _maximumValue;

	public float MaximumValue => _minimumValue;

	public float Value
	{
		get
		{
			return _maximumValue;
		}
		set
		{
			_value = value;
		}
	}

	public float[] GateValues
	{
		get
		{
			//IL_001f: Expected Obj, but got I4
			SDebug.LogFormat("Retrieving Random value from unsynced random generator. Client game state diverged", null);
			return (float[])((LoggingRandomGen)(object)this.m_OnValueChanged).Seed;
		}
		set
		{
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected Obj, but got Unknown
			Delegate obj = this.m_OnValueChanged;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.RemoveImpl((Delegate)(object)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				object obj3 = this + 8;
				if (obj3 == obj)
				{
					obj3 = obj4;
				}
				if (obj3 != obj)
				{
					obj = (Delegate)obj3;
					continue;
				}
				break;
			}
		}
	}

	public Gate Gate
	{
		get
		{
			//IL_0007: Expected I4, but got Obj
			return (Gate)_gateValues;
		}
	}

	public event EventHandler<ValueChangedEventArgs> OnValueChanged
	{
		add
		{
			//IL_0077: Expected I, but got Obj
			//IL_008d: Expected Obj, but got I
			//IL_00b4: Expected I4, but got Obj
			//IL_0013: Expected I, but got Obj
			object obj = ((IConvertible)"SwitchDefaultException: Add case for '").ToType((Type)(object)value, (IFormatProvider)(object)"'.");
			nint num = (nint)typeof(Exception);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v9 (Il2CppClass<System.Exception>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num2 = (nint)typeof(Exception);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v14 (Il2CppClass<System.Exception>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			((Exception)this).SetErrorCode((int)obj);
		}
		remove
		{
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected Obj, but got Unknown
			Delegate obj = this.m_OnValueChanged;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.CombineImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				object obj3 = this + 8;
				if (obj3 == obj)
				{
					obj3 = obj4;
				}
				if (obj3 != obj)
				{
					obj = (Delegate)obj3;
					continue;
				}
				break;
			}
		}
	}

	public GatedValue(float minimumValue, float maximumValue, float defaultValue, float[] gateValues)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
	}

	private void RaiseOnValueChanged(ValueChangedEventArgs valueChangedEventArgs)
	{
		//IL_0134: Unknown result type (might be due to invalid IL or missing references)
		//IL_0139: Expected Obj, but got Unknown
		//IL_013f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0144: Expected Obj, but got Unknown
		//IL_016b: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 + 4;
		object obj3 = this + 24;
		obj3 = valueChangedEventArgs;
		bool flag = RuntimeHelpers.IsReferenceOrContainsReferences<T>();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v14 (System.Boolean)+C]");
		object obj4 = -3;
		float[] gateValues = _gateValues;
		if ((nint)obj4 == gateValues.Length)
		{
			Array.Sort(_gateValues);
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		throw new ArrayTypeMismatchException();
	}
}
