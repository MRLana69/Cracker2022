using System;
using System.Collections.Generic;
using UnityEngine;

public class LetterPickup : MonoBehaviour
{
	public MeshFilter LetterMesh;

	public List<Mesh> Letters;

	public bool shouldSpawnParticles;

	protected char _letterChar;

	public const char NO_LETTER = '\0';

	private void Awake()
	{
		//IL_00bb: Expected I, but got Obj
		//IL_0057: Expected I, but got Obj
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
		NullReferenceException ex = new NullReferenceException();
		Action action = default;
		action._002Ector(this, (IntPtr)ex);
		trackObject.OnActivate += action;
		NullReferenceException ex2 = new NullReferenceException();
		Action action2 = default;
		action2._002Ector(this, (IntPtr)ex2);
		trackObject.OnDeactivate += action2;
	}

	protected virtual void OnActivate()
	{
	}

	protected virtual void OnDeactivate()
	{
	}
}
