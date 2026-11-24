//Type is in global namespace

public class CharacterStats : MonoBehaviour
{
	private GameStats stats; //Field offset: 0xC
	private Character character; //Field offset: 0x10

	public CharacterStats() { }

	private void OnCriticalHit(CriticalHitType type) { }

	private void OnJump(float jumpHeight, bool willPlaySound) { }

	private void OnJumpOverTrain() { }

	private void OnPassedObstacle(ObstaclePassType type) { }

	private void OnRoll() { }

	private void OnStumble(StumbleType stumbleType, StumbleHorizontalHit horizontalHit, StumbleVerticalHit verticalHit, string colliderName, bool safeStumble) { }

	public void Start() { }

}

