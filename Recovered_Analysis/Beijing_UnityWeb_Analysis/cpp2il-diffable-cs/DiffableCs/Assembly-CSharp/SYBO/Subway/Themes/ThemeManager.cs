namespace SYBO.Subway.Themes;

public class ThemeManager : MonoBehaviour
{
	private static bool _applicationQuitting; //Field offset: 0x0
	private static ThemeManager _instance; //Field offset: 0x4
	private Action<Theme> ThemeChanged; //Field offset: 0xC
	private Vector4 _distortion; //Field offset: 0x10
	private Theme _theme; //Field offset: 0x20
	private Theme _themeRefDuplicate; //Field offset: 0x24
	private CameraCulling _cameraCulling; //Field offset: 0x28
	private float _backgroundStartDistance; //Field offset: 0x2C
	private float _backgroundToFogBlendStartDistance; //Field offset: 0x30

	public event Action<Theme> ThemeChanged
	{
		 add { } //Length: 9
		 remove { } //Length: 111
	}

	public bool DistortionYFlipped
	{
		 set { } //Length: 111
	}

	public static ThemeManager Instance
	{
		 get { } //Length: 141
	}

	public Theme Theme
	{
		 get { } //Length: 6
	}

	private static ThemeManager() { }

	public ThemeManager() { }

	public void add_ThemeChanged(Action<Theme> value) { }

	private void Awake() { }

	public void ForceRefresh() { }

	public static ThemeManager get_Instance() { }

	public Theme get_Theme() { }

	public int GetEnvironmentModelVariationCount(RouteCategory routeCategory, EnvironmentKind envTypeInfo) { }

	public Transform GetEnvironmentSegmentModel(RouteCategory routeCategory, EnvironmentKind envKind, EnvironmentSequence sequence, EnvironmentSide side, int variation) { }

	private Nullable<EnvironmentSegmentParts> GetSequenceModel(EnvironmentSegmentSequence segments, EnvironmentSequence sequence) { }

	public bool NeedSameVariationForAllSegments(EnvironmentType envType) { }

	private void OnApplicationQuit() { }

	private void OnDestroy() { }

	private void OnValidate() { }

	public void PrepoolThemePrefabs() { }

	public void remove_ThemeChanged(Action<Theme> value) { }

	private void ResetTheme() { }

	public void set_DistortionYFlipped(bool value) { }

	private void SetShaderStates() { }

	private void Start() { }

	private void UIScreenController_OnApplicationResumed() { }

	private void Update() { }

}

