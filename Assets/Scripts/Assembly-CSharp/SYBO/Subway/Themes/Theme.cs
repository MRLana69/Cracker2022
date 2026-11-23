using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using SYBO.Components.Utilities;
using SYBO.Subway.Level;
using SYBO.Subway.Level.Environments;
using SYBO.Subway.Visuals;
using UnityEngine;

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
			_prefab = prefab;
			string name = prefab.name;
			_prefabName = name;
		}

		public void SetPreloadAmount(DeviceInfo.PerformanceLevel perfLevel, int amount)
		{
			switch (perfLevel)
			{
			case DeviceInfo.PerformanceLevel.Low:
				_preloadAmountLowPerf = amount;
				break;
			case DeviceInfo.PerformanceLevel.Medium:
				_preloadAmountMediumPerf = amount;
				break;
			case DeviceInfo.PerformanceLevel.High:
				_preloadAmountHighPerf = amount;
				break;
			default:
			{
				object[] array = Array.Empty<object>();
				break;
			}
			}
		}

		public int GetPreloadAmount(DeviceInfo.PerformanceLevel perfLevel)
		{
			switch (perfLevel)
			{
			case DeviceInfo.PerformanceLevel.Low:
				return _preloadAmountLowPerf;
			case DeviceInfo.PerformanceLevel.Medium:
				return _preloadAmountMediumPerf;
			case DeviceInfo.PerformanceLevel.High:
				return _preloadAmountHighPerf;
			default:
			{
				object[] array = Array.Empty<object>();
				return 0;
			}
			}
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

	private MaterialGroup[] _devicePerformanceRelativeMaterials;

	private GenericAndThemePrefabGroup[] _prefabMappingsGeneric;

	private RouteEnvironmentModelAssets[] _routeEnvironmentModelAssets;

	public const string FieldPatternGroundAsset = "_groundAssets.";

	private GroundAssetGroup _groundAssets;

	private List<EnvironmentKind> _baseIgnoredEnvironmentKinds;

	private List<ThemePreloadSetting> _themePreloadSettings;

	[NonSerialized]
	private bool _initialized;

	private Dictionary<GameObject, GameObject> _genericToThemePrefabDict;

	private Dictionary<Material, Material> _devicePerformanceRelativeMaterialsDict;

	public Shader BackgroundLayerCommonMaterialShader
	{
		get
		{
			Background background = _background;
			return background.LayerCommonMaterialShader;
		}
	}

	public float BackgroundLayerSpacing
	{
		get
		{
			Background background = _background;
			return background.LayerSpacing;
		}
	}

	public float BackgroundSkylineLeftLimit
	{
		get
		{
			Background background = _background;
			return background.SkylineLeftLimit;
		}
	}

	public float BackgroundSkylineRightLimit
	{
		get
		{
			Background background = _background;
			return background.SkylineRightLimit;
		}
	}

	public BackgroundLayer[] BackgroundLayers
	{
		get
		{
			Background background = _background;
			return background.Layers;
		}
	}

	public DistantEnvironmentController.DistantObjectGlobalConfig DistantObjectGlobalConfig => _distantObjectGlobalConfig;

	public DistantEnvironmentController.DistantObjectConfig[] DistantObjectConfigs => _distantObjectConfigs;

	public unsafe Color FogColor
	{
		get
		{
			//IL_000f: Expected F4, but got VT
			//IL_000a: Expected native int or pointer, but got VT
			//IL_0024: Expected F4, but got I
			//IL_001f: Expected native int or pointer, but got VT
			Color color = default;
			((Color*)(nint)color)->r = (float)_fogColor;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L1 (SYBO.Subway.Themes.Theme)+24]");
			((Color*)(nint)color)->b = 0f;
			return color;
		}
	}

	public unsafe Color BackgroundGradientTopColor
	{
		get
		{
			//IL_001c: Expected F4, but got VT
			//IL_0017: Expected native int or pointer, but got VT
			//IL_0031: Expected F4, but got I
			//IL_002c: Expected native int or pointer, but got VT
			Background background = _background;
			Color color = default;
			((Color*)(nint)color)->r = (float)background.GradientTopColor;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4 @ S1_v2 (SYBO.Subway.Level.Background)+2C]");
			((Color*)(nint)color)->b = 0f;
			return color;
		}
	}

	public unsafe Color BackgroundGradientBottomColor
	{
		get
		{
			//IL_001c: Expected F4, but got VT
			//IL_0017: Expected native int or pointer, but got VT
			//IL_0031: Expected F4, but got I
			//IL_002c: Expected native int or pointer, but got VT
			Background background = _background;
			Color color = default;
			((Color*)(nint)color)->r = (float)background.GradientBottomColor;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4 @ S1_v2 (SYBO.Subway.Level.Background)+3C]");
			((Color*)(nint)color)->b = 0f;
			return color;
		}
	}

	public float FogStartDistance => _fogStartDistance;

	public float FogEndDistance => _fogEndDistance;

	public float BackgroundStartDistance => _backgroundStartDistance;

	public float DistantFogStartDistance => _distantFogStartDistance;

	public float DistantFogEndDistance => _distantFogEndDistance;

	public float DistantBackgroundStartDistance => _distantBackgroundStartDistance;

	public float BackgroundGradientBottom
	{
		get
		{
			Background background = _background;
			return background.GradientBottom;
		}
	}

	public float BackgroundGradientTop
	{
		get
		{
			Background background = _background;
			return background.GradientTop;
		}
	}

	public Material GlowGoldMaterial => _glowGold;

	public unsafe Color GlowGoldColor
	{
		get
		{
			//IL_000f: Expected F4, but got VT
			//IL_000a: Expected native int or pointer, but got VT
			//IL_0024: Expected F4, but got I
			//IL_001f: Expected native int or pointer, but got VT
			Color color = default;
			((Color*)(nint)color)->r = (float)_glowGoldColor;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L1 (SYBO.Subway.Themes.Theme)+4C]");
			((Color*)(nint)color)->b = 0f;
			return color;
		}
	}

	public float GlowGoldFalloff => _glowGoldFalloff;

	public ThemeEffect[] Effects => _effects;

	public bool RoofedCullingEnabled => _roofedCullingEnabled;

	public EnvironmentType[] RoofedCullingEnvironmentsHigh => _roofedCullingEnvironmentsHigh;

	public EnvironmentType[] RoofedCullingEnvironmentsLow => _roofedCullingEnvironmentsLow;

	public RoofedCulling.CustomRoofedCulling[] RoofedCullingEnvironmentsCustom => _roofedCullingEnvironmentsCustom;

	public GenericAndThemePrefabGroup[] GenericToThemePrefabMappingGroups => _prefabMappingsGeneric;

	public RouteEnvironmentModelAssets[] RouteEnvironmentModelAssets => _routeEnvironmentModelAssets;

	public GroundAssetGroup GroundAssets
	{
		get
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected Obj, but got Unknown
			object obj = this + 124;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22A");
			GroundAssetGroup result = default;
			return result;
		}
	}

	public string ThemePath
	{
		get
		{
			string text = name;
			return "Assets/Themes/" + text;
		}
	}

	public TransitionConfig[] EnvironmentTransitionConfigs => _environmentTransitionConfigs;

	private void OnEnable()
	{
		_initialized = false;
		Initialize();
	}

	private void EditorInitData()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 96;
		_ = 0;
		throw new IndexOutOfRangeException();
	}

	public void Initialize()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_00ef: Expected Obj, but got I
		//IL_0271: Expected Obj, but got I4
		//IL_03bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c4: Expected Obj, but got Unknown
		//IL_011f: Expected Obj, but got I4
		//IL_02a1: Expected Obj, but got I
		//IL_02b3: Expected Obj, but got I
		//IL_0142: Unknown result type (might be due to invalid IL or missing references)
		//IL_0147: Expected Obj, but got Unknown
		//IL_0166: Expected Obj, but got I
		//IL_0321: Unknown result type (might be due to invalid IL or missing references)
		//IL_0326: Expected Obj, but got Unknown
		//IL_0413: Unknown result type (might be due to invalid IL or missing references)
		//IL_0418: Expected Obj, but got Unknown
		//IL_022a: Unknown result type (might be due to invalid IL or missing references)
		//IL_022f: Expected Obj, but got Unknown
		//IL_019b: Expected Obj, but got I
		//IL_0334: Unknown result type (might be due to invalid IL or missing references)
		//IL_0339: Expected Obj, but got Unknown
		//IL_035a: Expected Obj, but got I
		//IL_01cb: Expected Obj, but got I
		//IL_01db: Expected Obj, but got I
		//IL_01eb: Expected Obj, but got I
		//IL_01fb: Expected Obj, but got I
		//IL_0216: Expected Obj, but got I
		//IL_021a: Expected VT, but got Obj
		object obj2 = default;
		object obj = obj2 - 16;
		if (~(_initialized ? 1u : 0u) == 0)
		{
			return;
		}
		nint num = 0;
		nint num2 = 0;
		IntPtr intPtr = num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v77 @ S4_v5 (Il2CppClass<Il2CppRgctx<System.Collections.Generic.Dictionary`2<UnityEngine.GameObject, UnityEngine.GameObject>>>)+4] (should have been resolved before IL gen)");
		Dictionary<GameObject, GameObject> genericToThemePrefabDict = default;
		_genericToThemePrefabDict = genericToThemePrefabDict;
		nint num3 = 0;
		nint num4 = 0;
		IntPtr intPtr2 = num4;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v98 @ S4_v10 (Il2CppClass<Il2CppRgctx<System.Collections.Generic.Dictionary`2<UnityEngine.Material, UnityEngine.Material>>>)+4] (should have been resolved before IL gen)");
		Dictionary<Material, Material> devicePerformanceRelativeMaterialsDict = default;
		_devicePerformanceRelativeMaterialsDict = devicePerformanceRelativeMaterialsDict;
		bool flag = _prefabMappingsGeneric == null;
		GenericAndThemePrefabGroup[] prefabMappingsGeneric = _prefabMappingsGeneric;
		if (!flag)
		{
			object obj3 = default;
			object obj16 = default;
			while ((nint)obj3 < prefabMappingsGeneric.Length)
			{
				object obj4 = obj3 << 3;
				object obj5 = (object)prefabMappingsGeneric + obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v151 @ S1_v32+10]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
				object obj6 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
				if ((nint)0 != 0)
				{
					object obj7 = 0;
					while (true)
					{
						object obj8 = obj7;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ S0_v75+C]");
						if ((nint)obj8 >= 0)
						{
							break;
						}
						object obj9 = obj7 << 3;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
						object obj10 = 0 + obj9;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v218 @ S1_v40+10]");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
						if ((UnityEngine.Object)0 != null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
							if ((UnityEngine.Object)0 != null)
							{
								nint num5 = 0;
								UnityEngine.Object obj11 = (UnityEngine.Object)0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v309 @ S5_v15 (UnityEngine.Object)+10]");
								object obj12 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v310 @ S5_v16+60]");
								object obj13 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v311 @ S5_v17+5C]");
								object obj14 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v312 @ S5_v18+4] (should have been resolved before IL gen)");
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
								_0021_00210 val = (_0021_00210)NGUITools.AddMissingComponent<T>((GameObject)0);
							}
						}
						object obj15 = obj7 + 1;
						obj7 = obj15;
					}
				}
				obj3 = obj16 + 1;
				prefabMappingsGeneric = _prefabMappingsGeneric;
			}
		}
		DeviceInfo instance = DeviceInfo.Instance;
		if (_devicePerformanceRelativeMaterials != null && instance.performanceLevel != DeviceInfo.PerformanceLevel.High)
		{
			MaterialGroup[] devicePerformanceRelativeMaterials = _devicePerformanceRelativeMaterials;
			object obj24;
			for (object obj17 = 0; (nint)obj17 < devicePerformanceRelativeMaterials.Length; obj24 = obj17 + 1, devicePerformanceRelativeMaterials = _devicePerformanceRelativeMaterials, obj17 = obj24)
			{
				object obj18 = obj17 << 2;
				object obj19 = (object)devicePerformanceRelativeMaterials + obj18;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v253 @ S0_v42+10]");
				object obj20 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v254 @ S0_v43+C]");
				if (!((UnityEngine.Object)0 != null))
				{
					continue;
				}
				UnityEngine.Object obj21;
				object obj22;
				if (instance.performanceLevel != DeviceInfo.PerformanceLevel.Low)
				{
					if (instance.performanceLevel != DeviceInfo.PerformanceLevel.Medium)
					{
						obj21 = null;
						goto IL_042f;
					}
					obj22 = obj20 + 16;
				}
				else
				{
					obj22 = obj20 + 20;
				}
				obj21 = (UnityEngine.Object)obj22;
				goto IL_042f;
				IL_042f:
				if (obj21 != null)
				{
					nint num6 = 0;
					nint num7 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v344 @ S5_v8 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<UnityEngine.Material, UnityEngine.Material>>)+5C]");
					object obj23 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v345 @ S5_v9+4] (should have been resolved before IL gen)");
				}
			}
		}
		_initialized = true;
	}

	public void InitializeEnvironmentTransitions()
	{
		//IL_0069: Expected Obj, but got I4
		//IL_0055: Expected VT, but got Obj
		//IL_0031: Expected Obj, but got I
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected Obj, but got Unknown
		TransitionConfig[] environmentTransitionConfigs = _environmentTransitionConfigs;
		object obj = 0;
		while (environmentTransitionConfigs.Length > (nint)obj)
		{
			object obj2 = obj << 2;
			object obj3 = (object)environmentTransitionConfigs + obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S0_v16+10]");
			((TransitionConfig)0).Initialize();
			object obj4 = obj + 1;
			obj = obj4;
		}
		_00210 val = (_00210)Singleton<>.Instantiate();
	}

	public void PrepoolPrefabs()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_001c: Expected Obj, but got I4
		//IL_01c9: Expected VT, but got Obj
		//IL_002f: Expected I, but got Obj
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected Obj, but got Unknown
		//IL_0059: Expected Obj, but got I
		//IL_0383: Unknown result type (might be due to invalid IL or missing references)
		//IL_0388: Expected Obj, but got Unknown
		//IL_0465: Expected I, but got Obj
		//IL_0087: Expected Obj, but got I4
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Expected Obj, but got Unknown
		//IL_00ce: Expected Obj, but got I
		//IL_0239: Expected Obj, but got I
		//IL_00e7: Expected I, but got Obj
		//IL_039e: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a3: Expected Obj, but got Unknown
		//IL_0107: Expected Obj, but got I
		//IL_0120: Expected I, but got Obj
		//IL_013f: Expected Obj, but got I
		//IL_0166: Expected I, but got Obj
		//IL_0185: Expected Obj, but got I
		//IL_01b5: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 - 16;
		if (!Application.isPlaying)
		{
			return;
		}
		object obj3 = 0;
		while (true)
		{
			GenericAndThemePrefabGroup[] prefabMappingsGeneric = _prefabMappingsGeneric;
			if (prefabMappingsGeneric.Length <= (nint)obj3)
			{
				break;
			}
			nint num = obj3 << 3;
			object obj4 = prefabMappingsGeneric + num;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ S1_v33+10]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
			if ((nint)0 != 0)
			{
				object obj6 = 0;
				while (true)
				{
					object obj7 = obj6;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ S0_v76+C]");
					if ((nint)obj7 >= 0)
					{
						break;
					}
					object obj8 = obj6 << 3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
					object obj9 = 0 + obj8;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ S1_v41+10]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
					bool flag = (UnityEngine.Object)0 != null;
					bool flag2 = !flag;
					num = unchecked((nint)null);
					if (!flag2)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
						bool flag3 = (UnityEngine.Object)0 != null;
						bool flag4 = !flag3;
						num = unchecked((nint)null);
						if (!flag4)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
							PreloadSetting component = ((GameObject)0).GetComponent<PreloadSetting>();
							bool flag5 = component != null;
							bool flag6 = !flag5;
							num = unchecked((nint)null);
							if (!flag6)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
								Transform transform = ((GameObject)0).transform;
								PrefabPool prefabPool = PoolManager.GetPrefabPool(transform);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v228 @ S0_v104 (PreloadSetting)+C]");
								prefabPool.preloadAmount = 0;
								num = unchecked((nint)null);
							}
						}
					}
					object obj10 = obj6 + 1;
					obj6 = obj10;
				}
			}
			object obj11 = obj3 + 1;
			obj3 = obj11;
		}
		Type typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)typeof(DeviceInfo.PerformanceLevel));
		Array values = Enum.GetValues(typeFromHandle);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23D");
		int num2 = 0;
		object obj14 = default;
		while (true)
		{
			List<ThemePreloadSetting> themePreloadSettings = _themePreloadSettings;
			bool flag7 = num2 >= themePreloadSettings._size;
			nint num3 = unchecked((nint)null);
			int num4 = 0;
			if (flag7)
			{
				break;
			}
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ S0_v28+C]");
				if (0 <= num3)
				{
					break;
				}
				object obj12 = num3 << 2;
				object obj13 = obj14 + obj12;
				DeviceInfo instance = DeviceInfo.Instance;
				DeviceInfo.PerformanceLevel performanceLevel = instance.performanceLevel;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v218 @ S0_v58+10]");
				bool flag8 = (nint)performanceLevel >= (nint)0;
				bool flag9 = !flag8;
				nint num = 2;
				if (!flag9)
				{
					ThemePreloadSetting themePreloadSetting = _themePreloadSettings.get_Item(num2);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v218 @ S0_v58+10]");
					int preloadAmount = themePreloadSetting.GetPreloadAmount(DeviceInfo.PerformanceLevel.Low);
					int num5 = preloadAmount + num4;
					num4 = num5;
				}
				nint num6 = num3 + 1;
				num3 = num6;
			}
			if (num4 >= 1)
			{
				ThemePreloadSetting themePreloadSetting2 = _themePreloadSettings.get_Item(num2);
				PrefabPool prefabPool2 = PoolManager.GetPrefabPool(themePreloadSetting2._prefab);
				prefabPool2.preloadAmount = num4;
				nint num = 0;
			}
			int num7 = num2 + 1;
			num2 = num7;
		}
		PoolManager.TriggerPoolBalancing();
	}

	public bool TryGetDevicePerformanceRelativeMaterial(Material material, out Material performanceRelative)
	{
		Initialize();
		return _devicePerformanceRelativeMaterialsDict.TryGetValue(material, out performanceRelative);
	}

	public unsafe bool TryGetThemePrefabFromGeneric(GameObject genericPrefab, out GameObject themePrefab)
	{
		//IL_00ea: Expected Obj, but got I
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Expected Obj, but got Unknown
		Initialize();
		nint num = 0;
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S3_v3 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<UnityEngine.GameObject, UnityEngine.GameObject>>)+54]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v27 @ S3_v4+4] (should have been resolved before IL gen)");
		object obj3 = default;
		object obj2 = obj3 ^ -1;
		object obj4 = obj2 >> 31;
		bool result;
		if (obj4 != null)
		{
			GameObject gameObject = _genericToThemePrefabDict.get_Item(genericPrefab);
			ref GameObject reference = ref *(GameObject*)gameObject;
			bool flag = themePrefab == null;
			bool flag2 = !flag;
			result = true;
			if (!flag2)
			{
				string text = genericPrefab.name;
				string text2 = "Theme.TryGetThemePrefabFromGeneric(): generic prefab is set, but theme specific missing. Setting theme prefab to generic " + text;
				reference = ref *(GameObject*)genericPrefab;
				return true;
			}
		}
		else
		{
			bool flag3 = TryGetSynchronizedThemeAssetFromGeneric(genericPrefab, out themePrefab);
			result = true;
			if (!flag3)
			{
				ref GameObject reference = ref *(GameObject*)null;
				result = false;
			}
		}
		return result;
	}

	public unsafe bool TryGetSynchronizedThemeAssetFromGeneric(GameObject genericPrefab, out GameObject themePrefab)
	{
		Initialize();
		if (genericPrefab == null)
		{
			ref GameObject reference = ref *(GameObject*)null;
			return false;
		}
		bool flag = _genericToThemePrefabDict.TryGetValue(genericPrefab, out themePrefab);
		bool flag2 = !flag;
		bool result = false;
		if (!flag2)
		{
			bool flag3 = themePrefab == null;
			bool flag4 = !flag3;
			result = true;
			if (!flag4)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
				string text = genericPrefab.name;
				throw new ArrayTypeMismatchException();
			}
		}
		return result;
	}

	public bool ShouldIgnoreBase(EnvironmentKind envKind)
	{
		int num = 0;
		bool flag;
		while (true)
		{
			List<EnvironmentKind> baseIgnoredEnvironmentKinds = _baseIgnoredEnvironmentKinds;
			flag = num < baseIgnoredEnvironmentKinds._size;
			if (!flag)
			{
				break;
			}
			EnvironmentKind environmentKind = _baseIgnoredEnvironmentKinds.get_Item(num);
			if (environmentKind._type == envKind._type && environmentKind._density == envKind._density)
			{
				break;
			}
			int num2 = num + 1;
			num = num2;
		}
		return flag;
	}

	public float GetCameraDistanceToClosestBackgroundLayer()
	{
		//IL_0009: Expected Obj, but got I4
		//IL_0012: Expected Obj, but got I4
		//IL_0042: Expected Obj, but got I
		//IL_0191: Unknown result type (might be due to invalid IL or missing references)
		//IL_0196: Expected Obj, but got Unknown
		//IL_00ab: Expected Obj, but got I
		//IL_00e5: Expected Obj, but got I
		//IL_00f5: Expected Obj, but got I
		object obj = -1;
		object obj2 = 0;
		Background background;
		while (true)
		{
			background = _background;
			BackgroundLayer[] layers = background.Layers;
			if (layers.Length <= (nint)obj2)
			{
				break;
			}
			object obj3 = obj2 << 2;
			object obj4 = (object)layers + obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S1_v10+10]");
			object obj5 = 0;
			object obj6 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S1_v11+18]");
			if ((nint)obj6 < 0)
			{
				Background background2 = _background;
				object obj7 = obj2 << 2;
				object obj8 = (object)background2.Layers + obj7;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S0_v26+10]");
				object obj9 = 0;
				Background background3 = _background;
				object obj10 = obj2 << 2;
				object obj11 = (object)background3.Layers + obj10;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ S0_v32+10]");
				object obj12 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ S0_v27+18]");
				obj = 0;
			}
			object obj13 = obj2 + 1;
			obj2 = obj13;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ S0_v32+10]");
		if ((nint)0 == 0)
		{
			return 1000f;
		}
		float num = 0f - background.LayerSpacing;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S0_v33+18]");
		float num2 = 0f * num;
		float num3 = num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S0_v33+24]");
		float num4 = num3 + 0f;
		return num4 + 1000f;
	}

	public Theme()
	{
		Background background = default;
		background._002Ector();
		_background = background;
		DistantEnvironmentController.DistantObjectGlobalConfig distantObjectGlobalConfig = default;
		_distantObjectGlobalConfig = distantObjectGlobalConfig;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		DistantEnvironmentController.DistantObjectConfig[] distantObjectConfigs = default;
		_distantObjectConfigs = distantObjectConfigs;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		TransitionConfig[] environmentTransitionConfigs = default;
		_environmentTransitionConfigs = environmentTransitionConfigs;
		_glowGoldFalloff = 200f;
		_distantFogEndDistance = 850f;
		_backgroundStartDistance = 1000f;
		_fogStartDistance = 700f;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		ThemeEffect[] effects = default;
		_effects = effects;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		EnvironmentType[] roofedCullingEnvironmentsHigh = default;
		_roofedCullingEnvironmentsHigh = roofedCullingEnvironmentsHigh;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		EnvironmentType[] roofedCullingEnvironmentsLow = default;
		_roofedCullingEnvironmentsLow = roofedCullingEnvironmentsLow;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		RoofedCulling.CustomRoofedCulling[] roofedCullingEnvironmentsCustom = default;
		_roofedCullingEnvironmentsCustom = roofedCullingEnvironmentsCustom;
		List<EnvironmentKind> list = default;
		list._002Ector();
		_baseIgnoredEnvironmentKinds = list;
		List<ThemePreloadSetting> list2 = default;
		list2._002Ector();
		_themePreloadSettings = list2;
		base._002Ector();
	}
}
