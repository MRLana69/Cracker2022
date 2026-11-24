namespace SYBO.Components.Utilities.Data;

public class NumericFloatToggle : NumericToggle, IChangeable
{
	private float _value; //Field offset: 0x18
	private float _valueOriginal; //Field offset: 0x1C

	public float Value
	{
		 get { } //Length: 26
		 set { } //Length: 204
	}

	public NumericFloatToggle() { }

	public NumericFloatToggle(float value, bool isEnabled = true, string inspectorMessage = "(Default)") { }

	public float get_Value() { }

	private void Initialize(float value, bool isEnabled, string message) { }

	protected override bool IsOriginalValue() { }

	public void Reset() { }

	public void set_Value(float value) { }

	public void SoftReset() { }

}

