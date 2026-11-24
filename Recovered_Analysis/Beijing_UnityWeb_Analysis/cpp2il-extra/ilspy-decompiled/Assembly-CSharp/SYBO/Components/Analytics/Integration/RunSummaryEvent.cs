namespace SYBO.Components.Analytics.Integration;

public class RunSummaryEvent : SubwayBaseSessionEvent
{
	public int GameID;

	public long Score;

	public short HeadStartsUsed;

	public int HoverboardsUsed;

	public int ScoreMultiplierCollected;

	public int ScoreMultiplierSpawned;

	public short ScoreBoosterUsed;

	public long CoinsCollected;

	public long CoinsCollectedRaw;

	public long CoinsSpawned;

	public int CoinMagnetsCollected;

	public int CoinMagnetsSpawned;

	public int JetpacksCollected;

	public int JetpacksSpawned;

	public int SuperSneakersCollected;

	public int SuperSneakersSpawned;

	public int MysteryBoxesCollected;

	public int MysteryBoxesSpawned;

	public int SuperMysteryBoxesCollected;

	public int SuperMysteryBoxesSpawned;

	public int KeysCollected;

	public int KeysSpawned;

	public int DailyLettersCollected;

	public int DailyLettersSpawned;

	public int CharacterLettersCollected;

	public int CharacterLettersSpawned;

	public int TokensCollected;

	public int TokensSpawned;

	public int PogoSticksSpawned;

	public int PogoSticksCollected;

	public int MysteryPowerupsSpawned;

	public int MysteryPowerupHoverboardsCollected;

	public int MysteryPowerupDoubleCoinsCollected;

	public int MysteryPowerupDoubleJumpsCollected;

	public int MysteryPowerupPlusMultipliersCollected;

	public int NumberOfStumbles;

	public int Framerate;

	public override string EventName => "player_died";

	public RunSummaryEvent()
	{
		((SubwaySessionStartedEvent)(object)this)._002Ector();
	}
}
