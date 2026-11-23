using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2ILInjected;
using UI.Screens;
using UnityEngine;

public class PlusMultiplier : CharacterModifier
{
	private sealed class _003CBegin_003Ed__7(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public PlusMultiplier _003C_003E4__this;

		private float _003Cduration_003E5__2;

		object IEnumerator<object>.Current => _003C_003E2__current;

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			PlusMultiplier plusMultiplier = _003C_003E4__this;
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
				plusMultiplier.stop = StopSignal.DONT_STOP;
				((CharacterModifier)plusMultiplier)._paused = false;
				GameStats instance2 = GameStats.Instance;
				ActivePowerup powerup = instance2.TriggerPowerup(PowerupType.plusMultiplier, ((CharacterModifier)plusMultiplier).TriggeredByMysteryPowerup__BackingField);
				plusMultiplier._powerup = powerup;
				ActivePowerup powerup2 = plusMultiplier._powerup;
				_003Cduration_003E5__2 = powerup2.timeLeft;
				plusMultiplier.StartPlusMultiplier();
			}
			ActivePowerup powerup3 = plusMultiplier._powerup;
			if (powerup3.timeLeft < 0f || plusMultiplier.stop != StopSignal.DONT_STOP)
			{
				plusMultiplier.StopPlusMultiplier();
				ActivePowerup powerup4 = plusMultiplier._powerup;
				if (!(powerup4.timeLeft > 0f))
				{
					Sound sound = So.Instance.playSound(plusMultiplier.powerDownSound);
				}
				goto IL_0160;
			}
			float ratio = powerup3.timeLeft / _003Cduration_003E5__2;
			plusMultiplier.ratio = ratio;
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

	public static bool plusMultiplierEnabled;

	private static PlusMultiplier instance;

	public static PlusMultiplier Instance
	{
		get
		{
			//IL_0014: Expected VT, but got Obj
			bool flag = (object)instance == null;
			bool flag2 = !flag;
			PlusMultiplier result = instance;
			if (!flag2)
			{
				Type typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)typeof(PlusMultiplier));
				UnityEngine.Object obj = UnityEngine.Object.FindObjectOfType(typeFromHandle);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @238");
				PlusMultiplier plusMultiplier = default;
				instance = plusMultiplier;
				result = plusMultiplier;
			}
			return result;
		}
	}

	private void Awake()
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
		//IL_0015: Expected I, but got Obj
		base.TriggeredByMysteryPowerup__BackingField = false;
		nint num = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v15 @ S1_v4 (Il2CppClass<PlusMultiplier>)+104] (should have been resolved before IL gen)");
		plusMultiplierEnabled = false;
	}

	public void StartPlusMultiplier()
	{
		UIScreenController uIScreenController = UIScreenController.Instance;
		Upgrade upgrade = Upgrades.upgrades.get_Item(PowerupType.plusMultiplier);
		string message = Strings.Get(upgrade.name);
		uIScreenController.messageHelper.ShowMessage(message, bigText: true);
		plusMultiplierEnabled = true;
		((PlusMultiplier)(object)uIScreenController.messageHelper).ChangeTheMultiplier();
	}

	public void StopPlusMultiplier()
	{
		plusMultiplierEnabled = false;
		((PlusMultiplier)null).ResetLabelColour();
		((PlusMultiplier)null).ChangeTheMultiplier();
	}

	private void ResetLabelColour()
	{
		UIScreenController uIScreenController = UIScreenController.Instance;
		string topScreenName = uIScreenController.GetTopScreenName();
		UIScreen screenFromCache = uIScreenController.GetScreenFromCache(topScreenName);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @238");
		UnityEngine.Object obj = default;
		if (obj != null)
		{
			((IngameScreen)obj).ResetMultiplierLabelColour();
		}
	}

	private void ChangeTheMultiplier()
	{
		PlayerInfo playerInfo = PlayerInfo.Instance;
		Action onScoreMultiplierChanged = playerInfo.onScoreMultiplierChanged;
		if (playerInfo.onScoreMultiplierChanged != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v14.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
		}
	}
}
