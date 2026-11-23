using System.Collections.Generic;
using Cpp2ILInjected;
using SYBO.Common.Components.Singleton;
using SYBO.Common.Utilities;
using SYBO.Subway.Characters;
using UnityEngine;

namespace SYBO.Subway.Managers;

public class SceneViewWindowManager : SingletonMonobehavior<SceneViewWindowManager>
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
			return _character;
		}
		set
		{
			_character = value;
		}
	}

	public bool IsEnabled
	{
		get
		{
			return _isEnabled;
		}
		set
		{
			_isEnabled = value;
		}
	}

	public SceneViewCameraTargetType SceneViewCameraTargetType
	{
		get
		{
			return __sceneViewCameraTargetType;
		}
		set
		{
			__sceneViewCameraTargetType = value;
		}
	}

	public SceneViewCameraZoomType SceneViewCameraZoomType
	{
		get
		{
			return __sceneViewCameraZoomType;
		}
		set
		{
			__sceneViewCameraZoomType = value;
		}
	}

	public unsafe Vector3 GetSceneViewPivot()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0077: Expected native int or pointer, but got VT
		//IL_0085: Expected native int or pointer, but got VT
		//IL_005c: Expected F4, but got I
		//IL_0057: Expected native int or pointer, but got VT
		//IL_0069: Expected F4, but got Obj
		//IL_0064: Expected native int or pointer, but got VT
		object obj2 = default;
		object obj = obj2 - 16;
		Vector3 vector = default;
		if (__sceneViewCameraTargetType == SceneViewCameraTargetType.Character)
		{
			Vector3 currentTransformPosition = _character.CurrentTransformPosition;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
			((Vector3*)(nint)vector)->z = 0f;
			((Vector3*)(nint)vector)->x = (float)obj;
		}
		else
		{
			((Vector3*)(nint)vector)->x = 0f;
			((Vector3*)(nint)vector)->z = 0f;
		}
		return vector;
	}

	public unsafe Quaternion GetSceneViewRotation()
	{
		//IL_0060: Expected native int or pointer, but got VT
		//IL_006e: Expected native int or pointer, but got VT
		//IL_007c: Expected native int or pointer, but got VT
		//IL_0089: Expected native int or pointer, but got VT
		float x;
		float w;
		if (__sceneViewCameraZoomType == SceneViewCameraZoomType.Default)
		{
			x = 0.4f;
			w = 0.81f;
		}
		else
		{
			x = 0.05f;
			w = 0.05f;
		}
		Quaternion quaternion = default;
		((Quaternion*)(nint)quaternion)->w = w;
		((Quaternion*)(nint)quaternion)->z = 0.2f;
		((Quaternion*)(nint)quaternion)->y = -0.3f;
		((Quaternion*)(nint)quaternion)->x = x;
		return quaternion;
	}

	protected override void Initialize()
	{
		Transform childTransform = transform;
		HierarchyUtility.ReparentByHierarchyPathType(childTransform, HierarchyPathType.DynamicManagers);
	}

	public void ShowNextSceneViewCameraTargetType()
	{
		//IL_00a6: Expected Obj, but got I
		if (~(_isEnabled ? 1u : 0u) == 0)
		{
			if (_sceneViewCameraTargetTypes == null)
			{
				List<SceneViewCameraTargetType> list = default;
				list._002Ector();
				_sceneViewCameraTargetTypes = list;
				_sceneViewCameraTargetTypes.Add(SceneViewCameraTargetType.Character);
				_sceneViewCameraTargetTypes.Add(SceneViewCameraTargetType.WorldOrigin);
			}
			int num = ++_sceneViewCameraTargetTypesIndex;
			List<SceneViewCameraTargetType> sceneViewCameraTargetTypes = _sceneViewCameraTargetTypes;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ S1_v8 (System.Collections.Generic.List`1<SYBO.Subway.Managers.SceneViewCameraTargetType>)+C]");
			object obj = -1;
			int index;
			if (num <= (nint)obj)
			{
				index = _sceneViewCameraTargetTypesIndex;
			}
			else
			{
				_sceneViewCameraTargetTypesIndex = 0;
				index = 0;
			}
			SceneViewCameraTargetType _sceneViewCameraTargetType = _sceneViewCameraTargetTypes.get_Item(index);
			__sceneViewCameraTargetType = _sceneViewCameraTargetType;
		}
	}

	public void ShowNextSceneViewZoomType()
	{
		//IL_00a6: Expected Obj, but got I
		if (~(_isEnabled ? 1u : 0u) == 0)
		{
			if (_sceneViewCameraZoomTypes == null)
			{
				List<SceneViewCameraZoomType> list = default;
				list._002Ector();
				_sceneViewCameraZoomTypes = list;
				_sceneViewCameraZoomTypes.Add(SceneViewCameraZoomType.Default);
				_sceneViewCameraZoomTypes.Add(SceneViewCameraZoomType.Chase);
			}
			int num = ++_sceneViewCameraZoomTypesIndex;
			List<SceneViewCameraZoomType> sceneViewCameraZoomTypes = _sceneViewCameraZoomTypes;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ S1_v8 (System.Collections.Generic.List`1<SYBO.Subway.Managers.SceneViewCameraZoomType>)+C]");
			object obj = -1;
			int index;
			if (num <= (nint)obj)
			{
				index = _sceneViewCameraZoomTypesIndex;
			}
			else
			{
				_sceneViewCameraZoomTypesIndex = 0;
				index = 0;
			}
			SceneViewCameraZoomType _sceneViewCameraZoomType = _sceneViewCameraZoomTypes.get_Item(index);
			__sceneViewCameraZoomType = _sceneViewCameraZoomType;
		}
	}

	public bool HasSceneView()
	{
		return false;
	}

	public object GetSceneView()
	{
		return null;
	}

	public void UpdatePropertiesOnSceneView()
	{
	}

	private void RepaintSceneView()
	{
	}
}
