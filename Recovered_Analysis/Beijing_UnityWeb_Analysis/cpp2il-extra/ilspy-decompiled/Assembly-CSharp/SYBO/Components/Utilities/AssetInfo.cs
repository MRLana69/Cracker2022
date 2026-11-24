using System;
using UnityEngine;

namespace SYBO.Components.Utilities;

[Serializable]
public class AssetInfo
{
	public string Guid;

	public bool IsIncluded;

	public AssetInfo()
	{
		ScriptableObject.CreateScriptableObject((ScriptableObject)(object)this);
	}
}
