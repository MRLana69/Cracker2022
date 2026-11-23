using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2ILInjected;
using SYBO.Subway.Characters;
using UnityEngine;

public class SuperSneakers : CharacterModifier
{
	public delegate void OnSwitchToSuperSneakersDelegate();

	public delegate void SuperSneakerOnStopDelegate();

	private sealed class _003CBegin_003Ed__28(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public SuperSneakers _003C_003E4__this;

		object IEnumerator<object>.Current => _003C_003E2__current;

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			SuperSneakers superSneakers = _003C_003E4__this;
			if (_003C_003E1__state != 0)
			{
				if (_003C_003E1__state != 1)
				{
					goto IL_032f;
				}
				_003C_003E1__state = -1;
			}
			else
			{
				_003C_003E1__state = -1;
				Character character = superSneakers.character;
				character._isJumpingHigher = true;
				((CharacterModifier)superSneakers)._paused = false;
				if (~(character._isStumbling ? 1u : 0u) == 0)
				{
					character.StopStumble();
				}
				CharacterRendering characterRendering = superSneakers.characterRendering;
				CharacterModel characterModel = characterRendering._characterModel;
				characterModel._meshSuperSneaker.enabled = true;
				superSneakers.isActive = true;
				superSneakers.longMagnet.Activate();
				OnSwitchToSuperSneakersDelegate onSwitchToSuperSneakers = superSneakers.m_OnSwitchToSuperSneakers;
				if (superSneakers.m_OnSwitchToSuperSneakers != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v115.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
				}
				superSneakers.stop = StopSignal.DONT_STOP;
			}
			ActivePowerup powerup = superSneakers._powerup;
			if (!(powerup.timeLeft > 0f) || superSneakers.stop != StopSignal.DONT_STOP)
			{
				superSneakers.timeActiveInARow = 0f;
				CharacterRendering characterRendering2 = superSneakers.characterRendering;
				CharacterModel characterModel2 = characterRendering2._characterModel;
				characterModel2._meshSuperSneaker.enabled = false;
				superSneakers.isActive = false;
				if (!superSneakers.longMagnet.ShouldBeActive)
				{
					superSneakers.longMagnet.Deactivate();
				}
				ActivePowerup powerup2 = superSneakers._powerup;
				if (!(powerup2.timeLeft > 0f))
				{
					Sound sound = So.Instance.playSound(superSneakers.powerDownSound);
				}
				Character character2 = superSneakers.character;
				character2._isJumpingHigher = false;
				SuperSneakerOnStopDelegate superSneakerOnStop = superSneakers.m_SuperSneakerOnStop;
				if (superSneakers.m_SuperSneakerOnStop != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v183.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
				}
				goto IL_032f;
			}
			if (!((CharacterModifier)superSneakers)._paused)
			{
				float deltaTime = Time.deltaTime;
				float timeActiveInARow = superSneakers.timeActiveInARow + deltaTime;
				superSneakers.timeActiveInARow = timeActiveInARow;
				Action onSupersneakersTimeActiveChange = OnSupersneakersTimeActiveChange;
				if (OnSupersneakersTimeActiveChange != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v155.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
				}
			}
			_003C_003E2__current = null;
			_003C_003E1__state = 1;
			return true;
			IL_032f:
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

	public bool isActive;

	private Character character;

	private CharacterRendering characterRendering;

	public AudioClipInfo powerDownSound;

	private LongMagnet longMagnet;

	public float timeActiveInARow;

	public static Action OnSupersneakersTimeActiveChange;

	private static SuperSneakers instance;

	private OnSwitchToSuperSneakersDelegate m_OnSwitchToSuperSneakers;

	private SuperSneakerOnStopDelegate m_SuperSneakerOnStop;

	public override bool ShouldPauseInAlternateRoutes => true;

	public override bool ShouldPauseInJetpack => true;

	public static SuperSneakers Instance
	{
		get
		{
			//IL_0014: Expected VT, but got Obj
			bool flag = (object)instance == null;
			bool flag2 = !flag;
			SuperSneakers result = instance;
			if (!flag2)
			{
				Type typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)typeof(SuperSneakers));
				UnityEngine.Object obj = UnityEngine.Object.FindObjectOfType(typeFromHandle);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @238");
				SuperSneakers superSneakers = default;
				instance = superSneakers;
				result = superSneakers;
			}
			return result;
		}
	}

	public event OnSwitchToSuperSneakersDelegate OnSwitchToSuperSneakers
	{
		add
		{
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected Obj, but got Unknown
			object obj = this + 52;
			Delegate obj2 = this.m_OnSwitchToSuperSneakers;
			Delegate obj4 = default;
			bool flag2;
			do
			{
				Delegate obj3 = Delegate.Combine(obj2, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
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
			object obj = this + 52;
			Delegate obj2 = this.m_OnSwitchToSuperSneakers;
			Delegate obj4 = default;
			bool flag2;
			do
			{
				Delegate obj3 = Delegate.Remove(obj2, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
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

	public event SuperSneakerOnStopDelegate SuperSneakerOnStop
	{
		add
		{
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected Obj, but got Unknown
			object obj = this + 56;
			Delegate obj2 = this.m_SuperSneakerOnStop;
			Delegate obj4 = default;
			bool flag2;
			do
			{
				Delegate obj3 = Delegate.Combine(obj2, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
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
			object obj = this + 56;
			Delegate obj2 = this.m_SuperSneakerOnStop;
			Delegate obj4 = default;
			bool flag2;
			do
			{
				Delegate obj3 = Delegate.Remove(obj2, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
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

	public void Awake()
	{
		instance = this;
		GameObject gameObject = base.gameObject;
		LongMagnet component = gameObject.GetComponent<LongMagnet>();
		longMagnet = component;
		Character character = Character.Instance;
		this.character = character;
		CharacterRendering characterRendering = CharacterRendering.Instance;
		this.characterRendering = characterRendering;
	}

	public override void Pause()
	{
		base._paused = true;
		ActivePowerup powerup = _powerup;
		if (_powerup != null)
		{
			powerup.Paused = true;
		}
		Character character = this.character;
		character._isJumpingHigher = false;
		isActive = false;
	}

	public override void Resume()
	{
		base._paused = false;
		ActivePowerup powerup = _powerup;
		if (_powerup != null)
		{
			powerup.Paused = false;
		}
		Character character = this.character;
		character._isJumpingHigher = true;
		isActive = true;
	}

	public override void ExpireSoon()
	{
		ActivePowerup powerup = _powerup;
		powerup.timeLeft = CharacterModifierCollection.TIME_LEFT_FOR_EXPIRE_SOON;
	}

	public void StopHack()
	{
		isActive = false;
		CharacterRendering characterRendering = this.characterRendering;
		CharacterModel characterModel = characterRendering._characterModel;
		characterModel._meshSuperSneaker.enabled = false;
	}

	public override void Prepare()
	{
		GameStats gameStats = GameStats.Instance;
		gameStats.PickedUpPowerupsIncrement();
		GameStats gameStats2 = GameStats.Instance;
		ActivePowerup powerup = gameStats2.TriggerPowerup(PowerupType.supersneakers);
		_powerup = powerup;
	}

	public override IEnumerator Begin()
	{
		_ = 0;
		IEnumerator result = default;
		return result;
	}
}
