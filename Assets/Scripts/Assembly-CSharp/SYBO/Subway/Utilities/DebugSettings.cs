using System;
using Cpp2ILInjected;
using SYBO.Common.Components.Singleton;
using SYBO.Common.Utilities;
using SYBO.Subway.Managers;
using UnityEngine;

namespace SYBO.Subway.Utilities;

public class DebugSettings : SingletonMonobehavior<DebugSettings>
{
	private bool _unlockedSceneCamera = true;

	private bool _characterInvincible;

	private bool _dontUseAssetBundlesInEditor = true;

	private bool _useManifestsForAssetBundlesInEditor;

	private bool _dontUseIdles;

	private bool _forceHighResCharacterTextures;

	private bool _editorDevicePerformanceLevelOverride;

	private DeviceInfo.PerformanceLevel _editorDevicePerformanceLevel;

	public static bool IsAllowed => Debug.isDebugBuild;

	public static bool UnlockedSceneCamera
	{
		get
		{
			//IL_0013: Expected VT, but got Obj
			CheckIsAllowed();
			_00210 val = (_00210)SingletonMonobehavior<>.Instance;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v8 (T)+C]");
			return false;
		}
	}

	public static bool CharacterInvincible
	{
		get
		{
			//IL_0013: Expected VT, but got Obj
			CheckIsAllowed();
			_00210 val = (_00210)SingletonMonobehavior<>.Instance;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v8 (T)+D]");
			return false;
		}
		set
		{
			//IL_0013: Expected VT, but got Obj
			CheckIsAllowed();
			_00210 val = (_00210)SingletonMonobehavior<>.Instance;
		}
	}

	public static bool DontUseBaseBundleInEditor
	{
		get
		{
			//IL_0013: Expected VT, but got Obj
			CheckIsAllowed();
			_00210 val = (_00210)SingletonMonobehavior<>.Instance;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v8 (T)+E]");
			return false;
		}
		set
		{
			//IL_0013: Expected VT, but got Obj
			CheckIsAllowed();
			_00210 val = (_00210)SingletonMonobehavior<>.Instance;
		}
	}

	public static bool UseManifestsForAssetBundlesInEditor
	{
		get
		{
			//IL_0013: Expected VT, but got Obj
			CheckIsAllowed();
			_00210 val = (_00210)SingletonMonobehavior<>.Instance;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v8 (T)+F]");
			return false;
		}
	}

	public static bool DontUseIdles
	{
		get
		{
			//IL_0013: Expected VT, but got Obj
			CheckIsAllowed();
			_00210 val = (_00210)SingletonMonobehavior<>.Instance;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v8 (T)+10]");
			return false;
		}
		set
		{
			//IL_0013: Expected VT, but got Obj
			CheckIsAllowed();
			_00210 val = (_00210)SingletonMonobehavior<>.Instance;
		}
	}

	public static bool ForceHighResCharacterTextures
	{
		get
		{
			//IL_0013: Expected VT, but got Obj
			CheckIsAllowed();
			_00210 val = (_00210)SingletonMonobehavior<>.Instance;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v8 (T)+11]");
			return false;
		}
	}

	public static bool OverrideEditorDevicePerformanceLevel
	{
		get
		{
			//IL_0013: Expected VT, but got Obj
			CheckIsAllowed();
			_00210 val = (_00210)SingletonMonobehavior<>.Instance;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v8 (T)+12]");
			return false;
		}
	}

	public static DeviceInfo.PerformanceLevel EditorDevicePerformanceLevel
	{
		get
		{
			//IL_0013: Expected VT, but got Obj
			CheckIsAllowed();
			_00210 val = (_00210)SingletonMonobehavior<>.Instance;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v8 (T)+14]");
			return DeviceInfo.PerformanceLevel.Low;
		}
	}

	protected override void Initialize()
	{
		Transform childTransform = transform;
		HierarchyUtility.ReparentByHierarchyPathType(childTransform, HierarchyPathType.Manual);
	}

	private static void CheckIsAllowed()
	{
		if (!IsAllowed)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			InvalidOperationException ex = default;
			ex._002Ector("Use of DebugSetting not allowed");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
		}
	}

	protected void Awake()
	{
		if (DemoVideoModeManager.IsEnabled)
		{
			CharacterInvincible = true;
		}
	}
}
