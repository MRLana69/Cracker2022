using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2ILInjected;
using SYBO.Subway.Characters;
using UnityEngine;

public class DoubleJump : CharacterModifier
{
	private sealed class _003CBegin_003Ed__12(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public DoubleJump _003C_003E4__this;

		private float _003Cduration_003E5__2;

		object IEnumerator<object>.Current => _003C_003E2__current;

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			DoubleJump doubleJump = _003C_003E4__this;
			if (_003C_003E1__state != 0)
			{
				if (_003C_003E1__state != 1)
				{
					goto IL_0160;
				}
				_003C_003E1__state = -1;
			}
			else
			{
				_003C_003E1__state = -1;
				GameStats instance = GameStats.Instance;
				instance.PickedUpPowerupsIncrement();
				((CharacterModifier)doubleJump)._paused = false;
				GameStats instance2 = GameStats.Instance;
				ActivePowerup powerup = instance2.TriggerPowerup(PowerupType.doubleJump, ((CharacterModifier)doubleJump).TriggeredByMysteryPowerup__BackingField);
				doubleJump._powerup = powerup;
				ActivePowerup powerup2 = doubleJump._powerup;
				_003Cduration_003E5__2 = powerup2.timeLeft;
				doubleJump.StartDoubleJump();
				doubleJump.stop = StopSignal.DONT_STOP;
			}
			ActivePowerup powerup3 = doubleJump._powerup;
			if (powerup3.timeLeft < 0f || doubleJump.stop != StopSignal.DONT_STOP)
			{
				doubleJump.StopDoubleJump();
				ActivePowerup powerup4 = doubleJump._powerup;
				if (!(powerup4.timeLeft > 0f))
				{
					Sound sound = So.Instance.playSound(doubleJump.powerDownSound);
				}
				goto IL_0160;
			}
			float ratio = powerup3.timeLeft / _003Cduration_003E5__2;
			doubleJump.ratio = ratio;
			_003C_003E2__current = null;
			_003C_003E1__state = 1;
			return true;
			IL_0160:
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

	public static bool doubleJumpEnabled;

	private static DoubleJump instance;

	private Character character;

	public override bool ShouldPauseInAlternateRoutes => true;

	public override bool ShouldPauseInJetpack => true;

	public static DoubleJump Instance
	{
		get
		{
			//IL_0014: Expected VT, but got Obj
			bool flag = (object)instance == null;
			bool flag2 = !flag;
			DoubleJump result = instance;
			if (!flag2)
			{
				Type typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)typeof(DoubleJump));
				UnityEngine.Object obj = UnityEngine.Object.FindObjectOfType(typeFromHandle);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @238");
				DoubleJump doubleJump = default;
				instance = doubleJump;
				result = doubleJump;
			}
			return result;
		}
	}

	private void Awake()
	{
		instance = this;
		Character character = Character.Instance;
		this.character = character;
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
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v5 @ S1_v3 (Il2CppClass<DoubleJump>)+104] (should have been resolved before IL gen)");
		StopDoubleJump();
	}

	public override void Pause()
	{
		base._paused = true;
		ActivePowerup powerup = _powerup;
		if (_powerup != null)
		{
			powerup.Paused = true;
		}
		doubleJumpEnabled = false;
		Character character = this.character;
		character._isDoubleJumping = false;
		CharacterModel characterModel = character._characterModel;
		if (characterModel._doubleJumpers != null)
		{
			Character character2 = this.character;
			CharacterModel characterModel2 = character2._characterModel;
			characterModel2._doubleJumpers.enabled = false;
		}
	}

	public override void Resume()
	{
		base._paused = false;
		ActivePowerup powerup = _powerup;
		if (_powerup != null)
		{
			powerup.Paused = false;
		}
		doubleJumpEnabled = true;
		Character character = this.character;
		character._isDoubleJumping = true;
		CharacterModel characterModel = character._characterModel;
		if (characterModel._doubleJumpers != null)
		{
			Character character2 = this.character;
			CharacterModel characterModel2 = character2._characterModel;
			characterModel2._doubleJumpers.enabled = true;
		}
	}

	public void StartDoubleJump()
	{
		UIScreenController uIScreenController = UIScreenController.Instance;
		Upgrade upgrade = Upgrades.upgrades.get_Item(PowerupType.doubleJump);
		string message = Strings.Get(upgrade.name);
		uIScreenController.messageHelper.ShowMessage(message, bigText: true);
		doubleJumpEnabled = true;
		Character character = this.character;
		character._isDoubleJumping = true;
		CharacterModel characterModel = character._characterModel;
		if (characterModel._doubleJumpers != null)
		{
			Character character2 = this.character;
			CharacterModel characterModel2 = character2._characterModel;
			characterModel2._doubleJumpers.enabled = true;
		}
	}

	public void StopDoubleJump()
	{
		base._paused = false;
		doubleJumpEnabled = false;
		Character character = this.character;
		character._isDoubleJumping = false;
		CharacterModel characterModel = character._characterModel;
		if (characterModel._doubleJumpers != null)
		{
			Character character2 = this.character;
			CharacterModel characterModel2 = character2._characterModel;
			characterModel2._doubleJumpers.enabled = false;
		}
	}
}
