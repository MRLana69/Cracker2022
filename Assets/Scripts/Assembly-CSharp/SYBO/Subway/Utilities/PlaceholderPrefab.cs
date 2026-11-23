using SYBO.Components.Utilities;
using SYBO.Subway.Level;
using UnityEngine;

namespace SYBO.Subway.Utilities;

public class PlaceholderPrefab : MonoBehaviour, IPrefabBehaviour
{
	private TrackObject[] _trackObjects;

	private Selector[] _selectors;

	public TrackObject[] TrackObjects => _trackObjects;

	public Selector[] Selectors => _selectors;

	public void Initialize()
	{
		TrackObject[] componentsInChildren = GetComponentsInChildren<TrackObject>(includeInactive: true);
		_trackObjects = componentsInChildren;
		Selector[] componentsInChildren2 = GetComponentsInChildren<Selector>(includeInactive: true);
		_selectors = componentsInChildren2;
	}
}
