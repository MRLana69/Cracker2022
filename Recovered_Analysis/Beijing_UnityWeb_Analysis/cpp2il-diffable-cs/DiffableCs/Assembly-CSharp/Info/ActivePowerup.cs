namespace Info;

public class ActivePowerup
{
	public UpgradeType type; //Field offset: 0x8
	public float timeLeft; //Field offset: 0xC
	public float timeActivated; //Field offset: 0x10
	public bool Paused; //Field offset: 0x14

	public ActivePowerup() { }

}

