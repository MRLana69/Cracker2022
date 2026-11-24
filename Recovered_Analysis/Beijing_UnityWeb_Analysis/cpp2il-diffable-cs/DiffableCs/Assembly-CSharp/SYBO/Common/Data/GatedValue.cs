namespace SYBO.Common.Data;

public class GatedValue
{
	private EventHandler<ValueChangedEventArgs> OnValueChanged; //Field offset: 0x8
	private float _minimumValue; //Field offset: 0xC
	private float _maximumValue; //Field offset: 0x10
	private float _value; //Field offset: 0x14
	private float[] _gateValues; //Field offset: 0x18

	public event EventHandler<ValueChangedEventArgs> OnValueChanged
	{
		 add { } //Length: 107
		 remove { } //Length: 111
	}

	public Gate Gate
	{
		 get { } //Length: 6
	}

	public float[] GateValues
	{
		 get { } //Length: 62
		 set { } //Length: 111
	}

	public float MaximumValue
	{
		 get { } //Length: 6
	}

	public float MinimumValue
	{
		 get { } //Length: 6
	}

	public float Value
	{
		 get { } //Length: 6
		 set { } //Length: 8
	}

	public GatedValue(float minimumValue, float maximumValue, float defaultValue, float[] gateValues) { }

	public void add_OnValueChanged(EventHandler<ValueChangedEventArgs> value) { }

	public Gate get_Gate() { }

	public float[] get_GateValues() { }

	public float get_MaximumValue() { }

	public float get_MinimumValue() { }

	public float get_Value() { }

	private void RaiseOnValueChanged(ValueChangedEventArgs valueChangedEventArgs) { }

	public void remove_OnValueChanged(EventHandler<ValueChangedEventArgs> value) { }

	public void set_GateValues(float[] value) { }

	public void set_Value(float value) { }

}

