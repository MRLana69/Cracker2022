using System;
using Cpp2ILInjected;
using SYBO.Common.Utilities;
using SYBO.Common.Visuals;
using UnityEngine;

namespace SYBO.Subway.Visuals;

public class OnActivationMeshCombineLauncher : MonoBehaviour
{
	private TrackObject _trackObject;

	private MeshCombiner _meshCombiner;

	private unsafe void Awake()
	{
		//IL_007a: Expected VT, but got Obj
		TrackObject component = GetComponent<TrackObject>();
		_trackObject = component;
		if (_trackObject != null)
		{
			Action action = default;
			action._002Ector(this, (nint)__ldftn(OnActivationMeshCombineLauncher.TrackObject_OnActivate));
			_trackObject.OnActivate += action;
			Action action2 = default;
			action2._002Ector(this, (nint)__ldftn(OnActivationMeshCombineLauncher.TrackObject_OnDeactivate));
			_trackObject.OnDeactivate += action2;
		}
		Type typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)typeof(MeshCombiner));
		Component component2 = GameObjectUtil.AddComponentIfMissing(this, typeFromHandle);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @238");
		MeshCombiner meshCombiner = default;
		_meshCombiner = meshCombiner;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @238");
	}

	private void TrackObject_OnActivate()
	{
		_meshCombiner.CombineInactive();
	}

	private void TrackObject_OnDeactivate()
	{
		_meshCombiner.DestroyCombined();
	}

	private unsafe void OnDestroy()
	{
		if (_trackObject != null)
		{
			Action action = default;
			action._002Ector(this, (nint)__ldftn(OnActivationMeshCombineLauncher.TrackObject_OnActivate));
			_trackObject.OnActivate -= action;
			Action action2 = default;
			action2._002Ector(this, (nint)__ldftn(OnActivationMeshCombineLauncher.TrackObject_OnDeactivate));
			_trackObject.OnDeactivate -= action2;
		}
	}
}
