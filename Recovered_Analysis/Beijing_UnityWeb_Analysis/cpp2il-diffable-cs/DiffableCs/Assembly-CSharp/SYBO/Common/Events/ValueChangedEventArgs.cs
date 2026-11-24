namespace SYBO.Common.Events;

public class ValueChangedEventArgs : EventArgs
{
	private float _newValue; //Field offset: 0x8
	private float _oldValue; //Field offset: 0xC
	private float _deltaValue; //Field offset: 0x10

	public float DeltaValue
	{
		 get { } //Length: 6
	}

	public float NewValue
	{
		 get { } //Length: 6
	}

	public float OldValue
	{
		 get { } //Length: 6
	}

	public ValueChangedEventArgs(float newValue, float oldValue, float deltaValue) { }

	public float get_DeltaValue() { }

	public float get_NewValue() { }

	public float get_OldValue() { }

}

