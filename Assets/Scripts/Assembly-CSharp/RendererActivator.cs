using System;
using UnityEngine;

public class RendererActivator : MonoBehaviour
{
	public unsafe void Awake()
	{
		TrackObject component = GetComponent<TrackObject>();
		bool flag = (object)component == null;
		bool flag2 = !flag;
		TrackObject trackObject = component;
		if (!flag2)
		{
			GameObject gameObject = base.gameObject;
			TrackObject trackObject2 = gameObject.AddComponent<TrackObject>();
			trackObject = trackObject2;
		}
		Action action = default;
		action._002Ector(this, (nint)__ldftn(RendererActivator.OnActivate));
		trackObject.OnActivate += action;
		Action action2 = default;
		action2._002Ector(this, (nint)__ldftn(RendererActivator.OnDeactivate));
		trackObject.OnDeactivate += action2;
		Renderer component2 = GetComponent<Renderer>();
		component2.enabled = false;
	}

	public void OnActivate()
	{
		Renderer component = GetComponent<Renderer>();
		component.enabled = true;
	}

	public void OnDeactivate()
	{
		Renderer component = GetComponent<Renderer>();
		component.enabled = false;
	}
}
