using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

public class DoubleCoins : CharacterModifier
{
	private sealed class _003CBegin_003Ed__8(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public DoubleCoins _003C_003E4__this;

		private float _003Cduration_003E5__2;

		object IEnumerator<object>.Current => _003C_003E2__current;

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			DoubleCoins doubleCoins = _003C_003E4__this;
			if (_003C_003E1__state != 0)
			{
				if (_003C_003E1__state != 1)
				{
					goto IL_016a;
				}
				_003C_003E1__state = -1;
			}
			else
			{
				_003C_003E1__state = -1;
				numberOfAnimationBlinks = 0;
				GameStats instance = GameStats.Instance;
				instance.PickedUpPowerupsIncrement();
				doubleCoins.stop = StopSignal.DONT_STOP;
				((CharacterModifier)doubleCoins)._paused = false;
				GameStats instance2 = GameStats.Instance;
				ActivePowerup powerup = instance2.TriggerPowerup(PowerupType.doubleCoinsMysteryPowerup, ((CharacterModifier)doubleCoins).TriggeredByMysteryPowerup__BackingField);
				doubleCoins._powerup = powerup;
				ActivePowerup powerup2 = doubleCoins._powerup;
				_003Cduration_003E5__2 = powerup2.timeLeft;
				doubleCoins.StartDoubleCoins();
			}
			ActivePowerup powerup3 = doubleCoins._powerup;
			if (powerup3.timeLeft < 0f || doubleCoins.stop != StopSignal.DONT_STOP)
			{
				doubleCoins.StopDoubleCoins();
				ActivePowerup powerup4 = doubleCoins._powerup;
				if (!(powerup4.timeLeft > 0f))
				{
					Sound sound = So.Instance.playSound(doubleCoins.powerDownSound);
				}
				goto IL_016a;
			}
			float ratio = powerup3.timeLeft / _003Cduration_003E5__2;
			doubleCoins.ratio = ratio;
			_003C_003E2__current = null;
			_003C_003E1__state = 1;
			return true;
			IL_016a:
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

	public static bool HasDoubleCoinsModifier;

	public static int numberOfAnimationBlinks;

	private static DoubleCoins instance;

	public static DoubleCoins Instance
	{
		get
		{
			//IL_0014: Expected VT, but got Obj
			bool flag = (object)instance == null;
			bool flag2 = !flag;
			DoubleCoins result = instance;
			if (!flag2)
			{
				Type typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)typeof(DoubleCoins));
				UnityEngine.Object obj = UnityEngine.Object.FindObjectOfType(typeFromHandle);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @238");
				DoubleCoins doubleCoins = default;
				instance = doubleCoins;
				result = doubleCoins;
			}
			return result;
		}
	}

	public void Awake()
	{
		instance = this;
	}

	public override IEnumerator Begin()
	{
		_ = 0;
		IEnumerator result = default;
		return result;
	}

	public override void ExpireSoon()
	{
		ActivePowerup powerup = _powerup;
		powerup.timeLeft = CharacterModifierCollection.TIME_LEFT_FOR_EXPIRE_SOON;
	}

	public override void Reset()
	{
		//IL_0010: Expected I, but got Obj
		base.TriggeredByMysteryPowerup__BackingField = false;
		nint num = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v5 @ S1_v3 (Il2CppClass<DoubleCoins>)+104] (should have been resolved before IL gen)");
		StopDoubleCoins();
	}

	public void StartDoubleCoins()
	{
		UIScreenController uIScreenController = UIScreenController.Instance;
		Upgrade upgrade = Upgrades.upgrades.get_Item(PowerupType.doubleCoinsMysteryPowerup);
		string message = Strings.Get(upgrade.name);
		uIScreenController.messageHelper.ShowMessage(message, bigText: true);
		HasDoubleCoinsModifier = true;
	}

	public void StopDoubleCoins()
	{
		HasDoubleCoinsModifier = false;
		numberOfAnimationBlinks = 0;
	}
}
