using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2ILInjected;
using SYBO.Common.Components.Singleton;
using SYBO.Common.Managers;
using SYBO.Subway;
using SYBO.Subway.Characters;
using SYBO.Subway.Routes.Builders;
using UnityEngine;

public class Hoverboard : CharacterModifier
{
	public enum BoardAbility
	{
		None,
		Jumper,
		Lowrider,
		HighSpeed,
		Speed,
		DoubleJump,
		Glider,
		Teleport,
		Vanity
	}

	public delegate void OnSwitchToHoverboardDelegate(HoverboardBundle hoverbooardBundle, BoardAbility[] abilities);

	public delegate void OnEndHoverboardDelegate();

	public delegate void OnHoverboardJumpDelegate();

	public delegate void OnRunDelegate();

	public delegate void RunDelegate();

	public delegate void OnSpeedStartDelegate();

	public delegate void OnSpeedEndDelegate();

	private sealed class _003CBegin_003Ed__94(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public Hoverboard _003C_003E4__this;

		private HoverboardBundle _003CnewBoard_003E5__2;

		private float _003CtimeLeft_003E5__3;

		private float _003CnewCoolDownDist_003E5__4;

		private float _003CdistanceLeft_003E5__5;

		private bool _003CdidStopCooldown_003E5__6;

		object IEnumerator<object>.Current => _003C_003E2__current;

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_05e3: Expected VT, but got Obj
			//IL_05f3: Expected Obj, but got I
			//IL_0604: Unknown result type (might be due to invalid IL or missing references)
			//IL_0609: Expected Obj, but got Unknown
			Hoverboard hoverboard = _003C_003E4__this;
			float num;
			float num2;
			if (_003C_003E1__state != 0)
			{
				if (_003C_003E1__state != 1)
				{
					if (_003C_003E1__state != 2)
					{
						if (_003C_003E1__state != 3)
						{
							goto IL_07db;
						}
						_003C_003E1__state = -1;
						num = _003CdistanceLeft_003E5__5;
						goto IL_0a40;
					}
					_003C_003E1__state = -1;
					num2 = _003CtimeLeft_003E5__3;
					goto IL_0a23;
				}
				_003C_003E1__state = -1;
			}
			else
			{
				_003C_003E1__state = -1;
				if (~(hoverboard.__isAllowed ? 1u : 0u) != 0 || hoverboard._isInCooldown)
				{
					goto IL_07db;
				}
				hoverboard.hoverboardRoot.SetActive(value: true);
				if (~(hoverboard._isARewardFromMysteryPowerup ? 1u : 0u) != 0)
				{
					PlayerInfo instance = PlayerInfo.Instance;
					instance.UseUpgrade(PowerupType.hoverboard);
					Character character = hoverboard.character;
					HoverboardBundle hoverboardBundle = character._characterModel.AddEquippedHoverboard();
					_003CnewBoard_003E5__2 = hoverboardBundle;
				}
				else
				{
					hoverboard.ResetBoardAndAbilitys();
					Character character2 = hoverboard.character;
					HoverboardBundle hoverboardBundle2 = character2._characterModel.AddRandomHoverboard();
					_003CnewBoard_003E5__2 = hoverboardBundle2;
					HoverboardBundle component = _003CnewBoard_003E5__2.GetComponent<HoverboardBundle>();
					hoverboard._currentRandomBoard = component.boardType;
					UIScreenController instance2 = UIScreenController.Instance;
					Hoverboards.Board board = Hoverboards.boardData.get_Item(hoverboard._currentRandomBoard);
					string text = Strings.Get(board.name);
					string text2 = Strings.Get(StringID.MYSTERY_POWERUP_RANDOM_HOVERBOARD_TEXT);
					string message = text + " " + text2;
					instance2.messageHelper.ShowMessage(message, bigText: true);
				}
				hoverboard.SetupAbilitiesAndVisuals(_003CnewBoard_003E5__2);
				MissionsManager instance3 = MissionsManager.Instance;
				instance3.PlayerDidThis(MissionTarget.HoverBoard);
				GameStats instance4 = GameStats.Instance;
				ActivePowerup powerup = instance4.TriggerPowerup(PowerupType.hoverboard, ((CharacterModifier)hoverboard).TriggeredByMysteryPowerup__BackingField);
				hoverboard._powerup = powerup;
				((CharacterModifier)hoverboard)._paused = false;
				Character character3 = hoverboard.character;
				if (~(character3._isStumbling ? 1u : 0u) == 0)
				{
					character3.StopStumble();
				}
				hoverboard.isActive = true;
				Sound sound = So.Instance.playSound(hoverboard.StartSound);
				Character character4 = hoverboard.character;
				character4.CharacterPickupParticleSystem.PickedUpDefaultPowerUp();
				Character character5 = hoverboard.character;
				character5.ImmuneToCriticalHit = true;
				hoverboard.stop = StopSignal.DONT_STOP;
			}
			ActivePowerup powerup2 = hoverboard._powerup;
			if (!(powerup2.timeLeft > 0f) || hoverboard.stop != StopSignal.DONT_STOP)
			{
				Character character6 = hoverboard.character;
				character6.ImmuneToCriticalHit = false;
				hoverboard.isActive = false;
				hoverboard.ResetBoardAndAbilitys();
				StopSignal stop = hoverboard.stop;
				if (hoverboard.stop == StopSignal.DONT_STOP)
				{
					MissionsManager instance5 = MissionsManager.Instance;
					instance5.PlayerDidThis(MissionTarget.HoverBoardExpire);
					Sound sound2 = So.Instance.playSound(hoverboard.powerDownSound);
					hoverboard._isInCooldown = true;
					OnEndHoverboardDelegate onEndHoverboard = hoverboard.m_OnEndHoverboard;
					if (hoverboard.m_OnEndHoverboard != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v344.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
					}
					Character character7 = hoverboard.character;
					if (~(character7._isFalling ? 1u : 0u) == 0 || ~(character7.__isJumping ? 1u : 0u) == 0)
					{
						OnHoverboardJumpDelegate onJump = hoverboard.m_OnJump;
						if (hoverboard.m_OnJump != null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v418.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
						}
					}
					else
					{
						RunDelegate run = hoverboard.m_Run;
						if (hoverboard.m_Run != null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v451.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
						}
					}
					UnityEngine.Object.Destroy(_003CnewBoard_003E5__2);
					stop = hoverboard.stop;
				}
				if (stop != StopSignal.STOP)
				{
					goto IL_07db;
				}
				hoverboard.isActive = false;
				Character character8 = hoverboard.character;
				character8.ImmuneToCriticalHit = false;
				hoverboard._isInCooldown = true;
				GameObject gameObject = character8.HoverboardCrashParticleSystem.gameObject;
				gameObject.SetActive(value: true);
				Character character9 = hoverboard.character;
				character9.HoverboardCrashParticleSystem.Play();
				hoverboard.PlayCrashSound();
				OnEndHoverboardDelegate onEndHoverboard2 = hoverboard.m_OnEndHoverboard;
				if (hoverboard.m_OnEndHoverboard != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v447.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
				}
				OnHoverboardJumpDelegate onJump2 = hoverboard.m_OnJump;
				if (hoverboard.m_OnJump != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v506.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
				}
				UnityEngine.Object.Destroy(_003CnewBoard_003E5__2);
				_003CtimeLeft_003E5__3 = hoverboard.WaitForParticlesDelay;
				num2 = hoverboard.WaitForParticlesDelay;
				goto IL_0a23;
			}
			_003C_003E2__current = null;
			_003C_003E1__state = 1;
			return true;
			IL_07db:
			return false;
			IL_0a40:
			if (!(num > 0f))
			{
				Character character10 = hoverboard.character;
				GameObject gameObject2 = character10.HoverboardCrashParticleSystem.gameObject;
				gameObject2.SetActive(value: false);
				UnityEngine.Object.Destroy(_003CnewBoard_003E5__2);
				goto IL_07db;
			}
			Game instance6 = Game.Instance;
			float deltaTime = Time.deltaTime;
			float num3 = instance6.__currentLevelSpeed * deltaTime;
			float num4 = num - num3;
			_003CdistanceLeft_003E5__5 = num4;
			Game instance7 = Game.Instance;
			float deltaTime2 = Time.deltaTime;
			float num5 = instance7.__currentLevelSpeed * deltaTime2;
			if ((_003CnewCoolDownDist_003E5__4 -= num5) < 0f && !_003CdidStopCooldown_003E5__6)
			{
				Character character11 = hoverboard.character;
				character11.ImmuneToCriticalHit = false;
				_003CdidStopCooldown_003E5__6 = true;
			}
			hoverboard._currentRandomBoard = Hoverboards.BoardType.normal;
			_003C_003E2__current = null;
			_003C_003E1__state = 3;
			return true;
			IL_0a23:
			if (!(num2 > 0f))
			{
				_00210 val = (_00210)SingletonMonobehavior<>.Instance;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v192 @ S0_v49 (T)+3C]");
				object obj = 0;
				object obj2 = obj;
				object obj3 = obj + 32;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v218 @ S1_v27+DC] (should have been resolved before IL gen)");
				Character character12 = hoverboard.character;
				Game instance8 = Game.Instance;
				Game.SpeedInfo speed = instance8.speed;
				float num6 = instance8.__currentSpeed / speed.min;
				float distance = hoverboard.RemoveObstaclesDistance * num6;
				RouteBuilder routeBuilder = default;
				routeBuilder.HideLogic(character12.z, distance);
				hoverboard.character.Revive();
				Character character13 = hoverboard.character;
				if (~(character13._isRolling ? 1u : 0u) == 0)
				{
					character13.EndRoll();
				}
				Game instance9 = Game.Instance;
				Game.SpeedInfo speed2 = instance9.speed;
				float num7 = instance9.__currentSpeed / speed2.min;
				float num8 = hoverboard.slowMotionDistance * num7;
				Game instance10 = Game.Instance;
				Game.SpeedInfo speed3 = instance10.speed;
				float num9 = instance10.__currentSpeed / speed3.min;
				float num10 = hoverboard.cooldownDstance * num9;
				_003CdidStopCooldown_003E5__6 = false;
				_003CdistanceLeft_003E5__5 = num8;
				_003CnewCoolDownDist_003E5__4 = num10;
				num = num8;
				goto IL_0a40;
			}
			float deltaTime3 = Time.deltaTime;
			float num11 = num2 - deltaTime3;
			_003C_003E2__current = null;
			_003CtimeLeft_003E5__3 = num11;
			_003C_003E1__state = 2;
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

	private bool isJumper;

	private bool isLowrider;

	private bool isHighSpeedBoard;

	private bool isSpeedBoard;

	private bool isGlider;

	private bool isVTol;

	private bool isTeleporter;

	private bool isDoubleJump;

	private bool isVanity;

	public GameObject currentHoverboard;

	public AudioClipInfo powerDownSound;

	public float cooldownDstance = 50f;

	public float slowMotionDistance;

	public float slowDownToScale = 0.3f;

	private GameObject hoverboardRoot;

	public float WaitForParticlesDelay;

	public float RemoveObstaclesDistance = 250f;

	private LongMagnet longMagnet;

	private Character character;

	public bool isActive;

	public bool _isInCooldown;

	private bool __isAllowed = true;

	private bool _isARewardFromMysteryPowerup;

	public AudioClipInfo CrashSound;

	public AudioClipInfo StartSound;

	private static Hoverboard instance;

	private Hoverboards.BoardType _currentRandomBoard;

	private OnSwitchToHoverboardDelegate m_OnSwitchToHoverboard;

	private OnEndHoverboardDelegate m_OnEndHoverboard;

	private OnHoverboardJumpDelegate m_OnJump;

	private OnRunDelegate m_OnRun;

	private RunDelegate m_Run;

	private OnSpeedStartDelegate m_OnSpeedStart;

	private OnSpeedEndDelegate m_OnSpeedEnd;

	public bool IsJumper => isJumper;

	public bool IsLowrider => isLowrider;

	public bool IsHighSpeedBoard => isHighSpeedBoard;

	public bool IsSpeedBoard => isSpeedBoard;

	public bool IsGlider => isGlider;

	public bool IsVTol => isVTol;

	public bool IsTeleporter => isTeleporter;

	public bool IsDoubleJump => isDoubleJump;

	public bool IsVanity => isVanity;

	public bool IsInCooldown => _isInCooldown;

	public bool IsAllowed
	{
		get
		{
			return __isAllowed;
		}
		set
		{
			__isAllowed = value;
		}
	}

	public bool IsARewardFromMysteryPowerup
	{
		get
		{
			return _isARewardFromMysteryPowerup;
		}
		set
		{
			_isARewardFromMysteryPowerup = value;
		}
	}

	public override bool ShouldPauseInJetpack => true;

	public override bool ShouldPauseInAlternateRoutes => true;

	public static Hoverboard Instance
	{
		get
		{
			//IL_0014: Expected VT, but got Obj
			bool flag = (object)instance == null;
			bool flag2 = !flag;
			Hoverboard result = instance;
			if (!flag2)
			{
				Type typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)typeof(Hoverboard));
				UnityEngine.Object obj = UnityEngine.Object.FindObjectOfType(typeFromHandle);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @238");
				Hoverboard hoverboard = default;
				instance = hoverboard;
				result = hoverboard;
			}
			return result;
		}
	}

	public event OnSwitchToHoverboardDelegate OnSwitchToHoverboard
	{
		add
		{
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected Obj, but got Unknown
			object obj = this + 96;
			Delegate obj2 = this.m_OnSwitchToHoverboard;
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
			object obj = this + 96;
			Delegate obj2 = this.m_OnSwitchToHoverboard;
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

	public event OnEndHoverboardDelegate OnEndHoverboard
	{
		add
		{
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected Obj, but got Unknown
			object obj = this + 100;
			Delegate obj2 = this.m_OnEndHoverboard;
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
			object obj = this + 100;
			Delegate obj2 = this.m_OnEndHoverboard;
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

	public event OnHoverboardJumpDelegate OnJump
	{
		add
		{
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected Obj, but got Unknown
			object obj = this + 104;
			Delegate obj2 = this.m_OnJump;
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
			object obj = this + 104;
			Delegate obj2 = this.m_OnJump;
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

	public event OnRunDelegate OnRun
	{
		add
		{
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected Obj, but got Unknown
			object obj = this + 108;
			Delegate obj2 = this.m_OnRun;
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
			object obj = this + 108;
			Delegate obj2 = this.m_OnRun;
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

	public event RunDelegate Run
	{
		add
		{
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected Obj, but got Unknown
			object obj = this + 112;
			Delegate obj2 = this.m_Run;
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
			object obj = this + 112;
			Delegate obj2 = this.m_Run;
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

	public event OnSpeedStartDelegate OnSpeedStart
	{
		add
		{
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected Obj, but got Unknown
			object obj = this + 116;
			Delegate obj2 = this.m_OnSpeedStart;
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
			object obj = this + 116;
			Delegate obj2 = this.m_OnSpeedStart;
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

	public event OnSpeedEndDelegate OnSpeedEnd
	{
		add
		{
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected Obj, but got Unknown
			object obj = this + 120;
			Delegate obj2 = this.m_OnSpeedEnd;
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
			object obj = this + 120;
			Delegate obj2 = this.m_OnSpeedEnd;
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
	}

	public unsafe void intialize()
	{
		Game game = Game.Instance;
		Action action = default;
		action._002Ector(this, (nint)__ldftn(Hoverboard.Game_OnCharacterModelRecreated));
		game.OnCharacterModelRecreated += action;
		Character character = Character.Instance;
		this.character = character;
		Character character2 = this.character;
		CharacterModel characterModel = character2._characterModel;
		GameObject gameObject = characterModel._attachPoint1.gameObject;
		hoverboardRoot = gameObject;
		GameObject gameObject2 = base.gameObject;
		LongMagnet component = gameObject2.GetComponent<LongMagnet>();
		longMagnet = component;
	}

	private void Game_OnCharacterModelRecreated()
	{
		Character character = this.character;
		CharacterModel characterModel = character._characterModel;
		GameObject gameObject = characterModel._attachPoint1.gameObject;
		hoverboardRoot = gameObject;
	}

	public override void Reset()
	{
		//IL_007c: Expected I, but got Obj
		//IL_0019: Expected VT, but got Obj
		//IL_0022: Expected VT, but got Obj
		//IL_003c: Expected F4, but got I
		//IL_003c: Expected Obj, but got VT
		base.TriggeredByMysteryPowerup__BackingField = false;
		nint num = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v15 @ S1_v4 (Il2CppClass<Hoverboard>)+104] (should have been resolved before IL gen)");
		Character character = this.character;
		character.ImmuneToCriticalHit = false;
		character._characterController.enabled = true;
		Character character2 = this.character;
		character2.CharacterTrigger.enabled = true;
		hoverboardRoot.SetActive(value: false);
		isActive = false;
		_00210 val = (_00210)SingletonMonobehavior<>.Instance;
		_00210 val2 = (_00210)SingletonMonobehavior<>.Instance;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S1_v13 (T)+10]");
		((TimeScaleManager)val).TimeScale = 0f;
		Character character3 = this.character;
		GameObject gameObject = character3.HoverboardCrashParticleSystem.gameObject;
		gameObject.SetActive(value: false);
	}

	public void SetupAbilitiesAndVisuals(HoverboardBundle hoverboardBundle)
	{
		//IL_0172: Expected Obj, but got I4
		//IL_0283: Unknown result type (might be due to invalid IL or missing references)
		//IL_0288: Expected Obj, but got Unknown
		//IL_0298: Expected Obj, but got I
		//IL_02c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c8: Expected Obj, but got Unknown
		//IL_02d8: Expected Obj, but got I
		//IL_02ef: Expected Obj, but got I
		//IL_030e: Expected Obj, but got I
		//IL_018e: Expected Obj, but got I4
		//IL_0a30: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a35: Expected Obj, but got Unknown
		//IL_0a45: Expected Obj, but got I
		//IL_04dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e2: Expected Obj, but got Unknown
		//IL_04f2: Expected Obj, but got I
		//IL_0564: Unknown result type (might be due to invalid IL or missing references)
		//IL_0569: Expected Obj, but got Unknown
		//IL_0579: Expected Obj, but got I
		//IL_03cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d1: Expected Obj, but got Unknown
		//IL_03e1: Expected Obj, but got I
		//IL_05ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0604: Expected Obj, but got Unknown
		//IL_0614: Expected Obj, but got I
		//IL_069a: Unknown result type (might be due to invalid IL or missing references)
		//IL_069f: Expected Obj, but got Unknown
		//IL_06af: Expected Obj, but got I
		//IL_0390: Expected Obj, but got I
		//IL_0399: Unknown result type (might be due to invalid IL or missing references)
		//IL_039e: Expected Obj, but got Unknown
		//IL_077a: Unknown result type (might be due to invalid IL or missing references)
		//IL_077f: Expected Obj, but got Unknown
		//IL_078f: Expected Obj, but got I
		//IL_07e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ed: Expected Obj, but got Unknown
		//IL_07fd: Expected Obj, but got I
		//IL_08e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_08e7: Expected Obj, but got Unknown
		//IL_08f7: Expected Obj, but got I
		List<BoardAbility> list = default;
		list._002Ector();
		nint num = 0;
		nint num2 = 0;
		IntPtr intPtr = num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v28 @ S3_v3 (Il2CppClass<Il2CppMethodRgctx<UnityEngine.Component::GetComponentsInChildren>>)+4] (should have been resolved before IL gen)");
		HoverboardBundle.CustomSet[] customSets = hoverboardBundle.customSets;
		if (customSets.Length != 0)
		{
			bool flag = customSets.Length < 2;
			bool flag2 = true;
			if (!flag)
			{
				HoverboardManager hoverboardManager = HoverboardManager.Instance;
				PlayerInfo playerInfo = PlayerInfo.Instance;
				bool flag3 = hoverboardManager.IsCustomSetEquippedForBoard(playerInfo._currentHoverboard, 0);
				bool flag4 = !flag3;
				flag2 = true;
				if (!flag4)
				{
					HoverboardBundle.CustomSet customSet = customSets[1];
					bool useDefaultmodel = customSet.useDefaultmodel;
					flag2 = useDefaultmodel;
				}
				if (customSets.Length >= 3)
				{
					HoverboardManager hoverboardManager2 = HoverboardManager.Instance;
					PlayerInfo playerInfo2 = PlayerInfo.Instance;
					if (hoverboardManager2.IsCustomSetEquippedForBoard(playerInfo2._currentHoverboard, 1))
					{
						HoverboardBundle.CustomSet customSet2 = customSets[2];
						bool useDefaultmodel2 = customSet2.useDefaultmodel;
						bool flag5 = flag2 & useDefaultmodel2;
						flag2 = flag5;
					}
				}
			}
			int num3 = default;
			int num21 = default;
			object obj11 = default;
			HoverboardManager hoverboardManager5 = default;
			HoverboardManager hoverboardManager6 = default;
			HoverboardManager hoverboardManager7 = default;
			for (; num3 < customSets.Length; num3 = num21 + 1)
			{
				bool flag6 = num3 == 0;
				object obj = flag2 & flag6;
				if (obj == null)
				{
					object obj2 = num3 - 1;
					if (num3 != 1)
					{
						if ((nint)obj2 != 1)
						{
							continue;
						}
						HoverboardManager hoverboardManager3 = HoverboardManager.Instance;
						PlayerInfo playerInfo3 = PlayerInfo.Instance;
						if (!hoverboardManager3.IsCustomSetEquippedForBoard(playerInfo3._currentHoverboard, 1))
						{
							continue;
						}
					}
					else
					{
						HoverboardManager hoverboardManager4 = HoverboardManager.Instance;
						PlayerInfo playerInfo4 = PlayerInfo.Instance;
						if (!hoverboardManager4.IsCustomSetEquippedForBoard(playerInfo4._currentHoverboard, 0))
						{
							continue;
						}
					}
				}
				int num4 = num3 << 2;
				object obj3 = customSets + num4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ S1_v20+10]");
				object obj4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v164 @ S1_v21+8]");
				list.Add(BoardAbility.None);
				int num5 = num3 << 2;
				object obj5 = customSets + num5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v177 @ S0_v36+10]");
				object obj6 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ S0_v37+C]");
				bool flag7 = (UnityEngine.Object)0 != null;
				bool flag8 = !flag7;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ S0_v37+C]");
				UnityEngine.Object obj7 = (UnityEngine.Object)0;
				if (!flag8)
				{
					hoverboardBundle.AddCustomBaseModel(num3, isMenu: false);
					obj7 = null;
					while (true)
					{
						UnityEngine.Object obj8 = obj7;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S0_v9+C]");
						if ((nint)obj8 >= 0)
						{
							break;
						}
						object obj9 = (object)obj7 << 2;
						object obj10 = obj11 + obj9;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v317 @ S0_v166+10]");
						((Renderer)0).enabled = false;
						UnityEngine.Object obj12 = (UnityEngine.Object)(obj7 + 1);
						obj7 = obj12;
					}
				}
				hoverboardBundle.AddCustomSetModelAndEffect(num3, isMenu: false, addEffect: true);
				int num6 = num3 << 2;
				object obj13 = customSets + num6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v304 @ S0_v47+10]");
				object obj14 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v305 @ S0_v48+8]");
				if ((nint)0 == 1)
				{
					isJumper = true;
					int num7 = num3 << 2;
					object obj15 = customSets + num7;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v326 @ S0_v139+10]");
					object obj16 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v327 @ S0_v140+1D]");
					if ((nint)0 != 0)
					{
						Character character = this.character;
						CharacterModel characterModel = character._characterModel;
						characterModel._meshSuperSneaker.enabled = true;
					}
					longMagnet.Activate();
					GameObject gameObject = hoverboardBundle.gameObject;
					nint num8 = 0;
					nint num9 = 0;
					IntPtr intPtr2 = num9;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v393 @ S3_v25 (Il2CppClass<Il2CppMethodRgctx<UnityEngine.GameObject::GetComponentInChildren>>)+4] (should have been resolved before IL gen)");
					if ((UnityEngine.Object)(object)hoverboardManager5 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v394 @ S0_v147 (HoverboardManager)+20]");
						if ((nint)0 == 0)
						{
							((playThruster)(object)hoverboardManager5).Initialize();
						}
					}
					continue;
				}
				int num10 = num3 << 2;
				object obj17 = customSets + num10;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v333 @ S0_v52+10]");
				object obj18 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v334 @ S0_v53+8]");
				if ((nint)0 == 2)
				{
					isLowrider = true;
					Character character2 = this.character;
					character2._squeezeCollider.Add(this);
					continue;
				}
				int num11 = num3 << 2;
				object obj19 = customSets + num11;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v360 @ S0_v57+10]");
				object obj20 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v361 @ S0_v58+8]");
				if ((nint)0 == 3)
				{
					HoverboardManager onSpeedStart = (HoverboardManager)(object)this.m_OnSpeedStart;
					if (this.m_OnSpeedStart != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v370._displayCustomSets (System.Boolean[]) (should have been resolved before IL gen)");
					}
					isHighSpeedBoard = true;
					Game game = Game.Instance;
					game.ActivateHighSpeed(Game.SpeedBoostType.High);
					continue;
				}
				int num12 = num3 << 2;
				object obj21 = customSets + num12;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v375 @ S0_v62+10]");
				object obj22 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v376 @ S0_v63+8]");
				if ((nint)0 == 4)
				{
					HoverboardManager onSpeedStart2 = (HoverboardManager)(object)this.m_OnSpeedStart;
					if (this.m_OnSpeedStart != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v412._displayCustomSets (System.Boolean[]) (should have been resolved before IL gen)");
					}
					isSpeedBoard = true;
					Game game2 = Game.Instance;
					game2.ActivateHighSpeed(Game.SpeedBoostType.Normal);
					continue;
				}
				int num13 = num3 << 2;
				object obj23 = customSets + num13;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v417 @ S0_v67+10]");
				object obj24 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v418 @ S0_v68+8]");
				if ((nint)0 == 6)
				{
					isGlider = true;
					longMagnet.Activate();
					GameObject gameObject2 = hoverboardBundle.gameObject;
					nint num14 = 0;
					nint num15 = 0;
					IntPtr intPtr3 = num15;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v474 @ S3_v21 (Il2CppClass<Il2CppMethodRgctx<UnityEngine.GameObject::GetComponentInChildren>>)+4] (should have been resolved before IL gen)");
					if ((UnityEngine.Object)(object)hoverboardManager6 != null)
					{
						((GliderAnimation)(object)hoverboardManager6).AddEvents();
					}
					continue;
				}
				int num16 = num3 << 2;
				object obj25 = customSets + num16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v447 @ S0_v72+10]");
				object obj26 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v448 @ S0_v73+8]");
				if ((nint)0 == 7)
				{
					isTeleporter = true;
					continue;
				}
				int num17 = num3 << 2;
				object obj27 = customSets + num17;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v460 @ S0_v77+10]");
				object obj28 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v461 @ S0_v78+8]");
				if ((nint)0 == 5)
				{
					isDoubleJump = true;
					GameObject gameObject3 = hoverboardBundle.gameObject;
					nint num18 = 0;
					nint num19 = 0;
					IntPtr intPtr4 = num19;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v499 @ S3_v17 (Il2CppClass<Il2CppMethodRgctx<UnityEngine.GameObject::GetComponentInChildren>>)+4] (should have been resolved before IL gen)");
					if ((UnityEngine.Object)(object)hoverboardManager7 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v500 @ S0_v90 (HoverboardManager)+20]");
						if ((nint)0 == 1)
						{
							((playThruster)(object)hoverboardManager7).Initialize();
						}
					}
				}
				else
				{
					int num20 = num3 << 2;
					object obj29 = customSets + num20;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v486 @ S0_v82+10]");
					object obj30 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v487 @ S0_v83+8]");
					if ((nint)0 == 8)
					{
						isVanity = true;
					}
				}
			}
		}
		OnSwitchToHoverboardDelegate onSwitchToHoverboard = this.m_OnSwitchToHoverboard;
		if (this.m_OnSwitchToHoverboard != null)
		{
			BoardAbility[] array = list.ToArray();
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v70.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
		}
	}

	public void ResetBoardAndAbilitys()
	{
		//IL_00cb: Expected I, but got Obj
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Expected Obj, but got Unknown
		Character character = this.character;
		character._characterModel.RemoveCurrentHoverboard();
		ActivePowerup powerup = _powerup;
		if (powerup.timeLeft > 0f)
		{
			powerup.timeLeft = 0f;
		}
		if (~(isJumper ? 1u : 0u) == 0)
		{
			if (!longMagnet.ShouldBeActive)
			{
				longMagnet.Deactivate();
			}
			SuperSneakers superSneakers = SuperSneakers.Instance;
			if (~(superSneakers.isActive ? 1u : 0u) != 0)
			{
				Character character2 = this.character;
				CharacterModel characterModel = character2._characterModel;
				characterModel._meshSuperSneaker.enabled = false;
			}
			else
			{
				SuperSneakers superSneakers2 = SuperSneakers.Instance;
				nint num = (nint)superSneakers2;
				object obj = superSneakers2 + 72;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v155 @ S1_v34 (Il2CppClass<SuperSneakers>)+104] (should have been resolved before IL gen)");
			}
			isJumper = false;
		}
		if (~(isLowrider ? 1u : 0u) == 0)
		{
			Character character3 = this.character;
			character3._squeezeCollider.Remove(this);
			isLowrider = false;
		}
		if (~(isHighSpeedBoard ? 1u : 0u) == 0)
		{
			OnSpeedEndDelegate onSpeedEnd = this.m_OnSpeedEnd;
			if (this.m_OnSpeedEnd != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v73.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
			}
			Game game = Game.Instance;
			game.DeactivateHighSpeed();
			isHighSpeedBoard = false;
		}
		if (~(isSpeedBoard ? 1u : 0u) == 0)
		{
			OnSpeedEndDelegate onSpeedEnd2 = this.m_OnSpeedEnd;
			if (this.m_OnSpeedEnd != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v103.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
			}
			Game game2 = Game.Instance;
			game2.DeactivateHighSpeed();
			isSpeedBoard = false;
		}
		if (~(isGlider ? 1u : 0u) == 0)
		{
			isGlider = false;
			if (!longMagnet.ShouldBeActive)
			{
				longMagnet.Deactivate();
			}
		}
		if (~(isTeleporter ? 1u : 0u) == 0)
		{
			isTeleporter = false;
		}
		if (~(isDoubleJump ? 1u : 0u) == 0)
		{
			isDoubleJump = false;
		}
	}

	public override IEnumerator Begin()
	{
		_ = 0;
		IEnumerator result = default;
		return result;
	}

	public void PlayCrashSound()
	{
		Sound sound = So.Instance.playSound(CrashSound);
	}

	public override void Pause()
	{
		base._paused = true;
		ActivePowerup powerup = _powerup;
		if (_powerup != null)
		{
			powerup.Paused = true;
		}
		ResetBoardAndAbilitys();
		PlayerInfo playerInfo = PlayerInfo.Instance;
		PlayerInfo playerInfo2 = PlayerInfo.Instance;
		if (playerInfo._currentHoverboard == Hoverboards.BoardType.speedboard || playerInfo2._currentHoverboard == Hoverboards.BoardType.hotrod)
		{
			Game game = Game.Instance;
			game.DeactivateHighSpeed();
		}
	}

	public override void Resume()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		object obj2 = default;
		Enum obj = (Enum)(obj2 - 16);
		base._paused = false;
		ActivePowerup powerup = _powerup;
		if (_powerup != null)
		{
			powerup.Paused = false;
		}
		ActivePowerup powerup2 = _powerup;
		if (powerup2.timeLeft > 0f)
		{
			Character character = this.character;
			if (~(_isARewardFromMysteryPowerup ? 1u : 0u) != 0)
			{
				HoverboardBundle hoverboardBundle = character._characterModel.AddEquippedHoverboard();
				SetupAbilitiesAndVisuals(hoverboardBundle);
				return;
			}
			_ = -1;
			obj = (Enum)(object)typeof(Hoverboards.BoardType);
			_ = _currentRandomBoard;
			string text = obj.ToString();
			HoverboardBundle hoverboardBundle2 = character._characterModel.AddHoverboard(text, isMenu: false);
			SetupAbilitiesAndVisuals(hoverboardBundle2);
		}
	}

	private void FinishRandomBoard()
	{
		_currentRandomBoard = Hoverboards.BoardType.normal;
	}

	public override void ExpireSoon()
	{
		ActivePowerup powerup = _powerup;
		powerup.timeLeft = CharacterModifierCollection.TIME_LEFT_FOR_EXPIRE_SOON;
	}

	public void HardReset()
	{
		isActive = false;
		PlayerInfo playerInfo = PlayerInfo.Instance;
		_isARewardFromMysteryPowerup = false;
		__isAllowed = playerInfo._isTutorialCompleted;
		_currentRandomBoard = Hoverboards.BoardType.normal;
	}

	private void RaiseOnEndHoverboard()
	{
		OnEndHoverboardDelegate onEndHoverboard = this.m_OnEndHoverboard;
		if (this.m_OnEndHoverboard != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v2.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
		}
	}
}
