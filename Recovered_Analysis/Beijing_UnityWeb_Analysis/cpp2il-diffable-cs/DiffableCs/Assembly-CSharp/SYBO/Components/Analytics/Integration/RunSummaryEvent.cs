namespace SYBO.Components.Analytics.Integration;

public class RunSummaryEvent : SubwayBaseSessionEvent
{
	public int GameID; //Field offset: 0x24
	public long Score; //Field offset: 0x28
	public short HeadStartsUsed; //Field offset: 0x30
	public int HoverboardsUsed; //Field offset: 0x34
	public int ScoreMultiplierCollected; //Field offset: 0x38
	public int ScoreMultiplierSpawned; //Field offset: 0x3C
	public short ScoreBoosterUsed; //Field offset: 0x40
	public long CoinsCollected; //Field offset: 0x48
	public long CoinsCollectedRaw; //Field offset: 0x50
	public long CoinsSpawned; //Field offset: 0x58
	public int CoinMagnetsCollected; //Field offset: 0x60
	public int CoinMagnetsSpawned; //Field offset: 0x64
	public int JetpacksCollected; //Field offset: 0x68
	public int JetpacksSpawned; //Field offset: 0x6C
	public int SuperSneakersCollected; //Field offset: 0x70
	public int SuperSneakersSpawned; //Field offset: 0x74
	public int MysteryBoxesCollected; //Field offset: 0x78
	public int MysteryBoxesSpawned; //Field offset: 0x7C
	public int SuperMysteryBoxesCollected; //Field offset: 0x80
	public int SuperMysteryBoxesSpawned; //Field offset: 0x84
	public int KeysCollected; //Field offset: 0x88
	public int KeysSpawned; //Field offset: 0x8C
	public int DailyLettersCollected; //Field offset: 0x90
	public int DailyLettersSpawned; //Field offset: 0x94
	public int CharacterLettersCollected; //Field offset: 0x98
	public int CharacterLettersSpawned; //Field offset: 0x9C
	public int TokensCollected; //Field offset: 0xA0
	public int TokensSpawned; //Field offset: 0xA4
	public int PogoSticksSpawned; //Field offset: 0xA8
	public int PogoSticksCollected; //Field offset: 0xAC
	public int MysteryPowerupsSpawned; //Field offset: 0xB0
	public int MysteryPowerupHoverboardsCollected; //Field offset: 0xB4
	public int MysteryPowerupDoubleCoinsCollected; //Field offset: 0xB8
	public int MysteryPowerupDoubleJumpsCollected; //Field offset: 0xBC
	public int MysteryPowerupPlusMultipliersCollected; //Field offset: 0xC0
	public int NumberOfStumbles; //Field offset: 0xC4
	public int Framerate; //Field offset: 0xC8

	public override string EventName
	{
		 get { } //Length: 43
	}

	public RunSummaryEvent() { }

	public override string get_EventName() { }

}

