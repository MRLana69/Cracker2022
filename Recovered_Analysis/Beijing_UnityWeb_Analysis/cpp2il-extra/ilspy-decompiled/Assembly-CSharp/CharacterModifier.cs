using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2ILInjected;
using Info;
using UnityEngine;

public abstract class CharacterModifier : MonoBehaviour
{
	public enum StopSignal
	{
		DONT_STOP,
		STOP,
		STOP_NO_ENDING
	}

	private sealed class _003CBegin_003Ed__16(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		object IEnumerator<object>.Current
		{
			get
			{
				if (_003C_003E1__state == 0)
				{
					_003C_003E1__state = -1;
				}
				return null;
			}
		}

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			NullReferenceException ex = default;
			ex._002Ector();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}

		private bool MoveNext()
		{
			//IL_0007: Expected I4, but got Obj
			return (byte)(int)_003C_003E2__current != 0;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
		}
	}

	protected StopSignal stop;

	private bool _paused;

	public ActivePowerup _powerup;

	private bool TriggeredByMysteryPowerup__BackingField;

	private IEnumerator current;

	public bool Paused
	{
		get
		{
			return TriggeredByMysteryPowerup__BackingField;
		}
		protected set
		{
			//IL_0030: Expected Obj, but got I
			//IL_006c: Expected Obj, but got I4
			//IL_0080: Unknown result type (might be due to invalid IL or missing references)
			//IL_0085: Expected Obj, but got Unknown
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (CharacterModifier)+28]");
			Delegate obj = (Delegate)0;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.RemoveImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				object obj3 = this + 40;
				if (obj3 == obj)
				{
					obj3 = obj4;
				}
				if (obj3 != obj)
				{
					obj = (Delegate)obj3;
					continue;
				}
				break;
			}
		}
	}

	public ActivePowerup Powerup
	{
		get
		{
			//IL_0019: Expected Obj, but got I4
			bool paused = _paused;
			return (ActivePowerup)paused;
		}
		protected set
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected I4, but got Unknown
			bool paused = (byte)(value & 1) != 0;
			_paused = paused;
		}
	}

	public bool TriggeredByMysteryPowerup
	{
		get
		{
			//IL_0007: Expected I4, but got Obj
			return (byte)(int)_powerup != 0;
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected Obj, but got Unknown
			//IL_0013: Expected Obj, but got I4
			object obj = this + 20;
			obj = value;
		}
	}

	public StopSignal Stop
	{
		get
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			_ = 0;
			StopSignal result = default;
			return result;
		}
		set
		{
			bool flag = (byte)(value & StopSignal.STOP) != 0;
			TriggeredByMysteryPowerup__BackingField = flag;
		}
	}

	public virtual bool ShouldPauseInJetpack => (byte)stop != 0;

	public virtual bool ShouldPauseInAlternateRoutes => false;

	public bool IsAllowedInAlternateRoutes => false;

	public IEnumerator Current
	{
		get
		{
			//IL_0013: Unknown result type (might be due to invalid IL or missing references)
			//IL_0018: Expected Obj, but got Unknown
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
			object obj = default;
			return (IEnumerator)(obj ^ 1);
		}
		set
		{
			//IL_000a: Expected I4, but got Obj
			stop = (StopSignal)value;
		}
	}

	public virtual void Prepare()
	{
		CancelInvoke();
	}

	public virtual IEnumerator Begin()
	{
		//IL_0019: Expected Obj, but got I4
		bool flag = TriggeredByMysteryPowerup__BackingField;
		return (IEnumerator)flag;
	}

	public virtual void Pause()
	{
	}

	public virtual void Resume()
	{
		_paused = true;
		if (_powerup != null)
		{
			ActivePowerup powerup = _powerup;
			powerup.Paused = true;
		}
	}

	public virtual void Reset()
	{
		_paused = false;
		if (_powerup != null)
		{
			ActivePowerup powerup = _powerup;
			powerup.Paused = false;
		}
	}

	public virtual void ExpireSoon()
	{
		TriggeredByMysteryPowerup__BackingField = false;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7266");
	}
}
