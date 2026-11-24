namespace SYBO.Subway.Level;

public class BackgroundLayer
{
	public string Name; //Field offset: 0x8
	public BackgroundObject[] SingleObjectPrefabs; //Field offset: 0xC
	public BackgroundObject[] SkylineFillObjectPrefabs; //Field offset: 0x10
	private bool _dontRandomizeSingleObjectSpawnPosition; //Field offset: 0x14
	private float _speed; //Field offset: 0x18
	public int LayerIndex; //Field offset: 0x1C
	private Vector3 _offsetFromLayerDefault; //Field offset: 0x20
	private PerformanceLevel _requiredPerformanceLevel; //Field offset: 0x2C
	private bool _useCommonMaterial; //Field offset: 0x30
	private Color _commonMaterialTintColor; //Field offset: 0x34
	private readonly List<BackgroundObject> _backgroundObjects; //Field offset: 0x44
	private readonly List<BackgroundObject> _movingSingleObjects; //Field offset: 0x48
	private readonly List<BackgroundObject> _movingSkylineFillObjects; //Field offset: 0x4C
	private int <NextSingleObjectSpawnIndex>k__BackingField; //Field offset: 0x50
	private Material <MaterialInstance>k__BackingField; //Field offset: 0x54

	public List<BackgroundObject> BackgroundObjects
	{
		 get { } //Length: 6
	}

	public Color CommonMaterialTintColor
	{
		 get { } //Length: 326
		 set { } //Length: 26
	}

	public bool DontRandomizeSingleObjectSpawnPosition
	{
		 get { } //Length: 9
	}

	public Material MaterialInstance
	{
		 get { } //Length: 6
		 set { } //Length: 8
	}

	public List<BackgroundObject> MovingSingleObjects
	{
		 get { } //Length: 6
	}

	public List<BackgroundObject> MovingSkylineFillObjects
	{
		 get { } //Length: 6
	}

	public int NextSingleObjectSpawnIndex
	{
		 get { } //Length: 9
		 set { } //Length: 26
	}

	public Vector3 OffsetFromLayerDefault
	{
		 get { } //Length: 61
	}

	public PerformanceLevel RequiredPerformanceLevel
	{
		 get { } //Length: 34
	}

	public float Speed
	{
		 get { } //Length: 7
		 set { } //Length: 44
	}

	public bool UseCommonMaterial
	{
		 get { } //Length: 6
	}

	public BackgroundLayer() { }

	public BackgroundLayer(BackgroundLayer layerToCopy) { }

	public List<BackgroundObject> get_BackgroundObjects() { }

	public Color get_CommonMaterialTintColor() { }

	public bool get_DontRandomizeSingleObjectSpawnPosition() { }

	public Material get_MaterialInstance() { }

	public List<BackgroundObject> get_MovingSingleObjects() { }

	public List<BackgroundObject> get_MovingSkylineFillObjects() { }

	public int get_NextSingleObjectSpawnIndex() { }

	public Vector3 get_OffsetFromLayerDefault() { }

	public PerformanceLevel get_RequiredPerformanceLevel() { }

	public float get_Speed() { }

	public bool get_UseCommonMaterial() { }

	public void set_CommonMaterialTintColor(Color value) { }

	public void set_MaterialInstance(Material value) { }

	public void set_NextSingleObjectSpawnIndex(int value) { }

	public void set_Speed(float value) { }

}

