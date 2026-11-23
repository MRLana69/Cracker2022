using System;
using Cpp2ILInjected;
using SYBO.Common.Events;
using SYBO.Common.Utilities;

namespace SYBO.Common.Data;

public class GatedValue
{
	private float _minimumValue;

	private float _maximumValue;

	private float _value;

	private float[] _gateValues;

	private EventHandler<ValueChangedEventArgs> m_OnValueChanged;

	public float MinimumValue => _minimumValue;

	public float MaximumValue => _maximumValue;

	public float Value
	{
		get
		{
			return _value;
		}
		set
		{
			bool flag = value < _maximumValue;
			float num = value;
			if (!flag)
			{
				num = _maximumValue;
			}
			if (!(num > _minimumValue))
			{
				num = _minimumValue;
			}
			_value = num;
			if (num != _value)
			{
				float deltaValue = num - _value;
				ValueChangedEventArgs e = default;
				e._002Ector(_value, _value, deltaValue);
				EventHandler<ValueChangedEventArgs> onValueChanged = this.m_OnValueChanged;
				if (this.m_OnValueChanged != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v71 @ S0_v17 (System.EventHandler`1<SYBO.Common.Events.ValueChangedEventArgs>)+C] (should have been resolved before IL gen)");
				}
			}
		}
	}

	public float[] GateValues
	{
		get
		{
			return _gateValues;
		}
		set
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_017c: Expected Obj, but got I4
			object obj2 = default;
			object obj = obj2 - 16;
			_gateValues = value;
			int[] array = EnumUtility.ConvertEnumToIntArray<T>();
			object obj3 = array.Length - 3;
			float[] gateValues = _gateValues;
			if ((nint)obj3 != gateValues.Length)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
				throw new ArrayTypeMismatchException();
			}
			Array.Sort(gateValues);
		}
	}

	public Gate Gate
	{
		get
		{
			//IL_0055: Unknown result type (might be due to invalid IL or missing references)
			//IL_005a: Expected Obj, but got Unknown
			//IL_007a: Invalid comparison between F4 and I
			//IL_00ae: Expected I4, but got VT
			bool flag = !(_value > _minimumValue);
			Gate result = Gate.Empty;
			if (!flag)
			{
				bool flag2 = !(_value < _maximumValue);
				result = Gate.Full;
				if (!flag2)
				{
					int num = 0;
					while (true)
					{
						float[] gateValues = _gateValues;
						if (num >= gateValues.Length)
						{
							break;
						}
						int num2 = num << 2;
						object obj = gateValues + num2;
						int num3 = num + 1;
						float value = _value;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ S0_v20+10]");
						bool flag3 = value < 0f;
						bool flag4 = !flag3;
						num = num3;
						if (!flag4)
						{
							return (Gate)EnumUtility.ConvertIndexToEnumValue<T>(num3);
						}
					}
					result = Gate.High;
				}
			}
			return result;
		}
	}

	public event EventHandler<ValueChangedEventArgs> OnValueChanged
	{
		add
		{
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected Obj, but got Unknown
			object obj = this + 24;
			Delegate obj2 = this.m_OnValueChanged;
			Delegate obj4 = default;
			bool flag2;
			do
			{
				Delegate obj3 = Delegate.Combine(obj2, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23D");
				bool flag = obj2 == obj;
				if (!flag)
				{
					obj4 = (Delegate)obj;
				}
				obj = obj4;
				Delegate obj5 = obj2;
				if (!flag)
				{
					obj5 = (Delegate)obj;
				}
				flag2 = (object)obj2 != obj5;
				obj2 = obj5;
			}
			while (flag2);
		}
		remove
		{
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected Obj, but got Unknown
			object obj = this + 24;
			Delegate obj2 = this.m_OnValueChanged;
			Delegate obj4 = default;
			bool flag2;
			do
			{
				Delegate obj3 = Delegate.Remove(obj2, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23D");
				bool flag = obj2 == obj;
				if (!flag)
				{
					obj4 = (Delegate)obj;
				}
				obj = obj4;
				Delegate obj5 = obj2;
				if (!flag)
				{
					obj5 = (Delegate)obj;
				}
				flag2 = (object)obj2 != obj5;
				obj2 = obj5;
			}
			while (flag2);
		}
	}

	public GatedValue(float minimumValue, float maximumValue, float defaultValue, float[] gateValues)
	{
		_value = defaultValue;
		_maximumValue = maximumValue;
		_minimumValue = minimumValue;
		GateValues = gateValues;
	}

	private void RaiseOnValueChanged(ValueChangedEventArgs valueChangedEventArgs)
	{
		EventHandler<ValueChangedEventArgs> onValueChanged = this.m_OnValueChanged;
		if (this.m_OnValueChanged != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v2 @ S0_v2 (System.EventHandler`1<SYBO.Common.Events.ValueChangedEventArgs>)+C] (should have been resolved before IL gen)");
		}
	}
}
