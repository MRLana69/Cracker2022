namespace SYBO.Subway.Visuals;

public class RoofedCulling
{
	private class CullingBlock
	{
		private Vector4 _value; //Field offset: 0x8
		public bool Low; //Field offset: 0x18
		public bool Finalized; //Field offset: 0x19

		public float CullEndGameY
		{
			 get { } //Length: 9
			 set { } //Length: 11
		}

		public float CullEndGameZ
		{
			 get { } //Length: 9
			 set { } //Length: 11
		}

		public float CullStartGameY
		{
			 get { } //Length: 9
			 set { } //Length: 11
		}

		public float CullStartGameZ
		{
			 get { } //Length: 6
			 set { } //Length: 398
		}

		public CullingBlock() { }

		public float get_CullEndGameY() { }

		public float get_CullEndGameZ() { }

		public float get_CullStartGameY() { }

		public float get_CullStartGameZ() { }

		public void set_CullEndGameY(float value) { }

		public void set_CullEndGameZ(float value) { }

		public void set_CullStartGameY(float value) { }

		public void set_CullStartGameZ(float value) { }

		public Vector4 ToVector4() { }

	}

	public class CustomRoofedCulling
	{
		public EnvironmentType EnvironmentType; //Field offset: 0x8
		public Vector4 CullingBounds; //Field offset: 0xC

		public CustomRoofedCulling() { }

	}

	private const string CurrentCullingKeyword = "_RoofedCullCurrent"; //Field offset: 0x0
	private const string NextCullingKeyword = "_RoofedCullNext"; //Field offset: 0x0
	private const string GamePositionOffsetZKeyword = "_RoofedCullingGamePositionOffsetZ"; //Field offset: 0x0
	private LinkedList<CullingBlock> _cullingBlockList; //Field offset: 0x8
	private CullingBlock _currentCullingBlock; //Field offset: 0xC
	private CullingBlock _nextCullingBlock; //Field offset: 0x10
	private CullingBlock _emptyCullingblock; //Field offset: 0x14
	private CullingBlock _menuCullingblock; //Field offset: 0x18
	private Theme _theme; //Field offset: 0x1C

	private CullingBlock CurrentCullingBlock
	{
		 get { } //Length: 1150
		 set { } //Length: 97
	}

	private CullingBlock NextCullingBlock
	{
		 get { } //Length: 6
		 set { } //Length: 129
	}

	public RoofedCulling() { }

	private void EvaluateEnvironment(EnvironmentType environmentType, out bool cullEnvironment, ref bool cullLow, ref bool cullCustom, ref Vector4 customCullingBounds) { }

	private void Game_OnGameEnded() { }

	private void Game_OnGameStarted() { }

	private CullingBlock GenerateCullingBlock(float gamePosZ, bool low) { }

	private CullingBlock GenerateCustomCullingBlock(float gamePosZ, Vector4 customCullingBounds) { }

	private CullingBlock get_CurrentCullingBlock() { }

	private CullingBlock get_NextCullingBlock() { }

	public void Initialize() { }

	private void RouteChunk_OnEnvironmentSegmentSpawned(EnvironmentKind environmentKind, int gamePositionZ, Route route) { }

	private void set_CurrentCullingBlock(CullingBlock value) { }

	private void set_NextCullingBlock(CullingBlock value) { }

	public void UpdateCulling() { }

}

