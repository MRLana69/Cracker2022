namespace SYBO.Subway.Visuals;

public class FallingSnowThemeEffect : ThemeEffect
{
	private ParticleSystem _snowPrefab; //Field offset: 0xC
	private ParticleSystem _snow; //Field offset: 0x10
	private float zOffset; //Field offset: 0x14
	private Vector3 _snowOriginalPosition; //Field offset: 0x18

	public FallingSnowThemeEffect() { }

	private void Game_OnGameEnded() { }

	private void Game_OnGameStarted() { }

	public override void Initialize(Transform root) { }

	public override void UpdateEffect() { }

}

