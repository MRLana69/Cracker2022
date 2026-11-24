namespace SYBO.Subway.Level;

public class BackgroundCulling
{
	private struct CullingBlock
	{
		public int CullingStartGamePositionZ; //Field offset: 0x0
		public int CullingEndGamePositionZ; //Field offset: 0x4

	}

	private const string BackgroundCullingAlphaPropertyName = "_BackgroundCullingAlpha"; //Field offset: 0x0
	private const float FadeOutOffset = 100; //Field offset: 0x0
	public EnvironmentType EnvironmentType; //Field offset: 0x8
	public Mesh CullingMesh; //Field offset: 0xC
	public float CullingStartOffset; //Field offset: 0x10
	private LinkedList<CullingBlock> _cullingBlocks; //Field offset: 0x14
	private Transform _transform; //Field offset: 0x18
	private MeshRenderer _renderer; //Field offset: 0x1C

	private static float CullingOffset
	{
		 get { } //Length: 6
	}

	public BackgroundCulling() { }

	private static float CalculateCullingAlpha(float gamePositionZ, CullingBlock block) { }

	private static float get_CullingOffset() { }

	public void Initialize(Material material, int renderQueue) { }

	public void Reset() { }

	public void SetCullingEndZ(int gamePositionZ) { }

	public void SetCullingStartZ(int gamePositionZ) { }

	public void UpdateCulling(float gamePositionZ) { }

}

