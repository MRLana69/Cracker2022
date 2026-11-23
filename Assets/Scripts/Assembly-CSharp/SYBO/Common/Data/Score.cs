using System;
using Cpp2ILInjected;

namespace SYBO.Common.Data;

public class Score
{
	public class ValueChangedEventArgs : EventArgs
	{
		private float _newValue;

		private float _oldValue;

		private float _deltaValue;

		public float NewValue => _newValue;

		public float OldValue => _oldValue;

		public float DeltaValue => _deltaValue;

		public ValueChangedEventArgs(float newValue, float oldValue, float deltaValue)
		{
			_deltaValue = deltaValue;
			_oldValue = oldValue;
			_newValue = newValue;
		}
	}

	private float _value;

	private float _originalValue;

	private ScoreMultiplier _scoreMultiplier;

	private EventHandler<ValueChangedEventArgs> m_OnValueChanged;

	public float Value
	{
		get
		{
			return _value;
		}
		private set
		{
			_value = value;
			float deltaValue = value - value;
			ValueChangedEventArgs e = default;
			e._002Ector(_value, value, deltaValue);
			EventHandler<ValueChangedEventArgs> onValueChanged = this.m_OnValueChanged;
			if (this.m_OnValueChanged != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v28 @ S0_v12 (System.EventHandler`1<SYBO.Common.Data.Score+ValueChangedEventArgs>)+C] (should have been resolved before IL gen)");
			}
		}
	}

	public ScoreMultiplier ScoreMultiplier => _scoreMultiplier;

	public event EventHandler<ValueChangedEventArgs> OnValueChanged
	{
		add
		{
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected Obj, but got Unknown
			object obj = this + 20;
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
			object obj = this + 20;
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

	public Score(float originalValue)
	{
		_originalValue = originalValue;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		float[] array = default;
		array[0] = 1f;
		ScoreMultiplier scoreMultiplier = default;
		scoreMultiplier._002Ector(0, array);
		_scoreMultiplier = scoreMultiplier;
		Reset();
	}

	public Score(float originalValue, ScoreMultiplier scoreMultiplier)
	{
		_scoreMultiplier = scoreMultiplier;
		_originalValue = originalValue;
		Reset();
	}

	public void Reset()
	{
		_scoreMultiplier.Reset();
		float num = ValueChangeTo(_originalValue);
	}

	public float ValueChangeBy(float baseScoreDelta)
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Expected Obj, but got Unknown
		ScoreMultiplier scoreMultiplier = _scoreMultiplier;
		int num = scoreMultiplier._multiplierArrayIndex << 2;
		object obj = scoreMultiplier._multiplierArray + num;
		float num2 = _scoreMultiplier.NotifyScoreWasChanged(this, baseScoreDelta);
		float num3 = baseScoreDelta;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v9 @ S0_v4+10]");
		float num4 = num3 * 0f;
		float value = _value + num4;
		Value = value;
		return _value;
	}

	private float ValueChangeTo(float newBaseScore)
	{
		float delta = _value - newBaseScore;
		float num = _scoreMultiplier.NotifyScoreWasChanged(this, delta);
		Value = newBaseScore;
		return _value;
	}

	private void RaiseOnValueChanged(ValueChangedEventArgs valueChangedEventArgs)
	{
		EventHandler<ValueChangedEventArgs> onValueChanged = this.m_OnValueChanged;
		if (this.m_OnValueChanged != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v2 @ S0_v2 (System.EventHandler`1<SYBO.Common.Data.Score+ValueChangedEventArgs>)+C] (should have been resolved before IL gen)");
		}
	}
}
