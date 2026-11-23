using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using SYBO.Common.Components.Singleton;
using SYBO.Subway;
using SYBO.Subway.Pickups;
using UnityEngine;

public class GameStats
{
	private const int SCORE_FOR_PICKUPS = 30;

	private const int AMOUNT_BY_WHICH_EXTRA_SCORE_IS_CONSUMED = 4;

	private const float HOVERBOARD_COOLDOWN = 5f;

	public bool BragNotifyDone;

	public bool BragFacebookDone;

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

	private Dictionary<PowerupType, bool> _missionEachPowerupPickupStatus;

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

	private Action m_OnCoinsChanged;

	private Action m_OnCoinsIncreased;

	private Action m_OnScoreChanged;

	private Action m_OnJumpsChanged;

	private Action m_OnRollsChanged;

	private Action<PowerupType> m_PowerupTriggered;

	public int CoinsSpawned => _coinsSpawned;

	public int CoinsSpawnedRun => _coinsSpawnedRun;

	public int CoinsCollectedRaw => _coinsCollectedRaw;

	public int CoinsCollectedRawRun => _coinsCollectedRawRun;

	public int CoinsCollected
	{
		get
		{
			return Utils.EncryptDecryptXORValue(_xoredNumberOfCoinsCollected);
		}
		private set
		{
			int num = Utils.EncryptDecryptXORValue(_xoredNumberOfCoinsCollected);
			int xoredNumberOfCoinsCollected = Utils.EncryptDecryptXORValue(value);
			_xoredNumberOfCoinsCollected = xoredNumberOfCoinsCollected;
			if (value != num)
			{
				Action onCoinsChanged = this.m_OnCoinsChanged;
				if (this.m_OnCoinsChanged != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v29.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
				}
			}
		}
	}

	public int CoinsCollectedRun
	{
		get
		{
			return Utils.EncryptDecryptXORValue(_xoredNumberOfCoinsRun);
		}
		private set
		{
			int xoredNumberOfCoinsRun = Utils.EncryptDecryptXORValue(value);
			_xoredNumberOfCoinsRun = xoredNumberOfCoinsRun;
		}
	}

	public int CoinMultiplier
	{
		get
		{
			PlayerInfo playerInfo = PlayerInfo.Instance;
			int num = 4;
			if (!DoubleCoins.HasDoubleCoinsModifier)
			{
				num = 2;
			}
			int num2 = 2;
			if (!DoubleCoins.HasDoubleCoinsModifier)
			{
				num2 = 1;
			}
			if (!playerInfo._hasDoubleCoinsUpgrade)
			{
				num = num2;
			}
			_coinMultiplier = num;
			return num;
		}
	}

	public int CoinsWithJetpack => _coinsWithJetpack;

	public bool ScoreBoosterActivated
	{
		get
		{
			return _scoreBoosterActivated;
		}
		set
		{
			_scoreBoosterActivated = value;
		}
	}

	public int ScoreBoosterTier
	{
		get
		{
			return _scoreBoosterTier;
		}
		private set
		{
			_scoreBoosterTier = value;
			PlayerInfo playerInfo = PlayerInfo.Instance;
			Action onScoreMultiplierChanged = playerInfo.onScoreMultiplierChanged;
			if (playerInfo.onScoreMultiplierChanged != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v18.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
			}
		}
	}

	public int ScoreBoosterTierRun => _scoreBoosterTierRun;

	public bool CharacterDayEventActivated
	{
		get
		{
			return _characterDayEventActivated;
		}
		set
		{
			_characterDayEventActivated = value;
			PlayerInfo playerInfo = PlayerInfo.Instance;
			Action onScoreMultiplierChanged = playerInfo.onScoreMultiplierChanged;
			if (playerInfo.onScoreMultiplierChanged != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v18.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
			}
		}
	}

	public bool IsPausedPowerups
	{
		get
		{
			return _isPausedPowerups;
		}
		set
		{
			_isPausedPowerups = value;
		}
	}

	public int Score => _score;

	public Dictionary<PowerupType, bool> MissionEachPowerupPickupStatus => _missionEachPowerupPickupStatus;

	public float MetersInCurrentGame
	{
		get
		{
			return _metersInCurrentGame;
		}
		set
		{
			_metersInCurrentGame = value;
		}
	}

	public int Stumbles => _stumbles;

	public int StumblesRun => _stumblesRun;

	public int JumpsOverTrainsCount => _jumpsOverTrainsCount;

	public int RollCount
	{
		get
		{
			return _rollCount;
		}
		private set
		{
			_rollCount = value;
			Action onRollsChanged = this.m_OnRollsChanged;
			if (this.m_OnRollsChanged != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v5.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
			}
		}
	}

	public int JumpHighBarrierCount => _jumpHighBarrierCount;

	public int MovingTrainHitCount
	{
		get
		{
			return _movingTrainHit;
		}
		set
		{
			_movingTrainHit = value;
			if (value != 0)
			{
				MissionsManager missionsManager = MissionsManager.Instance;
				missionsManager.PlayerDidThis(MissionTarget.DieToTrain);
				MissionsManager missionsManager2 = MissionsManager.Instance;
				missionsManager2.PlayerDidThis(MissionTarget.CrashTrains);
			}
		}
	}

	public int JetpackPickupsCollected
	{
		get
		{
			return _jetpackPickupsCollected;
		}
		private set
		{
			//IL_0021: Expected Obj, but got I
			//IL_0034: Unknown result type (might be due to invalid IL or missing references)
			//IL_0039: Expected Obj, but got Unknown
			//IL_00a7: Expected Obj, but got I
			//IL_0080: Expected Obj, but got I
			_jetpackPickupsCollected = value;
			if (value == 0)
			{
				nint num = 0;
				nint num2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S3_v4 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<PowerupType, System.Boolean>>)+54]");
				object obj = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v30 @ S3_v5+4] (should have been resolved before IL gen)");
				object obj3 = default;
				object obj2 = obj3 ^ -1;
				object obj4 = obj2 >> 31;
				if (obj4 != null)
				{
					nint num3 = 0;
					nint num4 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ S5_v9 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<PowerupType, System.Boolean>>)+5C]");
					object obj5 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v77 @ S5_v10+4] (should have been resolved before IL gen)");
				}
				else
				{
					nint num5 = 0;
					nint num6 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ S5_v4 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<PowerupType, System.Boolean>>)+5C]");
					object obj6 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v88 @ S5_v5+4] (should have been resolved before IL gen)");
				}
			}
		}
	}

	public int JetpackPickupsCollectedRun => _jetpackPickupsCollectedRun;

	public int SuperSneakerPickupsCollected
	{
		get
		{
			return _superSneakerPickupsCollected;
		}
		private set
		{
			//IL_0021: Expected Obj, but got I
			//IL_0034: Unknown result type (might be due to invalid IL or missing references)
			//IL_0039: Expected Obj, but got Unknown
			//IL_00a7: Expected Obj, but got I
			//IL_0080: Expected Obj, but got I
			_superSneakerPickupsCollected = value;
			if (value == 0)
			{
				nint num = 0;
				nint num2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S3_v4 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<PowerupType, System.Boolean>>)+54]");
				object obj = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v30 @ S3_v5+4] (should have been resolved before IL gen)");
				object obj3 = default;
				object obj2 = obj3 ^ -1;
				object obj4 = obj2 >> 31;
				if (obj4 != null)
				{
					nint num3 = 0;
					nint num4 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ S5_v9 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<PowerupType, System.Boolean>>)+5C]");
					object obj5 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v77 @ S5_v10+4] (should have been resolved before IL gen)");
				}
				else
				{
					nint num5 = 0;
					nint num6 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ S5_v4 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<PowerupType, System.Boolean>>)+5C]");
					object obj6 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v88 @ S5_v5+4] (should have been resolved before IL gen)");
				}
			}
		}
	}

	public int SuperSneakerPickupsCollectedRun => _superSneakerPickupsCollectedRun;

	public int PogoStickPickupsCollected
	{
		get
		{
			return _pogoStickPickupsCollected;
		}
		private set
		{
			//IL_0021: Expected Obj, but got I
			//IL_0034: Unknown result type (might be due to invalid IL or missing references)
			//IL_0039: Expected Obj, but got Unknown
			//IL_00a7: Expected Obj, but got I
			//IL_0080: Expected Obj, but got I
			_pogoStickPickupsCollected = value;
			if (value == 0)
			{
				nint num = 0;
				nint num2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S3_v4 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<PowerupType, System.Boolean>>)+54]");
				object obj = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v30 @ S3_v5+4] (should have been resolved before IL gen)");
				object obj3 = default;
				object obj2 = obj3 ^ -1;
				object obj4 = obj2 >> 31;
				if (obj4 != null)
				{
					nint num3 = 0;
					nint num4 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ S5_v9 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<PowerupType, System.Boolean>>)+5C]");
					object obj5 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v77 @ S5_v10+4] (should have been resolved before IL gen)");
				}
				else
				{
					nint num5 = 0;
					nint num6 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ S5_v4 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<PowerupType, System.Boolean>>)+5C]");
					object obj6 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v88 @ S5_v5+4] (should have been resolved before IL gen)");
				}
			}
		}
	}

	public int PogoStickPickupsCollectedRun => _pogoStickPickupsCollectedRun;

	public int DailyLetterPickupsCollected => _dailyLetterPickupsCollected;

	public int DailyLetterPickupsCollectedRun => _dailyLetterPickupsCollectedRun;

	public int CharacterLetterPickupsCollected => _characterLetterPickupsCollected;

	public int CharacterLetterPickupsCollectedRun => _characterLetterPickupsCollectedRun;

	public int CoinMagnetPickupsCollected
	{
		get
		{
			return _coinMagnetPickupsCollected;
		}
		private set
		{
			//IL_0021: Expected Obj, but got I
			//IL_0034: Unknown result type (might be due to invalid IL or missing references)
			//IL_0039: Expected Obj, but got Unknown
			//IL_00a7: Expected Obj, but got I
			//IL_0080: Expected Obj, but got I
			_coinMagnetPickupsCollected = value;
			if (value == 0)
			{
				nint num = 0;
				nint num2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S3_v4 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<PowerupType, System.Boolean>>)+54]");
				object obj = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v30 @ S3_v5+4] (should have been resolved before IL gen)");
				object obj3 = default;
				object obj2 = obj3 ^ -1;
				object obj4 = obj2 >> 31;
				if (obj4 != null)
				{
					nint num3 = 0;
					nint num4 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ S5_v9 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<PowerupType, System.Boolean>>)+5C]");
					object obj5 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v77 @ S5_v10+4] (should have been resolved before IL gen)");
				}
				else
				{
					nint num5 = 0;
					nint num6 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ S5_v4 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<PowerupType, System.Boolean>>)+5C]");
					object obj6 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v88 @ S5_v5+4] (should have been resolved before IL gen)");
				}
			}
		}
	}

	public int CoinMagnetPickupsCollectedRun => _coinMagnetPickupsCollectedRun;

	public int MysteryBoxPickupsCollected => _mysteryBoxPickupsCollected;

	public int MysteryBoxPickupsCollectedRun => _mysteryBoxPickupsCollectedRun;

	public int SuperMysteryBoxPickupsCollected => _superMysteryBoxPickupsCollected;

	public int SuperMysteryBoxPickupsCollectedRun => _superMysteryBoxPickupsCollectedRun;

	public int DoubleMultiplierPickupsCollected
	{
		get
		{
			return _doubleMultiplierPickupsCollected;
		}
		private set
		{
			//IL_0021: Expected Obj, but got I
			//IL_0034: Unknown result type (might be due to invalid IL or missing references)
			//IL_0039: Expected Obj, but got Unknown
			//IL_00a7: Expected Obj, but got I
			//IL_0080: Expected Obj, but got I
			_doubleMultiplierPickupsCollected = value;
			if (value == 0)
			{
				nint num = 0;
				nint num2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S3_v4 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<PowerupType, System.Boolean>>)+54]");
				object obj = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v30 @ S3_v5+4] (should have been resolved before IL gen)");
				object obj3 = default;
				object obj2 = obj3 ^ -1;
				object obj4 = obj2 >> 31;
				if (obj4 != null)
				{
					nint num3 = 0;
					nint num4 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ S5_v9 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<PowerupType, System.Boolean>>)+5C]");
					object obj5 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v77 @ S5_v10+4] (should have been resolved before IL gen)");
				}
				else
				{
					nint num5 = 0;
					nint num6 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ S5_v4 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<PowerupType, System.Boolean>>)+5C]");
					object obj6 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v88 @ S5_v5+4] (should have been resolved before IL gen)");
				}
			}
		}
	}

	public int DoubleMultiplierPickupsCollectedRun => _doubleMultiplierPickupsCollectedRun;

	public int HuntTokensCollected => _huntTokensCollected;

	public int HuntTokensCollectedRun => _huntTokensCollectedRun;

	public int KeyPickupsCollected => _keyPickupsCollected;

	public int KeyPickupsCollectedRun => _keyPickupsCollectedRun;

	public static GameStats Instance
	{
		get
		{
			bool flag = instance == null;
			bool flag2 = !flag;
			GameStats result = instance;
			if (!flag2)
			{
				GameStats gameStats = default;
				gameStats._002Ector();
				instance = gameStats;
				result = gameStats;
			}
			return result;
		}
	}

	public event Action OnCoinsChanged
	{
		add
		{
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected Obj, but got Unknown
			object obj = this + 276;
			Delegate obj2 = this.m_OnCoinsChanged;
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
			object obj = this + 276;
			Delegate obj2 = this.m_OnCoinsChanged;
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

	public event Action OnCoinsIncreased
	{
		add
		{
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected Obj, but got Unknown
			object obj = this + 280;
			Delegate obj2 = this.m_OnCoinsIncreased;
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
			object obj = this + 280;
			Delegate obj2 = this.m_OnCoinsIncreased;
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

	public event Action OnScoreChanged
	{
		add
		{
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected Obj, but got Unknown
			object obj = this + 284;
			Delegate obj2 = this.m_OnScoreChanged;
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
			object obj = this + 284;
			Delegate obj2 = this.m_OnScoreChanged;
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

	public event Action OnJumpsChanged
	{
		add
		{
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected Obj, but got Unknown
			object obj = this + 288;
			Delegate obj2 = this.m_OnJumpsChanged;
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
			object obj = this + 288;
			Delegate obj2 = this.m_OnJumpsChanged;
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

	public event Action OnRollsChanged
	{
		add
		{
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected Obj, but got Unknown
			object obj = this + 292;
			Delegate obj2 = this.m_OnRollsChanged;
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
			object obj = this + 292;
			Delegate obj2 = this.m_OnRollsChanged;
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

	public event Action<PowerupType> PowerupTriggered
	{
		add
		{
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected Obj, but got Unknown
			object obj = this + 296;
			Delegate obj2 = this.m_PowerupTriggered;
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
			object obj = this + 296;
			Delegate obj2 = this.m_PowerupTriggered;
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

	private GameStats()
	{
		//IL_0076: Expected VT, but got Obj
		nint num = 0;
		nint num2 = 0;
		IntPtr intPtr = num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v26 @ S4_v4 (Il2CppClass<Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.Int32, System.Int32>>>)+4] (should have been resolved before IL gen)");
		Dictionary<int, int> spawnedPickupsLastRun = default;
		_spawnedPickupsLastRun = spawnedPickupsLastRun;
		nint num3 = 0;
		nint num4 = 0;
		IntPtr intPtr2 = num4;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v48 @ S4_v9 (Il2CppClass<Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.Int32, System.Int32>>>)+4] (should have been resolved before IL gen)");
		Dictionary<int, int> powerupActivationCountsLastRun = default;
		_powerupActivationCountsLastRun = powerupActivationCountsLastRun;
		nint num5 = 0;
		nint num6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v69 @ S4_v14 (Il2CppClass<Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.Int32, System.Int32>>>)+4] (should have been resolved before IL gen)");
		Dictionary<int, int> mysteryPowerupActivationCountsLastRun = default;
		_mysteryPowerupActivationCountsLastRun = mysteryPowerupActivationCountsLastRun;
		List<ActivePowerup> list = default;
		list._002Ector();
		_listOfActivePowerups = list;
		nint num7 = 0;
		nint num8 = 0;
		IntPtr intPtr3 = num8;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v100 @ S4_v19 (Il2CppClass<Il2CppRgctx<System.Collections.Generic.Dictionary`2<PowerupType, System.Boolean>>>)+4] (should have been resolved before IL gen)");
		Dictionary<PowerupType, bool> missionEachPowerupPickupStatus = default;
		_missionEachPowerupPickupStatus = missionEachPowerupPickupStatus;
		_00210 val = (_00210)SingletonMonobehavior<>.Instance;
		throw new ArgumentException();
	}

	public void CoinsSpawnedIncrement()
	{
		int coinsSpawned = _coinsSpawned + 1;
		_coinsSpawned = coinsSpawned;
		int coinsSpawnedRun = _coinsSpawnedRun + 1;
		_coinsSpawnedRun = coinsSpawnedRun;
	}

	public void CoinsCollectedRawIncrement()
	{
		int coinsCollectedRaw = _coinsCollectedRaw + 1;
		_coinsCollectedRaw = coinsCollectedRaw;
		int coinsCollectedRawRun = _coinsCollectedRawRun + 1;
		_coinsCollectedRawRun = coinsCollectedRawRun;
	}

	public void CoinsCollectedIncrement(int count)
	{
		if (count >= 1)
		{
			int coinsCollected = CoinsCollected;
			int coinsCollected2 = coinsCollected + count;
			CoinsCollected = coinsCollected2;
			int coinsCollectedRun = CoinsCollectedRun;
			int coinsCollectedRun2 = coinsCollectedRun + count;
			CoinsCollectedRun = coinsCollectedRun2;
			Action onCoinsIncreased = this.m_OnCoinsIncreased;
			if (this.m_OnCoinsIncreased != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v51.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
			}
			MissionsManager missionsManager = MissionsManager.Instance;
			PlayerInfo playerInfo = PlayerInfo.Instance;
			int magnitude = 2;
			if (!playerInfo._hasDoubleCoinsUpgrade)
			{
				magnitude = 1;
			}
			missionsManager.PlayerDidThis(MissionTarget.EarnCoin, magnitude);
			MissionsManager missionsManager2 = MissionsManager.Instance;
			missionsManager2.RemoveProgressForThis(MissionTarget.NoCoinsWithoutScore);
		}
	}

	public void CoinsWithJetpackIncrement()
	{
		int coinsWithJetpack = _coinsWithJetpack + 1;
		_coinsWithJetpack = coinsWithJetpack;
		MissionsManager missionsManager = MissionsManager.Instance;
		missionsManager.PlayerDidThisCoinMission(MissionTarget.CoinsWithJetpack);
	}

	public void CoinsWithPogoStickIncrement()
	{
		int coinsWithPogoStick = _coinsWithPogoStick + 1;
		_coinsWithPogoStick = coinsWithPogoStick;
		MissionsManager missionsManager = MissionsManager.Instance;
		missionsManager.PlayerDidThisCoinMission(MissionTarget.CollectCoinsWithPowerJumper);
	}

	public void CoinsInAirIncrement()
	{
		int coinsInAir = _coinsInAir + 1;
		_coinsInAir = coinsInAir;
		MissionsManager missionsManager = MissionsManager.Instance;
		missionsManager.PlayerDidThisCoinMission(MissionTarget.EarnCoinWithoutTouchingGround);
	}

	public void CoinsCollectedOnLeftTrackIncrement()
	{
		int coinCollectedOnLeftTrack = _coinCollectedOnLeftTrack + 1;
		_coinCollectedOnLeftTrack = coinCollectedOnLeftTrack;
		MissionsManager missionsManager = MissionsManager.Instance;
		missionsManager.PlayerDidThisCoinMission(MissionTarget.CollectCoinsLeftLane);
	}

	public void CoinsCollectedOnCenterTrackIncrement()
	{
		int coinsCollectedOnCenterTrack = _coinsCollectedOnCenterTrack + 1;
		_coinsCollectedOnCenterTrack = coinsCollectedOnCenterTrack;
		MissionsManager missionsManager = MissionsManager.Instance;
		missionsManager.PlayerDidThisCoinMission(MissionTarget.CollectCoinsCenterLane);
	}

	public void CoinsCollectedOnRightTrackIncrement()
	{
		int coinsCollectedOnRightTrack = _coinsCollectedOnRightTrack + 1;
		_coinsCollectedOnRightTrack = coinsCollectedOnRightTrack;
		MissionsManager missionsManager = MissionsManager.Instance;
		missionsManager.PlayerDidThisCoinMission(MissionTarget.CollectCoinsRightLane);
	}

	public void CoinMagnetCountIncrement()
	{
		int coinsWithCoinMagnetCount = _coinsWithCoinMagnetCount + 1;
		_coinsWithCoinMagnetCount = coinsWithCoinMagnetCount;
		MissionsManager missionsManager = MissionsManager.Instance;
		missionsManager.PlayerDidThisCoinMission(MissionTarget.CoinsWithMagnet);
	}

	public void ScoreBoosterTierIncrement()
	{
		int scoreBoosterTier = _scoreBoosterTier + 1;
		ScoreBoosterTier = scoreBoosterTier;
		int scoreBoosterTierRun = _scoreBoosterTierRun + 1;
		_scoreBoosterTierRun = scoreBoosterTierRun;
	}

	public void CalculateScore()
	{
		//IL_00a6: Expected F8, but got I4
		//IL_0290: Expected Obj, but got I4
		//IL_02ba: Expected I4, but got F8
		//IL_02da: Expected I4, but got F8
		//IL_00cb: Expected I4, but got F8
		//IL_00f0: Expected I4, but got F8
		//IL_0115: Expected I4, but got F8
		//IL_01ce: Expected I4, but got F8
		//IL_020c: Expected I4, but got F8
		if (!(_metersLastUsedForScore < _metersInCurrentGame))
		{
			return;
		}
		float meterScore = _metersInCurrentGame - _metersLastUsedForScore;
		_meterScore = meterScore;
		_metersLastUsedForScore = _metersInCurrentGame;
		PlayerInfo playerInfo = PlayerInfo.Instance;
		int scoreMultiplier = playerInfo.scoreMultiplier;
		double num = (double)_meterScore * (double)scoreMultiplier;
		double num2 = Math.Abs(num);
		if (!(num2 < 2147483648.0))
		{
			num = -2147483648.0;
		}
		int num3 = ConsumeAmountNeededToAdjustScoreBy(4);
		object obj = num3 * scoreMultiplier;
		double num4 = num + (double)obj;
		double num5 = num4 + (double)_score;
		_score = (int)num5;
		MissionsManager missionsManager = MissionsManager.Instance;
		missionsManager.PlayerDidThis(MissionTarget.Score, (int)num4);
		MissionsManager missionsManager2 = MissionsManager.Instance;
		missionsManager2.PlayerDidThis(MissionTarget.NoCoinsWithoutScore, (int)num4);
		MissionsManager missionsManager3 = MissionsManager.Instance;
		missionsManager3.PlayerDidThis(MissionTarget.NoRollsWithoutScore, (int)num4);
		MissionsManager missionsManager4 = MissionsManager.Instance;
		missionsManager4.PlayerDidThis(MissionTarget.NoJumpsWithoutScore, (int)num4);
		List<ActivePowerup> listOfActivePowerups = _listOfActivePowerups;
		if (listOfActivePowerups._size == 0)
		{
			goto IL_01ae;
		}
		List<ActivePowerup> listOfActivePowerups2 = _listOfActivePowerups;
		if (listOfActivePowerups2._size == 1)
		{
			ActivePowerup activePowerup = _listOfActivePowerups.get_Item(0);
			if (activePowerup.type == PowerupType.hoverboard)
			{
				goto IL_01ae;
			}
		}
		goto IL_01d3;
		IL_01ae:
		MissionsManager missionsManager5 = MissionsManager.Instance;
		missionsManager5.PlayerDidThis(MissionTarget.NoPowerUpsWithoutScore, (int)num4);
		goto IL_01d3;
		IL_01d3:
		if (~(_scoreBoosterActivated ? 1u : 0u) == 0)
		{
			MissionsManager missionsManager6 = MissionsManager.Instance;
			missionsManager6.PlayerDidThis(MissionTarget.ScoreWithScorebooster, (int)num4);
		}
		Action onScoreChanged = this.m_OnScoreChanged;
		if (this.m_OnScoreChanged != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v157.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
		}
	}

	public void ResetAmountNeededToAdjustScoreBy()
	{
		_amountLeftToConsume = 0;
	}

	public void IncreaseAmountNeededToAdjustScoreBy(int amount)
	{
		int amountLeftToConsume = amount + _amountLeftToConsume;
		_amountLeftToConsume = amountLeftToConsume;
	}

	private int ConsumeAmountNeededToAdjustScoreBy(int amount)
	{
		int num = default;
		if (amount >= 1 && _amountLeftToConsume >= 1)
		{
			bool flag = amount > _amountLeftToConsume;
			num = _amountLeftToConsume;
			if (!flag)
			{
				num = amount;
			}
			int amountLeftToConsume = _amountLeftToConsume - num;
			_amountLeftToConsume = amountLeftToConsume;
		}
		return num;
	}

	public void AddScoreForPickup(PowerupType type)
	{
		//IL_000e: Expected Obj, but got I4
		//IL_0039: Expected Obj, but got I4
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected Obj, but got Unknown
		//IL_0072: Expected Obj, but got I4
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Expected I4, but got Unknown
		object obj = type - 4;
		if ((nint)obj <= 6)
		{
			object obj2 = 125 >> (int)obj;
			object obj3 = obj2 & 1;
			if (obj3 != null)
			{
				object obj4 = 92 >> (int)obj;
				bool wasPowerup = (byte)(obj4 & 1) != 0;
				AddScoreForPickup(wasPowerup);
			}
		}
	}

	private void AddScoreForPickup(bool wasPowerup)
	{
		PlayerInfo playerInfo = PlayerInfo.Instance;
		int scoreMultiplier = playerInfo.scoreMultiplier;
		int num = scoreMultiplier * 30;
		int score = num + _score;
		_score = score;
		MissionsManager missionsManager = MissionsManager.Instance;
		missionsManager.PlayerDidThis(MissionTarget.Score, num);
		MissionsManager missionsManager2 = MissionsManager.Instance;
		missionsManager2.PlayerDidThis(MissionTarget.NoCoinsWithoutScore, num);
		MissionsManager missionsManager3 = MissionsManager.Instance;
		missionsManager3.PlayerDidThis(MissionTarget.NoRollsWithoutScore, num);
		MissionsManager missionsManager4 = MissionsManager.Instance;
		missionsManager4.PlayerDidThis(MissionTarget.NoJumpsWithoutScore, num);
		if (!wasPowerup)
		{
			MissionsManager missionsManager5 = MissionsManager.Instance;
			missionsManager5.PlayerDidThis(MissionTarget.NoPowerUpsWithoutScore, num);
		}
	}

	private void ResetScore()
	{
		_metersLastUsedForScore = 0f;
		_score = 0;
	}

	public void ResetGame()
	{
		BragNotifyDone = false;
		_metersLastUsedForScore = 0f;
		_score = 0;
		_amountLeftToConsume = 0;
		_coinsCollectedRaw = 0;
		_coinsSpawned = 0;
		CoinsCollected = 0;
		_scoreBoosterActivated = false;
		_coinsWithJetpack = 0;
		_coinsWithCoinMagnetCount = 0;
		ScoreBoosterTier = 0;
		_jumps = 0;
		_metersInCurrentGame = 0f;
		_rollCount = 0;
		Action onRollsChanged = this.m_OnRollsChanged;
		if (this.m_OnRollsChanged != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v32.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
		}
		_rollsLeftTrackCount = 0;
		_barrierHitCount = 0;
		_rollsRightTrackCount = 0;
		_jumpBarrierCount = 0;
		_trainHitCount = 0;
		JetpackPickupsCollected = 0;
		SuperSneakerPickupsCollected = 0;
		PogoStickPickupsCollected = 0;
		_characterLetterPickupsCollected = 0;
		_dailyLetterPickupsCollected = 0;
		CoinMagnetPickupsCollected = 0;
		_superMysteryBoxPickupsCollected = 0;
		_mysteryBoxPickupsCollected = 0;
		_pickedUpPowerups = 0;
		_superSneakerPickupsCollected = 0;
		DoubleMultiplierPickupsCollected = 0;
		_huntTokensCollected = 0;
		_keyPickupsCollected = 0;
		ResetRun();
	}

	public void ResetRun()
	{
		_coinsCollectedRawRun = 0;
		_coinsSpawnedRun = 0;
		CoinsCollectedRun = 0;
		_keyPickupsCollectedRun = 0;
		_doubleMultiplierPickupsCollectedRun = 0;
		_superMysteryBoxPickupsCollectedRun = 0;
		_mysteryBoxPickupsCollectedRun = 0;
		_coinMagnetPickupsCollectedRun = 0;
		_characterLetterPickupsCollectedRun = 0;
		_dailyLetterPickupsCollectedRun = 0;
		_pogoStickPickupsCollectedRun = 0;
		_superSneakerPickupsCollectedRun = 0;
		_jetpackPickupsCollectedRun = 0;
		_stumblesRun = 0;
		_scoreBoosterTierRun = 0;
		_huntTokensCollectedRun = 0;
		throw new IndexOutOfRangeException();
	}

	private unsafe void PickupManager_OnPickupSpawned(object sender, PickupManager.PickupEventArgs args)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0029: Expected Obj, but got I
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected Ref, but got Unknown
		//IL_006c: Expected Obj, but got I
		//IL_0081: Expected Obj, but got I
		//IL_009d: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 16;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [args @ L2 (System.Object)+C]");
		object obj3 = 0;
		ref int value = ref *(int*)(obj + 12);
		Dictionary<int, int> spawnedPickupsLastRun = _spawnedPickupsLastRun;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S1_v5+8]");
		bool flag = spawnedPickupsLastRun.TryGetValue(0, out value);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
		object obj4 = (nint)0 + (nint)1;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [args @ L2 (System.Object)+C]");
		object obj5 = 0;
		nint num = 0;
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ S5_v3 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.Int32, System.Int32>>)+5C]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v53 @ S5_v4+4] (should have been resolved before IL gen)");
	}

	public unsafe int GetPickupCountSpawnedLastRun(PickupType pickup)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected Ref, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		_ = 0;
		bool flag = _spawnedPickupsLastRun.TryGetValue((int)pickup, out *(int*)(obj + 12));
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
		return 0;
	}

	public unsafe ActivePowerup TriggerPowerup(PowerupType type, bool triggeredViaMysteryPowerup = false)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0216: Unknown result type (might be due to invalid IL or missing references)
		//IL_021b: Expected Ref, but got Unknown
		//IL_0248: Expected Obj, but got I
		//IL_0269: Expected Obj, but got I
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected Ref, but got Unknown
		//IL_004e: Expected Obj, but got I
		//IL_006f: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 16;
		_ = 0;
		bool flag = _powerupActivationCountsLastRun.TryGetValue((int)type, out *(int*)(obj + 12));
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
		object obj3 = (nint)0 + (nint)1;
		nint num = 0;
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ S5_v3 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.Int32, System.Int32>>)+5C]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v49 @ S5_v4+4] (should have been resolved before IL gen)");
		if (triggeredViaMysteryPowerup)
		{
			bool flag2 = _mysteryPowerupActivationCountsLastRun.TryGetValue((int)type, out *(int*)(obj + 12));
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
			object obj5 = (nint)0 + (nint)1;
			nint num3 = 0;
			nint num4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ S5_v9 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.Int32, System.Int32>>)+5C]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v98 @ S5_v10+4] (should have been resolved before IL gen)");
		}
		ActivePowerup activePowerup = default;
		activePowerup.type = type;
		float time = Time.time;
		activePowerup.timeActivated = time;
		PlayerInfo playerInfo = PlayerInfo.Instance;
		float powerupDuration = playerInfo.GetPowerupDuration(type);
		activePowerup.timeLeft = powerupDuration;
		List<ActivePowerup> listOfActivePowerups = _listOfActivePowerups;
		int num5 = listOfActivePowerups._size;
		while (true)
		{
			int num6 = num5 - 1;
			if (num6 <= -1)
			{
				break;
			}
			ActivePowerup activePowerup2 = _listOfActivePowerups.get_Item(num6);
			bool flag3 = activePowerup2.type != activePowerup.type;
			num5 = num6;
			if (!flag3)
			{
				_listOfActivePowerups.RemoveAt(num6);
				num5 = num6;
			}
		}
		AddScoreForPickup(type);
		_listOfActivePowerups.Add(activePowerup);
		MissionsManager missionsManager = MissionsManager.Instance;
		missionsManager.RemoveProgressForThis(MissionTarget.ActivePowerups);
		List<ActivePowerup> listOfActivePowerups2 = _listOfActivePowerups;
		int num7 = listOfActivePowerups2._size;
		int num8 = 0;
		while (true)
		{
			List<ActivePowerup> listOfActivePowerups3 = _listOfActivePowerups;
			if (num8 >= listOfActivePowerups3._size)
			{
				break;
			}
			ActivePowerup activePowerup3 = _listOfActivePowerups.get_Item(num8);
			if (activePowerup3.type == PowerupType.hoverboard)
			{
				num7--;
				break;
			}
			int num9 = num8 + 1;
			num8 = num9;
		}
		MissionsManager missionsManager2 = MissionsManager.Instance;
		missionsManager2.PlayerDidThis(MissionTarget.ActivePowerups, num7);
		Action<PowerupType> powerupTriggered = this.m_PowerupTriggered;
		if (this.m_PowerupTriggered != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v212 @ S0_v53 (System.Action`1<PowerupType>)+C] (should have been resolved before IL gen)");
		}
		return activePowerup;
	}

	public unsafe int GetPowerupActivationCountLastRun(PowerupType powerup)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected Ref, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		_ = 0;
		bool flag = _powerupActivationCountsLastRun.TryGetValue((int)powerup, out *(int*)(obj + 12));
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
		return 0;
	}

	public unsafe int GetMysteryPowerupActivationCountLastRun(PowerupType powerup)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected Ref, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		_ = 0;
		bool flag = _mysteryPowerupActivationCountsLastRun.TryGetValue((int)powerup, out *(int*)(obj + 12));
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
		return 0;
	}

	public List<ActivePowerup> GetActivePowerups()
	{
		return _listOfActivePowerups;
	}

	public bool IsPowerupActive(PowerupType type)
	{
		throw new ArgumentException();
	}

	public void UpdatePowerupTimes(float deltaTime)
	{
		if (_isPausedPowerups)
		{
			return;
		}
		List<ActivePowerup> listOfActivePowerups = _listOfActivePowerups;
		int num = listOfActivePowerups._size;
		while (true)
		{
			int num2 = num - 1;
			if (num2 <= -1)
			{
				break;
			}
			Game game = Game.Instance;
			if (!game.IsInJetpackMode)
			{
				Game game2 = Game.Instance;
				if (!game2.IsInPogostickMode)
				{
					goto IL_014b;
				}
			}
			ActivePowerup activePowerup = _listOfActivePowerups.get_Item(num2);
			bool flag = activePowerup.type == PowerupType.hoverboard;
			num = num2;
			if (flag)
			{
				continue;
			}
			ActivePowerup activePowerup2 = _listOfActivePowerups.get_Item(num2);
			bool flag2 = activePowerup2.type == PowerupType.supersneakers;
			num = num2;
			if (flag2)
			{
				continue;
			}
			ActivePowerup activePowerup3 = _listOfActivePowerups.get_Item(num2);
			bool flag3 = activePowerup3.type == PowerupType.doubleJump;
			num = num2;
			if (flag3)
			{
				continue;
			}
			goto IL_014b;
			IL_014b:
			ActivePowerup activePowerup4 = _listOfActivePowerups.get_Item(num2);
			if (activePowerup4.type == PowerupType.supersneakers)
			{
				Game game3 = Game.Instance;
				CharacterModifierCollection modifiers = game3._modifiers;
				Hoverboard hoverboard = modifiers.hoverboard;
				if (~(hoverboard.isActive ? 1u : 0u) == 0)
				{
					Hoverboard hoverboard2 = Hoverboard.Instance;
					num = num2;
					if (hoverboard2.isJumper)
					{
						continue;
					}
				}
			}
			ActivePowerup activePowerup5 = _listOfActivePowerups.get_Item(num2);
			if (activePowerup5.type == PowerupType.doubleJump)
			{
				Game game4 = Game.Instance;
				CharacterModifierCollection modifiers2 = game4._modifiers;
				Hoverboard hoverboard3 = modifiers2.hoverboard;
				if (~(hoverboard3.isActive ? 1u : 0u) == 0)
				{
					Hoverboard hoverboard4 = Hoverboard.Instance;
					num = num2;
					if (hoverboard4.isDoubleJump)
					{
						continue;
					}
				}
			}
			ActivePowerup activePowerup6 = _listOfActivePowerups.get_Item(num2);
			bool flag4 = (byte)(~(activePowerup6.Paused ? 1u : 0u)) != 0;
			float num3 = deltaTime;
			if (!flag4)
			{
				ActivePowerup activePowerup7 = _listOfActivePowerups.get_Item(num2);
				if (activePowerup7.type == PowerupType.hoverboard)
				{
					ActivePowerup activePowerup8 = _listOfActivePowerups.get_Item(num2);
					bool flag5 = activePowerup8.timeLeft > 0f;
					bool flag6 = !flag5;
					num3 = deltaTime;
					if (flag6)
					{
						goto IL_0591;
					}
				}
				num3 = 0f;
			}
			goto IL_0591;
			IL_0591:
			ActivePowerup activePowerup9 = _listOfActivePowerups.get_Item(num2);
			float timeLeft = activePowerup9.timeLeft - num3;
			activePowerup9.timeLeft = timeLeft;
			ActivePowerup activePowerup10 = _listOfActivePowerups.get_Item(num2);
			bool flag7 = activePowerup10.timeLeft < 0f;
			bool flag8 = !flag7;
			num = num2;
			if (flag8)
			{
				continue;
			}
			Game game5 = Game.Instance;
			if (game5.IsInJetpackMode)
			{
				ActivePowerup activePowerup11 = _listOfActivePowerups.get_Item(num2);
				bool flag9 = activePowerup11.type == PowerupType.jetpack;
				num = num2;
				if (flag9)
				{
					continue;
				}
			}
			ActivePowerup activePowerup12 = _listOfActivePowerups.get_Item(num2);
			if (activePowerup12.type == PowerupType.hoverboard)
			{
				Hoverboard hoverboard5 = Hoverboard.Instance;
				float num4 = hoverboard5.WaitForParticlesDelay + 5f;
				float num5 = 0f - num4;
				ActivePowerup activePowerup13 = _listOfActivePowerups.get_Item(num2);
				bool flag10 = num5 < activePowerup13.timeLeft;
				num = num2;
				if (flag10)
				{
					continue;
				}
				Hoverboard hoverboard6 = Hoverboard.Instance;
				hoverboard6.HardReset();
			}
			_listOfActivePowerups.RemoveAt(num2);
			MissionsManager missionsManager = MissionsManager.Instance;
			missionsManager.RemoveProgressForThis(MissionTarget.ActivePowerups);
			List<ActivePowerup> listOfActivePowerups2 = _listOfActivePowerups;
			int num6 = listOfActivePowerups2._size;
			int num7 = 0;
			while (true)
			{
				List<ActivePowerup> listOfActivePowerups3 = _listOfActivePowerups;
				if (num7 >= listOfActivePowerups3._size)
				{
					break;
				}
				ActivePowerup activePowerup14 = _listOfActivePowerups.get_Item(num7);
				if (activePowerup14.type == PowerupType.hoverboard)
				{
					num6--;
					break;
				}
				int num8 = num7 + 1;
				num7 = num8;
			}
			MissionsManager missionsManager2 = MissionsManager.Instance;
			missionsManager2.PlayerDidThis(MissionTarget.ActivePowerups, num6);
			num = num2;
		}
	}

	public void ClearPowerups()
	{
		((List<T>)(object)_listOfActivePowerups).Clear();
		MissionsManager missionsManager = MissionsManager.Instance;
		missionsManager.RemoveProgressForThis(MissionTarget.ActivePowerups);
	}

	public void RemoveHoverBoardPowerup()
	{
		List<ActivePowerup> listOfActivePowerups = _listOfActivePowerups;
		int num = listOfActivePowerups._size;
		while (true)
		{
			int num2 = num - 1;
			if (num2 > -1)
			{
				ActivePowerup activePowerup = _listOfActivePowerups.get_Item(num2);
				bool flag = activePowerup.type != PowerupType.hoverboard;
				num = num2;
				if (!flag)
				{
					ActivePowerup activePowerup2 = _listOfActivePowerups.get_Item(num2);
					activePowerup2.timeLeft = 0f;
					num = num2;
				}
				continue;
			}
			break;
		}
	}

	public void StumbleCountIncrement()
	{
		int stumbles = _stumbles + 1;
		_stumbles = stumbles;
		int stumblesRun = _stumblesRun + 1;
		_stumblesRun = stumblesRun;
	}

	public void JumpCountIncrement()
	{
		int jumps = _jumps + 1;
		_jumps = jumps;
		Action onJumpsChanged = this.m_OnJumpsChanged;
		if (this.m_OnJumpsChanged != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v7.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
		}
		MissionsManager missionsManager = MissionsManager.Instance;
		missionsManager.PlayerDidThis(MissionTarget.Jump);
		MissionsManager missionsManager2 = MissionsManager.Instance;
		missionsManager2.RemoveProgressForThis(MissionTarget.NoJumpsWithoutScore);
	}

	public void JumpsOverTrainsCountIncrement()
	{
		int jumpsOverTrainsCount = _jumpsOverTrainsCount + 1;
		_jumpsOverTrainsCount = jumpsOverTrainsCount;
		MissionsManager missionsManager = MissionsManager.Instance;
		missionsManager.PlayerDidThis(MissionTarget.JumpTrain);
	}

	public void RollCountIncrement()
	{
		int rollCount = _rollCount + 1;
		_rollCount = rollCount;
		Action onRollsChanged = this.m_OnRollsChanged;
		if (this.m_OnRollsChanged != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v7.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
		}
		MissionsManager missionsManager = MissionsManager.Instance;
		missionsManager.PlayerDidThis(MissionTarget.Roll);
		MissionsManager missionsManager2 = MissionsManager.Instance;
		missionsManager2.RemoveProgressForThis(MissionTarget.NoRollsWithoutScore);
	}

	public void RollsLeftTrackCountIncrement()
	{
		int rollsLeftTrackCount = _rollsLeftTrackCount + 1;
		_rollsLeftTrackCount = rollsLeftTrackCount;
		MissionsManager missionsManager = MissionsManager.Instance;
		missionsManager.PlayerDidThis(MissionTarget.RollLeft);
	}

	public void RollsCenterTrackCountIncrement()
	{
		int rollsCenterTrackCount = _rollsCenterTrackCount + 1;
		_rollsCenterTrackCount = rollsCenterTrackCount;
		MissionsManager missionsManager = MissionsManager.Instance;
		missionsManager.PlayerDidThis(MissionTarget.RollCenter);
	}

	public void RollsRightTrackCountIncrement()
	{
		int rollsRightTrackCount = _rollsRightTrackCount + 1;
		_rollsRightTrackCount = rollsRightTrackCount;
		MissionsManager missionsManager = MissionsManager.Instance;
		missionsManager.PlayerDidThis(MissionTarget.RollRight);
	}

	public void DodgeBarrierCountIncrement()
	{
		Game game = Game.Instance;
		if (!game.isDead)
		{
			Game game2 = Game.Instance;
			if (!game2._isInStumbleDeathSequence)
			{
				int dodgeBarrierCount = _dodgeBarrierCount + 1;
				_dodgeBarrierCount = dodgeBarrierCount;
				MissionsManager missionsManager = MissionsManager.Instance;
				missionsManager.PlayerDidThis(MissionTarget.RollUnderBarriers);
				MissionsManager missionsManager2 = MissionsManager.Instance;
				missionsManager2.PlayerDidThis(MissionTarget.DodgeBarriers);
			}
		}
	}

	public void JumpBarrierCountIncrement()
	{
		Game game = Game.Instance;
		if (!game.isDead)
		{
			Game game2 = Game.Instance;
			if (!game2._isInStumbleDeathSequence)
			{
				int jumpBarrierCount = _jumpBarrierCount + 1;
				_jumpBarrierCount = jumpBarrierCount;
				MissionsManager missionsManager = MissionsManager.Instance;
				missionsManager.PlayerDidThis(MissionTarget.JumpBarriers);
				MissionsManager missionsManager2 = MissionsManager.Instance;
				missionsManager2.PlayerDidThis(MissionTarget.DodgeBarriers);
			}
		}
	}

	public void JumpHighBarrierCountIncrement()
	{
		int jumpHighBarrierCount = _jumpHighBarrierCount + 1;
		_jumpHighBarrierCount = jumpHighBarrierCount;
	}

	public void TrainHitCountIncrement()
	{
		int trainHitCount = _trainHitCount + 1;
		_trainHitCount = trainHitCount;
		MissionsManager missionsManager = MissionsManager.Instance;
		missionsManager.PlayerDidThis(MissionTarget.CrashTrains);
	}

	public void BarrierHitCountIncrement()
	{
		int barrierHitCount = _barrierHitCount + 1;
		_barrierHitCount = barrierHitCount;
		MissionsManager missionsManager = MissionsManager.Instance;
		missionsManager.PlayerDidThis(MissionTarget.CrashBarriers);
	}

	public void JetpackPickupsCollectedIncrement()
	{
		int jetpackPickupsCollected = _jetpackPickupsCollected + 1;
		JetpackPickupsCollected = jetpackPickupsCollected;
		int jetpackPickupsCollectedRun = _jetpackPickupsCollectedRun + 1;
		_jetpackPickupsCollectedRun = jetpackPickupsCollectedRun;
		ReportOneOfEachPowerupIfApplicable(PowerupType.jetpack);
		MissionsManager missionsManager = MissionsManager.Instance;
		missionsManager.PlayerDidThis(MissionTarget.Jetpack);
	}

	public void SuperSneakerPickupsCollectedIncrement()
	{
		int superSneakerPickupsCollected = _superSneakerPickupsCollected + 1;
		SuperSneakerPickupsCollected = superSneakerPickupsCollected;
		int superSneakerPickupsCollectedRun = _superSneakerPickupsCollectedRun + 1;
		_superSneakerPickupsCollectedRun = superSneakerPickupsCollectedRun;
		ReportOneOfEachPowerupIfApplicable(PowerupType.supersneakers);
		MissionsManager missionsManager = MissionsManager.Instance;
		missionsManager.PlayerDidThis(MissionTarget.SuperSneakers);
	}

	public void PogoStickPickupsCollectedIncrement()
	{
		int pogoStickPickupsCollected = _pogoStickPickupsCollected + 1;
		PogoStickPickupsCollected = pogoStickPickupsCollected;
		int pogoStickPickupsCollectedRun = _pogoStickPickupsCollectedRun + 1;
		_pogoStickPickupsCollectedRun = pogoStickPickupsCollectedRun;
		MissionsManager missionsManager = MissionsManager.Instance;
		missionsManager.PlayerDidThis(MissionTarget.PickUpPowerJumpers);
		MissionsManager missionsManager2 = MissionsManager.Instance;
		missionsManager2.PlayerDidThis(MissionTarget.PickUpPowerJumpersSingleRun);
		ReportOneOfEachPowerupIfApplicable(PowerupType.pogostick);
	}

	public void DailyLetterPickupsCollectedIncrement()
	{
		int dailyLetterPickupsCollected = _dailyLetterPickupsCollected + 1;
		_dailyLetterPickupsCollected = dailyLetterPickupsCollected;
		int dailyLetterPickupsCollectedRun = _dailyLetterPickupsCollectedRun + 1;
		_dailyLetterPickupsCollectedRun = dailyLetterPickupsCollectedRun;
		MissionsManager missionsManager = MissionsManager.Instance;
		missionsManager.PlayerDidThis(MissionTarget.Letters);
	}

	public void CharacterLetterPickupsCollectedIncrement()
	{
		int characterLetterPickupsCollected = _characterLetterPickupsCollected + 1;
		_characterLetterPickupsCollected = characterLetterPickupsCollected;
		int characterLetterPickupsCollectedRun = _characterLetterPickupsCollectedRun + 1;
		_characterLetterPickupsCollectedRun = characterLetterPickupsCollectedRun;
	}

	public void CoinMagnetPickupsCollectedIncrement()
	{
		int coinMagnetPickupsCollected = _coinMagnetPickupsCollected + 1;
		CoinMagnetPickupsCollected = coinMagnetPickupsCollected;
		int coinMagnetPickupsCollectedRun = _coinMagnetPickupsCollectedRun + 1;
		_coinMagnetPickupsCollectedRun = coinMagnetPickupsCollectedRun;
		ReportOneOfEachPowerupIfApplicable(PowerupType.coinmagnet);
		MissionsManager missionsManager = MissionsManager.Instance;
		missionsManager.PlayerDidThis(MissionTarget.Magnets);
	}

	public void MysteryBoxPickupsCollectedInrement()
	{
		int mysteryBoxPickupsCollected = _mysteryBoxPickupsCollected + 1;
		_mysteryBoxPickupsCollected = mysteryBoxPickupsCollected;
		int mysteryBoxPickupsCollectedRun = _mysteryBoxPickupsCollectedRun + 1;
		_mysteryBoxPickupsCollectedRun = mysteryBoxPickupsCollectedRun;
		MissionsManager missionsManager = MissionsManager.Instance;
		missionsManager.PlayerDidThis(MissionTarget.MysteryBoxes);
	}

	public void SuperMysteryBoxPickupsCollectedIncrement()
	{
		int superMysteryBoxPickupsCollected = _superMysteryBoxPickupsCollected + 1;
		_superMysteryBoxPickupsCollected = superMysteryBoxPickupsCollected;
		int superMysteryBoxPickupsCollectedRun = _superMysteryBoxPickupsCollectedRun + 1;
		_superMysteryBoxPickupsCollectedRun = superMysteryBoxPickupsCollectedRun;
	}

	public void DoubleMultiplierPickupsCollectedIncrement()
	{
		int doubleMultiplierPickupsCollected = _doubleMultiplierPickupsCollected + 1;
		DoubleMultiplierPickupsCollected = doubleMultiplierPickupsCollected;
		int doubleMultiplierPickupsCollectedRun = _doubleMultiplierPickupsCollectedRun + 1;
		_doubleMultiplierPickupsCollectedRun = doubleMultiplierPickupsCollectedRun;
		ReportOneOfEachPowerupIfApplicable(PowerupType.doubleMultiplier);
		MissionsManager missionsManager = MissionsManager.Instance;
		missionsManager.PlayerDidThis(MissionTarget.DoubleMultiplier);
	}

	public void HuntTokensCollectedIncrement()
	{
		int huntTokensCollected = _huntTokensCollected + 1;
		_huntTokensCollected = huntTokensCollected;
		int huntTokensCollectedRun = _huntTokensCollectedRun + 1;
		_huntTokensCollectedRun = huntTokensCollectedRun;
	}

	private void ReportOneOfEachPowerupIfApplicable(PowerupType powerupType)
	{
		//IL_0021: Expected Obj, but got I
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected Obj, but got Unknown
		//IL_00a1: Expected Obj, but got I
		MissionsManager missionsManager = MissionsManager.Instance;
		if (missionsManager.IsMissionTargetActive(MissionTarget.OneOfEachPowerup))
		{
			nint num = 0;
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S3_v4 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<PowerupType, System.Boolean>>)+54]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v32 @ S3_v5+4] (should have been resolved before IL gen)");
			object obj3 = default;
			object obj2 = obj3 ^ -1;
			object obj4 = obj2 >> 31;
			if (obj4 != null && !_missionEachPowerupPickupStatus.get_Item(powerupType))
			{
				nint num3 = 0;
				nint num4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ S5_v4 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<PowerupType, System.Boolean>>)+5C]");
				object obj5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v78 @ S5_v5+4] (should have been resolved before IL gen)");
				MissionsManager missionsManager2 = MissionsManager.Instance;
				missionsManager2.PlayerDidThis(MissionTarget.OneOfEachPowerup);
			}
		}
	}

	public void PickedUpPowerupsIncrement()
	{
		int pickedUpPowerups = _pickedUpPowerups + 1;
		_pickedUpPowerups = pickedUpPowerups;
		PlayerInfo playerInfo = PlayerInfo.Instance;
		Statistics stats = playerInfo._stats;
		int[] values = stats._values;
		int value = values[25] + 1;
		stats.set_Item(Stat.PickupPowerup, value);
		MissionsManager missionsManager = MissionsManager.Instance;
		missionsManager.PlayerDidThis(MissionTarget.Powerups);
		MissionsManager missionsManager2 = MissionsManager.Instance;
		missionsManager2.RemoveProgressForThis(MissionTarget.NoPowerUpsWithoutScore);
	}

	public void KeyPickupsCollectedIncrement()
	{
		int keyPickupsCollected = _keyPickupsCollected + 1;
		_keyPickupsCollected = keyPickupsCollected;
		int keyPickupsCollectedRun = _keyPickupsCollectedRun + 1;
		_keyPickupsCollectedRun = keyPickupsCollectedRun;
		MissionsManager missionsManager = MissionsManager.Instance;
		missionsManager.PlayerDidThis(MissionTarget.PickupKeys);
	}

	public static int CoinToScoreConversion(int coins)
	{
		PlayerInfo playerInfo = PlayerInfo.Instance;
		int num = playerInfo._currentMissionSet + 1;
		if (num >= 30)
		{
			num = 30;
		}
		if (num <= 1)
		{
			num = 1;
		}
		return num;
	}
}
