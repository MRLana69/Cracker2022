using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using SYBO.Common.Utilities;
using SYBO.Components.Utilities;
using SYBO.Components.Utilities.Validators;
using SYBO.Subway.Characters;
using SYBO.Subway.StateSystem;
using SYBO.Subway.Themes;
using UnityEngine;

namespace SYBO.Subway.Managers;

public class SceneViewWindowManager : SingletonMonoBehaviour<SceneViewWindowManager>
{
	private Character _character;

	private bool _isEnabled;

	private SceneViewCameraTargetType __sceneViewCameraTargetType;

	private SceneViewCameraZoomType __sceneViewCameraZoomType;

	protected List<SceneViewCameraTargetType> _sceneViewCameraTargetTypes;

	protected int _sceneViewCameraTargetTypesIndex;

	protected List<SceneViewCameraZoomType> _sceneViewCameraZoomTypes;

	protected int _sceneViewCameraZoomTypesIndex;

	public Character Character
	{
		get
		{
			//IL_0065: Expected I, but got Obj
			//IL_007b: Expected Obj, but got I
			//IL_00b6: Expected Obj, but got I
			//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c4: Expected Obj, but got Unknown
			//IL_00e8: Expected Obj, but got VT
			//IL_0121: Expected Obj, but got I4
			//IL_0013: Expected I, but got Obj
			nint num = (nint)typeof(ThemeManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v9 (Il2CppClass<SYBO.Subway.Themes.ThemeManager>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(ThemeManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v24 (Il2CppClass<SYBO.Subway.Themes.ThemeManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			GameStateMachine instance = GameStateMachine.Instance;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S1_v5 (SYBO.Subway.StateSystem.GameStateMachine)+20]");
			ThemeManager themeManager = default;
			themeManager.ThemeChanged += (Action<Theme>)0;
			QualitySettingsManager qualitySettingsManager = (QualitySettingsManager)(themeManager + 52);
			qualitySettingsManager = (QualitySettingsManager)(object)themeManager;
			_ = ((UnityEngine.Object)themeManager).m_CachedPtr;
			qualitySettingsManager.OnQualityTypeChanged = (EventHandler<QualitySettingsManager.QualityTypeChangedEventArgs>)themeManager._distortion;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7 (SYBO.Subway.Themes.ThemeManager)+18]");
			_ = 0;
			_ = themeManager._theme;
			_ = themeManager._cameraCulling;
			_ = themeManager._backgroundToFogBlendStartDistance;
			return (Character)qualitySettingsManager.GetQualityLevelIntFromName((string)(object)this);
		}
		set
		{
			if ((object)_character != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7A74");
			}
		}
	}

	public bool IsEnabled
	{
		get
		{
			//IL_0007: Expected I4, but got Obj
			return (byte)(int)_character != 0;
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected Obj, but got Unknown
			//IL_0013: Expected Obj, but got I4
			object obj = this + 16;
			obj = value;
		}
	}

	public SceneViewCameraTargetType SceneViewCameraTargetType
	{
		get
		{
			return _isEnabled ? SceneViewCameraTargetType.WorldOrigin : SceneViewCameraTargetType.Character;
		}
		set
		{
			bool isEnabled = (byte)(value & SceneViewCameraTargetType.WorldOrigin) != 0;
			_isEnabled = isEnabled;
		}
	}

	public SceneViewCameraZoomType SceneViewCameraZoomType
	{
		get
		{
			return (SceneViewCameraZoomType)__sceneViewCameraTargetType;
		}
		set
		{
			__sceneViewCameraTargetType = (SceneViewCameraTargetType)value;
		}
	}

	public Vector3 GetSceneViewPivot()
	{
		Vector3 result = default;
		return result;
	}

	public unsafe Quaternion GetSceneViewRotation()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0017: Expected Obj, but got I4
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Expected Obj, but got Unknown
		//IL_00a2: Expected F4, but got Obj
		//IL_009d: Expected native int or pointer, but got VT
		//IL_00b7: Expected F4, but got I
		//IL_00b2: Expected native int or pointer, but got VT
		//IL_0045: Expected Obj, but got F4
		object obj2 = default;
		object obj = obj2 + 12;
		obj = 0;
		_ = 0;
		if (__sceneViewCameraTargetType != SceneViewCameraTargetType.Character)
		{
			obj = 0f;
			_ = 0f;
			_ = 0f;
		}
		else
		{
			object obj3 = _character + 248;
			obj2 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S1_v12+8]");
			_ = 0;
			obj = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			_ = 0;
		}
		Quaternion quaternion = default;
		((Quaternion*)(nint)quaternion)->x = (float)obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v9 @ S0_v5+8]");
		((Quaternion*)(nint)quaternion)->z = 0f;
		return quaternion;
	}

	protected override void SubclassInitialize()
	{
		((Validator<>)(object)this)._002Ector();
	}

	public void ShowNextSceneViewCameraTargetType()
	{
		//IL_001d: Expected VT, but got I4
		GameObject childTransform = gameObject;
		HierarchyUtility.ReparentByHierarchyPathType((Transform)(object)childTransform, HierarchyPathType.DynamicManagers, (Vector3)0);
	}

	public void ShowNextSceneViewZoomType()
	{
		//IL_00ba: Expected Obj, but got I
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected Obj, but got Unknown
		if (~(_isEnabled ? 1u : 0u) == 0)
		{
			if (_sceneViewCameraTargetTypes == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @BB79");
				object obj = this + 32;
				object obj2 = default;
				obj = obj2;
				_sceneViewCameraTargetTypes.Add(SceneViewCameraTargetType.Character);
				_sceneViewCameraTargetTypes.Add(SceneViewCameraTargetType.WorldOrigin);
			}
			int sceneViewCameraTargetTypesIndex = _sceneViewCameraTargetTypesIndex + 1;
			_sceneViewCameraTargetTypesIndex = sceneViewCameraTargetTypesIndex;
			List<SceneViewCameraTargetType> sceneViewCameraTargetTypes = _sceneViewCameraTargetTypes;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ S1_v8 (System.Collections.Generic.List`1<SYBO.Subway.Managers.SceneViewCameraTargetType>)+C]");
			object obj3 = -1;
			if (_sceneViewCameraTargetTypesIndex > (nint)obj3)
			{
				_sceneViewCameraTargetTypesIndex = 0;
			}
			SceneViewCameraTargetType _sceneViewCameraTargetType = _sceneViewCameraTargetTypes.get_Item(_sceneViewCameraTargetTypesIndex);
			__sceneViewCameraTargetType = _sceneViewCameraTargetType;
		}
	}

	public bool HasSceneView()
	{
		return (byte)__sceneViewCameraZoomType != 0;
	}

	public object GetSceneView()
	{
		return null;
	}

	public void UpdatePropertiesOnSceneView()
	{
		//IL_00ba: Expected Obj, but got I
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected Obj, but got Unknown
		if (~(_isEnabled ? 1u : 0u) == 0)
		{
			if (_sceneViewCameraZoomTypes == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @BB79");
				object obj = this + 40;
				object obj2 = default;
				obj = obj2;
				_sceneViewCameraZoomTypes.Add(SceneViewCameraZoomType.Default);
				_sceneViewCameraZoomTypes.Add(SceneViewCameraZoomType.Chase);
			}
			int sceneViewCameraZoomTypesIndex = _sceneViewCameraZoomTypesIndex + 1;
			_sceneViewCameraZoomTypesIndex = sceneViewCameraZoomTypesIndex;
			List<SceneViewCameraZoomType> sceneViewCameraZoomTypes = _sceneViewCameraZoomTypes;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ S1_v8 (System.Collections.Generic.List`1<SYBO.Subway.Managers.SceneViewCameraZoomType>)+C]");
			object obj3 = -1;
			if (_sceneViewCameraZoomTypesIndex > (nint)obj3)
			{
				_sceneViewCameraZoomTypesIndex = 0;
			}
			SceneViewCameraZoomType _sceneViewCameraZoomType = _sceneViewCameraZoomTypes.get_Item(_sceneViewCameraZoomTypesIndex);
			__sceneViewCameraZoomType = _sceneViewCameraZoomType;
		}
	}

	private void RepaintSceneView()
	{
	}
}
