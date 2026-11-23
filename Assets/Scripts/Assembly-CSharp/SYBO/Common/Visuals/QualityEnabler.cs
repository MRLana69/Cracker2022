using SYBO.Common.Components.Singleton;
using UnityEngine;

namespace SYBO.Common.Visuals;

public class QualityEnabler : MonoBehaviour
{
	private QualityFeature _feature;

	public QualityFeature Feature => _feature;

	private void OnEnable()
	{
		ApplyQuality();
	}

	public void ApplyQuality()
	{
		//IL_0045: Expected VT, but got Obj
		_00210 val = (_00210)SingletonMonobehavior<>.Instance;
		GameObject gameObject = base.gameObject;
		if (gameObject.activeSelf)
		{
			GameObject gameObject2 = base.gameObject;
			gameObject2.SetActive(value: false);
		}
	}
}
