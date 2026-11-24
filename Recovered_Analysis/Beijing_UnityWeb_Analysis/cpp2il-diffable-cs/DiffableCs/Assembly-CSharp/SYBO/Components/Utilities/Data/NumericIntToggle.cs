namespace SYBO.Components.Utilities.Data;

public class NumericIntToggle : NumericToggle, IChangeable
{
	private int _value; //Field offset: 0x18
	private int _valueOriginal; //Field offset: 0x1C

	public int Value
	{
		 get { } //Length: 12
		 set { } //Length: 99
	}

	public NumericIntToggle() { }

	public NumericIntToggle(int value, bool isEnabled = true, string inspectorMessage = "(Default)") { }

	public int get_Value() { }

	private void Initialize(int value, bool isEnabled, string message) { }

	protected override bool IsOriginalValue() { }

	public void Reset() { }

	public void set_Value(int value) { }

	public void SoftReset() { }

}

