using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using SYBO.Common;
using SYBO.Common.Components.Singleton;
using SYBO.Common.Utilities;
using SYBO.Subway.Cameras;
using SYBO.Subway.Characters.States;
using SYBO.Subway.Coins;
using SYBO.Subway.Level;
using SYBO.Subway.Pickups;
using SYBO.Subway.Rendering;
using SYBO.Subway.Routes;
using SYBO.Subway.Utilities;
using UnityEngine;

namespace SYBO.Subway.Characters;

public class Character : MonoBehaviour
{
	public enum StumbleState
	{
		Standard,
		Safe,
		None
	}

	public enum StumbleHorizontalHit
	{
		Left,
		LeftCorner,
		Center,
		RightCorner,
		Right
	}

	public enum StumbleVerticalHit
	{
		Upper,
		Middle,
		Lower
	}

	public enum StumbleType
	{
		Normal,
		Bush,
		Side
	}

	public delegate void OnStumbleDelegate(StumbleType stumbleType, StumbleHorizontalHit horizontalHit, StumbleVerticalHit verticalHit, string colliderName, bool safeStumble);

	public enum DeathCause
	{
		None,
		RepeatedStumble,
		CriticalHit,
		KillSwitch
	}

	public enum ObstacleType
	{
		None,
		Sides,
		MinorObstacle,
		Train,
		MovingTrain,
		TrainRamp,
		BarrierStandard,
		BarrierJump,
		BarrierJumpHigh,
		BarrierRoll,
		Pillar,
		Gates,
		StationPlatform,
		Blocker,
		Environment
	}

	public enum ObstaclePassType
	{
		None,
		Roll,
		Jump,
		JumpHigh
	}

	public enum CriticalHitType
	{
		Train,
		Barrier,
		MovingTrain,
		None
	}

	public delegate void OnCriticalHitDelegate(CriticalHitType type);

	public delegate void OnReviveDelegate();

	public delegate void OnJumpDelegate(float jumpHeight, bool willPlaySound);

	public delegate void OnDoubleJumpDelegate();

	public delegate void OnJumpIfHitByTrainDelegate();

	public delegate void OnHangtimeDelegate();

	public delegate void OnRollDelegate();

	public delegate void OnRollGuardDelegate();

	public delegate void OnHitByTrainDelegate();

	public enum OnChangeTrackDirection
	{
		Left,
		Right
	}

	public delegate void OnChangeTrackDelegate(OnChangeTrackDirection direction);

	public delegate void OnTutorialMoveBackToCheckPointDelegate(float duration);

	public delegate void OnTutorialStartFromCheckPointDelegate();

	public delegate void OnPassedObstacleDelegate(ObstaclePassType type);

	public delegate void OnJumpOverTrainDelegate();

	public delegate void OnTeleboardStartDelegate(float duration, Vector3 offset, float gameSpeed);

	public delegate void OnGliderEndDelegate();

	public delegate void OnResetTeleportFXDelegate();

	private struct SuperSneakersJump
	{
		public float z_start;

		public float z_length;

		public float z_end;

		public float y_start;
	}

	private enum ImpactX
	{
		Left,
		Middle,
		Right
	}

	private enum ImpactY
	{
		Upper,
		Middle,
		Lower
	}

	private enum ImpactZ
	{
		Before,
		Middle,
		After
	}

	private sealed class _003CToggleDustWithDelay_003Ed__342(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public float delay;

		public Character _003C_003E4__this;

		object IEnumerator<object>.Current => _003C_003E2__current;

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			int num;
			bool result;
			if (_003C_003E1__state != 0)
			{
				if (_003C_003E1__state != 1)
				{
					bool flag = _003C_003E1__state == 2;
					num = -1;
					result = false;
					if (!flag)
					{
						result = false;
						goto IL_0117;
					}
				}
				else
				{
					Character character = _003C_003E4__this;
					_003C_003E1__state = -1;
					Action<bool> onToggleDust = character.OnToggleDust;
					if (character.OnToggleDust != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v34 @ S0_v26 (System.Action`1<System.Boolean>)+C] (should have been resolved before IL gen)");
					}
					character._longMagnet.Deactivate();
					_003C_003E2__current = null;
					num = 2;
					result = true;
				}
			}
			else
			{
				_003C_003E1__state = -1;
				_ = delay;
				object obj = default;
				_003C_003E2__current = obj;
				num = 1;
				result = true;
			}
			_003C_003E1__state = num;
			goto IL_0117;
			IL_0117:
			return result;
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

	private sealed class _003C_003Ec__DisplayClass358_0
	{
		public Character _003C_003E4__this;

		public float trackIndexPositionBegin;

		public int newTrackIndex;

		public float startX;

		public float endX;

		public float dir;

		public float startRotation;

		internal unsafe void _003CChangeTrackCoroutine_003Eb__0(float t)
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected VT, but got Unknown
			//IL_01cf: Unknown result type (might be due to invalid IL or missing references)
			//IL_01d4: Expected VT, but got Unknown
			//IL_0203: Expected F4, but got I
			//IL_01fe: Expected native int or pointer, but got VT
			//IL_0225: Expected F4, but got I
			//IL_0220: Expected native int or pointer, but got VT
			object obj = default;
			Quaternion quaternion = (Quaternion)(obj - 80);
			Character character = _003C_003E4__this;
			float num = (float)newTrackIndex - trackIndexPositionBegin;
			float num2 = Math.Min(t, 1f);
			bool flag = t < 0f;
			float num3 = 0f;
			if (!flag)
			{
				num3 = num2;
			}
			float num4 = num * num3;
			float trackIndexPosition = trackIndexPositionBegin + num4;
			character._trackIndexPosition = trackIndexPosition;
			Character character2 = _003C_003E4__this;
			float num5 = endX - startX;
			float num6 = num5 * num3;
			float x = startX + num6;
			character2.x = x;
			Character character3 = _003C_003E4__this;
			float num7 = pMath.Bell(t);
			float num8 = num7 * dir;
			Character character4 = _003C_003E4__this;
			float num9 = num8 * character4._characterAngle;
			float num10 = 0f - startRotation;
			float num11 = num10 * num3;
			float num12 = startRotation + num11;
			float characterRotation = num9 + num12;
			character3._characterRotation = characterRotation;
			Character character5 = _003C_003E4__this;
			float num13 = character5._characterRotation * ((float)Math.PI / 180f);
			_ = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+38]");
			_ = 0;
			_ = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+30]");
			_ = 0;
			Vector3 euler = (Vector3)(quaternion + 16);
			Quaternion quaternion2 = Quaternion.Internal_FromEulerRad(euler);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+48]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+48]");
			((Quaternion*)(nint)quaternion)->z = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+40]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+40]");
			((Quaternion*)(nint)quaternion)->x = 0f;
			character5._characterRoot.localRotation = quaternion;
		}
	}

	private sealed class _003CChangeTrackCoroutine_003Ed__358(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public Character _003C_003E4__this;

		public int move;

		public float duration;

		private _003C_003Ec__DisplayClass358_0 _003C_003E8__1;

		object IEnumerator<object>.Current => _003C_003E2__current;

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_00fd: Expected F4, but got I
			//IL_0112: Expected F4, but got I
			//IL_0158: Expected Obj, but got I
			//IL_0519: Expected F4, but got I
			//IL_0314: Expected Obj, but got I
			//IL_01a2: Expected Obj, but got I
			//IL_0276: Expected Obj, but got I
			Character character = _003C_003E4__this;
			if (_003C_003E1__state != 0)
			{
				if (_003C_003E1__state == 1)
				{
					_003C_003E1__state = -1;
					int num = move;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (SYBO.Subway.Characters.Character)+164]");
					if ((nint)num != 0)
					{
						_ = 0;
					}
					_003C_003Ec__DisplayClass358_0 obj = _003C_003E8__1;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (SYBO.Subway.Characters.Character)+AC]");
					if ((nint)0 != obj.newTrackIndex)
					{
						_ = obj.newTrackIndex;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (SYBO.Subway.Characters.Character)+AC]");
						_ = 0;
					}
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (SYBO.Subway.Characters.Character)+160]");
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (SYBO.Subway.Characters.Character)+160]");
						IEnumerator routine = character.ChangeTrackCoroutine(0, duration);
						Coroutine coroutine = character.StartCoroutine(routine);
					}
				}
			}
			else
			{
				_003C_003E1__state = -1;
				_003C_003Ec__DisplayClass358_0 obj2 = default;
				_003C_003E8__1 = obj2;
				_003C_003Ec__DisplayClass358_0 obj3 = _003C_003E8__1;
				obj3._003C_003E4__this = _003C_003E4__this;
				int num2 = move;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (SYBO.Subway.Characters.Character)+164]");
				if ((nint)num2 != 0)
				{
					_ = 0;
					_ = move;
					_003C_003Ec__DisplayClass358_0 obj4 = _003C_003E8__1;
					int num3 = move;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (SYBO.Subway.Characters.Character)+16C]");
					int newTrackIndex = (int)((nint)num3 + (nint)0);
					obj4.newTrackIndex = newTrackIndex;
					_003C_003Ec__DisplayClass358_0 obj5 = _003C_003E8__1;
					float num4 = obj5.newTrackIndex;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (SYBO.Subway.Characters.Character)+170]");
					float num5 = num4 - 0f;
					_003C_003Ec__DisplayClass358_0 obj6 = _003C_003E8__1;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (SYBO.Subway.Characters.Character)+170]");
					obj6.trackIndexPositionBegin = 0f;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (SYBO.Subway.Characters.Character)+4C]");
					obj6.startX = 0f;
					float endX = (float)obj6.newTrackIndex * 20f;
					obj6.endX = endX;
					_003C_003Ec__DisplayClass358_0 obj7 = _003C_003E8__1;
					int newTrackIndex2 = obj7.newTrackIndex;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (SYBO.Subway.Characters.Character)+16C]");
					object obj8 = (nint)newTrackIndex2 - (nint)0;
					bool flag = (nint)obj8 > -1;
					float dir = 1f;
					if (!flag)
					{
						dir = -1f;
					}
					obj7.dir = dir;
					_003C_003Ec__DisplayClass358_0 obj9 = _003C_003E8__1;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (SYBO.Subway.Characters.Character)+168]");
					obj9.startRotation = 0f;
					if (obj9.newTrackIndex <= -1)
					{
						_ = 1;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (SYBO.Subway.Characters.Character)+178]");
						object obj10 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v220 @ S0_v60+30]");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (SYBO.Subway.Characters.Character)+104]");
						if ((nint)0 == 0)
						{
							character.HandleStumble(StumbleType.Side, StumbleHorizontalHit.Left, StumbleVerticalHit.Middle, "side");
							return false;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (SYBO.Subway.Characters.Character)+104]");
						if ((nint)0 != 1)
						{
							goto IL_047d;
						}
					}
					else
					{
						if (obj9.newTrackIndex < 3)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (SYBO.Subway.Characters.Character)+21C]");
							object obj11 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (SYBO.Subway.Characters.Character)+21C]");
							if ((nint)0 != 0)
							{
								int num6 = move ^ -1;
								int num7 = num6 >> 31;
								Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v237 @ S1_v33+C] (should have been resolved before IL gen)");
								_003C_003Ec__DisplayClass358_0 obj12 = _003C_003E8__1;
								int newTrackIndex3 = obj12.newTrackIndex;
							}
							else
							{
								int newTrackIndex3 = obj9.newTrackIndex;
							}
							throw new ArgumentException();
						}
						_ = 1;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (SYBO.Subway.Characters.Character)+178]");
						object obj13 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v232 @ S0_v53+30]");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (SYBO.Subway.Characters.Character)+104]");
						if ((nint)0 == 0)
						{
							character.HandleStumble(StumbleType.Side, StumbleHorizontalHit.Right, StumbleVerticalHit.Middle, "side");
							return false;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (SYBO.Subway.Characters.Character)+104]");
						if ((nint)0 != 1)
						{
							goto IL_047d;
						}
					}
					bool flag2 = move < 1;
					StumbleHorizontalHit horizontalHit = (StumbleHorizontalHit)((flag2 ? 1u : 0u) << 2);
					character.RequestSafeStumble(StumbleType.Side, horizontalHit, StumbleVerticalHit.Middle, "setpiece_side");
					return false;
				}
			}
			goto IL_047d;
			IL_047d:
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

	private sealed class _003CMoveCharacterToPosition_003Ed__359(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public Character _003C_003E4__this;

		public float newX;

		public float newZ;

		public float time;

		object IEnumerator<object>.Current => _003C_003E2__current;

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_0075: Expected Obj, but got I
			//IL_009c: Expected Obj, but got I
			//IL_00ac: Expected Obj, but got I
			//IL_0133: Expected Obj, but got I
			//IL_0143: Expected Obj, but got I
			//IL_01db: Expected Obj, but got I
			//IL_01f4: Expected Obj, but got I
			Character character = _003C_003E4__this;
			if (_003C_003E1__state != 0)
			{
				if (_003C_003E1__state == 1)
				{
					_003C_003E1__state = -1;
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (SYBO.Subway.Characters.Character)+C0]");
					((Collider)0).enabled = true;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (SYBO.Subway.Characters.Character)+224]");
					object obj = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (SYBO.Subway.Characters.Character)+224]");
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v68 @ S0_v45+C] (should have been resolved before IL gen)");
					}
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (SYBO.Subway.Characters.Character)+178]");
					RunningState runningState = ((Game)0).RunningState;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (SYBO.Subway.Characters.Character)+178]");
					((Game)0).CharacterState = runningState;
				}
				return false;
			}
			_003C_003E1__state = -1;
			_ = _003C_003E4__this;
			_ = newX;
			_ = newZ;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (SYBO.Subway.Characters.Character)+4C]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (SYBO.Subway.Characters.Character)+54]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (SYBO.Subway.Characters.Character)+178]");
			((Game)0).CharacterState = null;
			_ = 1;
			_ = 1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (SYBO.Subway.Characters.Character)+C0]");
			((Collider)0).enabled = false;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (SYBO.Subway.Characters.Character)+220]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (SYBO.Subway.Characters.Character)+220]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v122 @ S0_v26+C] (should have been resolved before IL gen)");
			}
			throw new ArgumentException();
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

	private sealed class _003CStumbleDecay_003Ed__375(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public Character _003C_003E4__this;

		object IEnumerator<object>.Current => _003C_003E2__current;

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			Character character = _003C_003E4__this;
			if (_003C_003E1__state != 0)
			{
				if (_003C_003E1__state == 1)
				{
					_003C_003E1__state = -1;
					character.StopStumble();
				}
				return false;
			}
			_003C_003E1__state = -1;
			_ = character.stumbleDecayTime;
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

	private sealed class _003CLaneSwitchJump_003Ed__379(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public Character _003C_003E4__this;

		public float jumpHeight;

		public Vector3 start;

		public Vector3 end;

		public float jumpsPerLaneSwitch;

		private bool _003ChasLanded_003E5__2;

		private bool _003CjumpDone_003E5__3;

		object IEnumerator<object>.Current => _003C_003E2__current;

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
		}

		private unsafe bool MoveNext()
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected VT, but got Unknown
			//IL_0100: Expected Obj, but got I
			//IL_011d: Expected Obj, but got I
			//IL_01c6: Expected F4, but got I
			//IL_01c1: Expected native int or pointer, but got VT
			//IL_01ed: Expected F4, but got I
			//IL_01e8: Expected native int or pointer, but got VT
			//IL_0208: Invalid comparison between Obj and F4
			//IL_029c: Invalid comparison between Obj and F4
			object obj = default;
			Vector3 vector = (Vector3)(obj - 48);
			Character character = _003C_003E4__this;
			if (_003C_003E1__state != 0)
			{
				if (_003C_003E1__state != 1)
				{
					goto IL_0288;
				}
				_003C_003E1__state = -1;
			}
			else
			{
				_003ChasLanded_003E5__2 = false;
				_003C_003E1__state = -1;
				OnJumpDelegate onJump = character.m_OnJump;
				if (character.m_OnJump != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v22.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
				}
			}
			if (!_003CjumpDone_003E5__3)
			{
				Transform transform = character._characterController.transform;
				Vector3 position = transform.position;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+28]");
				nint num = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Characters.Character+<LaneSwitchJump>d__379)+20]");
				object obj2 = num - 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Characters.Character+<LaneSwitchJump>d__379)+2C]");
				nint num2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Characters.Character+<LaneSwitchJump>d__379)+20]");
				object obj3 = num2 - 0;
				object obj4 = obj2 / obj3;
				float num3 = (float)obj4 / jumpsPerLaneSwitch;
				float num4 = num3 * 4f;
				float num5 = 1f - num3;
				float num6 = num4 * num5;
				float num7 = num6 * jumpHeight;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Characters.Character+<LaneSwitchJump>d__379)+1C]");
				float num8 = 0f + num7;
				Transform transform2 = character._characterController.transform;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+28]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+18]");
				((Vector3*)(nint)vector)->z = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+20]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+10]");
				((Vector3*)(nint)vector)->x = 0f;
				transform2.position = vector;
				if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj4) >= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)1f))
				{
					_003CjumpDone_003E5__3 = true;
				}
				if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj4) >= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)0.8f) && !_003ChasLanded_003E5__2)
				{
					Action<Character> onLanding = character.m_OnLanding;
					if (character.m_OnLanding != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v178 @ S0_v39 (System.Action`1<SYBO.Subway.Characters.Character>)+C] (should have been resolved before IL gen)");
					}
					_003ChasLanded_003E5__2 = true;
				}
				_003C_003E2__current = null;
				_003C_003E1__state = 1;
			}
			goto IL_0288;
			IL_0288:
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

	private sealed class _003CResetAfterRouteDelayed_003Ed__406(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public Character _003C_003E4__this;

		public bool isRouteDestructing;

		object IEnumerator<object>.Current => _003C_003E2__current;

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_0052: Expected I4, but got I8
			if (_003C_003E1__state != 0)
			{
				if (_003C_003E1__state == 1)
				{
					_003C_003E1__state = -1;
					_003C_003E4__this.ResetAfterRoute(isRouteDestructing);
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

	private static Character _instance;

	private const float DEBUG_JUMP_HEIGHT = 100f;

	private const float _HEIGHT_CONSIDERED_IS_ABOVE_ROUTES_GROUND = 20f;

	private float _glideTime;

	private AnimationCurve _glideVerticalSpeed;

	public CapsuleCollider CharacterTrigger;

	public CollisionNotifier CharacterTriggerNotifier;

	public CollisionNotifier CoinMagnetCollider;

	public CollisionNotifier CoinMagnetLongCollider;

	public ParticleSystem HoverboardCrashParticleSystem;

	public ParticleSystem MysteryPowerupParticleSystem;

	public ParticleSystem TurboHeadstartParticleSystem;

	public float ColliderTrackWidth;

	public CharacterPickupParticles CharacterPickupParticleSystem;

	public bool ImmuneToCriticalHit;

	public float LastGroundedY;

	public float SubwayMaxY;

	public bool StopColliding;

	public float JumpHeight;

	public float x;

	private ReviveFX _reviveFX;

	public float z;

	private bool _killSwitchEnabled;

	public AnimationCurve superSneakersJumpCurve;

	public float hitPoistionDistance;

	public float superSneakersJumpApexRatio;

	public float gliderGravity;

	public float gravity;

	public float jumpHeightNormal;

	public float jumpHeightSuperSneakers;

	public float verticalFallSpeedLimit;

	public float stumbleCornerTolerance;

	public float stumbleDecayTime;

	public bool inAirJump;

	public Variable<bool> IsGrounded;

	public float verticalSpeed;

	public float sameLaneTimeStamp;

	public float SetPieceForgivingJumpTime;

	public float SetPieceForgivingJumpHeight;

	public bool SetPieceForcedForgivingJump;

	public Action OnSetPieceForgivingJump;

	public const float TRACK_SWITCH_SPEED_CONSTANT_DEFAULT = 30f;

	public const float TRACK_SWITCH_SPEED_CONSTANT_TELEBORD = 20f;

	private const float RampingDistance = 50f;

	private bool _isStumbling;

	private bool _isFalling;

	private bool __isJumping;

	private bool _isRolling;

	private bool _isTucked;

	private bool _isInsideSubway;

	private int __trackIndex;

	private float _offsetFromFloorY;

	private int __trackIndexPrevious;

	private bool _isJumpingHigher;

	private bool _isTeleboard;

	private bool _isDoubleJumping;

	private bool _isGliderboard;

	private bool _isVTol;

	private CharacterController _characterController;

	private CharacterModel _characterModel;

	private CharacterCamera _characterCamera;

	private CharacterRendering _characterRendering;

	private Hoverboard _hoverboard;

	private LongMagnet _longMagnet;

	private SuperSneakers _superSneakers;

	private RunningState _runningState;

	private Transform _characterRoot;

	private VariableBool _squeezeCollider;

	private float _characterAngle;

	private Vector3 __previousFixedUpdateTransformPosition;

	private Vector3 __previousPreviousFixedUpdateTransformPosition;

	private StumbleState _stumbleState;

	public DeathCause LastDeathCause;

	private ObstacleType _lastObstacleType;

	public Action<bool> OnRouteDone;

	public Action<bool> OnToggleDust;

	public Action OnEnterRoute;

	public Action OnEnterRouteEnd;

	public Action OnExitRoute;

	private bool __isInLipFlight;

	private float _lastZ;

	private int _killSwitchUpdates;

	private Sound _currentlyPlayingGrindSound;

	private Vector3 _characterControllerCenter;

	private float _characterControllerHeight;

	private float _characterControllerSkinWidth;

	private Vector3 _characterColliderCenter;

	private float _characterColliderHeight;

	private int _initialTrackIndex;

	private int _trackMovement;

	private int _trackMovementNext;

	private int _ignoredMovement;

	private float _characterRotation;

	private int _trackIndexTarget;

	private float _trackIndexPosition;

	private bool _willSecondJump;

	private Game _game;

	private FollowingGuard _followingGuard;

	private RouteManager _routeManager;

	private float _originaljumpHeightSuperSneakers;

	private float _glideTimeLeft;

	private bool _vTolEnded;

	private bool _jumpUpperCollision;

	private float _jumpUpperCollisionColliderMinY;

	private bool _jumpUpperCollisionEvaded;

	private bool _movedSinceLastFixedUpdate;

	private Vector3 _posFixedUpdateLast;

	private Vector3 _posFixedUpdatePrevious;

	private HashSet<Collider> subwayColliders;

	private SuperSneakersJump? _superSneakersJump;

	private string _lastHitTag;

	private bool _startedJumpFromGround;

	private float _trainJumpSampleZ;

	private float _trainJumpSampleLength;

	private bool _trainJump;

	private float _verticalSpeed_jumpTolerance;

	private Layers _layers;

	private ObstaclePassType _lastObstaclePassType;

	private int _lastObstaclePassTrackIndex;

	private float _lastCheckpointTime;

	private OnStumbleDelegate m_OnStumble;

	private OnCriticalHitDelegate m_OnCriticalHit;

	private OnReviveDelegate m_OnRevive;

	private OnJumpDelegate m_OnJump;

	private OnDoubleJumpDelegate m_OnDoubleJump;

	private OnJumpIfHitByTrainDelegate m_OnJumpIfHitByTrain;

	private Action<Character> m_OnLanding;

	private OnHangtimeDelegate m_OnHangtime;

	private OnRollDelegate m_OnRoll;

	private OnRollGuardDelegate m_OnRollGuard;

	private OnHitByTrainDelegate m_OnHitByTrain;

	private OnChangeTrackDelegate m_OnChangeTrack;

	private OnTutorialMoveBackToCheckPointDelegate m_OnTutorialMoveBackToCheckPoint;

	private OnTutorialStartFromCheckPointDelegate m_OnTutorialStartFromCheckPoint;

	private OnPassedObstacleDelegate m_OnPassedObstacle;

	private OnJumpOverTrainDelegate m_OnJumpOverTrain;

	private OnTeleboardStartDelegate m_OnTeleboardStart;

	private OnGliderEndDelegate m_OnVTolEnd;

	private OnResetTeleportFXDelegate m_OnResetTeleportFX;

	public static Character Instance
	{
		get
		{
			//IL_0014: Expected VT, but got Obj
			if (_instance == null)
			{
				Type typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)typeof(Character));
				UnityEngine.Object obj = UnityEngine.Object.FindObjectOfType(typeFromHandle);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @238");
				Character instance = default;
				_instance = instance;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @238");
			}
			return _instance;
		}
	}

	public ReviveFX ReviveFX => _reviveFX;

	public bool KillSwitchEnabled
	{
		get
		{
			return _killSwitchEnabled;
		}
		set
		{
			_killSwitchEnabled = value;
		}
	}

	public bool IsStumbling
	{
		get
		{
			return _isStumbling;
		}
		set
		{
			_isStumbling = value;
		}
	}

	public bool IsChangingTracks => _trackMovement != 0;

	public int TrackMovement => _trackMovement;

	public bool IsFalling
	{
		get
		{
			return _isFalling;
		}
		set
		{
			_isFalling = value;
		}
	}

	public bool IsJumping
	{
		get
		{
			return __isJumping;
		}
		set
		{
			__isJumping = value;
		}
	}

	public bool IsRolling => _isRolling;

	public bool IsTucked => _isTucked;

	public bool IsInsideSubway => _isInsideSubway;

	public int TrackIndexCurrent
	{
		get
		{
			return __trackIndex;
		}
		set
		{
			if (value != __trackIndex)
			{
				__trackIndex = value;
				__trackIndexPrevious = __trackIndex;
			}
		}
	}

	public float OffsetFromFloorY
	{
		get
		{
			return _offsetFromFloorY;
		}
		private set
		{
			_offsetFromFloorY = value;
		}
	}

	public int TrackIndexPrevious
	{
		get
		{
			return __trackIndexPrevious;
		}
		private set
		{
			__trackIndexPrevious = value;
		}
	}

	public unsafe bool IsAboveGroundOfCharacterRoute
	{
		get
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected VT, but got Unknown
			//IL_0054: Expected Obj, but got I
			//IL_0100: Invalid comparison between Obj and F4
			//IL_00aa: Expected F4, but got I
			//IL_00a5: Expected native int or pointer, but got VT
			//IL_00cc: Expected F4, but got I
			//IL_00c7: Expected native int or pointer, but got VT
			//IL_00f2: Expected Obj, but got I
			object obj = default;
			Vector3 vector = (Vector3)(obj - 48);
			Transform transform = base.transform;
			Vector3 position = transform.position;
			bool isCharacterInAnyRoute = _routeManager.IsCharacterInAnyRoute;
			bool flag = !isCharacterInAnyRoute;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+24]");
			object obj2 = 0;
			if (!flag)
			{
				RouteManager routeManager = _routeManager;
				Transform transform2 = base.transform;
				Vector3 position2 = transform2.position;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+28]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+28]");
				((Vector3*)(nint)vector)->z = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+20]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+20]");
				((Vector3*)(nint)vector)->x = 0f;
				Vector3 relativePosition = routeManager._characterRoute.GetRelativePosition(vector);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+24]");
				obj2 = 0;
			}
			return System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj2) > System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)20f);
		}
	}

	public bool IsJumpingHigher
	{
		get
		{
			if (~(_isJumpingHigher ? 1u : 0u) == 0)
			{
				return true;
			}
			Hoverboard hoverboard = _hoverboard;
			if (~(hoverboard.isActive ? 1u : 0u) != 0)
			{
				return false;
			}
			Hoverboard instance = Hoverboard.Instance;
			return instance.isJumper;
		}
		set
		{
			_isJumpingHigher = value;
		}
	}

	public bool IsTeleboard
	{
		get
		{
			if (~(_isTeleboard ? 1u : 0u) == 0)
			{
				return true;
			}
			Hoverboard hoverboard = _hoverboard;
			if (~(hoverboard.isActive ? 1u : 0u) != 0)
			{
				return false;
			}
			Hoverboard instance = Hoverboard.Instance;
			return instance.isTeleporter;
		}
		set
		{
			_isTeleboard = value;
		}
	}

	public bool IsDoubleJumping
	{
		get
		{
			bool result = true;
			if (!_isDoubleJumping)
			{
				result = true;
				if (!DoubleJump.doubleJumpEnabled)
				{
					Hoverboard hoverboard = _hoverboard;
					bool isDoubleJump = hoverboard.isDoubleJump;
					result = isDoubleJump;
				}
			}
			return result;
		}
		set
		{
			_isDoubleJumping = value;
		}
	}

	public bool IsGliderboard
	{
		get
		{
			if (~(_isGliderboard ? 1u : 0u) == 0)
			{
				return true;
			}
			Hoverboard hoverboard = _hoverboard;
			if (~(hoverboard.isActive ? 1u : 0u) != 0)
			{
				return false;
			}
			Hoverboard instance = Hoverboard.Instance;
			return instance.isGlider;
		}
		set
		{
			_isGliderboard = value;
		}
	}

	public bool IsVTol
	{
		get
		{
			if (~(_isVTol ? 1u : 0u) == 0)
			{
				return true;
			}
			Hoverboard hoverboard = _hoverboard;
			if (~(hoverboard.isActive ? 1u : 0u) != 0)
			{
				return false;
			}
			Hoverboard instance = Hoverboard.Instance;
			return instance.isVTol;
		}
		set
		{
			_isVTol = value;
		}
	}

	public CharacterController CharacterController => _characterController;

	public CharacterModel CharacterModel => _characterModel;

	public CharacterCamera CharacterCamera => _characterCamera;

	public CharacterRendering CharacterRendering => _characterRendering;

	public Hoverboard Hoverboard => _hoverboard;

	public LongMagnet LongMagnet => _longMagnet;

	public SuperSneakers SuperSneakers => _superSneakers;

	public RunningState RunningState => _runningState;

	public Transform CharacterRoot => _characterRoot;

	public VariableBool SqueezeCollider => _squeezeCollider;

	public float CharacterAngle => _characterAngle;

	public unsafe Bounds Bounds
	{
		get
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_004c: Expected VT, but got I
			//IL_0047: Expected native int or pointer, but got VT
			object obj2 = default;
			object obj = obj2 - 32;
			Bounds bounds = CharacterTrigger.bounds;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
			Bounds bounds2 = default;
			((Bounds*)(nint)bounds2)->m_Center = (Vector3)0;
			return bounds2;
		}
	}

	public StumbleState CurrentStumbleState
	{
		get
		{
			return _stumbleState;
		}
		set
		{
			_stumbleState = value;
		}
	}

	public unsafe Vector3 CurrentTransformPosition
	{
		get
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_003f: Expected F4, but got I
			//IL_003a: Expected native int or pointer, but got VT
			//IL_004c: Expected F4, but got Obj
			//IL_0047: Expected native int or pointer, but got VT
			object obj2 = default;
			object obj = obj2 - 16;
			Transform transform = base.transform;
			Vector3 position = transform.position;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
			Vector3 vector = default;
			((Vector3*)(nint)vector)->z = 0f;
			((Vector3*)(nint)vector)->x = (float)obj;
			return vector;
		}
		set
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected VT, but got Unknown
			//IL_0025: Expected native int or pointer, but got VT
			//IL_0037: Expected native int or pointer, but got VT
			object obj = default;
			Vector3 vector = (Vector3)(obj - 16);
			Transform transform = base.transform;
			((Vector3*)(nint)vector)->z = value.z;
			((Vector3*)(nint)vector)->x = value.x;
			transform.position = vector;
		}
	}

	public unsafe Vector3 PreviousFixedUpdateTransformPosition
	{
		get
		{
			//IL_000f: Expected F4, but got VT
			//IL_000a: Expected native int or pointer, but got VT
			//IL_0024: Expected F4, but got I
			//IL_001f: Expected native int or pointer, but got VT
			Vector3 vector = default;
			((Vector3*)(nint)vector)->x = (float)__previousFixedUpdateTransformPosition;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L1 (SYBO.Subway.Characters.Character)+F4]");
			((Vector3*)(nint)vector)->z = 0f;
			return vector;
		}
		set
		{
			//IL_00f4: Expected VT, but got F4
			float num = (float)__previousFixedUpdateTransformPosition - value.x;
			float num2 = num * num;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Characters.Character)+F0]");
			float num3 = 0f - value.y;
			float num4 = num3 * num3;
			float num5 = num2 + num4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Characters.Character)+F4]");
			float num6 = 0f - value.z;
			float num7 = num6 * num6;
			float num8 = num5 + num7;
			if (!(num8 < 9.9999994E-11f))
			{
				__previousPreviousFixedUpdateTransformPosition = __previousFixedUpdateTransformPosition;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Characters.Character)+F4]");
				_ = 0;
				__previousFixedUpdateTransformPosition = (Vector3)value.x;
				_ = value.z;
			}
		}
	}

	public unsafe Vector3 PreviousPreviousFixedUpdateTransformPosition
	{
		get
		{
			//IL_000f: Expected F4, but got VT
			//IL_000a: Expected native int or pointer, but got VT
			//IL_0024: Expected F4, but got I
			//IL_001f: Expected native int or pointer, but got VT
			Vector3 vector = default;
			((Vector3*)(nint)vector)->x = (float)__previousPreviousFixedUpdateTransformPosition;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L1 (SYBO.Subway.Characters.Character)+100]");
			((Vector3*)(nint)vector)->z = 0f;
			return vector;
		}
		private set
		{
			//IL_000f: Expected VT, but got F4
			__previousPreviousFixedUpdateTransformPosition = (Vector3)value.x;
			_ = value.z;
		}
	}

	public ObstacleType LastObstacleType => _lastObstacleType;

	public int IgnoredMovement
	{
		set
		{
			_ignoredMovement = value;
		}
	}

	public float TrackIndexPosition => _trackIndexPosition;

	public unsafe float CharacterColliderLeadingZ
	{
		get
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_0057: Unknown result type (might be due to invalid IL or missing references)
			//IL_005c: Expected VT, but got Unknown
			//IL_0065: Expected Ref, but got VT
			//IL_007b: Expected F4, but got I
			object obj2 = default;
			object obj = obj2 - 48;
			_ = 0;
			_ = 0;
			_ = 0;
			Bounds bounds = CharacterTrigger.bounds;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
			_ = 0;
			Bounds bounds2 = (Bounds)(obj + 24);
			Vector3 max = ((Bounds*)bounds2)->max;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
			return 0f;
		}
	}

	public bool IsInLipFlight
	{
		get
		{
			return __isInLipFlight;
		}
		set
		{
			__isInLipFlight = value;
		}
	}

	public bool IsVisibleShadow
	{
		get
		{
			return _characterModel.IsVisibleShadow;
		}
		set
		{
			_characterModel.IsVisibleShadow = value;
		}
	}

	public event OnStumbleDelegate OnStumble
	{
		add
		{
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected Obj, but got Unknown
			object obj = this + 496;
			Delegate obj2 = this.m_OnStumble;
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
			object obj = this + 496;
			Delegate obj2 = this.m_OnStumble;
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

	public event OnCriticalHitDelegate OnCriticalHit
	{
		add
		{
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected Obj, but got Unknown
			object obj = this + 500;
			Delegate obj2 = this.m_OnCriticalHit;
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
			object obj = this + 500;
			Delegate obj2 = this.m_OnCriticalHit;
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

	public event OnReviveDelegate OnRevive
	{
		add
		{
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected Obj, but got Unknown
			object obj = this + 504;
			Delegate obj2 = this.m_OnRevive;
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
			object obj = this + 504;
			Delegate obj2 = this.m_OnRevive;
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

	public event OnJumpDelegate OnJump
	{
		add
		{
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected Obj, but got Unknown
			object obj = this + 508;
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
			object obj = this + 508;
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

	public event OnDoubleJumpDelegate OnDoubleJump
	{
		add
		{
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected Obj, but got Unknown
			object obj = this + 512;
			Delegate obj2 = this.m_OnDoubleJump;
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
			object obj = this + 512;
			Delegate obj2 = this.m_OnDoubleJump;
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

	public event OnJumpIfHitByTrainDelegate OnJumpIfHitByTrain
	{
		add
		{
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected Obj, but got Unknown
			object obj = this + 516;
			Delegate obj2 = this.m_OnJumpIfHitByTrain;
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
			object obj = this + 516;
			Delegate obj2 = this.m_OnJumpIfHitByTrain;
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

	public event Action<Character> OnLanding
	{
		add
		{
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected Obj, but got Unknown
			object obj = this + 520;
			Delegate obj2 = this.m_OnLanding;
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
			object obj = this + 520;
			Delegate obj2 = this.m_OnLanding;
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

	public event OnHangtimeDelegate OnHangtime
	{
		add
		{
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected Obj, but got Unknown
			object obj = this + 524;
			Delegate obj2 = this.m_OnHangtime;
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
			object obj = this + 524;
			Delegate obj2 = this.m_OnHangtime;
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

	public event OnRollDelegate OnRoll
	{
		add
		{
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected Obj, but got Unknown
			object obj = this + 528;
			Delegate obj2 = this.m_OnRoll;
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
			object obj = this + 528;
			Delegate obj2 = this.m_OnRoll;
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

	public event OnRollGuardDelegate OnRollGuard
	{
		add
		{
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected Obj, but got Unknown
			object obj = this + 532;
			Delegate obj2 = this.m_OnRollGuard;
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
			object obj = this + 532;
			Delegate obj2 = this.m_OnRollGuard;
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

	public event OnHitByTrainDelegate OnHitByTrain
	{
		add
		{
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected Obj, but got Unknown
			object obj = this + 536;
			Delegate obj2 = this.m_OnHitByTrain;
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
			object obj = this + 536;
			Delegate obj2 = this.m_OnHitByTrain;
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

	public event OnChangeTrackDelegate OnChangeTrack
	{
		add
		{
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected Obj, but got Unknown
			object obj = this + 540;
			Delegate obj2 = this.m_OnChangeTrack;
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
			object obj = this + 540;
			Delegate obj2 = this.m_OnChangeTrack;
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

	public event OnTutorialMoveBackToCheckPointDelegate OnTutorialMoveBackToCheckPoint
	{
		add
		{
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected Obj, but got Unknown
			object obj = this + 544;
			Delegate obj2 = this.m_OnTutorialMoveBackToCheckPoint;
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
			object obj = this + 544;
			Delegate obj2 = this.m_OnTutorialMoveBackToCheckPoint;
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

	public event OnTutorialStartFromCheckPointDelegate OnTutorialStartFromCheckPoint
	{
		add
		{
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected Obj, but got Unknown
			object obj = this + 548;
			Delegate obj2 = this.m_OnTutorialStartFromCheckPoint;
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
			object obj = this + 548;
			Delegate obj2 = this.m_OnTutorialStartFromCheckPoint;
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

	public event OnPassedObstacleDelegate OnPassedObstacle
	{
		add
		{
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected Obj, but got Unknown
			object obj = this + 552;
			Delegate obj2 = this.m_OnPassedObstacle;
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
			object obj = this + 552;
			Delegate obj2 = this.m_OnPassedObstacle;
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

	public event OnJumpOverTrainDelegate OnJumpOverTrain
	{
		add
		{
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected Obj, but got Unknown
			object obj = this + 556;
			Delegate obj2 = this.m_OnJumpOverTrain;
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
			object obj = this + 556;
			Delegate obj2 = this.m_OnJumpOverTrain;
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

	public event OnTeleboardStartDelegate OnTeleboardStart
	{
		add
		{
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected Obj, but got Unknown
			object obj = this + 560;
			Delegate obj2 = this.m_OnTeleboardStart;
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
			object obj = this + 560;
			Delegate obj2 = this.m_OnTeleboardStart;
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

	public event OnGliderEndDelegate OnVTolEnd
	{
		add
		{
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected Obj, but got Unknown
			object obj = this + 564;
			Delegate obj2 = this.m_OnVTolEnd;
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
			object obj = this + 564;
			Delegate obj2 = this.m_OnVTolEnd;
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

	public event OnResetTeleportFXDelegate OnResetTeleportFX
	{
		add
		{
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected Obj, but got Unknown
			object obj = this + 568;
			Delegate obj2 = this.m_OnResetTeleportFX;
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
			object obj = this + 568;
			Delegate obj2 = this.m_OnResetTeleportFX;
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

	public void Initialize()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_00ad: Expected VT, but got Obj
		//IL_00bc: Expected Obj, but got VT
		object obj2 = default;
		object obj = obj2 - 48;
		_instance = this;
		CharacterRendering component = GetComponent<CharacterRendering>();
		_characterRendering = component;
		GameObject gameObject = base.gameObject;
		CharacterController component2 = gameObject.GetComponent<CharacterController>();
		_characterController = component2;
		Layers instance = Layers.Instance;
		_layers = instance;
		Game instance2 = Game.Instance;
		_game = instance2;
		CharacterController charactercontroller = Game.Charactercontroller;
		_characterController = charactercontroller;
		Hoverboard instance3 = Hoverboard.Instance;
		_hoverboard = instance3;
		LongMagnet component3 = _hoverboard.GetComponent<LongMagnet>();
		_longMagnet = component3;
		RunningState instance4 = RunningState.Instance;
		_runningState = instance4;
		_00210 val = (_00210)SingletonMonobehavior<>.Instance;
		_routeManager = (RouteManager)val;
		Renderer component4 = HoverboardCrashParticleSystem.GetComponent<Renderer>();
		Material material = component4.material;
		material.renderQueue = RenderQueues.TransparentOverlay;
		throw new ArgumentException();
	}

	public void RecreateCharacterModel()
	{
		GameObject obj = _characterModel.gameObject;
		UnityEngine.Object.Destroy(obj);
		CharacterModel characterModel = _characterRendering.RecreateCharacterModel();
		_characterModel = characterModel;
		Transform characterRoot = _characterModel.transform;
		_characterRoot = characterRoot;
	}

	protected void Awake()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		_instance = this;
		float skinWidth = _characterController.skinWidth;
		float num = skinWidth + 0.6000004f;
		Vector3 center = _characterController.center;
		float num2 = num;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4]");
		float num3 = num2 + 0f;
		float height = _characterController.height;
		float num4 = height * 0.5f;
		float offsetFromFloorY = num3 - num4;
		_offsetFromFloorY = offsetFromFloorY;
		Variable<bool> isGrounded = IsGrounded;
		throw new ArgumentException();
	}

	protected void OnDestroy()
	{
		if (_routeManager != null)
		{
			throw new ArgumentException();
		}
	}

	protected unsafe void FixedUpdate()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0105: Expected F4, but got I
		//IL_0100: Expected native int or pointer, but got VT
		//IL_0127: Expected F4, but got I
		//IL_0122: Expected native int or pointer, but got VT
		//IL_0095: Expected VT, but got I
		object obj = default;
		Vector3 vector = (Vector3)(obj + -64);
		if (~(_movedSinceLastFixedUpdate ? 1u : 0u) == 0)
		{
			_posFixedUpdatePrevious = _posFixedUpdateLast;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Characters.Character)+1A0]");
			_ = 0;
			Transform transform = base.transform;
			Vector3 position = transform.position;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+28]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+20]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+28]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+20]");
			_posFixedUpdateLast = (Vector3)0;
			_movedSinceLastFixedUpdate = false;
		}
		Transform transform2 = base.transform;
		Vector3 position2 = transform2.position;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+38]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+38]");
		((Vector3*)(nint)vector)->z = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+30]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+30]");
		((Vector3*)(nint)vector)->x = 0f;
		PreviousFixedUpdateTransformPosition = vector;
		CharacterTriggerNotifier.ClearFrame();
		CoinMagnetCollider.ClearFrame();
		CoinMagnetLongCollider.ClearFrame();
	}

	protected unsafe void Update()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_067f: Invalid comparison between I and F4
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Expected VT, but got Unknown
		//IL_009d: Expected VT, but got Obj
		//IL_06cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_06d1: Expected VT, but got Unknown
		//IL_0758: Unknown result type (might be due to invalid IL or missing references)
		//IL_075d: Expected VT, but got Unknown
		//IL_012c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0131: Expected VT, but got Unknown
		//IL_01b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bd: Expected VT, but got Unknown
		//IL_0232: Unknown result type (might be due to invalid IL or missing references)
		//IL_0237: Expected VT, but got Unknown
		//IL_02e7: Expected Obj, but got I
		//IL_0304: Expected Obj, but got I
		//IL_032e: Expected Obj, but got I
		//IL_0358: Expected Obj, but got I
		//IL_07c4: Expected F4, but got I
		//IL_07bf: Expected native int or pointer, but got VT
		//IL_07e6: Expected F4, but got I
		//IL_07e1: Expected native int or pointer, but got VT
		//IL_0442: Unknown result type (might be due to invalid IL or missing references)
		//IL_0447: Expected VT, but got Unknown
		//IL_0450: Unknown result type (might be due to invalid IL or missing references)
		//IL_0455: Expected VT, but got Unknown
		//IL_05d9: Expected Obj, but got I4
		object obj = default;
		Quaternion quaternion = (Quaternion)(obj - 288);
		_ = 0;
		_ = 0;
		Transform transform = base.transform;
		Vector3 position = transform.position;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+114]");
		if (0f < 0f)
		{
			Transform transform2 = base.transform;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+118]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+B8]");
			_ = 0;
			_ = 1065353216;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+110]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+B0]");
			_ = 0;
			Vector3 position2 = (Vector3)(quaternion + 128);
			transform2.position = position2;
		}
		Game game = _game;
		if (game._isPaused)
		{
			return;
		}
		_00210 val = (_00210)SingletonMonobehavior<>.Instance;
		float timeScale = Time.timeScale;
		if (timeScale == 0f)
		{
			return;
		}
		bool isAllowed = DebugSettings.IsAllowed;
		bool flag = !isAllowed;
		bool flag2 = false;
		if (!flag)
		{
			bool characterInvincible = DebugSettings.CharacterInvincible;
			flag2 = characterInvincible;
		}
		Quaternion characterModelLocalRotation = GetCharacterModelLocalRotation();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+D8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+D0]");
		_ = 0;
		Quaternion rotation = (Quaternion)(quaternion + 112);
		Vector3 vector = Quaternion.Internal_ToEulerRad(rotation);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+110]");
		float num = 0f * 57.29578f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+114]");
		float num2 = 0f * 57.29578f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+118]");
		float num3 = 0f * 57.29578f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+108]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+100]");
		_ = 0;
		Vector3 euler = (Vector3)(quaternion + 96);
		Vector3 vector2 = Quaternion.Internal_MakePositive(euler);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+D8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+D0]");
		_ = 0;
		Quaternion rotation2 = (Quaternion)(quaternion + 80);
		Vector3 vector3 = Quaternion.Internal_ToEulerRad(rotation2);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+110]");
		float num4 = 0f * 57.29578f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+114]");
		float num5 = 0f * 57.29578f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+118]");
		float num6 = 0f * 57.29578f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+108]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+100]");
		_ = 0;
		Vector3 euler2 = (Vector3)(quaternion - -64);
		Vector3 vector4 = Quaternion.Internal_MakePositive(euler2);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+118]");
		float num7 = 0f * ((float)Math.PI / 180f);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+108]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+114]");
		float num8 = 0f * ((float)Math.PI / 180f);
		_ = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+100]");
		_ = 0;
		Vector3 euler3 = (Vector3)(quaternion + 48);
		Quaternion quaternion2 = Quaternion.Internal_FromEulerRad(euler3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+118]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+D8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+110]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+D0]");
		_ = 0;
		float deltaTime = Time.deltaTime;
		float num9 = deltaTime * 90f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+A8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+C8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+A0]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+C0]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+E0]");
		nint num10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+F0]");
		object obj2 = num10 * 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+E4]");
		nint num11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+F4]");
		object obj3 = num11 * 0;
		object obj4 = obj2 + obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+E8]");
		nint num12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+F8]");
		object obj5 = num12 * 0;
		object obj6 = obj4 + obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+EC]");
		nint num13 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+FC]");
		object obj7 = num13 * 0;
		float value = (float)obj6 + (float)obj7;
		float num14 = Math.Abs(value);
		if (!(num14 < 1f))
		{
			num14 = 1f;
		}
		if (!(num14 > 0.999999f))
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @EAD");
			object obj9 = default;
			object obj8 = obj9 + obj9;
			float num15 = (float)obj8 * 57.29578f;
			if (num15 != 0f)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+E8]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+F8]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+E0]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+F0]");
				_ = 0;
				Quaternion a = (Quaternion)(quaternion + 32);
				Quaternion b = (Quaternion)(quaternion + 16);
				float val2 = num9 / num15;
				float t = Math.Min(val2, 1f);
				Quaternion quaternion3 = Quaternion.SlerpUnclamped(a, b, t);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+108]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+100]");
				_ = 0;
				goto IL_07a2;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+F8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+F0]");
		_ = 0;
		goto IL_07a2;
		IL_0844:
		_lastZ = z;
		return;
		IL_07a2:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+118]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+118]");
		((Quaternion*)(nint)quaternion)->z = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+110]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+110]");
		((Quaternion*)(nint)quaternion)->x = 0f;
		SetCharacterModelLocalRotation(quaternion);
		Game game2 = _game;
		CharacterModifierCollection modifiers = game2._modifiers;
		CharacterModifier hoverboard = modifiers.hoverboard;
		bool flag3 = hoverboard.stop != CharacterModifier.StopSignal.DONT_STOP && modifiers.IsActive(hoverboard);
		if (!flag2 && ~(_killSwitchEnabled ? 1u : 0u) == 0)
		{
			if (z == _lastZ)
			{
				Game game3 = _game;
				Variable<bool> isInGame = game3.IsInGame;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v440 @ S0_v127 (Variable`1<System.Boolean>)+8]");
				if ((nint)0 != 0)
				{
					Game game4 = _game;
					if (!game4._isInStumbleDeathSequence)
					{
						if (_killSwitchUpdates >= 1)
						{
							int killSwitchUpdates = _killSwitchUpdates - 1;
							_killSwitchUpdates = killSwitchUpdates;
						}
						else if (!game4._isPaused)
						{
							object obj10 = flag3 | game4.isDead;
							if (obj10 == null && z > 10f)
							{
								ExecuteKillSwitch();
							}
						}
						goto IL_0844;
					}
				}
			}
			if (_killSwitchUpdates != 10)
			{
				_killSwitchUpdates = 10;
			}
		}
		goto IL_0844;
	}

	public unsafe void SetCharacterModelLocalRotation(Quaternion rotation)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_002a: Expected native int or pointer, but got VT
		//IL_003c: Expected native int or pointer, but got VT
		object obj = default;
		Quaternion quaternion = (Quaternion)(obj - 16);
		Transform transform = _characterModel.transform;
		((Quaternion*)(nint)quaternion)->z = rotation.z;
		((Quaternion*)(nint)quaternion)->x = rotation.x;
		transform.localRotation = quaternion;
	}

	public unsafe Quaternion GetCharacterModelLocalRotation()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0044: Expected F4, but got I
		//IL_003f: Expected native int or pointer, but got VT
		//IL_0051: Expected F4, but got Obj
		//IL_004c: Expected native int or pointer, but got VT
		object obj2 = default;
		object obj = obj2 - 16;
		Transform transform = _characterModel.transform;
		Quaternion localRotation = transform.localRotation;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		Quaternion quaternion = default;
		((Quaternion*)(nint)quaternion)->z = 0f;
		((Quaternion*)(nint)quaternion)->x = (float)obj;
		return quaternion;
	}

	public unsafe void ResetCharacterModelLocalRotation()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0030: Expected I, but got Obj
		//IL_0062: Expected F4, but got I
		//IL_005d: Expected native int or pointer, but got VT
		//IL_007d: Expected F4, but got I
		//IL_0078: Expected native int or pointer, but got VT
		object obj = default;
		Quaternion quaternion = (Quaternion)(obj - 32);
		Transform transform = _characterModel.transform;
		nint num = (nint)typeof(Quaternion);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S0_v11 (Il2CppClass<UnityEngine.Quaternion>)+5C]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v12 (Il2CppStaticFields<UnityEngine.Quaternion>)+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+18]");
		((Quaternion*)(nint)quaternion)->z = 0f;
		_ = Quaternion.identityQuaternion;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+10]");
		((Quaternion*)(nint)quaternion)->x = 0f;
		transform.localRotation = quaternion;
	}

	public unsafe void Reset()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_011f: Expected F4, but got I4
		//IL_0161: Expected I, but got Obj
		//IL_0229: Unknown result type (might be due to invalid IL or missing references)
		//IL_022e: Expected VT, but got Unknown
		//IL_024e: Expected I, but got Obj
		//IL_02b9: Expected F4, but got I
		//IL_02b4: Expected native int or pointer, but got VT
		//IL_02d8: Expected F4, but got I
		//IL_02d3: Expected native int or pointer, but got VT
		//IL_02fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0301: Expected Obj, but got Unknown
		object obj = default;
		Vector3 vector = (Vector3)(obj - 80);
		LastDeathCause = DeathCause.None;
		_lastObstacleType = ObstacleType.None;
		Game game = _game;
		Game.SpeedInfo speed = game.speed;
		game.SpeedAtLastObstacleHit = speed.min;
		IsVisibleShadow = true;
		ResetCharacterModelLocalRotation();
		_stumbleState = StumbleState.Standard;
		if (__trackIndex != _initialTrackIndex)
		{
			__trackIndex = _initialTrackIndex;
			__trackIndexPrevious = __trackIndex;
		}
		_trackIndexTarget = _initialTrackIndex;
		float num = (float)__trackIndex * 20f;
		_ignoredMovement = 0;
		_trackMovement = 0;
		z = 0f;
		x = num;
		_trackIndexPosition = __trackIndex;
		_squeezeCollider.Clear();
		Transform transform = _characterController.transform;
		Vector3 position = Route.GetPosition(x, z);
		nint num2 = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ S0_v45 (Il2CppClass<UnityEngine.Vector3>)+5C]");
		nint num3 = 0;
		float num4 = (float)Vector3.upVector * 5f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+40]");
		float num5 = 0f + num4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ S0_v46 (Il2CppStaticFields<UnityEngine.Vector3>)+1C]");
		float num6 = 0f * 5f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+44]");
		float num7 = 0f + num6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ S0_v46 (Il2CppStaticFields<UnityEngine.Vector3>)+20]");
		float num8 = 0f * 5f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+48]");
		float num9 = 0f + num8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+38]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+30]");
		_ = 0;
		Vector3 position2 = vector + 16;
		transform.position = position2;
		nint num10 = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ S0_v65 (Il2CppClass<UnityEngine.Vector3>)+5C]");
		nint num11 = 0;
		float num12 = (float)Vector3.upVector * -5f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ S0_v66 (Il2CppStaticFields<UnityEngine.Vector3>)+1C]");
		float num13 = 0f * -5f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ S0_v66 (Il2CppStaticFields<UnityEngine.Vector3>)+20]");
		float num14 = 0f * -5f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+28]");
		((Vector3*)(nint)vector)->z = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+20]");
		((Vector3*)(nint)vector)->x = 0f;
		CollisionFlags collisionFlags = _characterController.Move(vector);
		verticalSpeed = 0f;
		object obj2 = this + 436;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22E");
		_startedJumpFromGround = false;
		__isJumping = false;
		inAirJump = false;
		_jumpUpperCollisionEvaded = true;
		_jumpUpperCollision = false;
		__isInLipFlight = false;
		LastGroundedY = 0f;
		JumpHeight = jumpHeightNormal;
		throw new IndexOutOfRangeException();
	}

	public void InitForRun()
	{
		_followingGuard.Restart(closeToCharacter: true);
		StartStumble();
		float time = Time.time;
		sameLaneTimeStamp = time;
	}

	public unsafe void Revive()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Expected Obj, but got Unknown
		//IL_002b: Expected Obj, but got I4
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Expected Obj, but got Unknown
		//IL_013a: Unknown result type (might be due to invalid IL or missing references)
		//IL_013f: Expected Obj, but got Unknown
		//IL_014f: Expected Obj, but got I
		//IL_0165: Unknown result type (might be due to invalid IL or missing references)
		//IL_016a: Expected VT, but got Unknown
		//IL_0173: Expected Ref, but got VT
		//IL_0200: Expected I, but got Obj
		//IL_0268: Expected F4, but got I
		//IL_0263: Expected native int or pointer, but got VT
		//IL_0287: Expected F4, but got I
		//IL_0282: Expected native int or pointer, but got VT
		object obj = default;
		Vector3 vector = (Vector3)(obj - 80);
		_ = 0;
		object obj2 = vector - -64;
		obj2 = 0;
		_ = 0;
		LastDeathCause = DeathCause.None;
		_lastObstacleType = ObstacleType.None;
		Game game = _game;
		Game.SpeedInfo speed = game.speed;
		game.SpeedAtLastObstacleHit = speed.min;
		_characterRendering.ResetTeleportFx();
		OnReviveDelegate onRevive = this.m_OnRevive;
		if (this.m_OnRevive != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v29.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
		}
		if (~(_isStumbling ? 1u : 0u) == 0)
		{
			StopStumble();
		}
		_isFalling = false;
		float num = CalculateJumpVerticalSpeed(15f);
		verticalSpeed = num;
		object obj3 = this + 436;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22E");
		if (~(_jumpUpperCollision ? 1u : 0u) == 0)
		{
			Bounds bounds = _characterController.bounds;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+30]");
			_ = 0;
			object obj4 = vector - -64;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+28]");
			obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+20]");
			_ = 0;
			Bounds bounds2 = (Bounds)(vector + 56);
			Vector3 min = ((Bounds*)bounds2)->min;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+24]");
			float num2 = 0f - _jumpUpperCollisionColliderMinY;
			if (num2 < 0f)
			{
				nint num3 = (nint)typeof(Vector3);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ S0_v51 (Il2CppClass<UnityEngine.Vector3>)+5C]");
				nint num4 = 0;
				float num5 = (float)Vector3.upVector * num2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ S0_v52 (Il2CppStaticFields<UnityEngine.Vector3>)+1C]");
				float num6 = 0f * num2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ S0_v52 (Il2CppStaticFields<UnityEngine.Vector3>)+20]");
				float num7 = 0f * num2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+18]");
				((Vector3*)(nint)vector)->z = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+10]");
				((Vector3*)(nint)vector)->x = 0f;
				CollisionFlags collisionFlags = _characterController.Move(vector);
			}
		}
		_jumpUpperCollisionEvaded = true;
		_jumpUpperCollision = false;
	}

	private void SetLastObstacleType(ObstacleType ot)
	{
		_lastObstacleType = ot;
		Game game = _game;
		game.SpeedAtLastObstacleHit = game.__currentSpeed;
	}

	private void ClearLastObstacleType()
	{
		_lastObstacleType = ObstacleType.None;
		Game game = _game;
		Game.SpeedInfo speed = game.speed;
		game.SpeedAtLastObstacleHit = speed.min;
	}

	public bool IsDescending()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_002e: Invalid comparison between I and F4
		object obj2 = default;
		object obj = obj2 - 16;
		Vector3 velocity = _characterController.velocity;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4]");
		return 0f < 0f;
	}

	public unsafe void CreateExplosionAtCharactersFeet()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0075: Expected native int or pointer, but got VT
		//IL_0089: Expected native int or pointer, but got VT
		object obj = default;
		Vector3 vector = (Vector3)(obj - 32);
		_ = -1059061760;
		((Vector3*)(nint)vector)->z = -7f;
		_ = 0;
		((Vector3*)(nint)vector)->x = 0f;
		RouteScoreChangeExplosion routeScoreChangeExplosion = RouteScoreChangeExplosion.CreateAtPosition(vector);
		GameObject gameObject = routeScoreChangeExplosion.gameObject;
		Transform childTransform = gameObject.transform;
		GameObject hoverboardGameObject = _characterModel.GetHoverboardGameObject();
		Transform transform = hoverboardGameObject.transform;
		Transform parent = transform.parent;
		HierarchyUtility.Reparent(childTransform, parent);
	}

	public TrackLane GetLaneFromIndex(int laneIndex)
	{
		bool flag = laneIndex == 2;
		TrackLane result = TrackLane.Right;
		if (!flag)
		{
			result = TrackLane.Mid;
		}
		if (laneIndex == 0)
		{
			result = TrackLane.Left;
		}
		return result;
	}

	public void ChangeTrackLeft1()
	{
		ChangeTrackBy(-1);
	}

	public void ChangeTrackLeft2()
	{
		ChangeTrackBy(-1);
	}

	public void ChangeTrackRight1()
	{
		ChangeTrackBy(1);
	}

	public void ChangeTrackRight2()
	{
		ChangeTrackBy(1);
	}

	public void ChangeTrackCenter()
	{
		if (__trackIndex != 0)
		{
			if (__trackIndex != 1 && __trackIndex == 2)
			{
				ChangeTrackLeft1();
			}
		}
		else
		{
			ChangeTrackRight1();
		}
	}

	public void ChangeTrackBy(int trackDelta)
	{
		bool isTeleboard = IsTeleboard;
		float num = 20f;
		if (!isTeleboard)
		{
			num = 30f;
		}
		Game instance = Game.Instance;
		float duration = num / instance.__currentSpeed;
		ChangeTrackBy(trackDelta, duration);
	}

	private void ChangeTrackTo(int newTrackIndex)
	{
		int trackDelta = newTrackIndex - __trackIndex;
		ChangeTrackBy(trackDelta);
	}

	public unsafe void ChangeTrackBy(int trackDelta, float duration)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0077: Expected I4, but got F8
		//IL_0165: Expected Obj, but got I4
		//IL_0205: Expected native int or pointer, but got VT
		//IL_021d: Expected native int or pointer, but got VT
		//IL_01e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e7: Expected VT, but got Unknown
		object obj = default;
		Vector3 vector = (Vector3)(obj + -64);
		MissionsManager instance = MissionsManager.Instance;
		float time = Time.time;
		double num = (double)time - (double)sameLaneTimeStamp;
		double num2 = Math.Abs(num);
		int magnitude = ((!(num2 < 2147483648.0)) ? int.MinValue : ((int)num));
		instance.PlayerDidThis(MissionTarget.StayInOneLane, magnitude);
		MissionsManager instance2 = MissionsManager.Instance;
		instance2.RemoveProgressForThis(MissionTarget.StayInOneLane);
		float time2 = Time.time;
		sameLaneTimeStamp = time2;
		if (_ignoredMovement == trackDelta)
		{
			return;
		}
		if (trackDelta != _trackMovement)
		{
			ForceChangeTrack(trackDelta, duration);
			if (!IsTeleboard || _game.IsInPogostickMode || _game.IsInJetpackMode)
			{
				return;
			}
			object obj2 = trackDelta + 1;
			if (obj2 != null)
			{
				if ((nint)obj2 != 1 && (nint)obj2 == 2)
				{
					_ = 1065353216;
					_ = 1065353216;
					_ = 1101004800;
					_ = 1101004800;
					Vector3 offset = vector + 16;
					Teleboard(offset);
				}
			}
			else
			{
				_ = 1065353216;
				((Vector3*)(nint)vector)->z = 1f;
				_ = 3248488448L;
				((Vector3*)(nint)vector)->x = -20f;
				Teleboard(vector);
			}
		}
		else
		{
			_trackMovementNext = trackDelta;
		}
	}

	public void ForceChangeTrack(int movement, float duration)
	{
		StopAllCoroutines();
		IEnumerator routine = ChangeTrackCoroutine(movement, duration);
		Coroutine coroutine = StartCoroutine(routine);
	}

	public void SetLastCheckpointTime(float t)
	{
		_lastCheckpointTime = t;
	}

	public void SetBackToCheckPoint(float zoomTime)
	{
		//IL_008b: Expected F4, but got I4
		if (__trackIndex != _initialTrackIndex)
		{
			__trackIndex = _initialTrackIndex;
			__trackIndexPrevious = __trackIndex;
		}
		_trackIndexTarget = _initialTrackIndex;
		float newX = (float)__trackIndex * 20f;
		_ignoredMovement = 0;
		_trackMovement = 0;
		_trackIndexPosition = __trackIndex;
		IEnumerator routine = MoveCharacterToPosition(newX, _lastCheckpointTime, zoomTime);
		Coroutine coroutine = StartCoroutine(routine);
	}

	public void ForceLeaveSubway()
	{
		throw new IndexOutOfRangeException();
	}

	public float GetTrackX()
	{
		return (float)__trackIndex * 20f;
	}

	public void DebugSuperJump()
	{
		JumpHeight = 100f;
		Jump();
		JumpHeight = JumpHeight;
	}

	public void JumpAdvanced(float jumpHeight, bool willPlaySound = true, bool willPlayAnimation = true)
	{
		float num = CalculateJumpVerticalSpeed(jumpHeight);
		verticalSpeed = num;
		if (~(_isRolling ? 1u : 0u) == 0)
		{
			ExpandColliders();
		}
		_isFalling = false;
		throw new NullReferenceException();
	}

	private IEnumerator ToggleDustWithDelay(float delay)
	{
		_ = 0;
		IEnumerator result = default;
		return result;
	}

	public void Jump()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0074: Expected Obj, but got I4
		//IL_00d6: Expected Obj, but got I4
		//IL_00b4: Expected Obj, but got I4
		//IL_077b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0780: Expected Obj, but got Unknown
		//IL_00f9: Expected Obj, but got I4
		//IL_0102: Expected Obj, but got I4
		//IL_013c: Expected Obj, but got I4
		//IL_0145: Expected Obj, but got I4
		//IL_014e: Expected Obj, but got I4
		//IL_016f: Expected Obj, but got I4
		//IL_0178: Expected Obj, but got I4
		//IL_0181: Expected Obj, but got I4
		object obj2 = default;
		object obj = obj2 - 96;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		object obj3;
		if (__isJumping || verticalSpeed > 0f || !(verticalSpeed > _verticalSpeed_jumpTolerance))
		{
			bool flag = (byte)(~(SetPieceForcedForgivingJump ? 1u : 0u)) != 0;
			obj3 = 1;
			if (flag)
			{
				goto IL_00c2;
			}
		}
		float timeSinceLevelLoad = Time.timeSinceLevelLoad;
		float num = timeSinceLevelLoad - SetPieceForgivingJumpTime;
		bool flag2 = num < 0.15f;
		obj3 = 1;
		if (!flag2)
		{
			goto IL_00c2;
		}
		Variable<bool> isGrounded = IsGrounded;
		SetPieceForcedForgivingJump = false;
		object obj4 = 1;
		obj3 = 1;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ S0_v113 (Variable`1<System.Boolean>)+8]");
		object obj5 = default;
		if ((nint)0 == 0)
		{
			Action onSetPieceForgivingJump = OnSetPieceForgivingJump;
			bool flag3 = OnSetPieceForgivingJump == null;
			obj5 = 1;
			obj4 = 0;
			obj3 = 1;
			if (!flag3)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v110.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
				obj5 = 1;
				obj4 = 0;
				obj3 = 1;
			}
		}
		goto IL_0747;
		IL_0747:
		OnSetPieceForgivingJump = null;
		bool isGrounded2 = _characterController.isGrounded;
		bool flag4 = isGrounded2;
		if (obj3 == null)
		{
			flag4 = isGrounded2;
			if (!isGrounded2)
			{
				RunningState runningState = _runningState;
				bool flag5 = (byte)((runningState.transitionFromHeight ? 1u : 0u) ^ 1u) != 0;
				flag4 = flag5;
			}
		}
		object obj6 = flag4 | obj5;
		if (obj6 != null)
		{
			if (~(__isJumping ? 1u : 0u) == 0 && ~(_jumpUpperCollisionEvaded ? 1u : 0u) == 0)
			{
				_jumpUpperCollision = false;
			}
			if (~(_isRolling ? 1u : 0u) == 0)
			{
				ExpandColliders();
			}
			_vTolEnded = false;
			_glideTimeLeft = 0f;
			_willSecondJump = true;
			_isFalling = false;
			throw new NullReferenceException();
		}
		if (AllowDoubleJump())
		{
			if (~(__isJumping ? 1u : 0u) == 0 && ~(_jumpUpperCollisionEvaded ? 1u : 0u) == 0)
			{
				_jumpUpperCollision = false;
			}
			if (~(_isRolling ? 1u : 0u) == 0)
			{
				ExpandColliders();
			}
			_vTolEnded = false;
			_glideTimeLeft = 0f;
			_willSecondJump = false;
			_isFalling = false;
			throw new NullReferenceException();
		}
		if (verticalSpeed < 0f)
		{
			inAirJump = true;
		}
		return;
		IL_00c2:
		SetPieceForcedForgivingJump = false;
		obj4 = 1;
		goto IL_0747;
	}

	public void CheckInAirJump()
	{
		if (_characterController.isGrounded && ~(inAirJump ? 1u : 0u) == 0)
		{
			Jump();
			inAirJump = false;
		}
	}

	private void Teleboard(Vector3 offset)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0058: Expected Obj, but got F4
		object obj2 = default;
		object obj = obj2 - 16;
		OnTeleboardStartDelegate onTeleboardStart = this.m_OnTeleboardStart;
		if (this.m_OnTeleboardStart != null)
		{
			Game game = _game;
			_ = offset.z;
			obj = offset.x;
			float num = 17f / game.__currentSpeed;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v8.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
		}
	}

	public void Roll()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 32;
		if (~(_isRolling ? 1u : 0u) != 0)
		{
			_isTucked = false;
			_glideTimeLeft = _glideTime;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Characters.Character)+1C4]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Characters.Character)+1BC]");
			_ = 0;
			_ = _superSneakersJump;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
			if ((nint)0 != 0)
			{
				object obj3 = this + 436;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22E");
			}
			_squeezeCollider.Add(this);
			RunningState runningState = _runningState;
			bool flag = (byte)(~(runningState.transitionFromHeight ? 1u : 0u)) != 0;
			bool flag2 = !flag;
			float num = -250f;
			if (!flag2)
			{
				float num2 = CalculateJumpVerticalSpeed(JumpHeight);
				float num3 = 0f - num2;
				num = num3;
			}
			_isRolling = true;
			verticalSpeed = num;
			inAirJump = false;
			OnRollDelegate onRoll = this.m_OnRoll;
			if (this.m_OnRoll != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v61.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
			}
		}
	}

	public void EnterRoute()
	{
		Action onEnterRoute = OnEnterRoute;
		if (OnEnterRoute != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v2.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
		}
	}

	public void EnterRouteEnd()
	{
		Action onEnterRouteEnd = OnEnterRouteEnd;
		if (OnEnterRouteEnd != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v2.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
		}
	}

	public void ExitRoute()
	{
		Action onExitRoute = OnExitRoute;
		if (OnExitRoute != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v2.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
		}
	}

	public unsafe void ApplyGravity()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0530: Unknown result type (might be due to invalid IL or missing references)
		//IL_0535: Expected Obj, but got Unknown
		//IL_05da: Expected I, but got Obj
		//IL_05f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f8: Expected Obj, but got Unknown
		//IL_0609: Expected Obj, but got I
		//IL_0640: Expected Obj, but got I
		//IL_064a: Unsupported input type for neg.
		//IL_064a: Unknown result type (might be due to invalid IL or missing references)
		//IL_064f: Expected Obj, but got Unknown
		//IL_067d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0682: Expected VT, but got Unknown
		//IL_068b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0690: Expected VT, but got Unknown
		//IL_0699: Unknown result type (might be due to invalid IL or missing references)
		//IL_069e: Expected VT, but got Unknown
		//IL_06aa: Expected native int or pointer, but got VT
		//IL_06de: Expected VT, but got I
		//IL_06d9: Expected native int or pointer, but got VT
		//IL_06e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ec: Expected Ref, but got Unknown
		//IL_01d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01dc: Expected VT, but got Unknown
		//IL_01e5: Expected Ref, but got VT
		//IL_022d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0232: Expected VT, but got Unknown
		//IL_023b: Expected Ref, but got VT
		object obj = default;
		Ray ray = (Ray)(obj - 160);
		object obj2 = ray + 112;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @237");
		if (verticalSpeed < 0f && _characterController.isGrounded)
		{
			if (~(_startedJumpFromGround ? 1u : 0u) == 0 && ~(_trainJump ? 1u : 0u) == 0)
			{
				RunningState runningState = _runningState;
				if (runningState.currentRunPosition == RunningState.RunPositions.ground)
				{
					OnJumpOverTrainDelegate onJumpOverTrain = this.m_OnJumpOverTrain;
					if (this.m_OnJumpOverTrain != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v123.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
					}
				}
			}
			RunningState runningState2 = _runningState;
			if (runningState2.currentRunPosition != RunningState.RunPositions.air)
			{
				_startedJumpFromGround = false;
			}
			throw new NullReferenceException();
		}
		if (~(_startedJumpFromGround ? 1u : 0u) != 0 || !(_trainJumpSampleZ < z))
		{
			goto IL_05b3;
		}
		Transform transform = base.transform;
		Vector3 position = transform.position;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Ray)+50]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Ray)+48]");
		_ = 0;
		nint num = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v211 @ S0_v91 (Il2CppClass<UnityEngine.Vector3>)+5C]");
		nint num2 = 0;
		object obj3 = ray - -64;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v212 @ S0_v92 (Il2CppStaticFields<UnityEngine.Vector3>)+20]");
		object obj4 = -0;
		obj3 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Ray)+68]");
		_ = 0;
		_ = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v212 @ S0_v92 (Il2CppStaticFields<UnityEngine.Vector3>)+1C]");
		object obj5 = -0;
		object obj6 = 0 - Vector3.upVector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Ray)+60]");
		_ = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Ray)+38]");
		_ = 0;
		Ray ray2 = (Ray)(ray + 72);
		Vector3 origin = (Vector3)(ray + 40);
		Vector3 direction = (Vector3)(ray + 24);
		*(Ray*)(nint)ray2 = new Ray(origin, direction);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Ray)+58]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Ray)+50]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Ray)+48]");
		((Ray*)(nint)ray)->m_Origin = (Vector3)0;
		if (Physics.Raycast(ray, out *(RaycastHit*)(ray + 112)))
		{
			RaycastHit raycastHit = (RaycastHit)(ray + 112);
			Collider collider = ((RaycastHit*)raycastHit)->collider;
			if (!collider.CompareTag("HitMovingTrain"))
			{
				RaycastHit raycastHit2 = (RaycastHit)(ray + 112);
				Collider collider2 = ((RaycastHit*)raycastHit2)->collider;
				if (!collider2.CompareTag("HitTrain"))
				{
					goto IL_0716;
				}
			}
			_trainJump = true;
		}
		goto IL_0716;
		IL_0716:
		float trainJumpSampleZ = _trainJumpSampleZ + _trainJumpSampleLength;
		_trainJumpSampleZ = trainJumpSampleZ;
		goto IL_05b3;
		IL_0738:
		if (!_characterController.isGrounded && !_isFalling && verticalSpeed < verticalFallSpeedLimit && !_isRolling)
		{
			_isTucked = false;
			_isFalling = true;
			OnHangtimeDelegate onHangtime = this.m_OnHangtime;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v401.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
			throw new NullReferenceException();
		}
		return;
		IL_046d:
		float deltaTime = Time.deltaTime;
		float num3 = gravity * deltaTime;
		float num4 = verticalSpeed - num3;
		verticalSpeed = num4;
		goto IL_0738;
		IL_05b3:
		if (~(_isFalling ? 1u : 0u) != 0)
		{
			goto IL_046d;
		}
		if (IsGliderboard)
		{
			if (_glideTimeLeft < _glideTime)
			{
				float time = _glideTimeLeft / _glideTime;
				float num5 = _glideVerticalSpeed.Evaluate(time);
				float num6 = gliderGravity * num5;
				verticalSpeed = num6;
				float deltaTime2 = Time.deltaTime;
				float glideTimeLeft = _glideTimeLeft + deltaTime2;
				_glideTimeLeft = glideTimeLeft;
			}
			else
			{
				float deltaTime3 = Time.deltaTime;
				float num7 = gliderGravity * deltaTime3;
				float num8 = verticalSpeed - num7;
				verticalSpeed = num8;
			}
		}
		else
		{
			if (~(_isFalling ? 1u : 0u) != 0 || !IsVTol)
			{
				goto IL_046d;
			}
			if (_glideTimeLeft < _glideTime)
			{
				verticalSpeed = 0f;
				float deltaTime4 = Time.deltaTime;
				float glideTimeLeft2 = _glideTimeLeft + deltaTime4;
				_glideTimeLeft = glideTimeLeft2;
			}
			else
			{
				if (~(_vTolEnded ? 1u : 0u) != 0)
				{
					OnGliderEndDelegate onVTolEnd = this.m_OnVTolEnd;
					if (this.m_OnVTolEnd != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v381.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
					}
					_vTolEnded = true;
				}
				float deltaTime5 = Time.deltaTime;
				float num9 = gravity * deltaTime5;
				float num10 = verticalSpeed - num9;
				verticalSpeed = num10;
			}
		}
		goto IL_0738;
	}

	public unsafe void MoveWithGravity()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_009f: Expected I, but got Obj
		//IL_0116: Expected F4, but got I
		//IL_0111: Expected native int or pointer, but got VT
		//IL_0135: Expected F4, but got I
		//IL_0130: Expected native int or pointer, but got VT
		object obj = default;
		Vector3 vector = (Vector3)(obj - 32);
		if (_characterController.enabled)
		{
			float deltaTime = Time.deltaTime;
			float num = gravity * deltaTime;
			float val = verticalSpeed - num;
			float num2 = (verticalSpeed = Math.Min(val, 0f));
			float deltaTime2 = Time.deltaTime;
			nint num3 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ S0_v17 (Il2CppClass<UnityEngine.Vector3>)+5C]");
			nint num4 = 0;
			float num5 = num2 * deltaTime2;
			float num6 = (float)Vector3.upVector * num5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ S0_v18 (Il2CppStaticFields<UnityEngine.Vector3>)+1C]");
			float num7 = 0f * num5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ S0_v18 (Il2CppStaticFields<UnityEngine.Vector3>)+20]");
			float num8 = 0f * num5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+18]");
			((Vector3*)(nint)vector)->z = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+10]");
			((Vector3*)(nint)vector)->x = 0f;
			CollisionFlags collisionFlags = _characterController.Move(vector);
		}
	}

	public unsafe void MoveForward()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_067b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0680: Expected Obj, but got Unknown
		//IL_0693: Unknown result type (might be due to invalid IL or missing references)
		//IL_0698: Expected Obj, but got Unknown
		//IL_06bf: Expected I, but got Obj
		//IL_06f3: Expected F4, but got I
		//IL_0703: Expected F4, but got I
		//IL_070c: Expected Obj, but got I4
		//IL_0734: Expected Obj, but got I4
		//IL_0ccb: Expected F4, but got VT
		//IL_0086: Expected F4, but got I
		//IL_0096: Expected F4, but got I
		//IL_009f: Expected Obj, but got I4
		//IL_0927: Expected Obj, but got I
		//IL_095c: Expected Obj, but got I
		//IL_01e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ea: Expected Obj, but got Unknown
		//IL_087b: Expected I, but got Obj
		//IL_03cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d2: Expected Obj, but got Unknown
		//IL_03f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fe: Expected Obj, but got Unknown
		//IL_0430: Unknown result type (might be due to invalid IL or missing references)
		//IL_0435: Expected VT, but got Unknown
		//IL_0370: Unknown result type (might be due to invalid IL or missing references)
		//IL_0375: Expected VT, but got Unknown
		//IL_0802: Expected I, but got Obj
		//IL_0836: Expected F4, but got I
		//IL_0846: Expected F4, but got I
		//IL_084f: Expected Obj, but got I4
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Expected VT, but got Unknown
		//IL_010a: Expected Ref, but got VT
		//IL_0210: Unknown result type (might be due to invalid IL or missing references)
		//IL_0215: Expected Obj, but got Unknown
		//IL_0231: Invalid comparison between F4 and I
		//IL_0125: Invalid comparison between F4 and I
		//IL_0475: Expected F4, but got I
		//IL_0a57: Expected I, but got Obj
		//IL_0a70: Expected F4, but got VT
		//IL_0a80: Expected F4, but got I
		//IL_0a90: Expected F4, but got I
		//IL_017c: Expected F4, but got I
		//IL_018c: Expected F4, but got I
		//IL_0195: Expected Obj, but got I4
		//IL_0b80: Expected I, but got Obj
		//IL_0c15: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c1a: Expected VT, but got Unknown
		//IL_0c23: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c28: Expected VT, but got Unknown
		//IL_0c31: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c36: Expected Ref, but got Unknown
		//IL_0aa3: Expected I, but got Obj
		//IL_0b09: Expected F4, but got I
		//IL_0b04: Expected native int or pointer, but got VT
		//IL_0b17: Expected F4, but got VT
		//IL_0b12: Expected native int or pointer, but got VT
		//IL_0b20: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b25: Expected VT, but got Unknown
		//IL_0b2e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b33: Expected Ref, but got Unknown
		//IL_0a0b: Expected I, but got Obj
		//IL_0a24: Expected F4, but got VT
		//IL_0a34: Expected F4, but got I
		//IL_0a44: Expected F4, but got I
		//IL_0ce7: Expected I, but got Obj
		//IL_0d7c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d81: Expected VT, but got Unknown
		//IL_0d8a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d8f: Expected VT, but got Unknown
		//IL_0d98: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d9d: Expected Ref, but got Unknown
		//IL_0515: Invalid comparison between I and F4
		//IL_0992: Expected I, but got Obj
		//IL_0750: Expected I, but got Obj
		//IL_07d6: Expected VT, but got F4
		//IL_07ef: Expected Obj, but got I4
		//IL_0591: Invalid comparison between F4 and I
		//IL_0560: Expected F4, but got I
		object obj = default;
		Vector3 vector = (Vector3)(obj - 352);
		_ = 0;
		_ = 0;
		_ = 0;
		object obj2 = vector + 280;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @237");
		object obj3 = vector + 232;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @237");
		Transform transform = base.transform;
		Vector3 position = transform.position;
		Game game = _game;
		float deltaTime = Time.deltaTime;
		float num = game.__currentSpeed * deltaTime;
		float num2 = z + num;
		nint num3 = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ S0_v32 (Il2CppClass<UnityEngine.Vector3>)+5C]");
		nint num4 = 0;
		bool flag = (byte)(~(__isJumping ? 1u : 0u)) != 0;
		Vector3 vector2 = Vector3.zeroVector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ S0_v33 (Il2CppStaticFields<UnityEngine.Vector3>)+4]");
		float num5 = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ S0_v33 (Il2CppStaticFields<UnityEngine.Vector3>)+8]");
		float num6 = 0f;
		object obj4 = 1;
		if (!flag)
		{
			bool flag2 = (byte)(~(_jumpUpperCollision ? 1u : 0u)) != 0;
			vector2 = Vector3.zeroVector;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ S0_v33 (Il2CppStaticFields<UnityEngine.Vector3>)+4]");
			num5 = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ S0_v33 (Il2CppStaticFields<UnityEngine.Vector3>)+8]");
			num6 = 0f;
			obj4 = 1;
			if (!flag2)
			{
				if (!_jumpUpperCollisionEvaded)
				{
					Bounds bounds = CharacterTrigger.bounds;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+E0]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+D8]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+D0]");
					_ = 0;
					Bounds bounds2 = (Bounds)(vector + 328);
					Vector3 max = ((Bounds*)bounds2)->max;
					float jumpUpperCollisionColliderMinY = _jumpUpperCollisionColliderMinY;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+D4]");
					if (jumpUpperCollisionColliderMinY < 0f)
					{
						bool flag3 = !(verticalSpeed < 0f);
						bool flag4 = !flag3;
						vector2 = Vector3.zeroVector;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ S0_v33 (Il2CppStaticFields<UnityEngine.Vector3>)+4]");
						num5 = 0f;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ S0_v33 (Il2CppStaticFields<UnityEngine.Vector3>)+8]");
						num6 = 0f;
						obj4 = 0;
						if (!flag4)
						{
							float deltaTime2 = Time.deltaTime;
							float deltaTime3 = Time.deltaTime;
							nint num7 = (nint)typeof(Vector3);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v461 @ S0_v327 (Il2CppClass<UnityEngine.Vector3>)+5C]");
							nint num8 = 0;
							float num9 = 0f - gravity;
							float num10 = num9 * deltaTime2;
							float num11 = num10 * deltaTime3;
							float num12 = (float)Vector3.upVector * num11;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v462 @ S0_v328 (Il2CppStaticFields<UnityEngine.Vector3>)+1C]");
							float num13 = 0f * num11;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v462 @ S0_v328 (Il2CppStaticFields<UnityEngine.Vector3>)+20]");
							float num14 = 0f * num11;
							vector2 = (Vector3)num12;
							num5 = num13;
							num6 = num14;
							obj4 = 0;
						}
						goto IL_071a;
					}
				}
				nint num15 = (nint)typeof(Vector3);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v207 @ S0_v289 (Il2CppClass<UnityEngine.Vector3>)+5C]");
				nint num16 = 0;
				_jumpUpperCollisionEvaded = true;
				vector2 = Vector3.zeroVector;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v208 @ S0_v290 (Il2CppStaticFields<UnityEngine.Vector3>)+4]");
				num5 = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v208 @ S0_v290 (Il2CppStaticFields<UnityEngine.Vector3>)+8]");
				num6 = 0f;
				obj4 = 0;
			}
		}
		goto IL_071a;
		IL_071a:
		bool flag5 = verticalSpeed < 0f;
		object obj5 = 1;
		if (!flag5)
		{
			obj5 = obj4;
		}
		bool flag6 = obj5 == null;
		float num17 = (float)vector2;
		if (!flag6)
		{
			float deltaTime4 = Time.deltaTime;
			nint num18 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v277 @ S0_v263 (Il2CppClass<UnityEngine.Vector3>)+5C]");
			nint num19 = 0;
			float num20 = verticalSpeed * deltaTime4;
			float num21 = (float)Vector3.upVector * num20;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v278 @ S0_v264 (Il2CppStaticFields<UnityEngine.Vector3>)+1C]");
			float num22 = 0f * num20;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v278 @ S0_v264 (Il2CppStaticFields<UnityEngine.Vector3>)+20]");
			float num23 = 0f * num20;
			num17 = num21;
			num5 = num22;
			num6 = num23;
		}
		if (~(__isJumping ? 1u : 0u) == 0)
		{
			object obj6 = this + 436;
			if (obj6 != null)
			{
				object obj7 = vector + 208;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @33CE");
				float num24 = z;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+D8]");
				if (num24 < 0f)
				{
					if (obj4 != null)
					{
						float num25 = num2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+D0]");
						float num26 = num25 - 0f;
						float num27 = num26;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+D4]");
						float time = num27 / 0f;
						float num28 = superSneakersJumpCurve.Evaluate(time);
						float num29 = num28 * jumpHeightSuperSneakers;
						float num30 = num29;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+DC]");
						float num31 = num30 + 0f;
						float num32 = num31;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+D4]");
						float num33 = num32 - 0f;
						nint num34 = (nint)typeof(Vector3);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v485 @ S0_v243 (Il2CppClass<UnityEngine.Vector3>)+5C]");
						nint num35 = 0;
						float num36 = (float)Vector3.upVector * num33;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v486 @ S0_v244 (Il2CppStaticFields<UnityEngine.Vector3>)+1C]");
						float num37 = 0f * num33;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v486 @ S0_v244 (Il2CppStaticFields<UnityEngine.Vector3>)+20]");
						float num38 = 0f * num33;
						num17 = num36;
						num5 = num37;
						num6 = num38;
					}
					else
					{
						nint num39 = (nint)typeof(Vector3);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v418 @ S0_v221 (Il2CppClass<UnityEngine.Vector3>)+5C]");
						nint num40 = 0;
						num17 = (float)Vector3.zeroVector;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v419 @ S0_v222 (Il2CppStaticFields<UnityEngine.Vector3>)+4]");
						num5 = 0f;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v419 @ S0_v222 (Il2CppStaticFields<UnityEngine.Vector3>)+8]");
						num6 = 0f;
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22E");
					verticalSpeed = 0f;
					nint num41 = (nint)typeof(Vector3);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v429 @ S0_v206 (Il2CppClass<UnityEngine.Vector3>)+5C]");
					nint num42 = 0;
					num17 = (float)Vector3.zeroVector;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v430 @ S0_v207 (Il2CppStaticFields<UnityEngine.Vector3>)+4]");
					num5 = 0f;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v430 @ S0_v207 (Il2CppStaticFields<UnityEngine.Vector3>)+8]");
					num6 = 0f;
				}
			}
		}
		Vector3 position2 = Route.GetPosition(x, num2);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+D0]");
		nint num43 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+D0]");
		object obj8 = num43 - 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+D4]");
		float num44 = 0f - 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+D8]");
		nint num45 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+D8]");
		object obj9 = num45 - 0;
		if (_characterController.enabled)
		{
			float num46 = num6 + (float)obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+C8]");
			_ = 0;
			float num47 = num5 + num44;
			float num48 = num17 + (float)obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+C0]");
			_ = 0;
			Vector3 motion = vector + 96;
			CollisionFlags collisionFlags = _characterController.Move(motion);
		}
		else
		{
			Transform transform2 = _characterController.transform;
			Transform transform3 = _characterController.transform;
			Vector3 position3 = transform3.position;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+D0]");
			object obj10 = 0 + obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+D4]");
			float num49 = 0f + num44;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+D8]");
			object obj11 = 0 + obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+B8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+B0]");
			_ = 0;
			Vector3 position4 = vector + 112;
			transform2.position = position4;
		}
		Transform transform4 = base.transform;
		Vector3 position5 = transform4.position;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+D8]");
		z = 0f;
		if (_characterController.isGrounded)
		{
			nint num50 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v546 @ S0_v147 (Il2CppClass<UnityEngine.Vector3>)+5C]");
			nint num51 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+D8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+A8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+D4]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+D0]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+A0]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v547 @ S0_v148 (Il2CppStaticFields<UnityEngine.Vector3>)+2C]");
			((Vector3*)(nint)vector)->z = 0f;
			((Vector3*)(nint)vector)->x = (float)Vector3.downVector;
			Vector3 origin = vector + 16;
			if (Physics.Raycast(origin, vector, out *(RaycastHit*)(vector + 280), 2f))
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+118]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+120]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+D4]");
				float lastGroundedY = 0f + _characterControllerSkinWidth;
				LastGroundedY = lastGroundedY;
			}
		}
		else
		{
			nint num52 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v584 @ S1_v41 (Il2CppClass<UnityEngine.Vector3>)+5C]");
			nint num53 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v585 @ S1_v42 (Il2CppStaticFields<UnityEngine.Vector3>)+2C]");
			_ = 0;
			_ = Vector3.downVector;
			int num54 = LayerMask.NameToLayer("Ramp");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+D8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+D8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+98]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+D4]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+D0]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+D0]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+90]");
			_ = 0;
			Vector3 origin2 = vector + 80;
			Vector3 direction = vector - -64;
			ref RaycastHit hitInfo = ref *(RaycastHit*)(vector + 232);
			int layerMask = 1 << num54;
			if (Physics.Raycast(origin2, direction, out hitInfo, 50f, layerMask, QueryTriggerInteraction.Ignore))
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+E8]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+F0]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+D4]");
				if (0f > LastGroundedY)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+E8]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+F0]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+D4]");
					LastGroundedY = 0f;
				}
			}
			nint num55 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v715 @ S1_v64 (Il2CppClass<UnityEngine.Vector3>)+5C]");
			nint num56 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v716 @ S1_v65 (Il2CppStaticFields<UnityEngine.Vector3>)+50]");
			_ = 0;
			_ = Vector3.forwardVector;
			int num57 = LayerMask.NameToLayer("Ramp");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+D8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+D8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+88]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+D4]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+D0]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+D0]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+80]");
			_ = 0;
			Vector3 origin3 = vector + 48;
			Vector3 direction2 = vector + 32;
			ref RaycastHit hitInfo2 = ref *(RaycastHit*)(vector + 232);
			int layerMask2 = 1 << num57;
			if (Physics.Raycast(origin3, direction2, out hitInfo2, 50f, layerMask2, QueryTriggerInteraction.Ignore))
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+E8]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+F0]");
				_ = 0;
				float lastGroundedY2 = LastGroundedY;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+D4]");
				if (lastGroundedY2 < 0f)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+E8]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+F0]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+D4]");
					float num58 = 0f - LastGroundedY;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+104]");
					float num59 = 0f / 50f;
					float num60 = 1f - num59;
					float num61 = num60 * 0.25f;
					float num62 = Math.Min(num61, 1f);
					bool flag7 = num61 < 0f;
					float num63 = 0f;
					if (!flag7)
					{
						num63 = num62;
					}
					float num64 = num58 * num63;
					float lastGroundedY3 = LastGroundedY + num64;
					LastGroundedY = lastGroundedY3;
				}
			}
		}
		_movedSinceLastFixedUpdate = true;
	}

	public void EndRoll()
	{
		ExpandColliders();
		_isRolling = false;
	}

	public float CalculateJumpVerticalSpeed(float jumpHeight)
	{
		if (jumpHeight < 0f)
		{
			GameObject gameObject = base.gameObject;
		}
		float num = jumpHeight + jumpHeight;
		float result = num * gravity;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"System.Math.Sqrt not resolved\"");
		return result;
	}

	public float CalculateJumpVerticalSpeed()
	{
		return CalculateJumpVerticalSpeed(JumpHeight);
	}

	public float JumpLength(float speed, float jumpHeight)
	{
		float num = speed + speed;
		float num2 = CalculateJumpVerticalSpeed(jumpHeight);
		float num3 = num * num2;
		return num3 / gravity;
	}

	public void StopStumble()
	{
		_followingGuard.ResetCatchUp();
		_isStumbling = false;
	}

	private IEnumerator ChangeTrackCoroutine(int move, float duration)
	{
		_ = 0;
		IEnumerator result = default;
		return result;
	}

	private IEnumerator MoveCharacterToPosition(float newX, float newZ, float time)
	{
		_ = 0;
		IEnumerator result = default;
		return result;
	}

	private ObstacleType GetObstacleTypeFromTag(Collider obstacleCollider)
	{
		string text = obstacleCollider.tag;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @752");
		object obj = default;
		ObstacleType result;
		if ((nint)obj <= 1732711450)
		{
			if ((nint)obj <= 746443172)
			{
				if ((nint)obj != 529772392)
				{
					if ((nint)obj != 746443172 || !(text == "HitBlocker"))
					{
						goto IL_0409;
					}
					result = ObstacleType.Blocker;
				}
				else
				{
					if (!(text == "HitTrain"))
					{
						goto IL_0409;
					}
					result = ObstacleType.Train;
				}
			}
			else if ((nint)obj != 838486338)
			{
				if ((nint)obj != 1161371237)
				{
					if ((nint)obj != 1732711450 || !(text == "HitPillar"))
					{
						goto IL_0409;
					}
					result = ObstacleType.Pillar;
				}
				else
				{
					bool flag = text != "HitStationPlatform";
					result = ObstacleType.StationPlatform;
					if (flag)
					{
						goto IL_0409;
					}
				}
			}
			else
			{
				if (!(text == "HitGates"))
				{
					goto IL_0409;
				}
				result = ObstacleType.Gates;
			}
		}
		else if ((nint)obj <= -654871998)
		{
			if ((nint)obj != -672978903)
			{
				if ((nint)obj != -654871998)
				{
					if ((nint)obj != 1751097060 || !(text == "HitBarrierStandard"))
					{
						goto IL_0409;
					}
					result = ObstacleType.BarrierStandard;
				}
				else
				{
					if (!(text == "HitMovingTrain"))
					{
						goto IL_0409;
					}
					result = ObstacleType.MovingTrain;
				}
			}
			else
			{
				if (!(text == "Stumble"))
				{
					goto IL_0409;
				}
				result = ObstacleType.MinorObstacle;
			}
		}
		else if ((nint)obj != -482664158)
		{
			if ((nint)obj != -284302887)
			{
				if ((nint)obj != -236442304 || !(text == "HitTrainRamp"))
				{
					goto IL_0409;
				}
				result = ObstacleType.TrainRamp;
			}
			else
			{
				if (!(text == "HitBarrierJump"))
				{
					goto IL_0409;
				}
				result = ObstacleType.BarrierJump;
			}
		}
		else
		{
			if (!(text == "HitBarrierRoll"))
			{
				goto IL_0409;
			}
			result = ObstacleType.BarrierRoll;
		}
		goto IL_0459;
		IL_0459:
		return result;
		IL_0409:
		result = ObstacleType.None;
		goto IL_0459;
	}

	private ObstaclePassType GetPassTypeFromCollider(Collider obstacleCollider)
	{
		string text = obstacleCollider.tag;
		bool flag = text != "RollBarrier";
		ObstaclePassType result = ObstaclePassType.Roll;
		if (flag)
		{
			bool flag2 = text != "JumpBarrier";
			result = ObstaclePassType.Jump;
			if (flag2)
			{
				bool flag3 = text != "JumpHighBarrier";
				ObstaclePassType result2 = ObstaclePassType.JumpHigh;
				if (flag3)
				{
					result2 = ObstaclePassType.None;
				}
				return result2;
			}
		}
		return result;
	}

	private void OnCharacterTriggerExit(Collider collider)
	{
		if (collider.CompareTag("Subway"))
		{
			if (subwayColliders.Contains(collider))
			{
				bool flag = subwayColliders.Remove(collider);
				HashSet<Collider> hashSet = subwayColliders;
				bool isInsideSubway = hashSet._count > 0;
				_isInsideSubway = isInsideSubway;
			}
			return;
		}
		ObstaclePassType passTypeFromCollider = GetPassTypeFromCollider(collider);
		if (passTypeFromCollider == _lastObstaclePassType && _lastObstaclePassTrackIndex == __trackIndex)
		{
			OnPassedObstacleDelegate onPassedObstacle = this.m_OnPassedObstacle;
			if (this.m_OnPassedObstacle != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v97.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
			}
		}
		if (passTypeFromCollider == ObstaclePassType.Roll)
		{
			OnRollGuardDelegate onRollGuard = this.m_OnRollGuard;
			if (this.m_OnRollGuard != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v99.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
			}
		}
	}

	private unsafe void OnCharacterTriggerEnter(Collider collider)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_1083: Expected F4, but got I
		//IL_005a: Expected Obj, but got I
		//IL_00bd: Expected Obj, but got I
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Expected VT, but got Unknown
		//IL_00e1: Expected Ref, but got VT
		//IL_0603: Expected Obj, but got I
		//IL_0619: Unknown result type (might be due to invalid IL or missing references)
		//IL_061e: Expected VT, but got Unknown
		//IL_0627: Expected Ref, but got VT
		//IL_0661: Expected Obj, but got I
		//IL_0677: Unknown result type (might be due to invalid IL or missing references)
		//IL_067c: Expected VT, but got Unknown
		//IL_0685: Expected Ref, but got VT
		//IL_06cf: Invalid comparison between Obj and F4
		//IL_06f4: Expected Obj, but got I4
		//IL_1145: Expected Obj, but got I
		//IL_1171: Expected I, but got Obj
		//IL_11a2: Expected Obj, but got I
		//IL_11b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_11bd: Expected VT, but got Unknown
		//IL_11c6: Expected Ref, but got VT
		//IL_070a: Invalid comparison between F4 and Obj
		//IL_0724: Expected Obj, but got I4
		//IL_078f: Expected Obj, but got I4
		//IL_0797: Unknown result type (might be due to invalid IL or missing references)
		//IL_079c: Expected Obj, but got Unknown
		//IL_11e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_11eb: Expected Obj, but got Unknown
		//IL_0de3: Expected Obj, but got I4
		//IL_0842: Expected Obj, but got I
		//IL_0858: Unknown result type (might be due to invalid IL or missing references)
		//IL_085d: Expected VT, but got Unknown
		//IL_0866: Expected Ref, but got VT
		//IL_0c05: Expected Obj, but got I4
		//IL_0881: Expected F4, but got I
		//IL_0c44: Expected Obj, but got I
		//IL_0c5a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c5f: Expected VT, but got Unknown
		//IL_0c68: Expected Ref, but got VT
		//IL_0cd5: Expected Obj, but got I4
		//IL_0cdd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ce2: Expected Obj, but got Unknown
		//IL_0c83: Invalid comparison between F4 and I
		//IL_0ca0: Expected Obj, but got I4
		//IL_0cb7: Expected Obj, but got I4
		object obj = default;
		Character character = (Character)(obj - 48);
		character.MysteryPowerupParticleSystem = null;
		character.CoinMagnetLongCollider = null;
		character.CharacterTriggerNotifier = null;
		Transform transform = base.transform;
		Vector3 position = transform.position;
		hitPoistionDistance = (nint)((UnityEngine.Object)character).m_CachedPtr;
		Game game = _game;
		Variable<bool> isInGame = game.IsInGame;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S0_v16 (Variable`1<System.Boolean>)+8]");
		if ((nint)0 == 0)
		{
			return;
		}
		ImpactX obstacleImpactX;
		ImpactY characterImpactY;
		ImpactZ obstacleImpactZ;
		bool flag7;
		if (collider.CompareTag("Subway"))
		{
			nint num = 0;
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v271 @ S3_v29 (Il2CppRgctx<System.Collections.Generic.HashSet`1<UnityEngine.Collider>>)+3C]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v272 @ S3_v30+4] (should have been resolved before IL gen)");
			HashSet<Collider> hashSet = subwayColliders;
			bool isInsideSubway = hashSet._count > 0;
			_isInsideSubway = isInsideSubway;
			Bounds bounds = collider.bounds;
			character.MysteryPowerupParticleSystem = (ParticleSystem)(object)character._glideVerticalSpeed;
			character.CoinMagnetLongCollider = (CollisionNotifier)(nint)((UnityEngine.Object)character).m_CachedPtr;
			character.CharacterTriggerNotifier = (CollisionNotifier)(object)character;
			Bounds bounds2 = (Bounds)(character + 24);
			Vector3 max = ((Bounds*)bounds2)->max;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (SYBO.Subway.Characters.Character)+4]");
			float subwayMaxY = 0f - 3f;
			SubwayMaxY = subwayMaxY;
		}
		else
		{
			if (StopColliding)
			{
				return;
			}
			GameObject gameObject = collider.gameObject;
			int layer = gameObject.layer;
			Layers layers = _layers;
			if (layer == layers.Unremovable)
			{
				return;
			}
			Game game2 = _game;
			if (game2._isInStumbleDeathSequence)
			{
				return;
			}
			GameObject gameObject2 = collider.gameObject;
			int layer2 = gameObject2.layer;
			Layers instance = Layers.Instance;
			if (layer2 == instance.Pickup)
			{
				PickupSpawnPoint component = collider.GetComponent<PickupSpawnPoint>();
				if (component != null && component.__spawnPointState == SpawnPointState.Spawned)
				{
					component.TriggerCollisionWithCharacter(CharacterPickupParticleSystem);
				}
			}
			Coin component2 = collider.GetComponent<Coin>();
			if (component2 != null)
			{
				component2.Pickup(CharacterPickupParticleSystem);
			}
			GameObject gameObject3 = collider.gameObject;
			int layer3 = gameObject3.layer;
			Layers layers2 = _layers;
			if (layer3 == layers2.Hit)
			{
				ObstacleType obstacleTypeFromTag = character.GetObstacleTypeFromTag(collider);
				if (obstacleTypeFromTag != ObstacleType.None)
				{
					_lastObstacleType = obstacleTypeFromTag;
					Game game3 = _game;
					game3.SpeedAtLastObstacleHit = game3.__currentSpeed;
				}
			}
			GameObject gameObject4 = collider.gameObject;
			int layer4 = gameObject4.layer;
			Layers layers3 = _layers;
			if (layer4 != layers3.Default)
			{
				GameObject gameObject5 = collider.gameObject;
				int layer5 = gameObject5.layer;
				Layers layers4 = _layers;
				if (layer5 != layers4.Ramp)
				{
					if (collider.isTrigger)
					{
						GameObject gameObject6 = collider.gameObject;
						int layer6 = gameObject6.layer;
						Layers layers5 = _layers;
						if (layer6 == layers5.Hit)
						{
							bool flag = collider.CompareTag("Stumble");
							string colliderName = collider.name;
							if (flag)
							{
								HandleStumble(StumbleType.Bush, StumbleHorizontalHit.Center, StumbleVerticalHit.Lower, colliderName);
							}
							else
							{
								HandleStumble(StumbleType.Normal, StumbleHorizontalHit.Center, StumbleVerticalHit.Middle, colliderName);
							}
						}
						return;
					}
					if (DebugSettings.IsAllowed && DebugSettings.CharacterInvincible)
					{
						return;
					}
					string lastHitTag = collider.tag;
					_lastHitTag = lastHitTag;
					obstacleImpactX = GetObstacleImpactX(collider);
					characterImpactY = GetCharacterImpactY(collider);
					obstacleImpactZ = GetObstacleImpactZ(collider);
					Bounds bounds3 = collider.bounds;
					character.MysteryPowerupParticleSystem = (ParticleSystem)(object)character._glideVerticalSpeed;
					character.CoinMagnetLongCollider = (CollisionNotifier)(nint)((UnityEngine.Object)character).m_CachedPtr;
					character.CharacterTriggerNotifier = (CollisionNotifier)(object)character;
					Bounds bounds4 = (Bounds)(character + 24);
					Vector3 min = ((Bounds*)bounds4)->min;
					Bounds bounds5 = collider.bounds;
					character.MysteryPowerupParticleSystem = (ParticleSystem)(object)character._glideVerticalSpeed;
					character.CoinMagnetLongCollider = (CollisionNotifier)(nint)((UnityEngine.Object)character).m_CachedPtr;
					character.CharacterTriggerNotifier = (CollisionNotifier)(object)character;
					Bounds bounds6 = (Bounds)(character + 24);
					Vector3 max2 = ((Bounds*)bounds6)->max;
					object obj3 = (object)character + (object)character;
					Transform transform2 = base.transform;
					Vector3 position2 = transform2.position;
					float num3 = (float)obj3 * 0.5f;
					bool flag2 = System.Runtime.CompilerServices.Unsafe.As<Character, UIntPtr>(ref character) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)num3);
					bool flag3 = !flag2;
					bool flag4 = !flag3;
					object obj4 = 1;
					if (!flag4)
					{
						bool flag5 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)num3) < System.Runtime.CompilerServices.Unsafe.As<Character, UIntPtr>(ref character);
						bool flag6 = !flag5;
						obj4 = -1;
						flag7 = true;
						if (flag6)
						{
							goto IL_1112;
						}
					}
					flag7 = _trackMovement == (nint)obj4;
					goto IL_1112;
				}
			}
			if (collider.isTrigger && _characterController.isGrounded)
			{
				throw new NullReferenceException();
			}
			if (collider.isTrigger)
			{
				ObstaclePassType passTypeFromCollider = character.GetPassTypeFromCollider(collider);
				if (passTypeFromCollider != ObstaclePassType.None)
				{
					_lastObstaclePassType = passTypeFromCollider;
					_lastObstaclePassTrackIndex = __trackIndex;
				}
			}
		}
		return;
		IL_1112:
		Bounds bounds7 = CharacterTrigger.bounds;
		character.MysteryPowerupParticleSystem = (ParticleSystem)(object)character._glideVerticalSpeed;
		character.CoinMagnetLongCollider = (CollisionNotifier)(nint)((UnityEngine.Object)character).m_CachedPtr;
		character.CharacterTriggerNotifier = (CollisionNotifier)(object)character;
		character = (Character)(object)character.CharacterTriggerNotifier;
		((UnityEngine.Object)character).m_CachedPtr = (IntPtr)character.CoinMagnetLongCollider;
		Bounds bounds8 = collider.bounds;
		character.MysteryPowerupParticleSystem = (ParticleSystem)(object)character._glideVerticalSpeed;
		character.CoinMagnetLongCollider = (CollisionNotifier)(nint)((UnityEngine.Object)character).m_CachedPtr;
		character.CharacterTriggerNotifier = (CollisionNotifier)(object)character;
		Bounds bounds9 = (Bounds)(character + 24);
		Vector3 min2 = ((Bounds*)bounds9)->min;
		bool flag8 = obstacleImpactZ == ImpactZ.Before;
		bool flag9 = (nint)((UnityEngine.Object)character).m_CachedPtr < (nint)((UnityEngine.Object)character).m_CachedPtr;
		bool flag10 = !flag9;
		object obj5 = flag8 & flag10;
		object obj6 = flag7 & obj5;
		if (~(__isJumping ? 1u : 0u) == 0 && characterImpactY == ImpactY.Upper && !_characterController.isGrounded)
		{
			_jumpUpperCollisionEvaded = false;
			_jumpUpperCollision = true;
			verticalSpeed = 0f;
			if (!_jumpUpperCollision)
			{
				Bounds bounds10 = collider.bounds;
				character.MysteryPowerupParticleSystem = (ParticleSystem)(object)character._glideVerticalSpeed;
				character.CoinMagnetLongCollider = (CollisionNotifier)(nint)((UnityEngine.Object)character).m_CachedPtr;
				character.CharacterTriggerNotifier = (CollisionNotifier)(object)character;
				Bounds bounds11 = (Bounds)(character + 24);
				Vector3 min3 = ((Bounds*)bounds11)->min;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (SYBO.Subway.Characters.Character)+4]");
				_jumpUpperCollisionColliderMinY = 0f;
			}
		}
		bool flag11 = obstacleImpactZ == ImpactZ.Middle;
		object obj7 = flag11 | obj6;
		if (obj7 != null)
		{
			if (_trackMovement != 0)
			{
				int trackDelta = -_trackMovement;
				Game game4 = _game;
				float duration = 0.2f;
				if (!game4.IsRunningOnTutorialTrack__BackingField)
				{
					duration = 0.5f;
				}
				ChangeTrackBy(trackDelta, duration);
			}
			switch (obstacleImpactX)
			{
			case ImpactX.Left:
			{
				string colliderName3 = collider.name;
				HandleStumble(StumbleType.Normal, StumbleHorizontalHit.Left, StumbleVerticalHit.Middle, colliderName3);
				break;
			}
			case ImpactX.Right:
			{
				string colliderName2 = collider.name;
				HandleStumble(StumbleType.Normal, StumbleHorizontalHit.Right, StumbleVerticalHit.Middle, colliderName2);
				break;
			}
			}
			return;
		}
		if (obstacleImpactX == ImpactX.Middle || _trackMovement == 0)
		{
			if (obstacleImpactZ != ImpactZ.Before)
			{
				return;
			}
			if (characterImpactY == ImpactY.Lower)
			{
				bool isGliderboard = IsGliderboard;
				float jumpHeight = 1.5f;
				if (!isGliderboard)
				{
					jumpHeight = 8f;
				}
				float num4 = CalculateJumpVerticalSpeed(jumpHeight);
				verticalSpeed = num4;
				if (!IsTeleboard)
				{
					string colliderName4 = collider.name;
					HandleStumble(StumbleType.Normal, StumbleHorizontalHit.Center, StumbleVerticalHit.Lower, colliderName4);
					return;
				}
				GameStats instance2 = GameStats.Instance;
				int stumbles = instance2._stumbles + 1;
				instance2._stumbles = stumbles;
				int stumblesRun = instance2._stumblesRun + 1;
				instance2._stumblesRun = stumblesRun;
				OnResetTeleportFXDelegate onResetTeleportFX = this.m_OnResetTeleportFX;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v807.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
				return;
			}
			GameObject gameObject7 = collider.gameObject;
			if (gameObject7.CompareTag("HitMovingTrain"))
			{
				HitByTrainSequence();
				NotifyCriticalHit();
				return;
			}
			if (characterImpactY == ImpactY.Middle)
			{
				if (!IsTeleboard)
				{
					string colliderName5 = collider.name;
					HandleStumble(StumbleType.Normal, StumbleHorizontalHit.Center, StumbleVerticalHit.Middle, colliderName5, safeStumble: false, isCriticalHit: true);
				}
				else
				{
					OnResetTeleportFXDelegate onResetTeleportFX2 = this.m_OnResetTeleportFX;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v818.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
				}
				NotifyCriticalHit();
				return;
			}
			bool flag12 = (byte)(~(_jumpUpperCollision ? 1u : 0u)) != 0;
			object obj8 = 1;
			if (!flag12)
			{
				Bounds bounds12 = collider.bounds;
				character.MysteryPowerupParticleSystem = (ParticleSystem)(object)character._glideVerticalSpeed;
				character.CoinMagnetLongCollider = (CollisionNotifier)(nint)((UnityEngine.Object)character).m_CachedPtr;
				character.CharacterTriggerNotifier = (CollisionNotifier)(object)character;
				Bounds bounds13 = (Bounds)(character + 24);
				Vector3 min4 = ((Bounds*)bounds13)->min;
				float jumpUpperCollisionColliderMinY = _jumpUpperCollisionColliderMinY;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (SYBO.Subway.Characters.Character)+4]");
				bool flag13 = !(jumpUpperCollisionColliderMinY > 0f);
				bool flag14 = !flag13;
				obj8 = 1;
				if (!flag14)
				{
					obj8 = 0;
				}
			}
			bool flag15 = EnteredColliderFromBelow(collider, jumpUpperCollisionRepeated: false);
			if (~(__isJumping ? 1u : 0u) == 0)
			{
				bool flag16 = (byte)(~(_jumpUpperCollision ? 1u : 0u)) != 0;
				object obj9 = (flag15 ? 1 : 0) ^ 1;
				object obj10 = flag16 | obj9;
				object obj11 = obj8 & obj10;
				if (obj11 == null)
				{
					return;
				}
			}
			if (!IsTeleboard)
			{
				string colliderName6 = collider.name;
				HandleStumble(StumbleType.Normal, StumbleHorizontalHit.Center, StumbleVerticalHit.Upper, colliderName6, safeStumble: false, isCriticalHit: true);
			}
			else
			{
				GameStats instance3 = GameStats.Instance;
				int stumbles2 = instance3._stumbles + 1;
				instance3._stumbles = stumbles2;
				int stumblesRun2 = instance3._stumblesRun + 1;
				instance3._stumblesRun = stumblesRun2;
				OnResetTeleportFXDelegate onResetTeleportFX3 = this.m_OnResetTeleportFX;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v890.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
			}
			NotifyCriticalHit();
			return;
		}
		object obj12 = flag7 & flag8;
		if (obj12 != null)
		{
			GameObject gameObject8 = collider.gameObject;
			if (gameObject8.CompareTag("HitMovingTrain"))
			{
				HitByTrainSequence();
				NotifyCriticalHit();
			}
			else if (collider.CompareTag("HitTrainRamp"))
			{
				if (!IsTeleboard)
				{
					string colliderName7 = collider.name;
					HandleStumble(StumbleType.Normal, StumbleHorizontalHit.Center, StumbleVerticalHit.Lower, colliderName7);
				}
			}
			else
			{
				int movement = -_trackMovement;
				ForceChangeTrack(movement, 0.5f);
			}
		}
		else if (collider.CompareTag("HitTrainRamp"))
		{
			int movement2 = -_trackMovement;
			ForceChangeTrack(movement2, 0.5f);
		}
		switch (obstacleImpactX)
		{
		case ImpactX.Left:
			if (!IsTeleboard)
			{
				string colliderName9 = collider.name;
				HandleStumble(StumbleType.Normal, StumbleHorizontalHit.LeftCorner, StumbleVerticalHit.Middle, colliderName9);
			}
			break;
		case ImpactX.Right:
			if (!IsTeleboard)
			{
				string colliderName8 = collider.name;
				HandleStumble(StumbleType.Normal, StumbleHorizontalHit.RightCorner, StumbleVerticalHit.Middle, colliderName8);
			}
			break;
		}
	}

	private unsafe bool EnteredColliderFromBelow(Collider collider, bool jumpUpperCollisionRepeated)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Expected Obj, but got Unknown
		//IL_002b: Expected Obj, but got I4
		//IL_006f: Expected Obj, but got I
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Expected VT, but got Unknown
		//IL_0093: Expected Ref, but got VT
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Expected VT, but got Unknown
		//IL_00b3: Expected Ref, but got VT
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Expected VT, but got Unknown
		//IL_00ce: Expected Ref, but got VT
		//IL_0143: Unknown result type (might be due to invalid IL or missing references)
		//IL_0148: Expected VT, but got Unknown
		//IL_0151: Expected Ref, but got VT
		//IL_02c2: Expected I, but got Obj
		//IL_02db: Expected F4, but got VT
		//IL_02eb: Expected F4, but got I
		//IL_02fb: Expected F4, but got I
		//IL_030e: Expected I, but got Obj
		//IL_036c: Expected Obj, but got VT
		//IL_0370: Unsupported input type for neg.
		//IL_0370: Unknown result type (might be due to invalid IL or missing references)
		//IL_0375: Expected Obj, but got Unknown
		//IL_03d7: Expected Obj, but got I
		//IL_03db: Unsupported input type for neg.
		//IL_03db: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e0: Expected Obj, but got Unknown
		//IL_0451: Expected Obj, but got I
		//IL_0455: Unsupported input type for neg.
		//IL_0455: Unknown result type (might be due to invalid IL or missing references)
		//IL_045a: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 80;
		_ = 0;
		object obj3 = obj - -64;
		obj3 = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		Bounds bounds = CharacterTrigger.bounds;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
		obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		_ = 0;
		Bounds bounds2 = (Bounds)(obj + 56);
		Vector3 max = ((Bounds*)bounds2)->max;
		Bounds bounds3 = (Bounds)(obj + 56);
		Vector3 size = ((Bounds*)bounds3)->size;
		Bounds bounds4 = (Bounds)(obj + 56);
		Vector3 size2 = ((Bounds*)bounds4)->size;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
		float num = 0f * 0.5f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
		float num2 = 0f - num;
		Bounds bounds5 = collider.bounds;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		_ = 0;
		Bounds bounds6 = (Bounds)(obj + 32);
		Vector3 min = ((Bounds*)bounds6)->min;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		float num3 = 0f * 0.5f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		float num4 = 0f - num3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		float num5 = 0f - num4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
		float num6 = 0f - 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
		float num7 = 0f - num6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
		float num8 = 0f - num2;
		float num9 = num5 * num5;
		float num10 = num7 * num7;
		float num11 = num9 + num10;
		float num12 = num8 * num8;
		float num13 = num11 + num12;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"System.Math.Sqrt not resolved\"");
		float num16;
		float num17;
		float num18;
		if (num13 > 1E-05f)
		{
			float num14 = num8 / num13;
			float num15 = num7 / num13;
			num16 = num5 / num13;
			num17 = num14;
			num18 = num15;
		}
		else
		{
			nint num19 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v188 @ S0_v84 (Il2CppClass<UnityEngine.Vector3>)+5C]");
			nint num20 = 0;
			num16 = (float)Vector3.zeroVector;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v189 @ S0_v85 (Il2CppStaticFields<UnityEngine.Vector3>)+8]");
			num17 = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v189 @ S0_v85 (Il2CppStaticFields<UnityEngine.Vector3>)+4]");
			num18 = 0f;
		}
		nint num21 = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v200 @ S0_v64 (Il2CppClass<UnityEngine.Vector3>)+5C]");
		nint num22 = 0;
		float num23 = num18;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v201 @ S0_v65 (Il2CppStaticFields<UnityEngine.Vector3>)+38]");
		float num24 = num23 * 0f;
		float num25 = num17;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v201 @ S0_v65 (Il2CppStaticFields<UnityEngine.Vector3>)+34]");
		float num26 = num25 * 0f;
		float num27 = num24 - num26;
		object obj4 = _posFixedUpdateLast - _posFixedUpdatePrevious;
		object obj5 = 0 - obj4;
		float num28 = num27 * (float)obj5;
		float num29 = num17 * (float)Vector3.leftVector;
		float num30 = num16;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v201 @ S0_v65 (Il2CppStaticFields<UnityEngine.Vector3>)+38]");
		float num31 = num30 * 0f;
		float num32 = num29 - num31;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Characters.Character)+19C]");
		nint num33 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Characters.Character)+1A8]");
		object obj6 = num33 - 0;
		object obj7 = 0 - obj6;
		float num34 = num32 * (float)obj7;
		float num35 = num28 + num34;
		float num36 = num16;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v201 @ S0_v65 (Il2CppStaticFields<UnityEngine.Vector3>)+34]");
		float num37 = num36 * 0f;
		float num38 = num18 * (float)Vector3.leftVector;
		float num39 = num37 - num38;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Characters.Character)+1A0]");
		nint num40 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Characters.Character)+1AC]");
		object obj8 = num40 - 0;
		object obj9 = 0 - obj8;
		float num41 = num39 * (float)obj9;
		float num42 = num35 + num41;
		return num42 < 0f;
	}

	private void HitByTrainSequence()
	{
		Hoverboard hoverboard = _hoverboard;
		if (~(hoverboard.isActive ? 1u : 0u) == 0)
		{
			OnJumpIfHitByTrainDelegate onJumpIfHitByTrain = this.m_OnJumpIfHitByTrain;
			if (this.m_OnJumpIfHitByTrain != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v6.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
			}
		}
		else
		{
			OnHitByTrainDelegate onHitByTrain = this.m_OnHitByTrain;
			if (this.m_OnHitByTrain != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v10.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
			}
		}
	}

	private unsafe ImpactX GetObstacleImpactX(Collider collider)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Expected Obj, but got Unknown
		//IL_002b: Expected Obj, but got I4
		//IL_006f: Expected Obj, but got I
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Expected VT, but got Unknown
		//IL_00cc: Expected Ref, but got VT
		//IL_00e0: Expected Obj, but got I
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ee: Expected VT, but got Unknown
		//IL_00f7: Expected Ref, but got VT
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Expected VT, but got Unknown
		//IL_0117: Expected Ref, but got VT
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Expected VT, but got Unknown
		//IL_0132: Expected Ref, but got VT
		//IL_0144: Unknown result type (might be due to invalid IL or missing references)
		//IL_0149: Expected VT, but got Unknown
		//IL_0152: Expected Ref, but got VT
		//IL_0216: Expected Obj, but got I
		//IL_0266: Unknown result type (might be due to invalid IL or missing references)
		//IL_026b: Expected VT, but got Unknown
		//IL_0274: Expected Ref, but got VT
		//IL_0192: Expected Obj, but got I
		//IL_01a7: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 80;
		_ = 0;
		object obj3 = obj - -64;
		obj3 = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		Bounds bounds = CharacterTrigger.bounds;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
		obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		_ = 0;
		Bounds bounds2 = collider.bounds;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		_ = 0;
		Bounds bounds3 = (Bounds)(obj + 56);
		Vector3 min = ((Bounds*)bounds3)->min;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		object obj4 = 0;
		Bounds bounds4 = (Bounds)(obj + 32);
		Vector3 min2 = ((Bounds*)bounds4)->min;
		Bounds bounds5 = (Bounds)(obj + 56);
		Vector3 max = ((Bounds*)bounds5)->max;
		Bounds bounds6 = (Bounds)(obj + 32);
		Vector3 max2 = ((Bounds*)bounds6)->max;
		Bounds bounds7 = (Bounds)(obj + 32);
		Vector3 min3 = ((Bounds*)bounds7)->min;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		if (num <= 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
			obj4 = 0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		bool flag = num2 < 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		object obj5 = 0;
		if (!flag)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
			obj5 = 0;
		}
		object obj6 = obj4 + obj5;
		float num3 = (float)obj6 * 0.5f;
		float num4 = num3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		float num5 = num4 - 0f;
		Bounds bounds8 = (Bounds)(obj + 32);
		Vector3 size = ((Bounds*)bounds8)->size;
		double num6 = (double)ColliderTrackWidth * 0.33;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		double num7 = 0.0 - num6;
		bool flag2 = (double)num5 > num7;
		bool flag3 = !flag2;
		bool flag4 = !flag3;
		bool result = true;
		if (!flag4)
		{
			double num8 = (double)ColliderTrackWidth * 0.33;
			bool flag5 = (double)num5 < num8;
			bool flag6 = !flag5;
			result = flag6;
		}
		return result ? ImpactX.Middle : ImpactX.Left;
	}

	private unsafe ImpactZ GetObstacleImpactZ(Collider collider)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Expected VT, but got Unknown
		//IL_007f: Expected Ref, but got VT
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Expected VT, but got Unknown
		//IL_009f: Expected Ref, but got VT
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Expected VT, but got Unknown
		//IL_00ba: Expected Ref, but got VT
		//IL_00e0: Expected Obj, but got I
		//IL_00e9: Invalid comparison between Obj and F4
		//IL_0120: Unknown result type (might be due to invalid IL or missing references)
		//IL_0125: Expected VT, but got Unknown
		//IL_012e: Expected Ref, but got VT
		//IL_013b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0140: Expected VT, but got Unknown
		//IL_0149: Expected Ref, but got VT
		//IL_016f: Expected Obj, but got I
		//IL_020d: Invalid comparison between I and F4
		//IL_018d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0192: Expected VT, but got Unknown
		//IL_019b: Expected Ref, but got VT
		//IL_01c8: Invalid comparison between I and F4
		object obj2 = default;
		object obj = obj2 - 48;
		_ = 0;
		_ = 0;
		_ = 0;
		Transform transform = base.transform;
		Vector3 position = transform.position;
		Bounds bounds = collider.bounds;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		_ = 0;
		Bounds bounds2 = (Bounds)(obj + 24);
		Vector3 max = ((Bounds*)bounds2)->max;
		Bounds bounds3 = (Bounds)(obj + 24);
		Vector3 max2 = ((Bounds*)bounds3)->max;
		Bounds bounds4 = (Bounds)(obj + 24);
		Vector3 min = ((Bounds*)bounds4)->min;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		object obj3 = num - 0;
		float num2;
		if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj3) > System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)30f))
		{
			num2 = stumbleCornerTolerance;
		}
		else
		{
			Bounds bounds5 = (Bounds)(obj + 24);
			Vector3 max3 = ((Bounds*)bounds5)->max;
			Bounds bounds6 = (Bounds)(obj + 24);
			Vector3 min2 = ((Bounds*)bounds6)->min;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
			nint num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
			object obj4 = num3 - 0;
			num2 = (float)obj4 * 0.5f;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		float num4 = 0f - num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		bool flag = 0f > num4;
		bool flag2 = !flag;
		bool flag3 = !flag2;
		bool result = true;
		if (!flag3)
		{
			Bounds bounds7 = (Bounds)(obj + 24);
			Vector3 min3 = ((Bounds*)bounds7)->min;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
			float num5 = 0f + stumbleCornerTolerance;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
			bool flag4 = 0f < num5;
			bool flag5 = !flag4;
			result = flag5;
		}
		return result ? ImpactZ.Middle : ImpactZ.Before;
	}

	private unsafe ImpactY GetCharacterImpactY(Collider collider)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Expected Obj, but got Unknown
		//IL_002b: Expected Obj, but got I4
		//IL_006f: Expected Obj, but got I
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Expected VT, but got Unknown
		//IL_00cc: Expected Ref, but got VT
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Expected VT, but got Unknown
		//IL_00e7: Expected Ref, but got VT
		//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fe: Expected VT, but got Unknown
		//IL_0107: Expected Ref, but got VT
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		//IL_0119: Expected VT, but got Unknown
		//IL_0122: Expected Ref, but got VT
		//IL_0134: Unknown result type (might be due to invalid IL or missing references)
		//IL_0139: Expected VT, but got Unknown
		//IL_0142: Expected Ref, but got VT
		//IL_014f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0154: Expected VT, but got Unknown
		//IL_015d: Expected Ref, but got VT
		//IL_0194: Expected Obj, but got I
		//IL_0207: Expected Obj, but got I
		//IL_01b2: Expected Obj, but got I
		//IL_01c7: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 80;
		_ = 0;
		object obj3 = obj - -64;
		obj3 = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		Bounds bounds = CharacterTrigger.bounds;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
		obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		_ = 0;
		Bounds bounds2 = collider.bounds;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		_ = 0;
		Bounds bounds3 = (Bounds)(obj + 56);
		Vector3 min = ((Bounds*)bounds3)->min;
		Bounds bounds4 = (Bounds)(obj + 32);
		Vector3 min2 = ((Bounds*)bounds4)->min;
		Bounds bounds5 = (Bounds)(obj + 56);
		Vector3 max = ((Bounds*)bounds5)->max;
		Bounds bounds6 = (Bounds)(obj + 32);
		Vector3 max2 = ((Bounds*)bounds6)->max;
		Bounds bounds7 = (Bounds)(obj + 56);
		Vector3 min3 = ((Bounds*)bounds7)->min;
		Bounds bounds8 = (Bounds)(obj + 56);
		Vector3 size = ((Bounds*)bounds8)->size;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
		bool flag = num > 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
		object obj4 = 0;
		if (!flag)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
			obj4 = 0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
		bool flag2 = num2 < 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
		object obj5 = 0;
		if (!flag2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
			obj5 = 0;
		}
		object obj6 = obj4 + obj5;
		float num3 = (float)obj6 * 0.5f;
		float num4 = num3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
		float num5 = num4 - 0f;
		float num6 = num5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
		float num7 = num6 / 0f;
		bool flag3 = num7 < 0.66f;
		bool flag4 = num7 < 0.33f;
		ImpactY result = ImpactY.Lower;
		if (!flag4)
		{
			result = (flag3 ? ImpactY.Middle : ImpactY.Upper);
		}
		return result;
	}

	private void ExecuteKillSwitch()
	{
		LastDeathCause = DeathCause.KillSwitch;
		_game.Die();
	}

	private bool AllowDoubleJump()
	{
		bool result;
		if (IsDoubleJumping)
		{
			result = true;
			if (_willSecondJump)
			{
				goto IL_004a;
			}
		}
		result = false;
		goto IL_004a;
		IL_004a:
		return result;
	}

	private bool IsRunningFromTrain()
	{
		//IL_001d: Expected Obj, but got I4
		RunningState runningState = _runningState;
		object obj = runningState.currentRunPosition & (RunningState.RunPositions)(-2);
		return (nint)obj == 2;
	}

	private bool IsRunningOnGround()
	{
		RunningState runningState = _runningState;
		return runningState.currentRunPosition == RunningState.RunPositions.ground;
	}

	private unsafe void ExpandColliders()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0088: Expected I, but got Obj
		//IL_00a7: Expected Obj, but got VT
		//IL_00c4: Expected Obj, but got I
		//IL_00e1: Expected Obj, but got I
		//IL_0113: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Expected VT, but got Unknown
		//IL_013e: Expected I, but got Obj
		//IL_015d: Expected Obj, but got VT
		//IL_017a: Expected Obj, but got I
		//IL_0197: Expected Obj, but got I
		//IL_01b1: Expected F4, but got I
		//IL_01ac: Expected native int or pointer, but got VT
		//IL_01d0: Expected F4, but got I
		//IL_01cb: Expected native int or pointer, but got VT
		object obj = default;
		Vector3 vector = (Vector3)(obj + -64);
		if (_characterController.enabled)
		{
			nint num = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S0_v47 (Il2CppClass<UnityEngine.Vector3>)+5C]");
			nint num2 = 0;
			object obj2 = Vector3.upVector + Vector3.upVector;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ S0_v48 (Il2CppStaticFields<UnityEngine.Vector3>)+1C]");
			nint num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ S0_v48 (Il2CppStaticFields<UnityEngine.Vector3>)+1C]");
			object obj3 = num3 + 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ S0_v48 (Il2CppStaticFields<UnityEngine.Vector3>)+20]");
			nint num4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ S0_v48 (Il2CppStaticFields<UnityEngine.Vector3>)+20]");
			object obj4 = num4 + 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+38]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+30]");
			_ = 0;
			Vector3 motion = vector + 16;
			CollisionFlags collisionFlags = _characterController.Move(motion);
		}
		_squeezeCollider.Remove(this);
		if (_characterController.enabled)
		{
			nint num5 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ S0_v22 (Il2CppClass<UnityEngine.Vector3>)+5C]");
			nint num6 = 0;
			object obj5 = Vector3.downVector + Vector3.downVector;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ S0_v23 (Il2CppStaticFields<UnityEngine.Vector3>)+28]");
			nint num7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ S0_v23 (Il2CppStaticFields<UnityEngine.Vector3>)+28]");
			object obj6 = num7 + 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ S0_v23 (Il2CppStaticFields<UnityEngine.Vector3>)+2C]");
			nint num8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ S0_v23 (Il2CppStaticFields<UnityEngine.Vector3>)+2C]");
			object obj7 = num8 + 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+28]");
			((Vector3*)(nint)vector)->z = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+20]");
			((Vector3*)(nint)vector)->x = 0f;
			CollisionFlags collisionFlags2 = _characterController.Move(vector);
		}
	}

	private void StartStumble(bool safeStumble = false)
	{
		bool isStumbling = (byte)((safeStumble ? 1u : 0u) ^ 1u) != 0;
		_isStumbling = isStumbling;
		Game game = _game;
		if (~(game.IsRunningOnTutorialTrack__BackingField ? 1u : 0u) != 0)
		{
			_followingGuard.CatchUp();
		}
		IEnumerator routine = StumbleDecay();
		Coroutine coroutine = _followingGuard.StartCoroutine(routine);
	}

	private IEnumerator StumbleDecay()
	{
		_ = 0;
		IEnumerator result = default;
		return result;
	}

	public void RequestStumble(StumbleType stumbleType, StumbleHorizontalHit horizontalHit, StumbleVerticalHit verticalHit, string colliderName)
	{
		HandleStumble(stumbleType, horizontalHit, verticalHit, colliderName);
	}

	public void RequestSafeStumble(StumbleType stumbleType, StumbleHorizontalHit horizontalHit, StumbleVerticalHit verticalHit, string colliderName)
	{
		HandleStumble(stumbleType, horizontalHit, verticalHit, colliderName, safeStumble: true);
		_isStumbling = false;
	}

	private void HandleStumble(StumbleType stumbleType, StumbleHorizontalHit horizontalHit, StumbleVerticalHit verticalHit, string colliderName, bool safeStumble = false, bool isCriticalHit = false)
	{
		if (!isCriticalHit)
		{
			GameStats instance = GameStats.Instance;
			int stumbles = instance._stumbles + 1;
			instance._stumbles = stumbles;
			int stumblesRun = instance._stumblesRun + 1;
			instance._stumblesRun = stumblesRun;
		}
		if (!_game.IsInJetpackMode && !_game.IsInPogostickMode)
		{
			OnStumbleDelegate onStumble = this.m_OnStumble;
			if (this.m_OnStumble != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v60.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
			}
			StartStumble(safeStumble);
		}
	}

	private IEnumerator LaneSwitchJump(Vector3 start, Vector3 end, float jumpHeight, float jumpsPerLaneSwitch)
	{
		_ = 0;
		_ = start.z;
		_ = start.x;
		_ = end.x;
		_ = end.z;
		IEnumerator result = default;
		return result;
	}

	private void NotifyCriticalHit()
	{
		//IL_0044: Expected Obj, but got I4
		//IL_006f: Expected Obj, but got I4
		//IL_009a: Expected Obj, but got I4
		//IL_00c5: Expected Obj, but got I4
		//IL_00dc: Expected Obj, but got I4
		LastDeathCause = DeathCause.CriticalHit;
		if (this.m_OnCriticalHit == null)
		{
			return;
		}
		if (_lastHitTag != "HitTrain")
		{
			bool flag = _lastHitTag != "HitBarrierStandard";
			object obj = 1;
			if (flag)
			{
				bool flag2 = _lastHitTag != "HitBarrierJump";
				obj = 1;
				if (flag2)
				{
					bool flag3 = _lastHitTag != "HitBarrierRoll";
					obj = 1;
					if (flag3)
					{
						bool flag4 = _lastHitTag != "HitMovingTrain";
						object obj2 = 2;
						if (flag4)
						{
							obj2 = 3;
						}
						obj = obj2;
					}
				}
			}
		}
		OnCriticalHitDelegate onCriticalHit = this.m_OnCriticalHit;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v73.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
	}

	private void NotifyOnStumble(StumbleType stumbleType, StumbleHorizontalHit horizontalHit, StumbleVerticalHit verticalHit, string colliderName, bool safeStumble)
	{
		OnStumbleDelegate onStumble = this.m_OnStumble;
		if (this.m_OnStumble != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v2.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
		}
	}

	private void NotifyOnCriticalHit(CriticalHitType type)
	{
		OnCriticalHitDelegate onCriticalHit = this.m_OnCriticalHit;
		if (this.m_OnCriticalHit != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v2.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
		}
	}

	private void NotifyOnJump(float jumpHeight, bool willPlaySound)
	{
		OnJumpDelegate onJump = this.m_OnJump;
		if (this.m_OnJump != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v2.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
		}
	}

	private void NotifyOnDoubleJump()
	{
		OnDoubleJumpDelegate onDoubleJump = this.m_OnDoubleJump;
		if (this.m_OnDoubleJump != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v2.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
		}
	}

	private void NotifyOnJumpIfHitByTrain()
	{
		OnJumpIfHitByTrainDelegate onJumpIfHitByTrain = this.m_OnJumpIfHitByTrain;
		if (this.m_OnJumpIfHitByTrain != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v2.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
		}
	}

	public void NotifyOnLanding()
	{
		Action<Character> onLanding = this.m_OnLanding;
		if (this.m_OnLanding != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v2 @ S0_v2 (System.Action`1<SYBO.Subway.Characters.Character>)+C] (should have been resolved before IL gen)");
		}
	}

	private void NotifyOnHangtime()
	{
		OnHangtimeDelegate onHangtime = this.m_OnHangtime;
		if (this.m_OnHangtime != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v2.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
		}
	}

	private void NotifyOnRoll()
	{
		OnRollDelegate onRoll = this.m_OnRoll;
		if (this.m_OnRoll != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v2.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
		}
	}

	private void NotifyOnHitByTrain()
	{
		OnHitByTrainDelegate onHitByTrain = this.m_OnHitByTrain;
		if (this.m_OnHitByTrain != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v2.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
		}
	}

	private void NotifyOnChangeTrack(OnChangeTrackDirection direction)
	{
		OnChangeTrackDelegate onChangeTrack = this.m_OnChangeTrack;
		if (this.m_OnChangeTrack != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v2.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
		}
	}

	private void NotifyOnTutorialMoveBackToCheckPoint(float duration)
	{
		OnTutorialMoveBackToCheckPointDelegate onTutorialMoveBackToCheckPoint = this.m_OnTutorialMoveBackToCheckPoint;
		if (this.m_OnTutorialMoveBackToCheckPoint != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v2.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
		}
	}

	private void NotifyOnTutorialStartFromCheckPoint()
	{
		OnTutorialStartFromCheckPointDelegate onTutorialStartFromCheckPoint = this.m_OnTutorialStartFromCheckPoint;
		if (this.m_OnTutorialStartFromCheckPoint != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v2.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
		}
	}

	private void NotifyOnJumpOverTrain()
	{
		OnJumpOverTrainDelegate onJumpOverTrain = this.m_OnJumpOverTrain;
		if (this.m_OnJumpOverTrain != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v2.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
		}
	}

	public void ToggleDust(bool active)
	{
		Action<bool> onToggleDust = OnToggleDust;
		if (OnToggleDust != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v2 @ S0_v2 (System.Action`1<System.Boolean>)+C] (should have been resolved before IL gen)");
		}
	}

	private void RaiseOnToggleDust(bool active)
	{
		Action<bool> onToggleDust = OnToggleDust;
		if (OnToggleDust != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v2 @ S0_v2 (System.Action`1<System.Boolean>)+C] (should have been resolved before IL gen)");
		}
	}

	public void RaiseOnEnterRoute()
	{
		Action onEnterRoute = OnEnterRoute;
		if (OnEnterRoute != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v2.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
		}
	}

	public void RaiseOnEnterRouteEnd()
	{
		Action onEnterRouteEnd = OnEnterRouteEnd;
		if (OnEnterRouteEnd != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v2.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
		}
	}

	private void RaiseExitRoute()
	{
		Action onExitRoute = OnExitRoute;
		if (OnExitRoute != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v2.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
		}
	}

	private void IsGrounded_OnChange(bool value)
	{
		if (~(__isInLipFlight ? 1u : 0u) == 0)
		{
			__isInLipFlight = false;
		}
	}

	private void RouteManager_OnRouteCreated(object sender, RouteManager.RouteCreatedEventArgs args)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @238");
		UnityEngine.Object obj = default;
		if (obj != null)
		{
			SubscribeToAlternateRoute((AlternateRoute)obj);
		}
	}

	private void SubscribeToAlternateRoute(AlternateRoute alternateRoute)
	{
		throw new ArgumentException();
	}

	private void AlternateRoute_OnCharacterEntryStarted(object sender, EventArgs args)
	{
	}

	private void AlternateRoute_OnDestructing(object sender, EventArgs args)
	{
		UIScreenController instance = UIScreenController.Instance;
		string topScreenName = instance.GetTopScreenName();
		if (!topScreenName.Equals("IngameUI"))
		{
			ResetAfterRoute(isRouteDestructing: true);
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @238");
		UnityEngine.Object obj = default;
		if (obj != null)
		{
			throw new ArgumentException();
		}
	}

	private void AlternateRoute_OnCharacterEntered(object sender, EventArgs args)
	{
		_characterModel.IsVisibleShadow = false;
		_stumbleState = StumbleState.Safe;
	}

	private void AlternateRoute_OnCharacterEntrySkipped(object sender, Route.CharacterEntrySkippedEventArgs args)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [args @ L2 (System.Object)+8]");
		if ((nint)0 != 0)
		{
			IEnumerator routine = ResetAfterRouteDelayed(isRouteDestructing: false);
			Coroutine coroutine = StartCoroutine(routine);
		}
	}

	private IEnumerator ResetAfterRouteDelayed(bool isRouteDestructing)
	{
		_ = 0;
		IEnumerator result = default;
		return result;
	}

	public void ResetAfterRoute(bool isRouteDestructing)
	{
		Action<bool> onRouteDone = OnRouteDone;
		if (OnRouteDone != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v2 @ S0_v2 (System.Action`1<System.Boolean>)+C] (should have been resolved before IL gen)");
		}
		Game game = _game;
		CharacterModifierCollection modifiers = game._modifiers;
		Hoverboard hoverboard = modifiers.hoverboard;
		if (~(hoverboard.isActive ? 1u : 0u) != 0)
		{
			_characterModel.RemoveCurrentHoverboard();
		}
		Game game2 = _game;
		if (!isRouteDestructing)
		{
			game2._modifiers.Resume();
			_game.EnableEnemy();
		}
		else
		{
			game2._modifiers.Reset();
		}
	}

	public Character()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Expected Obj, but got Unknown
		//IL_0183: Unknown result type (might be due to invalid IL or missing references)
		//IL_0188: Expected Obj, but got Unknown
		//IL_019d: Expected Obj, but got F4
		//IL_01e0: Expected Obj, but got I
		//IL_01fd: Expected I, but got Obj
		//IL_0238: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 - 128;
		_glideTime = 1f;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0f;
		_ = 0f;
		_ = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+78]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+70]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+68]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+60]");
		_ = 0;
		object obj3 = obj + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @62F");
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		object obj4 = obj - -64;
		_ = 0;
		_ = 1f;
		obj4 = 1f;
		_ = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+58]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+50]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+48]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+40]");
		obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @62F");
		AnimationCurve animationCurve = default;
		Keyframe[] keys = default;
		animationCurve._002Ector(keys);
		_glideVerticalSpeed = animationCurve;
		stumbleCornerTolerance = 15f;
		jumpHeightSuperSneakers = 40f;
		gravity = 200f;
		superSneakersJumpApexRatio = 0.5f;
		ColliderTrackWidth = 17f;
		_ = 0;
		Variable<bool> isGrounded = default;
		IsGrounded = isGrounded;
		SetPieceForgivingJumpTime = -1f;
		VariableBool variableBool = default;
		variableBool._002Ector();
		_squeezeCollider = variableBool;
		_jumpUpperCollisionEvaded = true;
		_initialTrackIndex = 1;
		_killSwitchUpdates = 5;
		_characterAngle = 45f;
		nint num = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ S0_v70 (Il2CppClass<UnityEngine.Vector3>)+5C]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v157 @ S0_v71 (Il2CppStaticFields<UnityEngine.Vector3>)+8]");
		_ = 0;
		_posFixedUpdateLast = Vector3.zeroVector;
		nint num3 = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v176 @ S0_v80 (Il2CppClass<UnityEngine.Vector3>)+5C]");
		nint num4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v177 @ S0_v81 (Il2CppStaticFields<UnityEngine.Vector3>)+8]");
		_ = 0;
		_posFixedUpdatePrevious = Vector3.zeroVector;
		HashSet<Collider> hashSet = default;
		hashSet._002Ector();
		subwayColliders = hashSet;
		_verticalSpeed_jumpTolerance = -30f;
		_trainJumpSampleLength = 10f;
		base._002Ector();
	}

	private void _003CInitialize_003Eb__310_0(bool isInGame)
	{
		if (!isInGame)
		{
			StopAllCoroutines();
			ImmuneToCriticalHit = false;
			_characterController.enabled = true;
			StopColliding = false;
		}
	}

	private unsafe void _003CInitialize_003Eb__310_1(bool squeeze)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0107: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Expected VT, but got Unknown
		//IL_014e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Expected VT, but got Unknown
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Expected VT, but got Unknown
		//IL_00b9: Expected F4, but got I
		//IL_00b4: Expected native int or pointer, but got VT
		//IL_00cc: Expected native int or pointer, but got VT
		object obj = default;
		Vector3 vector = (Vector3)(obj - 96);
		if (squeeze)
		{
			_characterController.height = 4f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Characters.Character)+13C]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+58]");
			_ = 0;
			_ = 4611686018427387904L;
			_ = 4611686018427387904L;
			Vector3 center = vector + 16;
			_characterController.center = center;
			CharacterTrigger.height = 4f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Characters.Character)+150]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+48]");
			((Vector3*)(nint)vector)->z = 0f;
			_ = 4647714815446351872L;
			((Vector3*)(nint)vector)->x = 0f;
			CharacterTrigger.center = vector;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Characters.Character)+13C]");
			_ = 0;
			_ = _characterControllerCenter;
			Vector3 center2 = vector + 48;
			_characterController.center = center2;
			_characterController.height = _characterControllerHeight;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Characters.Character)+150]");
			_ = 0;
			_ = _characterColliderCenter;
			Vector3 center3 = vector + 32;
			CharacterTrigger.center = center3;
			CharacterTrigger.height = _characterColliderHeight;
		}
	}
}
