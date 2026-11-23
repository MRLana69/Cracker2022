using SYBO.Common.Components.Singleton;
using UnityEngine;

namespace SYBO.Common.Visuals;

public class QualityToggle : MonoBehaviour
{
	private QualityFeature _feature;

	private GameObject _unsupported;

	private GameObject _supported;

	private void Awake()
	{
		//IL_000f: Expected VT, but got Obj
		_00210 val = (_00210)SingletonMonobehavior<>.Instance;
		_unsupported.SetActive(value: true);
		_supported.SetActive(value: false);
	}
}
