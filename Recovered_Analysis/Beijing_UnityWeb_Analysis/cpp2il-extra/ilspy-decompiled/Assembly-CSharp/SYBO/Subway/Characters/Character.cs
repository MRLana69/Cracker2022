using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using InApp;
using InAppPurchase;
using Info;
using Kiloo.Common.Backend.PurchaseValidation;
using Kiloo.Common.HTTP;
using Kiloo.Common.Utility;
using Missions;
using SYBO.Common;
using SYBO.Common.StateSystem;
using SYBO.Common.Utilities;
using SYBO.Components.Utilities;
using SYBO.Subway.Benchmarking;
using SYBO.Subway.Cameras;
using SYBO.Subway.Coins;
using SYBO.Subway.Level;
using SYBO.Subway.Pickups;
using SYBO.Subway.Pickups.Pickers;
using SYBO.Subway.Placeholders;
using SYBO.Subway.Placeholders.Lifecycles;
using SYBO.Subway.Rendering;
using SYBO.Subway.Routes;
using SYBO.Subway.Routes.Builders;
using SYBO.Subway.StateSystem;
using SYBO.Subway.Themes;
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

	public enum RunPositions
	{
		ground,
		station,
		train,
		movingTrain,
		air
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

	[StructLayout((LayoutKind)0, Size = 16)]
	private struct SuperSneakersJump
	{
		public float StartGamePositionZ;

		public float Length;

		public float EndGamePositionZ;

		public float StartGamePositionY;
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

	private sealed class _003CToggleDustWithDelay_003Ed__357 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public float delay;

		public Character _003C_003E4__this;

		object IEnumerator<object>.Current
		{
			get
			{
				//IL_006a: Unknown result type (might be due to invalid IL or missing references)
				//IL_006f: Expected Obj, but got Unknown
				//IL_008b: Expected Obj, but got I4
				//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
				//IL_00ee: Expected Obj, but got Unknown
				//IL_00f7: Expected Obj, but got I4
				//IL_010b: Expected Obj, but got I4
				Character character = _003C_003E4__this;
				if (_003C_003E1__state != 0)
				{
					if (_003C_003E1__state != 1)
					{
						if (_003C_003E1__state == 2)
						{
							_003C_003E1__state = -1;
							return null;
						}
						return null;
					}
					_003C_003E1__state = -1;
					if (character.OnToggleDust != null)
					{
						character.OnToggleDust(obj: false);
					}
					character._longMagnet._002Ector();
					object obj = this + 12;
					obj = 0;
					_003C_003E1__state = 2;
					return 1;
				}
				_003C_003E1__state = -1;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				_ = delay;
				object obj2 = this + 12;
				object obj3 = default;
				obj2 = obj3;
				_003C_003E1__state = 1;
				return 1;
			}
		}

		object IEnumerator.Current => _003C_003E2__current;

		public _003CToggleDustWithDelay_003Ed__357(int _003C_003E1__state)
		{
			throw new InvalidOperationException();
		}

		void IDisposable.Dispose()
		{
			//IL_0015: Expected Obj, but got I
			//IL_007e: Expected Obj, but got I4
			//IL_0050: Expected Obj, but got I
			//IL_0060: Expected Obj, but got I
			//IL_00b6: Expected Obj, but got I
			//IL_00c6: Expected Obj, but got I
			//IL_011b: Expected Obj, but got I
			//IL_0138: Expected Obj, but got I4
			//IL_037a: Expected Obj, but got I
			//IL_0383: Unknown result type (might be due to invalid IL or missing references)
			//IL_0388: Expected Obj, but got Unknown
			//IL_03ca: Unknown result type (might be due to invalid IL or missing references)
			//IL_03cf: Expected Obj, but got Unknown
			//IL_01c4: Expected Obj, but got I
			//IL_01cd: Unknown result type (might be due to invalid IL or missing references)
			//IL_01d2: Expected Obj, but got Unknown
			//IL_0190: Expected Obj, but got I
			//IL_0199: Unknown result type (might be due to invalid IL or missing references)
			//IL_019e: Expected Obj, but got Unknown
			//IL_0257: Expected Obj, but got I
			//IL_02b1: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Characters.Character+<ToggleDustWithDelay>d__357)+34]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Characters.Character+<ToggleDustWithDelay>d__357)+34]");
			object obj3;
			object obj4;
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Characters.Character+<ToggleDustWithDelay>d__357)+34]");
				object obj2 = (nint)0 + (nint)16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6+C]");
				obj3 = 0;
				obj4 = obj2;
			}
			else
			{
				obj4 = this;
				obj3 = 1;
			}
			object obj5 = default;
			object obj23 = default;
			object obj20 = default;
			for (; obj5 != obj3; obj5 = obj23 + 1)
			{
				object obj6 = obj5 << 2;
				object obj7 = obj4 + obj6;
				object obj8 = obj7;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v14+10]");
				object obj9 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v14+14]");
				object obj10 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S0_v19+28]");
				if ((nint)0 == -1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A98");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S0_v19+24]");
				object obj11 = (nint)0 & (nint)0x10;
				bool flag = obj11 == null;
				object obj12 = (flag ? 1 : 0) ^ 1;
				if (obj12 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S0_v19+2A]");
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v14+8]");
						object obj13 = (nint)0 & (nint)0x3FFF;
						object obj14 = obj13 + 80504;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v104 @ S2_v14 (should have been resolved before IL gen)");
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v14+8]");
						object obj15 = (nint)0 & (nint)0x7FFF;
						object obj16 = obj15 + 46824;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v111 @ S1_v33 (should have been resolved before IL gen)");
					}
					continue;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S0_v19+28]");
				if ((nint)0 != -1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v14+10]");
					bool flag2;
					if ((nint)0 != 0)
					{
						object obj17 = obj9;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ S0_v59+9C]");
						object obj18 = (nint)0 & (nint)0x100;
						flag2 = obj18 != null;
					}
					else
					{
						flag2 = false;
					}
					if (!flag2 && _003C_003E2__current != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S0_v19+2B]");
						object obj19 = (nint)0 & (nint)3;
						bool flag3 = (nint)obj19 == 2;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120B8");
						if (flag3)
						{
							if (obj20 != null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @78B8");
							}
							else
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @78B9");
							}
						}
						else if (obj20 != null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @741D");
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7266");
						}
						continue;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v14+8]");
				object obj21 = (nint)0 & (nint)0x3FFF;
				object obj22 = obj21 + 80504;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v129 @ S2_v6 (should have been resolved before IL gen)");
			}
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

	private sealed class _003C_003Ec__DisplayClass374_0
	{
		public Character _003C_003E4__this;

		public float trackIndexPositionBegin;

		public int newTrackIndex;

		public float startX;

		public float endX;

		public float dir;

		public float startRotation;

		public _003C_003Ec__DisplayClass374_0()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			NullReferenceException ex = default;
			ex._002Ector();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}

		internal void _003CChangeTrackCoroutine_003Eb__0(float t)
		{
			//IL_0015: Expected Obj, but got I
			//IL_007e: Expected Obj, but got I4
			//IL_0050: Expected Obj, but got I
			//IL_0060: Expected Obj, but got I
			//IL_00b6: Expected Obj, but got I
			//IL_00c6: Expected Obj, but got I
			//IL_011b: Expected Obj, but got I
			//IL_0138: Expected Obj, but got I4
			//IL_0408: Expected Obj, but got I
			//IL_0455: Unknown result type (might be due to invalid IL or missing references)
			//IL_045a: Expected Obj, but got Unknown
			//IL_01d9: Expected Obj, but got I
			//IL_019b: Expected Obj, but got I
			//IL_01be: Expected F4, but got I4
			//IL_026f: Expected Obj, but got I
			//IL_029f: Invalid comparison between F4 and I4
			//IL_0337: Expected Obj, but got I
			//IL_02f9: Expected Obj, but got I
			//IL_031c: Expected F4, but got I4
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Characters.Character+<>c__DisplayClass374_0)+34]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Characters.Character+<>c__DisplayClass374_0)+34]");
			object obj3;
			object obj4;
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Characters.Character+<>c__DisplayClass374_0)+34]");
				object obj2 = (nint)0 + (nint)16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6+C]");
				obj3 = 0;
				obj4 = obj2;
			}
			else
			{
				obj4 = this;
				obj3 = 1;
			}
			object obj5 = default;
			object obj21 = default;
			object obj19 = default;
			for (; obj5 != obj3; obj5 = obj21 + 1)
			{
				object obj6 = obj5 << 2;
				object obj7 = obj4 + obj6;
				object obj8 = obj7;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S0_v14+10]");
				object obj9 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S0_v14+14]");
				object obj10 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ S0_v19+28]");
				if ((nint)0 == -1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A98");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ S0_v19+24]");
				object obj11 = (nint)0 & (nint)0x10;
				bool flag = obj11 == null;
				object obj12 = (flag ? 1 : 0) ^ 1;
				float num2;
				if (obj12 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ S0_v19+2A]");
					if ((nint)0 == 1)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S0_v14+8]");
						object obj13 = (nint)0 & (nint)0xF;
						float num = (float)obj13 + 46800f;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v110 @ S2_v18 (System.Single) (should have been resolved before IL gen)");
						num2 = 46800f;
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S0_v14+8]");
						object obj14 = (nint)0 & (nint)0x1FF;
						num2 = (float)obj14 + 79894f;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v156 @ S3_v6 (System.Single) (should have been resolved before IL gen)");
					}
					continue;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ S0_v19+28]");
				if ((nint)0 != -1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S0_v14+10]");
					bool flag2;
					if ((nint)0 != 0)
					{
						object obj15 = obj9;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ S0_v62+9C]");
						object obj16 = (nint)0 & (nint)0x100;
						flag2 = obj16 != null;
					}
					else
					{
						flag2 = false;
					}
					if (!flag2 && trackIndexPositionBegin != 0f)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S0_v14+10]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S0_v14+8]");
							object obj17 = (nint)0 & (nint)0xF;
							float num3 = (float)obj17 + 46800f;
							Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v159 @ S2_v13 (System.Single) (should have been resolved before IL gen)");
							num2 = 46800f;
							continue;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ S0_v19+2B]");
						object obj18 = (nint)0 & (nint)3;
						bool flag3 = (nint)obj18 == 2;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120B8");
						if (flag3)
						{
							if (obj19 != null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9928");
							}
							else
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9929");
							}
						}
						else if (obj19 != null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9466");
							num2 = t;
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @76BC");
						}
						continue;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S0_v14+8]");
				object obj20 = (nint)0 & (nint)0x1FF;
				num2 = (float)obj20 + 79894f;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v156 @ S3_v6 (System.Single) (should have been resolved before IL gen)");
			}
		}
	}

	private sealed class _003CChangeTrackCoroutine_003Ed__374(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public Character _003C_003E4__this;

		public int move;

		public float duration;

		private _003C_003Ec__DisplayClass374_0 _003C_003E8__1;

		object IEnumerator<object>.Current
		{
			get
			{
				//IL_003a: Unknown result type (might be due to invalid IL or missing references)
				//IL_003f: Expected Obj, but got Unknown
				//IL_005c: Unknown result type (might be due to invalid IL or missing references)
				//IL_0061: Expected Obj, but got Unknown
				//IL_00f2: Expected I, but got Obj
				//IL_0108: Expected Obj, but got I
				//IL_05ef: Expected F4, but got I
				//IL_060e: Expected F4, but got I
				//IL_0672: Expected Obj, but got I
				//IL_067b: Invalid comparison between Obj and F4
				//IL_0133: Expected I, but got Obj
				//IL_06c9: Expected F4, but got I
				//IL_0553: Expected Obj, but got I
				//IL_03e6: Expected Obj, but got I
				//IL_03f6: Expected Obj, but got I
				//IL_01a4: Expected Obj, but got I
				//IL_01b4: Expected Obj, but got I
				//IL_0456: Expected Obj, but got I4
				//IL_0456: Expected Obj, but got I4
				//IL_0456: Expected Obj, but got I4
				//IL_0364: Unknown result type (might be due to invalid IL or missing references)
				//IL_0369: Expected Obj, but got Unknown
				//IL_0379: Unknown result type (might be due to invalid IL or missing references)
				//IL_037e: Expected Obj, but got Unknown
				//IL_0210: Expected Obj, but got I4
				//IL_0210: Expected Obj, but got I4
				//IL_03cb: Expected Obj, but got I4
				//IL_0294: Expected Obj, but got I4
				//IL_04cd: Expected Obj, but got I4
				//IL_0724: Expected Obj, but got I4
				//IL_0724: Expected Obj, but got I4
				//IL_074a: Expected Obj, but got I4
				//IL_074a: Expected Obj, but got I4
				Character character = _003C_003E4__this;
				if (_003C_003E1__state != 0)
				{
					if (_003C_003E1__state == 1)
					{
						_003C_003E1__state = -1;
						int num = move;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v6 (SYBO.Subway.Characters.Character)+1C4]");
						if ((nint)num != 0)
						{
							_ = 0;
						}
						_003C_003Ec__DisplayClass374_0 obj = _003C_003E8__1;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v6 (SYBO.Subway.Characters.Character)+A4]");
						if ((nint)0 != obj.newTrackIndex)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v6 (SYBO.Subway.Characters.Character)+A4]");
							_ = 0;
							_ = obj.newTrackIndex;
						}
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v6 (SYBO.Subway.Characters.Character)+1C0]");
						if ((nint)0 != 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v6 (SYBO.Subway.Characters.Character)+1C0]");
							IEnumerator routine = ((CharacterRendering)(object)character).CatchPlayerAnimStarter((AnimationState)0, duration);
							Coroutine coroutine = character.StartCoroutine_Auto(routine);
						}
						return null;
					}
					return null;
				}
				_003C_003E1__state = -1;
				object obj2 = this + 28;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				object obj3 = default;
				obj2 = obj3;
				object obj4 = _003C_003E8__1 + 8;
				obj4 = _003C_003E4__this;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v6 (SYBO.Subway.Characters.Character)+1C4]");
				if ((nint)0 != move)
				{
					_ = move;
					_ = 0;
					_003C_003Ec__DisplayClass374_0 obj5 = _003C_003E8__1;
					int num2 = move;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v6 (SYBO.Subway.Characters.Character)+1CC]");
					int newTrackIndex = (int)((nint)num2 + (nint)0);
					obj5.newTrackIndex = newTrackIndex;
					_003C_003Ec__DisplayClass374_0 obj6 = _003C_003E8__1;
					nint num3 = (nint)typeof(Mathf);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ S1_v23 (Il2CppClass<UnityEngine.Mathf>)+BA]");
					object obj7 = (nint)0 & (nint)0x200;
					if (obj7 != null)
					{
						nint num4 = (nint)typeof(Mathf);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v199 @ S1_v80 (Il2CppClass<UnityEngine.Mathf>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					float num5 = obj6.newTrackIndex;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v6 (SYBO.Subway.Characters.Character)+1D0]");
					float value = num5 - 0f;
					_003C_003Ec__DisplayClass374_0 obj8 = _003C_003E8__1;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v6 (SYBO.Subway.Characters.Character)+1D0]");
					obj8.trackIndexPositionBegin = 0f;
					_003C_003Ec__DisplayClass374_0 obj9 = _003C_003E8__1;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v6 (SYBO.Subway.Characters.Character)+4C]");
					obj9.startX = 0f;
					_003C_003Ec__DisplayClass374_0 obj10 = _003C_003E8__1;
					_003C_003Ec__DisplayClass374_0 obj11 = _003C_003E8__1;
					float endX = (float)obj11.newTrackIndex * 20f;
					obj10.endX = endX;
					_003C_003Ec__DisplayClass374_0 obj12 = _003C_003E8__1;
					_003C_003Ec__DisplayClass374_0 obj13 = _003C_003E8__1;
					int newTrackIndex2 = obj13.newTrackIndex;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v6 (SYBO.Subway.Characters.Character)+1CC]");
					object obj14 = (nint)newTrackIndex2 - (nint)0;
					float dir = ((System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj14) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)0f)) ? (-1f) : 1f);
					obj12.dir = dir;
					_003C_003Ec__DisplayClass374_0 obj15 = _003C_003E8__1;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v6 (SYBO.Subway.Characters.Character)+1C8]");
					obj15.startRotation = 0f;
					_003C_003Ec__DisplayClass374_0 obj16 = _003C_003E8__1;
					if (obj16.newTrackIndex <= -1)
					{
						_ = 1;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v6 (SYBO.Subway.Characters.Character)+1D8]");
						object obj17 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v6 (SYBO.Subway.Characters.Character)+1D8]");
						object obj18 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v263 @ S2_v37+44]");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v6 (SYBO.Subway.Characters.Character)+11C]");
						if ((nint)0 == 0)
						{
							((InAppManager)(object)character).PurchaseRequestCallback((string)2, (string)null, (string)1, "side", PurchaseResult.Completed, (IPurchaseValidationResult)null);
							return null;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v6 (SYBO.Subway.Characters.Character)+11C]");
						if ((nint)0 != 1)
						{
							return null;
						}
						string transactionId = ((move <= 0) ? ((string)4) : null);
						((InAppManager)(object)character).CheckedItemRestoredCallback((string)2, transactionId, (string)1, (IPurchaseValidationResult)(object)"setpiece_side");
						return null;
					}
					float num6 = Math.Abs(value);
					int num7 = move >> 31;
					int num8 = num7 ^ 1;
					_003C_003Ec__DisplayClass374_0 obj19 = _003C_003E8__1;
					if (obj19.newTrackIndex < 3)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v6 (SYBO.Subway.Characters.Character)+154]");
						if ((nint)0 != 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7CE4");
						}
						_003C_003Ec__DisplayClass374_0 obj20 = _003C_003E8__1;
						_ = obj20.newTrackIndex;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
						nint num9 = 0;
						_ = 0;
						object obj22 = default;
						object obj21 = obj22 + 16;
						obj21 = _003C_003E8__1;
						object obj23 = this + 12;
						float num10 = num6 * duration;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11247");
						IEnumerator routine2 = default;
						Coroutine coroutine2 = character.StartCoroutine_Auto(routine2);
						obj23 = coroutine2;
						_003C_003E1__state = 1;
						return 1;
					}
					_ = 1;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v6 (SYBO.Subway.Characters.Character)+1D8]");
					object obj24 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v6 (SYBO.Subway.Characters.Character)+1D8]");
					object obj25 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v296 @ S1_v49+44]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v6 (SYBO.Subway.Characters.Character)+11C]");
					if ((nint)0 == 0)
					{
						((InAppManager)(object)character).PurchaseRequestCallback((string)2, (string)4, (string)1, "side", PurchaseResult.Completed, (IPurchaseValidationResult)null);
						return null;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v6 (SYBO.Subway.Characters.Character)+11C]");
					if ((nint)0 == 1)
					{
						string transactionId2 = ((move <= 0) ? ((string)4) : null);
						((InAppManager)(object)character).CheckedItemRestoredCallback((string)2, transactionId2, (string)1, (IPurchaseValidationResult)(object)"setpiece_side");
					}
				}
				return null;
			}
		}

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
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

	private sealed class _003CStumbleDecay_003Ed__393(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public Character _003C_003E4__this;

		object IEnumerator<object>.Current
		{
			get
			{
				//IL_004e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0053: Expected Obj, but got Unknown
				//IL_006f: Expected Obj, but got I4
				Character character = _003C_003E4__this;
				if (_003C_003E1__state != 0)
				{
					if (_003C_003E1__state == 1)
					{
						_003C_003E1__state = -1;
						character.HitByTrainSequence();
						return null;
					}
					return null;
				}
				_003C_003E1__state = -1;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				_ = character.stumbleDecayTime;
				object obj = this + 12;
				object obj2 = default;
				obj = obj2;
				_003C_003E1__state = 1;
				return 1;
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

	private sealed class _003CLaneSwitchJump_003Ed__397(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public Character _003C_003E4__this;

		public float jumpHeight;

		public Vector3 gamePositionStart;

		public Vector3 gamePositionEnd;

		public float jumpsPerLaneSwitch;

		private bool _003ChasLanded_003E5__2;

		private bool _003CjumpDone_003E5__3;

		object IEnumerator<object>.Current
		{
			get
			{
				//IL_0009: Unknown result type (might be due to invalid IL or missing references)
				//IL_000e: Expected Obj, but got Unknown
				//IL_0017: Unknown result type (might be due to invalid IL or missing references)
				//IL_001c: Expected Obj, but got Unknown
				//IL_0025: Unknown result type (might be due to invalid IL or missing references)
				//IL_002a: Expected Obj, but got Unknown
				//IL_0033: Expected Obj, but got I4
				//IL_0100: Unknown result type (might be due to invalid IL or missing references)
				//IL_0105: Expected Obj, but got Unknown
				//IL_014a: Unknown result type (might be due to invalid IL or missing references)
				//IL_014f: Expected Obj, but got Unknown
				//IL_0155: Unknown result type (might be due to invalid IL or missing references)
				//IL_015a: Expected Obj, but got Unknown
				//IL_0177: Expected Obj, but got I
				//IL_017d: Unknown result type (might be due to invalid IL or missing references)
				//IL_0182: Expected Obj, but got Unknown
				//IL_0188: Unknown result type (might be due to invalid IL or missing references)
				//IL_018d: Expected Obj, but got Unknown
				//IL_01aa: Expected Obj, but got I
				//IL_0259: Invalid comparison between Obj and F4
				//IL_02b4: Invalid comparison between Obj and F4
				//IL_02e9: Expected Obj, but got I4
				//IL_0317: Unknown result type (might be due to invalid IL or missing references)
				//IL_031c: Expected Obj, but got Unknown
				//IL_0325: Expected Obj, but got I4
				//IL_0339: Expected Obj, but got I4
				object obj = default;
				Character character = (Character)(obj + 36);
				object obj2 = obj + 12;
				object obj3 = obj + 24;
				obj3 = 0;
				_ = 0;
				if (_003C_003E1__state != 0)
				{
					if (_003C_003E1__state != 1)
					{
						return null;
					}
					_003C_003E1__state = -1;
				}
				else
				{
					_003C_003E1__state = -1;
					_003ChasLanded_003E5__2 = false;
					_003CjumpDone_003E5__3 = false;
					((CharacterRendering)(object)_003C_003E4__this).OnJump(jumpHeight, false);
				}
				if (~(_003CjumpDone_003E5__3 ? 1u : 0u) == 0)
				{
					return null;
				}
				object obj4 = _003C_003E4__this + 236;
				obj2 = obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ S1_v11+8]");
				_ = 0;
				obj3 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7+8]");
				_ = 0;
				obj = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7+8]");
				_ = 0;
				object obj5 = this + 24;
				object obj6 = this + 24;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
				nint num = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ S4_v3+8]");
				object obj7 = num - 0;
				object obj8 = this + 36;
				object obj9 = this + 24;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ S4_v6+8]");
				nint num2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ S5_v5+8]");
				object obj10 = num2 - 0;
				object obj11 = obj7 / obj10;
				float num3 = (float)obj11 / jumpsPerLaneSwitch;
				float num4 = 4f * num3;
				float num5 = 1f - num3;
				float num6 = num4 * num5;
				float num7 = num6 * jumpHeight;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ S1_v24+4]");
				float num8 = 0f + num7;
				character = (Character)obj3;
				Character character2 = character;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v9+8]");
				((UnityEngine.Object)character2).m_CachedPtr = (IntPtr)0;
				_003C_003E4__this.UpdateGroundTag(character);
				if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj11) >= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)1f))
				{
					_003CjumpDone_003E5__3 = true;
				}
				bool flag = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj11) >= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)0.8f);
				bool flag2 = !flag;
				bool flag3 = _003ChasLanded_003E5__2;
				object obj12 = flag2 | flag3;
				if (obj12 == null)
				{
					_003C_003E4__this.NotifyOnHangtime();
					_003ChasLanded_003E5__2 = true;
				}
				object obj13 = this + 12;
				obj13 = 0;
				_003C_003E1__state = 1;
				return 1;
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

	private sealed class _003CResetAfterRouteDelayed_003Ed__424(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public Character _003C_003E4__this;

		public bool isRouteDestructing;

		object IEnumerator<object>.Current
		{
			get
			{
				//IL_0054: Unknown result type (might be due to invalid IL or missing references)
				//IL_0059: Expected Obj, but got Unknown
				//IL_0062: Expected Obj, but got I4
				//IL_0076: Expected Obj, but got I4
				if (_003C_003E1__state != 0)
				{
					if (_003C_003E1__state == 1)
					{
						_003C_003E1__state = -1;
						bool isInGame = isRouteDestructing;
						_003C_003E4__this._003CInitialize_003Eb__323_0(isInGame);
						return null;
					}
					return null;
				}
				_003C_003E1__state = -1;
				object obj = this + 12;
				obj = 0;
				_003C_003E1__state = 1;
				return 1;
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

	private static Character _instance;

	private const float _HEIGHT_CONSIDERED_IS_ABOVE_ROUTES_GROUND = 20f;

	public const int InitialTrackIndex = 1;

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

	private bool TransitioningFromHeight__BackingField;

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

	private Transform _characterRoot;

	private VariableBool _squeezeCollider;

	private float _characterAngle;

	private RunPositions CurrentRunPosition__BackingField;

	private Queue<Collider> GrindedTrains;

	private int GrindedTrainsBufferSize;

	private Vector3 _gamePosition;

	private Vector3 _transformPosition;

	private Vector3 __previousFixedUpdateTransformPosition;

	private Vector3 __previousPreviousFixedUpdateTransformPosition;

	private StumbleState _stumbleState;

	private OnStumbleDelegate m_OnStumble;

	public DeathCause LastDeathCause;

	private ObstacleType _lastObstacleType;

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

	public Action<bool> OnRouteDone;

	public Action<bool> OnToggleDust;

	public Action OnEnterRoute;

	public Action OnEnterRouteEnd;

	public Action OnExitRoute;

	private bool __isInLipFlight;

	private float _lastGamePositionZ;

	private int _killSwitchUpdates;

	private Sound _currentlyPlayingGrindSound;

	private Vector3 _characterControllerCenter;

	private float _characterControllerHeight;

	private float _characterControllerSkinWidth;

	private Vector3 _characterColliderCenter;

	private float _characterColliderHeight;

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

	private float _trainJumpSampleGamePositionZ;

	private float _trainJumpSampleLength;

	private bool _trainJump;

	private float _verticalSpeed_jumpTolerance;

	private Layers _layers;

	private ObstaclePassType _lastObstaclePassType;

	private int _lastObstaclePassTrackIndex;

	private float _lastCheckpointGamePositionZ;

	public static Character Instance
	{
		get
		{
			//IL_0028: Expected Obj, but got I4
			string text = PlayerPrefs.GetString("DEMO_VIDEO_MODE_IS_ENABLED", null);
			bool flag = (nint)text == 1;
			return (Character)flag;
		}
	}

	public ReviveFX ReviveFX => (ReviveFX)(object)HoverboardCrashParticleSystem;

	public bool KillSwitchEnabled
	{
		get
		{
			//IL_0007: Expected I4, but got Obj
			return (byte)(int)_reviveFX != 0;
		}
		set
		{
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_000f: Expected Obj, but got Unknown
			ParticleSystem hoverboardCrashParticleSystem = (ParticleSystem)(value + HoverboardCrashParticleSystem);
			HoverboardCrashParticleSystem = hoverboardCrashParticleSystem;
		}
	}

	public bool IsStumbling
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

	public bool IsChangingTracks => _isStumbling;

	public int TrackMovement
	{
		get
		{
			return (_trackMovement != 0) ? 1 : 0;
		}
		set
		{
			int isStumbling = value & 1;
			_isStumbling = (byte)isStumbling != 0;
		}
	}

	public int TrackMovementNext
	{
		set
		{
			_trackMovement = value;
		}
	}

	public bool IsFalling
	{
		get
		{
			return (byte)_trackMovement != 0;
		}
		set
		{
			_trackMovementNext = (value ? 1 : 0);
		}
	}

	public bool IsJumping
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

	public bool TransitioningFromHeight
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

	public bool IsRolling => TransitioningFromHeight__BackingField;

	public bool IsTucked => _isRolling;

	public bool IsInsideSubway => _isTucked;

	public int TrackIndexCurrent
	{
		get
		{
			return _isInsideSubway ? 1 : 0;
		}
		set
		{
			int num = value & 1;
			TransitioningFromHeight__BackingField = (byte)num != 0;
		}
	}

	public float OffsetFromFloorY
	{
		get
		{
			if ((nint)CharacterTrigger == 1)
			{
				return 30f;
			}
			return 15f;
		}
		private set
		{
			//IL_000b: Expected Obj, but got I4
			CoinMagnetLongCollider = (CollisionNotifier)1;
			((CoinCurve)this).ResizeIfNeeded(value);
		}
	}

	public int TrackIndexPrevious
	{
		get
		{
			return __trackIndex;
		}
		private set
		{
			if (__trackIndex != value)
			{
				__trackIndexPrevious = __trackIndex;
				__trackIndex = value;
			}
		}
	}

	public bool IsAboveGroundOfCharacterRoute => (byte)__trackIndexPrevious != 0;

	public bool IsJumpingHigher
	{
		get
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_0017: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Expected Obj, but got Unknown
			//IL_0022: Unknown result type (might be due to invalid IL or missing references)
			//IL_0027: Expected Obj, but got Unknown
			//IL_004f: Expected VT, but got Obj
			//IL_0072: Expected Obj, but got I
			//IL_00fb: Invalid comparison between Obj and F4
			//IL_0090: Unknown result type (might be due to invalid IL or missing references)
			//IL_0095: Expected Obj, but got Unknown
			//IL_00ed: Expected Obj, but got I
			RouteChunk routeChunk = default;
			object obj = routeChunk + 12;
			EnvironmentKind environmentKind = (EnvironmentKind)(routeChunk + 24);
			object obj2 = this + 248;
			environmentKind = (EnvironmentKind)obj2;
			EnvironmentKind environmentKind2 = environmentKind;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S1_v5+8]");
			environmentKind2._type = EnvironmentType.None;
			RouteScoreChangeExplosion routeScoreChangeExplosion = RouteScoreChangeExplosion.CreateAtPosition((Vector3)_routeManager);
			bool flag = (object)routeScoreChangeExplosion == null;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7 (SYBO.Subway.Level.EnvironmentKind)+4]");
			object obj3 = 0;
			if (!flag)
			{
				RouteManager routeManager = _routeManager;
				object obj4 = this + 248;
				obj = obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S1_v13+8]");
				_ = 0;
				environmentKind = (EnvironmentKind)obj;
				EnvironmentKind environmentKind3 = environmentKind;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v9 @ S0_v5+8]");
				environmentKind3._type = EnvironmentType.None;
				routeChunk.Build((EnvironmentKind)(object)routeManager._characterRoute, environmentKind);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7 (SYBO.Subway.Routes.RouteChunk)+4]");
				obj3 = 0;
			}
			return System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj3) > System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)20f);
		}
		set
		{
			__trackIndexPrevious = (value ? 1 : 0);
		}
	}

	public bool IsTeleboard
	{
		get
		{
			//IL_0047: Expected I, but got Obj
			//IL_005d: Expected Obj, but got I
			//IL_0088: Expected I, but got Obj
			if (~(_isJumpingHigher ? 1u : 0u) == 0)
			{
				return true;
			}
			Hoverboard hoverboard = _hoverboard;
			if (~(hoverboard.isActive ? 1u : 0u) == 0)
			{
				nint num = (nint)typeof(Hoverboard);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S0_v13 (Il2CppClass<Hoverboard>)+BA]");
				object obj = (nint)0 & (nint)0x200;
				if (obj != null)
				{
					nint num2 = (nint)typeof(Hoverboard);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v21 (Il2CppClass<Hoverboard>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				CharacterModifier characterModifier = MysteryPowerup.SelectRandomCharacterModifier();
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S0_v18 (CharacterModifier)+20]");
				return (nint)0 != 0;
			}
			return false;
		}
		set
		{
			_isJumpingHigher = value;
		}
	}

	public bool IsDoubleJumping
	{
		get
		{
			//IL_0047: Expected I, but got Obj
			//IL_005d: Expected Obj, but got I
			//IL_0088: Expected I, but got Obj
			if (~(_isTeleboard ? 1u : 0u) == 0)
			{
				return true;
			}
			Hoverboard hoverboard = _hoverboard;
			if (~(hoverboard.isActive ? 1u : 0u) == 0)
			{
				nint num = (nint)typeof(Hoverboard);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S0_v13 (Il2CppClass<Hoverboard>)+BA]");
				object obj = (nint)0 & (nint)0x200;
				if (obj != null)
				{
					nint num2 = (nint)typeof(Hoverboard);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v21 (Il2CppClass<Hoverboard>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				CharacterModifier characterModifier = MysteryPowerup.SelectRandomCharacterModifier();
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S0_v18 (CharacterModifier)+26]");
				return (nint)0 != 0;
			}
			return false;
		}
		set
		{
			_isTeleboard = value;
		}
	}

	public bool IsGliderboard
	{
		get
		{
			//IL_0021: Expected I, but got Obj
			//IL_0037: Expected Obj, but got I
			//IL_0062: Expected I, but got Obj
			if (~(_isDoubleJumping ? 1u : 0u) == 0)
			{
				return true;
			}
			nint num = (nint)typeof(DoubleJump);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v9 (Il2CppClass<DoubleJump>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(DoubleJump);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v21 (Il2CppClass<DoubleJump>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (~(DoubleJump.doubleJumpEnabled ? 1u : 0u) == 0)
			{
				return true;
			}
			Hoverboard hoverboard = _hoverboard;
			return hoverboard.isDoubleJump;
		}
		set
		{
			_isDoubleJumping = value;
		}
	}

	public bool IsVTol
	{
		get
		{
			//IL_0047: Expected I, but got Obj
			//IL_005d: Expected Obj, but got I
			//IL_0088: Expected I, but got Obj
			if (~(_isGliderboard ? 1u : 0u) == 0)
			{
				return true;
			}
			Hoverboard hoverboard = _hoverboard;
			if (~(hoverboard.isActive ? 1u : 0u) == 0)
			{
				nint num = (nint)typeof(Hoverboard);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S0_v13 (Il2CppClass<Hoverboard>)+BA]");
				object obj = (nint)0 & (nint)0x200;
				if (obj != null)
				{
					nint num2 = (nint)typeof(Hoverboard);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v21 (Il2CppClass<Hoverboard>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				CharacterModifier characterModifier = MysteryPowerup.SelectRandomCharacterModifier();
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S0_v18 (CharacterModifier)+24]");
				return (nint)0 != 0;
			}
			return false;
		}
		set
		{
			_isGliderboard = value;
		}
	}

	public CharacterController CharacterController
	{
		get
		{
			//IL_000e: Expected Obj, but got I4
			//IL_0047: Expected I, but got Obj
			//IL_005d: Expected Obj, but got I
			//IL_011a: Expected Obj, but got I4
			//IL_0088: Expected I, but got Obj
			if (~(_isVTol ? 1u : 0u) == 0)
			{
				return (CharacterController)1;
			}
			Hoverboard hoverboard = _hoverboard;
			if (~(hoverboard.isActive ? 1u : 0u) == 0)
			{
				nint num = (nint)typeof(Hoverboard);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S0_v13 (Il2CppClass<Hoverboard>)+BA]");
				object obj = (nint)0 & (nint)0x200;
				if (obj != null)
				{
					nint num2 = (nint)typeof(Hoverboard);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v21 (Il2CppClass<Hoverboard>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				CharacterModifier characterModifier = MysteryPowerup.SelectRandomCharacterModifier();
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S0_v18 (CharacterModifier)+25]");
				bool flag = (nint)0 != 0;
				return (CharacterController)flag;
			}
			return null;
		}
	}

	public CharacterModel CharacterModel => (CharacterModel)(object)_characterController;

	public CharacterCamera CharacterCamera => (CharacterCamera)(object)_characterModel;

	public CharacterRendering CharacterRendering => (CharacterRendering)(object)_characterCamera;

	public Hoverboard Hoverboard => (Hoverboard)(object)_characterRendering;

	public LongMagnet LongMagnet => (LongMagnet)(object)_hoverboard;

	public SuperSneakers SuperSneakers => (SuperSneakers)(object)_longMagnet;

	public Transform CharacterRoot => (Transform)(object)_superSneakers;

	public VariableBool SqueezeCollider => (VariableBool)(object)_characterRoot;

	public float CharacterAngle => _offsetFromFloorY;

	public Bounds Bounds
	{
		get
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected Obj, but got Unknown
			object obj = this & 1;
			Bounds result = default;
			return result;
		}
	}

	public unsafe StumbleState CurrentStumbleState
	{
		get
		{
			//IL_0007: Expected I4, but got Obj
			return (StumbleState)_squeezeCollider;
		}
		set
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [value @ L1 (SYBO.Subway.Characters.Character+StumbleState)+14]");
			((Collider)(object)this).get_bounds_Injected(out *(Bounds*)null);
		}
	}

	public RunPositions CurrentRunPosition
	{
		get
		{
			return (RunPositions)_stumbleState;
		}
		private set
		{
			_stumbleState = (StumbleState)value;
		}
	}

	public Vector3 GamePosition
	{
		get
		{
			Vector3 result = default;
			return result;
		}
	}

	public unsafe Vector3 TransformPosition
	{
		get
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected Obj, but got Unknown
			//IL_0018: Expected F4, but got Obj
			//IL_0013: Expected native int or pointer, but got VT
			//IL_002d: Expected F4, but got I
			//IL_0028: Expected native int or pointer, but got VT
			object obj = this + 236;
			Vector3 vector = default;
			((Vector3*)(nint)vector)->x = (float)obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5 @ S1_v2+8]");
			((Vector3*)(nint)vector)->z = 0f;
			return vector;
		}
	}

	public unsafe Vector3 PreviousFixedUpdateTransformPosition
	{
		get
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected Obj, but got Unknown
			//IL_0018: Expected F4, but got Obj
			//IL_0013: Expected native int or pointer, but got VT
			//IL_002d: Expected F4, but got I
			//IL_0028: Expected native int or pointer, but got VT
			object obj = this + 248;
			Vector3 vector = default;
			((Vector3*)(nint)vector)->x = (float)obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5 @ S1_v2+8]");
			((Vector3*)(nint)vector)->z = 0f;
			return vector;
		}
		set
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			object obj = value + 260;
			Character character = (Character)obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5 @ S1_v2+8]");
			((UnityEngine.Object)this).m_CachedPtr = (IntPtr)0;
		}
	}

	public unsafe Vector3 PreviousPreviousFixedUpdateTransformPosition
	{
		get
		{
			//IL_0114: Unknown result type (might be due to invalid IL or missing references)
			//IL_0119: Expected Obj, but got Unknown
			//IL_0122: Unknown result type (might be due to invalid IL or missing references)
			//IL_0127: Expected Obj, but got Unknown
			//IL_0156: Expected I, but got Obj
			//IL_016c: Expected Obj, but got I
			//IL_0197: Unknown result type (might be due to invalid IL or missing references)
			//IL_019c: Expected VT, but got Unknown
			//IL_01a9: Expected F4, but got Obj
			//IL_01a4: Expected native int or pointer, but got VT
			//IL_01be: Expected F4, but got I
			//IL_01b9: Expected native int or pointer, but got VT
			//IL_01c7: Unknown result type (might be due to invalid IL or missing references)
			//IL_01cc: Expected VT, but got Unknown
			//IL_01d9: Expected F4, but got Obj
			//IL_01d4: Expected native int or pointer, but got VT
			//IL_01ee: Expected F4, but got I
			//IL_01e9: Expected native int or pointer, but got VT
			//IL_0212: Expected VT, but got Obj
			//IL_0013: Expected I, but got Obj
			//IL_005b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0060: Expected Obj, but got Unknown
			//IL_006d: Expected F4, but got Obj
			//IL_0068: Expected native int or pointer, but got VT
			//IL_0082: Expected F4, but got I
			//IL_007d: Expected native int or pointer, but got VT
			//IL_008f: Expected native int or pointer, but got VT
			//IL_00a1: Expected native int or pointer, but got VT
			//IL_00b3: Expected Obj, but got VT
			//IL_00bd: Expected F4, but got Obj
			//IL_00b8: Expected native int or pointer, but got VT
			//IL_00cc: Expected F4, but got I
			//IL_00c7: Expected native int or pointer, but got VT
			//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
			//IL_00da: Expected VT, but got Unknown
			//IL_00e7: Expected native int or pointer, but got VT
			//IL_00f9: Expected native int or pointer, but got VT
			object obj2 = default;
			object obj = obj2 + 12;
			Character character = default;
			object obj3 = character + 260;
			obj = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S1_v5+8]");
			_ = 0;
			obj2 = this;
			_ = ((UnityEngine.Object)this).m_CachedPtr;
			nint num = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v14 (Il2CppClass<UnityEngine.Vector3>)+BA]");
			object obj4 = (nint)0 & (nint)0x200;
			if (obj4 != null)
			{
				nint num2 = (nint)typeof(Vector3);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S0_v38 (Il2CppClass<UnityEngine.Vector3>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Quaternion quaternion = (Quaternion)(obj2 + 24);
			((Quaternion*)(nint)quaternion)->x = (float)obj;
			Quaternion quaternion2 = quaternion;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
			((Quaternion*)(nint)quaternion2)->z = 0f;
			Quaternion quaternion3 = (Quaternion)(obj2 + 36);
			((Quaternion*)(nint)quaternion3)->x = (float)obj2;
			Quaternion quaternion4 = quaternion3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			((Quaternion*)(nint)quaternion4)->z = 0f;
			bool flag = quaternion == quaternion3;
			bool flag2 = !flag;
			Vector3 result = (Vector3)character;
			if (!flag2)
			{
				object obj5 = character + 260;
				((Quaternion*)(nint)quaternion)->x = (float)obj5;
				Quaternion quaternion5 = quaternion;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ S1_v27+8]");
				((Quaternion*)(nint)quaternion5)->z = 0f;
				((Quaternion*)(nint)quaternion3)->x = quaternion.x;
				((Quaternion*)(nint)quaternion3)->z = quaternion.z;
				character.OnStumble += (OnStumbleDelegate)quaternion3;
				((Quaternion*)(nint)quaternion3)->x = (float)this;
				((Quaternion*)(nint)quaternion3)->z = (nint)((UnityEngine.Object)this).m_CachedPtr;
				Vector3 vector = (Vector3)(character + 260);
				((Vector3*)(nint)vector)->x = quaternion3.x;
				((Vector3*)(nint)vector)->z = quaternion3.z;
				result = vector;
			}
			return result;
		}
		private set
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			object obj = value + 272;
			Character character = (Character)obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5 @ S1_v2+8]");
			((UnityEngine.Object)this).m_CachedPtr = (IntPtr)0;
		}
	}

	public ObstacleType LastObstacleType => (ObstacleType)CurrentRunPosition__BackingField;

	public int IgnoredMovement
	{
		set
		{
			//IL_0066: Expected Obj, but got I4
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected Obj, but got Unknown
			Delegate obj = this.m_OnResetTeleportFX;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.RemoveImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				object obj3 = this + 368;
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

	public int TrackIndexTarget
	{
		set
		{
			_ignoredMovement = value;
		}
	}

	public float TrackIndexPosition
	{
		get
		{
			return _characterAngle;
		}
		set
		{
			_offsetFromFloorY = value;
		}
	}

	public float CharacterColliderLeadingZ => _trackIndexPosition;

	public bool IsInLipFlight
	{
		get
		{
			return (byte)_lastObstacleType != 0;
		}
		set
		{
			_trackIndexTarget = (value ? 1 : 0);
		}
	}

	public bool IsVisibleShadow
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

	public unsafe float LastCheckpointGamePositionZ
	{
		get
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_0017: Expected Obj, but got I4
			//IL_002c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0031: Expected Obj, but got Unknown
			//IL_007b: Expected F4, but got I
			object obj2 = default;
			object obj = obj2 + 40;
			obj = 0;
			_ = 0;
			_ = 0;
			Collider collider = (Collider)(obj2 + 16);
			collider.get_bounds_Injected(out *(Bounds*)CharacterTrigger);
			obj = collider;
			_ = ((UnityEngine.Object)collider).m_CachedPtr;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v9 (UnityEngine.Collider)+10]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F4AD");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			return 0f;
		}
	}

	public event OnStumbleDelegate OnStumble
	{
		add
		{
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected Obj, but got Unknown
			_ = ((Delegate)value).method_ptr;
			object obj = this + 272;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			_ = 0;
		}
		remove
		{
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected Obj, but got Unknown
			Delegate obj = this.m_OnStumble;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.CombineImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				object obj3 = this + 288;
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

	public event OnCriticalHitDelegate OnCriticalHit
	{
		add
		{
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected Obj, but got Unknown
			Delegate obj = this.m_OnStumble;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.RemoveImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				object obj3 = this + 288;
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
		remove
		{
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected Obj, but got Unknown
			Delegate obj = this.m_OnCriticalHit;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.CombineImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				object obj3 = this + 300;
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

	public event OnReviveDelegate OnRevive
	{
		add
		{
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected Obj, but got Unknown
			Delegate obj = this.m_OnCriticalHit;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.RemoveImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				object obj3 = this + 300;
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
		remove
		{
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected Obj, but got Unknown
			Delegate obj = this.m_OnRevive;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.CombineImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				object obj3 = this + 304;
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

	public event OnJumpDelegate OnJump
	{
		add
		{
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected Obj, but got Unknown
			Delegate obj = this.m_OnRevive;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.RemoveImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				object obj3 = this + 304;
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
		remove
		{
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected Obj, but got Unknown
			Delegate obj = this.m_OnJump;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.CombineImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				object obj3 = this + 308;
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

	public event OnDoubleJumpDelegate OnDoubleJump
	{
		add
		{
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected Obj, but got Unknown
			Delegate obj = this.m_OnJump;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.RemoveImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				object obj3 = this + 308;
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
		remove
		{
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected Obj, but got Unknown
			Delegate obj = this.m_OnDoubleJump;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.CombineImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				object obj3 = this + 312;
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

	public event OnJumpIfHitByTrainDelegate OnJumpIfHitByTrain
	{
		add
		{
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected Obj, but got Unknown
			Delegate obj = this.m_OnDoubleJump;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.RemoveImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				object obj3 = this + 312;
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
		remove
		{
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected Obj, but got Unknown
			Delegate obj = this.m_OnJumpIfHitByTrain;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.CombineImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				object obj3 = this + 316;
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

	public event Action<Character> OnLanding
	{
		add
		{
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected Obj, but got Unknown
			Delegate obj = this.m_OnJumpIfHitByTrain;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.RemoveImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				object obj3 = this + 316;
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
		remove
		{
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected Obj, but got Unknown
			Delegate obj = this.m_OnLanding;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.CombineImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				object obj3 = this + 320;
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

	public event OnHangtimeDelegate OnHangtime
	{
		add
		{
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected Obj, but got Unknown
			Delegate obj = this.m_OnLanding;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.RemoveImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				object obj3 = this + 320;
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
		remove
		{
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected Obj, but got Unknown
			Delegate obj = this.m_OnHangtime;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.CombineImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				object obj3 = this + 324;
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

	public event OnRollDelegate OnRoll
	{
		add
		{
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected Obj, but got Unknown
			Delegate obj = this.m_OnHangtime;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.RemoveImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				object obj3 = this + 324;
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
		remove
		{
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected Obj, but got Unknown
			Delegate obj = this.m_OnRoll;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.CombineImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				object obj3 = this + 328;
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

	public event OnRollGuardDelegate OnRollGuard
	{
		add
		{
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected Obj, but got Unknown
			Delegate obj = this.m_OnRoll;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.RemoveImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				object obj3 = this + 328;
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
		remove
		{
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected Obj, but got Unknown
			Delegate obj = this.m_OnRollGuard;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.CombineImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				object obj3 = this + 332;
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

	public event OnHitByTrainDelegate OnHitByTrain
	{
		add
		{
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected Obj, but got Unknown
			Delegate obj = this.m_OnRollGuard;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.RemoveImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				object obj3 = this + 332;
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
		remove
		{
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected Obj, but got Unknown
			Delegate obj = this.m_OnHitByTrain;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.CombineImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				object obj3 = this + 336;
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

	public event OnChangeTrackDelegate OnChangeTrack
	{
		add
		{
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected Obj, but got Unknown
			Delegate obj = this.m_OnHitByTrain;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.RemoveImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				object obj3 = this + 336;
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
		remove
		{
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected Obj, but got Unknown
			Delegate obj = this.m_OnChangeTrack;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.CombineImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				object obj3 = this + 340;
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

	public event OnTutorialMoveBackToCheckPointDelegate OnTutorialMoveBackToCheckPoint
	{
		add
		{
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected Obj, but got Unknown
			Delegate obj = this.m_OnChangeTrack;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.RemoveImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				object obj3 = this + 340;
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
		remove
		{
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected Obj, but got Unknown
			Delegate obj = this.m_OnTutorialMoveBackToCheckPoint;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.CombineImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				object obj3 = this + 344;
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

	public event OnTutorialStartFromCheckPointDelegate OnTutorialStartFromCheckPoint
	{
		add
		{
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected Obj, but got Unknown
			Delegate obj = this.m_OnTutorialMoveBackToCheckPoint;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.RemoveImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				object obj3 = this + 344;
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
		remove
		{
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected Obj, but got Unknown
			Delegate obj = this.m_OnTutorialStartFromCheckPoint;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.CombineImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				object obj3 = this + 348;
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

	public event OnPassedObstacleDelegate OnPassedObstacle
	{
		add
		{
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected Obj, but got Unknown
			Delegate obj = this.m_OnTutorialStartFromCheckPoint;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.RemoveImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				object obj3 = this + 348;
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
		remove
		{
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected Obj, but got Unknown
			Delegate obj = this.m_OnPassedObstacle;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.CombineImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				object obj3 = this + 352;
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

	public event OnJumpOverTrainDelegate OnJumpOverTrain
	{
		add
		{
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected Obj, but got Unknown
			Delegate obj = this.m_OnPassedObstacle;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.RemoveImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				object obj3 = this + 352;
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
		remove
		{
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected Obj, but got Unknown
			Delegate obj = this.m_OnJumpOverTrain;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.CombineImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				object obj3 = this + 356;
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

	public event OnTeleboardStartDelegate OnTeleboardStart
	{
		add
		{
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected Obj, but got Unknown
			Delegate obj = this.m_OnJumpOverTrain;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.RemoveImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				object obj3 = this + 356;
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
		remove
		{
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected Obj, but got Unknown
			Delegate obj = this.m_OnTeleboardStart;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.CombineImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				object obj3 = this + 360;
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

	public event OnGliderEndDelegate OnVTolEnd
	{
		add
		{
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected Obj, but got Unknown
			Delegate obj = this.m_OnTeleboardStart;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.RemoveImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				object obj3 = this + 360;
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
		remove
		{
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected Obj, but got Unknown
			Delegate obj = this.m_OnVTolEnd;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.CombineImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				object obj3 = this + 364;
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

	public event OnResetTeleportFXDelegate OnResetTeleportFX
	{
		add
		{
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected Obj, but got Unknown
			Delegate obj = this.m_OnVTolEnd;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.RemoveImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				object obj3 = this + 364;
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
		remove
		{
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected Obj, but got Unknown
			Delegate obj = this.m_OnResetTeleportFX;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.CombineImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				object obj3 = this + 368;
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

	public void Initialize()
	{
	}

	public unsafe void RecreateCharacterModel()
	{
		//IL_06cd: Expected I, but got Obj
		//IL_06e3: Expected Obj, but got I
		//IL_0999: Unknown result type (might be due to invalid IL or missing references)
		//IL_099e: Expected Obj, but got Unknown
		//IL_09b0: Expected Obj, but got VT
		//IL_09b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_09bb: Expected Obj, but got Unknown
		//IL_005a: Expected Obj, but got VT
		//IL_0068: Expected I, but got Obj
		//IL_007e: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0706: Unknown result type (might be due to invalid IL or missing references)
		//IL_070b: Expected Obj, but got Unknown
		//IL_071c: Expected Obj, but got I4
		//IL_072a: Expected I, but got Obj
		//IL_0740: Expected Obj, but got I
		//IL_0763: Unknown result type (might be due to invalid IL or missing references)
		//IL_0768: Expected Obj, but got Unknown
		//IL_0779: Expected Obj, but got I4
		//IL_077f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0784: Expected Obj, but got Unknown
		//IL_07a3: Expected I, but got Obj
		//IL_07b9: Expected Obj, but got I
		//IL_00a9: Expected I, but got Obj
		//IL_07dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_07e1: Expected Obj, but got Unknown
		//IL_07f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_07fd: Expected Obj, but got Unknown
		//IL_0814: Expected Obj, but got VT
		//IL_081a: Unknown result type (might be due to invalid IL or missing references)
		//IL_081f: Expected Obj, but got Unknown
		//IL_0828: Expected VT, but got Obj
		//IL_00f6: Expected I, but got Obj
		//IL_018a: Expected Obj, but got VT
		//IL_0143: Expected I, but got Obj
		//IL_01b9: Expected I, but got Obj
		//IL_01cf: Expected Obj, but got I
		//IL_083b: Expected Obj, but got I4
		//IL_085c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0861: Expected Obj, but got Unknown
		//IL_0285: Unknown result type (might be due to invalid IL or missing references)
		//IL_028a: Expected Obj, but got Unknown
		//IL_029d: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a2: Expected Obj, but got Unknown
		//IL_02b7: Expected Obj, but got I
		//IL_01fa: Expected I, but got Obj
		//IL_0316: Unknown result type (might be due to invalid IL or missing references)
		//IL_031b: Expected Obj, but got Unknown
		//IL_032b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0330: Expected Obj, but got Unknown
		//IL_036e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0373: Expected Obj, but got Unknown
		//IL_039b: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a0: Expected Obj, but got Unknown
		//IL_03ca: Expected I, but got Obj
		//IL_03e0: Expected Obj, but got I
		//IL_0880: Unknown result type (might be due to invalid IL or missing references)
		//IL_0885: Expected Obj, but got Unknown
		//IL_08a5: Expected I, but got Obj
		//IL_08bb: Expected Obj, but got I
		//IL_08de: Unknown result type (might be due to invalid IL or missing references)
		//IL_08e3: Expected Obj, but got Unknown
		//IL_08f4: Expected Obj, but got I4
		//IL_0902: Expected I, but got Obj
		//IL_0918: Expected Obj, but got I
		//IL_040b: Expected I, but got Obj
		//IL_093b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0940: Expected Obj, but got Unknown
		//IL_0957: Unknown result type (might be due to invalid IL or missing references)
		//IL_095c: Expected Obj, but got Unknown
		//IL_0974: Unknown result type (might be due to invalid IL or missing references)
		//IL_0979: Expected Obj, but got Unknown
		//IL_0458: Expected I, but got Obj
		//IL_04a5: Expected I, but got Obj
		//IL_051c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0521: Expected Obj, but got Unknown
		//IL_055b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0560: Expected Obj, but got Unknown
		//IL_057d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0582: Expected Obj, but got Unknown
		//IL_0591: Expected VT, but got Obj
		//IL_059f: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a4: Expected Obj, but got Unknown
		//IL_05bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c1: Expected Obj, but got Unknown
		//IL_061c: Expected VT, but got Obj
		//IL_0634: Unknown result type (might be due to invalid IL or missing references)
		//IL_0639: Expected Obj, but got Unknown
		//IL_069b: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a0: Expected Obj, but got Unknown
		nint num = (nint)typeof(Character);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v9 (Il2CppClass<SYBO.Subway.Characters.Character>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Character);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v170 (Il2CppClass<SYBO.Subway.Characters.Character>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		_instance = this;
		object obj2 = this + 196;
		_0021_00210 componentInChildren = (_0021_00210)((Component)this).GetComponentInChildren<T>();
		obj2 = componentInChildren;
		object obj3 = this + 184;
		string text = tag;
		_0021_00210 componentInChildren2 = (_0021_00210)((GameObject)(object)text).GetComponentInChildren<T>();
		obj3 = componentInChildren2;
		nint num3 = (nint)typeof(Layers);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S0_v20 (Il2CppClass<Layers>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num4 = (nint)typeof(Layers);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ S0_v166 (Il2CppClass<Layers>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj5 = this + 576;
		bool startupFinished = LoadLevelCtrl.StartupFinished;
		obj5 = startupFinished;
		nint num5 = (nint)typeof(Game);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ S0_v27 (Il2CppClass<SYBO.Subway.Game>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num6 = (nint)typeof(Game);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S0_v162 (Il2CppClass<SYBO.Subway.Game>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj7 = this + 472;
		bool isInstantiated = Game.IsInstantiated;
		obj7 = isInstantiated;
		object obj8 = this + 184;
		Game instance = Game.Instance;
		obj8 = instance;
		nint num7 = (nint)typeof(Hoverboard);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ S0_v36 (Il2CppClass<Hoverboard>)+BA]");
		object obj9 = (nint)0 & (nint)0x200;
		if (obj9 != null)
		{
			nint num8 = (nint)typeof(Hoverboard);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ S0_v158 (Il2CppClass<Hoverboard>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj10 = this + 200;
		CharacterModifier characterModifier = MysteryPowerup.SelectRandomCharacterModifier();
		obj10 = characterModifier;
		object obj11 = this + 204;
		_0021_00210 componentInChildren3 = (_0021_00210)((Component)_hoverboard).GetComponentInChildren<T>();
		obj11 = componentInChildren3;
		object obj12 = this + 480;
		_00210 val = (_00210)SingletonMonoBehaviour<>.Instantiate();
		obj12 = val;
		Renderer component = HoverboardCrashParticleSystem.GetComponent<Renderer>();
		Material sharedMaterial = component.sharedMaterial;
		nint num9 = (nint)typeof(RenderQueues);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ S1_v39 (Il2CppClass<SYBO.Subway.Rendering.RenderQueues>)+BA]");
		object obj13 = (nint)0 & (nint)0x200;
		if (obj13 != null)
		{
			nint num10 = (nint)typeof(RenderQueues);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ S1_v167 (Il2CppClass<SYBO.Subway.Rendering.RenderQueues>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		sharedMaterial.EnableKeyword((string)RenderQueues.TransparentOverlay);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num11 = 0;
		_ = 0;
		EventHandler<RouteManager.RouteCreatedEventArgs> eventHandler = default;
		object obj14 = eventHandler + 16;
		obj14 = this;
		_routeManager.OnRouteCreated -= eventHandler;
		Game game = _game;
		Variable<bool> isInGame = game.IsInGame;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr = 0;
		Delegate obj15 = default;
		obj15.method_ptr = method_ptr;
		obj15.method = (nint)__ldftn(Character._003CInitialize_003Eb__323_0);
		object obj16 = obj15 + 16;
		obj16 = this;
		object obj17 = game.IsInGame + 12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v184 @ S0_v54 (Variable`1<System.Boolean>)+C]");
		Delegate obj18 = ((Delegate)0).CombineImpl(obj15);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
		object obj19 = default;
		obj17 = obj19;
		VariableBool squeezeCollider = _squeezeCollider;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr2 = 0;
		Delegate obj20 = default;
		obj20.method_ptr = method_ptr2;
		obj20.method = (nint)__ldftn(Character._003CInitialize_003Eb__323_1);
		object obj21 = obj20 + 16;
		obj21 = this;
		object obj22 = _squeezeCollider + 12;
		Delegate obj23 = ((Delegate)squeezeCollider.OnChange).CombineImpl(obj20);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
		object obj24 = default;
		obj22 = obj24;
		_characterRendering.Awake();
		object obj25 = this + 188;
		_0021_00210[] componentsInChildren = (_0021_00210[])(object)((Component)this).GetComponentsInChildren<T>();
		obj25 = componentsInChildren;
		_characterModel.RecreateCharacter();
		object obj26 = this + 212;
		GameObject gameObject = _characterModel.gameObject;
		obj26 = gameObject;
		nint num12 = (nint)typeof(Utils);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v267 @ S0_v87 (Il2CppClass<Utils>)+BA]");
		object obj27 = (nint)0 & (nint)0x200;
		if (obj27 != null)
		{
			nint num13 = (nint)typeof(Utils);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v273 @ S0_v154 (Il2CppClass<Utils>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj28 = this + 208;
		SuperSneakers superSneakers = Utils.FindObject<SuperSneakers>(this);
		obj28 = superSneakers;
		nint num14 = (nint)typeof(CharacterCamera);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v288 @ S0_v94 (Il2CppClass<SYBO.Subway.Cameras.CharacterCamera>)+BA]");
		object obj29 = (nint)0 & (nint)0x200;
		if (obj29 != null)
		{
			nint num15 = (nint)typeof(CharacterCamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v294 @ S0_v150 (Il2CppClass<SYBO.Subway.Cameras.CharacterCamera>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj30 = this + 192;
		int selectedBenchmarkIndex = SubwayBenchmarkContainer.SelectedBenchmarkIndex;
		obj30 = selectedBenchmarkIndex;
		nint num16 = (nint)typeof(FollowingGuard);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v307 @ S0_v101 (Il2CppClass<FollowingGuard>)+BA]");
		object obj31 = (nint)0 & (nint)0x200;
		if (obj31 != null)
		{
			nint num17 = (nint)typeof(FollowingGuard);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v313 @ S0_v146 (Il2CppClass<FollowingGuard>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj32 = this + 476;
		IEnumerator enumerator = HouseKeeper.InitAuthAndCloudSave();
		obj32 = enumerator;
		object obj33 = this + 52;
		_0021_00210[] componentsInChildren2 = (_0021_00210[])(object)((Component)this).GetComponentsInChildren<T>();
		obj33 = componentsInChildren2;
		object obj34 = this + 20;
		Animation animation = ((SafeAnimation)(object)CharacterTriggerNotifier).Animation;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7510");
		object obj35 = default;
		obj34 = obj35;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num18 = 0;
		_ = 0;
		Action<Collider> action = default;
		object obj36 = action + 16;
		obj36 = this;
		CharacterTriggerNotifier.TriggerEnter -= action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num19 = 0;
		_ = 0;
		Action<Collider> action2 = default;
		object obj37 = action2 + 16;
		obj37 = this;
		CharacterTriggerNotifier.TriggerExit -= action2;
		CapsuleCollider capsuleCollider = default;
		CharacterController characterController = (CharacterController)(capsuleCollider + 12);
		characterController.center = (Vector3)_characterController;
		object obj38 = capsuleCollider + 24;
		obj38 = characterController;
		_ = ((UnityEngine.Object)characterController).m_CachedPtr;
		object obj39 = this + 408;
		obj39 = obj38;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v395 @ S0_v118+8]");
		_ = 0;
		float skinWidth = _characterController.skinWidth;
		_characterControllerHeight = skinWidth;
		float height = ((CapsuleCollider)(object)_characterController).height;
		_characterControllerSkinWidth = height;
		capsuleCollider.center = (Vector3)CharacterTrigger;
		obj38 = capsuleCollider;
		_ = ((UnityEngine.Object)capsuleCollider).m_CachedPtr;
		object obj40 = this + 428;
		obj40 = obj38;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v395 @ S0_v118+8]");
		_ = 0;
		float distance = ((RaycastHit2D*)CharacterTrigger)->distance;
		_characterColliderHeight = distance;
		StayInOneLaneMission instance2 = StayInOneLaneMission.instance;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num20 = 0;
		_ = 0;
		Action<Character> action3 = default;
		object obj41 = action3 + 16;
		obj41 = instance2;
		OnLanding -= action3;
		_originaljumpHeightSuperSneakers = jumpHeightSuperSneakers;
	}

	protected void Awake()
	{
		//IL_0078: Expected I, but got Obj
		//IL_008e: Expected Obj, but got I
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Expected Obj, but got Unknown
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		string obj = _characterModel.tag;
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S1_v4 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S1_v17 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		UnityEngine.Object.DestroyImmediate((UnityEngine.Object)(object)obj);
		object obj3 = this + 188;
		IEnumerator enumerator = _characterRendering.OnRollPlayAnimation();
		obj3 = enumerator;
		object obj4 = this + 212;
		GameObject gameObject = _characterModel.gameObject;
		obj4 = gameObject;
	}

	protected unsafe void OnDestroy()
	{
		//IL_01be: Expected I, but got Obj
		//IL_01d4: Expected Obj, but got I
		//IL_0205: Expected I, but got Obj
		//IL_021b: Expected Obj, but got I
		//IL_0258: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_00bd: Expected VT, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0165: Unknown result type (might be due to invalid IL or missing references)
		//IL_016a: Expected Obj, but got Unknown
		//IL_017a: Unknown result type (might be due to invalid IL or missing references)
		//IL_017f: Expected Obj, but got Unknown
		//IL_0194: Expected Obj, but got I
		nint num = (nint)typeof(Character);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v9 (Il2CppClass<SYBO.Subway.Characters.Character>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Character);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v46 (Il2CppClass<SYBO.Subway.Characters.Character>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		_instance = this;
		nint num3 = (nint)typeof(GamePositionRoot);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S0_v16 (Il2CppClass<SYBO.Subway.Level.GamePositionRoot>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(GamePositionRoot);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S0_v42 (Il2CppClass<SYBO.Subway.Level.GamePositionRoot>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool isRestricted = AgeRestriction.isRestricted;
		GameObject gameObject = base.gameObject;
		((GamePositionRoot)isRestricted).RemoveOffsetTransform((Transform)(object)gameObject);
		float height = ((CapsuleCollider)(object)_characterController).height;
		CharacterController characterController = default;
		characterController.center = (Vector3)_characterController;
		float num5 = 0.6000004f + height;
		float num6 = num5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7 (UnityEngine.CharacterController)+4]");
		float num7 = num6 + 0f;
		float skinWidth = _characterController.skinWidth;
		float num8 = skinWidth * 0.5f;
		float offsetFromFloorY = num7 - num8;
		_offsetFromFloorY = offsetFromFloorY;
		Variable<bool> isGrounded = IsGrounded;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr = 0;
		Delegate obj3 = default;
		obj3.method_ptr = method_ptr;
		obj3.method = (nint)__ldftn(Character.IsGrounded_OnChange);
		object obj4 = obj3 + 16;
		obj4 = this;
		object obj5 = IsGrounded + 12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ S0_v28 (Variable`1<System.Boolean>)+C]");
		Delegate obj6 = ((Delegate)0).CombineImpl(obj3);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
		object obj7 = default;
		obj5 = obj7;
	}

	protected void FixedUpdate()
	{
		//IL_00a0: Expected I, but got Obj
		//IL_00b6: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Expected Obj, but got Unknown
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S1_v3 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v19 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)_routeManager).FindKernel((string)null) != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num3 = 0;
			_ = 0;
			EventHandler<RouteManager.CharacterRouteChangedEventArgs> eventHandler = default;
			object obj2 = eventHandler + 16;
			obj2 = this;
			_routeManager.OnCharacterRouteChanged += eventHandler;
		}
	}

	protected void Update()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected Obj, but got Unknown
		//IL_0135: Expected VT, but got Obj
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Expected Obj, but got Unknown
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Expected Obj, but got Unknown
		//IL_00ab: Expected VT, but got Obj
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Expected Obj, but got Unknown
		Transform transform = default;
		Character character = (Character)(transform + 24);
		Transform transform2 = (Transform)(transform + 12);
		if (~(_movedSinceLastFixedUpdate ? 1u : 0u) == 0)
		{
			object obj = this + 504;
			transform2 = (Transform)obj;
			Transform transform3 = transform2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S2_v6+8]");
			((UnityEngine.Object)transform3).m_CachedPtr = (IntPtr)0;
			character = (Character)(object)transform2;
			((UnityEngine.Object)character).m_CachedPtr = ((UnityEngine.Object)transform2).m_CachedPtr;
			object obj2 = this + 516;
			obj2 = character;
			_ = ((UnityEngine.Object)character).m_CachedPtr;
			GameObject gameObject = base.gameObject;
			transform.position = (Vector3)gameObject;
			character = (Character)(object)transform;
			((UnityEngine.Object)character).m_CachedPtr = ((UnityEngine.Object)transform).m_CachedPtr;
			object obj3 = this + 504;
			obj3 = character;
			_ = ((UnityEngine.Object)character).m_CachedPtr;
			_movedSinceLastFixedUpdate = false;
		}
		GameObject gameObject2 = base.gameObject;
		transform2.position = (Vector3)gameObject2;
		character = (Character)(object)transform2;
		((UnityEngine.Object)character).m_CachedPtr = ((UnityEngine.Object)transform2).m_CachedPtr;
		Vector3 previousPreviousFixedUpdateTransformPosition = character.PreviousPreviousFixedUpdateTransformPosition;
		CharacterTriggerNotifier._002Ector();
		CoinMagnetCollider._002Ector();
		CoinMagnetLongCollider._002Ector();
	}

	public void SetCharacterModelLocalRotation(Quaternion rotation)
	{
		//IL_000f: Expected I4, but got VT
		_characterModel.StartEyeAnimations((UIModelController.ModelScreen)rotation);
	}

	public Quaternion GetCharacterModelLocalRotation()
	{
		//IL_0011: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0 (UnityEngine.Quaternion)+BC]");
		GameObject gameObject = ((Component)0).gameObject;
		((UnityEngine.Object)this).m_CachedPtr = ((UnityEngine.Object)this).m_CachedPtr;
		Vector3 localScale = ((Transform)(object)this).localScale;
		Quaternion result = default;
		return result;
	}

	public unsafe void ResetCharacterModelLocalRotation()
	{
		//IL_04c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c8: Expected Obj, but got Unknown
		//IL_04d1: Expected Obj, but got I4
		//IL_04e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e5: Expected Obj, but got Unknown
		//IL_04ee: Expected Obj, but got I4
		//IL_04fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0502: Expected Obj, but got Unknown
		//IL_0508: Unknown result type (might be due to invalid IL or missing references)
		//IL_050d: Expected Obj, but got Unknown
		//IL_0545: Unknown result type (might be due to invalid IL or missing references)
		//IL_054a: Expected VT, but got Unknown
		//IL_0557: Expected F4, but got Obj
		//IL_0552: Expected native int or pointer, but got VT
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected Obj, but got Unknown
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Expected Obj, but got Unknown
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Expected Obj, but got Unknown
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Expected Obj, but got Unknown
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Expected Obj, but got Unknown
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Expected Obj, but got Unknown
		//IL_00dd: Expected VT, but got Obj
		//IL_0599: Expected I4, but got Obj
		//IL_0167: Expected I, but got Obj
		//IL_017d: Expected Obj, but got I
		//IL_05ea: Expected F4, but got I
		//IL_05ea: Expected F4, but got I
		//IL_0637: Expected F4, but got Obj
		//IL_0632: Expected native int or pointer, but got VT
		//IL_0672: Expected VT, but got Obj
		//IL_01a8: Expected I, but got Obj
		//IL_06d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_06db: Expected Obj, but got Unknown
		//IL_0707: Expected F4, but got I
		//IL_02c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c6: Expected Obj, but got Unknown
		//IL_02f2: Invalid comparison between I and F4
		//IL_0389: Unknown result type (might be due to invalid IL or missing references)
		//IL_038e: Expected Obj, but got Unknown
		//IL_042a: Unknown result type (might be due to invalid IL or missing references)
		//IL_042f: Expected Obj, but got Unknown
		//IL_0450: Unknown result type (might be due to invalid IL or missing references)
		//IL_0455: Expected Obj, but got Unknown
		//IL_0480: Invalid comparison between I and F4
		object obj2 = default;
		object obj = obj2 + 120;
		obj = 0;
		_ = 0;
		object obj3 = obj2 + 104;
		obj3 = 0;
		_ = 0;
		Transform transform = (Transform)(obj2 + 152);
		object obj4 = this + 248;
		transform = (Transform)obj4;
		Transform transform2 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S1_v11+8]");
		((UnityEngine.Object)transform2).m_CachedPtr = (IntPtr)0;
		obj = transform;
		_ = ((UnityEngine.Object)transform).m_CachedPtr;
		Vector2 vector = (Vector2)(obj2 + 136);
		((Vector2*)(nint)vector)->x = (float)transform;
		_ = ((UnityEngine.Object)transform).m_CachedPtr;
		if (vector.y < 0f)
		{
			_ = 1f;
			GameObject gameObject = base.gameObject;
			transform = (Transform)obj;
			Transform transform3 = transform;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
			((UnityEngine.Object)transform3).m_CachedPtr = (IntPtr)0;
			Vector3 localPosition = transform.localPosition;
			EndRoll();
		}
		Character character = (Character)(obj2 + 88);
		object obj5 = obj2 + 76;
		object obj6 = obj2 - -64;
		Transform transform4 = (Transform)(obj2 + 48);
		object obj7 = obj2 + 32;
		object obj8 = obj2 + 16;
		Game game = _game;
		if (~(game._isPaused ? 1u : 0u) == 0)
		{
			return;
		}
		_00210 val = (_00210)SingletonMonoBehaviour<>.Instantiate();
		float realtimeSinceStartup = Time.realtimeSinceStartup;
		if (realtimeSinceStartup == 0f)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @80D1");
		object obj9 = default;
		bool flag = obj9 != null && DebugSettings.DontUseBaseBundleInEditor;
		character.SetLastObstacleType((ObstacleType)this);
		obj3 = character;
		_ = ((UnityEngine.Object)character).m_CachedPtr;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F950");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F950");
		nint num = (nint)typeof(Quaternion);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v187 @ S0_v63 (Il2CppClass<UnityEngine.Quaternion>)+BA]");
		object obj10 = (nint)0 & (nint)0x200;
		if (obj10 != null)
		{
			nint num2 = (nint)typeof(Quaternion);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v192 @ S0_v142 (Il2CppClass<UnityEngine.Quaternion>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ S0_v29+4]");
		nint num3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ S0_v31+8]");
		transform4.Rotate(0f, num3, 0f);
		obj7 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v12+8]");
		_ = 0;
		obj8 = transform4;
		_ = ((UnityEngine.Object)transform4).m_CachedPtr;
		float unscaledTime = Time.unscaledTime;
		float t = 90f * unscaledTime;
		((Vector2*)(nint)vector)->x = (float)obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ S0_v35+8]");
		_ = 0;
		transform = (Transform)obj8;
		Transform transform5 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ S0_v37+8]");
		((UnityEngine.Object)transform5).m_CachedPtr = (IntPtr)0;
		Vector2 vector2 = Vector2.Lerp(vector, (Vector2)transform, t);
		transform = (Transform)obj2;
		Transform transform6 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((UnityEngine.Object)transform6).m_CachedPtr = (IntPtr)0;
		Quaternion characterModelLocalRotation = ((Character)(object)transform).GetCharacterModelLocalRotation();
		Game game2 = _game;
		CharacterModifierCollection modifiers = game2._modifiers;
		Hoverboard hoverboard = modifiers.hoverboard;
		IEnumerator enumerator;
		if (((CharacterModifier)hoverboard).stop != CharacterModifier.StopSignal.DONT_STOP)
		{
			Game game3 = _game;
			Game game4 = _game;
			CharacterModifierCollection modifiers2 = game4._modifiers;
			enumerator = ((LongMagnet)(object)game3._modifiers).PullPickupSpawnPoint((PickupSpawnPoint)(object)modifiers2.hoverboard);
		}
		else
		{
			enumerator = null;
		}
		if (!flag && ~(_killSwitchEnabled ? 1u : 0u) == 0)
		{
			object obj11 = this + 236;
			transform = (Transform)obj11;
			Transform transform7 = transform;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v306 @ S1_v78+8]");
			((UnityEngine.Object)transform7).m_CachedPtr = (IntPtr)0;
			if ((float)(nint)((UnityEngine.Object)transform).m_CachedPtr == _lastGamePositionZ)
			{
				Game game5 = _game;
				Variable<bool> isInGame = game5.IsInGame;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v321 @ S0_v110 (Variable`1<System.Boolean>)+8]");
				if ((nint)0 != 0)
				{
					Game game6 = _game;
					if (~(game6._isInStumbleDeathSequence ? 1u : 0u) != 0)
					{
						object obj12 = _game - -64;
						if (obj12 == null)
						{
							if (_killSwitchUpdates >= 1)
							{
								int killSwitchUpdates = _killSwitchUpdates - 1;
								_killSwitchUpdates = killSwitchUpdates;
							}
							else
							{
								Game game7 = _game;
								if (!game7._isPaused)
								{
									object obj13 = _game - -64;
									object obj14 = (object)enumerator | obj13;
									if (obj14 == null)
									{
										object obj15 = this + 236;
										transform = (Transform)obj15;
										Transform transform8 = transform;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v354 @ S1_v94+8]");
										((UnityEngine.Object)transform8).m_CachedPtr = (IntPtr)0;
										if ((float)(nint)((UnityEngine.Object)transform).m_CachedPtr > 10f)
										{
											ExpandColliders();
										}
									}
								}
							}
							goto IL_06d0;
						}
					}
				}
			}
			if (_killSwitchUpdates != 10)
			{
				_killSwitchUpdates = 10;
			}
		}
		goto IL_06d0;
		IL_06d0:
		object obj16 = this + 236;
		transform = (Transform)obj16;
		Transform transform9 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v298 @ S1_v71+8]");
		((UnityEngine.Object)transform9).m_CachedPtr = (IntPtr)0;
		_lastGamePositionZ = (nint)((UnityEngine.Object)transform).m_CachedPtr;
	}

	public void Reset()
	{
		//IL_006f: Expected I, but got Obj
		//IL_0085: Expected Obj, but got I
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		GameObject gameObject = _characterModel.gameObject;
		nint num = (nint)typeof(Quaternion);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S1_v5 (Il2CppClass<UnityEngine.Quaternion>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Quaternion);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S1_v14 (Il2CppClass<UnityEngine.Quaternion>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Vector2 zero = Vector2.zero;
		object obj2 = default;
		Transform transform = (Transform)(obj2 + 16);
		transform = (Transform)obj2;
		Transform transform2 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((UnityEngine.Object)transform2).m_CachedPtr = (IntPtr)0;
		Vector3 localScale = transform.localScale;
	}

	public unsafe void InitForRun()
	{
		//IL_0218: Expected VT, but got I4
		//IL_0289: Expected F4, but got I4
		//IL_02be: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c3: Expected Obj, but got Unknown
		//IL_02e5: Expected I, but got Obj
		//IL_02fb: Expected Obj, but got I
		//IL_0321: Unknown result type (might be due to invalid IL or missing references)
		//IL_0326: Expected Obj, but got Unknown
		//IL_0338: Unknown result type (might be due to invalid IL or missing references)
		//IL_033d: Expected VT, but got Unknown
		//IL_034a: Expected F4, but got Obj
		//IL_0345: Expected native int or pointer, but got VT
		//IL_035f: Expected F4, but got I
		//IL_035a: Expected native int or pointer, but got VT
		//IL_0368: Unknown result type (might be due to invalid IL or missing references)
		//IL_036d: Expected Obj, but got Unknown
		//IL_0388: Unknown result type (might be due to invalid IL or missing references)
		//IL_038d: Expected VT, but got Unknown
		//IL_039a: Expected F4, but got Obj
		//IL_0395: Expected native int or pointer, but got VT
		//IL_03ac: Expected F4, but got Obj
		//IL_03a7: Expected native int or pointer, but got VT
		//IL_03b9: Expected F4, but got Obj
		//IL_03b4: Expected native int or pointer, but got VT
		//IL_03ce: Expected F4, but got I
		//IL_03c9: Expected native int or pointer, but got VT
		//IL_03d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03dc: Expected Obj, but got Unknown
		//IL_007b: Expected F4, but got Obj
		//IL_0076: Expected native int or pointer, but got VT
		//IL_0090: Expected F4, but got I
		//IL_008b: Expected native int or pointer, but got VT
		//IL_009a: Expected Obj, but got VT
		//IL_002f: Expected I, but got Obj
		//IL_00b5: Expected native int or pointer, but got VT
		//IL_00c7: Expected native int or pointer, but got VT
		//IL_00eb: Expected F4, but got Obj
		//IL_00e6: Expected native int or pointer, but got VT
		//IL_0100: Expected F4, but got I
		//IL_00fb: Expected native int or pointer, but got VT
		//IL_010f: Expected Ref, but got VT
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0134: Expected Obj, but got Unknown
		LastDeathCause = DeathCause.None;
		_lastObstacleType = ObstacleType.None;
		Game game = _game;
		Game game2 = _game;
		Game.SpeedInfo speed = game2.speed;
		game.SpeedAtLastObstacleHit = speed.min;
		SetCharacterModelLocalRotation((Quaternion)1);
		Reset();
		_stumbleState = StumbleState.Standard;
		_trackIndexTarget = 1;
		if (__trackIndex != 1)
		{
			__trackIndexPrevious = __trackIndex;
			__trackIndex = 1;
		}
		float num = (float)__trackIndex * 20f;
		x = num;
		_trackIndexPosition = __trackIndex;
		_trackMovement = 0;
		_trackMovementNext = 0;
		_ignoredMovement = 0;
		_squeezeCollider.UpdateValue();
		object obj = default;
		RouteBuilder routeBuilder = (RouteBuilder)(obj + 48);
		routeBuilder.HideLogic(x, 0f);
		nint num2 = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ S0_v30 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num3 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S0_v72 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj3 = obj + 36;
		Vector3 down = Vector3.down;
		Vector3 vector = (Vector3)(obj + 72);
		((Vector3*)(nint)vector)->x = (float)obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ S0_v35+8]");
		((Vector3*)(nint)vector)->z = 0f;
		object obj4 = obj + 24;
		Vector3 vector2 = vector / 5f;
		Vector3 vector3 = (Vector3)(obj + 60);
		((Vector3*)(nint)vector3)->x = (float)routeBuilder;
		((Vector3*)(nint)vector3)->z = (float)routeBuilder.OnCompletedLayingSections;
		((Vector3*)(nint)vector)->x = (float)obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ S0_v40+8]");
		((Vector3*)(nint)vector)->z = 0f;
		object obj5 = obj + 12;
		Vector3 vector4 = vector3 - vector;
		((Vector3*)(nint)vector)->x = (float)obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ S0_v47+8]");
		((Vector3*)(nint)vector)->z = 0f;
		UpdateGroundTag((Character)vector);
		Vector3 down2 = Vector3.down;
		((Vector3*)(nint)vector)->x = vector3.x;
		((Vector3*)(nint)vector)->z = vector3.z;
		Quaternion quaternion = Quaternion.AngleAxis(-5f, vector);
		((Vector3*)(nint)vector)->x = (float)obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((Vector3*)(nint)vector)->z = 0f;
		CollisionFlags collisionFlags = _characterController.Move_Injected(ref *(Vector3*)vector);
		EndRoll();
		verticalSpeed = 0f;
		object obj6 = this + 532;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @39CF");
		JumpHeight = jumpHeightNormal;
		inAirJump = false;
		__isJumping = false;
		_isRolling = false;
		__isInLipFlight = false;
		_startedJumpFromGround = false;
		_jumpUpperCollision = false;
		_jumpUpperCollisionEvaded = true;
		LastGroundedY = 0f;
		__isInLipFlight = false;
		throw new IndexOutOfRangeException();
	}

	public void Revive()
	{
		NotifyOnCriticalHit(CriticalHitType.Train);
	}

	private void SetLastObstacleType(ObstacleType ot)
	{
		//IL_0011: Expected Obj, but got I
		//IL_001f: Expected VT, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [ot @ L1 (SYBO.Subway.Characters.Character+ObstacleType)+BC]");
		GameObject gameObject = ((Component)0).gameObject;
		((Transform)(object)this).localRotation = (Quaternion)gameObject;
	}

	private unsafe void ClearLastObstacleType()
	{
		//IL_01cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d0: Expected Obj, but got Unknown
		//IL_01d9: Expected Obj, but got I4
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Expected Obj, but got Unknown
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Expected Obj, but got Unknown
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Expected Obj, but got Unknown
		//IL_0142: Expected I, but got Obj
		//IL_0158: Expected Obj, but got I
		//IL_02a8: Expected VT, but got Obj
		//IL_0183: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 24;
		obj = 0;
		_ = 0;
		_ = 0;
		LastDeathCause = DeathCause.None;
		_lastObstacleType = ObstacleType.None;
		Game game = _game;
		Game game2 = _game;
		Game.SpeedInfo speed = game2.speed;
		game.SpeedAtLastObstacleHit = speed.min;
		_characterRendering.Character_OnEnterRoute();
		if (this.m_OnRevive != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @78B7");
		}
		if (~(_isStumbling ? 1u : 0u) == 0)
		{
			HitByTrainSequence();
		}
		Collider collider = (Collider)(obj2 + 48);
		object obj3 = obj2 + 12;
		__isJumping = true;
		_isFalling = false;
		float fOVForAspectRatio = ((CharacterCamera)this).GetFOVForAspectRatio(15f);
		verticalSpeed = fOVForAspectRatio;
		object obj4 = this + 532;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @39CF");
		if (~(_jumpUpperCollision ? 1u : 0u) == 0)
		{
			collider.get_bounds_Injected(out *(Bounds*)_characterController);
			obj = collider;
			_ = ((UnityEngine.Object)collider).m_CachedPtr;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ S0_v25 (UnityEngine.Collider)+10]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F4AA");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ S0_v27+4]");
			float num = 0f - _jumpUpperCollisionColliderMinY;
			if (num < 0f)
			{
				nint num2 = (nint)typeof(Vector3);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ S1_v41 (Il2CppClass<UnityEngine.Vector3>)+BA]");
				object obj5 = (nint)0 & (nint)0x200;
				if (obj5 != null)
				{
					nint num3 = (nint)typeof(Vector3);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v140 @ S1_v52 (Il2CppClass<UnityEngine.Vector3>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				Vector3 down = Vector3.down;
				collider = (Collider)obj3;
				Collider collider2 = collider;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ S0_v27+8]");
				((UnityEngine.Object)collider2).m_CachedPtr = (IntPtr)0;
				Quaternion quaternion = Quaternion.AngleAxis(num, (Vector3)collider);
				collider = (Collider)obj2;
				Collider collider3 = collider;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
				((UnityEngine.Object)collider3).m_CachedPtr = (IntPtr)0;
				CollisionFlags collisionFlags = _characterController.Move_Injected(ref *(Vector3*)collider);
			}
		}
		EndRoll();
		_jumpUpperCollision = false;
		_jumpUpperCollisionEvaded = true;
	}

	public void SetGamePosition(Vector3 gamePosition)
	{
		//IL_000a: Expected I4, but got VT
		_lastObstacleType = (ObstacleType)gamePosition;
		Game game = _game;
		Game game2 = _game;
		game.SpeedAtLastObstacleHit = game2.__currentSpeed;
	}

	public unsafe void UpdateGroundTag(Character character)
	{
		//IL_0071: Expected I, but got Obj
		//IL_0087: Expected Obj, but got I
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Expected I4, but got Unknown
		//IL_00c8: Expected I4, but got Obj
		//IL_00e3: Expected Obj, but got I4
		//IL_00f0: Expected I4, but got Obj
		//IL_0103: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		GameObject gameObject = base.gameObject;
		nint num = (nint)typeof(GamePositionRoot);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S1_v5 (Il2CppClass<SYBO.Subway.Level.GamePositionRoot>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(GamePositionRoot);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S1_v19 (Il2CppClass<SYBO.Subway.Level.GamePositionRoot>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool isRestricted = AgeRestriction.isRestricted;
		BackgroundCulling backgroundCulling = default;
		int num3 = backgroundCulling + 12;
		((int*)num3)->m_value = (int)character;
		_ = ((UnityEngine.Object)character).m_CachedPtr;
		backgroundCulling.Initialize((Material)isRestricted, num3);
		((int*)num3)->m_value = (int)backgroundCulling;
		_ = backgroundCulling.EnvironmentType;
		Vector3 localPosition = ((Transform)num3).localPosition;
		EndRoll();
	}

	public void UpdateInAirRunPosition()
	{
		_lastObstacleType = ObstacleType.None;
		Game game = _game;
		Game game2 = _game;
		Game.SpeedInfo speed = game2.speed;
		game.SpeedAtLastObstacleHit = speed.min;
	}

	private unsafe void LandedOnTrain(Collider trainCollider)
	{
		//IL_020e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0213: Expected VT, but got Unknown
		//IL_021c: Expected native int or pointer, but got VT
		//IL_022a: Expected native int or pointer, but got VT
		//IL_0250: Unknown result type (might be due to invalid IL or missing references)
		//IL_0255: Expected Obj, but got Unknown
		//IL_026a: Expected VT, but got I
		//IL_0278: Expected I, but got Obj
		//IL_028e: Expected Obj, but got I
		//IL_02b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b9: Expected Obj, but got Unknown
		//IL_02cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d0: Expected VT, but got Unknown
		//IL_02dd: Expected F4, but got Obj
		//IL_02d8: Expected native int or pointer, but got VT
		//IL_02f2: Expected F4, but got I
		//IL_02ed: Expected native int or pointer, but got VT
		//IL_02fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0300: Expected Obj, but got Unknown
		//IL_0316: Expected Obj, but got I4
		//IL_032b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0330: Expected Obj, but got Unknown
		//IL_034f: Expected F4, but got Obj
		//IL_034a: Expected native int or pointer, but got VT
		//IL_0364: Expected F4, but got I
		//IL_035f: Expected native int or pointer, but got VT
		//IL_005f: Expected F4, but got Obj
		//IL_005a: Expected native int or pointer, but got VT
		//IL_0074: Expected F4, but got I
		//IL_006f: Expected native int or pointer, but got VT
		//IL_0013: Expected I, but got Obj
		object obj = default;
		Vector3 vector = (Vector3)(obj + 60);
		((Vector3*)(nint)vector)->x = 0f;
		((Vector3*)(nint)vector)->z = 0f;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		Transform transform = (Transform)(obj + 48);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [trainCollider @ L1 (UnityEngine.Collider)+D4]");
		transform.position = (Vector3)0;
		nint num = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S0_v18 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S0_v63 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj3 = obj + 36;
		Vector3 down = Vector3.down;
		Quaternion quaternion = (Quaternion)(obj + 120);
		((Quaternion*)(nint)quaternion)->x = (float)obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S0_v23+8]");
		((Quaternion*)(nint)quaternion)->z = 0f;
		object obj4 = obj + 24;
		Quaternion quaternion2 = Quaternion.Inverse(quaternion);
		obj = 0;
		_ = 0;
		_ = 0;
		object obj5 = obj + 104;
		obj5 = transform;
		_ = ((UnityEngine.Object)transform).m_CachedPtr;
		((Quaternion*)(nint)quaternion)->x = (float)obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S0_v28+8]");
		((Quaternion*)(nint)quaternion)->z = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F967");
		((Quaternion*)(nint)quaternion)->x = (float)obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((Quaternion*)(nint)quaternion)->z = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+10]");
		_ = 0;
		RaycastHit[] array = Physics.RaycastAll((Vector3)quaternion, vector);
		if (array != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1168A");
			CustomYieldInstruction customYieldInstruction = default;
			object current = customYieldInstruction.Current;
			if ((string)current != "Ground")
			{
				CurrentRunPosition__BackingField = RunPositions.ground;
				StayInOneLaneMission instance = StayInOneLaneMission.instance;
				((MissionsManager)(object)instance).ResetProgressForMissionIndex(60);
			}
			else if ((string)current != "HitTrain")
			{
				CurrentRunPosition__BackingField = RunPositions.train;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1168A");
				int trackDelta = default;
				ChangeTrackBy(trackDelta);
			}
			else if ((string)current != "HitMovingTrain")
			{
				CurrentRunPosition__BackingField = RunPositions.movingTrain;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1168A");
				int trackDelta2 = default;
				ChangeTrackBy(trackDelta2);
			}
			else if ((string)current != "Station")
			{
				CurrentRunPosition__BackingField = RunPositions.station;
			}
		}
	}

	public bool IsDescending()
	{
		//IL_000f: Expected I4, but got Obj
		return (byte)(int)_characterModel.CharacterRig != 0;
	}

	public unsafe void CreateExplosionAtCharactersFeet()
	{
		string text = ((PhysicsScene*)_characterController)->ToString();
		if (text == null)
		{
			CurrentRunPosition__BackingField = RunPositions.air;
		}
	}

	public TrackLane GetLaneFromIndex(int laneIndex)
	{
		//IL_0014: Expected Obj, but got I4
		return ((HashSet<Coin>)(object)CharacterTriggerNotifier).Contains((Coin)laneIndex) ? TrackLane.Left : TrackLane.None;
	}

	public void ChangeTrackLeft1()
	{
		//IL_00a1: Expected Obj, but got I4
		//IL_00b0: Expected Obj, but got F4
		//IL_00ca: Expected I, but got Obj
		//IL_00e0: Expected Obj, but got I
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		//IL_010b: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_007c: Expected Obj, but got I4
		//IL_0092: Expected VT, but got I4
		//IL_0092: Expected Obj, but got I4
		object obj = 0;
		_ = 0;
		obj = 0f;
		_ = 0f;
		_ = -7f;
		nint num = (nint)typeof(RouteScoreChangeExplosion);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S0_v14 (Il2CppClass<SYBO.Subway.Routes.RouteScoreChangeExplosion>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(RouteScoreChangeExplosion);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S0_v26 (Il2CppClass<SYBO.Subway.Routes.RouteScoreChangeExplosion>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		RouteSection routeSection = (RouteSection)(obj + 12);
		routeSection = (RouteSection)obj;
		RouteSection routeSection2 = routeSection;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((UnityEngine.Object)routeSection2).m_CachedPtr = (IntPtr)0;
		List<EnvironmentKind> forcedEnvironmentKinds = routeSection.ForcedEnvironmentKinds;
		string text = ((Component)(object)forcedEnvironmentKinds).tag;
		int layer = ((GameObject)(object)text).layer;
		HoverboardBundle hoverboardBundle = _characterModel.AddEquippedHoverboard();
		int layer2 = ((GameObject)(object)hoverboardBundle).layer;
		Transform parentInternal = ((Transform)layer2).parentInternal;
		HierarchyUtility.Reparent((Transform)layer, parentInternal, (Vector3)0);
	}

	public void ChangeTrackLeft2()
	{
		ChangeTrackTo(-1);
	}

	public void ChangeTrackRight1()
	{
		ChangeTrackTo(-1);
	}

	public void ChangeTrackRight2()
	{
		ChangeTrackTo(1);
	}

	public void ChangeTrackCenter()
	{
		ChangeTrackTo(1);
	}

	public void ChangeTrackBy(int trackDelta)
	{
		//IL_00e5: Expected Obj, but got I4
		//IL_00e5: Expected Obj, but got I4
		//IL_00e5: Expected Obj, but got I4
		//IL_0014: Expected VT, but got I4
		//IL_0097: Expected Obj, but got I4
		if (_hoverboard.isActiveAndEnabled && !((Stack<T>)(object)GrindedTrains).Contains((T)trackDelta))
		{
			Queue<Collider> grindedTrains = GrindedTrains;
			if (grindedTrains._size > GrindedTrainsBufferSize)
			{
				_00210 val = (_00210)((Queue<T>)(object)GrindedTrains).Peek();
			}
			GrindedTrains.Enqueue((Collider)trackDelta);
		}
		StayInOneLaneMission instance = StayInOneLaneMission.instance;
		((OwnBoardsAward)(object)instance)._002Ector((AwardStaticData)60, (PersistentAwardProgress)1, (Action<Award>)(-1));
	}

	private void ChangeTrackTo(int newTrackIndex)
	{
		//IL_0100: Expected I, but got Obj
		//IL_0116: Expected Obj, but got I
		//IL_00a8: Expected I, but got Obj
		//IL_0037: Expected I, but got Obj
		bool isDoubleJumping = IsDoubleJumping;
		nint num = (nint)typeof(Game);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ S1_v4 (Il2CppClass<SYBO.Subway.Game>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		bool flag = obj == null;
		if (isDoubleJumping)
		{
			if (!flag)
			{
				nint num2 = (nint)typeof(Game);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S0_v20 (Il2CppClass<SYBO.Subway.Game>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool isInstantiated = Game.IsInstantiated;
			float num3 = 20f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S3_v7 (System.Boolean)+44]");
			float duration = num3 / 0f;
			ForceChangeTrack(newTrackIndex, duration);
			return;
		}
		if (!flag)
		{
			nint num4 = (nint)typeof(Game);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S0_v12 (Il2CppClass<SYBO.Subway.Game>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool isInstantiated2 = Game.IsInstantiated;
		float num5 = 30f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ S3_v3 (System.Boolean)+44]");
		float duration2 = num5 / 0f;
		ForceChangeTrack(newTrackIndex, duration2);
	}

	public void ChangeTrackBy(int trackDelta, float duration)
	{
		//IL_0009: Expected Obj, but got I4
		//IL_001f: Expected Obj, but got I4
		float unscaledCoinSpacing = ((CoinCurve)trackDelta).UnscaledCoinSpacing;
		((CharacterRendering)this).OnCatchPlayer((string)trackDelta, duration, unscaledCoinSpacing);
	}

	public void ForceChangeTrack(int movement, float duration)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0080: Expected VT, but got I4
		//IL_0080: Expected VT, but got Obj
		//IL_011c: Expected Obj, but got I4
		//IL_01d1: Expected Obj, but got I4
		//IL_01e0: Expected Obj, but got F4
		//IL_0181: Expected Obj, but got I4
		//IL_0190: Expected Obj, but got F4
		object obj = default;
		Collider collider = (Collider)(obj + 12);
		if (_ignoredMovement == movement)
		{
			return;
		}
		if (_trackMovement == movement)
		{
			_trackMovementNext = movement;
			return;
		}
		GizmoUtility.DrawArrow((Vector3)this, (Vector3)movement, duration);
		if (!IsDoubleJumping || _game.HasSuperSneakers || _game.IsInPogostickMode)
		{
			return;
		}
		object obj2 = movement - -1;
		if (movement != -1)
		{
			if ((nint)obj2 != 1 && (nint)obj2 == 2)
			{
				obj = 0;
				_ = 0;
				obj = 20f;
				_ = 0f;
				_ = 1f;
				collider = (Collider)obj;
				Collider collider2 = collider;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
				((UnityEngine.Object)collider2).m_CachedPtr = (IntPtr)0;
				OnCharacterTriggerExit(collider);
			}
		}
		else
		{
			obj = 0;
			_ = 0;
			obj = -20f;
			_ = 0f;
			_ = 1f;
			collider = (Collider)obj;
			Collider collider3 = collider;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			((UnityEngine.Object)collider3).m_CachedPtr = (IntPtr)0;
			OnCharacterTriggerExit(collider);
		}
	}

	public void SetLastCheckpointGamePositionZ(float gamePositionZ)
	{
		_trackIndexPosition = gamePositionZ;
	}

	public void ForceLeaveSubway()
	{
		if (__trackIndex == 2)
		{
			ChangeTrackLeft2();
		}
		else if (__trackIndex == 0)
		{
			ChangeTrackRight2();
		}
	}

	public float GetTrackX()
	{
		return _lastCheckpointGamePositionZ;
	}

	public void JumpAdvanced(float jumpHeight, bool willPlaySound = true, bool willPlayAnimation = true)
	{
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_0054: Expected I, but got Obj
		//IL_00a3: Expected Obj, but got F4
		//IL_0264: Expected I, but got Obj
		//IL_027a: Expected Obj, but got I
		//IL_00d6: Expected I, but got Obj
		//IL_0145: Invalid comparison between I and F4
		//IL_0173: Expected Obj, but got I4
		//IL_0184: Expected Obj, but got I4
		//IL_01c0: Expected Obj, but got I4
		//IL_01b3: Expected Obj, but got I4
		float num = verticalFallSpeedLimit;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v11 (System.Single)+C]");
		if ((nint)0 == 0)
		{
			return;
		}
		nint num2 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S1_v5 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num3 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ S1_v21 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		RouteChunk routeChunk;
		if (_characterRendering != null)
		{
			routeChunk = ((List<RouteChunk>)verticalFallSpeedLimit).get_Item(0);
		}
		else
		{
			CharacterRendering characterRendering = _characterRendering;
			routeChunk = (RouteChunk)(object)characterRendering._characterController;
		}
		bool flag = !willPlayAnimation;
		RouteChunk routeChunk2 = routeChunk;
		while (true)
		{
			nint num4 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ S0_v23 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num5 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ S0_v42 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)(object)routeChunk2).FindKernel((string)null) != 0 && !routeChunk2._built)
			{
				Vector3 gamePositionEnd = routeChunk2.GamePositionEnd;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
				if (0f < jumpHeight)
				{
					bool flag2 = ((List<RouteChunk>)SetPieceForcedForgivingJump).Contains(routeChunk2);
					object obj3 = flag & flag2;
					if (obj3 != null)
					{
						break;
					}
					RouteChunk next = ((!flag2) ? ((RouteChunk)willPlaySound) : ((RouteChunk)willPlayAnimation));
					((RouteBuilder)(object)this).SetChunkCrossReferences(routeChunk2, next);
					routeChunk2 = routeChunk2.Next;
					continue;
				}
				break;
			}
			break;
		}
	}

	private IEnumerator ToggleDustWithDelay(float delay)
	{
		//IL_0050: Expected Obj, but got I4
		if ((nint)CoinMagnetCollider > -1)
		{
			int num = ((CoinCurve)this).NumberOfCoins(delay);
			bool flag = (nint)CoinMagnetCollider < num;
			return (IEnumerator)flag;
		}
		return null;
	}

	public void Jump()
	{
		throw new IndexOutOfRangeException();
	}

	public unsafe void CheckInAirJump()
	{
		//IL_07bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_07c1: Expected Obj, but got Unknown
		//IL_07ca: Expected Obj, but got I4
		//IL_07d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_07de: Expected Obj, but got Unknown
		//IL_07e7: Expected Obj, but got I4
		//IL_07f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_07fb: Expected Obj, but got Unknown
		//IL_0804: Expected Obj, but got I4
		//IL_0813: Unknown result type (might be due to invalid IL or missing references)
		//IL_0818: Expected Obj, but got Unknown
		//IL_0821: Expected Obj, but got I4
		//IL_0072: Expected Obj, but got I4
		//IL_0137: Expected Obj, but got I4
		//IL_0064: Expected Obj, but got I4
		//IL_0898: Unknown result type (might be due to invalid IL or missing references)
		//IL_089d: Expected Obj, but got Unknown
		//IL_08a6: Expected Obj, but got I4
		//IL_08be: Unknown result type (might be due to invalid IL or missing references)
		//IL_08c3: Expected Obj, but got Unknown
		//IL_004d: Expected Obj, but got I4
		//IL_0909: Unknown result type (might be due to invalid IL or missing references)
		//IL_090e: Expected VT, but got Unknown
		//IL_0917: Unknown result type (might be due to invalid IL or missing references)
		//IL_091c: Expected Obj, but got Unknown
		//IL_0925: Unknown result type (might be due to invalid IL or missing references)
		//IL_092a: Expected Obj, but got Unknown
		//IL_0933: Unknown result type (might be due to invalid IL or missing references)
		//IL_0938: Expected Obj, but got Unknown
		//IL_0941: Unknown result type (might be due to invalid IL or missing references)
		//IL_0946: Expected Obj, but got Unknown
		//IL_094f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0954: Expected Obj, but got Unknown
		//IL_095d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0962: Expected Obj, but got Unknown
		//IL_096b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0970: Expected Obj, but got Unknown
		//IL_015e: Expected Obj, but got I4
		//IL_0104: Expected Obj, but got I4
		//IL_00c8: Expected Obj, but got I4
		SuperSneakersJump? superSneakersJump = default;
		object obj = (Nullable)superSneakersJump + 136;
		obj = 0;
		_ = 0;
		object obj2 = (Nullable)superSneakersJump + 120;
		obj2 = 0;
		_ = 0;
		object obj3 = (Nullable)superSneakersJump + 104;
		obj3 = 0;
		_ = 0;
		object obj4 = (Nullable)superSneakersJump + 88;
		obj4 = 0;
		_ = 0;
		object obj5;
		if (~(__isJumping ? 1u : 0u) != 0 && !(verticalSpeed > 0f))
		{
			bool flag = verticalSpeed > _verticalSpeed_jumpTolerance;
			obj5 = 1;
			if (flag)
			{
				goto IL_084b;
			}
		}
		if (~(SetPieceForcedForgivingJump ? 1u : 0u) == 0)
		{
			obj5 = 0;
			goto IL_084b;
		}
		object obj6 = 0;
		goto IL_0123;
		IL_0892:
		object obj7 = this + 152;
		obj7 = 0;
		string text = ((PhysicsScene*)_characterController)->ToString();
		object obj8 = obj6 ^ 1;
		object obj9 = (object)text | obj8;
		bool flag2 = obj9 == null;
		bool flag3 = !flag2;
		string text2 = text;
		if (!flag3)
		{
			bool flag4 = TransitioningFromHeight__BackingField;
			string text3 = (string)((flag4 ? 1 : 0) ^ 1);
			text2 = text3;
		}
		SuperSneakersJump superSneakersJump2 = (SuperSneakersJump)((Nullable)superSneakersJump + 148);
		object obj10 = (Nullable)superSneakersJump + 76;
		object obj11 = (Nullable)superSneakersJump - -64;
		object obj12 = (Nullable)superSneakersJump + 48;
		object obj13 = (Nullable)superSneakersJump + 32;
		object obj14 = (Nullable)superSneakersJump + 20;
		object obj15 = text2 & 1;
		object obj16 = 1 | obj15;
		if (obj16 != null)
		{
			if (~(__isJumping ? 1u : 0u) == 0 && ~(_jumpUpperCollisionEvaded ? 1u : 0u) == 0)
			{
				_jumpUpperCollision = false;
			}
			if (~(_isRolling ? 1u : 0u) == 0)
			{
				NotifyCriticalHit();
			}
			_glideTimeLeft = 0f;
			_vTolEnded = false;
			_willSecondJump = true;
			__isJumping = true;
			_isFalling = false;
			throw new NullReferenceException();
		}
		if (!IsRunningFromTrain())
		{
			if (verticalSpeed < 0f)
			{
				inAirJump = true;
			}
			return;
		}
		if (~(__isJumping ? 1u : 0u) == 0 && ~(_jumpUpperCollisionEvaded ? 1u : 0u) == 0)
		{
			_jumpUpperCollision = false;
		}
		if (~(_isRolling ? 1u : 0u) == 0)
		{
			NotifyCriticalHit();
		}
		_glideTimeLeft = 0f;
		_vTolEnded = false;
		_willSecondJump = false;
		__isJumping = true;
		_isFalling = false;
		throw new NullReferenceException();
		IL_084b:
		float deltaTime = Time.deltaTime;
		float num = deltaTime - SetPieceForgivingJumpTime;
		object obj17;
		if (num < 0.15f)
		{
			Variable<bool> isGrounded = IsGrounded;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ S0_v199 (Variable`1<System.Boolean>)+8]");
			bool flag5 = (nint)0 != 0;
			SetPieceForcedForgivingJump = false;
			if (flag5)
			{
				obj17 = 0;
			}
			else
			{
				if (OnSetPieceForgivingJump != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @78B7");
				}
				obj17 = 1;
			}
			obj6 = obj5;
			goto IL_0892;
		}
		obj6 = obj5;
		goto IL_0123;
		IL_0123:
		SetPieceForcedForgivingJump = false;
		obj17 = 0;
		goto IL_0892;
	}

	private void Teleboard(Vector3 offset)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected I4, but got Unknown
		int newTrackIndex = (int)(offset - __trackIndex);
		ChangeTrackTo(newTrackIndex);
	}

	public unsafe void Roll()
	{
		string text = ((PhysicsScene*)_characterController)->ToString();
		if (text != null && ~(inAirJump ? 1u : 0u) == 0)
		{
			CheckInAirJump();
			inAirJump = false;
		}
	}

	public void EnterRoute()
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected Obj, but got Unknown
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Expected Obj, but got Unknown
		if (~(_isRolling ? 1u : 0u) != 0)
		{
			_isTucked = false;
			_glideTimeLeft = _glideTime;
			object obj = this + 532;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v14+10]");
			if ((nint)0 != 0)
			{
				object obj2 = this + 532;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @39CF");
			}
			_squeezeCollider.Remove(this);
			if (~(TransitioningFromHeight__BackingField ? 1u : 0u) == 0)
			{
				verticalSpeed = -250f;
			}
			else
			{
				float fOVForAspectRatio = ((CharacterCamera)this).GetFOVForAspectRatio(JumpHeight);
				float num = 0f - fOVForAspectRatio;
				verticalSpeed = num;
			}
			_isRolling = true;
			inAirJump = false;
			NotifyOnHitByTrain();
		}
	}

	public void EnterRouteEnd()
	{
		RaiseOnEnterRouteEnd();
	}

	public void ExitRoute()
	{
		RaiseExitRoute();
	}

	public void ApplyGravity()
	{
		this._002Ector();
	}

	public unsafe void MoveWithGravity()
	{
		//IL_05c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c6: Expected VT, but got Unknown
		//IL_05cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d4: Expected Obj, but got Unknown
		//IL_05dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e2: Expected Obj, but got Unknown
		//IL_05eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f0: Expected Obj, but got Unknown
		//IL_05f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_05fe: Expected Obj, but got Unknown
		//IL_0607: Unknown result type (might be due to invalid IL or missing references)
		//IL_060c: Expected VT, but got Unknown
		//IL_0615: Expected native int or pointer, but got VT
		//IL_0623: Expected native int or pointer, but got VT
		//IL_012e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0133: Expected Obj, but got Unknown
		//IL_0140: Expected F4, but got Obj
		//IL_013b: Expected native int or pointer, but got VT
		//IL_0155: Expected F4, but got I
		//IL_0150: Expected native int or pointer, but got VT
		//IL_0189: Unknown result type (might be due to invalid IL or missing references)
		//IL_018e: Expected Obj, but got Unknown
		//IL_01b1: Expected I, but got Obj
		//IL_01c7: Expected Obj, but got I
		//IL_06c6: Expected F4, but got Obj
		//IL_06c1: Expected native int or pointer, but got VT
		//IL_06db: Expected F4, but got I
		//IL_06d6: Expected native int or pointer, but got VT
		//IL_06f1: Expected Obj, but got I4
		//IL_071f: Expected F4, but got Obj
		//IL_071a: Expected native int or pointer, but got VT
		//IL_0734: Expected F4, but got I
		//IL_072f: Expected native int or pointer, but got VT
		//IL_023e: Expected F4, but got Obj
		//IL_0239: Expected native int or pointer, but got VT
		//IL_0253: Expected F4, but got I
		//IL_024e: Expected native int or pointer, but got VT
		//IL_01f2: Expected I, but got Obj
		object obj = default;
		Quaternion quaternion = (Quaternion)(obj + 120);
		object obj2 = obj + 104;
		object obj3 = obj + 48;
		object obj4 = obj + 36;
		object obj5 = obj + 24;
		Vector3 vector = (Vector3)(obj + 60);
		((Vector3*)(nint)vector)->x = 0f;
		((Vector3*)(nint)vector)->z = 0f;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		if (verticalSpeed < 0f)
		{
			string text = ((PhysicsScene*)_characterController)->ToString();
			if (text != null)
			{
				if (~(_startedJumpFromGround ? 1u : 0u) == 0 && ~(_trainJump ? 1u : 0u) == 0 && CurrentRunPosition__BackingField == RunPositions.ground)
				{
					RaiseOnEnterRoute();
				}
				if (CurrentRunPosition__BackingField != RunPositions.air)
				{
					_startedJumpFromGround = false;
				}
				throw new NullReferenceException();
			}
		}
		if (~(_startedJumpFromGround ? 1u : 0u) == 0)
		{
			object obj6 = this + 236;
			((Quaternion*)(nint)quaternion)->x = (float)obj6;
			Quaternion quaternion2 = quaternion;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ S2_v24+8]");
			((Quaternion*)(nint)quaternion2)->z = 0f;
			if (_trainJumpSampleGamePositionZ < quaternion.z)
			{
				object obj7 = this + 248;
				obj3 = obj7;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ S1_v64+8]");
				_ = 0;
				nint num = (nint)typeof(Vector3);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ S0_v96 (Il2CppClass<UnityEngine.Vector3>)+BA]");
				object obj8 = (nint)0 & (nint)0x200;
				if (obj8 != null)
				{
					nint num2 = (nint)typeof(Vector3);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ S0_v129 (Il2CppClass<UnityEngine.Vector3>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				Vector3 down = Vector3.down;
				((Quaternion*)(nint)quaternion)->x = (float)obj4;
				Quaternion quaternion3 = quaternion;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v15+8]");
				((Quaternion*)(nint)quaternion3)->z = 0f;
				Quaternion quaternion4 = Quaternion.Inverse(quaternion);
				obj = 0;
				_ = 0;
				_ = 0;
				obj2 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13+8]");
				_ = 0;
				((Quaternion*)(nint)quaternion)->x = (float)obj5;
				Quaternion quaternion5 = quaternion;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v17+8]");
				((Quaternion*)(nint)quaternion5)->z = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F967");
				((Quaternion*)(nint)quaternion)->x = (float)obj;
				Quaternion quaternion6 = quaternion;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
				((Quaternion*)(nint)quaternion6)->z = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+10]");
				_ = 0;
				RaycastHit[] array = Physics.RaycastAll((Vector3)quaternion, vector);
				if (array != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1168A");
					GameObject gameObject = default;
					Component component = gameObject.GetComponent((Type)(object)"HitMovingTrain");
					if ((object)component == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1168A");
						GameObject gameObject2 = default;
						Component component2 = gameObject2.GetComponent((Type)(object)"HitTrain");
						if ((object)component2 == null)
						{
							goto IL_0743;
						}
					}
					_trainJump = true;
				}
				goto IL_0743;
			}
		}
		goto IL_0697;
		IL_07a4:
		string text2 = ((PhysicsScene*)_characterController)->ToString();
		if (text2 == null && ~(_isFalling ? 1u : 0u) != 0 && verticalSpeed < verticalFallSpeedLimit && ~(_isRolling ? 1u : 0u) != 0)
		{
			_isFalling = true;
			_isTucked = false;
			NotifyOnRoll();
			throw new NullReferenceException();
		}
		return;
		IL_0697:
		if (~(_isFalling ? 1u : 0u) == 0 && IsVTol)
		{
			if (_glideTimeLeft < _glideTime)
			{
				float defaultValue = _glideTimeLeft / _glideTime;
				float num3 = PlayerPrefs.GetFloat((string)(object)_glideVerticalSpeed, defaultValue);
				float num4 = gliderGravity * num3;
				verticalSpeed = num4;
				float unscaledTime = Time.unscaledTime;
				float glideTimeLeft = _glideTimeLeft + unscaledTime;
				_glideTimeLeft = glideTimeLeft;
			}
			else
			{
				float unscaledTime2 = Time.unscaledTime;
				float num5 = gliderGravity * unscaledTime2;
				float num6 = verticalSpeed - num5;
				verticalSpeed = num6;
			}
		}
		else
		{
			if (~(_isFalling ? 1u : 0u) == 0)
			{
				CharacterController characterController = CharacterController;
				if ((object)characterController != null)
				{
					if (_glideTimeLeft < _glideTime)
					{
						verticalSpeed = 0f;
						float unscaledTime3 = Time.unscaledTime;
						float glideTimeLeft2 = _glideTimeLeft + unscaledTime3;
						_glideTimeLeft = glideTimeLeft2;
					}
					else
					{
						if (~(_vTolEnded ? 1u : 0u) != 0)
						{
							if (this.m_OnVTolEnd != null)
							{
								this.m_OnVTolEnd();
							}
							_vTolEnded = true;
						}
						float unscaledTime4 = Time.unscaledTime;
						float num7 = gravity * unscaledTime4;
						float num8 = verticalSpeed - num7;
						verticalSpeed = num8;
					}
					goto IL_07a4;
				}
			}
			float unscaledTime5 = Time.unscaledTime;
			float num9 = gravity * unscaledTime5;
			float num10 = verticalSpeed - num9;
			verticalSpeed = num10;
		}
		goto IL_07a4;
		IL_0743:
		float trainJumpSampleGamePositionZ = _trainJumpSampleGamePositionZ + _trainJumpSampleLength;
		_trainJumpSampleGamePositionZ = trainJumpSampleGamePositionZ;
		goto IL_0697;
	}

	public unsafe void MoveForward()
	{
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00db: Expected VT, but got Unknown
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Expected Obj, but got Unknown
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Expected Obj, but got Unknown
		//IL_0100: Expected Obj, but got I4
		//IL_0145: Expected I, but got Obj
		//IL_015b: Expected Obj, but got I
		//IL_018e: Expected F4, but got Obj
		//IL_0189: Expected native int or pointer, but got VT
		//IL_01a3: Expected F4, but got I
		//IL_019e: Expected native int or pointer, but got VT
		//IL_01e7: Expected F4, but got Obj
		//IL_01e2: Expected native int or pointer, but got VT
		//IL_01fc: Expected F4, but got I
		//IL_01f7: Expected native int or pointer, but got VT
		//IL_020b: Expected Ref, but got VT
		//IL_0082: Expected I, but got Obj
		object obj = default;
		Vector3 vector = (Vector3)(obj + 36);
		object obj2 = obj + 12;
		object obj3 = obj + 24;
		obj3 = 0;
		_ = 0;
		if (!_characterController.isTrigger)
		{
			return;
		}
		float unscaledTime = Time.unscaledTime;
		float num = gravity * unscaledTime;
		float num2 = verticalSpeed - num;
		verticalSpeed = num2;
		if (verticalSpeed > 0f)
		{
			verticalSpeed = 0f;
		}
		float unscaledTime2 = Time.unscaledTime;
		nint num3 = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ S0_v30 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num4 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ S0_v44 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Vector3 down = Vector3.down;
		((Vector3*)(nint)vector)->x = (float)obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11+8]");
		((Vector3*)(nint)vector)->z = 0f;
		float angle = verticalSpeed * unscaledTime2;
		Quaternion quaternion = Quaternion.AngleAxis(angle, vector);
		obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		((Vector3*)(nint)vector)->x = (float)obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13+8]");
		((Vector3*)(nint)vector)->z = 0f;
		CollisionFlags collisionFlags = _characterController.Move_Injected(ref *(Vector3*)vector);
		EndRoll();
	}

	public unsafe void CachePositions()
	{
		//IL_0bdd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0be2: Expected Obj, but got Unknown
		//IL_0beb: Expected Obj, but got I4
		//IL_0bfa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bff: Expected Obj, but got Unknown
		//IL_0c08: Expected Obj, but got I4
		//IL_0c17: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c1c: Expected Obj, but got Unknown
		//IL_0c25: Expected Obj, but got I4
		//IL_0c34: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c39: Expected Obj, but got Unknown
		//IL_0c42: Expected Obj, but got I4
		//IL_0c51: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c56: Expected Obj, but got Unknown
		//IL_0c5f: Expected Obj, but got I4
		//IL_0c74: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c79: Expected Obj, but got Unknown
		//IL_0c82: Expected Obj, but got I4
		//IL_0c91: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c96: Expected Obj, but got Unknown
		//IL_0c9f: Expected Obj, but got I4
		//IL_0cc6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ccb: Expected Obj, but got Unknown
		//IL_0cd4: Expected Obj, but got I4
		//IL_0cfb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d00: Expected Obj, but got Unknown
		//IL_0d06: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d0b: Expected Obj, but got Unknown
		//IL_0d43: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d48: Expected VT, but got Unknown
		//IL_0d55: Expected F4, but got Obj
		//IL_0d50: Expected native int or pointer, but got VT
		//IL_0d67: Expected F4, but got I
		//IL_0d62: Expected native int or pointer, but got VT
		//IL_0db0: Expected I, but got Obj
		//IL_0dc6: Expected Obj, but got I
		//IL_0dec: Unknown result type (might be due to invalid IL or missing references)
		//IL_0df1: Expected Obj, but got Unknown
		//IL_0dfa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dff: Expected Obj, but got Unknown
		//IL_0e08: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e0d: Expected Obj, but got Unknown
		//IL_0e16: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e1b: Expected Obj, but got Unknown
		//IL_026b: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_0f0f: Expected I, but got Obj
		//IL_0f25: Expected Obj, but got I
		//IL_0f71: Expected Obj, but got F4
		//IL_0f83: Expected I, but got F4
		//IL_0fa1: Expected VT, but got Obj
		//IL_027e: Expected I, but got Obj
		//IL_105f: Expected I, but got Obj
		//IL_1075: Expected Obj, but got I
		//IL_01c6: Expected I, but got Obj
		//IL_01dc: Expected Obj, but got I
		//IL_1110: Expected F4, but got Obj
		//IL_110b: Expected native int or pointer, but got VT
		//IL_1122: Expected F4, but got Obj
		//IL_111d: Expected native int or pointer, but got VT
		//IL_114c: Expected VT, but got Obj
		//IL_02c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c8: Expected Obj, but got Unknown
		//IL_0784: Unknown result type (might be due to invalid IL or missing references)
		//IL_0789: Expected Obj, but got Unknown
		//IL_07a6: Expected Obj, but got I
		//IL_07c9: Expected I, but got Obj
		//IL_07df: Expected Obj, but got I
		//IL_0675: Expected I, but got Obj
		//IL_0207: Expected I, but got Obj
		//IL_121c: Expected F4, but got Obj
		//IL_1217: Expected native int or pointer, but got VT
		//IL_122e: Expected F4, but got Obj
		//IL_1229: Expected native int or pointer, but got VT
		//IL_1258: Expected VT, but got Obj
		//IL_06d1: Expected Obj, but got I
		//IL_06f4: Expected I, but got Obj
		//IL_070a: Expected Obj, but got I
		//IL_02f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f8: Expected Obj, but got Unknown
		//IL_031a: Unknown result type (might be due to invalid IL or missing references)
		//IL_031f: Expected Obj, but got Unknown
		//IL_032c: Expected F4, but got Obj
		//IL_0327: Expected native int or pointer, but got VT
		//IL_0341: Expected F4, but got I
		//IL_033c: Expected native int or pointer, but got VT
		//IL_035e: Expected Obj, but got I
		//IL_0370: Invalid comparison between F4 and Obj
		//IL_025d: Expected Obj, but got I4
		//IL_080a: Expected I, but got Obj
		//IL_119a: Expected F4, but got Obj
		//IL_1195: Expected native int or pointer, but got VT
		//IL_11ac: Expected F4, but got Obj
		//IL_11a7: Expected native int or pointer, but got VT
		//IL_11d6: Expected VT, but got Obj
		//IL_024f: Expected Obj, but got I4
		//IL_0735: Expected I, but got Obj
		//IL_05e7: Expected I, but got Obj
		//IL_05fd: Expected Obj, but got I
		//IL_03a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a5: Expected Obj, but got Unknown
		//IL_03c8: Expected I, but got Obj
		//IL_03de: Expected Obj, but got I
		//IL_096e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0973: Expected Obj, but got Unknown
		//IL_0990: Expected Obj, but got I
		//IL_099e: Expected I, but got Obj
		//IL_09b4: Expected Obj, but got I
		//IL_0472: Expected F4, but got Obj
		//IL_046d: Expected native int or pointer, but got VT
		//IL_0487: Expected F4, but got I
		//IL_0482: Expected native int or pointer, but got VT
		//IL_04a4: Expected Obj, but got I
		//IL_0559: Expected I, but got Obj
		//IL_056f: Expected Obj, but got I
		//IL_1331: Expected Obj, but got I4
		//IL_134c: Expected F4, but got Obj
		//IL_1347: Expected native int or pointer, but got VT
		//IL_135e: Expected F4, but got Obj
		//IL_1359: Expected native int or pointer, but got VT
		//IL_139a: Expected VT, but got Obj
		//IL_0886: Unknown result type (might be due to invalid IL or missing references)
		//IL_088b: Expected Obj, but got Unknown
		//IL_08a8: Expected Obj, but got I
		//IL_08b6: Expected I, but got Obj
		//IL_08cc: Expected Obj, but got I
		//IL_0628: Expected I, but got Obj
		//IL_10c5: Expected VT, but got Obj
		//IL_0409: Expected I, but got Obj
		//IL_0138: Expected I, but got Obj
		//IL_014e: Expected Obj, but got I
		//IL_09df: Expected I, but got Obj
		//IL_12a1: Expected F4, but got Obj
		//IL_129c: Expected native int or pointer, but got VT
		//IL_12b3: Expected F4, but got Obj
		//IL_12ae: Expected native int or pointer, but got VT
		//IL_12e6: Expected VT, but got Obj
		//IL_059a: Expected I, but got Obj
		//IL_0e6a: Expected Obj, but got F4
		//IL_0e7c: Expected I, but got F4
		//IL_0e87: Expected Obj, but got F4
		//IL_0eb2: Expected VT, but got Obj
		//IL_13a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_13ae: Expected Obj, but got Unknown
		//IL_13cb: Expected Obj, but got I
		//IL_13d9: Expected I, but got Obj
		//IL_13ef: Expected Obj, but got I
		//IL_08f7: Expected I, but got Obj
		//IL_0179: Expected I, but got Obj
		//IL_14cd: Expected Obj, but got I4
		//IL_14e8: Expected F4, but got Obj
		//IL_14e3: Expected native int or pointer, but got VT
		//IL_14fa: Expected F4, but got Obj
		//IL_14f5: Expected native int or pointer, but got VT
		//IL_1536: Expected VT, but got Obj
		//IL_0a57: Invalid comparison between I and F4
		//IL_0aa5: Expected I, but got Obj
		//IL_0a92: Expected F4, but got I
		//IL_0b1d: Invalid comparison between I and F4
		//IL_0b54: Expected I, but got Obj
		//IL_0b6a: Expected Obj, but got I
		//IL_145f: Expected F4, but got I
		//IL_0b95: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 236;
		obj = 0;
		_ = 0;
		object obj3 = obj2 + 224;
		obj3 = 0;
		_ = 0;
		object obj4 = obj2 + 212;
		obj4 = 0;
		_ = 0;
		object obj5 = obj2 + 200;
		obj5 = 0;
		_ = 0;
		object obj6 = obj2 + 176;
		obj6 = 0;
		_ = 0;
		_ = 0;
		object obj7 = obj2 + 160;
		obj7 = 0;
		_ = 0;
		RaycastHit[] array = (RaycastHit[])(obj2 + 116);
		array = (RaycastHit[])0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		RaycastHit[] array2 = (RaycastHit[])(obj2 + 72);
		array2 = (RaycastHit[])0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		Collider collider = (Collider)(obj2 + 264);
		object obj8 = this + 236;
		collider = (Collider)obj8;
		Collider collider2 = collider;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ S1_v38+8]");
		((UnityEngine.Object)collider2).m_CachedPtr = (IntPtr)0;
		obj = collider;
		_ = ((UnityEngine.Object)collider).m_CachedPtr;
		Vector3 vector = (Vector3)(obj2 + 248);
		((Vector3*)(nint)vector)->x = (float)collider;
		((Vector3*)(nint)vector)->z = (nint)((UnityEngine.Object)collider).m_CachedPtr;
		Game game = _game;
		float unscaledTime = Time.unscaledTime;
		float num = game.__currentSpeed * unscaledTime;
		float num2 = vector.z + num;
		nint num3 = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ S0_v53 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj9 = (nint)0 & (nint)0x200;
		if (obj9 != null)
		{
			nint num4 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ S0_v350 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj10 = obj2 + 40;
		object obj11 = obj2 + 24;
		object obj12 = obj2 + 12;
		RouteBuilder routeBuilder = (RouteBuilder)(obj2 + 56);
		Vector3 one = Vector3.one;
		obj3 = routeBuilder;
		_ = routeBuilder.OnCompletedLayingSections;
		if (~(__isJumping ? 1u : 0u) == 0 && ~(_jumpUpperCollision ? 1u : 0u) == 0)
		{
			if (!_jumpUpperCollisionEvaded)
			{
				collider.get_bounds_Injected(out *(Bounds*)CharacterTrigger);
				obj6 = collider;
				_ = ((UnityEngine.Object)collider).m_CachedPtr;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ S0_v42 (UnityEngine.Collider)+10]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F4AD");
				if (_jumpUpperCollisionColliderMinY < vector.y)
				{
					if (!(verticalSpeed < 0f))
					{
						float unscaledTime2 = Time.unscaledTime;
						float unscaledTime3 = Time.unscaledTime;
						nint num5 = (nint)typeof(Vector3);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v396 @ S0_v336 (Il2CppClass<UnityEngine.Vector3>)+BA]");
						object obj13 = (nint)0 & (nint)0x200;
						if (obj13 != null)
						{
							nint num6 = (nint)typeof(Vector3);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v444 @ S0_v346 (Il2CppClass<UnityEngine.Vector3>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						Vector3 down = Vector3.down;
						collider = (Collider)vector.x;
						((UnityEngine.Object)collider).m_CachedPtr = (IntPtr)vector.z;
						object obj14 = 0f - gravity;
						float num7 = (float)obj14 * unscaledTime2;
						float angle = num7 * unscaledTime3;
						Quaternion quaternion = Quaternion.AngleAxis(angle, (Vector3)collider);
						obj3 = routeBuilder;
						_ = routeBuilder.OnCompletedLayingSections;
					}
					goto IL_1472;
				}
			}
			nint num8 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v225 @ S0_v309 (Il2CppClass<UnityEngine.Vector3>)+BA]");
			object obj15 = (nint)0 & (nint)0x200;
			if (obj15 != null)
			{
				nint num9 = (nint)typeof(Vector3);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v249 @ S0_v317 (Il2CppClass<UnityEngine.Vector3>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Vector3 one2 = Vector3.one;
			obj3 = collider;
			_ = ((UnityEngine.Object)collider).m_CachedPtr;
			_jumpUpperCollisionEvaded = true;
			goto IL_1472;
		}
		object obj16 = 1;
		goto IL_0ef8;
		IL_1472:
		if (verticalSpeed < 0f)
		{
			obj16 = 0;
			goto IL_0ef8;
		}
		object obj17 = 0;
		goto IL_0f42;
		IL_0f42:
		if (~(__isJumping ? 1u : 0u) == 0)
		{
			object obj18 = this + 532;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v356 @ S0_v212+10]");
			if ((nint)0 != 0)
			{
				object obj19 = this + 532;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8778");
				obj7 = collider;
				_ = ((UnityEngine.Object)collider).m_CachedPtr;
				object obj20 = this + 236;
				((Vector3*)(nint)vector)->x = (float)obj20;
				Vector3 vector2 = vector;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v462 @ S1_v230+8]");
				((Vector3*)(nint)vector2)->z = 0f;
				routeBuilder = (RouteBuilder)obj7;
				RouteBuilder routeBuilder2 = routeBuilder;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S0_v25+8]");
				routeBuilder2.OnCompletedLayingSections = (EventHandler)0;
				float z = vector.z;
				EventHandler onCompletedLayingSections = routeBuilder.OnCompletedLayingSections;
				if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)z) >= System.Runtime.CompilerServices.Unsafe.As<EventHandler, UIntPtr>(ref onCompletedLayingSections))
				{
					object obj21 = this + 532;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @39CF");
					verticalSpeed = 0f;
					nint num10 = (nint)typeof(Vector3);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v539 @ S0_v261 (Il2CppClass<UnityEngine.Vector3>)+BA]");
					object obj22 = (nint)0 & (nint)0x200;
					if (obj22 != null)
					{
						nint num11 = (nint)typeof(Vector3);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v576 @ S0_v268 (Il2CppClass<UnityEngine.Vector3>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					Vector3 one3 = Vector3.one;
					obj3 = collider;
					_ = ((UnityEngine.Object)collider).m_CachedPtr;
				}
				else if (obj17 != null)
				{
					((Vector3*)(nint)vector)->x = (float)obj7;
					Vector3 vector3 = vector;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S0_v25+8]");
					((Vector3*)(nint)vector3)->z = 0f;
					routeBuilder = (RouteBuilder)obj7;
					RouteBuilder routeBuilder3 = routeBuilder;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S0_v25+8]");
					routeBuilder3.OnCompletedLayingSections = (EventHandler)0;
					float num12 = num2 - vector.x;
					float num13 = num12;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ S0_v64 (SYBO.Subway.Routes.Builders.RouteBuilder)+4]");
					float defaultValue = num13 / 0f;
					float num14 = PlayerPrefs.GetFloat((string)(object)superSneakersJumpCurve, defaultValue);
					obj10 = obj7;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S0_v25+8]");
					_ = 0;
					obj11 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
					_ = 0;
					float num15 = num14 * jumpHeightSuperSneakers;
					float num16 = num15;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ S0_v58+C]");
					float num17 = num16 + 0f;
					float num18 = num17;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ S0_v60+4]");
					float num19 = num18 - 0f;
					nint num20 = (nint)typeof(Vector3);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v607 @ S0_v243 (Il2CppClass<UnityEngine.Vector3>)+BA]");
					object obj23 = (nint)0 & (nint)0x200;
					if (obj23 != null)
					{
						nint num21 = (nint)typeof(Vector3);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v648 @ S0_v253 (Il2CppClass<UnityEngine.Vector3>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					Vector3 down2 = Vector3.down;
					collider = (Collider)obj12;
					Collider collider3 = collider;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ S0_v62+8]");
					((UnityEngine.Object)collider3).m_CachedPtr = (IntPtr)0;
					Vector3 vector4 = (Vector3)collider / num19;
					obj3 = obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
					_ = 0;
				}
				else
				{
					nint num22 = (nint)typeof(Vector3);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v570 @ S0_v225 (Il2CppClass<UnityEngine.Vector3>)+BA]");
					object obj24 = (nint)0 & (nint)0x200;
					if (obj24 != null)
					{
						nint num23 = (nint)typeof(Vector3);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v612 @ S0_v232 (Il2CppClass<UnityEngine.Vector3>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					Vector3 one4 = Vector3.one;
					obj3 = collider;
					_ = ((UnityEngine.Object)collider).m_CachedPtr;
				}
			}
		}
		routeBuilder.HideLogic(x, num2);
		obj10 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
		_ = 0;
		obj11 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
		_ = 0;
		obj4 = obj10;
		_ = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ S0_v60+8]");
		_ = 0;
		obj12 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v15+8]");
		_ = 0;
		nint num24 = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v438 @ S0_v89 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj25 = (nint)0 & (nint)0x200;
		if (obj25 != null)
		{
			nint num25 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v479 @ S0_v205 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		((Vector3*)(nint)vector)->x = (float)routeBuilder;
		((Vector3*)(nint)vector)->z = (float)routeBuilder.OnCompletedLayingSections;
		collider = (Collider)obj12;
		Collider collider4 = collider;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ S0_v62+8]");
		((UnityEngine.Object)collider4).m_CachedPtr = (IntPtr)0;
		Quaternion quaternion2 = Quaternion.FromToRotation(vector, (Vector3)collider);
		obj5 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		if (_characterController.isTrigger)
		{
			routeBuilder = (RouteBuilder)obj3;
			RouteBuilder routeBuilder4 = routeBuilder;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v12+8]");
			routeBuilder4.OnCompletedLayingSections = (EventHandler)0;
			obj10 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S0_v18+8]");
			_ = 0;
			nint num26 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v635 @ S1_v206 (Il2CppClass<UnityEngine.Vector3>)+BA]");
			object obj26 = (nint)0 & (nint)0x200;
			if (obj26 != null)
			{
				nint num27 = (nint)typeof(Vector3);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v661 @ S1_v218 (Il2CppClass<UnityEngine.Vector3>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			((Vector3*)(nint)vector)->x = (float)routeBuilder;
			((Vector3*)(nint)vector)->z = (float)routeBuilder.OnCompletedLayingSections;
			collider = (Collider)obj10;
			Collider collider5 = collider;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ S0_v58+8]");
			((UnityEngine.Object)collider5).m_CachedPtr = (IntPtr)0;
			Vector3 vector5 = vector - (Vector3)collider;
			collider = (Collider)obj11;
			Collider collider6 = collider;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ S0_v60+8]");
			((UnityEngine.Object)collider6).m_CachedPtr = (IntPtr)0;
			CollisionFlags collisionFlags = _characterController.Move_Injected(ref *(Vector3*)collider);
		}
		else
		{
			GameObject gameObject = base.gameObject;
			object obj27 = this + 248;
			routeBuilder = (RouteBuilder)obj27;
			RouteBuilder routeBuilder5 = routeBuilder;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v688 @ S2_v31+8]");
			routeBuilder5.OnCompletedLayingSections = (EventHandler)0;
			obj10 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S0_v18+8]");
			_ = 0;
			nint num28 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v701 @ S1_v185 (Il2CppClass<UnityEngine.Vector3>)+BA]");
			object obj28 = (nint)0 & (nint)0x200;
			if (obj28 != null)
			{
				nint num29 = (nint)typeof(Vector3);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v724 @ S1_v197 (Il2CppClass<UnityEngine.Vector3>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			((Vector3*)(nint)vector)->x = (float)routeBuilder;
			((Vector3*)(nint)vector)->z = (float)routeBuilder.OnCompletedLayingSections;
			collider = (Collider)obj10;
			Collider collider7 = collider;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ S0_v58+8]");
			((UnityEngine.Object)collider7).m_CachedPtr = (IntPtr)0;
			Vector3 vector6 = vector - (Vector3)collider;
			collider = (Collider)obj11;
			Collider collider8 = collider;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ S0_v60+8]");
			((UnityEngine.Object)collider8).m_CachedPtr = (IntPtr)0;
			Vector3 localPosition = ((Transform)(object)collider).localPosition;
		}
		EndRoll();
		string text = ((PhysicsScene*)_characterController)->ToString();
		if (text != null)
		{
			object obj29 = this + 248;
			routeBuilder = (RouteBuilder)obj29;
			RouteBuilder routeBuilder6 = routeBuilder;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v779 @ S1_v159+8]");
			routeBuilder6.OnCompletedLayingSections = (EventHandler)0;
			nint num30 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v786 @ S0_v182 (Il2CppClass<UnityEngine.Vector3>)+BA]");
			object obj30 = (nint)0 & (nint)0x200;
			if (obj30 != null)
			{
				nint num31 = (nint)typeof(Vector3);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v808 @ S0_v196 (Il2CppClass<UnityEngine.Vector3>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Vector3 left = Vector3.left;
			((Vector3*)(nint)vector)->x = (float)routeBuilder;
			((Vector3*)(nint)vector)->z = (float)routeBuilder.OnCompletedLayingSections;
			collider = (Collider)obj10;
			Collider collider9 = collider;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ S0_v58+8]");
			((UnityEngine.Object)collider9).m_CachedPtr = (IntPtr)0;
			if (Physics.RaycastNonAlloc(vector, (Vector3)collider, array, 2f) != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F499");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ S0_v42 (UnityEngine.Collider)+4]");
				float lastGroundedY = 0f + _characterControllerSkinWidth;
				LastGroundedY = lastGroundedY;
			}
		}
		else
		{
			object obj31 = this + 248;
			routeBuilder = (RouteBuilder)obj31;
			RouteBuilder routeBuilder7 = routeBuilder;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v795 @ S1_v105+8]");
			routeBuilder7.OnCompletedLayingSections = (EventHandler)0;
			nint num32 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v802 @ S0_v114 (Il2CppClass<UnityEngine.Vector3>)+BA]");
			object obj32 = (nint)0 & (nint)0x200;
			if (obj32 != null)
			{
				nint num33 = (nint)typeof(Vector3);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v818 @ S0_v175 (Il2CppClass<UnityEngine.Vector3>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Vector3 left2 = Vector3.left;
			bool flag = ((MonoBehaviour)(object)"Ramp").IsInvoking();
			object obj33 = (flag ? 1 : 0) & 0x1F;
			int layerMask = 1 << (int)obj33;
			((Vector3*)(nint)vector)->x = (float)routeBuilder;
			((Vector3*)(nint)vector)->z = (float)routeBuilder.OnCompletedLayingSections;
			collider = (Collider)obj10;
			Collider collider10 = collider;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ S0_v58+8]");
			((UnityEngine.Object)collider10).m_CachedPtr = (IntPtr)0;
			if (Physics.RaycastNonAlloc(vector, (Vector3)collider, array2, 50f, layerMask, QueryTriggerInteraction.Ignore) != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F499");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ S0_v42 (UnityEngine.Collider)+4]");
				if (0f > LastGroundedY)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F499");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ S0_v42 (UnityEngine.Collider)+4]");
					LastGroundedY = 0f;
				}
			}
			object obj34 = this + 248;
			routeBuilder = (RouteBuilder)obj34;
			RouteBuilder routeBuilder8 = routeBuilder;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v949 @ S1_v126+8]");
			routeBuilder8.OnCompletedLayingSections = (EventHandler)0;
			nint num34 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v956 @ S0_v131 (Il2CppClass<UnityEngine.Vector3>)+BA]");
			object obj35 = (nint)0 & (nint)0x200;
			if (obj35 != null)
			{
				nint num35 = (nint)typeof(Vector3);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v965 @ S0_v165 (Il2CppClass<UnityEngine.Vector3>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Vector3 back = Vector3.back;
			bool flag2 = ((MonoBehaviour)(object)"Ramp").IsInvoking();
			object obj36 = (flag2 ? 1 : 0) & 0x1F;
			int layerMask2 = 1 << (int)obj36;
			((Vector3*)(nint)vector)->x = (float)routeBuilder;
			((Vector3*)(nint)vector)->z = (float)routeBuilder.OnCompletedLayingSections;
			collider = (Collider)obj10;
			Collider collider11 = collider;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ S0_v58+8]");
			((UnityEngine.Object)collider11).m_CachedPtr = (IntPtr)0;
			if (Physics.RaycastNonAlloc(vector, (Vector3)collider, array2, 50f, layerMask2, QueryTriggerInteraction.Ignore) != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F499");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ S0_v42 (UnityEngine.Collider)+4]");
				if (0f > LastGroundedY)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F499");
					nint num36 = (nint)typeof(Mathf);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1013 @ S0_v156 (Il2CppClass<UnityEngine.Mathf>)+BA]");
					object obj37 = (nint)0 & (nint)0x200;
					if (obj37 != null)
					{
						nint num37 = (nint)typeof(Mathf);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1018 @ S0_v161 (Il2CppClass<UnityEngine.Mathf>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ S0_v35 (UnityEngine.RaycastHit[])+1C]");
					float num38 = 0f / 50f;
					float num39 = 1f - num38;
					float t = num39 * 0.25f;
					float lastGroundedY2 = LastGroundedY;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ S0_v42 (UnityEngine.Collider)+4]");
					float lastGroundedY3 = Mathf.LerpUnclamped(lastGroundedY2, 0f, t);
					LastGroundedY = lastGroundedY3;
				}
			}
		}
		_movedSinceLastFixedUpdate = true;
		return;
		IL_0ef8:
		float unscaledTime4 = Time.unscaledTime;
		nint num40 = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v233 @ S0_v278 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj38 = (nint)0 & (nint)0x200;
		if (obj38 != null)
		{
			nint num41 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v259 @ S0_v288 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Vector3 down3 = Vector3.down;
		collider = (Collider)vector.x;
		((UnityEngine.Object)collider).m_CachedPtr = (IntPtr)vector.z;
		float angle2 = verticalSpeed * unscaledTime4;
		Quaternion quaternion3 = Quaternion.AngleAxis(angle2, (Vector3)collider);
		obj3 = routeBuilder;
		_ = routeBuilder.OnCompletedLayingSections;
		obj17 = obj16;
		goto IL_0f42;
	}

	public void EndRoll()
	{
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Expected Obj, but got Unknown
		//IL_00ad: Expected VT, but got Obj
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Expected Obj, but got Unknown
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Expected Obj, but got Unknown
		//IL_00fb: Expected I, but got Obj
		//IL_0111: Expected Obj, but got I
		//IL_014e: Expected VT, but got Obj
		//IL_014e: Expected Obj, but got I4
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		object obj = default;
		Transform transform = (Transform)(obj + 12);
		GameObject gameObject = base.gameObject;
		transform.position = (Vector3)gameObject;
		object obj2 = obj + 24;
		obj2 = transform;
		_ = ((UnityEngine.Object)transform).m_CachedPtr;
		object obj3 = this + 248;
		obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S0_v11+8]");
		_ = 0;
		nint num = (nint)typeof(GamePositionRoot);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S0_v17 (Il2CppClass<SYBO.Subway.Level.GamePositionRoot>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num2 = (nint)typeof(GamePositionRoot);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S0_v28 (Il2CppClass<SYBO.Subway.Level.GamePositionRoot>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool isRestricted = AgeRestriction.isRestricted;
		GameObject gameObject2 = base.gameObject;
		Vector3 gamePosition = ((GamePositionRoot)isRestricted).GetGamePosition((Vector3)gameObject2);
		obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		object obj5 = this + 236;
		obj5 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S0_v11+8]");
		_ = 0;
	}

	public float CalculateJumpVerticalSpeed(float jumpHeight)
	{
		bool flag = (nint)_glideVerticalSpeed == 2;
		float num = (((nint)CharacterTrigger != 1) ? 15f : 30f);
		bool flag2 = !flag;
		float result = num;
		if (!flag2)
		{
			float num2 = jumpHeight / 110f;
			if (_glideVerticalSpeed == null)
			{
				num2 = 1f;
			}
			float num3 = num2 * num;
			result = num3;
		}
		return result;
	}

	public float CalculateJumpVerticalSpeed()
	{
		return (float)__trackIndex * 20f;
	}

	public float JumpLength(float speed, float jumpHeight)
	{
		float num = speed / 110f;
		if (_glideVerticalSpeed == null)
		{
			num = 1f;
		}
		return num * jumpHeight;
	}

	public void StopStumble()
	{
		NotifyCriticalHit();
		_isRolling = false;
	}

	private IEnumerator ChangeTrackCoroutine(int move, float duration)
	{
		//IL_001f: Expected Obj, but got I4
		//IL_001f: Expected Obj, but got I
		//IL_004f: Expected Obj, but got I4
		//IL_0081: Expected Obj, but got I4
		float setPieceForgivingJumpTime = SetPieceForgivingJumpTime;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v9 @ S0_v5 (System.Single)+50]");
		if (((RouteManager._003C_003Ec__DisplayClass72_0)0)._003CGetRoutePrefab_003Eb__0((Route)move))
		{
			return null;
		}
		EnvironmentBaseKind environmentBaseKind = RouteChunk.EnvironentBaseToBaseKind((EnvironmentBase)move);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		float num = 0f + 170f;
		bool flag = num < duration;
		return (IEnumerator)flag;
	}

	private ObstacleType GetObstacleTypeFromTag(Collider obstacleCollider)
	{
		//IL_0176: Unknown result type (might be due to invalid IL or missing references)
		//IL_017b: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 4;
		if ((object)obstacleCollider != null)
		{
			if ((nint)obstacleCollider != 1)
			{
				if ((nint)obstacleCollider == 2)
				{
					return ObstacleType.MovingTrain;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
				obj = obstacleCollider;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
				throw new ArrayTypeMismatchException();
			}
			return ObstacleType.MinorObstacle;
		}
		return ObstacleType.Sides;
	}

	private ObstaclePassType GetPassTypeFromCollider(Collider obstacleCollider)
	{
		//IL_04a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a5: Expected Obj, but got Unknown
		//IL_03ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d3: Expected Obj, but got Unknown
		//IL_044b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0450: Expected Obj, but got Unknown
		//IL_0351: Unknown result type (might be due to invalid IL or missing references)
		//IL_0356: Expected Obj, but got Unknown
		//IL_027f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0284: Expected Obj, but got Unknown
		//IL_01da: Unknown result type (might be due to invalid IL or missing references)
		//IL_01df: Expected Obj, but got Unknown
		//IL_0108: Unknown result type (might be due to invalid IL or missing references)
		//IL_010d: Expected Obj, but got Unknown
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Expected Obj, but got Unknown
		//IL_02fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0301: Expected Obj, but got Unknown
		//IL_0185: Unknown result type (might be due to invalid IL or missing references)
		//IL_018a: Expected Obj, but got Unknown
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected Obj, but got Unknown
		object current = ((CustomYieldInstruction)(object)obstacleCollider).Current;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @C9E1");
		object obj = default;
		if ((nint)obj < 1732711451)
		{
			if ((nint)obj < 746443173)
			{
				if ((nint)obj < 746443172)
				{
					object obj2 = obj - 529772392;
					if (obj2 == null && (string)current != "HitTrain")
					{
						return ObstaclePassType.JumpHigh;
					}
				}
				else
				{
					object obj3 = obj - 746443172;
					if (obj3 == null && (string)current != "HitBlocker")
					{
						return (ObstaclePassType)13;
					}
				}
			}
			else if ((nint)obj < 1161371237)
			{
				object obj4 = obj - 838486338;
				if (obj4 == null && (string)current != "HitGates")
				{
					return (ObstaclePassType)11;
				}
			}
			else if ((nint)obj < 1732711450)
			{
				object obj5 = obj - 1161371237;
				if (obj5 == null && (string)current != "HitStationPlatform")
				{
					return (ObstaclePassType)12;
				}
			}
			else
			{
				object obj6 = obj - 1732711450;
				if (obj6 == null && (string)current != "HitPillar")
				{
					return (ObstaclePassType)10;
				}
			}
		}
		else if ((nint)obj < -654871997)
		{
			if ((nint)obj < -654871998)
			{
				object obj7 = obj - -672978903;
				if (obj7 == null && (string)current != "Stumble")
				{
					return ObstaclePassType.Jump;
				}
			}
			else if ((nint)obj < 1751097060)
			{
				object obj8 = obj - -654871998;
				if (obj8 == null && (string)current != "HitMovingTrain")
				{
					return (ObstaclePassType)4;
				}
			}
			else
			{
				object obj9 = obj - 1751097060;
				if (obj9 == null && (string)current != "HitBarrierStandard")
				{
					return (ObstaclePassType)6;
				}
			}
		}
		else if ((nint)obj < -284302887)
		{
			object obj10 = obj - -482664158;
			if (obj10 == null && (string)current != "HitBarrierRoll")
			{
				return (ObstaclePassType)9;
			}
		}
		else if ((nint)obj < -236442304)
		{
			object obj11 = obj - -284302887;
			if (obj11 == null && (string)current != "HitBarrierJump")
			{
				return (ObstaclePassType)7;
			}
		}
		else
		{
			object obj12 = obj - -236442304;
			if (obj12 == null && (string)current != "HitTrainRamp")
			{
				return (ObstaclePassType)5;
			}
		}
		return ObstaclePassType.None;
	}

	private void OnCharacterTriggerExit(Collider collider)
	{
		Game game = _game;
		if (this.m_OnTeleboardStart != null)
		{
			Game game2 = _game;
			_ = ((UnityEngine.Object)collider).m_CachedPtr;
			float num = 17f / game.__currentSpeed;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9920");
		}
	}

	private void OnCharacterTriggerEnter(Collider collider)
	{
		//IL_0014: Expected VT, but got Obj
		//IL_0040: Expected VT, but got Obj
		//IL_0101: Expected Obj, but got I4
		Component component = ((GameObject)(object)collider).GetComponent((Type)(object)"Subway");
		if ((object)component != null)
		{
			if (((HashSet<T>)(object)subwayColliders).Remove((T)collider))
			{
				bool flag = ((HashSet<T>)(object)subwayColliders).Add((T)collider);
				HashSet<Collider> hashSet = subwayColliders;
				bool isInsideSubway = hashSet._count > 0;
				_isInsideSubway = isInsideSubway;
			}
			return;
		}
		ImpactX obstacleImpactX = ((Character)null).GetObstacleImpactX(collider);
		if (obstacleImpactX == (ImpactX)_lastObstaclePassType && _lastObstaclePassTrackIndex == __trackIndex && this.m_OnPassedObstacle != null)
		{
			this.m_OnPassedObstacle.EndInvoke((IAsyncResult)obstacleImpactX);
		}
		if (obstacleImpactX == ImpactX.Middle && this.m_OnRollGuard != null)
		{
			this.m_OnRollGuard();
		}
	}

	private bool EnteredColliderFromBelow(Collider collider, bool jumpUpperCollisionRepeated)
	{
		//IL_01e8: Expected I, but got Obj
		//IL_01fe: Expected Obj, but got I
		//IL_0224: Expected Obj, but got I4
		//IL_005b: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_00b5: Expected Obj, but got I
		//IL_00d0: Expected Obj, but got I
		//IL_011c: Expected I, but got Obj
		//IL_0132: Expected Obj, but got I
		//IL_0251: Expected Obj, but got I4
		//IL_015d: Expected I, but got Obj
		//IL_01cb: Expected I4, but got Obj
		//IL_01a9: Expected Obj, but got I4
		int layer = ((GameObject)(object)_glideVerticalSpeed).layer;
		nint num = (nint)typeof(PoolManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S1_v5 (Il2CppClass<SYBO.Components.Utilities.PoolManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(PoolManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S1_v35 (Il2CppClass<SYBO.Components.Utilities.PoolManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		PrefabPool prefabPool = PoolManager.GetPrefabPool((Transform)layer);
		PlaceholderLifecycle component = ((Component)(object)prefabPool).GetComponent<PlaceholderLifecycle>();
		PickupType pickupType = ((PickupData)(object)component).PickupType;
		List<Component> themedComponents = ((SynchronizedThemeAsset)pickupType).ThemedComponents;
		if (themedComponents == null)
		{
			component.Despawn();
		}
		CollisionNotifier coinMagnetLongCollider = CoinMagnetLongCollider;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ S0_v18 (SYBO.Common.CollisionNotifier)+2C]");
		object obj2 = (nint)0 + (nint)1;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ S0_v18 (SYBO.Common.CollisionNotifier)+30]");
		object obj3 = (nint)0 + (nint)1;
		_0021_00210[] componentsInChildren = (_0021_00210[])(object)((Component)(object)prefabPool).GetComponentsInChildren<T>();
		((UnityEngine.Object)collider).m_CachedPtr = ((UnityEngine.Object)collider).m_CachedPtr;
		Vector3 localPosition = ((Transform)(object)collider).localPosition;
		nint num3 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ S0_v26 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num4 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ S0_v38 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)jumpUpperCollisionRepeated).FindKernel(null) != 0)
		{
			((Transform)(object)prefabPool).parentInternal = (Transform)jumpUpperCollisionRepeated;
		}
		((Coin)(object)componentsInChildren).TrackObject_OnActivate();
		((Coin)(object)componentsInChildren).Pickup((CharacterPickupParticles)null);
		return (byte)(int)componentsInChildren != 0;
	}

	private void HitByTrainSequence()
	{
		_followingGuard.MuteProximityLoop();
		_isStumbling = false;
	}

	private ImpactX GetObstacleImpactX(Collider collider)
	{
		object current = ((CustomYieldInstruction)(object)collider).Current;
		if ((string)current != "RollBarrier")
		{
			return ImpactX.Middle;
		}
		if ((string)current != "JumpBarrier")
		{
			return ImpactX.Right;
		}
		if ((string)current != "JumpHighBarrier")
		{
			return (ImpactX)3;
		}
		return ImpactX.Left;
	}

	private unsafe ImpactZ GetObstacleImpactZ(Collider collider)
	{
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_011d: Expected Obj, but got Unknown
		//IL_0126: Expected Obj, but got I4
		//IL_013b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0140: Expected Obj, but got Unknown
		//IL_0149: Expected Obj, but got I4
		//IL_015e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0163: Expected Obj, but got Unknown
		//IL_019a: Unknown result type (might be due to invalid IL or missing references)
		//IL_019f: Expected Obj, but got Unknown
		//IL_01d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d9: Expected Obj, but got Unknown
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected Obj, but got Unknown
		//IL_002b: Expected I, but got Obj
		//IL_0041: Expected Obj, but got I
		//IL_02ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cf: Expected Obj, but got Unknown
		//IL_02e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e7: Expected Obj, but got Unknown
		//IL_006c: Expected I, but got Obj
		//IL_022b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0230: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 144;
		obj = 0;
		_ = 0;
		_ = 0;
		object obj3 = obj2 + 120;
		obj3 = 0;
		_ = 0;
		_ = 0;
		Collider collider2 = (Collider)(obj2 + 96);
		collider2.get_bounds_Injected(out *(Bounds*)CharacterTrigger);
		obj = collider2;
		_ = ((UnityEngine.Object)collider2).m_CachedPtr;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S0_v17 (UnityEngine.Collider)+10]");
		_ = 0;
		Collider collider3 = (Collider)(obj2 + 72);
		collider3.get_bounds_Injected(out *(Bounds*)collider);
		obj3 = collider3;
		_ = ((UnityEngine.Object)collider3).m_CachedPtr;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ S0_v22 (UnityEngine.Collider)+10]");
		_ = 0;
		object obj4 = obj2 + 60;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F4AA");
		object obj5 = obj2 + 48;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F4AA");
		nint num = (nint)typeof(Mathf);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ S0_v35 (Il2CppClass<UnityEngine.Mathf>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num2 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ S0_v73 (Il2CppClass<UnityEngine.Mathf>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj4) > System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj5);
		bool flag2 = !flag;
		bool flag3 = !flag2;
		object obj7 = obj4;
		if (!flag3)
		{
			obj7 = obj5;
		}
		object obj8 = obj2 + 36;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F4AD");
		object obj9 = obj2 + 24;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F4AD");
		bool flag4 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj8) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj9);
		bool flag5 = !flag4;
		bool flag6 = !flag5;
		object obj10 = obj8;
		if (!flag6)
		{
			obj10 = obj9;
		}
		object obj11 = obj2 + 12;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F4AA");
		object obj12 = obj7 + obj10;
		float num3 = (float)obj12 * 0.5f;
		float num4 = num3 - (float)obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F4A3");
		double num5 = (double)ColliderTrackWidth * 0.33;
		double num6 = (double)obj2 - num5;
		if (num6 < (double)num4)
		{
			return ImpactZ.After;
		}
		double num7 = (double)ColliderTrackWidth * 0.33;
		bool flag7 = num7 > (double)num4;
		return (!flag7) ? ImpactZ.Middle : ImpactZ.Before;
	}

	private unsafe ImpactY GetCharacterImpactY(Collider collider)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0017: Expected Obj, but got I4
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected Obj, but got Unknown
		//IL_0034: Expected Obj, but got I4
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Expected Obj, but got Unknown
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Expected Obj, but got Unknown
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Expected Obj, but got Unknown
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Expected Obj, but got Unknown
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ee: Expected Obj, but got Unknown
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		//IL_010b: Expected Obj, but got Unknown
		//IL_0141: Expected Obj, but got I
		//IL_014a: Invalid comparison between Obj and F4
		//IL_01ab: Expected Obj, but got I
		//IL_0258: Invalid comparison between I and F4
		//IL_0213: Invalid comparison between I and F4
		object obj2 = default;
		object obj = obj2 + 112;
		obj = 0;
		_ = 0;
		object obj3 = obj2 + 88;
		obj3 = 0;
		_ = 0;
		_ = 0;
		object obj4 = obj2 + 72;
		object obj5 = this + 248;
		obj4 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S1_v11+8]");
		_ = 0;
		obj = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v12+8]");
		_ = 0;
		Collider collider2 = (Collider)(obj2 + 48);
		collider2.get_bounds_Injected(out *(Bounds*)collider);
		obj3 = collider2;
		_ = ((UnityEngine.Object)collider2).m_CachedPtr;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S0_v17 (UnityEngine.Collider)+10]");
		_ = 0;
		object obj6 = obj2 + 36;
		obj6 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v9 @ S0_v5+8]");
		_ = 0;
		object obj7 = obj2 + 24;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F4AD");
		object obj8 = obj2 + 12;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F4AD");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F4AA");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ S2_v6+8]");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		object obj9 = num - 0;
		float num2;
		if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj9) > System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)30f))
		{
			num2 = stumbleCornerTolerance;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F4AD");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F4AA");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v12+8]");
			object obj10 = -(nint)((UnityEngine.Object)collider2).m_CachedPtr;
			num2 = (float)obj10 * 0.5f;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ S1_v33+8]");
		float num3 = 0f - num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ S0_v22+8]");
		if (0f > num3)
		{
			return ImpactY.Lower;
		}
		obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v9 @ S0_v5+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F4AA");
		float num4 = (float)(nint)((UnityEngine.Object)collider2).m_CachedPtr + stumbleCornerTolerance;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v12+8]");
		bool flag = 0f < num4;
		return (!flag) ? ImpactY.Middle : ImpactY.Upper;
	}

	private void ExecuteKillSwitch()
	{
		Hoverboard hoverboard = _hoverboard;
		if (~(hoverboard.isActive ? 1u : 0u) == 0)
		{
			NotifyOnLanding();
		}
		else
		{
			NotifyOnTutorialStartFromCheckPoint();
		}
	}

	private bool AllowDoubleJump()
	{
		//IL_0020: Invalid comparison between I and F4
		Vector3 center = _characterController.center;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
		return 0f < 0f;
	}

	private bool IsRunningFromTrain()
	{
		if (IsGliderboard && ~(_willSecondJump ? 1u : 0u) == 0)
		{
			return true;
		}
		return false;
	}

	private bool IsRunningOnGround()
	{
		if (CurrentRunPosition__BackingField == RunPositions.train)
		{
			return true;
		}
		return CurrentRunPosition__BackingField == RunPositions.movingTrain;
	}

	private void ExpandColliders()
	{
		LastDeathCause = DeathCause.KillSwitch;
		_game.ResetEnemy();
	}

	private unsafe void StartStumble(bool safeStumble = false)
	{
		//IL_10e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_10eb: Expected Obj, but got Unknown
		//IL_10f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_10f9: Expected Obj, but got Unknown
		//IL_1102: Unknown result type (might be due to invalid IL or missing references)
		//IL_1107: Expected Obj, but got Unknown
		//IL_1110: Unknown result type (might be due to invalid IL or missing references)
		//IL_1115: Expected Obj, but got Unknown
		//IL_111e: Expected Obj, but got I4
		//IL_1133: Unknown result type (might be due to invalid IL or missing references)
		//IL_1138: Expected Obj, but got Unknown
		//IL_113e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1143: Expected Obj, but got Unknown
		//IL_116f: Expected F4, but got I
		//IL_0013: Expected Obj, but got I4
		//IL_004a: Expected Obj, but got I
		//IL_005a: Expected Obj, but got I
		//IL_006a: Expected Obj, but got I
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Expected Obj, but got Unknown
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Expected Obj, but got Unknown
		//IL_0150: Expected Obj, but got I4
		//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fe: Expected Obj, but got Unknown
		//IL_011e: Expected Obj, but got F4
		//IL_01d9: Expected Obj, but got I4
		//IL_01fd: Expected I, but got Obj
		//IL_0213: Expected Obj, but got I
		//IL_11ed: Expected Obj, but got I4
		//IL_11ff: Expected I, but got Obj
		//IL_1215: Expected Obj, but got I
		//IL_023e: Expected I, but got Obj
		//IL_0286: Expected Obj, but got I4
		//IL_0298: Expected I, but got Obj
		//IL_02ae: Expected Obj, but got I
		//IL_03c3: Expected Obj, but got I4
		//IL_0367: Expected I, but got Obj
		//IL_03b5: Expected I4, but got Obj
		//IL_02d9: Expected I, but got Obj
		//IL_1291: Expected Obj, but got I4
		//IL_12e4: Expected Obj, but got I4
		//IL_0419: Expected Obj, but got I4
		//IL_1416: Expected Obj, but got I4
		//IL_0478: Expected Obj, but got I4
		//IL_10a1: Expected Obj, but got I4
		//IL_04d0: Expected Obj, but got I4
		//IL_0608: Unknown result type (might be due to invalid IL or missing references)
		//IL_060d: Expected Obj, but got Unknown
		//IL_0616: Expected Obj, but got I4
		//IL_062c: Expected Obj, but got I4
		//IL_04f6: Expected Obj, but got I4
		//IL_064d: Expected Obj, but got I4
		//IL_0548: Expected Obj, but got I4
		//IL_0555: Expected Obj, but got I4
		//IL_06ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_06f4: Expected Obj, but got Unknown
		//IL_0711: Invalid comparison between Obj and F4
		//IL_0746: Invalid comparison between Obj and F4
		//IL_05ba: Expected Obj, but got I4
		//IL_05ba: Expected Obj, but got I4
		//IL_0739: Expected Obj, but got I4
		//IL_059a: Expected Obj, but got I4
		//IL_059a: Expected Obj, but got I4
		//IL_059a: Expected Obj, but got I4
		//IL_076e: Expected Obj, but got I4
		//IL_0808: Expected Obj, but got I4
		//IL_0810: Unknown result type (might be due to invalid IL or missing references)
		//IL_0815: Expected Obj, but got Unknown
		//IL_081d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0822: Expected Obj, but got Unknown
		//IL_0866: Expected Obj, but got I4
		//IL_1362: Unknown result type (might be due to invalid IL or missing references)
		//IL_1367: Expected Obj, but got Unknown
		//IL_09f7: Expected Obj, but got I4
		//IL_0a12: Expected Obj, but got I4
		//IL_0e12: Expected Obj, but got I4
		//IL_0ab9: Expected Obj, but got I4
		//IL_0bdf: Expected Obj, but got I4
		//IL_091c: Expected F4, but got I
		//IL_0adf: Expected Obj, but got I4
		//IL_0c10: Expected VT, but got I4
		//IL_0c1f: Expected VT, but got Obj
		//IL_0a25: Expected Obj, but got I4
		//IL_0a44: Expected Obj, but got I4
		//IL_0a44: Expected Obj, but got I4
		//IL_0de0: Expected Obj, but got I4
		//IL_0dff: Expected Obj, but got I4
		//IL_0dff: Expected Obj, but got I4
		//IL_0b37: Expected Obj, but got I4
		//IL_13f0: Expected Obj, but got I4
		//IL_0ec0: Expected Obj, but got I4
		//IL_0ee3: Expected Obj, but got I4
		//IL_0ee3: Expected Obj, but got I4
		//IL_0ee3: Expected Obj, but got I4
		//IL_0da2: Expected Obj, but got I
		//IL_0dbd: Expected Obj, but got I
		//IL_0c84: Expected Obj, but got I4
		//IL_0ca3: Expected Obj, but got I4
		//IL_0ca3: Expected Obj, but got I4
		//IL_0f59: Invalid comparison between F4 and I
		//IL_0b73: Expected VT, but got I4
		//IL_0b82: Expected VT, but got Obj
		//IL_1031: Expected Obj, but got I4
		//IL_1050: Expected Obj, but got I4
		//IL_1050: Expected Obj, but got I4
		//IL_0f91: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f96: Expected Obj, but got Unknown
		//IL_0f9e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fa3: Expected Obj, but got Unknown
		//IL_0ba8: Expected Obj, but got I4
		//IL_0bc7: Expected Obj, but got I4
		//IL_0bc7: Expected Obj, but got I4
		//IL_0ff3: Expected Obj, but got I
		//IL_100e: Expected Obj, but got I
		//IL_0cce: Expected Obj, but got I4
		//IL_0ced: Expected Obj, but got I4
		//IL_0ced: Expected Obj, but got I4
		object obj2 = default;
		object obj = obj2 + 48;
		Collider collider = (Collider)(obj2 + 24);
		object obj3 = obj2 + 12;
		object obj4 = obj2 + 88;
		obj4 = 0;
		_ = 0;
		_ = 0;
		Collider collider2 = (Collider)(obj2 - -64);
		object obj5 = this + 248;
		collider2 = (Collider)obj5;
		Collider collider3 = collider2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S1_v12+8]");
		((UnityEngine.Object)collider3).m_CachedPtr = (IntPtr)0;
		hitPoistionDistance = (nint)((UnityEngine.Object)collider2).m_CachedPtr;
		Game game = _game;
		Variable<bool> isInGame = game.IsInGame;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ S0_v26 (Variable`1<System.Boolean>)+8]");
		if ((nint)0 == 0)
		{
			return;
		}
		Component component = ((GameObject)safeStumble).GetComponent((Type)(object)"Subway");
		ImpactZ obstacleImpactZ;
		IEnumerator enumerator;
		ImpactY characterImpactY;
		bool flag2;
		if ((object)component != null)
		{
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v254 @ S2_v119 (Il2CppMethodInfo)+C]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v255 @ S2_v120+60]");
			object obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v256 @ S2_v121+38]");
			object obj8 = 0;
			object obj9 = obj8 & 0x1FFF;
			object obj10 = obj9 + 22691;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v142 @ S3_v41 (should have been resolved before IL gen)");
			HashSet<Collider> hashSet = subwayColliders;
			bool isInsideSubway = hashSet._count > 0;
			_isInsideSubway = isInsideSubway;
			collider2.get_bounds_Injected(out *(safeStumble ? ((Bounds*)1) : ((Bounds*)null)));
			obj4 = collider2;
			_ = ((UnityEngine.Object)collider2).m_CachedPtr;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S0_v19 (UnityEngine.Collider)+10]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F4AD");
			object obj11 = this - -64;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+4]");
			float num2 = 0f - 3f;
			obj11 = num2;
		}
		else
		{
			if (~(StopColliding ? 1u : 0u) == 0)
			{
				return;
			}
			string text = ((Component)safeStumble).tag;
			bool activeSelf = ((GameObject)(object)text).activeSelf;
			Layers layers = _layers;
			if ((activeSelf ? 1 : 0) == layers.Unremovable)
			{
				return;
			}
			Game game2 = _game;
			if (~(game2._isInStumbleDeathSequence ? 1u : 0u) == 0)
			{
				return;
			}
			string text2 = ((Component)safeStumble).tag;
			bool activeSelf2 = ((GameObject)(object)text2).activeSelf;
			nint num3 = (nint)typeof(Layers);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v308 @ S1_v29 (Il2CppClass<Layers>)+BA]");
			object obj12 = (nint)0 & (nint)0x200;
			if (obj12 != null)
			{
				nint num4 = (nint)typeof(Layers);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v314 @ S1_v249 (Il2CppClass<Layers>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool startupFinished = LoadLevelCtrl.StartupFinished;
			bool flag = activeSelf2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v322 @ S1_v34 (System.Boolean)+1C]");
			if ((nint)(flag ? 1 : 0) == 0)
			{
				PickupSpawnPoint component2 = ((Component)safeStumble).GetComponent<PickupSpawnPoint>();
				nint num5 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v353 @ S0_v255 (Il2CppClass<UnityEngine.Object>)+BA]");
				object obj13 = (nint)0 & (nint)0x200;
				if (obj13 != null)
				{
					nint num6 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v365 @ S0_v265 (Il2CppClass<UnityEngine.Object>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				if (((ComputeShader)(object)component2).FindKernel((string)null) != 0 && component2.__spawnPointState == SpawnPointState.Spawned)
				{
					((PickerCollection)(object)component2).OnPickerRemoveRequest += (Action<PickerRemoveRequestEventArgs>)(object)CharacterPickupParticleSystem;
				}
			}
			Coin component3 = ((Component)safeStumble).GetComponent<Coin>();
			nint num7 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v360 @ S0_v51 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj14 = (nint)0 & (nint)0x200;
			if (obj14 != null)
			{
				nint num8 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v373 @ S0_v248 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)(object)component3).FindKernel((string)null) != 0)
			{
				((CoinCurve)(object)component3).ToggleRenderers((byte)(int)CharacterPickupParticleSystem != 0);
			}
			string text3 = ((Component)safeStumble).tag;
			bool activeSelf3 = ((GameObject)(object)text3).activeSelf;
			Layers layers2 = _layers;
			if ((activeSelf3 ? 1 : 0) == layers2.Hit)
			{
				ObstaclePassType passTypeFromCollider = ((Character)null).GetPassTypeFromCollider((Collider)safeStumble);
				if (passTypeFromCollider != ObstaclePassType.None)
				{
					_lastObstacleType = (ObstacleType)passTypeFromCollider;
					Game game3 = _game;
					Game game4 = _game;
					game3.SpeedAtLastObstacleHit = game4.__currentSpeed;
				}
			}
			string text4 = ((Component)safeStumble).tag;
			bool activeSelf4 = ((GameObject)(object)text4).activeSelf;
			Layers layers3 = _layers;
			if ((activeSelf4 ? 1 : 0) != layers3.Default)
			{
				string text5 = ((Component)safeStumble).tag;
				bool activeSelf5 = ((GameObject)(object)text5).activeSelf;
				Layers layers4 = _layers;
				if ((activeSelf5 ? 1 : 0) != layers4.Ramp)
				{
					if (((CharacterController)safeStumble).isGrounded)
					{
						string text6 = ((Component)safeStumble).tag;
						bool activeSelf6 = ((GameObject)(object)text6).activeSelf;
						Layers layers5 = _layers;
						if ((activeSelf6 ? 1 : 0) == layers5.Hit)
						{
							Component component4 = ((GameObject)safeStumble).GetComponent((Type)(object)"Stumble");
							UnityEngine.Object cookie = UnityEngine.Object.Instantiate((UnityEngine.Object)safeStumble);
							if ((object)component4 != null)
							{
								((InAppManager)this).PurchaseRequestCallback((string)1, (string)2, (string)2, (string)(object)cookie, PurchaseResult.Completed, (IPurchaseValidationResult)null);
							}
							else
							{
								((InAppManager)this).PurchaseRequestCallback((string)null, (string)2, (string)1, (string)(object)cookie, PurchaseResult.Completed, (IPurchaseValidationResult)null);
							}
						}
						return;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @80D1");
					object obj15 = default;
					if (obj15 != null && DebugSettings.DontUseBaseBundleInEditor)
					{
						return;
					}
					object obj16 = this + 552;
					object current = ((CustomYieldInstruction)safeStumble).Current;
					obj16 = current;
					obstacleImpactZ = GetObstacleImpactZ((Collider)safeStumble);
					enumerator = ResetAfterRouteDelayed(safeStumble);
					characterImpactY = GetCharacterImpactY((Collider)safeStumble);
					collider2.get_bounds_Injected(out *(safeStumble ? ((Bounds*)1) : ((Bounds*)null)));
					obj4 = collider2;
					_ = ((UnityEngine.Object)collider2).m_CachedPtr;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S0_v19 (UnityEngine.Collider)+10]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F4AA");
					collider.get_bounds_Injected(out *(safeStumble ? ((Bounds*)1) : ((Bounds*)null)));
					obj4 = collider;
					_ = ((UnityEngine.Object)collider).m_CachedPtr;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11 (UnityEngine.Collider)+10]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F4AD");
					object obj17 = obj + obj3;
					float num9 = (float)obj17 * 0.5f;
					object obj18 = this + 248;
					obj2 = obj18;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v562 @ S1_v92+8]");
					_ = 0;
					object obj19;
					if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj2) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)num9))
					{
						obj19 = 1;
					}
					else
					{
						if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj2) <= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)num9))
						{
							flag2 = true;
							goto IL_1301;
						}
						obj19 = -1;
					}
					flag2 = _trackMovement == (nint)obj19;
					goto IL_1301;
				}
			}
			if (((CharacterController)safeStumble).isGrounded)
			{
				string text7 = ((PhysicsScene*)_characterController)->ToString();
				if (text7 != null)
				{
					throw new NullReferenceException();
				}
			}
			if (((CharacterController)safeStumble).isGrounded)
			{
				ImpactX obstacleImpactX = ((Character)null).GetObstacleImpactX((Collider)safeStumble);
				if (obstacleImpactX != ImpactX.Left)
				{
					_lastObstaclePassType = (ObstaclePassType)obstacleImpactX;
					_lastObstaclePassTrackIndex = __trackIndex;
				}
			}
		}
		return;
		IL_1301:
		collider2.get_bounds_Injected(out *(Bounds*)CharacterTrigger);
		obj4 = collider2;
		_ = ((UnityEngine.Object)collider2).m_CachedPtr;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S0_v19 (UnityEngine.Collider)+10]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F499");
		collider.get_bounds_Injected(out *(safeStumble ? ((Bounds*)1) : ((Bounds*)null)));
		obj4 = collider;
		_ = ((UnityEngine.Object)collider).m_CachedPtr;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11 (UnityEngine.Collider)+10]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F4AA");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
		nint num10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13+8]");
		bool flag3 = num10 < 0;
		bool flag4 = !flag3;
		bool flag5 = characterImpactY != ImpactY.Upper;
		object obj20 = (flag5 ? 1 : 0) ^ 1;
		object obj21 = flag4 & obj20;
		object obj22 = flag2 & obj21;
		bool jumpUpperCollision = _jumpUpperCollision;
		bool flag6 = enumerator == null;
		bool _isJumping = __isJumping;
		object obj23 = flag6 & _isJumping;
		if (obj23 != null)
		{
			string text8 = ((PhysicsScene*)_characterController)->ToString();
			if (text8 == null)
			{
				_jumpUpperCollision = true;
				_jumpUpperCollisionEvaded = false;
				verticalSpeed = 0f;
				if (!jumpUpperCollision)
				{
					collider2.get_bounds_Injected(out *(safeStumble ? ((Bounds*)1) : ((Bounds*)null)));
					obj4 = collider2;
					_ = ((UnityEngine.Object)collider2).m_CachedPtr;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S0_v19 (UnityEngine.Collider)+10]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F4AA");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+4]");
					_jumpUpperCollisionColliderMinY = 0f;
				}
			}
		}
		bool flag7 = characterImpactY == ImpactY.Middle;
		object obj24 = obj22 | flag7;
		if (obj24 != null)
		{
			if (_trackMovement != 0)
			{
				int movement = -_trackMovement;
				Game game5 = _game;
				float duration = ((~(game5.IsRunningOnTutorialTrack__BackingField ? 1u : 0u) != 0) ? 0.5f : 0.2f);
				ForceChangeTrack(movement, duration);
			}
			switch (obstacleImpactZ)
			{
			case ImpactZ.Before:
			{
				UnityEngine.Object cookie3 = UnityEngine.Object.Instantiate((UnityEngine.Object)safeStumble);
				((InAppManager)this).PurchaseRequestCallback((string)null, (string)null, (string)1, (string)(object)cookie3, PurchaseResult.Completed, (IPurchaseValidationResult)null);
				break;
			}
			case ImpactZ.After:
			{
				UnityEngine.Object cookie2 = UnityEngine.Object.Instantiate((UnityEngine.Object)safeStumble);
				((InAppManager)this).PurchaseRequestCallback((string)null, (string)4, (string)1, (string)(object)cookie2, PurchaseResult.Completed, (IPurchaseValidationResult)null);
				break;
			}
			}
		}
		else if (obstacleImpactZ != ImpactZ.Middle && _trackMovement != 0)
		{
			bool flag8 = characterImpactY == ImpactY.Upper;
			object obj25 = flag2 & flag8;
			if (obj25 != null)
			{
				string text9 = ((Component)safeStumble).tag;
				if (((MonoBehaviour)(object)text9).IsInvoking("HitMovingTrain"))
				{
					ExecuteKillSwitch();
					NotifyOnDoubleJump();
				}
				else
				{
					Component component5 = ((GameObject)safeStumble).GetComponent((Type)(object)"HitTrainRamp");
					if ((object)component5 == null)
					{
						Vector3 toPos = (Vector3)(-_trackMovement);
						GizmoUtility.DrawArrow((Vector3)this, toPos, 0.5f);
					}
					else if (!IsDoubleJumping)
					{
						UnityEngine.Object cookie4 = UnityEngine.Object.Instantiate((UnityEngine.Object)safeStumble);
						((InAppManager)this).PurchaseRequestCallback((string)null, (string)2, (string)2, (string)(object)cookie4, PurchaseResult.Completed, (IPurchaseValidationResult)null);
					}
				}
			}
			else
			{
				Component component6 = ((GameObject)safeStumble).GetComponent((Type)(object)"HitTrainRamp");
				if ((object)component6 != null)
				{
					Vector3 toPos2 = (Vector3)(-_trackMovement);
					GizmoUtility.DrawArrow((Vector3)this, toPos2, 0.5f);
				}
			}
			switch (obstacleImpactZ)
			{
			case ImpactZ.Before:
				if (!IsDoubleJumping)
				{
					UnityEngine.Object cookie6 = UnityEngine.Object.Instantiate((UnityEngine.Object)safeStumble);
					((InAppManager)this).PurchaseRequestCallback((string)null, (string)1, (string)1, (string)(object)cookie6, PurchaseResult.Completed, (IPurchaseValidationResult)null);
				}
				break;
			case ImpactZ.After:
				if (!IsDoubleJumping)
				{
					UnityEngine.Object cookie5 = UnityEngine.Object.Instantiate((UnityEngine.Object)safeStumble);
					((InAppManager)this).PurchaseRequestCallback((string)null, (string)3, (string)1, (string)(object)cookie5, PurchaseResult.Completed, (IPurchaseValidationResult)null);
				}
				break;
			}
		}
		else
		{
			if (flag5)
			{
				return;
			}
			if ((nint)enumerator == 2)
			{
				if (IsVTol)
				{
					float fOVForAspectRatio = ((CharacterCamera)this).GetFOVForAspectRatio(1.5f);
					verticalSpeed = fOVForAspectRatio;
				}
				else
				{
					float fOVForAspectRatio2 = ((CharacterCamera)this).GetFOVForAspectRatio(8f);
					verticalSpeed = fOVForAspectRatio2;
				}
				if (IsDoubleJumping)
				{
					string privacyPolicyUrl = Globals.GetPrivacyPolicyUrl();
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v827 @ S0_v180 (System.String)+A0]");
					object obj26 = (nint)0 + (nint)1;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v827 @ S0_v180 (System.String)+A4]");
					object obj27 = (nint)0 + (nint)1;
					this.m_OnResetTeleportFX();
				}
				else
				{
					UnityEngine.Object cookie7 = UnityEngine.Object.Instantiate((UnityEngine.Object)safeStumble);
					((InAppManager)this).PurchaseRequestCallback((string)null, (string)2, (string)2, (string)(object)cookie7, PurchaseResult.Completed, (IPurchaseValidationResult)null);
				}
				return;
			}
			string text10 = ((Component)safeStumble).tag;
			if (((MonoBehaviour)(object)text10).IsInvoking("HitMovingTrain"))
			{
				ExecuteKillSwitch();
				NotifyOnDoubleJump();
				return;
			}
			if ((nint)enumerator == 1)
			{
				if (IsDoubleJumping)
				{
					this.m_OnResetTeleportFX();
				}
				else
				{
					UnityEngine.Object cookie8 = UnityEngine.Object.Instantiate((UnityEngine.Object)safeStumble);
					((InAppManager)this).PurchaseRequestCallback((string)null, (string)2, (string)1, (string)(object)cookie8, PurchaseResult.Completed, (IPurchaseValidationResult)1);
				}
				NotifyOnDoubleJump();
				return;
			}
			bool flag9;
			if (jumpUpperCollision)
			{
				collider2.get_bounds_Injected(out *(safeStumble ? ((Bounds*)1) : ((Bounds*)null)));
				obj4 = collider2;
				_ = ((UnityEngine.Object)collider2).m_CachedPtr;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S0_v19 (UnityEngine.Collider)+10]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F4AA");
				float jumpUpperCollisionColliderMinY = _jumpUpperCollisionColliderMinY;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+4]");
				flag9 = !(jumpUpperCollisionColliderMinY > 0f);
			}
			else
			{
				flag9 = false;
			}
			IEnumerator enumerator2 = ((CharacterFXController)this).DespawnJumpRollEffect((Transform)safeStumble, (Character)null);
			if (~(__isJumping ? 1u : 0u) == 0)
			{
				bool jumpUpperCollision2 = _jumpUpperCollision;
				object obj28 = enumerator2 & jumpUpperCollision2;
				object obj29 = flag9 | obj28;
				if (obj29 != null)
				{
					return;
				}
			}
			if (IsDoubleJumping)
			{
				string privacyPolicyUrl2 = Globals.GetPrivacyPolicyUrl();
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v908 @ S0_v153 (System.String)+A0]");
				object obj30 = (nint)0 + (nint)1;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v908 @ S0_v153 (System.String)+A4]");
				object obj31 = (nint)0 + (nint)1;
				this.m_OnResetTeleportFX();
			}
			else
			{
				UnityEngine.Object cookie9 = UnityEngine.Object.Instantiate((UnityEngine.Object)safeStumble);
				((InAppManager)this).PurchaseRequestCallback((string)null, (string)2, (string)null, (string)(object)cookie9, PurchaseResult.Completed, (IPurchaseValidationResult)1);
			}
			NotifyOnDoubleJump();
		}
	}

	private IEnumerator StumbleDecay()
	{
		//IL_0016: Expected Obj, but got I4
		bool flag = CurrentRunPosition__BackingField == RunPositions.ground;
		return (IEnumerator)flag;
	}

	public void RequestStumble(StumbleType stumbleType, StumbleHorizontalHit horizontalHit, StumbleVerticalHit verticalHit, string colliderName)
	{
		((PickupManager)this).ResetPickupLastSpawnPositions(PickupManager.ReasonToResetHistory.RUN_STARTED);
	}

	public void RequestSafeStumble(StumbleType stumbleType, StumbleHorizontalHit horizontalHit, StumbleVerticalHit verticalHit, string colliderName)
	{
		//IL_001c: Expected Obj, but got I4
		//IL_001c: Expected Obj, but got I4
		//IL_001c: Expected Obj, but got I4
		((InAppManager)this).PurchaseRequestCallback((string)stumbleType, (string)horizontalHit, (string)verticalHit, colliderName, PurchaseResult.Completed, (IPurchaseValidationResult)null);
	}

	private unsafe void HandleStumble(StumbleType stumbleType, StumbleHorizontalHit horizontalHit, StumbleVerticalHit verticalHit, string colliderName, bool safeStumble = false, bool isCriticalHit = false)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_03bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c4: Expected Obj, but got Unknown
		//IL_03d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03dd: Expected Obj, but got Unknown
		//IL_03e5: Expected Obj, but got I4
		//IL_03eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f0: Expected Obj, but got Unknown
		//IL_03f8: Expected Obj, but got I4
		//IL_03fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0403: Expected Obj, but got Unknown
		//IL_040b: Expected Obj, but got I4
		//IL_0411: Unknown result type (might be due to invalid IL or missing references)
		//IL_0416: Expected Obj, but got Unknown
		//IL_041f: Expected VT, but got Obj
		//IL_0427: Expected Obj, but got VT
		//IL_0435: Expected I, but got Obj
		//IL_044b: Expected Obj, but got I
		//IL_046e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0473: Expected Obj, but got Unknown
		//IL_0080: Expected Obj, but got I4
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Expected Obj, but got Unknown
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Expected Obj, but got Unknown
		//IL_00e2: Expected F4, but got I4
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Expected Obj, but got Unknown
		//IL_0021: Expected I, but got Obj
		//IL_0126: Unknown result type (might be due to invalid IL or missing references)
		//IL_012b: Expected Obj, but got Unknown
		//IL_013b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0140: Expected Obj, but got Unknown
		//IL_015e: Expected Obj, but got I
		//IL_016e: Expected Obj, but got I
		//IL_017e: Expected Obj, but got I
		//IL_0187: Unknown result type (might be due to invalid IL or missing references)
		//IL_018c: Expected Obj, but got Unknown
		//IL_0195: Unknown result type (might be due to invalid IL or missing references)
		//IL_019a: Expected Obj, but got Unknown
		//IL_04a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a8: Expected Obj, but got Unknown
		//IL_04b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b6: Expected Obj, but got Unknown
		//IL_04e2: Expected Obj, but got I4
		//IL_051e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0523: Expected Obj, but got Unknown
		//IL_052c: Expected Obj, but got I4
		//IL_02ac: Expected Obj, but got I
		//IL_0381: Unknown result type (might be due to invalid IL or missing references)
		//IL_0386: Expected Obj, but got Unknown
		//IL_02e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e7: Expected Obj, but got Unknown
		//IL_0318: Unknown result type (might be due to invalid IL or missing references)
		//IL_031d: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 48;
		object obj3 = obj2 + 16;
		obj3 = obj;
		_ = -1;
		object obj4 = this + 68;
		obj4 = horizontalHit;
		object obj5 = this + 212;
		obj5 = isCriticalHit;
		object obj6 = this + 140;
		obj6 = stumbleType;
		object obj7 = this + 160;
		_00210 val = (_00210)SingletonMonoBehaviour<>.Instantiate();
		obj7 = val;
		nint num = (nint)typeof(ThemeManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ S0_v23 (Il2CppClass<SYBO.Subway.Themes.ThemeManager>)+BA]");
		object obj8 = (nint)0 & (nint)0x200;
		if (obj8 != null)
		{
			nint num2 = (nint)typeof(ThemeManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ S0_v125 (Il2CppClass<SYBO.Subway.Themes.ThemeManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj9 = this + 164;
		GameStateMachine instance = GameStateMachine.Instance;
		obj9 = instance;
		((RouteBuilder)(object)this).StopBuilding();
		((WeightRandomizedPrefabContainter<, >)(object)HoverboardCrashParticleSystem)._002Ector();
		verticalSpeed = 0f;
		_squeezeCollider = null;
		object obj10 = horizontalHit + 60;
		obj2 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ S1_v27+8]");
		_ = 0;
		object obj11 = obj2 + 24;
		obj11 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		object obj12 = this + 168;
		obj12 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ S0_v37+8]");
		_ = 0;
		LastGroundedY = (float)verticalHit;
		object obj13 = this - -64;
		obj13 = colliderName;
		((RouteBuilder)(object)this).AddNextSection();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		NullReferenceException ex = new NullReferenceException();
		object obj15 = default;
		object obj14 = obj15 + 16;
		obj14 = this;
		object obj16 = HoverboardCrashParticleSystem + 20;
		obj16 = obj15;
		nint num3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ S1_v61 (Il2CppMethodInfo)+C]");
		object obj17 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ S1_v62+60]");
		object obj18 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v151 @ S1_v63+C]");
		object obj19 = 0;
		object obj20 = obj19 & 0x3FFF;
		object obj21 = obj20 + 6161;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v159 @ S2_v11 (should have been resolved before IL gen)");
		object obj22 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
			if (obj22 == null)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			_ = 0;
			_ = 0;
		}
		object obj23 = obj3 + 4;
		object obj24 = obj23 + 1;
		obj23 = obj24;
		object obj25 = obj24 << 2;
		object obj26 = obj3 + obj25;
		obj26 = 181;
		object obj27 = default;
		if (obj27 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @741D");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v12+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v12+4]");
			object obj28 = (nint)0 << 2;
			object obj29 = obj3 + obj28;
			if ((nint)obj29 == 181)
			{
				object obj30 = obj3 + 4;
				if ((nint)obj30 > -1)
				{
					object obj31 = obj30 + -1;
					obj30 = obj31;
				}
				goto IL_0518;
			}
		}
		object obj32 = default;
		if (obj32 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		goto IL_0518;
		IL_0518:
		object obj33 = this + 128;
		obj33 = 0;
		IsGrounded = null;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @726B");
		RouteBuildProgress progressState = default;
		int progressStateSectionCount = ((RouteBuilder)(object)this).GetProgressStateSectionCount(progressState);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr = 0;
		Delegate obj34 = default;
		obj34.method_ptr = method_ptr;
		obj34.method = (nint)__ldftn(RouteBuilder.RouteChunk_OnEnvironmentSegmentSpawned);
		object obj35 = obj34 + 16;
		obj35 = this;
		Delegate obj36 = ((Delegate)RouteChunk.OnEnvironmentSegmentSpawned).CombineImpl(obj34);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
		Action<EnvironmentKind, int, Route> onEnvironmentSegmentSpawned = default;
		RouteChunk.OnEnvironmentSegmentSpawned = onEnvironmentSegmentSpawned;
	}

	private IEnumerator LaneSwitchJump(Vector3 gamePositionStart, Vector3 gamePositionEnd, float jumpHeight, float jumpsPerLaneSwitch)
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected Obj, but got Unknown
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected Obj, but got Unknown
		//IL_003e: Expected Obj, but got VT
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Expected Obj, but got Unknown
		//IL_0054: Expected Obj, but got VT
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		_ = 0;
		IEnumerator enumerator = default;
		object obj = enumerator + 32;
		obj = this;
		object obj2 = enumerator + 16;
		obj2 = gamePositionStart;
		object obj3 = enumerator + 28;
		obj3 = gamePositionEnd;
		return enumerator;
	}

	private unsafe void NotifyCriticalHit()
	{
		//IL_016a: Unknown result type (might be due to invalid IL or missing references)
		//IL_016f: Expected VT, but got Unknown
		//IL_0178: Unknown result type (might be due to invalid IL or missing references)
		//IL_017d: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_01bb: Expected F4, but got Obj
		//IL_01b6: Expected native int or pointer, but got VT
		//IL_01d0: Expected F4, but got I
		//IL_01cb: Expected native int or pointer, but got VT
		//IL_01ef: Expected F4, but got Obj
		//IL_01ea: Expected native int or pointer, but got VT
		//IL_0204: Expected F4, but got I
		//IL_01ff: Expected native int or pointer, but got VT
		//IL_0213: Expected Ref, but got VT
		//IL_00da: Expected I, but got Obj
		//IL_00f0: Expected Obj, but got I
		//IL_0054: Expected I, but got Obj
		//IL_0232: Expected F4, but got Obj
		//IL_022d: Expected native int or pointer, but got VT
		//IL_0247: Expected F4, but got I
		//IL_0242: Expected native int or pointer, but got VT
		//IL_0266: Expected F4, but got Obj
		//IL_0261: Expected native int or pointer, but got VT
		//IL_027b: Expected F4, but got I
		//IL_0276: Expected native int or pointer, but got VT
		//IL_028a: Expected Ref, but got VT
		//IL_011b: Expected I, but got Obj
		object obj = default;
		Vector3 vector = (Vector3)(obj + 24);
		object obj2 = obj + 12;
		if (_characterController.isTrigger)
		{
			nint num = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S1_v28 (Il2CppClass<UnityEngine.Vector3>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num2 = (nint)typeof(Vector3);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S1_v39 (Il2CppClass<UnityEngine.Vector3>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Vector3 down = Vector3.down;
			((Vector3*)(nint)vector)->x = (float)obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11+8]");
			((Vector3*)(nint)vector)->z = 0f;
			Vector3 vector2 = vector / 2f;
			((Vector3*)(nint)vector)->x = (float)obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			((Vector3*)(nint)vector)->z = 0f;
			CollisionFlags collisionFlags = _characterController.Move_Injected(ref *(Vector3*)vector);
		}
		((MeFooterNavigation)(object)_squeezeCollider).OnClickButton((Transform)(object)this);
		if (_characterController.isTrigger)
		{
			nint num3 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ S1_v12 (Il2CppClass<UnityEngine.Vector3>)+BA]");
			object obj4 = (nint)0 & (nint)0x200;
			if (obj4 != null)
			{
				nint num4 = (nint)typeof(Vector3);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ S1_v23 (Il2CppClass<UnityEngine.Vector3>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Vector3 left = Vector3.left;
			((Vector3*)(nint)vector)->x = (float)obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11+8]");
			((Vector3*)(nint)vector)->z = 0f;
			Vector3 vector3 = vector / 2f;
			((Vector3*)(nint)vector)->x = (float)obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			((Vector3*)(nint)vector)->z = 0f;
			CollisionFlags collisionFlags2 = _characterController.Move_Injected(ref *(Vector3*)vector);
		}
		EndRoll();
	}

	private void NotifyOnStumble(StumbleType stumbleType, StumbleHorizontalHit horizontalHit, StumbleVerticalHit verticalHit, string colliderName, bool safeStumble)
	{
		//IL_071a: Unknown result type (might be due to invalid IL or missing references)
		//IL_071f: Expected Obj, but got Unknown
		//IL_0728: Unknown result type (might be due to invalid IL or missing references)
		//IL_072d: Expected Obj, but got Unknown
		//IL_073b: Expected Obj, but got I4
		//IL_0223: Expected I, but got Obj
		//IL_0239: Expected Obj, but got I
		//IL_07bb: Expected Obj, but got I4
		//IL_0013: Expected Obj, but got I4
		//IL_02be: Expected I, but got Obj
		//IL_02d4: Expected Obj, but got I
		//IL_0264: Expected I, but got Obj
		//IL_07e5: Expected Obj, but got I4
		//IL_003e: Expected I, but got Obj
		//IL_0054: Expected Obj, but got I
		//IL_03ab: Expected Obj, but got I4
		//IL_03ab: Expected Obj, but got I4
		//IL_03b9: Expected I, but got Obj
		//IL_03cf: Expected Obj, but got I
		//IL_02ff: Expected I, but got Obj
		//IL_0762: Expected Obj, but got I4
		//IL_0847: Expected I, but got Obj
		//IL_085d: Expected Obj, but got I
		//IL_034b: Expected Obj, but got I4
		//IL_034b: Expected Obj, but got I4
		//IL_0354: Expected Obj, but got I4
		//IL_0363: Expected Obj, but got F4
		//IL_007f: Expected I, but got Obj
		//IL_03fa: Expected I, but got Obj
		//IL_00cc: Expected I, but got Obj
		//IL_00e2: Expected Obj, but got I
		//IL_0447: Expected I, but got Obj
		//IL_057d: Expected Obj, but got I4
		//IL_0593: Expected Obj, but got I
		//IL_05a3: Expected Obj, but got I
		//IL_05b3: Expected Obj, but got I
		//IL_05bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c1: Expected Obj, but got Unknown
		//IL_05ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_05cf: Expected Obj, but got Unknown
		//IL_0493: Expected Obj, but got I4
		//IL_049c: Expected Obj, but got I4
		//IL_04ab: Expected Obj, but got F4
		//IL_010d: Expected I, but got Obj
		//IL_05f5: Expected Obj, but got I4
		//IL_0603: Expected I, but got Obj
		//IL_0619: Expected Obj, but got I
		//IL_08d9: Expected VT, but got Obj
		//IL_0546: Expected Obj, but got I4
		//IL_0691: Expected I, but got Obj
		//IL_06a7: Expected Obj, but got I
		//IL_0644: Expected I, but got Obj
		//IL_0915: Expected Obj, but got I4
		//IL_06d2: Expected I, but got Obj
		object obj = default;
		Transform transform = (Transform)(obj + 24);
		object obj2 = obj + 12;
		object obj3 = stumbleType + 8;
		if ((nint)obj3 != 3)
		{
			object obj4 = stumbleType + 8;
			if ((nint)obj4 != 4)
			{
				nint num = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v135 (Il2CppClass<UnityEngine.Object>)+BA]");
				object obj5 = (nint)0 & (nint)0x200;
				if (obj5 != null)
				{
					nint num2 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ S0_v174 (Il2CppClass<UnityEngine.Object>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				if (!((UnityEngine.Object)horizontalHit != null))
				{
					nint num3 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ S0_v163 (Il2CppClass<UnityEngine.Object>)+BA]");
					object obj6 = (nint)0 & (nint)0x200;
					if (obj6 != null)
					{
						nint num4 = (nint)typeof(UnityEngine.Object);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ S0_v170 (Il2CppClass<UnityEngine.Object>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					if (!((UnityEngine.Object)(object)colliderName != null))
					{
						goto IL_0215;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
				throw new ArrayTypeMismatchException();
			}
		}
		goto IL_0215;
		IL_0215:
		nint num5 = (nint)typeof(EnvironmentBaseInfo);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S0_v20 (Il2CppClass<SYBO.Subway.Level.EnvironmentBaseInfo>)+BA]");
		object obj7 = (nint)0 & (nint)0x200;
		if (obj7 != null)
		{
			nint num6 = (nint)typeof(EnvironmentBaseInfo);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v126 (Il2CppClass<SYBO.Subway.Level.EnvironmentBaseInfo>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		int midPieceLength = ((EnvironmentInfo)stumbleType).MidPieceLength;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		GameObject gameObject = default;
		gameObject.layer = midPieceLength;
		int layer = gameObject.layer;
		nint num7 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ S0_v32 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj8 = (nint)0 & (nint)0x200;
		if (obj8 != null)
		{
			nint num8 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v140 @ S0_v122 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)horizontalHit).FindKernel(null) != 0)
		{
			((Transform)horizontalHit).parentInternal = (Transform)layer;
			obj2 = 0;
			_ = 0;
			obj2 = -20f;
			_ = 0f;
			_ = 0f;
			transform = (Transform)obj2;
			Transform transform2 = transform;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11+8]");
			((UnityEngine.Object)transform2).m_CachedPtr = (IntPtr)0;
			Vector3 eulerAngles = transform.eulerAngles;
		}
		((Transform)verticalHit).parentInternal = (Transform)layer;
		nint num9 = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v206 @ S0_v41 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj9 = (nint)0 & (nint)0x200;
		if (obj9 != null)
		{
			nint num10 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v220 @ S0_v109 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Vector3 one = Vector3.one;
		transform = (Transform)obj2;
		Transform transform3 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11+8]");
		((UnityEngine.Object)transform3).m_CachedPtr = (IntPtr)0;
		Vector3 eulerAngles2 = transform.eulerAngles;
		nint num11 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v243 @ S0_v50 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj10 = (nint)0 & (nint)0x200;
		if (obj10 != null)
		{
			nint num12 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v288 @ S0_v105 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)colliderName).FindKernel((string)null) != 0)
		{
			((Transform)(object)colliderName).parentInternal = (Transform)layer;
			obj2 = 0;
			_ = 0;
			obj2 = 20f;
			_ = 0f;
			_ = 0f;
			transform = (Transform)obj2;
			Transform transform4 = transform;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11+8]");
			((UnityEngine.Object)transform4).m_CachedPtr = (IntPtr)0;
			Vector3 eulerAngles3 = transform.eulerAngles;
		}
		StateMachine.Trigger orAddTrigger = ((StateMachine)(object)gameObject).GetOrAddTrigger(1);
		if (orAddTrigger != null)
		{
			_0021_00210[] componentsInChildrenBFS = (_0021_00210[])(object)SYBO.Common.Utilities.GameObjectUtil.GetComponentsInChildrenBFS<T>(gameObject);
			_0021_00210[] componentsInChildrenBFS2 = (_0021_00210[])(object)SYBO.Common.Utilities.GameObjectUtil.GetComponentsInChildrenBFS<T>(gameObject);
			((MeshFilter)(object)componentsInChildrenBFS).mesh = (Mesh)orAddTrigger.Id;
			Mesh mesh = ((MeshFilter)(object)componentsInChildrenBFS).mesh;
			UnityEngine.Object.DestroyImmediate(mesh, (byte)midPieceLength != 0);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @FA1F");
		}
		((Transform)layer).SetAsFirstSibling();
		nint num13 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v357 @ S4_v3 (Il2CppMethodInfo)+C]");
		object obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v358 @ S4_v4+60]");
		object obj12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v359 @ S4_v5+48]");
		object obj13 = 0;
		object obj14 = obj13 & 0x7FF;
		object obj15 = obj14 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v253 @ S5_v5 (should have been resolved before IL gen)");
		GameObject parentInternal = base.gameObject;
		((Transform)layer).parentInternal = (Transform)(object)parentInternal;
		nint num14 = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v378 @ S0_v66 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj16 = (nint)0 & (nint)0x200;
		if (obj16 != null)
		{
			nint num15 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v385 @ S0_v88 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Vector3 left = Vector3.left;
		transform = (Transform)obj2;
		Transform transform5 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11+8]");
		((UnityEngine.Object)transform5).m_CachedPtr = (IntPtr)0;
		Vector3 vector = (Vector3)transform / 500f;
		transform = (Transform)obj;
		Transform transform6 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((UnityEngine.Object)transform6).m_CachedPtr = (IntPtr)0;
		Vector3 eulerAngles4 = transform.eulerAngles;
		nint num16 = (nint)typeof(PoolManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v415 @ S0_v78 (Il2CppClass<SYBO.Components.Utilities.PoolManager>)+BA]");
		object obj17 = (nint)0 & (nint)0x200;
		if (obj17 != null)
		{
			nint num17 = (nint)typeof(PoolManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v420 @ S0_v84 (Il2CppClass<SYBO.Components.Utilities.PoolManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = PoolManager.PrefabPoolExists((Transform)layer);
	}

	private void NotifyOnCriticalHit(CriticalHitType type)
	{
		//IL_000e: Expected Obj, but got I4
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected I4, but got Unknown
		object obj = type ^ CriticalHitType.Barrier;
		bool isStumbling = (byte)(obj & 1) != 0;
		_isStumbling = isStumbling;
		Game game = _game;
		if (~(game.IsRunningOnTutorialTrack__BackingField ? 1u : 0u) != 0)
		{
			_followingGuard.ResetCatchUp();
		}
		CharacterModel characterModel = ((CharacterRendering)this).CharacterModel;
		Coroutine coroutine = _followingGuard.StartCoroutine_Auto((IEnumerator)characterModel);
	}

	private unsafe void NotifyOnJump(float jumpHeight, bool willPlaySound)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected Obj, but got Unknown
		//IL_0025: Expected Obj, but got I4
		//IL_003c: Expected Obj, but got I4
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected Ref, but got Unknown
		//IL_0086: Expected Obj, but got F4
		//IL_009a: Expected Obj, but got F4
		//IL_00bb: Expected Obj, but got I
		//IL_00dc: Expected Obj, but got I4
		//IL_011d: Expected F4, but got Obj
		//IL_0118: Expected native int or pointer, but got VT
		//IL_012f: Expected F4, but got I
		//IL_012a: Expected native int or pointer, but got VT
		//IL_014e: Expected VT, but got Ref
		//IL_0176: Unknown result type (might be due to invalid IL or missing references)
		//IL_017b: Expected Obj, but got Unknown
		CharacterRendering characterRendering = default;
		Vector3 vector = (Vector3)(characterRendering + 24);
		CharacterRendering characterRendering2 = (CharacterRendering)(characterRendering + 12);
		characterRendering2 = (CharacterRendering)0;
		((UnityEngine.Object)characterRendering2).m_CachedPtr = (IntPtr)0;
		characterRendering = (CharacterRendering)0;
		((UnityEngine.Object)characterRendering).m_CachedPtr = (IntPtr)0;
		ref Color reference = ref *(Color*)(characterRendering + 40);
		reference = ref *(((bool*)(willPlaySound ? 1 : 0))->m_value ? ((Color*)1) : ((Color*)null));
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [willPlaySound @ L2 (System.Boolean)+8]");
		_ = 0;
		Gizmos.set_color_Injected(ref reference);
		string debugText = ((CurveParent)_glideTime).GetDebugText();
		string debugText2 = ((CurveParent)_glideTime).GetDebugText();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S0_v17 (System.String)+30]");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S1_v17 (System.String)+2C]");
		object obj = num - 0;
		characterRendering2.OnCatchPlayer((string)(object)this, 0f, jumpHeight);
		object obj2 = 0;
		while ((nint)obj2 <= 12)
		{
			object obj3 = obj * obj2;
			float catchUpTime = (float)obj3 / 12f;
			characterRendering.OnCatchPlayer((string)(object)this, catchUpTime, jumpHeight);
			((Vector3*)(nint)vector)->x = (float)characterRendering2;
			((Vector3*)(nint)vector)->z = (nint)((UnityEngine.Object)characterRendering2).m_CachedPtr;
			reference = ref *(Color*)characterRendering;
			_ = ((UnityEngine.Object)characterRendering).m_CachedPtr;
			Gizmos.DrawWireCube(vector, (Vector3)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference));
			characterRendering2 = characterRendering;
			((UnityEngine.Object)characterRendering2).m_CachedPtr = ((UnityEngine.Object)characterRendering).m_CachedPtr;
			object obj4 = obj2 + 1;
			obj2 = obj4;
		}
	}

	private void NotifyOnDoubleJump()
	{
		//IL_0072: Expected Obj, but got I4
		//IL_00ad: Expected Obj, but got I4
		//IL_0131: Expected Obj, but got I4
		//IL_00e8: Expected Obj, but got I4
		//IL_0123: Expected Obj, but got I4
		LastDeathCause = DeathCause.CriticalHit;
		if (this.m_OnCriticalHit != null)
		{
			IAsyncResult result;
			if (_lastHitTag != "HitTrain")
			{
				result = null;
			}
			else if (_lastHitTag != "HitBarrierStandard")
			{
				result = (IAsyncResult)1;
			}
			else if (_lastHitTag != "HitBarrierJump")
			{
				result = (IAsyncResult)1;
			}
			else if (_lastHitTag != "HitBarrierRoll")
			{
				result = (IAsyncResult)1;
			}
			else
			{
				result = ((!(_lastHitTag != "HitMovingTrain")) ? ((IAsyncResult)3) : ((IAsyncResult)2));
			}
			this.m_OnCriticalHit.EndInvoke(result);
		}
	}

	private void NotifyOnJumpIfHitByTrain()
	{
		if (this.m_OnDoubleJump != null)
		{
			this.m_OnDoubleJump();
		}
	}

	public void NotifyOnLanding()
	{
		if (this.m_OnJumpIfHitByTrain != null)
		{
			this.m_OnJumpIfHitByTrain();
		}
	}

	private void NotifyOnHangtime()
	{
		if (this.m_OnLanding != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7C62");
		}
	}

	private void NotifyOnRoll()
	{
		if (this.m_OnHangtime != null)
		{
			this.m_OnHangtime();
		}
	}

	private void NotifyOnHitByTrain()
	{
		if (this.m_OnRoll != null)
		{
			this.m_OnRoll();
		}
	}

	private void NotifyOnChangeTrack(OnChangeTrackDirection direction)
	{
		//IL_002e: Expected Obj, but got I4
		if (this.m_OnCriticalHit != null)
		{
			this.m_OnCriticalHit.EndInvoke((IAsyncResult)direction);
		}
	}

	public void NotifyOnTutorialMoveBackToCheckPoint(float duration)
	{
		_lastCheckpointGamePositionZ = duration;
	}

	public void NotifyOnTutorialStartFromCheckPoint()
	{
		if (this.m_OnHitByTrain != null)
		{
			this.m_OnHitByTrain();
		}
	}

	private void NotifyOnJumpOverTrain()
	{
		if (this.m_OnTutorialStartFromCheckPoint != null)
		{
			this.m_OnTutorialStartFromCheckPoint();
		}
	}

	public void ToggleDust(bool active)
	{
		//IL_002e: Expected Obj, but got I4
		if (this.m_OnChangeTrack != null)
		{
			this.m_OnChangeTrack.EndInvoke((IAsyncResult)active);
		}
	}

	private void RaiseOnToggleDust(bool active)
	{
		IsGrounded_OnChange(active);
	}

	public void RaiseOnEnterRoute()
	{
		if (this.m_OnJumpOverTrain != null)
		{
			this.m_OnJumpOverTrain();
		}
	}

	public void RaiseOnEnterRouteEnd()
	{
		if (OnEnterRoute != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @78B7");
		}
	}

	private void RaiseExitRoute()
	{
		if (OnEnterRouteEnd != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @78B7");
		}
	}

	private void IsGrounded_OnChange(bool value)
	{
		if (OnToggleDust != null)
		{
			OnToggleDust(value);
		}
	}

	private unsafe void RouteManager_OnRouteCreated(object sender, RouteManager.RouteCreatedEventArgs args)
	{
		float unscaledCoinSpacing = ((CoinCurve)sender).UnscaledCoinSpacing;
		WebClient.DoSimulation((IRequest)this, ref *(Action*)sender, ref *(float*)args, unscaledCoinSpacing, (IList<SimulatedRequestResult>)null);
	}

	private void SubscribeToAlternateRoute(AlternateRoute alternateRoute)
	{
		if (~(__isInLipFlight ? 1u : 0u) == 0)
		{
			__isInLipFlight = false;
		}
	}

	private void AlternateRoute_OnCharacterEntryStarted(object sender, EventArgs args)
	{
		//IL_007a: Expected I, but got Obj
		//IL_0090: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_005c: Expected I4, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7281");
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v17 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		ComputeShader computeShader = default;
		if (computeShader.FindKernel(null) != 0)
		{
			ResetAfterRoute((byte)(int)computeShader != 0);
		}
	}

	private void AlternateRoute_OnDestructing(object sender, EventArgs args)
	{
	}

	private unsafe void AlternateRoute_OnCharacterEntered(object sender, EventArgs args)
	{
		//IL_0208: Expected I, but got Obj
		//IL_021e: Expected Obj, but got I
		//IL_0278: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_009e: Expected I, but got Obj
		//IL_00b4: Expected Obj, but got I
		//IL_00df: Expected I, but got Obj
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Expected Obj, but got Unknown
		//IL_0197: Expected Obj, but got I
		//IL_01a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a5: Expected Obj, but got Unknown
		//IL_01dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e2: Expected Obj, but got Unknown
		nint num = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UIScreenController>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v58 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = UIScreenController.ShouldShowOnlineScreen();
		IEnumerator a = ((UIScreenController)flag).DelayHideMainCamera();
		if (!string.Equals((string)(object)a, "IngameUI"))
		{
			_003CInitialize_003Eb__323_0(isInGame: true);
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7281");
		nint num3 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ S0_v19 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ S0_v53 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		ComputeShader computeShader = default;
		if (computeShader.FindKernel(null) != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint method_ptr = 0;
			EventHandler eventHandler = default;
			((Delegate)eventHandler).method_ptr = method_ptr;
			((Delegate)eventHandler).method = (nint)__ldftn(Character.AlternateRoute_OnCharacterEntered);
			object obj3 = eventHandler + 16;
			obj3 = this;
			((Route)(object)computeShader).OnCharacterEnteredLanded += eventHandler;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint cachedPtr = 0;
			Route route = default;
			((UnityEngine.Object)route).m_CachedPtr = cachedPtr;
			route.OnCharacterEntered = (EventHandler<Route.CharacterEnteredEventArgs>)0;
			object obj4 = route + 16;
			obj4 = this;
			Vector3 originGamePosition = route.OriginGamePosition;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num5 = 0;
			_ = 0;
			EventHandler<Route.CharacterEnteredEventArgs> eventHandler2 = default;
			object obj5 = eventHandler2 + 16;
			obj5 = this;
			((Route)(object)computeShader).OnCharacterEntered += eventHandler2;
		}
	}

	private void AlternateRoute_OnCharacterEntrySkipped(object sender, Route.CharacterEntrySkippedEventArgs args)
	{
		_characterModel.StartEyeAnimations(UIModelController.ModelScreen.Character);
		_stumbleState = StumbleState.Safe;
	}

	private unsafe IEnumerator ResetAfterRouteDelayed(bool isRouteDestructing)
	{
		//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fe: Expected Obj, but got Unknown
		//IL_0107: Expected Obj, but got I4
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0121: Expected Obj, but got Unknown
		//IL_012a: Expected Obj, but got I4
		//IL_013f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0144: Expected Obj, but got Unknown
		//IL_017b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0180: Expected Obj, but got Unknown
		//IL_01b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ba: Expected Obj, but got Unknown
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected Obj, but got Unknown
		//IL_002b: Expected I, but got Obj
		//IL_0041: Expected Obj, but got I
		//IL_020d: Expected Obj, but got I
		//IL_02cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d2: Expected Obj, but got Unknown
		//IL_02e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ea: Expected Obj, but got Unknown
		//IL_0338: Expected Obj, but got I
		//IL_006c: Expected I, but got Obj
		//IL_0224: Unknown result type (might be due to invalid IL or missing references)
		//IL_0229: Expected Obj, but got Unknown
		//IL_00bb: Expected Obj, but got I
		//IL_00eb: Expected Obj, but got I4
		//IL_00d0: Expected Obj, but got I
		//IL_00de: Expected Obj, but got I4
		object obj2 = default;
		object obj = obj2 + 144;
		obj = 0;
		_ = 0;
		_ = 0;
		object obj3 = obj2 + 120;
		obj3 = 0;
		_ = 0;
		_ = 0;
		Collider collider = (Collider)(obj2 + 96);
		collider.get_bounds_Injected(out *(Bounds*)CharacterTrigger);
		obj = collider;
		_ = ((UnityEngine.Object)collider).m_CachedPtr;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S0_v17 (UnityEngine.Collider)+10]");
		_ = 0;
		Collider collider2 = (Collider)(obj2 + 72);
		collider2.get_bounds_Injected(out *(isRouteDestructing ? ((Bounds*)1) : ((Bounds*)null)));
		obj3 = collider2;
		_ = ((UnityEngine.Object)collider2).m_CachedPtr;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ S0_v22 (UnityEngine.Collider)+10]");
		_ = 0;
		object obj4 = obj2 + 60;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F4AA");
		object obj5 = obj2 + 48;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F4AA");
		nint num = (nint)typeof(Mathf);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ S0_v35 (Il2CppClass<UnityEngine.Mathf>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num2 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ S0_v72 (Il2CppClass<UnityEngine.Mathf>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ S0_v27+4]");
		nint num3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ S0_v31+4]");
		bool flag = num3 > 0;
		bool flag2 = !flag;
		bool flag3 = !flag2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ S0_v27+4]");
		object obj7 = 0;
		if (!flag3)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ S0_v31+4]");
			obj7 = 0;
		}
		object obj8 = obj2 + 36;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F4AD");
		object obj9 = obj2 + 24;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F4AD");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ S0_v44+4]");
		nint num4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ S0_v48+4]");
		bool flag4 = num4 < 0;
		bool flag5 = !flag4;
		bool flag6 = !flag5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ S0_v44+4]");
		object obj10 = 0;
		if (!flag6)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ S0_v48+4]");
			obj10 = 0;
		}
		object obj11 = obj2 + 12;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F4AA");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F4A3");
		object obj12 = obj7 + obj10;
		float num5 = (float)obj12 * 0.5f;
		float num6 = num5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ S0_v54+4]");
		float num7 = num6 - 0f;
		float num8 = num7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
		float num9 = num8 / 0f;
		bool flag7 = num9 < 0.66f;
		if (num9 < 0.33f)
		{
			return (IEnumerator)2;
		}
		return (IEnumerator)flag7;
	}

	public unsafe void ResetAfterRoute(bool isRouteDestructing)
	{
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Expected Obj, but got Unknown
		//IL_00fa: Expected Obj, but got I4
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected Obj, but got Unknown
		//IL_0033: Expected Obj, but got I4
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Expected Obj, but got Unknown
		//IL_0070: Expected Obj, but got I4
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Expected Obj, but got Unknown
		//IL_00c1: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num = 0;
		_ = 0;
		EventHandler<Route.CharacterEntryStartedEventArgs> eventHandler = default;
		object obj = eventHandler + 16;
		obj = this;
		((Route)isRouteDestructing).OnCharacterEntryStarted -= eventHandler;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num2 = 0;
		_ = 0;
		EventHandler<Route.CharacterEntrySkippedEventArgs> eventHandler2 = default;
		object obj2 = eventHandler2 + 16;
		obj2 = this;
		((Route)isRouteDestructing).OnCharacterEntrySkipped -= eventHandler2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num3 = 0;
		_ = 0;
		EventHandler<Route.CharacterEnteredEventArgs> eventHandler3 = default;
		object obj3 = eventHandler3 + 16;
		obj3 = this;
		((Route)isRouteDestructing).OnCharacterEntered -= eventHandler3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr = 0;
		EventHandler eventHandler4 = default;
		((Delegate)eventHandler4).method_ptr = method_ptr;
		((Delegate)eventHandler4).method = (nint)__ldftn(Character.AlternateRoute_OnDestructing);
		object obj4 = eventHandler4 + 16;
		obj4 = this;
		((Route)isRouteDestructing).OnDestructing -= eventHandler4;
	}

	public Character()
	{
		if (OnExitRoute != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @78B7");
		}
	}

	static Character()
	{
		//IL_0030: Expected I, but got Obj
		//IL_0046: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		CoinStats coinStats = default;
		CoinStats.New = coinStats;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num = (nint)typeof(CoinStats);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v15 (Il2CppClass<SYBO.Subway.Coins.CoinStats>)+5C]");
		object obj = (nint)0 + (nint)4;
		object obj2 = default;
		obj = obj2;
	}

	private void _003CInitialize_003Eb__323_0(bool isInGame)
	{
		if (OnRouteDone != null)
		{
			OnRouteDone(isInGame);
		}
		Game game = _game;
		CharacterModifierCollection modifiers = game._modifiers;
		Hoverboard hoverboard = modifiers.hoverboard;
		if (~(hoverboard.isActive ? 1u : 0u) != 0)
		{
			_characterModel.DeleteBoardModels();
		}
		Game game2 = _game;
		if (isInGame)
		{
			((CoinMagnet)(object)game2._modifiers).Awake();
			return;
		}
		game2._modifiers.Reset();
		_game.UnlockGameSpeed();
	}

	private void _003CInitialize_003Eb__323_1(bool squeeze)
	{
		if (!squeeze)
		{
			MonoBehaviour.print(this);
			ImmuneToCriticalHit = false;
			_characterController.isTrigger = true;
			StopColliding = false;
		}
	}
}
