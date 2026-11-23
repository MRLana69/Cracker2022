using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

public abstract class CharacterModifier : MonoBehaviour
{
	public enum StopSignal
	{
		DONT_STOP,
		STOP,
		STOP_NO_ENDING
	}

	private sealed class _003CBegin_003Ed__28(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		object IEnumerator<object>.Current => _003C_003E2__current;

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			if (_003C_003E1__state == 0)
			{
				_003C_003E1__state = -1;
			}
			return false;
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

	protected StopSignal stop;

	private bool _paused;

	public ActivePowerup _powerup;

	private IEnumerator current;

	private bool TriggeredByMysteryPowerup__BackingField;

	public bool Paused
	{
		get
		{
			return _paused;
		}
		protected set
		{
			_paused = value;
		}
	}

	public ActivePowerup Powerup
	{
		get
		{
			return _powerup;
		}
		protected set
		{
			_powerup = value;
		}
	}

	public bool TriggeredByMysteryPowerup
	{
		get
		{
			return TriggeredByMysteryPowerup__BackingField;
		}
		set
		{
			TriggeredByMysteryPowerup__BackingField = value;
		}
	}

	public StopSignal Stop
	{
		get
		{
			return stop;
		}
		set
		{
			stop = value;
		}
	}

	public virtual bool ShouldPauseInJetpack => false;

	public virtual bool ShouldPauseInAlternateRoutes => false;

	public bool IsAllowedInAlternateRoutes
	{
		get
		{
			//IL_0005: Expected I, but got Obj
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0010: Expected Obj, but got Unknown
			//IL_0023: Unknown result type (might be due to invalid IL or missing references)
			//IL_0028: Expected I4, but got Unknown
			nint num = (nint)this;
			object obj = this + 40;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v3 @ S1_v2 (Il2CppClass<CharacterModifier>)+E4] (should have been resolved before IL gen)");
			object obj2 = default;
			return (byte)(obj2 ^ 1) != 0;
		}
	}

	public IEnumerator Current
	{
		get
		{
			return current;
		}
		set
		{
			current = value;
		}
	}

	public virtual void Prepare()
	{
	}

	public virtual IEnumerator Begin()
	{
		_ = 0;
		IEnumerator result = default;
		return result;
	}

	public virtual void Pause()
	{
		_paused = true;
		ActivePowerup powerup = _powerup;
		if (_powerup != null)
		{
			powerup.Paused = true;
		}
	}

	public virtual void Resume()
	{
		_paused = false;
		ActivePowerup powerup = _powerup;
		if (_powerup != null)
		{
			powerup.Paused = false;
		}
	}

	public virtual void Reset()
	{
		//IL_0010: Expected I, but got Obj
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected Obj, but got Unknown
		TriggeredByMysteryPowerup__BackingField = false;
		nint num = (nint)this;
		object obj = this + 72;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v5 @ S1_v3 (Il2CppClass<CharacterModifier>)+104] (should have been resolved before IL gen)");
	}

	public virtual void ExpireSoon()
	{
	}
}
