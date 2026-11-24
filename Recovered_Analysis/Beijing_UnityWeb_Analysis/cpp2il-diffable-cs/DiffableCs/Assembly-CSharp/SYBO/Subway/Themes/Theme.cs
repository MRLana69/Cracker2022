namespace SYBO.Subway.Themes;

public class Theme : ScriptableObject
{
	private class ThemePreloadSetting
	{
		private string _prefabName; //Field offset: 0x8
		private Transform _prefab; //Field offset: 0xC
		private int _preloadAmountLowPerf; //Field offset: 0x10
		private int _preloadAmountMediumPerf; //Field offset: 0x14
		private int _preloadAmountHighPerf; //Field offset: 0x18

		public Transform Prefab
		{
			 get { } //Length: 6
		}

		public ThemePreloadSetting(Transform prefab) { }

		public Transform get_Prefab() { }

		public int GetPreloadAmount(PerformanceLevel perfLevel) { }

		public void SetPreloadAmount(PerformanceLevel perfLevel, int amount) { }

	}

	public const string ThemesPath = "Assets/Themes"; //Field offset: 0x0
	public const string GenericAssetDirectoryName = "0.00_Generic"; //Field offset: 0x0
	public const string FieldPatternGroundAsset = "_groundAssets."; //Field offset: 0x0
	private const float MinFogTransitionDistance = 1; //Field offset: 0x0
	private Background _background; //Field offset: 0xC
	private DistantObjectGlobalConfig _distantObjectGlobalConfig; //Field offset: 0x10
	private DistantObjectConfig[] _distantObjectConfigs; //Field offset: 0x14
	private TransitionConfig[] _environmentTransitionConfigs; //Field offset: 0x18
	private Color _fogColor; //Field offset: 0x1C
	private float _fogStartDistance; //Field offset: 0x2C
	private float _fogEndDistance; //Field offset: 0x30
	private float _backgroundStartDistance; //Field offset: 0x34
	private float _distantFogStartDistance; //Field offset: 0x38
	private float _distantFogEndDistance; //Field offset: 0x3C
	private float _distantBackgroundStartDistance; //Field offset: 0x40
	private Color _glowGoldColor; //Field offset: 0x44
	private Material _glowGold; //Field offset: 0x54
	private float _glowGoldFalloff; //Field offset: 0x58
	private ThemeEffect[] _effects; //Field offset: 0x5C
	private bool _roofedCullingEnabled; //Field offset: 0x60
	private EnvironmentType[] _roofedCullingEnvironmentsHigh; //Field offset: 0x64
	private EnvironmentType[] _roofedCullingEnvironmentsLow; //Field offset: 0x68
	private CustomRoofedCulling[] _roofedCullingEnvironmentsCustom; //Field offset: 0x6C
	private Color _rollImpactRockColor; //Field offset: 0x70
	private Color _rollImpactDustColorMin; //Field offset: 0x80
	private Color _rollImpactDustColorMax; //Field offset: 0x90
	private MaterialGroup[] _devicePerformanceRelativeMaterials; //Field offset: 0xA0
	private GenericAndThemePrefabGroup[] _prefabMappingsGeneric; //Field offset: 0xA4
	private RouteEnvironmentModelAssets[] _routeEnvironmentModelAssets; //Field offset: 0xA8
	private GroundAssetGroup _groundAssets; //Field offset: 0xAC
	private List<EnvironmentKind> _baseIgnoredEnvironmentKinds; //Field offset: 0xE0
	private AudioClip _gameMusic; //Field offset: 0xE4
	private List<ThemePreloadSetting> _themePreloadSettings; //Field offset: 0xE8
	private bool _initialized; //Field offset: 0xEC
	private Dictionary<GameObject, GameObject> _genericToThemePrefabDict; //Field offset: 0xF0
	private Dictionary<Material, Material> _devicePerformanceRelativeMaterialsDict; //Field offset: 0xF4

	public BackgroundCulling[] BackgroundCulling
	{
		 get { } //Length: 9
	}

	public Color BackgroundCullingColor
	{
		 get { } //Length: 136
	}

	public float BackgroundGradientBottom
	{
		 get { } //Length: 9
	}

	public Color BackgroundGradientBottomColor
	{
		 get { } //Length: 29
	}

	public float BackgroundGradientTop
	{
		 get { } //Length: 9
	}

	public Color BackgroundGradientTopColor
	{
		 get { } //Length: 26
	}

	public Shader BackgroundLayerCommonMaterialShader
	{
		 get { } //Length: 6
	}

	public BackgroundLayer[] BackgroundLayers
	{
		 get { } //Length: 9
	}

	public float BackgroundLayerSpacing
	{
		 get { } //Length: 6
	}

	public float BackgroundSkylineLeftLimit
	{
		 get { } //Length: 9
	}

	public float BackgroundSkylineRightLimit
	{
		 get { } //Length: 9
	}

	public float BackgroundStartDistance
	{
		 get { } //Length: 6
	}

	public float DistantBackgroundStartDistance
	{
		 get { } //Length: 6
	}

	public float DistantFogEndDistance
	{
		 get { } //Length: 6
	}

	public float DistantFogStartDistance
	{
		 get { } //Length: 6
	}

	public DistantObjectConfig[] DistantObjectConfigs
	{
		 get { } //Length: 6
	}

	public DistantObjectGlobalConfig DistantObjectGlobalConfig
	{
		 get { } //Length: 9
	}

	public ThemeEffect[] Effects
	{
		 get { } //Length: 6
	}

	public TransitionConfig[] EnvironmentTransitionConfigs
	{
		 get { } //Length: 61
	}

	public Color FogColor
	{
		 get { } //Length: 30
	}

	public float FogEndDistance
	{
		 get { } //Length: 6
	}

	public float FogStartDistance
	{
		 get { } //Length: 9
	}

	public AudioClip GameMusic
	{
		 get { } //Length: 6
	}

	public GenericAndThemePrefabGroup[] GenericToThemePrefabMappingGroups
	{
		 get { } //Length: 7
	}

	public Color GlowGoldColor
	{
		 get { } //Length: 29
	}

	public float GlowGoldFalloff
	{
		 get { } //Length: 9
	}

	public Material GlowGoldMaterial
	{
		 get { } //Length: 6
	}

	public GroundAssetGroup GroundAssets
	{
		 get { } //Length: 27
	}

	public Color RollImpactDustColorMax
	{
		 get { } //Length: 27
	}

	public Color RollImpactDustColorMin
	{
		 get { } //Length: 27
	}

	public Color RollImpactRockColor
	{
		 get { } //Length: 27
	}

	public bool RoofedCullingEnabled
	{
		 get { } //Length: 6
	}

	public CustomRoofedCulling[] RoofedCullingEnvironmentsCustom
	{
		 get { } //Length: 6
	}

	public EnvironmentType[] RoofedCullingEnvironmentsHigh
	{
		 get { } //Length: 9
	}

	public EnvironmentType[] RoofedCullingEnvironmentsLow
	{
		 get { } //Length: 6
	}

	public RouteEnvironmentModelAssets[] RouteEnvironmentModelAssets
	{
		 get { } //Length: 7
	}

	public string ThemePath
	{
		 get { } //Length: 7
	}

	public Theme() { }

	private void EditorInitData() { }

	public BackgroundCulling[] get_BackgroundCulling() { }

	public Color get_BackgroundCullingColor() { }

	public float get_BackgroundGradientBottom() { }

	public Color get_BackgroundGradientBottomColor() { }

	public float get_BackgroundGradientTop() { }

	public Color get_BackgroundGradientTopColor() { }

	public Shader get_BackgroundLayerCommonMaterialShader() { }

	public BackgroundLayer[] get_BackgroundLayers() { }

	public float get_BackgroundLayerSpacing() { }

	public float get_BackgroundSkylineLeftLimit() { }

	public float get_BackgroundSkylineRightLimit() { }

	public float get_BackgroundStartDistance() { }

	public float get_DistantBackgroundStartDistance() { }

	public float get_DistantFogEndDistance() { }

	public float get_DistantFogStartDistance() { }

	public DistantObjectConfig[] get_DistantObjectConfigs() { }

	public DistantObjectGlobalConfig get_DistantObjectGlobalConfig() { }

	public ThemeEffect[] get_Effects() { }

	public TransitionConfig[] get_EnvironmentTransitionConfigs() { }

	public Color get_FogColor() { }

	public float get_FogEndDistance() { }

	public float get_FogStartDistance() { }

	public AudioClip get_GameMusic() { }

	public GenericAndThemePrefabGroup[] get_GenericToThemePrefabMappingGroups() { }

	public Color get_GlowGoldColor() { }

	public float get_GlowGoldFalloff() { }

	public Material get_GlowGoldMaterial() { }

	public GroundAssetGroup get_GroundAssets() { }

	public Color get_RollImpactDustColorMax() { }

	public Color get_RollImpactDustColorMin() { }

	public Color get_RollImpactRockColor() { }

	public bool get_RoofedCullingEnabled() { }

	public CustomRoofedCulling[] get_RoofedCullingEnvironmentsCustom() { }

	public EnvironmentType[] get_RoofedCullingEnvironmentsHigh() { }

	public EnvironmentType[] get_RoofedCullingEnvironmentsLow() { }

	public RouteEnvironmentModelAssets[] get_RouteEnvironmentModelAssets() { }

	public string get_ThemePath() { }

	public float GetCameraDistanceToClosestBackgroundLayer() { }

	public void Initialize() { }

	public void InitializeEnvironmentTransitions() { }

	private void OnEnable() { }

	public void PrepoolPrefabs() { }

	public bool ShouldIgnoreBase(EnvironmentKind envKind) { }

	public bool TryGetDevicePerformanceRelativeMaterial(Material material, out Material performanceRelative) { }

	public bool TryGetSynchronizedThemeAssetFromGeneric(GameObject genericPrefab, out GameObject themePrefab) { }

	public bool TryGetThemePrefabFromGeneric(GameObject genericPrefab, out GameObject themePrefab) { }

}

