using System.Collections.Generic;
using UnityEngine;

namespace SYBO.Subway.Placeholders;

public class SynchronizedThemeAsset : MonoBehaviour
{
	private List<Component> _themedComponents;

	public bool _canSynchronize = true;

	public List<Component> ThemedComponents => _themedComponents;

	public bool CanSynchronize
	{
		get
		{
			return _canSynchronize;
		}
		set
		{
			_canSynchronize = value;
		}
	}
}
