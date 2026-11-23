using System;
using UnityEngine;

namespace SYBO.Subway.Level;

[Serializable]
public class TargetWeightPair
{
	private GameObject _target;

	private float _weight;

	public GameObject Target => _target;

	public float Weight => _weight;
}
