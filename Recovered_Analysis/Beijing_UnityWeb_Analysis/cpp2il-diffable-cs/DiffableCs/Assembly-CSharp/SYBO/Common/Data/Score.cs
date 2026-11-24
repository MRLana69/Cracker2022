namespace SYBO.Common.Data;

public class Score
{
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
			 get { } //Length: 16
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

	private EventHandler<ValueChangedEventArgs> OnValueChanged; //Field offset: 0x8
	private float _value; //Field offset: 0xC
	private float _originalValue; //Field offset: 0x10
	private ScoreMultiplier _scoreMultiplier; //Field offset: 0x14

	public event EventHandler<ValueChangedEventArgs> OnValueChanged
	{
		 add { } //Length: 64
		 remove { } //Length: 111
	}

	public ScoreMultiplier ScoreMultiplier
	{
		 get { } //Length: 142
	}

	public float Value
	{
		 get { } //Length: 6
		private set { } //Length: 209
	}

	public Score(float originalValue) { }

	public Score(float originalValue, ScoreMultiplier scoreMultiplier) { }

	public void add_OnValueChanged(EventHandler<ValueChangedEventArgs> value) { }

	public ScoreMultiplier get_ScoreMultiplier() { }

	public float get_Value() { }

	private void RaiseOnValueChanged(ValueChangedEventArgs valueChangedEventArgs) { }

	public void remove_OnValueChanged(EventHandler<ValueChangedEventArgs> value) { }

	public void Reset() { }

	private void set_Value(float value) { }

	public float ValueChangeBy(float baseScoreDelta) { }

	private float ValueChangeTo(float newBaseScore) { }

}

