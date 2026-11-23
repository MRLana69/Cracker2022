using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2ILInjected;

public class DoubleScoreMultiplier : CharacterModifier
{
	private sealed class _003CBegin_003Ed__2(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public DoubleScoreMultiplier _003C_003E4__this;

		private float _003Cduration_003E5__2;

		object IEnumerator<object>.Current => _003C_003E2__current;

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			DoubleScoreMultiplier doubleScoreMultiplier = _003C_003E4__this;
			if (_003C_003E1__state != 0)
			{
				if (_003C_003E1__state != 1)
				{
					goto IL_0208;
				}
				_003C_003E1__state = -1;
			}
			else
			{
				_003C_003E1__state = -1;
				GameStats instance = GameStats.Instance;
				instance.PickedUpPowerupsIncrement();
				doubleScoreMultiplier.stop = StopSignal.DONT_STOP;
				((CharacterModifier)doubleScoreMultiplier)._paused = false;
				GameStats instance2 = GameStats.Instance;
				ActivePowerup powerup = instance2.TriggerPowerup(PowerupType.doubleMultiplier);
				doubleScoreMultiplier._powerup = powerup;
				ActivePowerup powerup2 = doubleScoreMultiplier._powerup;
				_003Cduration_003E5__2 = powerup2.timeLeft;
				PlayerInfo instance3 = PlayerInfo.Instance;
				if (!instance3._doubleScore)
				{
					instance3._doubleScore = true;
					Action onScoreMultiplierChanged = instance3.onScoreMultiplierChanged;
					if (instance3.onScoreMultiplierChanged != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v156.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
					}
				}
			}
			ActivePowerup powerup3 = doubleScoreMultiplier._powerup;
			if (!(powerup3.timeLeft > 0f) || doubleScoreMultiplier.stop != StopSignal.DONT_STOP)
			{
				PlayerInfo instance4 = PlayerInfo.Instance;
				if (~(instance4._doubleScore ? 1u : 0u) == 0)
				{
					instance4._doubleScore = false;
					Action onScoreMultiplierChanged2 = instance4.onScoreMultiplierChanged;
					if (instance4.onScoreMultiplierChanged != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v127.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
					}
				}
				ActivePowerup powerup4 = doubleScoreMultiplier._powerup;
				if (!(powerup4.timeLeft > 0f))
				{
					Sound sound = So.Instance.playSound(doubleScoreMultiplier.powerDownSound);
				}
				goto IL_0208;
			}
			float ratio = powerup3.timeLeft / _003Cduration_003E5__2;
			doubleScoreMultiplier.ratio = ratio;
			_003C_003E2__current = null;
			_003C_003E1__state = 1;
			return true;
			IL_0208:
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

	public float ratio;

	public AudioClipInfo powerDownSound;

	public override IEnumerator Begin()
	{
		_ = 0;
		IEnumerator result = default;
		return result;
	}

	public override void Reset()
	{
		//IL_0061: Expected I, but got Obj
		base.TriggeredByMysteryPowerup__BackingField = false;
		nint num = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v15 @ S1_v4 (Il2CppClass<DoubleScoreMultiplier>)+104] (should have been resolved before IL gen)");
		PlayerInfo instance = PlayerInfo.Instance;
		if (~(instance._doubleScore ? 1u : 0u) == 0)
		{
			instance._doubleScore = false;
			Action onScoreMultiplierChanged = instance.onScoreMultiplierChanged;
			if (instance.onScoreMultiplierChanged != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v31.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
			}
		}
	}
}
