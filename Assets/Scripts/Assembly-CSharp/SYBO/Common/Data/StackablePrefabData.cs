using System;
using System.Collections.Generic;
using UnityEngine;

namespace SYBO.Common.Data;

[Serializable]
public class StackablePrefabData
{
	private List<GameObject> _prefabs;

	private StackableBuildDirection _stackableBuildDirection;

	public List<GameObject> Prefabs => _prefabs;

	public StackableBuildDirection StackableBuildDirection => _stackableBuildDirection;
}
