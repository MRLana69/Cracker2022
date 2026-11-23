using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2ILInjected;
using Kiloo;
using SYBO.Common;
using SYBO.Common.Components.Singleton;
using SYBO.Common.Managers;
using SYBO.Common.Utilities;
using SYBO.Subway.Cameras;
using SYBO.Subway.Characters;
using SYBO.Subway.Characters.States;
using SYBO.Subway.Coins;
using SYBO.Subway.Info;
using SYBO.Subway.Inputs;
using SYBO.Subway.Level;
using SYBO.Subway.Managers;
using SYBO.Subway.Pickups;
using UnityEngine;

namespace SYBO.Subway;

public class Game : MonoBehaviour
{
	public enum GameStateCoroutineType
	{
		None,
		Intro,
		GameIntro,
		TopMenu,
		DieSequence,
		SwitchToDieStateWhenGrounded
	}

	public enum SpeedBoostType
	{
		Normal,
		High
	}

	[Serializable]
	public class SwipeInfo
	{
		public float distanceMin = 0.1f;

		public float doubleTapDuration;
	}

	[Serializable]
	public class SpeedInfo
	{
		public float min = 110f;

		public float max;

		public float rampUpDuration = 200f;
	}

	private sealed class _003CSkipRevive_003Ed__228(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public Game _003C_003E4__this;

		object IEnumerator<object>.Current => _003C_003E2__current;

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			Game game = _003C_003E4__this;
			if (_003C_003E1__state != 0)
			{
				if (_003C_003E1__state == 1)
				{
					_003C_003E1__state = -1;
					game.ChangeState(null, GameStateCoroutineType.TopMenu);
					IEnumerator routine = DelayGameOverScreen();
					Coroutine coroutine = game.StartCoroutine(routine);
				}
				return false;
			}
			_003C_003E1__state = -1;
			game.ingameTouchDetection = false;
			_ = 0.1f;
			object obj = default;
			_003C_003E2__current = obj;
			_003C_003E1__state = 1;
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

	private sealed class _003CBackToCheckPointSequence_003Ed__232(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public Game _003C_003E4__this;

		object IEnumerator<object>.Current => _003C_003E2__current;

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			Game game = _003C_003E4__this;
			if (_003C_003E1__state != 0)
			{
				if (_003C_003E1__state != 1)
				{
					if (_003C_003E1__state != 2)
					{
						goto IL_0167;
					}
					_003C_003E1__state = -1;
				}
				else
				{
					_003C_003E1__state = -1;
					Variable<bool> isInGame = game.IsInGame;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v32 (Variable`1<System.Boolean>)+8]");
					if ((nint)0 != 0)
					{
						game._character.SetBackToCheckPoint(game.backToCheckpointZoomTime);
						_ = game.backToCheckpointZoomTime;
						object obj = default;
						_003C_003E2__current = obj;
						_003C_003E1__state = 2;
						return true;
					}
				}
				game.goingBackToCheckpoint = false;
				Character character = game._character;
				character._killSwitchEnabled = true;
				goto IL_0167;
			}
			_003C_003E1__state = -1;
			Character character2 = game._character;
			character2._killSwitchEnabled = false;
			game.goingBackToCheckpoint = true;
			game.CharacterState = null;
			_ = game.backToCheckpointDelayTime;
			object obj2 = default;
			_003C_003E2__current = obj2;
			_003C_003E1__state = 1;
			return true;
			IL_0167:
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

	private sealed class _003CEnableCharacterDayEventAnimation_003Ed__233(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
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
			if (_003C_003E1__state != 0)
			{
				if (_003C_003E1__state == 1)
				{
					_003C_003E1__state = -1;
					GameStats instance = GameStats.Instance;
					instance.CharacterDayEventActivated = true;
				}
				return false;
			}
			_003C_003E1__state = -1;
			object obj = default;
			_003C_003E2__current = obj;
			_003C_003E1__state = 1;
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

	private sealed class _003CDebugRepeatedlySwipeLeftRightCoroutine_003Ed__234(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public Game _003C_003E4__this;

		object IEnumerator<object>.Current => _003C_003E2__current;

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
			//IL_00bc: Expected Obj, but got Unknown
			//IL_0082: Unknown result type (might be due to invalid IL or missing references)
			//IL_0087: Expected Obj, but got Unknown
			Game game = _003C_003E4__this;
			int num;
			if (_003C_003E1__state != 0)
			{
				if (_003C_003E1__state == 1)
				{
					_003C_003E1__state = -1;
					CharacterState _characterState = game.__characterState;
					object obj = _characterState - -64;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v33 @ S3_v6+BC] (should have been resolved before IL gen)");
					_ = 0.05f;
					object obj2 = default;
					_003C_003E2__current = obj2;
					num = 2;
					goto IL_0130;
				}
				if (_003C_003E1__state != 2)
				{
					return false;
				}
				_003C_003E1__state = -1;
				CharacterState _characterState2 = game.__characterState;
				object obj3 = _characterState2 - -64;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v68 @ S3_v10+BC] (should have been resolved before IL gen)");
			}
			else
			{
				_003C_003E1__state = -1;
			}
			_ = 0.05f;
			object obj4 = default;
			_003C_003E2__current = obj4;
			num = 1;
			goto IL_0130;
			IL_0130:
			_003C_003E1__state = num;
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

	private sealed class _003CStumbleDeathSequence_003Ed__237(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public Game _003C_003E4__this;

		object IEnumerator<object>.Current => _003C_003E2__current;

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_0163: Expected I, but got Obj
			Game game = _003C_003E4__this;
			if (_003C_003E1__state != 0)
			{
				if (_003C_003E1__state == 1)
				{
					_003C_003E1__state = -1;
					if (!game.IsInJetpackMode)
					{
						Variable<bool> isInGame = game.IsInGame;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ S0_v28 (Variable`1<System.Boolean>)+8]");
						if ((nint)0 != 0 && !game.IsInPogostickMode)
						{
							Character character = game._character;
							character.LastDeathCause = Character.DeathCause.RepeatedStumble;
							Action onEndStumbleDeathSequence = game.m_OnEndStumbleDeathSequence;
							if (game.m_OnEndStumbleDeathSequence != null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v91.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
							}
							if (game.__characterState != null)
							{
								CharacterState _characterState = game.__characterState;
								nint num = (nint)_characterState;
								Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v112 @ S1_v20 (Il2CppClass<SYBO.Subway.Characters.States.CharacterState>)+114] (should have been resolved before IL gen)");
							}
						}
					}
					game._isInStumbleDeathSequence = false;
				}
				return false;
			}
			_003C_003E1__state = -1;
			game._isInStumbleDeathSequence = true;
			SpeedInfo speed = game.speed;
			game.__currentSpeed = speed.min;
			_ = 0.2f;
			object obj = default;
			_003C_003E2__current = obj;
			_003C_003E1__state = 1;
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

	private sealed class _003CSwitchToDieStateWhenGrounded_003Ed__239(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public Game _003C_003E4__this;

		private int _003CframeCount_003E5__2;

		object IEnumerator<object>.Current => _003C_003E2__current;

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_00ba: Expected Obj, but got I
			//IL_00c3: Invalid comparison between Obj and F4
			//IL_00e3: Expected VT, but got Obj
			object obj2 = default;
			object obj = obj2 - 16;
			Game game = _003C_003E4__this;
			if (_003C_003E1__state != 0)
			{
				if (_003C_003E1__state != 1)
				{
					goto IL_016e;
				}
			}
			else
			{
				_003CframeCount_003E5__2 = 0;
			}
			_003C_003E1__state = -1;
			Character character = game._character;
			if (character._characterController.isGrounded)
			{
				goto IL_015a;
			}
			Transform transform = game._character.transform;
			Vector3 position = transform.position;
			game._character.MoveWithGravity();
			Transform transform2 = game._character.transform;
			Vector3 position2 = transform2.position;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4]");
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4]");
			object obj3 = num - 0;
			if (obj3 == (object)0f)
			{
				_00210 val = (_00210)SingletonMonobehavior<>.Instance;
				float timeScale = Time.timeScale;
				if (timeScale != 0f)
				{
					if (++_003CframeCount_003E5__2 >= 4)
					{
						goto IL_015a;
					}
					goto IL_01d5;
				}
			}
			_003CframeCount_003E5__2 = 0;
			goto IL_01d5;
			IL_01d5:
			_003C_003E2__current = null;
			_003C_003E1__state = 1;
			goto IL_016e;
			IL_015a:
			game.ChangeState(null, GameStateCoroutineType.DieSequence);
			goto IL_016e;
			IL_016e:
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

	private sealed class _003CDieSequence_003Ed__240(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public Game _003C_003E4__this;

		private float _003Cwait_003E5__2;

		private float _003CskipTime_003E5__3;

		object IEnumerator<object>.Current => _003C_003E2__current;

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_0339: Unknown result type (might be due to invalid IL or missing references)
			//IL_033e: Expected Obj, but got Unknown
			//IL_0089: Expected VT, but got Obj
			//IL_0092: Expected VT, but got Obj
			//IL_00ac: Expected F4, but got I
			//IL_00ac: Expected Obj, but got VT
			//IL_0142: Expected I4, but got F4
			//IL_0210: Unknown result type (might be due to invalid IL or missing references)
			//IL_0215: Expected Obj, but got Unknown
			object obj2 = default;
			object obj = obj2 - 144;
			object obj3 = obj + 72;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @237");
			Game game = _003C_003E4__this;
			if (_003C_003E1__state != 0)
			{
				if (_003C_003E1__state != 1)
				{
					if (_003C_003E1__state != 2)
					{
						if (_003C_003E1__state != 3)
						{
							goto IL_0371;
						}
						_003C_003E1__state = -1;
						goto IL_0473;
					}
					_003C_003E1__state = -1;
					goto IL_03f7;
				}
				_003C_003E1__state = -1;
			}
			else
			{
				_003C_003E1__state = -1;
				_00210 val = (_00210)SingletonMonobehavior<>.Instance;
				_00210 val2 = (_00210)SingletonMonobehavior<>.Instance;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S1_v44 (T)+C]");
				((TimeScaleManager)val).TimeScale = 0f;
				if (Game.m_OnGameReviveOffer != null)
				{
					Action onGameReviveOffer = Game.m_OnGameReviveOffer;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v206.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
				}
				float time = Time.time;
				float num = time + game._waitTimeBeforeScreen;
				_003Cwait_003E5__2 = num;
				float time2 = Time.time;
				float num2 = time2 + 0.5f;
				_003CskipTime_003E5__3 = num2;
			}
			float time3 = Time.time;
			bool result = default;
			if (time3 < _003CskipTime_003E5__3)
			{
				_003C_003E2__current = null;
				_003C_003E1__state = 1;
				result = true;
				goto IL_0371;
			}
			goto IL_03f7;
			IL_0371:
			return result;
			IL_0473:
			float time4 = Time.time;
			if (time4 < _003Cwait_003E5__2 && !Input.GetMouseButtonUp(0))
			{
				int touchCount = Input.touchCount;
				if (touchCount < 1)
				{
					goto IL_0269;
				}
				Touch[] touches = Input.touches;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A54A");
				object obj4 = obj + 72;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22A");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+6C]");
				if ((nint)0 != 3)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+6C]");
					if ((nint)0 != 4)
					{
						goto IL_0269;
					}
				}
			}
			game.ingameTouchDetection = false;
			game.LoadFactories();
			bool flag = SaveMeManager.IsSaveMePopupEnabled();
			result = false;
			if (!flag)
			{
				game.ChangeState(null, GameStateCoroutineType.TopMenu);
				IEnumerator routine = DelayGameOverScreen();
				Coroutine coroutine = game.StartCoroutine(routine);
				game.canRevive = false;
				result = false;
			}
			goto IL_0371;
			IL_0269:
			_003C_003E2__current = null;
			_003C_003E1__state = 3;
			result = true;
			goto IL_0371;
			IL_03f7:
			if (!PauseScreen.PauseScreenIsShown)
			{
				MissionsManager instance = MissionsManager.Instance;
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"System.Math.Floor not resolved\"");
				double num3 = Math.Abs((double)game._elapsedGameDuration);
				int magnitude = ((!(num3 < 2147483648.0)) ? int.MinValue : ((int)game._elapsedGameDuration));
				instance.PlayerDidThis(MissionTarget.TimeDeath, magnitude);
				if (SaveMeManager.IsSaveMePopupEnabled())
				{
					UIScreenController instance2 = UIScreenController.Instance;
					instance2.QueuePopup("SaveMePopup");
				}
				goto IL_0473;
			}
			_003C_003E2__current = null;
			_003C_003E1__state = 2;
			result = true;
			goto IL_0371;
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

	private sealed class _003CDelayGameOverScreen_003Ed__241(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
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
			//IL_0038: Expected I4, but got I8
			if (_003C_003E1__state != 0)
			{
				if (_003C_003E1__state == 1)
				{
					_003C_003E1__state = -1;
					UIScreenController instance = UIScreenController.Instance;
					instance.GameOverTriggered();
				}
				return false;
			}
			_003C_003E1__state = -1;
			_003C_003E1__state = 1;
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

	private sealed class _003CGameIntro_003Ed__244(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public Game _003C_003E4__this;

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
				_003C_003E4__this.LoadFactories();
				if (UIScreenController.IsInstanced)
				{
					UIScreenController instance = UIScreenController.Instance;
					instance.ShowMainMenu();
				}
				_003C_003E4__this.ChangeState(null, GameStateCoroutineType.TopMenu);
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

	private sealed class _003CTopMenu_003Ed__245(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public Game _003C_003E4__this;

		object IEnumerator<object>.Current => _003C_003E2__current;

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_0354: Expected VT, but got Obj
			//IL_035d: Expected VT, but got Obj
			//IL_0372: Expected F4, but got I
			//IL_0372: Expected Obj, but got VT
			if (_003C_003E1__state != 0)
			{
				bool flag = _003C_003E1__state == 1;
				int num = -1;
				bool result = false;
				if (!flag)
				{
					result = false;
				}
				else
				{
					_003C_003E1__state = num;
				}
				return result;
			}
			Game game = _003C_003E4__this;
			_003C_003E1__state = -1;
			Variable<bool> isInGame = game.IsInGame;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S0_v19 (Variable`1<System.Boolean>)+8]");
			if ((nint)0 != 0 && Game.m_OnGameEnded != null)
			{
				Action onGameEnded = Game.m_OnGameEnded;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v103.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
			}
			_00210 val = (_00210)SingletonMonobehavior<>.Instance;
			_00210 val2 = (_00210)SingletonMonobehavior<>.Instance;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ S1_v9 (T)+C]");
			((TimeScaleManager)val).TimeScale = 0f;
			game.__currentSpeed = (game.__currentLevelSpeed = game.Speed(0f, game._currentSpeedInfo));
			Action<float> onSpeedChanged = game.m_OnSpeedChanged;
			if (game.m_OnSpeedChanged != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v116 @ S0_v29 (System.Action`1<System.Single>)+C] (should have been resolved before IL gen)");
			}
			game.LoadFactories();
			throw new NullReferenceException();
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

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Action<float> _003C_003E9__246_0;

		static _003C_003Ec()
		{
			_003C_003Ec obj = default;
			_003C_003E9 = obj;
		}

		internal void _003CIntro_003Eb__246_0(float _003Cp0_003E)
		{
		}
	}

	private sealed class _003CIntro_003Ed__246(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public Game _003C_003E4__this;

		private IEnumerator _003CcameraMovement_003E5__2;

		private float _003Ctime_003E5__3;

		private float _003Cfov_start_003E5__4;

		private float _003Cfov_end_003E5__5;

		object IEnumerator<object>.Current => _003C_003E2__current;

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
		}

		private unsafe bool MoveNext()
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected VT, but got Unknown
			//IL_0073: Expected VT, but got Obj
			//IL_007c: Expected VT, but got Obj
			//IL_0096: Expected F4, but got I
			//IL_0096: Expected Obj, but got VT
			//IL_013d: Expected I, but got Obj
			//IL_016f: Expected F4, but got I
			//IL_016a: Expected native int or pointer, but got VT
			//IL_018a: Expected F4, but got I
			//IL_0185: Expected native int or pointer, but got VT
			object obj = default;
			Vector3 vector = (Vector3)(obj - 32);
			Game game = _003C_003E4__this;
			int num;
			if (_003C_003E1__state != 0)
			{
				if (_003C_003E1__state != 1)
				{
					bool flag = _003C_003E1__state == 2;
					num = -1;
					if (flag)
					{
						goto IL_0527;
					}
					goto IL_0536;
				}
				_003C_003E1__state = -1;
			}
			else
			{
				_003C_003E1__state = -1;
				_00210 val = (_00210)SingletonMonobehavior<>.Instance;
				_00210 val2 = (_00210)SingletonMonobehavior<>.Instance;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S1_v31 (T)+10]");
				((TimeScaleManager)val).TimeScale = 0f;
				game._gameStats.ResetGame();
				game._modifiers.Stop();
				game._modifiers.Update();
				game._audioStateLoop.ChangeLoop(AudioState.Ingame);
				game._followingGuard.MuteProximityLoop();
				game.isDead = false;
				Character character = game._character;
				CharacterPickupParticles characterPickupParticleSystem = character.CharacterPickupParticleSystem;
				Transform transform = characterPickupParticleSystem.CoinEFX.transform;
				nint num2 = (nint)typeof(CharacterPickupParticles);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v223 @ S0_v60 (Il2CppClass<CharacterPickupParticles>)+5C]");
				nint num3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v224 @ S0_v61 (Il2CppStaticFields<CharacterPickupParticles>)+8]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+18]");
				((Vector3*)(nint)vector)->z = 0f;
				_ = CharacterPickupParticles.coinEfxOffset;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+10]");
				((Vector3*)(nint)vector)->x = 0f;
				transform.localPosition = vector;
				game.StageMenuSequence();
				game._followingGuard.ShowEnemies(vis: true);
				game._followingGuard.PlayIntro();
				SpeedInfo speed = game.speed;
				SpeedInfo originalSpeed = game._originalSpeed;
				speed.min = originalSpeed.min;
				speed.max = originalSpeed.max;
				speed.rampUpDuration = originalSpeed.rampUpDuration;
				float _currentLevelSpeed = game.Speed(0f, game._currentSpeedInfo);
				game.__currentLevelSpeed = _currentLevelSpeed;
				float time = Time.time;
				game._offsetGameStartTime = time;
				game._character.InitForRun();
				Transform transform2 = game._characterCamera.transform;
				Transform parent = transform2.parent;
				Animation component = parent.GetComponent<Animation>();
				component.enabled = true;
				Transform transform3 = game._characterCamera.transform;
				Transform parent2 = transform3.parent;
				Animation component2 = parent2.GetComponent<Animation>();
				component2.CrossFade("startPan", 0.2f);
				CharacterRendering characterRendering = game._characterRendering;
				SafeAnimation characterSafeAnimation = characterRendering._characterSafeAnimation;
				characterSafeAnimation._animation.CrossFade("introRun", 0.2f);
				Action onIntroRun = game.m_OnIntroRun;
				if (game.m_OnIntroRun != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v308.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
				}
				CharacterRendering characterRendering2 = game._characterRendering;
				SafeAnimation characterSafeAnimation2 = characterRendering2._characterSafeAnimation;
				AnimationState animationState = characterSafeAnimation2._animation.get_Item("introRun");
				float length = animationState.length;
				bool flag2 = _003C_003Ec._003C_003E9__246_0 == null;
				bool flag3 = !flag2;
				Action<float> callback = _003C_003Ec._003C_003E9__246_0;
				if (!flag3)
				{
					throw new ArgumentException();
				}
				IEnumerator enumerator = pTween.To(length, callback);
				_003CcameraMovement_003E5__2 = enumerator;
				float time2 = Time.time;
				_003Ctime_003E5__3 = time2;
				CharacterCamera characterCamera = game._characterCamera;
				float fieldOfView = characterCamera._camera.fieldOfView;
				_003Cfov_start_003E5__4 = fieldOfView;
				RunningState runningState = game.RunningState;
				_003Cfov_end_003E5__5 = runningState.cameraFOV;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
			CharacterCamera characterCamera2 = game._characterCamera;
			object obj2 = default;
			bool flag4;
			if (obj2 == null)
			{
				characterCamera2._camera.fieldOfView = _003Cfov_end_003E5__5;
				game._followingGuard.enabled = true;
				if (~(game.IsRunningOnTutorialTrack__BackingField ? 1u : 0u) == 0)
				{
					game._followingGuard.ResetCatchUp();
					flag4 = false;
					if (game.IsRunningOnTutorialTrack__BackingField)
					{
						goto IL_0610;
					}
				}
				flag4 = true;
				goto IL_0610;
			}
			float num4 = _003Cfov_end_003E5__5 - _003Cfov_start_003E5__4;
			float time3 = Time.time;
			float num5 = time3 - _003Ctime_003E5__3;
			float num6 = num5 * 0.75f;
			float num7 = Math.Min(num6, 1f);
			bool flag5 = num6 < 0f;
			float num8 = 0f;
			if (!flag5)
			{
				num8 = num7;
			}
			float num9 = num4 * num8;
			float fieldOfView2 = _003Cfov_start_003E5__4 + num9;
			characterCamera2._camera.fieldOfView = fieldOfView2;
			int num10 = 1;
			goto IL_0645;
			IL_0610:
			game.isReadyForSlideinPowerups__BackingField = flag4;
			RunningState runningState2 = game.RunningState;
			game.CharacterState = runningState2;
			num10 = 2;
			goto IL_0645;
			IL_0527:
			_003C_003E1__state = num;
			goto IL_0536;
			IL_0536:
			return true;
			IL_0645:
			_003C_003E2__current = null;
			num = num10;
			goto IL_0527;
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

	public const float Z_OFFSET_BACKGROUND_TO_CHARACTER_CAMERA = 900f;

	private static CharacterController _characterController;

	private static int _DEBUG_CAMERA_DATA_INDEX = 2;

	public const float DISTANCE_PER_METER = 8f;

	public static float GAME_DEFAULT_GAME_SPEED = 110f;

	public static bool HasLoaded;

	private float highSpeedFOVIncrease = 10f;

	private SpeedInfo hotrodSpeedInfo;

	private GameObject characterModelPreviewFactoryPrefab;

	private GameObject hoverboardFactoryPrefab;

	private SpeedInfo highSpeedInfo;

	private float _speedChangeTransitionTime = 0.5f;

	private float speedFOVIncrease;

	public bool isDead;

	public bool ingameTouchDetection = true;

	public bool canRevive;

	public float reviveWaitTime = 3f;

	private float __currentSpeed;

	private float __currentLevelSpeed = 30f;

	private bool _isLockedGameSpeed;

	public float SpeedAtLastObstacleHit;

	public SwipeInfo swipe;

	public SpeedInfo speed;

	public float backToCheckpointDelayTime = 0.7f;

	public float backToCheckpointZoomTime;

	private float _elapsedGameDuration;

	private AudioStateLoop _audioStateLoop;

	public Variable<bool> IsInGame;

	public Variable<bool> IsInTopMenu;

	public AudioClipInfo DieSound;

	public bool awakeDone;

	public DateTime gameStartTime;

	public string startCharacterName;

	public int startCharacterTheme;

	public int pogoLevel;

	public int pogoJumpsLeft;

	private Character _character;

	private CharacterState __characterState;

	private CharacterModifierCollection _modifiers;

	private RunningState _runningState;

	private JetpackState _jetpackState;

	private PogoStickState _pogoStickState;

	private SpeedInfo _selectedBoardSpeedInfo;

	private SpeedInfo _currentSpeedInfo;

	private bool goingBackToCheckpoint;

	private SpeedInfo _originalSpeed;

	private IEnumerator _gameStateCoroutine;

	private GameStateCoroutineType _gameStateCoroutineType;

	private Swipe _currentSwipe;

	private CharacterRendering _characterRendering;

	private CharacterCamera _characterCamera;

	private FollowingGuard _followingGuard;

	private GameObject[] _menuFactories;

	private GameStats _gameStats;

	private int _debugCameraDataIndex;

	private float _elapsedRunDuration;

	private float _offsetGameStartTime;

	private bool _isPaused;

	private float _waitTimeBeforeScreen;

	private PickupManagerController _pickupManagerController;

	private SyboRandom _randomGenerator;

	private static Game instance;

	private bool _isPausedPowerups;

	private IEnumerator _debugRepeatedlySwipeLeftRightCoroutine;

	private bool _isInStumbleDeathSequence;

	private bool IsRunningOnTutorialTrack__BackingField;

	private bool isReadyForSlideinPowerups__BackingField;

	private static Action m_OnGameAwake;

	private static Action m_OnGameStarted;

	private static Action<bool> m_OnRunStarted;

	private static Action m_OnGameRevived;

	private static Action<bool> m_OnPlayerDied;

	private static Action<bool> m_OnRunEnded;

	private static Action m_OnGameReviveOffer;

	private static Action m_OnGameEnded;

	private static Action m_OnMenuScreenShown;

	private static Action m_OnGameDestroyed;

	private EventHandler<CharacterStateChangedEventArgs> m_OnCharacterStateChanged;

	private Action<float> m_OnSpeedChanged;

	private Action<int> m_OnTurboHeadstartInput;

	private Action m_OnEndStumbleDeathSequence;

	private Action<bool> m_OnPauseChange;

	private Action m_OnStageMenuSequence;

	private Action m_OnIntroRun;

	private Action m_OnCharacterModelRecreated;

	private float swipeThreshold;

	private Vector2 touchStartPos;

	private Vector2 touchEndPos;

	private Vector2 swipeDelta;

	private float swipeDelay;

	private bool isSwiping;

	private bool swipeFlag;

	private float delayTime;

	public static CharacterController Charactercontroller
	{
		get
		{
			//IL_0014: Expected VT, but got Obj
			bool flag = (object)_characterController == null;
			bool flag2 = !flag;
			CharacterController result = _characterController;
			if (!flag2)
			{
				Type typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)typeof(CharacterController));
				UnityEngine.Object obj = UnityEngine.Object.FindObjectOfType(typeFromHandle);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @238");
				CharacterController characterController = default;
				_characterController = characterController;
				result = characterController;
			}
			return result;
		}
	}

	public float HighSpeedFOVIncrease => highSpeedFOVIncrease;

	public float SpeedFOVIncrease => speedFOVIncrease;

	public bool IsRunningOnTutorialTrack
	{
		get
		{
			return IsRunningOnTutorialTrack__BackingField;
		}
		set
		{
			IsRunningOnTutorialTrack__BackingField = value;
		}
	}

	public float CurrentSpeed => __currentSpeed;

	public float CurrentLevelSpeed => __currentLevelSpeed;

	public bool IsLockedGameSpeed
	{
		get
		{
			return _isLockedGameSpeed;
		}
		set
		{
			_isLockedGameSpeed = value;
		}
	}

	public float ElapsedGameDuration => _elapsedGameDuration;

	public bool isReadyForSlideinPowerups
	{
		get
		{
			return isReadyForSlideinPowerups__BackingField;
		}
		set
		{
			isReadyForSlideinPowerups__BackingField = value;
		}
	}

	public Character Character => _character;

	public CharacterState CharacterState
	{
		get
		{
			return __characterState;
		}
		set
		{
			//IL_0017: Expected I, but got Obj
			__characterState = value;
			if (__characterState != null)
			{
				CharacterState _characterState = __characterState;
				nint num = (nint)_characterState;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v33 @ S2_v7 (Il2CppClass<SYBO.Subway.Characters.States.CharacterState>)+104] (should have been resolved before IL gen)");
				IEnumerator gameStateCoroutine = default;
				_gameStateCoroutine = gameStateCoroutine;
			}
			CharacterStateChangedEventArgs e = default;
			e._002Ector(__characterState, __characterState);
			EventHandler<CharacterStateChangedEventArgs> onCharacterStateChanged = this.m_OnCharacterStateChanged;
			if (this.m_OnCharacterStateChanged != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v56 @ S0_v21 (System.EventHandler`1<SYBO.Subway.CharacterStateChangedEventArgs>)+C] (should have been resolved before IL gen)");
			}
		}
	}

	public CharacterModifierCollection Modifiers => _modifiers;

	public RunningState RunningState
	{
		get
		{
			//IL_0024: Unknown result type (might be due to invalid IL or missing references)
			//IL_0029: Expected Obj, but got Unknown
			object result = this + 140;
			if (_runningState == null)
			{
				RunningState componentInChildren = GetComponentInChildren<RunningState>();
				_runningState = componentInChildren;
			}
			return (RunningState)result;
		}
	}

	public JetpackState JetpackState => _jetpackState;

	public PogoStickState PogoStickState => _pogoStickState;

	public bool IsInJetpackMode => __characterState == _jetpackState;

	public bool IsInPogostickMode => __characterState == _pogoStickState;

	public bool HasSuperSneakers
	{
		get
		{
			CharacterModifierCollection modifiers = _modifiers;
			SuperSneakers superSneakers = modifiers.superSneakers;
			return superSneakers.isActive;
		}
	}

	public float CurrentSpeedNormalized
	{
		get
		{
			SpeedInfo speedInfo = speed;
			return __currentSpeed / speedInfo.min;
		}
	}

	public float ElapsedRunDuration => _elapsedRunDuration;

	public SyboRandom RandomGenerator => _randomGenerator;

	public float OffsetGameStartTime
	{
		get
		{
			float time = Time.time;
			return time - _offsetGameStartTime;
		}
	}

	public bool IsPaused => _isPaused;

	public static Game Instance
	{
		get
		{
			bool flag = (object)instance == null;
			bool flag2 = !flag;
			Game result = instance;
			if (!flag2)
			{
				result = (instance = Utils.FindObject<Game>(warnIfNotFound: false));
			}
			return result;
		}
	}

	public static bool IsInstantiated => instance != null;

	public bool IsPausedPowerups
	{
		get
		{
			return _isPausedPowerups;
		}
		set
		{
			_isPausedPowerups = value;
			GameStats gameStats = GameStats.Instance;
			if (value)
			{
				gameStats._isPausedPowerups = true;
				_modifiers.Pause();
			}
			else
			{
				gameStats._isPausedPowerups = false;
				_modifiers.Resume();
			}
		}
	}

	public bool isInStumbleDeathSequence => _isInStumbleDeathSequence;

	public static event Action OnGameAwake
	{
		add
		{
			Delegate obj = Game.m_OnGameAwake;
			Action action = default;
			bool flag2;
			do
			{
				Delegate obj2 = Delegate.Combine(obj, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
				bool flag = (object)obj == Game.m_OnGameAwake;
				Action onGameAwake = action;
				if (!flag)
				{
					onGameAwake = Game.m_OnGameAwake;
				}
				Game.m_OnGameAwake = onGameAwake;
				Delegate obj3 = obj;
				if (!flag)
				{
					obj3 = Game.m_OnGameAwake;
				}
				flag2 = (object)obj != obj3;
				obj = obj3;
			}
			while (flag2);
		}
		remove
		{
			Delegate obj = Game.m_OnGameAwake;
			Action action = default;
			bool flag2;
			do
			{
				Delegate obj2 = Delegate.Remove(obj, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
				bool flag = (object)obj == Game.m_OnGameAwake;
				Action onGameAwake = action;
				if (!flag)
				{
					onGameAwake = Game.m_OnGameAwake;
				}
				Game.m_OnGameAwake = onGameAwake;
				Delegate obj3 = obj;
				if (!flag)
				{
					obj3 = Game.m_OnGameAwake;
				}
				flag2 = (object)obj != obj3;
				obj = obj3;
			}
			while (flag2);
		}
	}

	public static event Action OnGameStarted
	{
		add
		{
			Delegate obj = Game.m_OnGameStarted;
			Action action = default;
			bool flag2;
			do
			{
				Delegate obj2 = Delegate.Combine(obj, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
				bool flag = (object)obj == Game.m_OnGameStarted;
				Action onGameStarted = action;
				if (!flag)
				{
					onGameStarted = Game.m_OnGameStarted;
				}
				Game.m_OnGameStarted = onGameStarted;
				Delegate obj3 = obj;
				if (!flag)
				{
					obj3 = Game.m_OnGameStarted;
				}
				flag2 = (object)obj != obj3;
				obj = obj3;
			}
			while (flag2);
		}
		remove
		{
			Delegate obj = Game.m_OnGameStarted;
			Action action = default;
			bool flag2;
			do
			{
				Delegate obj2 = Delegate.Remove(obj, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
				bool flag = (object)obj == Game.m_OnGameStarted;
				Action onGameStarted = action;
				if (!flag)
				{
					onGameStarted = Game.m_OnGameStarted;
				}
				Game.m_OnGameStarted = onGameStarted;
				Delegate obj3 = obj;
				if (!flag)
				{
					obj3 = Game.m_OnGameStarted;
				}
				flag2 = (object)obj != obj3;
				obj = obj3;
			}
			while (flag2);
		}
	}

	public static event Action<bool> OnRunStarted
	{
		add
		{
			Delegate obj = Game.m_OnRunStarted;
			Action<bool> action = default;
			bool flag2;
			do
			{
				Delegate obj2 = Delegate.Combine(obj, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23D");
				bool flag = (object)obj == Game.m_OnRunStarted;
				Action<bool> onRunStarted = action;
				if (!flag)
				{
					onRunStarted = Game.m_OnRunStarted;
				}
				Game.m_OnRunStarted = onRunStarted;
				Delegate obj3 = obj;
				if (!flag)
				{
					obj3 = Game.m_OnRunStarted;
				}
				flag2 = (object)obj != obj3;
				obj = obj3;
			}
			while (flag2);
		}
		remove
		{
			Delegate obj = Game.m_OnRunStarted;
			Action<bool> action = default;
			bool flag2;
			do
			{
				Delegate obj2 = Delegate.Remove(obj, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23D");
				bool flag = (object)obj == Game.m_OnRunStarted;
				Action<bool> onRunStarted = action;
				if (!flag)
				{
					onRunStarted = Game.m_OnRunStarted;
				}
				Game.m_OnRunStarted = onRunStarted;
				Delegate obj3 = obj;
				if (!flag)
				{
					obj3 = Game.m_OnRunStarted;
				}
				flag2 = (object)obj != obj3;
				obj = obj3;
			}
			while (flag2);
		}
	}

	public static event Action OnGameRevived
	{
		add
		{
			Delegate obj = Game.m_OnGameRevived;
			Action action = default;
			bool flag2;
			do
			{
				Delegate obj2 = Delegate.Combine(obj, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
				bool flag = (object)obj == Game.m_OnGameRevived;
				Action onGameRevived = action;
				if (!flag)
				{
					onGameRevived = Game.m_OnGameRevived;
				}
				Game.m_OnGameRevived = onGameRevived;
				Delegate obj3 = obj;
				if (!flag)
				{
					obj3 = Game.m_OnGameRevived;
				}
				flag2 = (object)obj != obj3;
				obj = obj3;
			}
			while (flag2);
		}
		remove
		{
			Delegate obj = Game.m_OnGameRevived;
			Action action = default;
			bool flag2;
			do
			{
				Delegate obj2 = Delegate.Remove(obj, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
				bool flag = (object)obj == Game.m_OnGameRevived;
				Action onGameRevived = action;
				if (!flag)
				{
					onGameRevived = Game.m_OnGameRevived;
				}
				Game.m_OnGameRevived = onGameRevived;
				Delegate obj3 = obj;
				if (!flag)
				{
					obj3 = Game.m_OnGameRevived;
				}
				flag2 = (object)obj != obj3;
				obj = obj3;
			}
			while (flag2);
		}
	}

	public static event Action<bool> OnPlayerDied
	{
		add
		{
			Delegate obj = Game.m_OnPlayerDied;
			Action<bool> action = default;
			bool flag2;
			do
			{
				Delegate obj2 = Delegate.Combine(obj, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23D");
				bool flag = (object)obj == Game.m_OnPlayerDied;
				Action<bool> onPlayerDied = action;
				if (!flag)
				{
					onPlayerDied = Game.m_OnPlayerDied;
				}
				Game.m_OnPlayerDied = onPlayerDied;
				Delegate obj3 = obj;
				if (!flag)
				{
					obj3 = Game.m_OnPlayerDied;
				}
				flag2 = (object)obj != obj3;
				obj = obj3;
			}
			while (flag2);
		}
		remove
		{
			Delegate obj = Game.m_OnPlayerDied;
			Action<bool> action = default;
			bool flag2;
			do
			{
				Delegate obj2 = Delegate.Remove(obj, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23D");
				bool flag = (object)obj == Game.m_OnPlayerDied;
				Action<bool> onPlayerDied = action;
				if (!flag)
				{
					onPlayerDied = Game.m_OnPlayerDied;
				}
				Game.m_OnPlayerDied = onPlayerDied;
				Delegate obj3 = obj;
				if (!flag)
				{
					obj3 = Game.m_OnPlayerDied;
				}
				flag2 = (object)obj != obj3;
				obj = obj3;
			}
			while (flag2);
		}
	}

	public static event Action<bool> OnRunEnded
	{
		add
		{
			Delegate obj = Game.m_OnRunEnded;
			Action<bool> action = default;
			bool flag2;
			do
			{
				Delegate obj2 = Delegate.Combine(obj, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23D");
				bool flag = (object)obj == Game.m_OnRunEnded;
				Action<bool> onRunEnded = action;
				if (!flag)
				{
					onRunEnded = Game.m_OnRunEnded;
				}
				Game.m_OnRunEnded = onRunEnded;
				Delegate obj3 = obj;
				if (!flag)
				{
					obj3 = Game.m_OnRunEnded;
				}
				flag2 = (object)obj != obj3;
				obj = obj3;
			}
			while (flag2);
		}
		remove
		{
			Delegate obj = Game.m_OnRunEnded;
			Action<bool> action = default;
			bool flag2;
			do
			{
				Delegate obj2 = Delegate.Remove(obj, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23D");
				bool flag = (object)obj == Game.m_OnRunEnded;
				Action<bool> onRunEnded = action;
				if (!flag)
				{
					onRunEnded = Game.m_OnRunEnded;
				}
				Game.m_OnRunEnded = onRunEnded;
				Delegate obj3 = obj;
				if (!flag)
				{
					obj3 = Game.m_OnRunEnded;
				}
				flag2 = (object)obj != obj3;
				obj = obj3;
			}
			while (flag2);
		}
	}

	public static event Action OnGameReviveOffer
	{
		add
		{
			Delegate obj = Game.m_OnGameReviveOffer;
			Action action = default;
			bool flag2;
			do
			{
				Delegate obj2 = Delegate.Combine(obj, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
				bool flag = (object)obj == Game.m_OnGameReviveOffer;
				Action onGameReviveOffer = action;
				if (!flag)
				{
					onGameReviveOffer = Game.m_OnGameReviveOffer;
				}
				Game.m_OnGameReviveOffer = onGameReviveOffer;
				Delegate obj3 = obj;
				if (!flag)
				{
					obj3 = Game.m_OnGameReviveOffer;
				}
				flag2 = (object)obj != obj3;
				obj = obj3;
			}
			while (flag2);
		}
		remove
		{
			Delegate obj = Game.m_OnGameReviveOffer;
			Action action = default;
			bool flag2;
			do
			{
				Delegate obj2 = Delegate.Remove(obj, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
				bool flag = (object)obj == Game.m_OnGameReviveOffer;
				Action onGameReviveOffer = action;
				if (!flag)
				{
					onGameReviveOffer = Game.m_OnGameReviveOffer;
				}
				Game.m_OnGameReviveOffer = onGameReviveOffer;
				Delegate obj3 = obj;
				if (!flag)
				{
					obj3 = Game.m_OnGameReviveOffer;
				}
				flag2 = (object)obj != obj3;
				obj = obj3;
			}
			while (flag2);
		}
	}

	public static event Action OnGameEnded
	{
		add
		{
			Delegate obj = Game.m_OnGameEnded;
			Action action = default;
			bool flag2;
			do
			{
				Delegate obj2 = Delegate.Combine(obj, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
				bool flag = (object)obj == Game.m_OnGameEnded;
				Action onGameEnded = action;
				if (!flag)
				{
					onGameEnded = Game.m_OnGameEnded;
				}
				Game.m_OnGameEnded = onGameEnded;
				Delegate obj3 = obj;
				if (!flag)
				{
					obj3 = Game.m_OnGameEnded;
				}
				flag2 = (object)obj != obj3;
				obj = obj3;
			}
			while (flag2);
		}
		remove
		{
			Delegate obj = Game.m_OnGameEnded;
			Action action = default;
			bool flag2;
			do
			{
				Delegate obj2 = Delegate.Remove(obj, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
				bool flag = (object)obj == Game.m_OnGameEnded;
				Action onGameEnded = action;
				if (!flag)
				{
					onGameEnded = Game.m_OnGameEnded;
				}
				Game.m_OnGameEnded = onGameEnded;
				Delegate obj3 = obj;
				if (!flag)
				{
					obj3 = Game.m_OnGameEnded;
				}
				flag2 = (object)obj != obj3;
				obj = obj3;
			}
			while (flag2);
		}
	}

	public static event Action OnMenuScreenShown
	{
		add
		{
			Delegate obj = Game.m_OnMenuScreenShown;
			Action action = default;
			bool flag2;
			do
			{
				Delegate obj2 = Delegate.Combine(obj, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
				bool flag = (object)obj == Game.m_OnMenuScreenShown;
				Action onMenuScreenShown = action;
				if (!flag)
				{
					onMenuScreenShown = Game.m_OnMenuScreenShown;
				}
				Game.m_OnMenuScreenShown = onMenuScreenShown;
				Delegate obj3 = obj;
				if (!flag)
				{
					obj3 = Game.m_OnMenuScreenShown;
				}
				flag2 = (object)obj != obj3;
				obj = obj3;
			}
			while (flag2);
		}
		remove
		{
			Delegate obj = Game.m_OnMenuScreenShown;
			Action action = default;
			bool flag2;
			do
			{
				Delegate obj2 = Delegate.Remove(obj, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
				bool flag = (object)obj == Game.m_OnMenuScreenShown;
				Action onMenuScreenShown = action;
				if (!flag)
				{
					onMenuScreenShown = Game.m_OnMenuScreenShown;
				}
				Game.m_OnMenuScreenShown = onMenuScreenShown;
				Delegate obj3 = obj;
				if (!flag)
				{
					obj3 = Game.m_OnMenuScreenShown;
				}
				flag2 = (object)obj != obj3;
				obj = obj3;
			}
			while (flag2);
		}
	}

	public static event Action OnGameDestroyed
	{
		add
		{
			Delegate obj = Game.m_OnGameDestroyed;
			Action action = default;
			bool flag2;
			do
			{
				Delegate obj2 = Delegate.Combine(obj, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
				bool flag = (object)obj == Game.m_OnGameDestroyed;
				Action onGameDestroyed = action;
				if (!flag)
				{
					onGameDestroyed = Game.m_OnGameDestroyed;
				}
				Game.m_OnGameDestroyed = onGameDestroyed;
				Delegate obj3 = obj;
				if (!flag)
				{
					obj3 = Game.m_OnGameDestroyed;
				}
				flag2 = (object)obj != obj3;
				obj = obj3;
			}
			while (flag2);
		}
		remove
		{
			Delegate obj = Game.m_OnGameDestroyed;
			Action action = default;
			bool flag2;
			do
			{
				Delegate obj2 = Delegate.Remove(obj, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
				bool flag = (object)obj == Game.m_OnGameDestroyed;
				Action onGameDestroyed = action;
				if (!flag)
				{
					onGameDestroyed = Game.m_OnGameDestroyed;
				}
				Game.m_OnGameDestroyed = onGameDestroyed;
				Delegate obj3 = obj;
				if (!flag)
				{
					obj3 = Game.m_OnGameDestroyed;
				}
				flag2 = (object)obj != obj3;
				obj = obj3;
			}
			while (flag2);
		}
	}

	public event EventHandler<CharacterStateChangedEventArgs> OnCharacterStateChanged
	{
		add
		{
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected Obj, but got Unknown
			object obj = this + 240;
			Delegate obj2 = this.m_OnCharacterStateChanged;
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
			object obj = this + 240;
			Delegate obj2 = this.m_OnCharacterStateChanged;
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

	public event Action<float> OnSpeedChanged
	{
		add
		{
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected Obj, but got Unknown
			object obj = this + 244;
			Delegate obj2 = this.m_OnSpeedChanged;
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
			object obj = this + 244;
			Delegate obj2 = this.m_OnSpeedChanged;
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

	public event Action<int> OnTurboHeadstartInput
	{
		add
		{
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected Obj, but got Unknown
			object obj = this + 248;
			Delegate obj2 = this.m_OnTurboHeadstartInput;
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
			object obj = this + 248;
			Delegate obj2 = this.m_OnTurboHeadstartInput;
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

	public event Action OnEndStumbleDeathSequence
	{
		add
		{
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected Obj, but got Unknown
			object obj = this + 252;
			Delegate obj2 = this.m_OnEndStumbleDeathSequence;
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
			object obj = this + 252;
			Delegate obj2 = this.m_OnEndStumbleDeathSequence;
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

	public event Action<bool> OnPauseChange
	{
		add
		{
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected Obj, but got Unknown
			object obj = this + 256;
			Delegate obj2 = this.m_OnPauseChange;
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
			object obj = this + 256;
			Delegate obj2 = this.m_OnPauseChange;
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

	public event Action OnStageMenuSequence
	{
		add
		{
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected Obj, but got Unknown
			object obj = this + 260;
			Delegate obj2 = this.m_OnStageMenuSequence;
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
			object obj = this + 260;
			Delegate obj2 = this.m_OnStageMenuSequence;
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

	public event Action OnIntroRun
	{
		add
		{
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected Obj, but got Unknown
			object obj = this + 264;
			Delegate obj2 = this.m_OnIntroRun;
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
			object obj = this + 264;
			Delegate obj2 = this.m_OnIntroRun;
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

	public event Action OnCharacterModelRecreated
	{
		add
		{
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected Obj, but got Unknown
			object obj = this + 268;
			Delegate obj2 = this.m_OnCharacterModelRecreated;
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
			object obj = this + 268;
			Delegate obj2 = this.m_OnCharacterModelRecreated;
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

	public Game()
	{
		SpeedInfo speedInfo = default;
		speedInfo.rampUpDuration = 200f;
		speedInfo.min = 110f;
		_currentSpeedInfo = speedInfo;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		GameObject[] menuFactories = default;
		_menuFactories = menuFactories;
		_waitTimeBeforeScreen = 3f;
		_debugCameraDataIndex = -1;
		SyboRandom syboRandom = default;
		syboRandom._002Ector();
		_randomGenerator = syboRandom;
		swipeDelay = 0.3f;
		swipeThreshold = 100f;
		base._002Ector();
		_ = 0;
		Variable<bool> isInGame = default;
		IsInGame = isInGame;
		_ = 0;
		Variable<bool> isInTopMenu = default;
		IsInTopMenu = isInTopMenu;
	}

	public static float ConvertUnityUnitsToGameMeters(float unityUnits)
	{
		return unityUnits * 0.125f;
	}

	public static float ConvertGameMetersToUnityUnits(float meters)
	{
		return meters * 8f;
	}

	public void SetCurrentSpeed(float speed)
	{
		__currentSpeed = speed;
	}

	public void SetCurrentLevelSpeed(float levelSpeed)
	{
		__currentLevelSpeed = levelSpeed;
	}

	protected unsafe void Awake()
	{
		//IL_0143: Expected VT, but got Obj
		//IL_0152: Expected Obj, but got VT
		Character character = Character.Instance;
		_character = character;
		SingletonMonobehavior<TimeScaleManager>.Instantiate();
		SingletonMonobehavior<CoinManager>.Instantiate();
		_originalSpeed = speed;
		LoadFactories();
		HasLoaded = true;
		_character.Initialize();
		CharacterRendering characterRendering = CharacterRendering.Instance;
		_characterRendering = characterRendering;
		CharacterCamera characterCamera = CharacterCamera.Instance;
		_characterCamera = characterCamera;
		RunningState runningState = RunningState.Instance;
		_runningState = runningState;
		JetpackState jetpackState = JetpackState.Instance;
		_jetpackState = jetpackState;
		PogoStickState pogoStickState = PogoStickState.Instance;
		_pogoStickState = pogoStickState;
		FollowingGuard followingGuard = FollowingGuard.Instance;
		_followingGuard = followingGuard;
		_followingGuard.Initialize();
		FollowingGuard followingGuard2 = _followingGuard;
		FollowingGuard.OnCatchPlayerDelegate onCatchPlayerDelegate = default;
		onCatchPlayerDelegate._002Ector(this, (nint)__ldftn(Game.OnCatchPlayer));
		Delegate obj = Delegate.Combine(followingGuard2.OnCatchPlayer, onCatchPlayerDelegate);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
		FollowingGuard.OnCatchPlayerDelegate onCatchPlayer = default;
		followingGuard2.OnCatchPlayer = onCatchPlayer;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
		CharacterModifierCollection characterModifierCollection = default;
		characterModifierCollection._002Ector();
		_modifiers = characterModifierCollection;
		_0021_00210 val = (_0021_00210)UnityEngine.Object.FindObjectOfType<T>();
		_audioStateLoop = (AudioStateLoop)val;
		throw new ArgumentException();
	}

	protected void Start()
	{
		ChangeGameStateCoroutine(GameStateCoroutineType.GameIntro);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
	}

	protected unsafe void OnDestroy()
	{
		//IL_0040: Expected VT, but got Obj
		//IL_0088: Expected VT, but got Obj
		//IL_00aa: Expected Obj, but got VT
		if (_pickupManagerController != null)
		{
			_pickupManagerController.Destroy();
		}
		if (SingletonMonobehavior<>.IsInstantiated)
		{
			_00210 val = (_00210)SingletonMonobehavior<>.Instance;
			throw new ArgumentException();
		}
		if (SingletonMonobehavior<>.IsInstantiated)
		{
			_00210 val2 = (_00210)SingletonMonobehavior<>.Instance;
			EventHandler eventHandler = default;
			eventHandler._002Ector(this, (nint)__ldftn(Game.CoinManager_OnCoinCollected));
			((CoinManager)val2).OnCoinCollected -= eventHandler;
		}
		if (_characterCamera != null)
		{
			throw new ArgumentException();
		}
		if (SingletonMonobehavior<>.IsInstantiated)
		{
			SingletonMonobehavior<>.Destroy();
		}
		if (Game.m_OnGameDestroyed != null)
		{
			Action onGameDestroyed = Game.m_OnGameDestroyed;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v159.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
		}
	}

	public float EvaluatePlayerDistanceTravelTime(float distanceFromCharacter)
	{
		return distanceFromCharacter / __currentSpeed;
	}

	public void RecreateCharacterModel()
	{
		_character.RecreateCharacterModel();
		Action onCharacterModelRecreated = this.m_OnCharacterModelRecreated;
		if (this.m_OnCharacterModelRecreated != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v5.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
		}
	}

	public void ChangeCurrentSpeed(float timeOffset)
	{
		float offsetGameStartTime = _offsetGameStartTime - timeOffset;
		_offsetGameStartTime = offsetGameStartTime;
	}

	public void StartNewGame(bool duel)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		_ = 0;
		isSwiping = false;
		DateTime utcNow = CDateTime.UtcNow;
		_elapsedRunDuration = 0f;
		_elapsedGameDuration = 0f;
		gameStartTime = utcNow;
		Character character = _character;
		character._killSwitchEnabled = true;
		_isInStumbleDeathSequence = false;
		PlayerInfo playerInfo = PlayerInfo.Instance;
		bool flag = (byte)((playerInfo._isTutorialCompleted ? 1u : 0u) ^ 1u) != 0;
		IsRunningOnTutorialTrack__BackingField = flag;
		if (~(playerInfo._isTutorialCompleted ? 1u : 0u) != 0)
		{
			Character character2 = _character;
			character2._lastCheckpointTime = 0f;
		}
		PlayerInfo playerInfo2 = PlayerInfo.Instance;
		SYBO.Subway.Info.Characters.Model model = SYBO.Subway.Info.Characters.characterData.get_Item((SYBO.Subway.Info.Characters.CharacterType)playerInfo2._currentCharacter);
		startCharacterName = model.modelName;
		PlayerInfo playerInfo3 = PlayerInfo.Instance;
		int currentThemeIndex = playerInfo3.currentThemeIndex;
		startCharacterTheme = currentThemeIndex;
		SaveMeManager.IS_PURCHASE_RUNNING_INGAME = false;
		throw new NullReferenceException();
	}

	public void Update()
	{
		Variable<bool> isInGame = IsInGame;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v14 @ S0_v8 (Variable`1<System.Boolean>)+8]");
		if ((nint)0 != 0)
		{
			float deltaTime = Time.deltaTime;
			float elapsedGameDuration = _elapsedGameDuration + deltaTime;
			_elapsedGameDuration = elapsedGameDuration;
			float deltaTime2 = Time.deltaTime;
			float elapsedRunDuration = _elapsedRunDuration + deltaTime2;
			_elapsedRunDuration = elapsedRunDuration;
		}
		if (!SaveMeManager.IS_PURCHASE_RUNNING_INGAME)
		{
			Variable<bool> isInTopMenu = IsInTopMenu;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S0_v47 (Variable`1<System.Boolean>)+8]");
			if ((nint)0 == 0 && !IsRunningOnTutorialTrack__BackingField && !_isLockedGameSpeed)
			{
				float offsetGameStartTime = OffsetGameStartTime;
				float _currentLevelSpeed = Speed(offsetGameStartTime, _currentSpeedInfo);
				__currentLevelSpeed = _currentLevelSpeed;
				goto IL_01e7;
			}
		}
		float deltaTime3 = Time.deltaTime;
		float offsetGameStartTime2 = _offsetGameStartTime + deltaTime3;
		_offsetGameStartTime = offsetGameStartTime2;
		goto IL_01e7;
		IL_01e7:
		if (_gameStateCoroutine != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
		}
		if (__characterState != null && _modifiers != null)
		{
			_modifiers.Update();
		}
		GameStats gameStats = GameStats.Instance;
		float deltaTime4 = Time.deltaTime;
		gameStats.UpdatePowerupTimes(deltaTime4);
		if (_pickupManagerController != null)
		{
			_pickupManagerController.Update();
		}
		Control();
	}

	private void Control()
	{
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Expected Obj, but got Unknown
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Expected Obj, but got Unknown
		//IL_013b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0140: Expected Obj, but got Unknown
		//IL_0189: Unknown result type (might be due to invalid IL or missing references)
		//IL_018e: Expected Obj, but got Unknown
		if (!(__characterState != null))
		{
			return;
		}
		UIScreenController uIScreenController = UIScreenController.Instance;
		PauseScreen pauseScreen = uIScreenController.PauseScreen;
		if (!pauseScreen._isActive)
		{
			if (Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.W))
			{
				CharacterState _characterState = __characterState;
				object obj = _characterState - -64;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v62 @ S2_v21+BC] (should have been resolved before IL gen)");
			}
			if (Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.S))
			{
				CharacterState _characterState2 = __characterState;
				object obj2 = _characterState2 - -64;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v92 @ S2_v17+BC] (should have been resolved before IL gen)");
			}
			if (Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.A))
			{
				CharacterState _characterState3 = __characterState;
				object obj3 = _characterState3 - -64;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v122 @ S2_v13+BC] (should have been resolved before IL gen)");
			}
			if (Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.D))
			{
				CharacterState _characterState4 = __characterState;
				object obj4 = _characterState4 - -64;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v151 @ S2_v9+BC] (should have been resolved before IL gen)");
			}
			SwipeHandler();
		}
	}

	public void SwipeHandler()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0053: Expected VT, but got Obj
		//IL_0076: Expected VT, but got Obj
		//IL_01f6: Expected Obj, but got I
		//IL_0203: Expected VT, but got Obj
		//IL_024b: Expected Obj, but got F4
		//IL_0253: Unknown result type (might be due to invalid IL or missing references)
		//IL_0258: Expected VT, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		if (Input.GetMouseButtonDown(0))
		{
			Vector3 mousePosition = Input.mousePosition;
			isSwiping = true;
			touchStartPos = (Vector2)obj;
		}
		if (Input.GetMouseButtonUp(0))
		{
			Vector3 mousePosition2 = Input.mousePosition;
			isSwiping = false;
			touchStartPos = (Vector2)obj;
		}
		else
		{
			if (~(isSwiping ? 1u : 0u) != 0)
			{
				return;
			}
			if (!swipeFlag)
			{
				float time = Time.time;
				float num = time - delayTime;
				if (num > swipeDelay)
				{
					swipeFlag = true;
				}
			}
			Vector3 mousePosition3 = Input.mousePosition;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4]");
			object obj3 = (nint)0 << 32;
			Vector2 vector = (Vector2)(obj | obj3);
			touchEndPos = vector;
			float num2 = (float)obj - (float)touchStartPos;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4]");
			float num3 = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Game)+118]");
			float num4 = num3 - 0f;
			object obj4 = num4 << 32;
			Vector2 vector2 = (Vector2)(num2 | obj4);
			swipeDelta = vector2;
			float num5 = Math.Abs(num2);
			bool flag = num5 > swipeThreshold;
			float num6 = Math.Abs(num4);
			bool flag2 = swipeThreshold < num6;
			bool flag3 = true;
			if (!flag2)
			{
				flag3 = flag;
			}
			if (!flag3)
			{
				return;
			}
			if (num5 > num6)
			{
				bool flag4 = num2 > 0f;
				SwipeDir input = SwipeDir.Right;
				if (!flag4)
				{
					input = SwipeDir.Left;
				}
				Swipe(input);
			}
			else
			{
				bool flag5 = num4 > 0f;
				bool input2 = !flag5;
				Swipe(input2 ? SwipeDir.Down : SwipeDir.Up);
			}
		}
	}

	private void Swipe(SwipeDir input)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0021: Expected VT, but got Obj
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		Vector3 mousePosition = Input.mousePosition;
		touchStartPos = (Vector2)obj;
		if (~(swipeFlag ? 1u : 0u) == 0)
		{
			float time = Time.time;
			swipeFlag = false;
			delayTime = time;
			CharacterState _characterState = __characterState;
			object obj3 = _characterState - -64;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v49 @ S2_v4+BC] (should have been resolved before IL gen)");
		}
	}

	public void UpdateMeters()
	{
		//IL_0053: Expected F8, but got I4
		GameStats gameStats = _gameStats;
		Character character = _character;
		float num = character.z * 0.125f;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2BE");
		double num3 = default;
		double num2 = Math.Abs(num3);
		if (!(num2 < 2147483648.0))
		{
			num3 = -2147483648.0;
		}
		gameStats._metersInCurrentGame = (float)num3;
	}

	public void ChangeState(CharacterState newCharacterState, GameStateCoroutineType gameStateCoroutineType)
	{
		CharacterState = newCharacterState;
		ChangeGameStateCoroutine(gameStateCoroutineType);
		CharacterStateChangedEventArgs e = default;
		e._002Ector(__characterState, __characterState);
		EventHandler<CharacterStateChangedEventArgs> onCharacterStateChanged = this.m_OnCharacterStateChanged;
		if (this.m_OnCharacterStateChanged != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v33 @ S0_v15 (System.EventHandler`1<SYBO.Subway.CharacterStateChangedEventArgs>)+C] (should have been resolved before IL gen)");
		}
	}

	private void ChangeGameStateCoroutine(GameStateCoroutineType gameStateCoroutineType)
	{
		if (_gameStateCoroutineType != gameStateCoroutineType)
		{
			_gameStateCoroutineType = gameStateCoroutineType;
			switch (gameStateCoroutineType)
			{
			case GameStateCoroutineType.Intro:
			{
				IEnumerator gameStateCoroutine5 = Intro();
				_gameStateCoroutine = gameStateCoroutine5;
				break;
			}
			case GameStateCoroutineType.GameIntro:
			{
				IEnumerator gameStateCoroutine4 = GameIntro();
				_gameStateCoroutine = gameStateCoroutine4;
				break;
			}
			case GameStateCoroutineType.TopMenu:
			{
				IEnumerator gameStateCoroutine3 = TopMenu();
				_gameStateCoroutine = gameStateCoroutine3;
				break;
			}
			case GameStateCoroutineType.DieSequence:
			{
				IEnumerator gameStateCoroutine2 = DieSequence();
				_gameStateCoroutine = gameStateCoroutine2;
				break;
			}
			case GameStateCoroutineType.SwitchToDieStateWhenGrounded:
			{
				IEnumerator gameStateCoroutine = SwitchToDieStateWhenGrounded();
				_gameStateCoroutine = gameStateCoroutine;
				break;
			}
			case GameStateCoroutineType.None:
				_gameStateCoroutine = null;
				break;
			}
		}
	}

	public void ActivateJetpack()
	{
		if (__characterState != _jetpackState)
		{
			CharacterState = _jetpackState;
		}
	}

	public void ActivateHighSpeed(SpeedBoostType speedBoostType)
	{
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Expected Obj, but got Unknown
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Expected Obj, but got Unknown
		object obj = default;
		switch (speedBoostType)
		{
		case SpeedBoostType.High:
			_selectedBoardSpeedInfo = highSpeedInfo;
			obj = this + 12;
			break;
		case SpeedBoostType.Normal:
			_selectedBoardSpeedInfo = hotrodSpeedInfo;
			obj = this + 36;
			break;
		}
		CharacterCamera characterCamera = _characterCamera;
		float fieldOfView = characterCamera._camera.fieldOfView;
		RunningState runningState = RunningState;
		float num = runningState.cameraFOV + (float)obj;
		throw new ArgumentException();
	}

	public void DeactivateHighSpeed()
	{
		CharacterCamera characterCamera = _characterCamera;
		float fieldOfView = characterCamera._camera.fieldOfView;
		RunningState runningState = RunningState;
		_ = runningState.cameraFOV;
		throw new ArgumentException();
	}

	public void PickupJetpack()
	{
		Game game = Instance;
		game.StartJetpack();
		GameStats gameStats = GameStats.Instance;
		gameStats.JetpackPickupsCollectedIncrement();
	}

	public void StartJetpack()
	{
		JetpackState jetpackState = _jetpackState;
		jetpackState._powerupType = PowerupType.jetpack;
		_ = 0;
		CharacterState = jetpackState;
	}

	public void PickupPogostick()
	{
		pogoJumpsLeft = pogoLevel;
		StartPogostick();
		GameStats gameStats = GameStats.Instance;
		gameStats.PogoStickPickupsCollectedIncrement();
	}

	public void StartPogostick()
	{
		PogoStickState pogoStickState = _pogoStickState;
		pogoStickState.powerType = PowerupType.pogostick;
		CharacterState = pogoStickState;
	}

	public void StartTopMenu()
	{
		ChangeState(null, GameStateCoroutineType.TopMenu);
	}

	public void Megaheadstart()
	{
		//IL_018c: Expected Obj, but got I4
		//IL_009d: Expected Obj, but got I
		JetpackState jetpackState = _jetpackState;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2 @ S0_v2 (SYBO.Subway.Characters.States.JetpackState)+94]");
		if ((nint)0 != 0)
		{
			if (jetpackState._turboHeadstart <= 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2 @ S0_v2 (SYBO.Subway.Characters.States.JetpackState)+C5]");
				if ((nint)0 == 0)
				{
					_ = 1;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2 @ S0_v2 (SYBO.Subway.Characters.States.JetpackState)+A8]");
					object obj = (nint)0 + (nint)1;
				}
				JetpackState jetpackState2 = _jetpackState;
				object obj2 = jetpackState2._turboHeadstart - 1;
				if (jetpackState2._turboHeadstart != 1)
				{
					if ((nint)obj2 == 1)
					{
						jetpackState2._powerupType = PowerupType.turboHeadstart2;
					}
				}
				else
				{
					jetpackState2._powerupType = PowerupType.turboHeadstart1;
				}
			}
		}
		else if (jetpackState._turboHeadstart == 0)
		{
			if (isDead)
			{
				return;
			}
			_ = 21;
			_ = 1;
			CharacterState = jetpackState;
		}
		Action<int> onTurboHeadstartInput = this.m_OnTurboHeadstartInput;
		if (this.m_OnTurboHeadstartInput != null)
		{
			JetpackState jetpackState3 = _jetpackState;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v38 @ S0_v9 (System.Action`1<System.Int32>)+C] (should have been resolved before IL gen)");
		}
	}

	public void Die()
	{
		//IL_011f: Expected Obj, but got I4
		//IL_0295: Expected Obj, but got I4
		//IL_0155: Expected Obj, but got I4
		//IL_00f8: Expected Obj, but got I4
		//IL_023d: Expected Obj, but got I4
		CharacterModifierCollection modifiers = _modifiers;
		if (_modifiers.IsActive(modifiers.hoverboard))
		{
			CharacterModifierCollection modifiers2 = _modifiers;
			Hoverboard hoverboard = modifiers2.hoverboard;
			if (~(hoverboard.isTeleporter ? 1u : 0u) == 0)
			{
				CharacterRendering characterRendering = CharacterRendering.Instance;
				characterRendering.ResetTeleportFx();
			}
			_followingGuard.Restart(closeToCharacter: true);
			CharacterModifierCollection modifiers3 = _modifiers;
			Hoverboard hoverboard2 = modifiers3.hoverboard;
			((CharacterModifier)hoverboard2).stop = CharacterModifier.StopSignal.STOP;
			_followingGuard.MuteProximityLoop();
			_followingGuard.ResetCatchUp();
			Character character = _character;
			if (~(character._isStumbling ? 1u : 0u) == 0)
			{
				character.StopStumble();
			}
			GameStats gameStats = GameStats.Instance;
			gameStats.RemoveHoverBoardPowerup();
			object obj = 1;
		}
		else if (~(IsRunningOnTutorialTrack__BackingField ? 1u : 0u) == 0)
		{
			object obj = 0;
			if (!goingBackToCheckpoint)
			{
				IEnumerator routine = BackToCheckPointSequence();
				Coroutine coroutine = StartCoroutine(routine);
				obj = 1;
			}
		}
		else
		{
			canRevive = true;
			GameStats gameStats2 = GameStats.Instance;
			gameStats2._isPausedPowerups = true;
			isDead = true;
			MovingTrain.ActivateAutoPilot();
			FollowingGuard followingGuard = _followingGuard;
			if (~(followingGuard.isShowing ? 1u : 0u) == 0)
			{
				CharacterRendering characterRendering2 = _characterRendering;
				SafeAnimation characterSafeAnimation = characterRendering2._characterSafeAnimation;
				AnimationState animationState = characterSafeAnimation._animation.get_Item("death_movingTrain");
				if (animationState.enabled)
				{
					_followingGuard.HitByTrainSequence();
				}
				else
				{
					Character character2 = _character;
					object obj2 = character2.__trackIndex * 20;
					float pos = character2.x - (float)obj2;
					_followingGuard.CatchPlayer(pos);
				}
			}
			_followingGuard.enabled = false;
			StopAllCoroutines();
			ChangeState(null, GameStateCoroutineType.SwitchToDieStateWhenGrounded);
			object obj = 0;
		}
		if (Game.m_OnPlayerDied != null)
		{
			Action<bool> onPlayerDied = Game.m_OnPlayerDied;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v139 @ S0_v35 (System.Action`1<System.Boolean>)+C] (should have been resolved before IL gen)");
		}
		if (Game.m_OnRunEnded != null)
		{
			Action<bool> onRunEnded = Game.m_OnRunEnded;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v194 @ S0_v28 (System.Action`1<System.Boolean>)+C] (should have been resolved before IL gen)");
		}
	}

	public void Revive()
	{
		_elapsedRunDuration = 0f;
		ResetEnemy();
		_character.Revive();
		GameStats gameStats = GameStats.Instance;
		gameStats.ResetRun();
		throw new NullReferenceException();
	}

	public void ResetEnemy()
	{
		if (_followingGuard != null)
		{
			_followingGuard.enabled = true;
			_followingGuard.MuteProximityLoop();
			_followingGuard.ResetCatchUp();
			_followingGuard.ResetModelRootPosition();
			_followingGuard.ShowEnemies(vis: false);
		}
	}

	public void DisableEnemy()
	{
		_followingGuard.StopAllCoroutines();
		_followingGuard.ResetCatchUp();
		_followingGuard.MuteProximityLoop();
		_followingGuard.enabled = false;
		_followingGuard.ShowEnemies(vis: false);
	}

	public void EnableEnemy()
	{
		ResetEnemy();
	}

	public void LockGameSpeedTo(float gameSpeed = -1f)
	{
		Game game = Instance;
		game._isLockedGameSpeed = true;
		__currentLevelSpeed = gameSpeed;
		__currentSpeed = gameSpeed;
		Action<float> onSpeedChanged = this.m_OnSpeedChanged;
		if (this.m_OnSpeedChanged != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v22 @ S0_v12 (System.Action`1<System.Single>)+C] (should have been resolved before IL gen)");
		}
	}

	public void UnlockGameSpeed()
	{
		Game game = Instance;
		game._isLockedGameSpeed = false;
	}

	public void SetGameSpeed(float gameSpeed)
	{
		__currentLevelSpeed = gameSpeed;
		__currentSpeed = gameSpeed;
		Action<float> onSpeedChanged = this.m_OnSpeedChanged;
		if (this.m_OnSpeedChanged != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v7 @ S0_v4 (System.Action`1<System.Single>)+C] (should have been resolved before IL gen)");
		}
	}

	public IEnumerator SkipRevive()
	{
		_ = 0;
		IEnumerator result = default;
		return result;
	}

	private void LoadFactories()
	{
		GameObject[] menuFactories = _menuFactories;
		if (menuFactories[0] == null)
		{
			GameObject[] menuFactories2 = _menuFactories;
			GameObject gameObject = UnityEngine.Object.Instantiate(characterModelPreviewFactoryPrefab);
			throw new ArrayTypeMismatchException();
		}
	}

	public void TriggerPause(bool pauseGame)
	{
		//IL_0045: Expected VT, but got Obj
		//IL_004e: Expected VT, but got Obj
		//IL_0068: Expected F4, but got I
		//IL_0068: Expected Obj, but got VT
		//IL_0019: Expected VT, but got Obj
		//IL_0027: Expected Obj, but got VT
		_isPaused = pauseGame;
		if (pauseGame)
		{
			ingameTouchDetection = false;
			_00210 val = (_00210)SingletonMonobehavior<>.Instance;
			((TimeScaleManager)val).TimeScale = 0f;
		}
		else
		{
			ingameTouchDetection = true;
			_00210 val2 = (_00210)SingletonMonobehavior<>.Instance;
			_00210 val3 = (_00210)SingletonMonobehavior<>.Instance;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S1_v10 (T)+10]");
			((TimeScaleManager)val2).TimeScale = 0f;
		}
		Action<bool> onPauseChange = this.m_OnPauseChange;
		if (this.m_OnPauseChange != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v37 @ S0_v9 (System.Action`1<System.Boolean>)+C] (should have been resolved before IL gen)");
		}
	}

	public void RewardCoin()
	{
		int coinMultiplier = _gameStats.CoinMultiplier;
		_gameStats.CoinsCollectedIncrement(coinMultiplier);
		if (_character.IsAboveGroundOfCharacterRoute)
		{
			_gameStats.CoinsInAirIncrement();
		}
		JetpackState jetpackState = JetpackState.Instance;
		if (~(jetpackState.isActive ? 1u : 0u) == 0)
		{
			_gameStats.CoinsWithJetpackIncrement();
		}
		PogoStickState pogoStickState = PogoStickState.Instance;
		if (~(pogoStickState.isActive ? 1u : 0u) == 0)
		{
			_gameStats.CoinsWithPogoStickIncrement();
		}
		Character character = _character;
		if (character.__trackIndex != 0)
		{
			if (character.__trackIndex != 1)
			{
				if (character.__trackIndex == 2)
				{
					_gameStats.CoinsCollectedOnRightTrackIncrement();
				}
			}
			else
			{
				_gameStats.CoinsCollectedOnCenterTrackIncrement();
			}
		}
		else
		{
			_gameStats.CoinsCollectedOnLeftTrackIncrement();
		}
	}

	private IEnumerator BackToCheckPointSequence()
	{
		_ = 0;
		IEnumerator result = default;
		return result;
	}

	private IEnumerator EnableCharacterDayEventAnimation()
	{
		_ = 0;
		IEnumerator result = default;
		return result;
	}

	private IEnumerator DebugRepeatedlySwipeLeftRightCoroutine()
	{
		_ = 0;
		IEnumerator result = default;
		return result;
	}

	private float Speed(float time, SpeedInfo speedInfo)
	{
		SpeedInfo speedInfo2 = speed;
		if (time < speedInfo2.rampUpDuration)
		{
			float num = speedInfo.max - speedInfo.min;
			float num2 = time / speedInfo2.rampUpDuration;
			float num3 = num * num2;
			return speedInfo.min + num3;
		}
		return speedInfo.max;
	}

	public float GetSpeedAtTime(float t)
	{
		return Speed(t, _currentSpeedInfo);
	}

	private IEnumerator StumbleDeathSequence()
	{
		_ = 0;
		IEnumerator result = default;
		return result;
	}

	private void OnCatchPlayer(string currentCharacterCaught, float catchUpTime, float waitTime)
	{
		_waitTimeBeforeScreen = reviveWaitTime;
	}

	private IEnumerator SwitchToDieStateWhenGrounded()
	{
		_ = 0;
		IEnumerator result = default;
		return result;
	}

	private IEnumerator DieSequence()
	{
		_ = 0;
		IEnumerator result = default;
		return result;
	}

	private IEnumerator DelayGameOverScreen()
	{
		_ = 0;
		IEnumerator result = default;
		return result;
	}

	private unsafe void SetMenuCamera()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Expected Obj, but got Unknown
		//IL_007b: Expected Obj, but got I
		//IL_0098: Expected Obj, but got I
		//IL_00ac: Expected I, but got Obj
		//IL_0138: Unknown result type (might be due to invalid IL or missing references)
		//IL_013d: Expected VT, but got Unknown
		//IL_01b4: Expected F4, but got I
		//IL_01af: Expected native int or pointer, but got VT
		//IL_01e0: Expected F4, but got I
		//IL_01db: Expected native int or pointer, but got VT
		//IL_01f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fb: Expected VT, but got Unknown
		object obj = default;
		Quaternion quaternion = (Quaternion)(obj - 112);
		_ = 0;
		_ = 0;
		_characterCamera.SetCurrentCharacterState(null);
		Vector3 currentTransformPosition = _character.CurrentTransformPosition;
		RunningState runningState = RunningState;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+60]");
		object obj2 = 0 + runningState.cameraOffset;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+64]");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v16 (SYBO.Subway.Characters.States.RunningState)+38]");
		object obj3 = num + 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+68]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v16 (SYBO.Subway.Characters.States.RunningState)+3C]");
		object obj4 = num2 + 0;
		nint num3 = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ S0_v29 (Il2CppClass<UnityEngine.Vector3>)+5C]");
		nint num4 = 0;
		float num5 = (float)Vector3.upVector * 0.8f;
		float num6 = (float)obj2 + num5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ S0_v30 (Il2CppStaticFields<UnityEngine.Vector3>)+1C]");
		float num7 = 0f * 0.8f;
		float num8 = (float)obj3 + num7;
		_ = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+58]");
		_ = 0;
		_ = 0f;
		_ = 0.37527075f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+50]");
		_ = 0;
		Vector3 euler = (Vector3)(quaternion + 32);
		Quaternion quaternion2 = Quaternion.Internal_FromEulerRad(euler);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+68]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+60]");
		_ = 0;
		CameraData defaultCameraDataForMenu = _characterCamera.GetDefaultCameraDataForMenu();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ S0_v30 (Il2CppStaticFields<UnityEngine.Vector3>)+20]");
		float num9 = 0f * 0.8f;
		float num10 = (float)obj4 + num9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+48]");
		((Quaternion*)(nint)quaternion)->z = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+38]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+40]");
		((Quaternion*)(nint)quaternion)->x = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+30]");
		_ = 0;
		Vector3 cameraLocalPosition = (Vector3)(quaternion + 16);
		_characterCamera.SetCameraDataForcefully(defaultCameraDataForMenu, cameraLocalPosition, quaternion);
	}

	private unsafe void StageMenuSequence()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_00d1: Expected I, but got Obj
		//IL_0103: Expected F4, but got I
		//IL_00fe: Expected native int or pointer, but got VT
		//IL_011e: Expected F4, but got I
		//IL_0119: Expected native int or pointer, but got VT
		object obj = default;
		Vector3 vector = (Vector3)(obj - 32);
		LoadFactories();
		_modifiers.Reset();
		_followingGuard.enabled = false;
		_followingGuard.ShowEnemies(vis: false);
		_followingGuard.StopAllCoroutines();
		_character.StopAllCoroutines();
		_character.Reset();
		nint num = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S0_v23 (Il2CppClass<UnityEngine.Vector3>)+5C]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S0_v24 (Il2CppStaticFields<UnityEngine.Vector3>)+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+18]");
		((Vector3*)(nint)vector)->z = 0f;
		_ = Vector3.zeroVector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+10]");
		((Vector3*)(nint)vector)->x = 0f;
		_character.CurrentTransformPosition = vector;
		SetMenuCamera();
		Action onStageMenuSequence = this.m_OnStageMenuSequence;
		if (this.m_OnStageMenuSequence != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v64.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
		}
		Character character = _character;
		SuperSneakers superSneakers = character._superSneakers;
		if (~(superSneakers.isActive ? 1u : 0u) == 0)
		{
			superSneakers.StopHack();
			Character character2 = _character;
			character2._isJumpingHigher = false;
		}
		JetpackState jetpackState = _jetpackState;
		jetpackState._canActivateLongHeadstart = false;
		jetpackState._activateTurboHeadstart = false;
		jetpackState._turboHeadstart = 0;
		GameStats gameStats = GameStats.Instance;
		gameStats.ClearPowerups();
		GameStats gameStats2 = GameStats.Instance;
		gameStats2._isPausedPowerups = false;
		_isLockedGameSpeed = false;
	}

	private IEnumerator GameIntro()
	{
		_ = 0;
		IEnumerator result = default;
		return result;
	}

	private IEnumerator TopMenu()
	{
		_ = 0;
		IEnumerator result = default;
		return result;
	}

	private IEnumerator Intro()
	{
		_ = 0;
		IEnumerator result = default;
		return result;
	}

	private void HandleProductionInput(InputType inputType)
	{
		//IL_0013: Expected Obj, but got I4
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Expected Obj, but got Unknown
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Expected Obj, but got Unknown
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Expected Obj, but got Unknown
		//IL_0142: Unknown result type (might be due to invalid IL or missing references)
		//IL_0147: Expected Obj, but got Unknown
		//IL_0164: Expected I, but got Obj
		//IL_016d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0172: Expected Obj, but got Unknown
		if (!(__characterState != null))
		{
			return;
		}
		object obj = inputType - 1;
		if (inputType != InputType.SwipeUp)
		{
			if ((nint)obj != 1)
			{
				if ((nint)obj != 2)
				{
					if ((nint)obj != 3)
					{
						if ((nint)obj != 4 && (nint)obj == 5)
						{
							CharacterState _characterState = __characterState;
							nint num = (nint)_characterState;
							object obj2 = _characterState + 96;
							Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v106 @ S1_v10 (Il2CppClass<SYBO.Subway.Characters.States.CharacterState>)+11C] (should have been resolved before IL gen)");
						}
					}
					else
					{
						CharacterState _characterState2 = __characterState;
						object obj3 = _characterState2 - -64;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v101 @ S2_v17+BC] (should have been resolved before IL gen)");
					}
				}
				else
				{
					CharacterState _characterState3 = __characterState;
					object obj4 = _characterState3 - -64;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v94 @ S2_v13+BC] (should have been resolved before IL gen)");
				}
			}
			else
			{
				CharacterState _characterState4 = __characterState;
				object obj5 = _characterState4 - -64;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v87 @ S2_v9+BC] (should have been resolved before IL gen)");
			}
		}
		else
		{
			CharacterState _characterState5 = __characterState;
			object obj6 = _characterState5 - -64;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v48 @ S2_v5+BC] (should have been resolved before IL gen)");
		}
	}

	public void ShowNextSceneViewCameraTargetType()
	{
		//IL_0026: Expected VT, but got Obj
		//IL_000e: Expected VT, but got Obj
		//IL_0017: Expected Obj, but got VT
		_00210 val = (_00210)SingletonMonobehavior<>.Instance;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v7 (T)+10]");
		if ((nint)0 != 0)
		{
			_00210 val2 = (_00210)SingletonMonobehavior<>.Instance;
			((SceneViewWindowManager)val2).ShowNextSceneViewCameraTargetType();
		}
	}

	public void ShowNextSceneViewZoomType()
	{
		//IL_0026: Expected VT, but got Obj
		//IL_000e: Expected VT, but got Obj
		//IL_0017: Expected Obj, but got VT
		_00210 val = (_00210)SingletonMonobehavior<>.Instance;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v7 (T)+10]");
		if ((nint)0 != 0)
		{
			_00210 val2 = (_00210)SingletonMonobehavior<>.Instance;
			((SceneViewWindowManager)val2).ShowNextSceneViewZoomType();
		}
	}

	private void InputManager_OnInputEvent(object sender, InputEventArgs inputEventArgs)
	{
		//IL_0026: Expected Obj, but got I
		if (!_isPaused)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [inputEventArgs @ L2 (System.Object)+8]");
			object obj = -1;
			if ((nint)obj <= 5)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [inputEventArgs @ L2 (System.Object)+8]");
				HandleProductionInput(InputType.None);
			}
		}
	}

	private void CoinManager_OnCoinCollected(object sender, EventArgs args)
	{
		RewardCoin();
	}

	private void RaiseOnCharacterStateChanged(CharacterStateChangedEventArgs characterStateChangedEventArgs)
	{
		EventHandler<CharacterStateChangedEventArgs> onCharacterStateChanged = this.m_OnCharacterStateChanged;
		if (this.m_OnCharacterStateChanged != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v2 @ S0_v2 (System.EventHandler`1<SYBO.Subway.CharacterStateChangedEventArgs>)+C] (should have been resolved before IL gen)");
		}
	}

	public void OnStumble(Character.StumbleType stumbleType, Character.StumbleHorizontalHit horizontalHit, Character.StumbleVerticalHit verticalHit, string colliderName, bool safeStumble)
	{
		Character character = _character;
		if (~(character._isStumbling ? 1u : 0u) == 0 && !safeStumble && __characterState != null)
		{
			IEnumerator routine = StumbleDeathSequence();
			Coroutine coroutine = StartCoroutine(routine);
		}
	}

	public void OnCriticalHit(Character.CriticalHitType type)
	{
		//IL_0030: Expected I, but got Obj
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Expected Obj, but got Unknown
		if (__characterState != null)
		{
			Sound sound = So.Instance.playSound(DieSound);
			CharacterState _characterState = __characterState;
			nint num = (nint)_characterState;
			object obj = _characterState + 88;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v47 @ S1_v7 (Il2CppClass<SYBO.Subway.Characters.States.CharacterState>)+114] (should have been resolved before IL gen)");
		}
	}

	private void _003CAwake_003Eb__189_0(bool value)
	{
		CharacterRendering characterRendering = _characterRendering;
		characterRendering._characterModel.StartEyeAnimations(UIModelController.ModelScreen.Character);
	}
}
