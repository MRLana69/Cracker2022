using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2ILInjected;
using Kiloo.Common.Utility;
using UnityEngine;

namespace SYBO.Common.Data;

public class ScoreMultiplier
{
	public class ValueChangedEventArgs : EventArgs
	{
		private float _newValue;

		private float _oldValue;

		public float NewValue => _newValue;

		public float OldValue => _oldValue;

		public ValueChangedEventArgs(float newValue, float oldValue)
		{
			_oldValue = oldValue;
			_newValue = newValue;
		}
	}

	private sealed class _003CCoolDownCoroutine_003Ed__29(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public ScoreMultiplier _003C_003E4__this;

		object IEnumerator<object>.Current => _003C_003E2__current;

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			ScoreMultiplier scoreMultiplier = _003C_003E4__this;
			if (_003C_003E1__state != 0)
			{
				if (_003C_003E1__state != 1)
				{
					goto IL_00e8;
				}
				_003C_003E1__state = -1;
				if (scoreMultiplier._multiplierArray != null)
				{
					int multiplierArrayIndex = scoreMultiplier._multiplierArrayIndex - 1;
					scoreMultiplier.MultiplierArrayIndex = multiplierArrayIndex;
				}
			}
			else
			{
				_003C_003E1__state = -1;
			}
			float num = scoreMultiplier._coolDownDurationMS / 1000f;
			object obj = default;
			_003C_003E2__current = obj;
			_003C_003E1__state = 1;
			goto IL_00e8;
			IL_00e8:
			return true;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			NotSupportedException ex = default;
			ex._002Ector();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
		}
	}

	private float[] _multiplierArray;

	private int _multiplierArrayIndex;

	private float _coolDownDurationMS;

	private float _minimumPositiveScoreDeltaToIncreaseMultiplier;

	private int _originalMultiplierArrayIndex;

	private float _scoreDeltaSinceLastIncreaseToMultiplier;

	private IEnumerator _coolDownCoroutine;

	private EventHandler<ValueChangedEventArgs> m_OnValueChanged;

	public float[] MultiplierArray => _multiplierArray;

	public unsafe int MultiplierArrayIndex
	{
		get
		{
			return _multiplierArrayIndex;
		}
		private set
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c9: Expected Obj, but got Unknown
			//IL_0140: Unknown result type (might be due to invalid IL or missing references)
			//IL_0145: Expected Obj, but got Unknown
			//IL_015a: Expected F4, but got I
			//IL_015a: Expected Ref, but got F4
			//IL_0047: Unknown result type (might be due to invalid IL or missing references)
			//IL_004c: Expected Obj, but got Unknown
			//IL_006d: Expected F4, but got I
			//IL_006d: Expected F4, but got I
			object obj2 = default;
			object obj = obj2 - 16;
			int num = _multiplierArrayIndex << 2;
			object obj3 = _multiplierArray + num;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S1_v5+10]");
			_ = 0;
			float[] multiplierArray = _multiplierArray;
			int num2 = multiplierArray.Length - 1;
			if (value <= num2)
			{
				num2 = value;
			}
			bool flag = value < 0;
			int multiplierArrayIndex = 0;
			if (!flag)
			{
				multiplierArrayIndex = num2;
			}
			_multiplierArrayIndex = multiplierArrayIndex;
			float num3 = (float)obj + 12f;
			int num4 = _multiplierArrayIndex << 2;
			object obj4 = _multiplierArray + num4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ S1_v12+10]");
			if (!((float*)num3)->Equals(0f))
			{
				int num5 = _multiplierArrayIndex << 2;
				object obj5 = _multiplierArray + num5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ S0_v18+10]");
				nint num6 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
				ValueChangedEventArgs e = default;
				e._002Ector(num6, 0f);
				EventHandler<ValueChangedEventArgs> onValueChanged = this.m_OnValueChanged;
				if (this.m_OnValueChanged != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v101 @ S0_v26 (System.EventHandler`1<SYBO.Common.Data.ScoreMultiplier+ValueChangedEventArgs>)+C] (should have been resolved before IL gen)");
				}
			}
		}
	}

	public float CoolDownDurationMS
	{
		get
		{
			return _coolDownDurationMS;
		}
		set
		{
			if (!(value < 0f))
			{
				_coolDownDurationMS = value;
			}
		}
	}

	public float Value
	{
		get
		{
			//IL_001a: Unknown result type (might be due to invalid IL or missing references)
			//IL_001f: Expected Obj, but got Unknown
			//IL_002c: Expected F4, but got I
			int num = _multiplierArrayIndex << 2;
			object obj = _multiplierArray + num;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v7 @ S0_v3+10]");
			return 0f;
		}
	}

	public float MinimumPositiveScoreDeltaToIncreaseMultiplier
	{
		get
		{
			return _minimumPositiveScoreDeltaToIncreaseMultiplier;
		}
		set
		{
			if (!(value < 0f))
			{
				_minimumPositiveScoreDeltaToIncreaseMultiplier = value;
			}
		}
	}

	public event EventHandler<ValueChangedEventArgs> OnValueChanged
	{
		add
		{
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected Obj, but got Unknown
			object obj = this + 36;
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
			object obj = this + 36;
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

	public ScoreMultiplier(int multiplierArrayIndex, float[] multiplierArray, float minimumPositiveScoreDeltaToIncreaseMultiplier = 1f)
	{
		_minimumPositiveScoreDeltaToIncreaseMultiplier = 1f;
		_multiplierArray = multiplierArray;
		_originalMultiplierArrayIndex = multiplierArrayIndex;
		_coolDownDurationMS = 3000f;
		_minimumPositiveScoreDeltaToIncreaseMultiplier = minimumPositiveScoreDeltaToIncreaseMultiplier;
		MultiplierArrayIndex = multiplierArrayIndex;
		IEnumerator coolDownCoroutine = CoolDownCoroutine();
		_coolDownCoroutine = coolDownCoroutine;
		Reset();
	}

	public void Reset()
	{
		MultiplierArrayIndex = _originalMultiplierArrayIndex;
		_scoreDeltaSinceLastIncreaseToMultiplier = 0f;
		RestartCoolDownCoroutine();
	}

	public float NotifyScoreWasChanged(Score score, float delta)
	{
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Expected Obj, but got Unknown
		//IL_00cb: Expected F4, but got I
		float num = (_scoreDeltaSinceLastIncreaseToMultiplier += delta);
		if (num > 0f && !(num < _minimumPositiveScoreDeltaToIncreaseMultiplier))
		{
			_scoreDeltaSinceLastIncreaseToMultiplier = 0f;
			int multiplierArrayIndex = _multiplierArrayIndex + 1;
			MultiplierArrayIndex = multiplierArrayIndex;
			RestartCoolDownCoroutine();
		}
		int num2 = _multiplierArrayIndex << 2;
		object obj = _multiplierArray + num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v8+10]");
		return 0f;
	}

	private void RestartCoolDownCoroutine()
	{
		StopCoolDownCoroutine();
		IEnumerator coolDownCoroutine = CoolDownCoroutine();
		_coolDownCoroutine = coolDownCoroutine;
		Coroutine coroutine = CoroutineUtil.StartCoroutine(_coolDownCoroutine);
	}

	private void StopCoolDownCoroutine()
	{
		CoroutineUtil.StopCoroutine(_coolDownCoroutine);
	}

	private IEnumerator CoolDownCoroutine()
	{
		_ = 0;
		IEnumerator result = default;
		return result;
	}

	private void RaiseOnValueChanged(ValueChangedEventArgs valueChangedEventArgs)
	{
		EventHandler<ValueChangedEventArgs> onValueChanged = this.m_OnValueChanged;
		if (this.m_OnValueChanged != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v2 @ S0_v2 (System.EventHandler`1<SYBO.Common.Data.ScoreMultiplier+ValueChangedEventArgs>)+C] (should have been resolved before IL gen)");
		}
	}
}
