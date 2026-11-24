using System;
using UnityEngine;

namespace SYBO.Subway.Themes;

[Serializable]
public struct GenericAndThemePrefab
{
	public const string FieldPatternGenericPrefab = "GenericPrefab";

	public GameObject GenericPrefab;

	public const string FieldPatternThemePrefab = "ThemePrefab";

	public GameObject ThemePrefab;
}
