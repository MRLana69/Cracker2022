using System;

namespace SYBO.Subway.Themes;

[Serializable]
public struct GenericAndThemePrefabGroup
{
	public const string FieldPatternName = "Name";

	public string Name;

	public const string FieldPatternPrefabMappings = "PrefabMappings";

	public GenericAndThemePrefab[] PrefabMappings;
}
