using UnityEngine;

namespace SYBO.Common.Components;

public class SetActiveComponent : MonoBehaviour
{
	private bool _toggleActiveValue;

	private Timing _toggleActiveTiming = Timing.Start;

	protected void Awake()
	{
		CheckTiming(Timing.Awake);
	}

	protected void Start()
	{
		CheckTiming(Timing.Start);
	}

	protected void CheckTiming(Timing currentUnityTiming)
	{
		if (currentUnityTiming == _toggleActiveTiming)
		{
			GameObject gameObject = base.gameObject;
			gameObject.SetActive(_toggleActiveValue);
		}
	}
}
