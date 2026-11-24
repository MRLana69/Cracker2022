using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using Cpp2ILInjected;
using Data.Save;
using Info;
using Kiloo.Common.Extensions;
using Missions;
using SYBO.Components.Utilities;
using SYBO.Subway;
using SYBO.Subway.Info;
using SYBO.Subway.Pickups;
using UI.Screens.RewardManagement;
using UnityEngine;

public class GameStats
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Comparison<ActivePowerup> _003C_003E9__116_0;

		public static Comparison<ActivePowerup> _003C_003E9__121_0;

		static _003C_003Ec()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			ColorTeleboardMenuEffect._003C_003Ec obj = default;
			ColorTeleboardMenuEffect._003C_003Ec._003C_003E9 = obj;
		}

		public _003C_003Ec()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			NullReferenceException ex = default;
			ex._002Ector();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}

		internal int _003CTriggerPowerup_003Eb__116_0(ActivePowerup a, ActivePowerup b)
		{
			//IL_0009: Expected Obj, but got I4
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120A3");
			int result = default;
			return result;
		}

		internal int _003CUpdatePowerupTimes_003Eb__121_0(ActivePowerup a, ActivePowerup b)
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			object obj = b + 12;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D9CC");
			int result = default;
			return result;
		}
	}

	private const int SCORE_FOR_PICKUPS = 30;

	private const int AMOUNT_BY_WHICH_EXTRA_SCORE_IS_CONSUMED = 4;

	private const float HOVERBOARD_COOLDOWN = 5f;

	public bool BragNotifyDone;

	public bool BragFacebookDone;

	private Action m_OnCoinsChanged;

	private Action<int> m_OnCoinsIncreased;

	private Action m_OnScoreChanged;

	private Action m_OnJumpsChanged;

	private Action m_OnRollsChanged;

	private Action<UpgradeType> m_PowerupTriggered;

	private Action m_OnMysteryBoxPickup;

	private Action m_OnSuperMysteryBoxPickup;

	private int _coinsSpawned;

	private int _coinsSpawnedRun;

	private int _coinsCollectedRaw;

	private int _coinsCollectedRawRun;

	private int _xoredNumberOfCoinsCollected;

	private int _xoredNumberOfCoinsRun;

	private int _coinMultiplier;

	private int _coinsWithJetpack;

	private int _coinsWithPogoStick;

	private int _coinsInAir;

	private int _coinCollectedOnLeftTrack;

	private int _coinsCollectedOnCenterTrack;

	private int _coinsCollectedOnRightTrack;

	private int _coinsWithCoinMagnetCount;

	private bool _scoreBoosterActivated;

	private int _scoreBoosterTier;

	private int _scoreBoosterTierRun;

	private bool _characterDayEventActivated;

	private int _score;

	private float _metersLastUsedForScore;

	private float _meterScore;

	private int _amountLeftToConsume;

	private bool _isPausedPowerups;

	private Dictionary<int, int> _spawnedPickupsLastRun;

	private Dictionary<int, int> _powerupActivationCountsLastRun;

	private Dictionary<int, int> _mysteryPowerupActivationCountsLastRun;

	private List<ActivePowerup> _listOfActivePowerups;

	private Dictionary<UpgradeType, bool> _missionEachPowerupPickupStatus;

	private float _metersInCurrentGame;

	private int _stumbles;

	private int _stumblesRun;

	private int _jumps;

	private int _jumpsOverTrainsCount;

	private int _rollCount;

	private int _rollsLeftTrackCount;

	private int _rollsCenterTrackCount;

	private int _rollsRightTrackCount;

	private int _dodgeBarrierCount;

	private int _jumpBarrierCount;

	private int _jumpHighBarrierCount;

	private int _trainHitCount;

	private int _movingTrainHit;

	private int _barrierHitCount;

	private int _jetpackPickupsCollected;

	private int _jetpackPickupsCollectedRun;

	private int _superSneakerPickupsCollected;

	private int _superSneakerPickupsCollectedRun;

	private int _pogoStickPickupsCollected;

	private int _pogoStickPickupsCollectedRun;

	private int _dailyLetterPickupsCollected;

	private int _dailyLetterPickupsCollectedRun;

	private int _characterLetterPickupsCollected;

	private int _characterLetterPickupsCollectedRun;

	private int _coinMagnetPickupsCollected;

	private int _coinMagnetPickupsCollectedRun;

	private int _mysteryBoxPickupsCollected;

	private int _mysteryBoxPickupsCollectedRun;

	private int _superMysteryBoxPickupsCollected;

	private int _superMysteryBoxPickupsCollectedRun;

	private int _doubleMultiplierPickupsCollected;

	private int _doubleMultiplierPickupsCollectedRun;

	private int _huntTokensCollected;

	private int _huntTokensCollectedRun;

	private int _pickedUpPowerups;

	private int _keyPickupsCollected;

	private int _keyPickupsCollectedRun;

	private static GameStats instance;

	public unsafe int CoinsSpawned
	{
		get
		{
			//IL_0050: Invalid comparison between VT and I4
			int num = ConsumeAmountNeededToAdjustScoreBy(45);
			_0021_00210 eventValue = (_0021_00210)((ExpiredLimitedBoardEventManager)(object)this.m_OnCoinsChanged).GetEventValue<T>(out *(bool*)num);
			if (eventValue != (_0021_00210)(object)0)
			{
				return PlayerSave.GetStatValue((Stat)num);
			}
			return 0;
		}
	}

	public int CoinsSpawnedRun => _coinsSpawned;

	public int CoinsCollectedRaw => _coinsSpawnedRun;

	public int CoinsCollectedRawRun => _coinsCollectedRaw;

	public int CoinsCollected
	{
		get
		{
			return _coinsCollectedRawRun;
		}
		private set
		{
			//IL_0066: Expected Obj, but got I4
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected Obj, but got Unknown
			Delegate obj = this.m_OnSuperMysteryBoxPickup;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.RemoveImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				object obj3 = this + 40;
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

	public int CoinsCollectedRun
	{
		get
		{
			//IL_0060: Expected I, but got Obj
			//IL_0076: Expected Obj, but got I
			//IL_00a2: Expected I4, but got Obj
			//IL_0013: Expected I, but got Obj
			nint num = (nint)typeof(Utils);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S1_v3 (Il2CppClass<Utils>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(Utils);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v8 (Il2CppClass<Utils>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			return (int)Utils.GetIntBinaryString(_xoredNumberOfCoinsCollected);
		}
		private set
		{
			//IL_0095: Unknown result type (might be due to invalid IL or missing references)
			//IL_009a: Expected Obj, but got Unknown
			//IL_00c8: Expected Obj, but got I4
			//IL_00c8: Expected Obj, but got I4
			//IL_00c8: Expected Obj, but got I4
			if (value >= 1)
			{
				int coinsCollectedRun = CoinsCollectedRun;
				int count = value + coinsCollectedRun;
				CoinsCollectedIncrement(count);
				int coinMultiplier = CoinMultiplier;
				bool scoreBoosterActivated = (byte)(value + coinMultiplier) != 0;
				ScoreBoosterActivated = scoreBoosterActivated;
				if (this.m_OnCoinsIncreased != null)
				{
					this.m_OnCoinsIncreased(value);
				}
				List<CelebrationReward> pendingRewards = InventorySave.pendingRewards;
				CelebrationReward lastAddedReward = (CelebrationReward)(value + pendingRewards);
				InventorySave.lastAddedReward = lastAddedReward;
				StayInOneLaneMission stayInOneLaneMission = StayInOneLaneMission.instance;
				((OwnBoardsAward)(object)stayInOneLaneMission)._002Ector((AwardStaticData)1, (PersistentAwardProgress)value, (Action<Award>)(-1));
				StayInOneLaneMission stayInOneLaneMission2 = StayInOneLaneMission.instance;
				((MissionsManager)(object)stayInOneLaneMission2).ResetProgressForMissionIndex(36);
			}
		}
	}

	public int CoinMultiplier
	{
		get
		{
			//IL_0058: Unknown result type (might be due to invalid IL or missing references)
			//IL_005d: Expected Obj, but got Unknown
			//IL_006b: Expected I, but got Obj
			//IL_0081: Expected Obj, but got I
			//IL_00a7: Expected I4, but got Obj
			//IL_00ab: Expected I4, but got Obj
			//IL_0013: Expected I, but got Obj
			object obj = this - -64;
			nint num = (nint)typeof(Utils);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S1_v4 (Il2CppClass<Utils>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num2 = (nint)typeof(Utils);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S1_v9 (Il2CppClass<Utils>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			return (int)Utils.GetIntBinaryString((int)obj);
		}
	}

	public int CoinsWithJetpack
	{
		get
		{
			//IL_016c: Expected I, but got Obj
			//IL_0182: Expected Obj, but got I
			//IL_01eb: Expected I, but got Obj
			//IL_0201: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			//IL_00ff: Expected I, but got Obj
			//IL_0079: Expected I, but got Obj
			nint num = (nint)typeof(UserSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Data.Save.UserSave>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(UserSave);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v42 (Il2CppClass<Data.Save.UserSave>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Dictionary<Characters.CharacterId, bool> hasCharacterBeenSeen = UserSave.hasCharacterBeenSeen;
			nint num3 = (nint)typeof(DoubleCoins);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S1_v4 (Il2CppClass<DoubleCoins>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			bool flag = obj2 != null;
			if (hasCharacterBeenSeen != null)
			{
				if (flag)
				{
					nint num4 = (nint)typeof(DoubleCoins);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S0_v36 (Il2CppClass<DoubleCoins>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				if (~(DoubleCoins.HasDoubleCoinsModifier ? 1u : 0u) == 0)
				{
					_coinMultiplier = 4;
				}
				else
				{
					_coinMultiplier = 2;
				}
			}
			else
			{
				if (flag)
				{
					nint num5 = (nint)typeof(DoubleCoins);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ S0_v22 (Il2CppClass<DoubleCoins>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				if (~(DoubleCoins.HasDoubleCoinsModifier ? 1u : 0u) == 0)
				{
					_coinMultiplier = 2;
				}
				else
				{
					_coinMultiplier = 1;
				}
			}
			return _coinMultiplier;
		}
	}

	public bool ScoreBoosterActivated
	{
		get
		{
			return (byte)_coinsWithJetpack != 0;
		}
		set
		{
			//IL_0060: Expected I, but got Obj
			//IL_0076: Expected Obj, but got I
			//IL_0099: Unknown result type (might be due to invalid IL or missing references)
			//IL_009e: Expected Obj, but got Unknown
			//IL_0013: Expected I, but got Obj
			nint num = (nint)typeof(Utils);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Utils>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(Utils);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v12 (Il2CppClass<Utils>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			object obj2 = this - -64;
			string intBinaryString = Utils.GetIntBinaryString(value ? 1 : 0);
			obj2 = intBinaryString;
		}
	}

	public int ScoreBoosterTier
	{
		get
		{
			return _scoreBoosterActivated ? 1 : 0;
		}
		private set
		{
			int scoreBoosterActivated = value & 1;
			_scoreBoosterActivated = (byte)scoreBoosterActivated != 0;
		}
	}

	public int ScoreBoosterTierRun => _scoreBoosterTier;

	public bool CharacterDayEventActivated
	{
		get
		{
			return (byte)_scoreBoosterTierRun != 0;
		}
		set
		{
			//IL_006a: Expected I, but got Obj
			//IL_0080: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			_scoreBoosterTier = (value ? 1 : 0);
			nint num = (nint)typeof(ScoreMultiplierInfo);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ S0_v7 (Il2CppClass<Info.ScoreMultiplierInfo>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(ScoreMultiplierInfo);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S0_v12 (Il2CppClass<Info.ScoreMultiplierInfo>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			ScoreMultiplierInfo._002Ecctor();
		}
	}

	public bool IsPausedPowerups
	{
		get
		{
			return _characterDayEventActivated;
		}
		set
		{
			//IL_006a: Expected I, but got Obj
			//IL_0080: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			_characterDayEventActivated = value;
			nint num = (nint)typeof(ScoreMultiplierInfo);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v7 (Il2CppClass<Info.ScoreMultiplierInfo>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(ScoreMultiplierInfo);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v12 (Il2CppClass<Info.ScoreMultiplierInfo>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			ScoreMultiplierInfo._002Ecctor();
		}
	}

	public int Score => _isPausedPowerups ? 1 : 0;

	public Dictionary<UpgradeType, bool> MissionEachPowerupPickupStatus
	{
		get
		{
			//IL_0007: Expected Obj, but got I4
			return (Dictionary<UpgradeType, bool>)_score;
		}
	}

	public float MetersInCurrentGame
	{
		get
		{
			//IL_0017: Expected F4, but got I
			string debugText = ((CurveParent)this).GetDebugText();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.String)+2C]");
			return 0f;
		}
		set
		{
			//IL_0042: Expected I, but got Obj
			//IL_0058: Expected Obj, but got I
			//IL_0974: Expected Obj, but got I4
			//IL_0083: Expected I, but got Obj
			//IL_00d0: Expected I, but got Obj
			//IL_00e6: Expected Obj, but got I
			//IL_09ae: Expected Obj, but got I4
			//IL_0111: Expected I, but got Obj
			//IL_0210: Expected I, but got Obj
			//IL_0226: Expected Obj, but got I
			//IL_032c: Expected I, but got Obj
			//IL_0342: Expected Obj, but got I
			//IL_0a16: Expected Obj, but got I
			//IL_0a26: Expected Obj, but got I
			//IL_0a90: Expected Obj, but got I
			//IL_0aa0: Expected Obj, but got I
			//IL_0251: Expected I, but got Obj
			//IL_050d: Expected I, but got Obj
			//IL_0523: Expected Obj, but got I
			//IL_036d: Expected I, but got Obj
			//IL_029e: Expected I, but got Obj
			//IL_02b4: Expected Obj, but got I
			//IL_0b45: Expected Obj, but got I4
			//IL_03ba: Expected I, but got Obj
			//IL_03d0: Expected Obj, but got I
			//IL_054e: Expected I, but got Obj
			//IL_02df: Expected I, but got Obj
			//IL_03fb: Expected I, but got Obj
			//IL_05c1: Expected I, but got Obj
			//IL_05d7: Expected Obj, but got I
			//IL_0b74: Expected Obj, but got I4
			//IL_0602: Expected I, but got Obj
			//IL_07af: Expected I, but got Obj
			//IL_07c5: Expected Obj, but got I
			//IL_069e: Expected I, but got Obj
			//IL_06b4: Expected Obj, but got I
			//IL_07f0: Expected I, but got Obj
			//IL_0bbb: Expected Obj, but got F4
			//IL_0bc8: Invalid comparison between F4 and Obj
			//IL_083d: Expected I, but got Obj
			//IL_0853: Expected Obj, but got I
			//IL_06df: Expected I, but got Obj
			//IL_0c3d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0c42: Expected Obj, but got Unknown
			//IL_0c59: Expected I, but got Obj
			//IL_0c6f: Expected Obj, but got I
			//IL_072c: Expected I, but got Obj
			//IL_0742: Expected Obj, but got I
			//IL_087e: Expected I, but got Obj
			//IL_076d: Expected I, but got Obj
			if (~(_isPausedPowerups ? 1u : 0u) == 0)
			{
				return;
			}
			List<ActivePowerup> listOfActivePowerups = _listOfActivePowerups;
			int num = listOfActivePowerups._size;
			while (true)
			{
				int num2 = num - 1;
				if (num2 < 0)
				{
					return;
				}
				ActivePowerup activePowerup = _listOfActivePowerups.get_Item(num2);
				nint num3 = (nint)typeof(Game);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ S0_v22 (Il2CppClass<SYBO.Subway.Game>)+BA]");
				object obj = (nint)0 & (nint)0x200;
				if (obj != null)
				{
					nint num4 = (nint)typeof(Game);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ S0_v227 (Il2CppClass<SYBO.Subway.Game>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				bool isInstantiated = Game.IsInstantiated;
				if (!((Game)isInstantiated).IsInPogostickMode)
				{
					nint num5 = (nint)typeof(Game);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ S0_v215 (Il2CppClass<SYBO.Subway.Game>)+BA]");
					object obj2 = (nint)0 & (nint)0x200;
					if (obj2 != null)
					{
						nint num6 = (nint)typeof(Game);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ S0_v223 (Il2CppClass<SYBO.Subway.Game>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					bool isInstantiated2 = Game.IsInstantiated;
					if (!((Game)isInstantiated2).HasSuperSneakers)
					{
						goto IL_01d5;
					}
				}
				if (activePowerup.type == UpgradeType.hoverboard || activePowerup.type == UpgradeType.supersneakers || activePowerup.type == UpgradeType.doubleJump)
				{
					goto IL_0a6a;
				}
				goto IL_01d5;
				IL_0ae4:
				float num7;
				if (activePowerup.type != UpgradeType.jetpack && activePowerup.type != UpgradeType.headstart2000)
				{
					float timeLeft = activePowerup.timeLeft - num7;
					activePowerup.timeLeft = timeLeft;
				}
				else
				{
					nint num8 = (nint)typeof(Game);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v293 @ S0_v127 (Il2CppClass<SYBO.Subway.Game>)+BA]");
					object obj3 = (nint)0 & (nint)0x200;
					if (obj3 != null)
					{
						nint num9 = (nint)typeof(Game);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v312 @ S0_v136 (Il2CppClass<SYBO.Subway.Game>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					bool isInstantiated3 = Game.IsInstantiated;
					if (((Game)isInstantiated3).IsInPogostickMode)
					{
						activePowerup.timeLeft = 1f;
					}
					else
					{
						activePowerup.timeLeft = -1f;
					}
				}
				if (activePowerup.timeLeft < 0f)
				{
					nint num10 = (nint)typeof(Game);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v334 @ S0_v51 (Il2CppClass<SYBO.Subway.Game>)+BA]");
					object obj4 = (nint)0 & (nint)0x200;
					if (obj4 != null)
					{
						nint num11 = (nint)typeof(Game);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v339 @ S0_v121 (Il2CppClass<SYBO.Subway.Game>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					bool isInstantiated4 = Game.IsInstantiated;
					if (!((Game)isInstantiated4).IsInPogostickMode || activePowerup.type != UpgradeType.jetpack)
					{
						if (activePowerup.type == UpgradeType.hoverboard)
						{
							nint num12 = (nint)typeof(Hoverboard);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v360 @ S0_v93 (Il2CppClass<Hoverboard>)+BA]");
							object obj5 = (nint)0 & (nint)0x200;
							if (obj5 != null)
							{
								nint num13 = (nint)typeof(Hoverboard);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v379 @ S0_v114 (Il2CppClass<Hoverboard>)+74]");
								if ((nint)0 == 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
								}
							}
							CharacterModifier characterModifier = MysteryPowerup.SelectRandomCharacterModifier();
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v386 @ S0_v98 (CharacterModifier)+44]");
							float num14 = 0f + 5f;
							object obj6 = 0f - num14;
							float timeLeft2 = activePowerup.timeLeft;
							if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)timeLeft2) > System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj6))
							{
								goto IL_0a6a;
							}
							nint num15 = (nint)typeof(Hoverboard);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v418 @ S0_v105 (Il2CppClass<Hoverboard>)+BA]");
							object obj7 = (nint)0 & (nint)0x200;
							if (obj7 != null)
							{
								nint num16 = (nint)typeof(Hoverboard);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v443 @ S0_v111 (Il2CppClass<Hoverboard>)+74]");
								if ((nint)0 == 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
								}
							}
							CharacterModifier characterModifier2 = MysteryPowerup.SelectRandomCharacterModifier();
							((Hoverboard)characterModifier2).RaiseOnEndHoverboard();
						}
						_listOfActivePowerups.RemoveAt(num2);
						nint num17 = (nint)typeof(_003C_003Ec);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v390 @ S1_v26 (Il2CppClass<GameStats+<>c>)+BA]");
						object obj8 = (nint)0 & (nint)0x200;
						if (obj8 != null)
						{
							nint num18 = (nint)typeof(_003C_003Ec);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v402 @ S1_v73 (Il2CppClass<GameStats+<>c>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						break;
					}
				}
				goto IL_0a6a;
				IL_0a6a:
				num = num2;
				continue;
				IL_01d5:
				if (activePowerup.type == UpgradeType.supersneakers)
				{
					nint num19 = (nint)typeof(Game);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v188 @ S0_v178 (Il2CppClass<SYBO.Subway.Game>)+BA]");
					object obj9 = (nint)0 & (nint)0x200;
					if (obj9 != null)
					{
						nint num20 = (nint)typeof(Game);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v205 @ S0_v199 (Il2CppClass<SYBO.Subway.Game>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					bool isInstantiated5 = Game.IsInstantiated;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v213 @ S0_v183 (System.Boolean)+8C]");
					object obj10 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v230 @ S0_v184+14]");
					object obj11 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v231 @ S0_v185+54]");
					if ((nint)0 != 0)
					{
						nint num21 = (nint)typeof(Hoverboard);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v249 @ S0_v188 (Il2CppClass<Hoverboard>)+BA]");
						object obj12 = (nint)0 & (nint)0x200;
						if (obj12 != null)
						{
							nint num22 = (nint)typeof(Hoverboard);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v273 @ S0_v195 (Il2CppClass<Hoverboard>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						CharacterModifier characterModifier3 = MysteryPowerup.SelectRandomCharacterModifier();
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v280 @ S0_v193 (CharacterModifier)+20]");
						if ((nint)0 != 0)
						{
							goto IL_0a6a;
						}
					}
				}
				if (activePowerup.type == UpgradeType.doubleJump)
				{
					nint num23 = (nint)typeof(Game);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v215 @ S0_v152 (Il2CppClass<SYBO.Subway.Game>)+BA]");
					object obj13 = (nint)0 & (nint)0x200;
					if (obj13 != null)
					{
						nint num24 = (nint)typeof(Game);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v232 @ S0_v173 (Il2CppClass<SYBO.Subway.Game>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					bool isInstantiated6 = Game.IsInstantiated;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v240 @ S0_v157 (System.Boolean)+8C]");
					object obj14 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v253 @ S0_v158+14]");
					object obj15 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v254 @ S0_v159+54]");
					if ((nint)0 != 0)
					{
						nint num25 = (nint)typeof(Hoverboard);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v282 @ S0_v162 (Il2CppClass<Hoverboard>)+BA]");
						object obj16 = (nint)0 & (nint)0x200;
						if (obj16 != null)
						{
							nint num26 = (nint)typeof(Hoverboard);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v299 @ S0_v169 (Il2CppClass<Hoverboard>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						CharacterModifier characterModifier4 = MysteryPowerup.SelectRandomCharacterModifier();
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v306 @ S0_v167 (CharacterModifier)+27]");
						if ((nint)0 != 0)
						{
							goto IL_0a6a;
						}
					}
				}
				if (~(activePowerup.Paused ? 1u : 0u) == 0)
				{
					if (activePowerup.type == UpgradeType.hoverboard)
					{
						bool flag = activePowerup.timeLeft > 0f;
						bool flag2 = !flag;
						num7 = value;
						if (flag2)
						{
							goto IL_0ae4;
						}
					}
					num7 = 0f;
				}
				else
				{
					num7 = value;
				}
				goto IL_0ae4;
			}
			if (_003C_003Ec._003C_003E9__121_0 == null)
			{
				nint num27 = (nint)typeof(_003C_003Ec);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v424 @ S1_v48 (Il2CppClass<GameStats+<>c>)+BA]");
				object obj17 = (nint)0 & (nint)0x200;
				if (obj17 != null)
				{
					nint num28 = (nint)typeof(_003C_003Ec);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v449 @ S1_v68 (Il2CppClass<GameStats+<>c>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				nint num29 = 0;
				_ = 0;
				object obj19 = default;
				object obj18 = obj19 + 16;
				obj18 = _003C_003Ec._003C_003E9;
				nint num30 = (nint)typeof(_003C_003Ec);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v477 @ S1_v65 (Il2CppClass<GameStats+<>c>)+5C]");
				object obj20 = (nint)0 + (nint)8;
				obj20 = obj19;
			}
			throw new NullReferenceException();
		}
	}

	public int Stumbles
	{
		get
		{
			//IL_0007: Expected I4, but got Obj
			return (int)_listOfActivePowerups;
		}
	}

	public int StumblesRun => _stumbles;

	public int JumpsOverTrainsCount => _stumblesRun;

	public int RollCount
	{
		get
		{
			return _jumpsOverTrainsCount;
		}
		private set
		{
			//IL_011d: Expected I, but got Obj
			//IL_0133: Expected Obj, but got I
			//IL_0167: Expected Obj, but got I4
			//IL_0171: Unknown result type (might be due to invalid IL or missing references)
			//IL_0176: Expected I4, but got Unknown
			//IL_01a0: Expected Obj, but got I4
			//IL_01a0: Expected Obj, but got I4
			//IL_0072: Expected Obj, but got I4
			//IL_0072: Expected Obj, but got I4
			//IL_0013: Expected I, but got Obj
			//IL_0097: Expected Obj, but got I4
			//IL_0097: Expected Obj, but got I4
			//IL_00bc: Expected Obj, but got I4
			//IL_00bc: Expected Obj, but got I4
			//IL_0109: Expected Obj, but got I4
			//IL_0109: Expected Obj, but got I4
			nint num = (nint)typeof(ScoreMultiplierInfo);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Info.ScoreMultiplierInfo>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(ScoreMultiplierInfo);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v24 (Il2CppClass<Info.ScoreMultiplierInfo>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			int rawMultiplier = ScoreMultiplierInfo.rawMultiplier;
			PersistentAwardProgress persistentAwardProgress = (PersistentAwardProgress)(rawMultiplier * 30);
			int score = persistentAwardProgress + _score;
			_score = score;
			StayInOneLaneMission stayInOneLaneMission = StayInOneLaneMission.instance;
			((OwnBoardsAward)(object)stayInOneLaneMission)._002Ector((AwardStaticData)3, persistentAwardProgress, (Action<Award>)(-1));
			StayInOneLaneMission stayInOneLaneMission2 = StayInOneLaneMission.instance;
			((OwnBoardsAward)(object)stayInOneLaneMission2)._002Ector((AwardStaticData)36, persistentAwardProgress, (Action<Award>)(-1));
			StayInOneLaneMission stayInOneLaneMission3 = StayInOneLaneMission.instance;
			((OwnBoardsAward)(object)stayInOneLaneMission3)._002Ector((AwardStaticData)64, persistentAwardProgress, (Action<Award>)(-1));
			StayInOneLaneMission stayInOneLaneMission4 = StayInOneLaneMission.instance;
			((OwnBoardsAward)(object)stayInOneLaneMission4)._002Ector((AwardStaticData)63, persistentAwardProgress, (Action<Award>)(-1));
			if (value == 0)
			{
				StayInOneLaneMission stayInOneLaneMission5 = StayInOneLaneMission.instance;
				((OwnBoardsAward)(object)stayInOneLaneMission5)._002Ector((AwardStaticData)65, persistentAwardProgress, (Action<Award>)(-1));
			}
		}
	}

	public int JumpHighBarrierCount => _rollCount;

	public int MovingTrainHitCount
	{
		get
		{
			return _jumpHighBarrierCount;
		}
		set
		{
			_rollCount = value;
			if (this.m_OnRollsChanged != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @78B7");
			}
		}
	}

	public int JetpackPickupsCollected
	{
		get
		{
			return _movingTrainHit;
		}
		private set
		{
			//IL_0048: Expected Obj, but got I4
			//IL_0048: Expected Obj, but got I4
			//IL_0048: Expected Obj, but got I4
			//IL_006e: Expected Obj, but got I4
			//IL_006e: Expected Obj, but got I4
			//IL_006e: Expected Obj, but got I4
			_movingTrainHit = value;
			if (value != 0)
			{
				StayInOneLaneMission stayInOneLaneMission = StayInOneLaneMission.instance;
				((OwnBoardsAward)(object)stayInOneLaneMission)._002Ector((AwardStaticData)12, (PersistentAwardProgress)1, (Action<Award>)(-1));
				StayInOneLaneMission stayInOneLaneMission2 = StayInOneLaneMission.instance;
				((OwnBoardsAward)(object)stayInOneLaneMission2)._002Ector((AwardStaticData)23, (PersistentAwardProgress)1, (Action<Award>)(-1));
			}
		}
	}

	public int JetpackPickupsCollectedRun => _jetpackPickupsCollected;

	public int SuperSneakerPickupsCollected
	{
		get
		{
			return _jetpackPickupsCollectedRun;
		}
		private set
		{
			//IL_001b: Expected Obj, but got I
			//IL_002b: Expected Obj, but got I
			//IL_003b: Expected Obj, but got I
			//IL_0044: Unknown result type (might be due to invalid IL or missing references)
			//IL_0049: Expected Obj, but got Unknown
			//IL_0052: Unknown result type (might be due to invalid IL or missing references)
			//IL_0057: Expected Obj, but got Unknown
			//IL_0100: Expected Obj, but got I
			//IL_0110: Expected Obj, but got I
			//IL_0120: Expected Obj, but got I
			//IL_0129: Unknown result type (might be due to invalid IL or missing references)
			//IL_012e: Expected Obj, but got Unknown
			//IL_0137: Unknown result type (might be due to invalid IL or missing references)
			//IL_013c: Expected Obj, but got Unknown
			//IL_009f: Expected Obj, but got I
			//IL_00af: Expected Obj, but got I
			//IL_00bf: Expected Obj, but got I
			//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
			//IL_00cd: Expected Obj, but got Unknown
			//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
			//IL_00db: Expected Obj, but got Unknown
			_jetpackPickupsCollected = value;
			if (value == 0)
			{
				nint num = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S2_v3 (Il2CppMethodInfo)+C]");
				object obj = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S2_v4+60]");
				object obj2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S2_v5+44]");
				object obj3 = 0;
				object obj4 = obj3 & 0x1FFF;
				object obj5 = obj4 + 22691;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v32 @ S3_v5 (should have been resolved before IL gen)");
				object obj6 = default;
				if ((nint)obj6 > -1)
				{
					nint num2 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ S4_v10 (Il2CppMethodInfo)+C]");
					object obj7 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ S4_v11+60]");
					object obj8 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ S4_v12+48]");
					object obj9 = 0;
					object obj10 = obj9 & 0x7FF;
					object obj11 = obj10 + 39195;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v47 @ S5_v9 (should have been resolved before IL gen)");
				}
				else
				{
					nint num3 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ S4_v5 (Il2CppMethodInfo)+C]");
					object obj12 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ S4_v6+60]");
					object obj13 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ S4_v7+48]");
					object obj14 = 0;
					object obj15 = obj14 & 0x7FF;
					object obj16 = obj15 + 39195;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v46 @ S5_v5 (should have been resolved before IL gen)");
				}
			}
		}
	}

	public int SuperSneakerPickupsCollectedRun => _superSneakerPickupsCollected;

	public int PogoStickPickupsCollected
	{
		get
		{
			return _superSneakerPickupsCollectedRun;
		}
		private set
		{
			//IL_001b: Expected Obj, but got I
			//IL_002b: Expected Obj, but got I
			//IL_003b: Expected Obj, but got I
			//IL_0044: Unknown result type (might be due to invalid IL or missing references)
			//IL_0049: Expected Obj, but got Unknown
			//IL_0052: Unknown result type (might be due to invalid IL or missing references)
			//IL_0057: Expected Obj, but got Unknown
			//IL_0100: Expected Obj, but got I
			//IL_0110: Expected Obj, but got I
			//IL_0120: Expected Obj, but got I
			//IL_0129: Unknown result type (might be due to invalid IL or missing references)
			//IL_012e: Expected Obj, but got Unknown
			//IL_0137: Unknown result type (might be due to invalid IL or missing references)
			//IL_013c: Expected Obj, but got Unknown
			//IL_009f: Expected Obj, but got I
			//IL_00af: Expected Obj, but got I
			//IL_00bf: Expected Obj, but got I
			//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
			//IL_00cd: Expected Obj, but got Unknown
			//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
			//IL_00db: Expected Obj, but got Unknown
			_superSneakerPickupsCollected = value;
			if (value == 0)
			{
				nint num = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S2_v3 (Il2CppMethodInfo)+C]");
				object obj = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S2_v4+60]");
				object obj2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S2_v5+44]");
				object obj3 = 0;
				object obj4 = obj3 & 0x1FFF;
				object obj5 = obj4 + 22691;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v32 @ S3_v5 (should have been resolved before IL gen)");
				object obj6 = default;
				if ((nint)obj6 > -1)
				{
					nint num2 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ S4_v10 (Il2CppMethodInfo)+C]");
					object obj7 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ S4_v11+60]");
					object obj8 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ S4_v12+48]");
					object obj9 = 0;
					object obj10 = obj9 & 0x7FF;
					object obj11 = obj10 + 39195;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v47 @ S5_v9 (should have been resolved before IL gen)");
				}
				else
				{
					nint num3 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ S4_v5 (Il2CppMethodInfo)+C]");
					object obj12 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ S4_v6+60]");
					object obj13 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ S4_v7+48]");
					object obj14 = 0;
					object obj15 = obj14 & 0x7FF;
					object obj16 = obj15 + 39195;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v46 @ S5_v5 (should have been resolved before IL gen)");
				}
			}
		}
	}

	public int PogoStickPickupsCollectedRun => _pogoStickPickupsCollected;

	public int DailyLetterPickupsCollected => _pogoStickPickupsCollectedRun;

	public int DailyLetterPickupsCollectedRun => _dailyLetterPickupsCollected;

	public int CharacterLetterPickupsCollected => _dailyLetterPickupsCollectedRun;

	public int CharacterLetterPickupsCollectedRun => _characterLetterPickupsCollected;

	public int CoinMagnetPickupsCollected
	{
		get
		{
			return _characterLetterPickupsCollectedRun;
		}
		private set
		{
			//IL_001b: Expected Obj, but got I
			//IL_002b: Expected Obj, but got I
			//IL_003b: Expected Obj, but got I
			//IL_0044: Unknown result type (might be due to invalid IL or missing references)
			//IL_0049: Expected Obj, but got Unknown
			//IL_0052: Unknown result type (might be due to invalid IL or missing references)
			//IL_0057: Expected Obj, but got Unknown
			//IL_0100: Expected Obj, but got I
			//IL_0110: Expected Obj, but got I
			//IL_0120: Expected Obj, but got I
			//IL_0129: Unknown result type (might be due to invalid IL or missing references)
			//IL_012e: Expected Obj, but got Unknown
			//IL_0137: Unknown result type (might be due to invalid IL or missing references)
			//IL_013c: Expected Obj, but got Unknown
			//IL_009f: Expected Obj, but got I
			//IL_00af: Expected Obj, but got I
			//IL_00bf: Expected Obj, but got I
			//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
			//IL_00cd: Expected Obj, but got Unknown
			//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
			//IL_00db: Expected Obj, but got Unknown
			_pogoStickPickupsCollected = value;
			if (value == 0)
			{
				nint num = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S2_v3 (Il2CppMethodInfo)+C]");
				object obj = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S2_v4+60]");
				object obj2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S2_v5+44]");
				object obj3 = 0;
				object obj4 = obj3 & 0x1FFF;
				object obj5 = obj4 + 22691;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v32 @ S3_v5 (should have been resolved before IL gen)");
				object obj6 = default;
				if ((nint)obj6 > -1)
				{
					nint num2 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ S4_v10 (Il2CppMethodInfo)+C]");
					object obj7 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ S4_v11+60]");
					object obj8 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ S4_v12+48]");
					object obj9 = 0;
					object obj10 = obj9 & 0x7FF;
					object obj11 = obj10 + 39195;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v47 @ S5_v9 (should have been resolved before IL gen)");
				}
				else
				{
					nint num3 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ S4_v5 (Il2CppMethodInfo)+C]");
					object obj12 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ S4_v6+60]");
					object obj13 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ S4_v7+48]");
					object obj14 = 0;
					object obj15 = obj14 & 0x7FF;
					object obj16 = obj15 + 39195;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v46 @ S5_v5 (should have been resolved before IL gen)");
				}
			}
		}
	}

	public int CoinMagnetPickupsCollectedRun => _coinMagnetPickupsCollected;

	public int MysteryBoxPickupsCollected => _coinMagnetPickupsCollectedRun;

	public int MysteryBoxPickupsCollectedRun => _mysteryBoxPickupsCollected;

	public int SuperMysteryBoxPickupsCollected => _mysteryBoxPickupsCollectedRun;

	public int SuperMysteryBoxPickupsCollectedRun => _superMysteryBoxPickupsCollected;

	public int DoubleMultiplierPickupsCollected
	{
		get
		{
			return _superMysteryBoxPickupsCollectedRun;
		}
		private set
		{
			//IL_001b: Expected Obj, but got I
			//IL_002b: Expected Obj, but got I
			//IL_003b: Expected Obj, but got I
			//IL_0044: Unknown result type (might be due to invalid IL or missing references)
			//IL_0049: Expected Obj, but got Unknown
			//IL_0052: Unknown result type (might be due to invalid IL or missing references)
			//IL_0057: Expected Obj, but got Unknown
			//IL_0100: Expected Obj, but got I
			//IL_0110: Expected Obj, but got I
			//IL_0120: Expected Obj, but got I
			//IL_0129: Unknown result type (might be due to invalid IL or missing references)
			//IL_012e: Expected Obj, but got Unknown
			//IL_0137: Unknown result type (might be due to invalid IL or missing references)
			//IL_013c: Expected Obj, but got Unknown
			//IL_009f: Expected Obj, but got I
			//IL_00af: Expected Obj, but got I
			//IL_00bf: Expected Obj, but got I
			//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
			//IL_00cd: Expected Obj, but got Unknown
			//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
			//IL_00db: Expected Obj, but got Unknown
			_coinMagnetPickupsCollected = value;
			if (value == 0)
			{
				nint num = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S2_v3 (Il2CppMethodInfo)+C]");
				object obj = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S2_v4+60]");
				object obj2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S2_v5+44]");
				object obj3 = 0;
				object obj4 = obj3 & 0x1FFF;
				object obj5 = obj4 + 22691;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v32 @ S3_v5 (should have been resolved before IL gen)");
				object obj6 = default;
				if ((nint)obj6 > -1)
				{
					nint num2 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ S4_v10 (Il2CppMethodInfo)+C]");
					object obj7 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ S4_v11+60]");
					object obj8 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ S4_v12+48]");
					object obj9 = 0;
					object obj10 = obj9 & 0x7FF;
					object obj11 = obj10 + 39195;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v47 @ S5_v9 (should have been resolved before IL gen)");
				}
				else
				{
					nint num3 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ S4_v5 (Il2CppMethodInfo)+C]");
					object obj12 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ S4_v6+60]");
					object obj13 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ S4_v7+48]");
					object obj14 = 0;
					object obj15 = obj14 & 0x7FF;
					object obj16 = obj15 + 39195;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v46 @ S5_v5 (should have been resolved before IL gen)");
				}
			}
		}
	}

	public int DoubleMultiplierPickupsCollectedRun => _doubleMultiplierPickupsCollected;

	public int HuntTokensCollected => _doubleMultiplierPickupsCollectedRun;

	public int HuntTokensCollectedRun => _huntTokensCollected;

	public int KeyPickupsCollected => _huntTokensCollectedRun;

	public int KeyPickupsCollectedRun => _keyPickupsCollected;

	public static GameStats Instance
	{
		get
		{
			//IL_0433: Unknown result type (might be due to invalid IL or missing references)
			//IL_0438: Expected Obj, but got Unknown
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			object obj2 = default;
			object obj = obj2 + 8;
			obj = "DUMMY_FRIEND_NAME_1";
			_ = 0;
			_ = 0;
			throw new ArrayTypeMismatchException();
		}
	}

	public event Action OnCoinsChanged
	{
		add
		{
			((GliderAnimation)this).HandleOnHangtime();
		}
		remove
		{
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected Obj, but got Unknown
			Delegate obj = this.m_OnCoinsChanged;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.CombineImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				object obj3 = this + 12;
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

	public event Action<int> OnCoinsIncreased
	{
		add
		{
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected Obj, but got Unknown
			Delegate obj = this.m_OnCoinsChanged;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.RemoveImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				object obj3 = this + 12;
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
			Delegate obj = this.m_OnCoinsIncreased;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.CombineImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				object obj3 = this + 16;
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

	public event Action OnScoreChanged
	{
		add
		{
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected Obj, but got Unknown
			Delegate obj = this.m_OnCoinsIncreased;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.RemoveImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				object obj3 = this + 16;
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
			Delegate obj = this.m_OnScoreChanged;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.CombineImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				object obj3 = this + 20;
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

	public event Action OnJumpsChanged
	{
		add
		{
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected Obj, but got Unknown
			Delegate obj = this.m_OnScoreChanged;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.RemoveImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				object obj3 = this + 20;
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
			Delegate obj = this.m_OnJumpsChanged;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.CombineImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				object obj3 = this + 24;
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

	public event Action OnRollsChanged
	{
		add
		{
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected Obj, but got Unknown
			Delegate obj = this.m_OnJumpsChanged;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.RemoveImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				object obj3 = this + 24;
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
			Delegate obj = this.m_OnRollsChanged;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.CombineImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				object obj3 = this + 28;
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

	public event Action<UpgradeType> PowerupTriggered
	{
		add
		{
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected Obj, but got Unknown
			Delegate obj = this.m_OnRollsChanged;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.RemoveImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				object obj3 = this + 28;
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
			Delegate obj = this.m_PowerupTriggered;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.CombineImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				object obj3 = this + 32;
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

	public event Action OnMysteryBoxPickup
	{
		add
		{
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected Obj, but got Unknown
			Delegate obj = this.m_PowerupTriggered;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.RemoveImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				object obj3 = this + 32;
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
			Delegate obj = this.m_OnMysteryBoxPickup;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.CombineImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				object obj3 = this + 36;
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

	public event Action OnSuperMysteryBoxPickup
	{
		add
		{
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected Obj, but got Unknown
			Delegate obj = this.m_OnMysteryBoxPickup;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.RemoveImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				object obj3 = this + 36;
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
			Delegate obj = this.m_OnSuperMysteryBoxPickup;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.CombineImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				object obj3 = this + 40;
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

	private GameStats()
	{
	}

	public void CoinsSpawnedIncrement()
	{
		//IL_01a0: Expected Obj, but got I
		//IL_01b0: Expected Obj, but got I
		//IL_01c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c6: Expected Obj, but got Unknown
		//IL_01cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d4: Expected Obj, but got Unknown
		//IL_01e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e9: Expected Obj, but got Unknown
		//IL_0211: Expected Obj, but got I
		//IL_0221: Expected Obj, but got I
		//IL_0232: Unknown result type (might be due to invalid IL or missing references)
		//IL_0237: Expected Obj, but got Unknown
		//IL_0240: Unknown result type (might be due to invalid IL or missing references)
		//IL_0245: Expected Obj, but got Unknown
		//IL_0255: Unknown result type (might be due to invalid IL or missing references)
		//IL_025a: Expected Obj, but got Unknown
		//IL_001b: Expected Obj, but got I
		//IL_002b: Expected Obj, but got I
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected Obj, but got Unknown
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Expected Obj, but got Unknown
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Expected Obj, but got Unknown
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Expected Obj, but got Unknown
		//IL_00b8: Expected Obj, but got I
		//IL_00c8: Expected Obj, but got I
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Expected Obj, but got Unknown
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Expected Obj, but got Unknown
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Expected Obj, but got Unknown
		//IL_013d: Expected VT, but got Obj
		//IL_0163: Unknown result type (might be due to invalid IL or missing references)
		//IL_0168: Expected Obj, but got Unknown
		//IL_017a: Expected Obj, but got VT
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S3_v2 (Il2CppMethodInfo)+C]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S3_v3+60]");
		object obj2 = 0;
		object obj3 = obj2;
		object obj4 = obj3 & 0x1FFF;
		object obj5 = obj4 + 113696;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v28 @ S4_v4 (should have been resolved before IL gen)");
		object obj6 = this + 136;
		object obj7 = default;
		obj6 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S3_v7 (Il2CppMethodInfo)+C]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S3_v8+60]");
		object obj9 = 0;
		object obj10 = obj9;
		object obj11 = obj10 & 0x1FFF;
		object obj12 = obj11 + 113696;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v52 @ S4_v8 (should have been resolved before IL gen)");
		object obj13 = this + 140;
		object obj14 = default;
		obj13 = obj14;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ S3_v12 (Il2CppMethodInfo)+C]");
		object obj15 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ S3_v13+60]");
		object obj16 = 0;
		object obj17 = obj16;
		object obj18 = obj17 & 0x1FFF;
		object obj19 = obj18 + 113696;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v75 @ S4_v12 (should have been resolved before IL gen)");
		object obj20 = this + 144;
		object obj21 = default;
		obj20 = obj21;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @BB79");
		object obj22 = this + 148;
		object obj23 = default;
		obj22 = obj23;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ S3_v17 (Il2CppMethodInfo)+C]");
		object obj24 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ S3_v18+60]");
		object obj25 = 0;
		object obj26 = obj25;
		object obj27 = obj26 & 0x1FFF;
		object obj28 = obj27 + 113696;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v108 @ S4_v16 (should have been resolved before IL gen)");
		object obj29 = this + 152;
		object obj30 = default;
		obj29 = obj30;
		if (Application.platform != RuntimePlatform.OSXEditor)
		{
			_00210 val = (_00210)SingletonMonoBehaviour<>.Instantiate();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num5 = 0;
			_ = 0;
			EventHandler<PickupManager.PickupEventArgs> eventHandler = default;
			object obj31 = eventHandler + 16;
			obj31 = this;
			((PickupManager)val).OnPickupSpawned -= eventHandler;
		}
	}

	public void CoinsCollectedRawIncrement()
	{
		int coinsSpawned = _coinsSpawned + 1;
		_coinsSpawned = coinsSpawned;
		int coinsSpawnedRun = _coinsSpawnedRun + 1;
		_coinsSpawnedRun = coinsSpawnedRun;
	}

	public void CoinsCollectedIncrement(int count)
	{
		//IL_008e: Expected I, but got Obj
		//IL_00a4: Expected Obj, but got I
		//IL_00e8: Expected I4, but got Obj
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(Utils);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S1_v3 (Il2CppClass<Utils>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Utils);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v12 (Il2CppClass<Utils>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string intBinaryString = Utils.GetIntBinaryString(_xoredNumberOfCoinsCollected);
		string intBinaryString2 = Utils.GetIntBinaryString(count);
		_xoredNumberOfCoinsCollected = (int)intBinaryString2;
		if ((nint)intBinaryString != count && this.m_OnCoinsChanged != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @78B7");
		}
	}

	public void CoinsWithJetpackIncrement()
	{
		int coinsCollectedRaw = _coinsCollectedRaw + 1;
		_coinsCollectedRaw = coinsCollectedRaw;
		int coinsCollectedRawRun = _coinsCollectedRawRun + 1;
		_coinsCollectedRawRun = coinsCollectedRawRun;
	}

	public void CoinsWithPogoStickIncrement()
	{
		//IL_003b: Expected Obj, but got I4
		//IL_003b: Expected Obj, but got I4
		//IL_003b: Expected Obj, but got I4
		int coinsWithJetpack = _coinsWithJetpack + 1;
		_coinsWithJetpack = coinsWithJetpack;
		StayInOneLaneMission stayInOneLaneMission = StayInOneLaneMission.instance;
		((OwnBoardsAward)(object)stayInOneLaneMission)._002Ector((AwardStaticData)72, (PersistentAwardProgress)1, (Action<Award>)(-1));
	}

	public void CoinsInAirIncrement()
	{
		//IL_003b: Expected Obj, but got I4
		//IL_003b: Expected Obj, but got I4
		//IL_003b: Expected Obj, but got I4
		int coinsWithPogoStick = _coinsWithPogoStick + 1;
		_coinsWithPogoStick = coinsWithPogoStick;
		StayInOneLaneMission stayInOneLaneMission = StayInOneLaneMission.instance;
		((OwnBoardsAward)(object)stayInOneLaneMission)._002Ector((AwardStaticData)81, (PersistentAwardProgress)1, (Action<Award>)(-1));
	}

	public void CoinsCollectedOnLeftTrackIncrement()
	{
		//IL_003b: Expected Obj, but got I4
		//IL_003b: Expected Obj, but got I4
		//IL_003b: Expected Obj, but got I4
		int coinsInAir = _coinsInAir + 1;
		_coinsInAir = coinsInAir;
		StayInOneLaneMission stayInOneLaneMission = StayInOneLaneMission.instance;
		((OwnBoardsAward)(object)stayInOneLaneMission)._002Ector((AwardStaticData)74, (PersistentAwardProgress)1, (Action<Award>)(-1));
	}

	public void CoinsCollectedOnCenterTrackIncrement()
	{
		//IL_003b: Expected Obj, but got I4
		//IL_003b: Expected Obj, but got I4
		//IL_003b: Expected Obj, but got I4
		int coinCollectedOnLeftTrack = _coinCollectedOnLeftTrack + 1;
		_coinCollectedOnLeftTrack = coinCollectedOnLeftTrack;
		StayInOneLaneMission stayInOneLaneMission = StayInOneLaneMission.instance;
		((OwnBoardsAward)(object)stayInOneLaneMission)._002Ector((AwardStaticData)75, (PersistentAwardProgress)1, (Action<Award>)(-1));
	}

	public void CoinsCollectedOnRightTrackIncrement()
	{
		//IL_003b: Expected Obj, but got I4
		//IL_003b: Expected Obj, but got I4
		//IL_003b: Expected Obj, but got I4
		int coinsCollectedOnCenterTrack = _coinsCollectedOnCenterTrack + 1;
		_coinsCollectedOnCenterTrack = coinsCollectedOnCenterTrack;
		StayInOneLaneMission stayInOneLaneMission = StayInOneLaneMission.instance;
		((OwnBoardsAward)(object)stayInOneLaneMission)._002Ector((AwardStaticData)76, (PersistentAwardProgress)1, (Action<Award>)(-1));
	}

	public void CoinMagnetCountIncrement()
	{
		//IL_003b: Expected Obj, but got I4
		//IL_003b: Expected Obj, but got I4
		//IL_003b: Expected Obj, but got I4
		int coinsCollectedOnRightTrack = _coinsCollectedOnRightTrack + 1;
		_coinsCollectedOnRightTrack = coinsCollectedOnRightTrack;
		StayInOneLaneMission stayInOneLaneMission = StayInOneLaneMission.instance;
		((OwnBoardsAward)(object)stayInOneLaneMission)._002Ector((AwardStaticData)77, (PersistentAwardProgress)1, (Action<Award>)(-1));
	}

	public void ScoreBoosterTierIncrement()
	{
		//IL_003b: Expected Obj, but got I4
		//IL_003b: Expected Obj, but got I4
		//IL_003b: Expected Obj, but got I4
		int coinsWithCoinMagnetCount = _coinsWithCoinMagnetCount + 1;
		_coinsWithCoinMagnetCount = coinsWithCoinMagnetCount;
		StayInOneLaneMission stayInOneLaneMission = StayInOneLaneMission.instance;
		((OwnBoardsAward)(object)stayInOneLaneMission)._002Ector((AwardStaticData)26, (PersistentAwardProgress)1, (Action<Award>)(-1));
	}

	public void CalculateScore()
	{
		bool characterDayEventActivated = (byte)(_scoreBoosterTier + 1) != 0;
		CharacterDayEventActivated = characterDayEventActivated;
		int scoreBoosterTierRun = _scoreBoosterTierRun + 1;
		_scoreBoosterTierRun = scoreBoosterTierRun;
	}

	public void ResetAmountNeededToAdjustScoreBy()
	{
		//IL_003c: Expected I, but got Obj
		//IL_0052: Expected Obj, but got I
		//IL_007d: Expected I, but got Obj
		//IL_00c5: Expected F4, but got I4
		//IL_0348: Expected Obj, but got I4
		//IL_0350: Unknown result type (might be due to invalid IL or missing references)
		//IL_0355: Expected Obj, but got Unknown
		//IL_035f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0364: Expected I4, but got Unknown
		//IL_038e: Expected Obj, but got I4
		//IL_038e: Expected Obj, but got I4
		//IL_00fe: Expected F4, but got I4
		//IL_015c: Expected Obj, but got I4
		//IL_015c: Expected Obj, but got I4
		//IL_0137: Expected F4, but got I4
		//IL_0181: Expected Obj, but got I4
		//IL_0181: Expected Obj, but got I4
		//IL_01a6: Expected Obj, but got I4
		//IL_01a6: Expected Obj, but got I4
		//IL_0269: Expected Obj, but got I4
		//IL_0269: Expected Obj, but got I4
		//IL_02a7: Expected Obj, but got I4
		//IL_02a7: Expected Obj, but got I4
		if (!(_metersLastUsedForScore < _metersInCurrentGame))
		{
			return;
		}
		float meterScore = _metersInCurrentGame - _metersLastUsedForScore;
		_meterScore = meterScore;
		_metersLastUsedForScore = _metersInCurrentGame;
		nint num = (nint)typeof(ScoreMultiplierInfo);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S0_v12 (Il2CppClass<Info.ScoreMultiplierInfo>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(ScoreMultiplierInfo);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v69 (Il2CppClass<Info.ScoreMultiplierInfo>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		int rawMultiplier = ScoreMultiplierInfo.rawMultiplier;
		float num3 = _meterScore * (float)rawMultiplier;
		if (num3 != num3)
		{
			num3 = -2.1474836E+09f;
		}
		else if (!(num3 < 2.1474836E+09f))
		{
			num3 = -2.1474836E+09f;
		}
		else if (!(num3 > -2.1474836E+09f))
		{
			num3 = -2.1474836E+09f;
		}
		int pickupCountSpawnedLastRun = GetPickupCountSpawnedLastRun(PickupType.SuperSneakers);
		object obj2 = rawMultiplier * pickupCountSpawnedLastRun;
		PersistentAwardProgress persistentAwardProgress = (PersistentAwardProgress)(obj2 + num3);
		int score = persistentAwardProgress + _score;
		_score = score;
		StayInOneLaneMission stayInOneLaneMission = StayInOneLaneMission.instance;
		((OwnBoardsAward)(object)stayInOneLaneMission)._002Ector((AwardStaticData)3, persistentAwardProgress, (Action<Award>)(-1));
		StayInOneLaneMission stayInOneLaneMission2 = StayInOneLaneMission.instance;
		((OwnBoardsAward)(object)stayInOneLaneMission2)._002Ector((AwardStaticData)36, persistentAwardProgress, (Action<Award>)(-1));
		StayInOneLaneMission stayInOneLaneMission3 = StayInOneLaneMission.instance;
		((OwnBoardsAward)(object)stayInOneLaneMission3)._002Ector((AwardStaticData)64, persistentAwardProgress, (Action<Award>)(-1));
		StayInOneLaneMission stayInOneLaneMission4 = StayInOneLaneMission.instance;
		((OwnBoardsAward)(object)stayInOneLaneMission4)._002Ector((AwardStaticData)63, persistentAwardProgress, (Action<Award>)(-1));
		List<ActivePowerup> listOfActivePowerups = _listOfActivePowerups;
		if (listOfActivePowerups._size == 0)
		{
			goto IL_0249;
		}
		List<ActivePowerup> listOfActivePowerups2 = _listOfActivePowerups;
		if (listOfActivePowerups2._size == 1)
		{
			ActivePowerup activePowerup = _listOfActivePowerups.get_Item(0);
			if (activePowerup.type == UpgradeType.hoverboard)
			{
				goto IL_0249;
			}
		}
		goto IL_026e;
		IL_0249:
		StayInOneLaneMission stayInOneLaneMission5 = StayInOneLaneMission.instance;
		((OwnBoardsAward)(object)stayInOneLaneMission5)._002Ector((AwardStaticData)65, persistentAwardProgress, (Action<Award>)(-1));
		goto IL_026e;
		IL_026e:
		if (~(_scoreBoosterActivated ? 1u : 0u) == 0)
		{
			StayInOneLaneMission stayInOneLaneMission6 = StayInOneLaneMission.instance;
			((OwnBoardsAward)(object)stayInOneLaneMission6)._002Ector((AwardStaticData)73, persistentAwardProgress, (Action<Award>)(-1));
		}
		TransformExtensions.Reset((Transform)(object)this.m_OnScoreChanged);
	}

	public void IncreaseAmountNeededToAdjustScoreBy(int amount)
	{
		int isPausedPowerups = amount & 1;
		_isPausedPowerups = (byte)isPausedPowerups != 0;
	}

	private int ConsumeAmountNeededToAdjustScoreBy(int amount)
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected Obj, but got Unknown
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected Obj, but got Unknown
		int num = 0;
		while (true)
		{
			if (num > 40)
			{
				num = -1;
				break;
			}
			object obj = this.m_OnCoinsChanged + 16;
			int num2 = num << 3;
			object obj2 = obj + num2;
			if ((nint)obj2 == amount)
			{
				break;
			}
			int num3 = num + 1;
			num = num3;
		}
		return num;
	}

	public void AddScoreForPickup(UpgradeType type)
	{
		int amountLeftToConsume = (int)(type + _amountLeftToConsume);
		_amountLeftToConsume = amountLeftToConsume;
	}

	private void AddScoreForPickup(bool wasPowerup)
	{
		//IL_000e: Expected Obj, but got I4
		object obj = (wasPowerup ? 1 : 0) - 4;
		if ((wasPowerup ? 1 : 0) != 4)
		{
			if ((nint)obj == 1)
			{
				return;
			}
			if ((nint)obj != 2 && (nint)obj != 3 && (nint)obj != 4)
			{
				if ((nint)obj == 5)
				{
					goto IL_00de;
				}
				if ((nint)obj != 6)
				{
					return;
				}
			}
			RollCount = 1;
			return;
		}
		goto IL_00de;
		IL_00de:
		RollCount = 0;
	}

	private void ResetScore()
	{
		_amountLeftToConsume = 0;
	}

	public void ResetGame()
	{
		_score = 0;
		_metersLastUsedForScore = 0f;
		_meterScore = 0f;
	}

	public void ResetRun()
	{
		BragNotifyDone = false;
		BragFacebookDone = false;
		_score = 0;
		_metersLastUsedForScore = 0f;
		_meterScore = 0f;
		_amountLeftToConsume = 0;
		_coinsSpawned = 0;
		_coinsCollectedRaw = 0;
		CoinsCollectedIncrement(0);
		_coinsWithCoinMagnetCount = 0;
		_coinsWithJetpack = 0;
		_scoreBoosterActivated = false;
		CharacterDayEventActivated = false;
		_metersInCurrentGame = 0f;
		_stumbles = 0;
		_jumps = 0;
		_jumpsOverTrainsCount = 0;
		MovingTrainHitCount = 0;
		_rollsLeftTrackCount = 0;
		_rollsCenterTrackCount = 0;
		_rollsRightTrackCount = 0;
		_dodgeBarrierCount = 0;
		_jumpBarrierCount = 0;
		_jumpHighBarrierCount = 0;
		_trainHitCount = 0;
		_barrierHitCount = 0;
		SuperSneakerPickupsCollected = 0;
		PogoStickPickupsCollected = 0;
		CoinMagnetPickupsCollected = 0;
		_dailyLetterPickupsCollected = 0;
		_characterLetterPickupsCollected = 0;
		DoubleMultiplierPickupsCollected = 0;
		_mysteryBoxPickupsCollected = 0;
		_superMysteryBoxPickupsCollected = 0;
		_superSneakerPickupsCollected = 0;
		_pickedUpPowerups = 0;
		ReportOneOfEachPowerupIfApplicable(UpgradeType._notset);
		_keyPickupsCollected = 0;
		_huntTokensCollected = 0;
		ClearPowerups();
	}

	private void PickupManager_OnPickupSpawned(object sender, PickupManager.PickupEventArgs args)
	{
		//IL_002b: Expected Obj, but got I
		Action<UpgradeType> powerupTriggered = this.m_PowerupTriggered;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S0_v8 (System.Action`1<Info.UpgradeType>)+84]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ S0_v9+8]");
		if ((nint)0 == 0)
		{
			((GliderAnimation)this).HandleOnCloseMenu();
		}
	}

	public int GetPickupCountSpawnedLastRun(PickupType pickup)
	{
		PickupType pickupType = default;
		if (pickupType > (PickupType)0)
		{
			if (_amountLeftToConsume < (int)pickupType)
			{
				pickupType = (PickupType)_amountLeftToConsume;
			}
			if (_amountLeftToConsume > 0)
			{
				int amountLeftToConsume = (int)(_amountLeftToConsume - pickupType);
				_amountLeftToConsume = amountLeftToConsume;
			}
			else
			{
				pickupType = (PickupType)0;
			}
			return (int)pickupType;
		}
		return 0;
	}

	public ActivePowerup TriggerPowerup(UpgradeType type, bool triggeredViaMysteryPowerup = false)
	{
		//IL_033c: Expected I, but got Obj
		//IL_0352: Expected Obj, but got I
		//IL_02ae: Expected I, but got Obj
		//IL_02c4: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0443: Expected Obj, but got I4
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_02ef: Expected I, but got Obj
		//IL_0381: Expected Obj, but got I4
		//IL_0393: Expected I, but got Obj
		//IL_03a9: Expected Obj, but got I
		//IL_00a1: Expected I, but got Obj
		//IL_00ee: Expected I, but got Obj
		//IL_013b: Expected Obj, but got I4
		//IL_0144: Unknown result type (might be due to invalid IL or missing references)
		//IL_0149: Expected Obj, but got Unknown
		//IL_0161: Expected I, but got Obj
		//IL_0177: Expected Obj, but got I
		//IL_03f8: Expected Obj, but got I4
		//IL_01a2: Expected I, but got Obj
		nint num = (nint)typeof(SocialManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SocialManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(SocialManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v67 (Il2CppClass<SocialManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool facebookDialogsSupported = SocialManager.facebookDialogsSupported;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v11 (System.Boolean)+38]");
		if ((nint)0 != 0)
		{
			nint num3 = (nint)typeof(SocialManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S0_v28 (Il2CppClass<SocialManager>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(SocialManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ S0_v63 (Il2CppClass<SocialManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool facebookDialogsSupported2 = SocialManager.facebookDialogsSupported;
			string localDisplayName = ((SocialManager)facebookDialogsSupported2).localDisplayName;
			nint num5 = (nint)typeof(Regex);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ S1_v11 (Il2CppClass<System.Text.RegularExpressions.Regex>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num6 = (nint)typeof(Regex);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ S1_v29 (Il2CppClass<System.Text.RegularExpressions.Regex>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (!((Regex)(object)localDisplayName).IsMatch("\\p{IsArabic}|\\p{IsHebrew}|\\p{IsSyriac}|\\p{IsThaana}"))
			{
				bool flag = default;
				object obj4 = (flag ? 1 : 0) + 12;
				object obj5 = obj4 + 1;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
				nint num7 = (nint)typeof(SocialManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ S0_v40 (Il2CppClass<SocialManager>)+BA]");
				object obj6 = (nint)0 & (nint)0x200;
				if (obj6 != null)
				{
					nint num8 = (nint)typeof(SocialManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ S0_v59 (Il2CppClass<SocialManager>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				bool facebookDialogsSupported3 = SocialManager.facebookDialogsSupported;
				string localDisplayName2 = ((SocialManager)facebookDialogsSupported3).localDisplayName;
				throw new ArrayTypeMismatchException();
			}
		}
		nint num9 = (nint)typeof(Strings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ S0_v20 (Il2CppClass<Strings>)+BA]");
		object obj7 = (nint)0 & (nint)0x200;
		if (obj7 != null)
		{
			nint num10 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ S0_v23 (Il2CppClass<Strings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string text = Strings.GetDefault((string)type);
		Array array = default;
		return (ActivePowerup)(object)(text + array);
	}

	public unsafe int GetPowerupActivationCountLastRun(UpgradeType upgrade)
	{
		ref int reference = ref *(int*)null;
		bool flag = _spawnedPickupsLastRun.TryGetValue((int)upgrade, out reference);
		return reference;
	}

	public unsafe int GetMysteryPowerupActivationCountLastRun(UpgradeType upgrade)
	{
		ref int reference = ref *(int*)null;
		bool flag = _powerupActivationCountsLastRun.TryGetValue((int)upgrade, out reference);
		return reference;
	}

	public List<ActivePowerup> GetActivePowerups()
	{
		return (List<ActivePowerup>)(object)_missionEachPowerupPickupStatus;
	}

	public unsafe bool IsPowerupActive(UpgradeType type)
	{
		ref int reference = ref *(int*)null;
		bool flag = _mysteryPowerupActivationCountsLastRun.TryGetValue((int)type, out reference);
		return (byte)reference != 0;
	}

	public unsafe void UpdatePowerupTimes(float deltaTime)
	{
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Expected VT, but got Unknown
		//IL_0108: Unknown result type (might be due to invalid IL or missing references)
		//IL_010d: Expected VT, but got Unknown
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Expected Obj, but got Unknown
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Expected Obj, but got Unknown
		//IL_0015: Expected Obj, but got I4
		//IL_003d: Expected VT, but got Obj
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected Obj, but got Unknown
		//IL_0070: Expected I, but got Obj
		//IL_0086: Expected Obj, but got I
		//IL_013b: Expected F4, but got Obj
		//IL_0136: Expected native int or pointer, but got VT
		//IL_014d: Expected F4, but got I
		//IL_0148: Expected native int or pointer, but got VT
		//IL_015a: Expected F4, but got Obj
		//IL_0155: Expected native int or pointer, but got VT
		//IL_016f: Expected F4, but got I
		//IL_016a: Expected native int or pointer, but got VT
		//IL_0191: Expected F4, but got Obj
		//IL_018c: Expected native int or pointer, but got VT
		//IL_01a6: Expected F4, but got I
		//IL_01a1: Expected native int or pointer, but got VT
		//IL_01af: Expected Obj, but got VT
		//IL_01bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c1: Expected Obj, but got Unknown
		//IL_00b1: Expected I, but got Obj
		object obj = default;
		Vector3 vector = (Vector3)(obj + 48);
		Vector3 vector2 = (Vector3)(obj + 36);
		Transform transform = (Transform)(obj + 24);
		object obj2 = obj + 12;
		object obj4 = default;
		object obj10 = default;
		while (true)
		{
			int coinsCollectedRaw = _coinsCollectedRaw;
			object obj3 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ S1_v9 (System.Int32)+C]");
			if ((nint)obj3 >= 0)
			{
				break;
			}
			object obj5 = _coinsCollectedRaw + 16;
			object obj6 = obj4 << 2;
			object obj7 = obj5 + obj6;
			transform.position = (Vector3)obj7;
			object obj8 = _missionEachPowerupPickupStatus + 248;
			obj2 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ S2_v10+8]");
			_ = 0;
			nint num = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ S1_v18 (Il2CppClass<UnityEngine.Vector3>)+BA]");
			object obj9 = (nint)0 & (nint)0x200;
			if (obj9 != null)
			{
				nint num2 = (nint)typeof(Vector3);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ S1_v31 (Il2CppClass<UnityEngine.Vector3>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			((Vector3*)(nint)vector2)->x = (float)transform;
			((Vector3*)(nint)vector2)->z = (nint)((UnityEngine.Object)transform).m_CachedPtr;
			((Vector3*)(nint)vector)->x = (float)obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v15+8]");
			((Vector3*)(nint)vector)->z = 0f;
			Vector3 vector3 = Vector3.LerpUnclamped(vector2, vector, deltaTime);
			((Vector3*)(nint)vector)->x = (float)obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			((Vector3*)(nint)vector)->z = 0f;
			Vector3 localPosition = ((Transform)vector).localPosition;
			obj4 = obj10 + 1;
		}
	}

	public void ClearPowerups()
	{
		_coinsSpawnedRun = 0;
		_coinsCollectedRawRun = 0;
		ScoreBoosterActivated = false;
		_scoreBoosterTierRun = 0;
		_stumblesRun = 0;
		_jetpackPickupsCollectedRun = 0;
		_superSneakerPickupsCollectedRun = 0;
		_pogoStickPickupsCollectedRun = 0;
		_dailyLetterPickupsCollectedRun = 0;
		_characterLetterPickupsCollectedRun = 0;
		_coinMagnetPickupsCollectedRun = 0;
		_mysteryBoxPickupsCollectedRun = 0;
		_superMysteryBoxPickupsCollectedRun = 0;
		_doubleMultiplierPickupsCollectedRun = 0;
		_keyPickupsCollectedRun = 0;
		_huntTokensCollectedRun = 0;
		throw new IndexOutOfRangeException();
	}

	public void RemoveHoverBoardPowerup()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @BB86");
		StayInOneLaneMission stayInOneLaneMission = StayInOneLaneMission.instance;
		((MissionsManager)(object)stayInOneLaneMission).ResetProgressForMissionIndex(59);
	}

	public void StumbleCountIncrement()
	{
		List<ActivePowerup> listOfActivePowerups = _listOfActivePowerups;
		int num = listOfActivePowerups._size;
		while (true)
		{
			int num2 = num - 1;
			if (num2 >= 0)
			{
				ActivePowerup activePowerup = _listOfActivePowerups.get_Item(num2);
				if (activePowerup.type == UpgradeType.hoverboard)
				{
					ActivePowerup activePowerup2 = _listOfActivePowerups.get_Item(num2);
					activePowerup2.timeLeft = 0f;
				}
				num = num2;
				continue;
			}
			break;
		}
	}

	public void JumpCountIncrement()
	{
		int stumbles = _stumbles + 1;
		_stumbles = stumbles;
		int stumblesRun = _stumblesRun + 1;
		_stumblesRun = stumblesRun;
	}

	public void JumpsOverTrainsCountIncrement()
	{
		//IL_0069: Expected Obj, but got I4
		//IL_0069: Expected Obj, but got I4
		//IL_0069: Expected Obj, but got I4
		int jumps = _jumps + 1;
		_jumps = jumps;
		if (this.m_OnJumpsChanged != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @78B7");
		}
		StayInOneLaneMission stayInOneLaneMission = StayInOneLaneMission.instance;
		((OwnBoardsAward)(object)stayInOneLaneMission)._002Ector((AwardStaticData)5, (PersistentAwardProgress)1, (Action<Award>)(-1));
		StayInOneLaneMission stayInOneLaneMission2 = StayInOneLaneMission.instance;
		((MissionsManager)(object)stayInOneLaneMission2).ResetProgressForMissionIndex(63);
	}

	public void RollCountIncrement()
	{
		//IL_003b: Expected Obj, but got I4
		//IL_003b: Expected Obj, but got I4
		//IL_003b: Expected Obj, but got I4
		int jumpsOverTrainsCount = _jumpsOverTrainsCount + 1;
		_jumpsOverTrainsCount = jumpsOverTrainsCount;
		StayInOneLaneMission stayInOneLaneMission = StayInOneLaneMission.instance;
		((OwnBoardsAward)(object)stayInOneLaneMission)._002Ector((AwardStaticData)4, (PersistentAwardProgress)1, (Action<Award>)(-1));
	}

	public void RollsLeftTrackCountIncrement()
	{
		//IL_0040: Expected Obj, but got I4
		//IL_0040: Expected Obj, but got I4
		//IL_0040: Expected Obj, but got I4
		int movingTrainHitCount = _rollCount + 1;
		MovingTrainHitCount = movingTrainHitCount;
		StayInOneLaneMission stayInOneLaneMission = StayInOneLaneMission.instance;
		((OwnBoardsAward)(object)stayInOneLaneMission)._002Ector((AwardStaticData)6, (PersistentAwardProgress)1, (Action<Award>)(-1));
		StayInOneLaneMission stayInOneLaneMission2 = StayInOneLaneMission.instance;
		((MissionsManager)(object)stayInOneLaneMission2).ResetProgressForMissionIndex(64);
	}

	public void RollsCenterTrackCountIncrement()
	{
		//IL_003b: Expected Obj, but got I4
		//IL_003b: Expected Obj, but got I4
		//IL_003b: Expected Obj, but got I4
		int rollsLeftTrackCount = _rollsLeftTrackCount + 1;
		_rollsLeftTrackCount = rollsLeftTrackCount;
		StayInOneLaneMission stayInOneLaneMission = StayInOneLaneMission.instance;
		((OwnBoardsAward)(object)stayInOneLaneMission)._002Ector((AwardStaticData)7, (PersistentAwardProgress)1, (Action<Award>)(-1));
	}

	public void RollsRightTrackCountIncrement()
	{
		//IL_003b: Expected Obj, but got I4
		//IL_003b: Expected Obj, but got I4
		//IL_003b: Expected Obj, but got I4
		int rollsCenterTrackCount = _rollsCenterTrackCount + 1;
		_rollsCenterTrackCount = rollsCenterTrackCount;
		StayInOneLaneMission stayInOneLaneMission = StayInOneLaneMission.instance;
		((OwnBoardsAward)(object)stayInOneLaneMission)._002Ector((AwardStaticData)8, (PersistentAwardProgress)1, (Action<Award>)(-1));
	}

	public void DodgeBarrierCountIncrement()
	{
		//IL_003b: Expected Obj, but got I4
		//IL_003b: Expected Obj, but got I4
		//IL_003b: Expected Obj, but got I4
		int rollsRightTrackCount = _rollsRightTrackCount + 1;
		_rollsRightTrackCount = rollsRightTrackCount;
		StayInOneLaneMission stayInOneLaneMission = StayInOneLaneMission.instance;
		((OwnBoardsAward)(object)stayInOneLaneMission)._002Ector((AwardStaticData)9, (PersistentAwardProgress)1, (Action<Award>)(-1));
	}

	public void JumpBarrierCountIncrement()
	{
		//IL_0154: Expected I, but got Obj
		//IL_016a: Expected Obj, but got I
		//IL_01d8: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_00a1: Expected I, but got Obj
		//IL_011b: Expected Obj, but got I4
		//IL_011b: Expected Obj, but got I4
		//IL_011b: Expected Obj, but got I4
		//IL_0141: Expected Obj, but got I4
		//IL_0141: Expected Obj, but got I4
		//IL_0141: Expected Obj, but got I4
		nint num = (nint)typeof(Game);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SYBO.Subway.Game>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Game);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v34 (Il2CppClass<SYBO.Subway.Game>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool isInstantiated = Game.IsInstantiated;
		object obj2 = (isInstantiated ? 1 : 0) - -64;
		if (obj2 != null)
		{
			return;
		}
		nint num3 = (nint)typeof(Game);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v17 (Il2CppClass<SYBO.Subway.Game>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num4 = (nint)typeof(Game);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S0_v30 (Il2CppClass<SYBO.Subway.Game>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool isInstantiated2 = Game.IsInstantiated;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v22 (System.Boolean)+D8]");
		if ((nint)0 == 0)
		{
			int dodgeBarrierCount = _dodgeBarrierCount + 1;
			_dodgeBarrierCount = dodgeBarrierCount;
			StayInOneLaneMission stayInOneLaneMission = StayInOneLaneMission.instance;
			((OwnBoardsAward)(object)stayInOneLaneMission)._002Ector((AwardStaticData)10, (PersistentAwardProgress)1, (Action<Award>)(-1));
			StayInOneLaneMission stayInOneLaneMission2 = StayInOneLaneMission.instance;
			((OwnBoardsAward)(object)stayInOneLaneMission2)._002Ector((AwardStaticData)21, (PersistentAwardProgress)1, (Action<Award>)(-1));
		}
	}

	public void JumpHighBarrierCountIncrement()
	{
		//IL_0154: Expected I, but got Obj
		//IL_016a: Expected Obj, but got I
		//IL_01d8: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_00a1: Expected I, but got Obj
		//IL_011b: Expected Obj, but got I4
		//IL_011b: Expected Obj, but got I4
		//IL_011b: Expected Obj, but got I4
		//IL_0141: Expected Obj, but got I4
		//IL_0141: Expected Obj, but got I4
		//IL_0141: Expected Obj, but got I4
		nint num = (nint)typeof(Game);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SYBO.Subway.Game>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Game);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v34 (Il2CppClass<SYBO.Subway.Game>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool isInstantiated = Game.IsInstantiated;
		object obj2 = (isInstantiated ? 1 : 0) - -64;
		if (obj2 != null)
		{
			return;
		}
		nint num3 = (nint)typeof(Game);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v17 (Il2CppClass<SYBO.Subway.Game>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num4 = (nint)typeof(Game);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S0_v30 (Il2CppClass<SYBO.Subway.Game>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool isInstantiated2 = Game.IsInstantiated;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v22 (System.Boolean)+D8]");
		if ((nint)0 == 0)
		{
			int jumpBarrierCount = _jumpBarrierCount + 1;
			_jumpBarrierCount = jumpBarrierCount;
			StayInOneLaneMission stayInOneLaneMission = StayInOneLaneMission.instance;
			((OwnBoardsAward)(object)stayInOneLaneMission)._002Ector((AwardStaticData)11, (PersistentAwardProgress)1, (Action<Award>)(-1));
			StayInOneLaneMission stayInOneLaneMission2 = StayInOneLaneMission.instance;
			((OwnBoardsAward)(object)stayInOneLaneMission2)._002Ector((AwardStaticData)21, (PersistentAwardProgress)1, (Action<Award>)(-1));
		}
	}

	public void TrainHitCountIncrement()
	{
		int jumpHighBarrierCount = _jumpHighBarrierCount + 1;
		_jumpHighBarrierCount = jumpHighBarrierCount;
	}

	public void BarrierHitCountIncrement()
	{
		//IL_003b: Expected Obj, but got I4
		//IL_003b: Expected Obj, but got I4
		//IL_003b: Expected Obj, but got I4
		int trainHitCount = _trainHitCount + 1;
		_trainHitCount = trainHitCount;
		StayInOneLaneMission stayInOneLaneMission = StayInOneLaneMission.instance;
		((OwnBoardsAward)(object)stayInOneLaneMission)._002Ector((AwardStaticData)23, (PersistentAwardProgress)1, (Action<Award>)(-1));
	}

	public void JetpackPickupsCollectedIncrement()
	{
		//IL_003b: Expected Obj, but got I4
		//IL_003b: Expected Obj, but got I4
		//IL_003b: Expected Obj, but got I4
		int barrierHitCount = _barrierHitCount + 1;
		_barrierHitCount = barrierHitCount;
		StayInOneLaneMission stayInOneLaneMission = StayInOneLaneMission.instance;
		((OwnBoardsAward)(object)stayInOneLaneMission)._002Ector((AwardStaticData)22, (PersistentAwardProgress)1, (Action<Award>)(-1));
	}

	public void SuperSneakerPickupsCollectedIncrement()
	{
		//IL_003e: Expected VT, but got I4
		//IL_0068: Expected Obj, but got I4
		//IL_0068: Expected Obj, but got I4
		//IL_0068: Expected Obj, but got I4
		int superSneakerPickupsCollected = _jetpackPickupsCollected + 1;
		SuperSneakerPickupsCollected = superSneakerPickupsCollected;
		int jetpackPickupsCollectedRun = _jetpackPickupsCollectedRun + 1;
		_jetpackPickupsCollectedRun = jetpackPickupsCollectedRun;
		Color color = GlobalColors.ApplyButtonPressColorOffset((Color32)6);
		StayInOneLaneMission stayInOneLaneMission = StayInOneLaneMission.instance;
		((OwnBoardsAward)(object)stayInOneLaneMission)._002Ector((AwardStaticData)13, (PersistentAwardProgress)1, (Action<Award>)(-1));
	}

	public void PogoStickPickupsCollectedIncrement()
	{
		//IL_003e: Expected VT, but got I4
		//IL_0068: Expected Obj, but got I4
		//IL_0068: Expected Obj, but got I4
		//IL_0068: Expected Obj, but got I4
		int pogoStickPickupsCollected = _superSneakerPickupsCollected + 1;
		PogoStickPickupsCollected = pogoStickPickupsCollected;
		int superSneakerPickupsCollectedRun = _superSneakerPickupsCollectedRun + 1;
		_superSneakerPickupsCollectedRun = superSneakerPickupsCollectedRun;
		Color color = GlobalColors.ApplyButtonPressColorOffset((Color32)7);
		StayInOneLaneMission stayInOneLaneMission = StayInOneLaneMission.instance;
		((OwnBoardsAward)(object)stayInOneLaneMission)._002Ector((AwardStaticData)14, (PersistentAwardProgress)1, (Action<Award>)(-1));
	}

	public void DailyLetterPickupsCollectedIncrement()
	{
		//IL_005a: Expected Obj, but got I4
		//IL_005a: Expected Obj, but got I4
		//IL_005a: Expected Obj, but got I4
		//IL_0080: Expected Obj, but got I4
		//IL_0080: Expected Obj, but got I4
		//IL_0080: Expected Obj, but got I4
		//IL_008a: Expected VT, but got I4
		int coinMagnetPickupsCollected = _pogoStickPickupsCollected + 1;
		CoinMagnetPickupsCollected = coinMagnetPickupsCollected;
		int pogoStickPickupsCollectedRun = _pogoStickPickupsCollectedRun + 1;
		_pogoStickPickupsCollectedRun = pogoStickPickupsCollectedRun;
		StayInOneLaneMission stayInOneLaneMission = StayInOneLaneMission.instance;
		((OwnBoardsAward)(object)stayInOneLaneMission)._002Ector((AwardStaticData)79, (PersistentAwardProgress)1, (Action<Award>)(-1));
		StayInOneLaneMission stayInOneLaneMission2 = StayInOneLaneMission.instance;
		((OwnBoardsAward)(object)stayInOneLaneMission2)._002Ector((AwardStaticData)80, (PersistentAwardProgress)1, (Action<Award>)(-1));
		Color color = GlobalColors.ApplyButtonPressColorOffset((Color32)18);
	}

	public void CharacterLetterPickupsCollectedIncrement()
	{
		//IL_0055: Expected Obj, but got I4
		//IL_0055: Expected Obj, but got I4
		//IL_0055: Expected Obj, but got I4
		int dailyLetterPickupsCollected = _dailyLetterPickupsCollected + 1;
		_dailyLetterPickupsCollected = dailyLetterPickupsCollected;
		int dailyLetterPickupsCollectedRun = _dailyLetterPickupsCollectedRun + 1;
		_dailyLetterPickupsCollectedRun = dailyLetterPickupsCollectedRun;
		StayInOneLaneMission stayInOneLaneMission = StayInOneLaneMission.instance;
		((OwnBoardsAward)(object)stayInOneLaneMission)._002Ector((AwardStaticData)15, (PersistentAwardProgress)1, (Action<Award>)(-1));
	}

	public void CoinMagnetPickupsCollectedIncrement()
	{
		int characterLetterPickupsCollected = _characterLetterPickupsCollected + 1;
		_characterLetterPickupsCollected = characterLetterPickupsCollected;
		int characterLetterPickupsCollectedRun = _characterLetterPickupsCollectedRun + 1;
		_characterLetterPickupsCollectedRun = characterLetterPickupsCollectedRun;
	}

	public void MysteryBoxPickupsCollectedInrement()
	{
		//IL_003e: Expected VT, but got I4
		//IL_0068: Expected Obj, but got I4
		//IL_0068: Expected Obj, but got I4
		//IL_0068: Expected Obj, but got I4
		int doubleMultiplierPickupsCollected = _coinMagnetPickupsCollected + 1;
		DoubleMultiplierPickupsCollected = doubleMultiplierPickupsCollected;
		int coinMagnetPickupsCollectedRun = _coinMagnetPickupsCollectedRun + 1;
		_coinMagnetPickupsCollectedRun = coinMagnetPickupsCollectedRun;
		Color color = GlobalColors.ApplyButtonPressColorOffset((Color32)8);
		StayInOneLaneMission stayInOneLaneMission = StayInOneLaneMission.instance;
		((OwnBoardsAward)(object)stayInOneLaneMission)._002Ector((AwardStaticData)16, (PersistentAwardProgress)1, (Action<Award>)(-1));
	}

	public void SuperMysteryBoxPickupsCollectedIncrement()
	{
		//IL_0055: Expected Obj, but got I4
		//IL_0055: Expected Obj, but got I4
		//IL_0055: Expected Obj, but got I4
		int mysteryBoxPickupsCollected = _mysteryBoxPickupsCollected + 1;
		_mysteryBoxPickupsCollected = mysteryBoxPickupsCollected;
		int mysteryBoxPickupsCollectedRun = _mysteryBoxPickupsCollectedRun + 1;
		_mysteryBoxPickupsCollectedRun = mysteryBoxPickupsCollectedRun;
		StayInOneLaneMission stayInOneLaneMission = StayInOneLaneMission.instance;
		((OwnBoardsAward)(object)stayInOneLaneMission)._002Ector((AwardStaticData)17, (PersistentAwardProgress)1, (Action<Award>)(-1));
		if (this.m_OnMysteryBoxPickup != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @78B7");
		}
	}

	public void DoubleMultiplierPickupsCollectedIncrement()
	{
		int superMysteryBoxPickupsCollected = _superMysteryBoxPickupsCollected + 1;
		_superMysteryBoxPickupsCollected = superMysteryBoxPickupsCollected;
		int superMysteryBoxPickupsCollectedRun = _superMysteryBoxPickupsCollectedRun + 1;
		_superMysteryBoxPickupsCollectedRun = superMysteryBoxPickupsCollectedRun;
		if (this.m_OnSuperMysteryBoxPickup != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @78B7");
		}
	}

	public void HuntTokensCollectedIncrement()
	{
		//IL_003e: Expected VT, but got I4
		//IL_0068: Expected Obj, but got I4
		//IL_0068: Expected Obj, but got I4
		//IL_0068: Expected Obj, but got I4
		UpgradeType upgradeType = (UpgradeType)(_doubleMultiplierPickupsCollected + 1);
		ReportOneOfEachPowerupIfApplicable(upgradeType);
		int doubleMultiplierPickupsCollectedRun = _doubleMultiplierPickupsCollectedRun + 1;
		_doubleMultiplierPickupsCollectedRun = doubleMultiplierPickupsCollectedRun;
		Color color = GlobalColors.ApplyButtonPressColorOffset((Color32)10);
		StayInOneLaneMission stayInOneLaneMission = StayInOneLaneMission.instance;
		((OwnBoardsAward)(object)stayInOneLaneMission)._002Ector((AwardStaticData)38, (PersistentAwardProgress)1, (Action<Award>)(-1));
	}

	private void ReportOneOfEachPowerupIfApplicable(UpgradeType upgradeType)
	{
		//IL_001b: Expected Obj, but got I
		//IL_002b: Expected Obj, but got I
		//IL_003b: Expected Obj, but got I
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Expected Obj, but got Unknown
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Expected Obj, but got Unknown
		//IL_0100: Expected Obj, but got I
		//IL_0110: Expected Obj, but got I
		//IL_0120: Expected Obj, but got I
		//IL_0129: Unknown result type (might be due to invalid IL or missing references)
		//IL_012e: Expected Obj, but got Unknown
		//IL_0137: Unknown result type (might be due to invalid IL or missing references)
		//IL_013c: Expected Obj, but got Unknown
		//IL_009f: Expected Obj, but got I
		//IL_00af: Expected Obj, but got I
		//IL_00bf: Expected Obj, but got I
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Expected Obj, but got Unknown
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00db: Expected Obj, but got Unknown
		_doubleMultiplierPickupsCollected = (int)upgradeType;
		if (upgradeType == UpgradeType._notset)
		{
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S2_v3 (Il2CppMethodInfo)+C]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S2_v4+60]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S2_v5+44]");
			object obj3 = 0;
			object obj4 = obj3 & 0x1FFF;
			object obj5 = obj4 + 22691;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v32 @ S3_v5 (should have been resolved before IL gen)");
			object obj6 = default;
			if ((nint)obj6 > -1)
			{
				nint num2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ S4_v10 (Il2CppMethodInfo)+C]");
				object obj7 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ S4_v11+60]");
				object obj8 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ S4_v12+48]");
				object obj9 = 0;
				object obj10 = obj9 & 0x7FF;
				object obj11 = obj10 + 39195;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v47 @ S5_v9 (should have been resolved before IL gen)");
			}
			else
			{
				nint num3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ S4_v5 (Il2CppMethodInfo)+C]");
				object obj12 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ S4_v6+60]");
				object obj13 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ S4_v7+48]");
				object obj14 = 0;
				object obj15 = obj14 & 0x7FF;
				object obj16 = obj15 + 39195;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v46 @ S5_v5 (should have been resolved before IL gen)");
			}
		}
	}

	public void PickedUpPowerupsIncrement()
	{
		int huntTokensCollected = _huntTokensCollected + 1;
		_huntTokensCollected = huntTokensCollected;
		int huntTokensCollectedRun = _huntTokensCollectedRun + 1;
		_huntTokensCollectedRun = huntTokensCollectedRun;
	}

	public void KeyPickupsCollectedIncrement()
	{
		//IL_0024: Expected Obj, but got I4
		//IL_004a: Expected Obj, but got I4
		//IL_004a: Expected Obj, but got I4
		//IL_004a: Expected Obj, but got I4
		int pickedUpPowerups = _pickedUpPowerups + 1;
		_pickedUpPowerups = pickedUpPowerups;
		((NewMonoBehaviour)25)._002Ector();
		StayInOneLaneMission stayInOneLaneMission = StayInOneLaneMission.instance;
		((OwnBoardsAward)(object)stayInOneLaneMission)._002Ector((AwardStaticData)24, (PersistentAwardProgress)1, (Action<Award>)(-1));
		StayInOneLaneMission stayInOneLaneMission2 = StayInOneLaneMission.instance;
		((MissionsManager)(object)stayInOneLaneMission2).ResetProgressForMissionIndex(65);
	}

	public void RunCompleted()
	{
		//IL_0055: Expected Obj, but got I4
		//IL_0055: Expected Obj, but got I4
		//IL_0055: Expected Obj, but got I4
		int keyPickupsCollected = _keyPickupsCollected + 1;
		_keyPickupsCollected = keyPickupsCollected;
		int keyPickupsCollectedRun = _keyPickupsCollectedRun + 1;
		_keyPickupsCollectedRun = keyPickupsCollectedRun;
		StayInOneLaneMission stayInOneLaneMission = StayInOneLaneMission.instance;
		((OwnBoardsAward)(object)stayInOneLaneMission)._002Ector((AwardStaticData)70, (PersistentAwardProgress)1, (Action<Award>)(-1));
	}

	public static int CoinToScoreConversion(int coins)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [coins @ L0 (System.Int32)+130]");
		return 0;
	}
}
