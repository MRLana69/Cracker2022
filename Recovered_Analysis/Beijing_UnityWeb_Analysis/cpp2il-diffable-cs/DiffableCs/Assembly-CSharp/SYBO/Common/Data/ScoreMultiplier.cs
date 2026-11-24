namespace SYBO.Common.Data;

public class ScoreMultiplier
{
	private sealed class <CoolDownCoroutine>d__29 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public ScoreMultiplier <>4__this; //Field offset: 0x10

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 164
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <CoolDownCoroutine>d__29(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	public class ValueChangedEventArgs : EventArgs
	{
		private float _newValue; //Field offset: 0x8
		private float _oldValue; //Field offset: 0xC

		public float NewValue
		{
			 get { } //Length: 6
		}

		public float OldValue
		{
			 get { } //Length: 6
		}

		public ValueChangedEventArgs(float newValue, float oldValue) { }

		public float get_NewValue() { }

		public float get_OldValue() { }

	}

	private EventHandler<ValueChangedEventArgs> OnValueChanged; //Field offset: 0x8
	private float[] _multiplierArray; //Field offset: 0xC
	private int _multiplierArrayIndex; //Field offset: 0x10
	private float _coolDownDurationMS; //Field offset: 0x14
	private float _minimumPositiveScoreDeltaToIncreaseMultiplier; //Field offset: 0x18
	private int _originalMultiplierArrayIndex; //Field offset: 0x1C
	private float _scoreDeltaSinceLastIncreaseToMultiplier; //Field offset: 0x20
	private IEnumerator _coolDownCoroutine; //Field offset: 0x24

	public event EventHandler<ValueChangedEventArgs> OnValueChanged
	{
		 add { } //Length: 64
		 remove { } //Length: 111
	}

	public float CoolDownDurationMS
	{
		 get { } //Length: 6
		 set { } //Length: 116
	}

	public float MinimumPositiveScoreDeltaToIncreaseMultiplier
	{
		 get { } //Length: 21
		 set { } //Length: 19
	}

	public float[] MultiplierArray
	{
		 get { } //Length: 6
	}

	public int MultiplierArrayIndex
	{
		 get { } //Length: 6
		private set { } //Length: 111
	}

	public float Value
	{
		 get { } //Length: 6
	}

	public ScoreMultiplier(int multiplierArrayIndex, float[] multiplierArray, float minimumPositiveScoreDeltaToIncreaseMultiplier = 1) { }

	public void add_OnValueChanged(EventHandler<ValueChangedEventArgs> value) { }

	private IEnumerator CoolDownCoroutine() { }

	public float get_CoolDownDurationMS() { }

	public float get_MinimumPositiveScoreDeltaToIncreaseMultiplier() { }

	public float[] get_MultiplierArray() { }

	public int get_MultiplierArrayIndex() { }

	public float get_Value() { }

	public float NotifyScoreWasChanged(Score score, float delta) { }

	private void RaiseOnValueChanged(ValueChangedEventArgs valueChangedEventArgs) { }

	public void remove_OnValueChanged(EventHandler<ValueChangedEventArgs> value) { }

	public void Reset() { }

	private void RestartCoolDownCoroutine() { }

	public void set_CoolDownDurationMS(float value) { }

	public void set_MinimumPositiveScoreDeltaToIncreaseMultiplier(float value) { }

	private void set_MultiplierArrayIndex(int value) { }

	private void StopCoolDownCoroutine() { }

}

