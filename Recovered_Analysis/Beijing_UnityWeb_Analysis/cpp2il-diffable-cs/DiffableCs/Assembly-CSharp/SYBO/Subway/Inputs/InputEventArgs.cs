namespace SYBO.Subway.Inputs;

public class InputEventArgs : EventArgs
{
	private InputType _inputType; //Field offset: 0x8
	private float _timeStamp; //Field offset: 0xC
	private KeyCode _keyCode; //Field offset: 0x10

	public InputType InputType
	{
		 get { } //Length: 9
	}

	public KeyCode KeyCode
	{
		 get { } //Length: 6
	}

	public float TimeStamp
	{
		 get { } //Length: 9
	}

	public InputEventArgs(InputType inputType) { }

	public InputEventArgs(InputType inputType, KeyCode keyCode) { }

	public InputType get_InputType() { }

	public KeyCode get_KeyCode() { }

	public float get_TimeStamp() { }

	public override string ToString() { }

}

