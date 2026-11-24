namespace UnityEngine.Rendering;

public class SupportedRenderingFeatures
{
	public enum LightmapMixedBakeModes
	{
		None = 0,
		IndirectOnly = 1,
		Subtractive = 2,
		Shadowmask = 4,
	}

	public enum ReflectionProbeModes
	{
		None = 0,
		Rotation = 1,
	}

	private static SupportedRenderingFeatures s_Active; //Field offset: 0x0
	private ReflectionProbeModes <reflectionProbeModes>k__BackingField; //Field offset: 0x8
	private LightmapMixedBakeModes <defaultMixedLightingModes>k__BackingField; //Field offset: 0xC
	private LightmapMixedBakeModes <mixedLightingModes>k__BackingField; //Field offset: 0x10
	private LightmapBakeType <lightmapBakeTypes>k__BackingField; //Field offset: 0x14
	private LightmapsMode <lightmapsModes>k__BackingField; //Field offset: 0x18
	private bool <lightProbeProxyVolumes>k__BackingField; //Field offset: 0x1C
	private bool <motionVectors>k__BackingField; //Field offset: 0x1D
	private bool <receiveShadows>k__BackingField; //Field offset: 0x1E
	private bool <reflectionProbes>k__BackingField; //Field offset: 0x1F
	private bool <rendererPriority>k__BackingField; //Field offset: 0x20
	private bool <overridesEnvironmentLighting>k__BackingField; //Field offset: 0x21
	private bool <overridesFog>k__BackingField; //Field offset: 0x22
	private bool <overridesOtherLightingSettings>k__BackingField; //Field offset: 0x23
	private bool <editableMaterialRenderQueue>k__BackingField; //Field offset: 0x24

	public static SupportedRenderingFeatures active
	{
		 get { } //Length: 49
		 set { } //Length: 99
	}

	public LightmapMixedBakeModes defaultMixedLightingModes
	{
		 get { } //Length: 9
	}

	public LightmapBakeType lightmapBakeTypes
	{
		 get { } //Length: 6
	}

	public LightmapsMode lightmapsModes
	{
		 get { } //Length: 6
	}

	public LightmapMixedBakeModes mixedLightingModes
	{
		 get { } //Length: 6
	}

	private static SupportedRenderingFeatures() { }

	public SupportedRenderingFeatures() { }

	internal static void FallbackMixedLightingModeByRef(nint fallbackModePtr) { }

	public static SupportedRenderingFeatures get_active() { }

	public LightmapMixedBakeModes get_defaultMixedLightingModes() { }

	public LightmapBakeType get_lightmapBakeTypes() { }

	public LightmapsMode get_lightmapsModes() { }

	public LightmapMixedBakeModes get_mixedLightingModes() { }

	internal static bool IsLightmapBakeTypeSupported(LightmapBakeType bakeType) { }

	internal static void IsLightmapBakeTypeSupportedByRef(LightmapBakeType bakeType, nint isSupportedPtr) { }

	internal static void IsLightmapsModeSupportedByRef(LightmapsMode mode, nint isSupportedPtr) { }

	internal static bool IsMixedLightingModeSupported(MixedLightingMode mixedMode) { }

	internal static void IsMixedLightingModeSupportedByRef(MixedLightingMode mixedMode, nint isSupportedPtr) { }

	public static void set_active(SupportedRenderingFeatures value) { }

}

