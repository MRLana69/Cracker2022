using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2ILInjected;
using Data.Save;
using Info;
using Missions;
using SYBO.Common.Managers;
using SYBO.Components.Utilities;
using SYBO.Subway;
using SYBO.Subway.Characters;
using SYBO.Subway.Coins;
using SYBO.Subway.Routes.Builders.Worker;
using UnityEngine;
using UnityEngine.Rendering;

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

	public delegate void OnSpeedStartDelegate();

	public delegate void OnSpeedEndDelegate();

	private sealed class _003CBegin_003Ed__84 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Hoverboard _003C_003E4__this;

		private HoverboardBundle _003CnewBoard_003E5__2;

		private float _003CtimeLeft_003E5__3;

		private float _003CnewCoolDownDist_003E5__4;

		private float _003CdistanceLeft_003E5__5;

		private bool _003CdidStopCooldown_003E5__6;

		object IEnumerator<object>.Current
		{
			get
			{
				//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
				//IL_00bd: Expected Obj, but got Unknown
				//IL_00cb: Expected Obj, but got I4
				//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
				//IL_00d6: Expected Obj, but got Unknown
				//IL_00df: Expected Obj, but got I4
				//IL_02e2: Unknown result type (might be due to invalid IL or missing references)
				//IL_02e7: Expected Obj, but got Unknown
				//IL_010a: Unknown result type (might be due to invalid IL or missing references)
				//IL_010f: Expected Obj, but got Unknown
				//IL_0d7b: Expected Obj, but got I4
				//IL_0d7b: Expected Obj, but got I4
				//IL_0d7b: Expected Obj, but got I4
				//IL_0153: Expected Obj, but got VT
				//IL_0552: Expected Obj, but got I4
				//IL_0552: Expected Obj, but got I4
				//IL_0552: Expected Obj, but got I4
				//IL_08da: Expected VT, but got Obj
				//IL_0321: Unknown result type (might be due to invalid IL or missing references)
				//IL_0326: Expected Obj, but got Unknown
				//IL_0358: Expected Obj, but got I4
				//IL_0358: Expected Obj, but got I4
				//IL_0169: Expected I4, but got Obj
				//IL_0177: Expected I, but got Obj
				//IL_018d: Expected Obj, but got I
				//IL_0752: Expected Obj, but got I4
				//IL_0565: Expected I, but got Obj
				//IL_057b: Expected Obj, but got I
				//IL_050a: Unknown result type (might be due to invalid IL or missing references)
				//IL_050f: Expected Obj, but got Unknown
				//IL_0518: Expected Obj, but got I4
				//IL_052c: Expected Obj, but got I4
				//IL_08f7: Unknown result type (might be due to invalid IL or missing references)
				//IL_08fc: Expected Obj, but got Unknown
				//IL_091f: Expected I, but got Obj
				//IL_0935: Expected Obj, but got I
				//IL_08aa: Unknown result type (might be due to invalid IL or missing references)
				//IL_08af: Expected Obj, but got Unknown
				//IL_08b8: Expected Obj, but got I4
				//IL_08cc: Expected Obj, but got I4
				//IL_0369: Expected Obj, but got I4
				//IL_0cb5: Expected I, but got Obj
				//IL_0ccb: Expected Obj, but got I
				//IL_0f4f: Expected Obj, but got I
				//IL_0f6c: Expected Obj, but got I
				//IL_0f99: Expected F4, but got I
				//IL_0b33: Expected I, but got Obj
				//IL_0b49: Expected Obj, but got I
				//IL_03cf: Expected I, but got Obj
				//IL_03e5: Expected Obj, but got I
				//IL_01b8: Expected I, but got Obj
				//IL_05a6: Expected I, but got Obj
				//IL_0960: Expected I, but got Obj
				//IL_0252: Expected I, but got Obj
				//IL_0268: Expected Obj, but got I
				//IL_0205: Expected I, but got Obj
				//IL_07cc: Expected I, but got Obj
				//IL_07e2: Expected Obj, but got I
				//IL_0ee4: Expected I, but got Obj
				//IL_0efa: Expected Obj, but got I
				//IL_09e9: Expected I, but got Obj
				//IL_09ff: Expected Obj, but got I
				//IL_0b74: Expected I, but got Obj
				//IL_0aa5: Expected I, but got Obj
				//IL_0abb: Expected Obj, but got I
				//IL_0410: Expected I, but got Obj
				//IL_0d46: Expected I4, but got Obj
				//IL_0d46: Expected Obj, but got I
				//IL_0fc5: Expected Obj, but got I
				//IL_0fe2: Expected Obj, but got I
				//IL_100f: Expected Obj, but got I
				//IL_102c: Expected Obj, but got I
				//IL_10df: Unknown result type (might be due to invalid IL or missing references)
				//IL_10e4: Expected Obj, but got Unknown
				//IL_10ed: Expected Obj, but got I4
				//IL_1101: Expected Obj, but got I4
				//IL_0293: Expected I, but got Obj
				//IL_080d: Expected I, but got Obj
				//IL_0682: Expected I, but got Obj
				//IL_0a2a: Expected I, but got Obj
				//IL_0ae6: Expected I, but got Obj
				Hoverboard hoverboard = _003C_003E4__this;
				if (_003C_003E1__state != 0)
				{
					if (_003C_003E1__state != 1)
					{
						if (_003C_003E1__state != 2)
						{
							if (_003C_003E1__state == 3)
							{
								_003C_003E1__state = -1;
								goto IL_0dea;
							}
							return null;
						}
						_003C_003E1__state = -1;
						goto IL_0856;
					}
					_003C_003E1__state = -1;
				}
				else
				{
					_003C_003E1__state = -1;
					if (~(hoverboard.__isAllowed ? 1u : 0u) != 0)
					{
						return null;
					}
					if (~(hoverboard._isInCooldown ? 1u : 0u) == 0)
					{
						return null;
					}
					object obj = hoverboard - -64;
					((GameObject)obj).tag = (string)1;
					object obj2 = this + 20;
					obj2 = 0;
					if (~(hoverboard._isARewardFromMysteryPowerup ? 1u : 0u) == 0)
					{
						hoverboard.PlayCrashSound();
						object obj3 = this + 20;
						Character character = hoverboard.character;
						SkinnedMeshRenderer[] renderes = ((CharacterModelPreview)(object)character._characterModel).Renderes;
						obj3 = renderes;
						_0021_00210 componentInChildren = (_0021_00210)((Component)_003CnewBoard_003E5__2).GetComponentInChildren<T>();
						CharacterModel charactermodel = ((HoverboardBundle)componentInChildren).Charactermodel;
						hoverboard._currentRandomBoard = (Boards.BoardId)charactermodel;
						nint num = (nint)typeof(Boards);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v393 @ S0_v219 (Il2CppClass<Info.Boards>)+BA]");
						object obj4 = (nint)0 & (nint)0x200;
						if (obj4 != null)
						{
							nint num2 = (nint)typeof(Boards);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v413 @ S0_v242 (Il2CppClass<Info.Boards>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						Boards.Board board = Boards.boardData.get_Item(hoverboard._currentRandomBoard);
						nint num3 = (nint)typeof(Strings);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v453 @ S1_v165 (Il2CppClass<Strings>)+BA]");
						object obj5 = (nint)0 & (nint)0x200;
						if (obj5 != null)
						{
							nint num4 = (nint)typeof(Strings);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v504 @ S1_v177 (Il2CppClass<Strings>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						string text = Strings.GetDefault(board.name);
						string provider = Strings.GetDefault("MYSTERY_POWERUP_RANDOM_HOVERBOARD_TEXT");
						object obj6 = ((IConvertible)text).ToType((Type)(object)" ", (IFormatProvider)(object)provider);
						nint num5 = (nint)typeof(UIScreenController);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v625 @ S0_v231 (Il2CppClass<UIScreenController>)+BA]");
						object obj7 = (nint)0 & (nint)0x200;
						if (obj7 != null)
						{
							nint num6 = (nint)typeof(UIScreenController);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v643 @ S0_v238 (Il2CppClass<UIScreenController>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						bool flag = UIScreenController.ShouldShowOnlineScreen();
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v650 @ S0_v236 (System.Boolean)+E0]");
						((UIModelController)0).ActivateCelebrationBoardWithStripes((Boards.BoardId)obj6, UIModelController.ModelScreen.GameOver);
					}
					else
					{
						InventorySave.IncreaseTier(UpgradeType.hoverboard);
						object obj8 = this + 20;
						Character character2 = hoverboard.character;
						HoverboardBundle hoverboardBundle = character2._characterModel.AddRandomHoverboard();
						obj8 = hoverboardBundle;
					}
					((LongMagnet)(object)hoverboard).CoinHit((Collider)(object)_003CnewBoard_003E5__2);
					StayInOneLaneMission instance = StayInOneLaneMission.instance;
					((OwnBoardsAward)(object)instance)._002Ector((AwardStaticData)34, (PersistentAwardProgress)1, (Action<Award>)(-1));
					object obj9 = hoverboard + 20;
					string privacyPolicyUrl = Globals.GetPrivacyPolicyUrl();
					bool flag2 = ((CharacterModifier)hoverboard).TriggeredByMysteryPowerup__BackingField;
					bool flag3 = Globals.TryAddAnimationEvent((Animation)(object)privacyPolicyUrl, (string)1, (AnimationEvent)flag2);
					obj9 = flag3;
					((CharacterModifier)hoverboard)._paused = false;
					Character character3 = hoverboard.character;
					if (~(character3._isStumbling ? 1u : 0u) == 0)
					{
						hoverboard.character.HitByTrainSequence();
					}
					hoverboard.isActive = true;
					nint num7 = (nint)typeof(So);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v611 @ S0_v189 (Il2CppClass<So>)+BA]");
					object obj10 = (nint)0 & (nint)0x200;
					if (obj10 != null)
					{
						nint num8 = (nint)typeof(So);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v630 @ S0_v203 (Il2CppClass<So>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					HoverboardBundle hoverboardBundle2 = ((CharacterModel)(object)So.Instance).AddHoverboard((string)(object)hoverboard.StartSound, false);
					Character character4 = hoverboard.character;
					character4.CharacterPickupParticleSystem.PickedUpHuntToken();
					Character character5 = hoverboard.character;
					character5.ImmuneToCriticalHit = true;
					hoverboard.stop = StopSignal.DONT_STOP;
				}
				ActivePowerup powerup = hoverboard._powerup;
				if (powerup.timeLeft > 0f && hoverboard.stop == StopSignal.DONT_STOP)
				{
					object obj11 = this + 12;
					obj11 = 0;
					_003C_003E1__state = 1;
					return 1;
				}
				Character character6 = hoverboard.character;
				character6.ImmuneToCriticalHit = false;
				hoverboard.isActive = false;
				hoverboard.PlayCrashSound();
				if (hoverboard.stop != StopSignal.DONT_STOP)
				{
					goto IL_06c1;
				}
				StayInOneLaneMission instance2 = StayInOneLaneMission.instance;
				((OwnBoardsAward)(object)instance2)._002Ector((AwardStaticData)35, (PersistentAwardProgress)1, (Action<Award>)(-1));
				nint num9 = (nint)typeof(So);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v326 @ S0_v120 (Il2CppClass<So>)+BA]");
				object obj12 = (nint)0 & (nint)0x200;
				if (obj12 != null)
				{
					nint num10 = (nint)typeof(So);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v373 @ S0_v149 (Il2CppClass<So>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				HoverboardBundle hoverboardBundle3 = ((CharacterModel)(object)So.Instance).AddHoverboard((string)(object)hoverboard.powerDownSound, false);
				hoverboard._isInCooldown = true;
				hoverboard._002Ector();
				Character character7 = hoverboard.character;
				if (!character7._isFalling)
				{
					Character character8 = hoverboard.character;
					if (!character8.__isJumping)
					{
						if (hoverboard.m_OnRun != null)
						{
							hoverboard.m_OnRun();
						}
						goto IL_0ed6;
					}
				}
				if (hoverboard.m_OnJump != null)
				{
					hoverboard.m_OnJump();
				}
				goto IL_0ed6;
				IL_06c1:
				if (hoverboard.stop == StopSignal.STOP)
				{
					hoverboard.isActive = false;
					Character character9 = hoverboard.character;
					character9.ImmuneToCriticalHit = false;
					hoverboard._isInCooldown = true;
					Character character10 = hoverboard.character;
					string tag = character10.HoverboardCrashParticleSystem.tag;
					((GameObject)(object)tag).tag = (string)1;
					Character character11 = hoverboard.character;
					character11.HoverboardCrashParticleSystem.Stop();
					hoverboard.Pause();
					hoverboard._002Ector();
					if (hoverboard.m_OnJump != null)
					{
						hoverboard.m_OnJump();
					}
					nint num11 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v555 @ S1_v87 (Il2CppClass<UnityEngine.Object>)+BA]");
					object obj13 = (nint)0 & (nint)0x200;
					if (obj13 != null)
					{
						nint num12 = (nint)typeof(UnityEngine.Object);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v590 @ S1_v94 (Il2CppClass<UnityEngine.Object>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					UnityEngine.Object.DestroyImmediate(_003CnewBoard_003E5__2);
					_003CtimeLeft_003E5__3 = hoverboard.WaitForParticlesDelay;
					goto IL_0856;
				}
				return null;
				IL_0856:
				if (_003CtimeLeft_003E5__3 > 0f)
				{
					float unscaledTime = Time.unscaledTime;
					float num13 = _003CtimeLeft_003E5__3 - unscaledTime;
					_003CtimeLeft_003E5__3 = num13;
					object obj14 = this + 12;
					obj14 = 0;
					_003C_003E1__state = 2;
					return 1;
				}
				_00210 val = (_00210)SingletonMonoBehaviour<>.Instantiate();
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
				object obj15 = hoverboard.character + 236;
				object obj16 = obj15;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v269 @ S2_v16+8]");
				_ = 0;
				nint num14 = (nint)typeof(Game);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v280 @ S3_v10 (Il2CppClass<SYBO.Subway.Game>)+BA]");
				object obj17 = (nint)0 & (nint)0x200;
				if (obj17 != null)
				{
					nint num15 = (nint)typeof(Game);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v316 @ S3_v22 (Il2CppClass<SYBO.Subway.Game>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				bool isInstantiated = Game.IsInstantiated;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v324 @ S3_v15 (System.Boolean)+58]");
				object obj18 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v324 @ S3_v15 (System.Boolean)+44]");
				nint num16 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v369 @ S4_v6+8]");
				object obj19 = num16 / 0;
				float reqPositionCleanedUpGameZ = hoverboard.RemoveObstaclesDistance * (float)obj19;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
				RouteBuilderWorker routeBuilderWorker = default;
				routeBuilderWorker.UpdateWorker(0f, reqPositionCleanedUpGameZ);
				hoverboard.character.ClearLastObstacleType();
				Character character12 = hoverboard.character;
				if (~(character12._isRolling ? 1u : 0u) == 0)
				{
					hoverboard.character.StopStumble();
				}
				nint num17 = (nint)typeof(Game);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v487 @ S1_v46 (Il2CppClass<SYBO.Subway.Game>)+BA]");
				object obj20 = (nint)0 & (nint)0x200;
				if (obj20 != null)
				{
					nint num18 = (nint)typeof(Game);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v522 @ S1_v59 (Il2CppClass<SYBO.Subway.Game>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				bool isInstantiated2 = Game.IsInstantiated;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v529 @ S1_v51 (System.Boolean)+58]");
				object obj21 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v529 @ S1_v51 (System.Boolean)+44]");
				nint num19 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v572 @ S2_v25+8]");
				object obj22 = num19 / 0;
				float num20 = hoverboard.slowMotionDistance * (float)obj22;
				bool isInstantiated3 = Game.IsInstantiated;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v580 @ S2_v28 (System.Boolean)+58]");
				object obj23 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v580 @ S2_v28 (System.Boolean)+44]");
				nint num21 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v619 @ S3_v20+8]");
				object obj24 = num21 / 0;
				float num22 = hoverboard.cooldownDstance * (float)obj24;
				_003CnewCoolDownDist_003E5__4 = num22;
				_003CdistanceLeft_003E5__5 = num20;
				_003CdidStopCooldown_003E5__6 = false;
				goto IL_0dea;
				IL_0dea:
				if (!(_003CdistanceLeft_003E5__5 > 0f))
				{
					Character character13 = hoverboard.character;
					string tag2 = character13.HoverboardCrashParticleSystem.tag;
					((GameObject)(object)tag2).tag = null;
					nint num23 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v309 @ S1_v24 (Il2CppClass<UnityEngine.Object>)+BA]");
					object obj25 = (nint)0 & (nint)0x200;
					if (obj25 != null)
					{
						nint num24 = (nint)typeof(UnityEngine.Object);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v353 @ S1_v29 (Il2CppClass<UnityEngine.Object>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					UnityEngine.Object.DestroyImmediate(_003CnewBoard_003E5__2);
					return null;
				}
				nint num25 = (nint)typeof(Game);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v207 @ S0_v21 (Il2CppClass<SYBO.Subway.Game>)+BA]");
				object obj26 = (nint)0 & (nint)0x200;
				if (obj26 != null)
				{
					nint num26 = (nint)typeof(Game);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v254 @ S0_v42 (Il2CppClass<SYBO.Subway.Game>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				bool isInstantiated4 = Game.IsInstantiated;
				float unscaledTime2 = Time.unscaledTime;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v264 @ S2_v4 (System.Boolean)+48]");
				float num27 = 0f * unscaledTime2;
				float num28 = _003CdistanceLeft_003E5__5 - num27;
				_003CdistanceLeft_003E5__5 = num28;
				bool isInstantiated5 = Game.IsInstantiated;
				float unscaledTime3 = Time.unscaledTime;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v365 @ S2_v8 (System.Boolean)+48]");
				float num29 = 0f * unscaledTime3;
				float num30 = _003CnewCoolDownDist_003E5__4 - num29;
				_003CnewCoolDownDist_003E5__4 = num30;
				if (_003CnewCoolDownDist_003E5__4 < 0f && ~(_003CdidStopCooldown_003E5__6 ? 1u : 0u) != 0)
				{
					Character character14 = hoverboard.character;
					character14.ImmuneToCriticalHit = false;
					_003CdidStopCooldown_003E5__6 = true;
				}
				hoverboard._currentRandomBoard = Boards.BoardId.normal;
				object obj27 = this + 12;
				obj27 = 0;
				_003C_003E1__state = 3;
				return 1;
				IL_0ed6:
				nint num31 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v543 @ S1_v107 (Il2CppClass<UnityEngine.Object>)+BA]");
				object obj28 = (nint)0 & (nint)0x200;
				if (obj28 != null)
				{
					nint num32 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v584 @ S1_v112 (Il2CppClass<UnityEngine.Object>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				UnityEngine.Object.DestroyImmediate(_003CnewBoard_003E5__2);
				goto IL_06c1;
			}
		}

		object IEnumerator.Current => _003C_003E2__current;

		public _003CBegin_003Ed__84(int _003C_003E1__state)
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Hoverboard+<Begin>d__84)+34]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Hoverboard+<Begin>d__84)+34]");
			object obj3;
			object obj4;
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Hoverboard+<Begin>d__84)+34]");
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

	public float cooldownDstance;

	public float slowMotionDistance;

	public float slowDownToScale;

	private GameObject hoverboardRoot;

	public float WaitForParticlesDelay;

	public float RemoveObstaclesDistance;

	private LongMagnet longMagnet;

	private Character character;

	public bool isActive;

	public bool _isInCooldown;

	private bool __isAllowed;

	private bool _isARewardFromMysteryPowerup;

	public AudioClipInfo CrashSound;

	public AudioClipInfo StartSound;

	private static Hoverboard instance;

	private Boards.BoardId _currentRandomBoard;

	private OnSwitchToHoverboardDelegate m_OnSwitchToHoverboard;

	private OnEndHoverboardDelegate m_OnEndHoverboard;

	private OnHoverboardJumpDelegate m_OnJump;

	private OnRunDelegate m_OnRun;

	private OnSpeedStartDelegate m_OnSpeedStart;

	private OnSpeedEndDelegate m_OnSpeedEnd;

	public bool IsJumper
	{
		get
		{
			//IL_0023: Expected Obj, but got I4
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			_ = 0;
			bool flag = default;
			object obj = (flag ? 1 : 0) + 16;
			obj = this;
			return flag;
		}
	}

	public bool IsLowrider => isJumper;

	public bool IsHighSpeedBoard => isLowrider;

	public bool IsSpeedBoard => isHighSpeedBoard;

	public bool IsGlider => isSpeedBoard;

	public bool IsVTol => isGlider;

	public bool IsTeleporter => isVTol;

	public bool IsDoubleJump => isTeleporter;

	public bool IsVanity => isDoubleJump;

	public bool IsInCooldown => isVanity;

	public bool IsAllowed
	{
		get
		{
			return _isInCooldown;
		}
		set
		{
			//IL_0141: Expected Obj, but got I4
			//IL_0153: Expected I, but got Obj
			//IL_0169: Expected Obj, but got I
			//IL_018f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0194: Expected Obj, but got Unknown
			//IL_0013: Expected I, but got Obj
			//IL_0062: Expected Obj, but got I4
			//IL_0091: Expected VT, but got Obj
			//IL_00a4: Expected I, but got Obj
			//IL_00ba: Expected Obj, but got I
			//IL_01d1: Invalid comparison between I and F4
			//IL_01eb: Invalid comparison between I and F4
			//IL_0201: Expected Obj, but got I4
			//IL_0225: Unknown result type (might be due to invalid IL or missing references)
			//IL_022a: Expected I4, but got Unknown
			//IL_00e5: Expected I, but got Obj
			//IL_0133: Expected F4, but got I4
			Coin component = ((Component)value).GetComponent<Coin>();
			nint num = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v11 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S0_v30 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Transform transform = default;
			object obj2 = transform + 12;
			if (((ComputeShader)(object)component).FindKernel((string)null) == 0)
			{
				return;
			}
			object obj3 = (isVanity ? 1 : 0) + 248;
			obj2 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S1_v11+8]");
			_ = 0;
			GameObject gameObject = component.gameObject;
			transform.position = (Vector3)gameObject;
			nint num3 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ S1_v19 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj4 = (nint)0 & (nint)0x200;
			if (obj4 != null)
			{
				nint num4 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ S1_v31 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v16+4]");
			bool flag = !(0f < 70f);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7 (UnityEngine.Transform)+4]");
			bool flag2 = !(0f < 70f);
			object obj5 = flag ^ flag2;
			int num5 = ((ComputeShader)(object)component).FindKernel((string)null);
			int num6 = num5 ^ 1;
			if ((obj5 | num6) == 0)
			{
				component.MoveToSuperSneakers(isGlider ? 1 : 0);
			}
		}
	}

	public bool IsARewardFromMysteryPowerup
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

	public override bool ShouldPauseInJetpack
	{
		get
		{
			//IL_0023: Expected Obj, but got I4
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			_ = 0;
			bool flag = default;
			object obj = (flag ? 1 : 0) + 16;
			obj = this;
			return flag;
		}
	}

	public override bool ShouldPauseInAlternateRoutes => true;

	public static Hoverboard Instance
	{
		get
		{
			//IL_001d: Expected Obj, but got I4
			bool doubleScoreActive = DoubleScoreMultiplier._doubleScoreActive;
			return (Hoverboard)doubleScoreActive;
		}
	}

	public event OnSwitchToHoverboardDelegate OnSwitchToHoverboard
	{
		add
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected I4, but got Unknown
			bool isARewardFromMysteryPowerup = (byte)(value & 1) != 0;
			_isARewardFromMysteryPowerup = isARewardFromMysteryPowerup;
		}
		remove
		{
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected Obj, but got Unknown
			Delegate obj = this.m_OnSwitchToHoverboard;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.CombineImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				object obj3 = this + 100;
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

	public event OnEndHoverboardDelegate OnEndHoverboard
	{
		add
		{
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected Obj, but got Unknown
			Delegate obj = this.m_OnSwitchToHoverboard;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.RemoveImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				object obj3 = this + 100;
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
			Delegate obj = this.m_OnEndHoverboard;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.CombineImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				object obj3 = this + 104;
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

	public event OnHoverboardJumpDelegate OnJump
	{
		add
		{
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected Obj, but got Unknown
			Delegate obj = this.m_OnEndHoverboard;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.RemoveImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				object obj3 = this + 104;
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
				object obj3 = this + 108;
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

	public event OnRunDelegate OnRun
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
				object obj3 = this + 108;
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
			Delegate obj = this.m_OnRun;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.CombineImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				object obj3 = this + 112;
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

	public event OnSpeedStartDelegate OnSpeedStart
	{
		add
		{
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected Obj, but got Unknown
			Delegate obj = this.m_OnRun;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.RemoveImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				object obj3 = this + 112;
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
			Delegate obj = this.m_OnSpeedStart;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.CombineImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				object obj3 = this + 116;
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

	public event OnSpeedEndDelegate OnSpeedEnd
	{
		add
		{
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected Obj, but got Unknown
			Delegate obj = this.m_OnSpeedStart;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.RemoveImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				object obj3 = this + 116;
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
			Delegate obj = this.m_OnSpeedEnd;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.CombineImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				object obj3 = this + 120;
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

	public void Awake()
	{
		base.Prepare();
	}

	public void intialize()
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(Hoverboard);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Hoverboard>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Hoverboard);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v12 (Il2CppClass<Hoverboard>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		instance = this;
	}

	private unsafe void Game_OnCharacterModelRecreated()
	{
		//IL_0104: Expected I, but got Obj
		//IL_011a: Expected Obj, but got I
		//IL_01e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ec: Expected Obj, but got Unknown
		//IL_01fe: Expected Obj, but got I4
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_013d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0142: Expected Obj, but got Unknown
		//IL_0159: Unknown result type (might be due to invalid IL or missing references)
		//IL_015e: Expected Obj, but got Unknown
		//IL_0195: Unknown result type (might be due to invalid IL or missing references)
		//IL_019a: Expected Obj, but got Unknown
		//IL_00a1: Expected I, but got Obj
		nint num = (nint)typeof(Game);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SYBO.Subway.Game>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Game);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v27 (Il2CppClass<SYBO.Subway.Game>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool isInstantiated = Game.IsInstantiated;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr = 0;
		Action action = default;
		((Delegate)action).method_ptr = method_ptr;
		((Delegate)action).method = (nint)__ldftn(Hoverboard.Game_OnCharacterModelRecreated);
		object obj2 = action + 16;
		obj2 = this;
		((Game)isInstantiated).OnCharacterModelRecreated -= action;
		nint num3 = (nint)typeof(Character);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S0_v13 (Il2CppClass<SYBO.Subway.Characters.Character>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num4 = (nint)typeof(Character);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ S0_v23 (Il2CppClass<SYBO.Subway.Characters.Character>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj4 = this + 80;
		CharacterRendering characterRendering = CharacterRendering.Instance;
		obj4 = characterRendering;
		object obj5 = this - -64;
		Character character = this.character;
		CharacterModel characterModel = character._characterModel;
		string text = characterModel._attachPoint1.tag;
		obj5 = text;
		object obj6 = this + 76;
		string text2 = tag;
		LongMagnet component = ((GameObject)(object)text2).GetComponent<LongMagnet>();
		obj6 = component;
	}

	public override void Reset()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected Obj, but got Unknown
		object obj = this - -64;
		Character character = this.character;
		CharacterModel characterModel = character._characterModel;
		string text = characterModel._attachPoint1.tag;
		obj = text;
	}

	public void SetupAbilitiesAndVisuals(HoverboardBundle hoverboardBundle)
	{
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected Obj, but got Unknown
		Delegate obj = this.m_OnSpeedEnd;
		object obj4 = default;
		while (true)
		{
			Delegate obj2 = obj.RemoveImpl((Delegate)(object)hoverboardBundle);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
			object obj3 = this + 120;
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

	public void ResetBoardAndAbilitys()
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected Obj, but got Unknown
		//IL_002e: Expected VT, but got Obj
		//IL_003c: Expected VT, but got Obj
		//IL_0051: Expected F4, but got I
		//IL_0051: Expected Obj, but got VT
		base.ExpireSoon();
		Character character = this.character;
		character.ImmuneToCriticalHit = false;
		Character character2 = this.character;
		character2._characterController.isTrigger = true;
		Character character3 = this.character;
		character3.CharacterTrigger.isTrigger = true;
		object obj = this - -64;
		((GameObject)obj).tag = null;
		isActive = false;
		_00210 val = (_00210)SingletonMonoBehaviour<>.Instantiate();
		_00210 val2 = (_00210)SingletonMonoBehaviour<>.Instantiate();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S1_v11 (T)+14]");
		((TimeScaleManager)val).TimeScaleInMenuDefault = 0f;
		Character character4 = this.character;
		string text = character4.HoverboardCrashParticleSystem.tag;
		((GameObject)(object)text).tag = null;
	}

	public override IEnumerator Begin()
	{
		//IL_0019: Expected Obj, but got I4
		bool isARewardFromMysteryPowerup = _isARewardFromMysteryPowerup;
		return (IEnumerator)isARewardFromMysteryPowerup;
	}

	public void PlayCrashSound()
	{
		//IL_005a: Expected I, but got Obj
		//IL_0070: Expected Obj, but got I
		//IL_020d: Expected I, but got Obj
		//IL_0223: Expected Obj, but got I
		//IL_009b: Expected I, but got Obj
		//IL_02ca: Expected I, but got Obj
		//IL_02e0: Expected Obj, but got I
		//IL_0477: Expected Obj, but got I4
		//IL_00e8: Expected I, but got Obj
		//IL_00fe: Expected Obj, but got I
		//IL_0499: Expected Obj, but got I4
		//IL_024e: Expected I, but got Obj
		//IL_030b: Expected I, but got Obj
		//IL_0129: Expected I, but got Obj
		Character character = this.character;
		character._characterModel.DeleteBoardModels();
		if (~(isJumper ? 1u : 0u) == 0)
		{
			VariableBool longMagnetSuction = longMagnet.LongMagnetSuction;
			if (longMagnetSuction == null)
			{
				longMagnet._002Ector();
			}
			nint num = (nint)typeof(SuperSneakers);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ S0_v82 (Il2CppClass<SuperSneakers>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(SuperSneakers);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ S0_v105 (Il2CppClass<SuperSneakers>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool watchedReviveAdInCurrentRun = SaveMeManager.WatchedReviveAdInCurrentRun;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ S0_v87 (System.Boolean)+20]");
			if ((nint)0 != 0)
			{
				nint num3 = (nint)typeof(SuperSneakers);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v151 @ S0_v96 (Il2CppClass<SuperSneakers>)+BA]");
				object obj2 = (nint)0 & (nint)0x200;
				if (obj2 != null)
				{
					nint num4 = (nint)typeof(SuperSneakers);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v179 @ S0_v101 (Il2CppClass<SuperSneakers>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				bool watchedReviveAdInCurrentRun2 = SaveMeManager.WatchedReviveAdInCurrentRun;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7266");
			}
			else
			{
				Character character2 = this.character;
				CharacterModel characterModel = character2._characterModel;
				characterModel._meshSuperSneaker.shadowCastingMode = ShadowCastingMode.Off;
			}
			isJumper = false;
		}
		if (~(isLowrider ? 1u : 0u) == 0)
		{
			Character character3 = this.character;
			((MeFooterNavigation)(object)character3._squeezeCollider).OnClickButton((Transform)(object)this);
			isLowrider = false;
		}
		if (~(isHighSpeedBoard ? 1u : 0u) == 0)
		{
			if (this.m_OnSpeedEnd != null)
			{
				this.m_OnSpeedEnd();
			}
			nint num5 = (nint)typeof(Game);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ S0_v59 (Il2CppClass<SYBO.Subway.Game>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num6 = (nint)typeof(Game);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ S0_v66 (Il2CppClass<SYBO.Subway.Game>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool isInstantiated = Game.IsInstantiated;
			((Game)isInstantiated).PickupJetpack();
			isHighSpeedBoard = false;
		}
		if (~(isSpeedBoard ? 1u : 0u) == 0)
		{
			if (this.m_OnSpeedEnd != null)
			{
				this.m_OnSpeedEnd();
			}
			nint num7 = (nint)typeof(Game);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ S0_v42 (Il2CppClass<SYBO.Subway.Game>)+BA]");
			object obj4 = (nint)0 & (nint)0x200;
			if (obj4 != null)
			{
				nint num8 = (nint)typeof(Game);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v164 @ S0_v49 (Il2CppClass<SYBO.Subway.Game>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool isInstantiated2 = Game.IsInstantiated;
			((Game)isInstantiated2).PickupJetpack();
			isSpeedBoard = false;
		}
		if (~(isGlider ? 1u : 0u) == 0)
		{
			isGlider = false;
			VariableBool longMagnetSuction2 = longMagnet.LongMagnetSuction;
			if (longMagnetSuction2 == null)
			{
				longMagnet._002Ector();
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

	public override void Pause()
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(So);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<So>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(So);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v14 (Il2CppClass<So>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		HoverboardBundle hoverboardBundle = ((CharacterModel)(object)So.Instance).AddHoverboard((string)(object)CrashSound, false);
	}

	public override void Resume()
	{
		//IL_003e: Expected Obj, but got I4
		//IL_0069: Expected I, but got Obj
		//IL_007f: Expected Obj, but got I
		//IL_0126: Expected Obj, but got I4
		//IL_00aa: Expected I, but got Obj
		base._paused = true;
		if (_powerup != null)
		{
			ActivePowerup powerup = _powerup;
			powerup.Paused = true;
		}
		PlayCrashSound();
		Boards.BoardId previousBoardId = PlayerSave.previousBoardId;
		bool flag = previousBoardId == Boards.BoardId.speedboard;
		Boards.BoardId previousBoardId2 = PlayerSave.previousBoardId;
		bool flag2 = previousBoardId2 == Boards.BoardId.hotrod;
		object obj = flag | flag2;
		if (obj == null)
		{
			return;
		}
		nint num = (nint)typeof(Game);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v16 (Il2CppClass<SYBO.Subway.Game>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(Game);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ S0_v22 (Il2CppClass<SYBO.Subway.Game>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool isInstantiated = Game.IsInstantiated;
		((Game)isInstantiated).PickupJetpack();
	}

	private void FinishRandomBoard()
	{
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Expected Obj, but got Unknown
		base._paused = false;
		if (_powerup != null)
		{
			ActivePowerup powerup = _powerup;
			powerup.Paused = false;
		}
		ActivePowerup powerup2 = _powerup;
		if (powerup2.timeLeft > 0f)
		{
			Character character = this.character;
			if (~(_isARewardFromMysteryPowerup ? 1u : 0u) == 0)
			{
				object obj = this + 96;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
				throw new NullReferenceException();
			}
			HoverboardBundle collider = character._characterModel.AddRandomHoverboard();
			((LongMagnet)(object)this).CoinHit((Collider)(object)collider);
		}
	}

	public override void ExpireSoon()
	{
		_currentRandomBoard = Boards.BoardId.normal;
	}

	public void HardReset()
	{
		//IL_006a: Expected I, but got Obj
		//IL_0080: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		ActivePowerup powerup = _powerup;
		nint num = (nint)typeof(CharacterModifierCollection);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S1_v3 (Il2CppClass<CharacterModifierCollection>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(CharacterModifierCollection);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v10 (Il2CppClass<CharacterModifierCollection>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		powerup.timeLeft = CharacterModifierCollection.TIME_LEFT_FOR_EXPIRE_SOON;
	}

	private void RaiseOnEndHoverboard()
	{
		isActive = false;
		_isInCooldown = false;
		if (OnboardingSave.numberOfRunsSinceLastGuideline != 0)
		{
			__isAllowed = true;
		}
		else
		{
			__isAllowed = false;
		}
		_isARewardFromMysteryPowerup = false;
		_currentRandomBoard = Boards.BoardId.normal;
	}

	public Hoverboard()
	{
		if (this.m_OnEndHoverboard != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @78B7");
		}
	}
}
