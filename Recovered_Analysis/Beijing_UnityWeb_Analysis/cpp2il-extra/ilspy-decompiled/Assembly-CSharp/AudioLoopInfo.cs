using System;
using UnityEngine;

[Serializable]
public class AudioLoopInfo
{
	public AudioClip[] clips;

	public float minStartTime = 0.8f;

	public float maxStartTime = 1.1f;

	public float minStartPitch = 0.5f;

	public float maxStartPitch = 0.7f;

	public float minStartVolume = 1f;

	public float maxStartVolume;

	public float minTargetPitch;

	public float maxTargetPitch;

	public float minTargetVolume;

	public float maxTargatVolume;

	public float minStopTime;

	public float maxStopTime;

	public float minStopPitch;

	public float maxStopPitch;

	public AudioRolloffMode Rollof;

	public AudioLoopInfo()
	{
		//IL_0037: Expected F4, but got I4
	}
}
