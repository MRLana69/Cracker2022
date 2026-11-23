using SYBO.Subway.Characters;
using UnityEngine;

public class CharacterStats : MonoBehaviour
{
	private GameStats stats;

	private Character character;

	public unsafe void Start()
	{
		GameStats instance = GameStats.Instance;
		stats = instance;
		Character component = GetComponent<Character>();
		character = component;
		Character.OnJumpDelegate onJumpDelegate = default;
		onJumpDelegate._002Ector(this, (nint)__ldftn(CharacterStats.OnJump));
		character.OnJump += onJumpDelegate;
		Character.OnRollDelegate onRollDelegate = default;
		onRollDelegate._002Ector(this, (nint)__ldftn(CharacterStats.OnRoll));
		character.OnRoll += onRollDelegate;
		Character.OnPassedObstacleDelegate onPassedObstacleDelegate = default;
		onPassedObstacleDelegate._002Ector(this, (nint)__ldftn(CharacterStats.OnPassedObstacle));
		character.OnPassedObstacle += onPassedObstacleDelegate;
		Character.OnJumpOverTrainDelegate onJumpOverTrainDelegate = default;
		onJumpOverTrainDelegate._002Ector(this, (nint)__ldftn(CharacterStats.OnJumpOverTrain));
		character.OnJumpOverTrain += onJumpOverTrainDelegate;
		Character.OnCriticalHitDelegate onCriticalHitDelegate = default;
		onCriticalHitDelegate._002Ector(this, (nint)__ldftn(CharacterStats.OnCriticalHit));
		character.OnCriticalHit += onCriticalHitDelegate;
		Character.OnStumbleDelegate onStumbleDelegate = default;
		onStumbleDelegate._002Ector(this, (nint)__ldftn(CharacterStats.OnStumble));
		character.OnStumble += onStumbleDelegate;
	}

	private void OnJump(float jumpHeight, bool willPlaySound)
	{
		stats.JumpCountIncrement();
	}

	private void OnRoll()
	{
		stats.RollCountIncrement();
		Character character = this.character;
		bool flag = character.__trackIndex == 0;
		bool flag2 = !flag;
		int _trackIndex = character.__trackIndex;
		if (!flag2)
		{
			stats.RollsLeftTrackCountIncrement();
			Character character2 = this.character;
			_trackIndex = character2.__trackIndex;
		}
		int num;
		if (_trackIndex == 1)
		{
			stats.RollsCenterTrackCountIncrement();
			Character character3 = this.character;
			num = character3.__trackIndex;
		}
		else
		{
			num = _trackIndex;
		}
		if (num == 2)
		{
			stats.RollsRightTrackCountIncrement();
		}
	}

	private void OnPassedObstacle(Character.ObstaclePassType type)
	{
		//IL_000e: Expected Obj, but got I4
		object obj = type - 1;
		if (type != Character.ObstaclePassType.Roll)
		{
			if ((nint)obj != 1)
			{
				if ((nint)obj == 2)
				{
					stats.JumpBarrierCountIncrement();
					GameStats gameStats = stats;
					int jumpHighBarrierCount = gameStats._jumpHighBarrierCount + 1;
					gameStats._jumpHighBarrierCount = jumpHighBarrierCount;
				}
			}
			else
			{
				stats.JumpBarrierCountIncrement();
			}
		}
		else
		{
			stats.DodgeBarrierCountIncrement();
		}
	}

	private void OnJumpOverTrain()
	{
		stats.JumpsOverTrainsCountIncrement();
	}

	private void OnCriticalHit(Character.CriticalHitType type)
	{
		switch (type)
		{
		case Character.CriticalHitType.Train:
			stats.TrainHitCountIncrement();
			break;
		case Character.CriticalHitType.Barrier:
			stats.BarrierHitCountIncrement();
			break;
		case Character.CriticalHitType.MovingTrain:
		{
			GameStats gameStats = stats;
			int movingTrainHitCount = gameStats._movingTrainHit + 1;
			gameStats.MovingTrainHitCount = movingTrainHitCount;
			break;
		}
		}
	}

	private void OnStumble(Character.StumbleType stumbleType, Character.StumbleHorizontalHit horizontalHit, Character.StumbleVerticalHit verticalHit, string colliderName, bool safeStumble)
	{
		if (colliderName.Contains("lightSignal"))
		{
			MissionsManager instance = MissionsManager.Instance;
			instance.PlayerDidThis(MissionTarget.BumpLightSignal);
		}
		else if (colliderName.Contains("bush") || colliderName.Contains("powerbox"))
		{
			MissionsManager instance2 = MissionsManager.Instance;
			instance2.PlayerDidThis(MissionTarget.BumpBush);
		}
		else if (colliderName.Contains("ramp_side"))
		{
			MissionsManager instance3 = MissionsManager.Instance;
			instance3.PlayerDidThis(MissionTarget.BumpTrain);
		}
		else if (!colliderName.Contains("blocker_jump") && !colliderName.Contains("blocker_roll"))
		{
			bool flag = colliderName.Contains("blocker_standard");
			MissionsManager instance4 = MissionsManager.Instance;
			if (flag)
			{
				instance4.PlayerDidThis(MissionTarget.BumpBarrier);
			}
			else
			{
				instance4.PlayerDidThis(MissionTarget.BumpTrain);
			}
		}
		else
		{
			MissionsManager instance5 = MissionsManager.Instance;
			instance5.PlayerDidThis(MissionTarget.BumpBarrier);
		}
	}
}
