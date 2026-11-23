using System;
using UnityEngine;

[Serializable]
public class AudioLoopInfo
{
	public AudioClip[] clips;

	public float minStartTime = 0.4f;

	public float maxStartTime;

	public float minStartPitch;

	public float maxStartPitch = 0.5f;

	public float minStartVolume;

	public float maxStartVolume;

	public float minTargetPitch = 0.8f;

	public float maxTargetPitch;

	public float minTargetVolume = 0.5f;

	public float maxTargatVolume;

	public float minStopTime = 0.4f;

	public float maxStopTime;

	public float minStopPitch;

	public float maxStopPitch = 0.5f;

	public AudioRolloffMode Rollof;
}
