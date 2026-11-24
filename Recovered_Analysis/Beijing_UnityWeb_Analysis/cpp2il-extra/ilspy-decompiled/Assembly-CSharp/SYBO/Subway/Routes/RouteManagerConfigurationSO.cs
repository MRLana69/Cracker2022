using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using SYBO.Common.Utilities;
using SYBO.Components.Utilities.Validators;
using SYBO.Subway.Pickups;
using UnityEngine;

namespace SYBO.Subway.Routes;

[Serializable]
public class RouteManagerConfigurationSO : ScriptableObject
{
	public static string PREFAB_ASSET_PATH;

	public static string PREFAB_RESOURCE_PATH;

	public RouteManagerConfigurationSO()
	{
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Expected Obj, but got Unknown
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected Obj, but got Unknown
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected Obj, but got Unknown
		_ = 1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		RouteManager.AlternateRouteConfig alternateRouteConfig = default;
		alternateRouteConfig._002Ector();
		object obj = this + 80;
		obj = alternateRouteConfig;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		WeightRandomizedOrderedContainter<, >._003CEnumerator_003Ed__14 obj2 = default;
		((IDisposable)obj2).Dispose();
		object obj3 = this + 100;
		obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		List<PickupSpawnPoint> list = default;
		list._002Ector();
		object obj4 = this + 124;
		obj4 = list;
		((Validator<>)(object)this)._002Ector();
	}

	static RouteManagerConfigurationSO()
	{
		RouteManager.PrefabPath = "Assets/Resources/Prefabs/Managers/RouteManager.prefab";
	}
}
