using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using SYBO.Common.Utilities;
using SYBO.Subway.StateSystem;
using SYBO.Subway.Themes;
using UnityEngine;

namespace SYBO.Subway.Level;

public class PerformanceLevelModelSwap : MonoBehaviour
{
	public PerformanceLevelModelInfo performanceLevelModel;

	private bool _initialized;

	private bool _swapEvaluated;

	private MeshFilter _meshFilter;

	private Renderer _renderer;

	private ThemeManager _themeManager;

	private void InitializeCheck()
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected Obj, but got Unknown
		_ = 90f;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		object obj = this + 20;
		object obj2 = default;
		obj = obj2;
	}

	private void Start()
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected Obj, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected Obj, but got Unknown
		//IL_0052: Expected I, but got Obj
		//IL_0068: Expected Obj, but got I
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Expected Obj, but got Unknown
		//IL_0093: Expected I, but got Obj
		if (~(_initialized ? 1u : 0u) == 0)
		{
			return;
		}
		object obj = this + 32;
		Renderer component = GetComponent<Renderer>();
		obj = component;
		object obj2 = this + 28;
		MeshFilter component2 = GetComponent<MeshFilter>();
		obj2 = component2;
		nint num = (nint)typeof(ThemeManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S0_v14 (Il2CppClass<SYBO.Subway.Themes.ThemeManager>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num2 = (nint)typeof(ThemeManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S0_v21 (Il2CppClass<SYBO.Subway.Themes.ThemeManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj4 = this + 36;
		GameStateMachine instance = GameStateMachine.Instance;
		obj4 = instance;
		_initialized = true;
	}

	public void SwapMaterials()
	{
		Start();
		if (~(_swapEvaluated ? 1u : 0u) != 0)
		{
			this._002Ector();
		}
	}

	private bool SwapMaterials(DeviceInfo.PerformanceLevel perfLevel)
	{
		//IL_0043: Invalid comparison between VT and I
		IntPtr cachedPtr = ((UnityEngine.Object)this).m_CachedPtr;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [perfLevel @ L1 (DeviceInfo+PerformanceLevel)+8]");
		if (cachedPtr == (IntPtr)0)
		{
			PerformanceLevelModelInfo performanceLevelModelInfo = performanceLevelModel;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [perfLevel @ L1 (DeviceInfo+PerformanceLevel)+C]");
			return performanceLevelModelInfo == (PerformanceLevelModelInfo)(object)0;
		}
		return false;
	}

	private bool UpdateModel(ModelInfo meshInfo)
	{
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Expected Obj, but got Unknown
		//IL_006f: Expected I4, but got Obj
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected Obj, but got Unknown
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Expected Obj, but got Unknown
		EnvironmentType envType;
		if (meshInfo != null)
		{
			if ((nint)meshInfo != 1)
			{
				if ((nint)meshInfo != 2)
				{
					return false;
				}
				object obj = this + 12;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S0_v13+8]");
				envType = EnvironmentType.None;
			}
			else
			{
				object obj2 = this + 12;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v10+4]");
				envType = EnvironmentType.None;
			}
		}
		else
		{
			object obj3 = this + 12;
			envType = (EnvironmentType)obj3;
		}
		return ((LogicAssetsManager)this).HasEnvironmentSegmentLogic(envType);
	}

	public unsafe PerformanceLevelModelSwap()
	{
		//IL_0023: Expected I, but got Obj
		//IL_0039: Expected Obj, but got I
		//IL_024c: Expected Obj, but got I
		//IL_0064: Expected I, but got Obj
		//IL_00b1: Expected I, but got Obj
		//IL_00c7: Expected Obj, but got I
		//IL_00f2: Expected I, but got Obj
		//IL_0152: Unknown result type (might be due to invalid IL or missing references)
		//IL_0157: Expected Obj, but got Unknown
		//IL_0165: Unknown result type (might be due to invalid IL or missing references)
		//IL_016a: Expected Obj, but got Unknown
		//IL_02c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ce: Expected Obj, but got Unknown
		ref GameObject reference = ref *(GameObject*)null;
		if (~(_swapEvaluated ? 1u : 0u) == 0)
		{
			return;
		}
		Start();
		ThemeManager themeManager = _themeManager;
		nint num = (nint)typeof(DeviceInfo);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ S0_v19 (Il2CppClass<DeviceInfo>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(DeviceInfo);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ S0_v61 (Il2CppClass<DeviceInfo>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		int runAverageFPS = InRunAverageFPSCounter.runAverageFPS;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ S1_v8 (System.Int32)+8]");
		if (!UpdateModel((ModelInfo)0))
		{
			nint num3 = (nint)typeof(DeviceInfo);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S0_v29 (Il2CppClass<DeviceInfo>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(DeviceInfo);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ S0_v57 (Il2CppClass<DeviceInfo>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			int runAverageFPS2 = InRunAverageFPSCounter.runAverageFPS;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ S0_v34 (System.Int32)+8]");
			if ((nint)0 != 2)
			{
				Shader shader = Shader.Find((string)(object)_renderer);
				reference = ref *(GameObject*)null;
				object obj3 = shader + 12;
				object obj4 = default;
				object obj7 = default;
				while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj4) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj3))
				{
					object obj5 = shader + 16;
					object obj6 = obj4 << 2;
					object genericPrefab = obj5 + obj6;
					if (themeManager._theme.TryGetThemePrefabFromGeneric((GameObject)genericPrefab, out reference))
					{
						throw new ArrayTypeMismatchException();
					}
					obj4 = obj7 + 1;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @FA1F");
			}
		}
		_swapEvaluated = true;
	}
}
