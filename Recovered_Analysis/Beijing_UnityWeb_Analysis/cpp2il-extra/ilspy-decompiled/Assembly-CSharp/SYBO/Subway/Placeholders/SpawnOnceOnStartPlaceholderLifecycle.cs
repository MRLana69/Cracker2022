using System.Collections.Generic;
using Cpp2ILInjected;
using SYBO.Subway.Cameras;
using SYBO.Subway.Level;
using SYBO.Subway.Placeholders.Lifecycles;
using SYBO.Subway.Placeholders.PrefabProviders;
using UnityEngine;

namespace SYBO.Subway.Placeholders;

public class SpawnOnceOnStartPlaceholderLifecycle : PlaceholderLifecycle
{
	protected void Start()
	{
		_ = 1f;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724A");
	}

	private void SpawnInstances(bool spawnInChildrenLifecycles = false)
	{
		//IL_0041: Expected VT, but got I4
		//IL_0041: Expected VT, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Placeholders.SpawnOnceOnStartPlaceholderLifecycle)+18]");
		if ((nint)0 == 0)
		{
			((CharacterCamera)(object)this).SetCameraDataForcefully((CameraData)null, (Vector3)0, (Quaternion)0);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72FD");
		}
	}

	protected virtual void SpawnInstances(PlaceholderPrefabProviderBase prefabProvider, bool spawnInChildrenLifecycles = false)
	{
	}

	public SpawnOnceOnStartPlaceholderLifecycle()
	{
		//IL_0031: Expected Obj, but got I4
		if (Application.platform != RuntimePlatform.OSXEditor)
		{
			((Placeholder)(object)this).GetSpawnedObjects((List<Selector>)1);
		}
	}
}
