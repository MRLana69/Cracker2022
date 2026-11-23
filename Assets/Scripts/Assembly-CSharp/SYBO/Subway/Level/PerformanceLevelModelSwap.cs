using Cpp2ILInjected;
using SYBO.Common.Utilities;
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
		if (~(_initialized ? 1u : 0u) != 0)
		{
			Renderer component = GetComponent<Renderer>();
			_renderer = component;
			MeshFilter component2 = GetComponent<MeshFilter>();
			_meshFilter = component2;
			ThemeManager instance = ThemeManager.Instance;
			_themeManager = instance;
			_initialized = true;
		}
	}

	private void Start()
	{
		InitializeCheck();
	}

	public void SwapMaterials()
	{
	}

	private bool SwapMaterials(DeviceInfo.PerformanceLevel perfLevel)
	{
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Expected Obj, but got Unknown
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Expected Obj, but got Unknown
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Expected Obj, but got Unknown
		object meshInfo;
		switch (perfLevel)
		{
		default:
			return false;
		case DeviceInfo.PerformanceLevel.Low:
			meshInfo = this + 12;
			break;
		case DeviceInfo.PerformanceLevel.Medium:
			meshInfo = this + 16;
			break;
		case DeviceInfo.PerformanceLevel.High:
			meshInfo = this + 20;
			break;
		}
		return UpdateModel((ModelInfo)meshInfo);
	}

	private bool UpdateModel(ModelInfo meshInfo)
	{
		bool flag = meshInfo.Mesh == null;
		if (!flag)
		{
			_meshFilter.mesh = meshInfo.Mesh;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B24");
		}
		return (byte)((flag ? 1u : 0u) ^ 1u) != 0;
	}
}
