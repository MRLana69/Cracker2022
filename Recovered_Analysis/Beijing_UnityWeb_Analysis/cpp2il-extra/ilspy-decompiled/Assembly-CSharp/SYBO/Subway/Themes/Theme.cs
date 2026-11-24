using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using SYBO.Common.StateSystem;
using SYBO.Common.Utilities;
using SYBO.Components.Utilities;
using SYBO.Subway.Level;
using SYBO.Subway.Level.Environments;
using SYBO.Subway.Routes;
using SYBO.Subway.Visuals;
using UnityEngine;
using UnityUtilities;

namespace SYBO.Subway.Themes;

public class Theme : ScriptableObject
{
	[Serializable]
	private class ThemePreloadSetting
	{
		private string _prefabName;

		private Transform _prefab;

		private int _preloadAmountLowPerf;

		private int _preloadAmountMediumPerf;

		private int _preloadAmountHighPerf;

		public Transform Prefab => _prefab;

		public ThemePreloadSetting(Transform prefab)
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_0028: Expected Obj, but got I
			object obj = prefab + 8;
			ThemePreloadSetting themePreloadSetting = (ThemePreloadSetting)obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5 @ S1_v2+8]");
			_prefabName = (string)0;
		}

		public void SetPreloadAmount(DeviceInfo.PerformanceLevel perfLevel, int amount)
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected Obj, but got Unknown
			//IL_0013: Expected Obj, but got I4
			object obj = this + 8;
			obj = perfLevel;
			_ = 0;
		}

		public int GetPreloadAmount(DeviceInfo.PerformanceLevel perfLevel)
		{
			//IL_0060: Expected I, but got Obj
			//IL_0076: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			nint num = (nint)typeof(char);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<System.Char>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(char);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v12 (Il2CppClass<System.Char>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			return char.CheckLetter((UnicodeCategory)perfLevel) ? 1 : 0;
		}
	}

	public const string ThemesPath = "Assets/Themes";

	private const float MinFogTransitionDistance = 1f;

	public const string GenericAssetDirectoryName = "0.00_Generic";

	private Background _background;

	private DistantEnvironmentController.DistantObjectGlobalConfig _distantObjectGlobalConfig;

	private DistantEnvironmentController.DistantObjectConfig[] _distantObjectConfigs;

	private TransitionConfig[] _environmentTransitionConfigs;

	private Color _fogColor;

	private float _fogStartDistance;

	private float _fogEndDistance;

	private float _backgroundStartDistance;

	private float _distantFogStartDistance;

	private float _distantFogEndDistance;

	private float _distantBackgroundStartDistance;

	private Color _glowGoldColor;

	private Material _glowGold;

	private float _glowGoldFalloff;

	private ThemeEffect[] _effects;

	private bool _roofedCullingEnabled;

	private EnvironmentType[] _roofedCullingEnvironmentsHigh;

	private EnvironmentType[] _roofedCullingEnvironmentsLow;

	private RoofedCulling.CustomRoofedCulling[] _roofedCullingEnvironmentsCustom;

	private Color _rollImpactRockColor;

	private Color _rollImpactDustColorMin;

	private Color _rollImpactDustColorMax;

	private MaterialGroup[] _devicePerformanceRelativeMaterials;

	private GenericAndThemePrefabGroup[] _prefabMappingsGeneric;

	private RouteEnvironmentModelAssets[] _routeEnvironmentModelAssets;

	public const string FieldPatternGroundAsset = "_groundAssets.";

	private GroundAssetGroup _groundAssets;

	private List<EnvironmentKind> _baseIgnoredEnvironmentKinds;

	private AudioClip _gameMusic;

	private List<ThemePreloadSetting> _themePreloadSettings;

	[NonSerialized]
	private bool _initialized;

	private Dictionary<GameObject, GameObject> _genericToThemePrefabDict;

	private Dictionary<Material, Material> _devicePerformanceRelativeMaterialsDict;

	public Shader BackgroundLayerCommonMaterialShader => (Shader)(object)_distantObjectGlobalConfig;

	public float BackgroundLayerSpacing
	{
		get
		{
			//IL_0007: Expected F4, but got Obj
			return (float)_background;
		}
	}

	public float BackgroundSkylineLeftLimit
	{
		get
		{
			Background background = _background;
			return background.LayerSpacing;
		}
	}

	public float BackgroundSkylineRightLimit
	{
		get
		{
			Background background = _background;
			return background.SkylineLeftLimit;
		}
	}

	public BackgroundLayer[] BackgroundLayers
	{
		get
		{
			Background background = _background;
			return (BackgroundLayer[])(object)background.LayerCommonMaterialShader;
		}
	}

	public BackgroundCulling[] BackgroundCulling
	{
		get
		{
			Background background = _background;
			return (BackgroundCulling[])(object)background.Layers;
		}
	}

	public Color BackgroundCullingColor
	{
		get
		{
			//IL_0063: Expected Obj, but got I
			//IL_0074: Expected Obj, but got I
			//IL_0097: Expected Obj, but got F4
			//IL_001b: Expected Obj, but got I
			//IL_0025: Expected Obj, but got I4
			//IL_0041: Expected I4, but got Obj
			//IL_0041: Expected Obj, but got F4
			Color result = default;
			if ((object)this != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0 (UnityEngine.Color)+10]");
				((UIWidget)0).height = 325;
				Color color = ((UIWidget)25).color;
				((UILabel)result.a).fontSize = (int)"Waiting for chunks...";
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0 (UnityEngine.Color)+10]");
				nint num = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0 (UnityEngine.Color)+1C]");
				((UIWidget)num).height = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0 (UnityEngine.Color)+18]");
				Color color2 = ((UIWidget)0).color;
				float a = result.a;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0 (UnityEngine.Color)+20]");
				((UILabel)a).fontSize = 0;
			}
			return result;
		}
	}

	public DistantEnvironmentController.DistantObjectGlobalConfig DistantObjectGlobalConfig
	{
		get
		{
			Background background = _background;
			return (DistantEnvironmentController.DistantObjectGlobalConfig)(object)background.Culling;
		}
	}

	public DistantEnvironmentController.DistantObjectConfig[] DistantObjectConfigs => (DistantEnvironmentController.DistantObjectConfig[])(object)_distantObjectGlobalConfig;

	public unsafe Color FogColor
	{
		get
		{
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0010: Expected Obj, but got Unknown
			//IL_001d: Expected F4, but got Obj
			//IL_0018: Expected native int or pointer, but got VT
			//IL_0032: Expected F4, but got I
			//IL_002d: Expected native int or pointer, but got VT
			object obj = _background + 72;
			Color color = default;
			((Color*)(nint)color)->r = (float)obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v6 @ S1_v3+8]");
			((Color*)(nint)color)->b = 0f;
			return color;
		}
	}

	public unsafe Color BackgroundGradientTopColor
	{
		get
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected Obj, but got Unknown
			//IL_0018: Expected F4, but got Obj
			//IL_0013: Expected native int or pointer, but got VT
			//IL_002d: Expected F4, but got I
			//IL_0028: Expected native int or pointer, but got VT
			object obj = this + 28;
			Color color = default;
			((Color*)(nint)color)->r = (float)obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5 @ S1_v2+8]");
			((Color*)(nint)color)->b = 0f;
			return color;
		}
	}

	public unsafe Color BackgroundGradientBottomColor
	{
		get
		{
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0010: Expected Obj, but got Unknown
			//IL_001d: Expected F4, but got Obj
			//IL_0018: Expected native int or pointer, but got VT
			//IL_0032: Expected F4, but got I
			//IL_002d: Expected native int or pointer, but got VT
			object obj = _background + 36;
			Color color = default;
			((Color*)(nint)color)->r = (float)obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v6 @ S1_v3+8]");
			((Color*)(nint)color)->b = 0f;
			return color;
		}
	}

	public float FogStartDistance
	{
		get
		{
			Background background = _background;
			return background.SkylineRightLimit;
		}
	}

	public float FogEndDistance => _fogStartDistance;

	public float BackgroundStartDistance => _fogEndDistance;

	public float DistantFogStartDistance => _backgroundStartDistance;

	public float DistantFogEndDistance => _distantFogStartDistance;

	public float DistantBackgroundStartDistance => _distantFogEndDistance;

	public float BackgroundGradientBottom
	{
		get
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected Obj, but got Unknown
			//IL_0010: Expected F4, but got Obj
			object obj = this - -64;
			return (float)obj;
		}
	}

	public float BackgroundGradientTop
	{
		get
		{
			Background background = _background;
			return background.GradientBottom;
		}
	}

	public Material GlowGoldMaterial => (Material)(object)_distantObjectConfigs;

	public unsafe Color GlowGoldColor
	{
		get
		{
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0010: Expected Obj, but got Unknown
			//IL_001d: Expected F4, but got Obj
			//IL_0018: Expected native int or pointer, but got VT
			//IL_0032: Expected F4, but got I
			//IL_002d: Expected native int or pointer, but got VT
			object obj = _background + 52;
			Color color = default;
			((Color*)(nint)color)->r = (float)obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v6 @ S1_v3+8]");
			((Color*)(nint)color)->b = 0f;
			return color;
		}
	}

	public float GlowGoldFalloff
	{
		get
		{
			Background background = _background;
			return background.GradientTop;
		}
	}

	public ThemeEffect[] Effects => (ThemeEffect[])(object)_glowGold;

	public bool RoofedCullingEnabled
	{
		get
		{
			//IL_0007: Expected I4, but got Obj
			return (byte)(int)_effects != 0;
		}
	}

	public EnvironmentType[] RoofedCullingEnvironmentsHigh
	{
		get
		{
			//IL_0019: Expected Obj, but got I4
			bool roofedCullingEnabled = _roofedCullingEnabled;
			return (EnvironmentType[])roofedCullingEnabled;
		}
	}

	public EnvironmentType[] RoofedCullingEnvironmentsLow => _roofedCullingEnvironmentsHigh;

	public RoofedCulling.CustomRoofedCulling[] RoofedCullingEnvironmentsCustom => (RoofedCulling.CustomRoofedCulling[])(object)_roofedCullingEnvironmentsLow;

	public AudioClip GameMusic => (AudioClip)(object)_roofedCullingEnvironmentsCustom;

	public unsafe Color RollImpactRockColor
	{
		get
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected Obj, but got Unknown
			//IL_0018: Expected F4, but got Obj
			//IL_0013: Expected native int or pointer, but got VT
			//IL_002d: Expected F4, but got I
			//IL_0028: Expected native int or pointer, but got VT
			object obj = this + 68;
			Color color = default;
			((Color*)(nint)color)->r = (float)obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5 @ S1_v2+8]");
			((Color*)(nint)color)->b = 0f;
			return color;
		}
	}

	public unsafe Color RollImpactDustColorMin
	{
		get
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected Obj, but got Unknown
			//IL_0018: Expected F4, but got Obj
			//IL_0013: Expected native int or pointer, but got VT
			//IL_002d: Expected F4, but got I
			//IL_0028: Expected native int or pointer, but got VT
			object obj = this + 112;
			Color color = default;
			((Color*)(nint)color)->r = (float)obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5 @ S1_v2+8]");
			((Color*)(nint)color)->b = 0f;
			return color;
		}
	}

	public unsafe Color RollImpactDustColorMax
	{
		get
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected Obj, but got Unknown
			//IL_0018: Expected F4, but got Obj
			//IL_0013: Expected native int or pointer, but got VT
			//IL_002d: Expected F4, but got I
			//IL_0028: Expected native int or pointer, but got VT
			object obj = this + 128;
			Color color = default;
			((Color*)(nint)color)->r = (float)obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5 @ S1_v2+8]");
			((Color*)(nint)color)->b = 0f;
			return color;
		}
	}

	public GenericAndThemePrefabGroup[] GenericToThemePrefabMappingGroups => (GenericAndThemePrefabGroup[])(object)_gameMusic;

	public RouteEnvironmentModelAssets[] RouteEnvironmentModelAssets => (RouteEnvironmentModelAssets[])(object)_prefabMappingsGeneric;

	public unsafe GroundAssetGroup GroundAssets
	{
		get
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected Obj, but got Unknown
			//IL_0013: Expected native int or pointer, but got VT
			//IL_002d: Expected Obj, but got I
			//IL_0028: Expected native int or pointer, but got VT
			object ground = this + 144;
			GroundAssetGroup groundAssetGroup = default;
			System.Runtime.CompilerServices.Unsafe.Write(&((GroundAssetGroup*)(nint)groundAssetGroup)->Ground, ground);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5 @ S1_v2+8]");
			System.Runtime.CompilerServices.Unsafe.Write(&((GroundAssetGroup*)(nint)groundAssetGroup)->GroundShortShadowStart, (Transform)0);
			return groundAssetGroup;
		}
	}

	public string ThemePath => (string)(object)_routeEnvironmentModelAssets;

	public TransitionConfig[] EnvironmentTransitionConfigs
	{
		get
		{
			//IL_001d: Expected I4, but got Obj
			UnityEngine.Object obj = UnityEngine.Object.Instantiate((UnityEngine.Object)this);
			return (TransitionConfig[])(object)string.ConcatArray((string[])(object)"Assets/Themes/", (int)obj);
		}
	}

	private void OnEnable()
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected Obj, but got Unknown
		object obj = this + 32;
		obj = string.Empty;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F4C1");
	}

	private void EditorInitData()
	{
		_initialized = false;
		InitializeEnvironmentTransitions();
	}

	public void Initialize()
	{
		//IL_0234: Unknown result type (might be due to invalid IL or missing references)
		//IL_0239: Expected Obj, but got Unknown
		//IL_0242: Unknown result type (might be due to invalid IL or missing references)
		//IL_0247: Expected Obj, but got Unknown
		//IL_0250: Unknown result type (might be due to invalid IL or missing references)
		//IL_0255: Expected Obj, but got Unknown
		//IL_025e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0263: Expected Obj, but got Unknown
		//IL_026c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0271: Expected Obj, but got Unknown
		//IL_027a: Unknown result type (might be due to invalid IL or missing references)
		//IL_027f: Expected Obj, but got Unknown
		//IL_0288: Expected Obj, but got I4
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected Obj, but got Unknown
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Expected Obj, but got Unknown
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Expected Obj, but got Unknown
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Expected Obj, but got Unknown
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Expected Obj, but got Unknown
		//IL_014a: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Expected Obj, but got Unknown
		//IL_0178: Unknown result type (might be due to invalid IL or missing references)
		//IL_017d: Expected Obj, but got Unknown
		//IL_01a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ad: Expected Obj, but got Unknown
		//IL_01d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01db: Expected Obj, but got Unknown
		//IL_0206: Unknown result type (might be due to invalid IL or missing references)
		//IL_020b: Expected Obj, but got Unknown
		//IL_0219: Unknown result type (might be due to invalid IL or missing references)
		//IL_021e: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 48;
		object obj3 = obj2 + 40;
		object obj4 = obj2 + 32;
		object obj5 = obj2 + 24;
		object obj6 = obj2 + 8;
		object obj7 = obj2 + 16;
		obj7 = 0;
		((Dictionary<TKey, TValue>)(object)_genericToThemePrefabDict).Resize();
		if (_prefabMappingsGeneric != null)
		{
			GenericAndThemePrefabGroup[] prefabMappingsGeneric = _prefabMappingsGeneric;
			if (prefabMappingsGeneric.Length != 0)
			{
				return;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @39CF");
		obj7 = "Segments/Fillers";
		object obj8 = obj7 + 4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		object obj9 = default;
		obj8 = obj9;
		obj3 = obj7;
		obj = obj3;
		object obj11 = default;
		object obj10 = obj11 + 16;
		obj10 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @39CF");
		obj7 = "Props";
		object obj12 = obj7 + 4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		object obj13 = default;
		obj12 = obj13;
		obj4 = obj7;
		obj = obj4;
		object obj14 = obj11 + 24;
		obj14 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @39CF");
		obj7 = "Segments/Specials";
		object obj15 = obj7 + 4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		object obj16 = default;
		obj15 = obj16;
		obj5 = obj7;
		obj = obj5;
		object obj17 = obj11 + 32;
		obj17 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @39CF");
		obj7 = "Segments/Tracks";
		object obj18 = obj7 + 4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		object obj19 = default;
		obj18 = obj19;
		obj6 = obj7;
		obj = obj6;
		object obj20 = obj11 + 40;
		obj20 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @39CF");
		obj7 = "Segments/Tunnels";
		object obj21 = obj7 + 4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		object obj22 = default;
		obj21 = obj22;
		obj2 = obj7;
		obj = obj2;
		object obj23 = obj11 + 48;
		obj23 = obj;
		object obj24 = this + 164;
		obj24 = obj11;
	}

	public void InitializeEnvironmentTransitions()
	{
		//IL_0684: Unknown result type (might be due to invalid IL or missing references)
		//IL_0689: Expected Obj, but got Unknown
		//IL_0692: Unknown result type (might be due to invalid IL or missing references)
		//IL_0697: Expected Obj, but got Unknown
		//IL_0025: Expected Obj, but got I
		//IL_0035: Expected Obj, but got I
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Expected Obj, but got Unknown
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Expected Obj, but got Unknown
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected Obj, but got Unknown
		//IL_009b: Expected Obj, but got I
		//IL_00ab: Expected Obj, but got I
		//IL_00b3: Expected I, but got Obj
		//IL_00c1: Expected Obj, but got I
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Expected Obj, but got Unknown
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Expected Obj, but got Unknown
		//IL_0106: Expected Obj, but got I4
		//IL_06c9: Expected I, but got Obj
		//IL_06df: Expected Obj, but got I
		//IL_08ae: Expected Obj, but got I4
		//IL_011d: Expected Obj, but got I4
		//IL_0126: Expected Obj, but got I4
		//IL_0424: Expected I, but got Obj
		//IL_046c: Expected Obj, but got I4
		//IL_0136: Unknown result type (might be due to invalid IL or missing references)
		//IL_013b: Expected Obj, but got Unknown
		//IL_0705: Unknown result type (might be due to invalid IL or missing references)
		//IL_070a: Expected Obj, but got Unknown
		//IL_047c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0481: Expected Obj, but got Unknown
		//IL_04b2: Expected I, but got Obj
		//IL_04c8: Expected Obj, but got I
		//IL_0199: Expected I, but got Obj
		//IL_07eb: Expected Obj, but got I
		//IL_0919: Expected Obj, but got I
		//IL_081c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0821: Expected Obj, but got Unknown
		//IL_04f3: Expected I, but got Obj
		//IL_01c5: Expected Obj, but got I
		//IL_01d3: Expected Obj, but got I
		//IL_01fe: Expected I, but got Obj
		//IL_0214: Expected Obj, but got I
		//IL_0591: Expected Obj, but got I
		//IL_083c: Expected I, but got Obj
		//IL_0852: Expected Obj, but got I
		//IL_023f: Expected I, but got Obj
		//IL_099d: Expected I, but got Obj
		//IL_05a6: Expected Obj, but got I
		//IL_0294: Expected I, but got Obj
		//IL_02aa: Expected Obj, but got I
		//IL_05c3: Expected I, but got Obj
		//IL_0779: Expected Obj, but got I
		//IL_0618: Expected Obj, but got I
		//IL_0628: Expected Obj, but got I
		//IL_0638: Expected Obj, but got I
		//IL_0641: Unknown result type (might be due to invalid IL or missing references)
		//IL_0646: Expected Obj, but got Unknown
		//IL_064f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0654: Expected Obj, but got Unknown
		//IL_066d: Expected I, but got Obj
		//IL_02d5: Expected I, but got Obj
		//IL_033a: Expected Obj, but got I
		//IL_034a: Expected Obj, but got I
		//IL_035a: Expected Obj, but got I
		//IL_0363: Unknown result type (might be due to invalid IL or missing references)
		//IL_0368: Expected Obj, but got Unknown
		//IL_0371: Unknown result type (might be due to invalid IL or missing references)
		//IL_0376: Expected Obj, but got Unknown
		//IL_0396: Expected I, but got Obj
		//IL_03ac: Expected Obj, but got I
		//IL_07b5: Expected Obj, but got I
		//IL_03d7: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 16;
		object obj3 = obj2 + 8;
		if (~(_initialized ? 1u : 0u) == 0)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ S3_v3 (Il2CppMethodInfo)+C]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ S3_v4+60]");
		object obj5 = 0;
		object obj6 = obj5;
		object obj7 = obj6 & 0x1FFF;
		object obj8 = obj7 + 113696;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v92 @ S4_v5 (should have been resolved before IL gen)");
		object obj9 = this + 240;
		object obj10 = default;
		obj9 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ S3_v8 (Il2CppMethodInfo)+C]");
		object obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ S3_v9+60]");
		object obj12 = 0;
		nint num3 = (nint)obj12;
		object obj13 = num3 & 0x1FFF;
		object obj14 = obj13 + 113696;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v244 @ S4_v22 (should have been resolved before IL gen)");
		object obj15 = this + 244;
		object obj16 = default;
		obj15 = obj16;
		bool flag = _prefabMappingsGeneric == null;
		object obj17 = 113696;
		if (!flag)
		{
			obj17 = 113696;
			object obj18 = 0;
			while (true)
			{
				GenericAndThemePrefabGroup[] prefabMappingsGeneric = _prefabMappingsGeneric;
				if ((nint)obj18 >= prefabMappingsGeneric.Length)
				{
					break;
				}
				object obj19 = _prefabMappingsGeneric + 16;
				object obj20 = obj18 << 3;
				object obj21 = obj19 + obj20;
				obj = obj21;
				obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11+4]");
				bool flag2 = (nint)0 == 0;
				num3 = 3;
				if (!flag2)
				{
					nint num4 = unchecked((nint)null);
					num3 = 3;
					while (true)
					{
						obj = obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+4]");
						object obj22 = 0;
						nint num5 = num4;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v257 @ S1_v59+C]");
						if (num5 >= 0)
						{
							break;
						}
						obj = obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+4]");
						object obj23 = (nint)0 + (nint)16;
						object obj24 = num4 << 3;
						object obj25 = obj23 + obj24;
						obj3 = obj25;
						obj2 = obj3;
						nint num6 = (nint)typeof(UnityEngine.Object);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v293 @ S1_v70 (Il2CppClass<UnityEngine.Object>)+BA]");
						object obj26 = (nint)0 & (nint)0x200;
						if (obj26 != null)
						{
							nint num7 = (nint)typeof(UnityEngine.Object);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v316 @ S1_v103 (Il2CppClass<UnityEngine.Object>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						int num8 = ((ComputeShader)obj2).FindKernel((string)null);
						bool flag3 = num8 == 0;
						num3 = 3;
						if (!flag3)
						{
							obj = obj3;
							nint num9 = (nint)typeof(UnityEngine.Object);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v344 @ S1_v79 (Il2CppClass<UnityEngine.Object>)+BA]");
							object obj27 = (nint)0 & (nint)0x200;
							if (obj27 != null)
							{
								nint num10 = (nint)typeof(UnityEngine.Object);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v385 @ S1_v99 (Il2CppClass<UnityEngine.Object>)+74]");
								if ((nint)0 == 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
								}
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+4]");
							int num11 = ((ComputeShader)0).FindKernel(null);
							bool flag4 = num11 == 0;
							num3 = 3;
							if (!flag4)
							{
								obj = obj3;
								obj3 = obj3;
								nint num12 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v417 @ S4_v24 (Il2CppMethodInfo)+C]");
								object obj28 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v418 @ S4_v25+60]");
								object obj29 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v419 @ S4_v26+48]");
								obj14 = 0;
								object obj30 = obj14 & 0x7FF;
								obj17 = obj30 + 39195;
								Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v243 @ S5_v17 (should have been resolved before IL gen)");
								obj2 = obj3;
								nint num13 = (nint)typeof(NGUITools);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v431 @ S1_v89 (Il2CppClass<NGUITools>)+BA]");
								object obj31 = (nint)0 & (nint)0x200;
								if (obj31 != null)
								{
									nint num14 = (nint)typeof(NGUITools);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v444 @ S1_v95 (Il2CppClass<UnityEngine.Object>)+74]");
									if ((nint)0 == 0)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
									}
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
								bool instanceExists = ((PersistentSingletonMonoBehaviour<>)0).instanceExists;
								num3 = 2;
							}
						}
						nint num15 = num4 + 1;
						num4 = num15;
					}
				}
				object obj32 = obj18 + 1;
				obj18 = obj32;
			}
		}
		nint num16 = (nint)typeof(DeviceInfo);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ S0_v31 (Il2CppClass<DeviceInfo>)+BA]");
		object obj33 = (nint)0 & (nint)0x200;
		if (obj33 != null)
		{
			nint num17 = (nint)typeof(DeviceInfo);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v174 @ S0_v80 (Il2CppClass<DeviceInfo>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		int runAverageFPS = InRunAverageFPSCounter.runAverageFPS;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v182 @ S0_v36 (System.Int32)+8]");
		bool flag5 = (nint)0 == 2;
		bool flag6 = _devicePerformanceRelativeMaterials == null;
		object obj34 = flag5 | flag6;
		if (obj34 == null)
		{
			object obj35 = 0;
			while (true)
			{
				MaterialGroup[] devicePerformanceRelativeMaterials = _devicePerformanceRelativeMaterials;
				if ((nint)obj35 >= devicePerformanceRelativeMaterials.Length)
				{
					break;
				}
				object obj36 = _devicePerformanceRelativeMaterials + 16;
				object obj37 = obj35 << 2;
				object obj38 = obj36 + obj37;
				object obj39 = obj38;
				nint num18 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v310 @ S1_v28 (Il2CppClass<UnityEngine.Object>)+BA]");
				object obj40 = (nint)0 & (nint)0x200;
				if (obj40 != null)
				{
					nint num19 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v326 @ S1_v39 (Il2CppClass<UnityEngine.Object>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v307 @ S0_v51+C]");
				if (!((UnityEngine.Object)0 != null))
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v182 @ S0_v36 (System.Int32)+8]");
					UnityEngine.Object obj41;
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v182 @ S0_v36 (System.Int32)+8]");
						if ((nint)0 == 1)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v307 @ S0_v51+10]");
							obj41 = (UnityEngine.Object)0;
						}
						else
						{
							obj41 = null;
						}
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v307 @ S0_v51+14]");
						obj41 = (UnityEngine.Object)0;
					}
					nint num20 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v401 @ S0_v61 (Il2CppClass<UnityEngine.Object>)+BA]");
					object obj42 = (nint)0 & (nint)0x200;
					if (obj42 != null)
					{
						nint num21 = (nint)typeof(UnityEngine.Object);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v435 @ S0_v71 (Il2CppClass<UnityEngine.Object>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					bool flag7 = obj41 != null;
					bool flag8 = !flag7;
					bool flag9 = !flag8;
					nint num4 = (nint)typeof(UnityEngine.Object);
					if (!flag9)
					{
						nint num22 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v455 @ S4_v15 (Il2CppMethodInfo)+C]");
						object obj43 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v456 @ S4_v16+60]");
						object obj44 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v457 @ S4_v17+48]");
						obj14 = 0;
						object obj45 = obj14 & 0x7FF;
						obj17 = obj45 + 39195;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v243 @ S5_v17 (should have been resolved before IL gen)");
						num4 = (nint)typeof(UnityEngine.Object);
						num3 = 1;
					}
				}
				object obj46 = obj35 + 1;
				obj35 = obj46;
			}
		}
		_initialized = true;
	}

	public void PrepoolPrefabs()
	{
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected Obj, but got Unknown
		//IL_0077: Expected Obj, but got I4
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected Obj, but got Unknown
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected Obj, but got Unknown
		object obj = _environmentTransitionConfigs + 12;
		object obj2 = 0;
		while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj2) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj))
		{
			object obj3 = _environmentTransitionConfigs + 16;
			object obj4 = obj2 << 2;
			object obj5 = obj3 + obj4;
			((TransitionConfig)obj5)._002Ector();
			object obj6 = obj2 + 1;
			obj2 = obj6;
		}
		bool flag = SingletonMonoBehaviour<>.IsInstantiated();
	}

	public unsafe bool TryGetDevicePerformanceRelativeMaterial(Material material, out Material performanceRelative)
	{
		//IL_0008: Invalid comparison between Ref and Obj
		//IL_0100: Expected I4, but got Obj
		//IL_0034: Expected Obj, but got Ref
		//IL_003c: Invalid comparison between Ref and Obj
		//IL_0087: Expected Obj, but got I4
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Expected Obj, but got Unknown
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Expected Obj, but got Unknown
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Expected Obj, but got Unknown
		//IL_0099: Expected Obj, but got Ref
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Expected Obj, but got Unknown
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Expected Obj, but got Unknown
		//IL_00ca: Expected Obj, but got I4
		Material material2 = default;
		Material material3 = default;
		if (System.Runtime.CompilerServices.Unsafe.IsAddressGreaterThan(ref System.Runtime.CompilerServices.Unsafe.As<Material, byte>(ref performanceRelative), ref *(byte*)material2))
		{
			object obj = (ref System.Runtime.CompilerServices.Unsafe.As<Material, byte>(ref performanceRelative)) - (ref *(byte*)material2);
			object obj4;
			if (!System.Runtime.CompilerServices.Unsafe.AreSame(ref System.Runtime.CompilerServices.Unsafe.As<Material, byte>(ref performanceRelative), ref *(byte*)material2))
			{
				object obj2 = -1 / obj;
				object obj3 = obj2 * obj;
				obj4 = -1 - obj3;
			}
			else
			{
				obj4 = 0;
			}
			object obj5 = -1 - obj4;
			bool flag;
			do
			{
				flag = ((SyboRandom)(object)this).Bool();
			}
			while ((flag ? 1 : 0) > (nint)obj5);
			object obj6 = (ref System.Runtime.CompilerServices.Unsafe.As<Material, byte>(ref performanceRelative)) - (ref *(byte*)material2);
			object obj7;
			if (obj6 == null)
			{
				obj7 = 0;
			}
			else
			{
				object obj8 = flag / obj6;
				object obj9 = obj8 * obj6;
				obj7 = flag - obj9;
			}
			material3 = (Material)(object)((object)material2 + obj7);
		}
		return (byte)(int)material3 != 0;
	}

	public bool TryGetThemePrefabFromGeneric(GameObject genericPrefab, out GameObject themePrefab)
	{
		InitializeEnvironmentTransitions();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @108D8");
		bool result = default;
		return result;
	}

	public unsafe bool TryGetSynchronizedThemeAssetFromGeneric(GameObject genericPrefab, out GameObject themePrefab)
	{
		//IL_0159: Expected Obj, but got I
		//IL_0169: Expected Obj, but got I
		//IL_0179: Expected Obj, but got I
		//IL_0182: Unknown result type (might be due to invalid IL or missing references)
		//IL_0187: Expected Obj, but got Unknown
		//IL_0190: Unknown result type (might be due to invalid IL or missing references)
		//IL_0195: Expected Obj, but got Unknown
		//IL_00f7: Expected Obj, but got Ref
		//IL_00f7: Expected I4, but got Obj
		//IL_002e: Expected I, but got Obj
		//IL_0044: Expected Obj, but got I
		//IL_006f: Expected I, but got Obj
		//IL_00c9: Expected I4, but got Obj
		InitializeEnvironmentTransitions();
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S2_v2 (Il2CppMethodInfo)+C]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ S2_v3+60]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S2_v4+44]");
		object obj3 = 0;
		object obj4 = obj3 & 0x1FFF;
		object obj5 = obj4 + 22691;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v29 @ S3_v4 (should have been resolved before IL gen)");
		object obj6 = default;
		ref GameObject reference;
		if ((nint)obj6 > -1)
		{
			GameObject gameObject = _genericToThemePrefabDict.get_Item(genericPrefab);
			reference = ref *(GameObject*)gameObject;
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S1_v12 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj7 = (nint)0 & (nint)0x200;
			if (obj7 != null)
			{
				nint num3 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ S1_v22 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (themePrefab != null)
			{
				UnityEngine.Object obj8 = UnityEngine.Object.Instantiate((UnityEngine.Object)genericPrefab);
				string msg = string.ConcatArray((string[])(object)"Theme.TryGetThemePrefabFromGeneric(): generic prefab is set, but theme specific missing. Setting theme prefab to generic ", (int)obj8);
				SDebug.LogFormat(msg, null);
				reference = ref *(GameObject*)genericPrefab;
			}
			return true;
		}
		if (((ThemeManager)(object)this).GetEnvironmentModelVariationCount((RouteCategory)genericPrefab, (EnvironmentKind)System.Runtime.CompilerServices.Unsafe.AsPointer(ref themePrefab)) != 0)
		{
			return true;
		}
		reference = ref *(GameObject*)null;
		return false;
	}

	public bool ShouldIgnoreBase(EnvironmentKind envKind)
	{
		//IL_005f: Expected Obj, but got I
		//IL_006f: Expected Obj, but got I
		//IL_007f: Expected Obj, but got I
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Expected Obj, but got Unknown
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Expected Obj, but got Unknown
		//IL_003c: Expected I4, but got Obj
		//IL_00d2: Expected I4, but got Obj
		//IL_0014: Expected I4, but got Obj
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S2_v2 (Il2CppMethodInfo)+C]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S2_v3+60]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S2_v4+44]");
		object obj3 = 0;
		object obj4 = obj3 & 0x1FFF;
		object obj5 = obj4 + 22691;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v27 @ S3_v4 (should have been resolved before IL gen)");
		object obj6 = default;
		StateMachine.Trigger trigger2;
		if ((nint)obj6 > -1)
		{
			StateMachine.Trigger trigger = ((Dictionary<int, StateMachine.Trigger>)(object)_environmentTransitionConfigs).get_Item((int)envKind);
			trigger2 = trigger;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			StateMachine.Trigger trigger3 = default;
			trigger3.Id = (int)envKind;
			trigger2 = trigger3;
		}
		return (byte)(int)trigger2 != 0;
	}

	public float GetCameraDistanceToClosestBackgroundLayer()
	{
		return _glowGoldFalloff;
	}

	public unsafe Theme()
	{
		//IL_06d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_06db: Expected I, but got Unknown
		//IL_06e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e9: Expected Obj, but got Unknown
		//IL_06f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_06f7: Expected Obj, but got Unknown
		//IL_0393: Expected I, but got Obj
		//IL_03a9: Expected Obj, but got I
		//IL_0814: Expected I, but got Obj
		//IL_082f: Expected I, but got Obj
		//IL_0845: Expected Obj, but got I
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected Obj, but got Unknown
		//IL_0070: Expected I, but got Obj
		//IL_007d: Expected Obj, but got I
		//IL_0882: Unknown result type (might be due to invalid IL or missing references)
		//IL_0887: Expected Obj, but got Unknown
		//IL_03d4: Expected I, but got Obj
		//IL_0726: Unknown result type (might be due to invalid IL or missing references)
		//IL_072b: Expected Obj, but got Unknown
		//IL_0421: Expected I, but got Obj
		//IL_00a7: Expected I, but got Obj
		//IL_064c: Expected I, but got Obj
		//IL_0662: Expected Obj, but got I
		//IL_0962: Expected Obj, but got I
		//IL_0469: Expected Obj, but got I4
		//IL_0472: Expected Obj, but got I4
		//IL_068d: Expected I, but got Obj
		//IL_00d4: Expected Obj, but got I
		//IL_00e2: Expected Obj, but got I
		//IL_010d: Expected I, but got Obj
		//IL_0123: Expected Obj, but got I
		//IL_0480: Unknown result type (might be due to invalid IL or missing references)
		//IL_0485: Expected Obj, but got Unknown
		//IL_04ae: Expected I, but got Obj
		//IL_04c4: Expected Obj, but got I
		//IL_014e: Expected I, but got Obj
		//IL_05be: Expected I, but got Obj
		//IL_05d4: Expected Obj, but got I
		//IL_019a: Expected I, but got Obj
		//IL_01a8: Expected I, but got Obj
		//IL_01be: Expected Obj, but got I
		//IL_092f: Expected I, but got Obj
		//IL_08dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_08e1: Expected Obj, but got Unknown
		//IL_04ef: Expected I, but got Obj
		//IL_0789: Expected Obj, but got I
		//IL_05ff: Expected I, but got Obj
		//IL_01e9: Expected I, but got Obj
		//IL_055f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0564: Expected Obj, but got Unknown
		//IL_0235: Expected I, but got Obj
		//IL_0243: Expected Obj, but got I
		//IL_0255: Expected I, but got Obj
		//IL_026b: Expected Obj, but got I
		//IL_07b5: Expected Obj, but got VT
		//IL_0296: Expected I, but got Obj
		//IL_02e2: Expected I, but got Obj
		//IL_02f3: Expected Obj, but got I
		//IL_0305: Expected I, but got Obj
		//IL_031b: Expected Obj, but got I
		//IL_07e1: Expected Obj, but got I4
		//IL_0346: Expected I, but got Obj
		object obj = default;
		nint num = (nint)(obj + 16);
		object obj2 = obj + 8;
		object obj3 = obj + 24;
		if (Application.platform == RuntimePlatform.OSXEditor)
		{
			return;
		}
		object obj4 = default;
		object obj16 = default;
		while (true)
		{
			GenericAndThemePrefabGroup[] prefabMappingsGeneric = _prefabMappingsGeneric;
			if ((nint)obj4 >= prefabMappingsGeneric.Length)
			{
				break;
			}
			object obj5 = _prefabMappingsGeneric + 16;
			object obj6 = obj4 << 3;
			object obj7 = obj5 + obj6;
			((IntPtr*)num)->m_value = (void*)(nint)obj7;
			obj2 = (object)((IntPtr*)num)->m_value;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11+4]");
			if ((nint)0 != 0)
			{
				nint num2 = unchecked((nint)null);
				while (true)
				{
					((IntPtr*)num)->m_value = ((IntPtr*)num)->m_value;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9 (System.IntPtr)+4]");
					object obj8 = 0;
					nint intPtr = num2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v173 @ S1_v75+C]");
					if (intPtr >= 0)
					{
						break;
					}
					((IntPtr*)num)->m_value = ((IntPtr*)num)->m_value;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9 (System.IntPtr)+4]");
					object obj9 = (nint)0 + (nint)16;
					object obj10 = num2 << 3;
					object obj11 = obj9 + obj10;
					obj2 = obj11;
					obj = obj2;
					nint num3 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v198 @ S1_v86 (Il2CppClass<UnityEngine.Object>)+BA]");
					object obj12 = (nint)0 & (nint)0x200;
					if (obj12 != null)
					{
						nint num4 = (nint)typeof(UnityEngine.Object);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v213 @ S1_v123 (Il2CppClass<UnityEngine.Object>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					if (((ComputeShader)obj).FindKernel((string)null) != 0)
					{
						((IntPtr*)num)->m_value = (void*)(nint)obj2;
						nint num5 = (nint)typeof(UnityEngine.Object);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v236 @ S1_v95 (Il2CppClass<UnityEngine.Object>)+BA]");
						object obj13 = (nint)0 & (nint)0x200;
						if (obj13 != null)
						{
							nint num6 = (nint)typeof(UnityEngine.Object);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v280 @ S1_v119 (Il2CppClass<UnityEngine.Object>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9 (System.IntPtr)+4]");
						if (((ComputeShader)0).FindKernel(null) != 0)
						{
							((IntPtr*)num)->m_value = (void*)(nint)obj2;
							_0021_00210 componentInChildren = (_0021_00210)((GameObject)((IntPtr*)num)->m_value).GetComponentInChildren<T>();
							nint num7 = (nint)typeof(UnityEngine.Object);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v347 @ S0_v125 (Il2CppClass<UnityEngine.Object>)+BA]");
							object obj14 = (nint)0 & (nint)0x200;
							if (obj14 != null)
							{
								nint num8 = (nint)typeof(UnityEngine.Object);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v375 @ S0_v136 (Il2CppMethodInfo)+74]");
								if ((nint)0 == 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
								}
							}
							if (((ComputeShader)componentInChildren).FindKernel(null) != 0)
							{
								((IntPtr*)num)->m_value = (void*)(nint)obj2;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9 (System.IntPtr)+4]");
								int layer = ((GameObject)0).layer;
								nint num9 = (nint)typeof(PoolManager);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v421 @ S1_v108 (Il2CppClass<SYBO.Components.Utilities.PoolManager>)+BA]");
								object obj15 = (nint)0 & (nint)0x200;
								if (obj15 != null)
								{
									nint num10 = (nint)typeof(PoolManager);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v425 @ S1_v115 (Il2CppClass<UnityEngine.Object>)+74]");
									if ((nint)0 == 0)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
									}
								}
								bool flag = PoolManager.PrefabPoolExists((Transform)layer);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v327 @ S0_v123 (T)+C]");
								_ = 0;
							}
						}
					}
					nint num11 = num2 + 1;
					num2 = num11;
				}
			}
			obj4 = obj16 + 1;
		}
		nint num12 = (nint)typeof(Type);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ S0_v24 (Il2CppClass<System.Type>)+BA]");
		object obj17 = (nint)0 & (nint)0x200;
		if (obj17 != null)
		{
			nint num13 = (nint)typeof(Type);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ S0_v91 (Il2CppClass<System.Type>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		obj3 = typeof(DeviceInfo.PerformanceLevel);
		((IntPtr*)num)->m_value = (void*)(nint)obj3;
		Type enumType = Type.internal_from_handle((IntPtr)num);
		nint num14 = (nint)typeof(Enum);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v175 @ S1_v17 (Il2CppClass<System.Enum>)+BA]");
		object obj18 = (nint)0 & (nint)0x200;
		if (obj18 != null)
		{
			nint num15 = (nint)typeof(Enum);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v204 @ S1_v59 (Il2CppClass<System.Enum>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		ulong[] array = Enum.InternalGetValues((System.RuntimeType)enumType);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @81FC");
		object obj20 = default;
		object obj19 = obj20 + 12;
		int num16 = 0;
		while (true)
		{
			List<ThemePreloadSetting> themePreloadSettings = _themePreloadSettings;
			if (num16 >= themePreloadSettings._size)
			{
				break;
			}
			object obj21 = 0;
			object obj22 = 0;
			while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj21) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj19))
			{
				object obj23 = obj20 + 16;
				object obj24 = obj21 << 2;
				object obj25 = obj23 + obj24;
				nint num17 = (nint)typeof(DeviceInfo);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v337 @ S0_v71 (Il2CppClass<DeviceInfo>)+BA]");
				object obj26 = (nint)0 & (nint)0x200;
				if (obj26 != null)
				{
					nint num18 = (nint)typeof(DeviceInfo);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v352 @ S0_v87 (Il2CppClass<System.Enum>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				int runAverageFPS = InRunAverageFPSCounter.runAverageFPS;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v360 @ S0_v76 (System.Int32)+8]");
				if (0 >= (nint)obj25)
				{
					ThemePreloadSetting themePreloadSetting = _themePreloadSettings.get_Item(num16);
					bool flag2 = (RouteChunk.ChunkBlockConstraint)(object)themePreloadSetting == (RouteChunk.ChunkBlockConstraint)obj25;
					object obj27 = flag2 + obj22;
					obj22 = obj27;
				}
				object obj28 = obj21 + 1;
				obj21 = obj28;
			}
			if ((nint)obj22 >= 1)
			{
				ThemePreloadSetting themePreloadSetting2 = _themePreloadSettings.get_Item(num16);
				nint num19 = (nint)typeof(PoolManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v388 @ S1_v39 (Il2CppClass<SYBO.Components.Utilities.PoolManager>)+BA]");
				object obj29 = (nint)0 & (nint)0x200;
				if (obj29 != null)
				{
					nint num20 = (nint)typeof(PoolManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v405 @ S1_v45 (Il2CppClass<SYBO.Components.Utilities.PoolManager>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				bool flag3 = PoolManager.PrefabPoolExists(themePreloadSetting2._prefab);
				nint num2 = (nint)typeof(PoolManager);
			}
			int num21 = num16 + 1;
			num16 = num21;
		}
		nint num22 = (nint)typeof(PoolManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v292 @ S0_v42 (Il2CppClass<SYBO.Components.Utilities.PoolManager>)+BA]");
		object obj30 = (nint)0 & (nint)0x200;
		if (obj30 != null)
		{
			nint num23 = (nint)typeof(PoolManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v315 @ S0_v47 (Il2CppClass<SYBO.Components.Utilities.PoolManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		PoolManager.BeginBalancing(null);
	}
}
